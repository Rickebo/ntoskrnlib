using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Logging;
using ntoskrnlib.Interop;

namespace ntoskrnlib.Gen;

[System.Runtime.Versioning.SupportedOSPlatform("windows")]
internal sealed class UdtEmitter
{
    private readonly ILogger<UdtEmitter> _logger;
    private readonly TypeInspector _insp;
    private readonly CodeGenerator _gen;
    private readonly DynamicWrapperGenerator? _dyn;
    private readonly string? _ns;
    private readonly string? _moduleSym;

    public UdtEmitter(ILogger<UdtEmitter> logger, TypeInspector insp, CodeGenerator gen, DynamicWrapperGenerator? dyn = null, string? @namespace = null, string? moduleSymbolPrefix = null)
    {
        _logger = logger;
        _insp = insp;
        _gen = gen;
        _dyn = dyn;
        _ns = @namespace;
        _moduleSym = moduleSymbolPrefix;
    }

    public int GenerateWithDependencies(uint rootTypeId, string outputDir, bool flatten)
    {
        var rootName = _insp.GetTypeName(rootTypeId);
        _logger.LogInformation("Starting generation for root type {name} ({id}) into {dir}", rootName, rootTypeId, outputDir);

        var queue = new Queue<uint>();
        var seen = new HashSet<uint>();
        queue.Enqueue(rootTypeId);
        int written = 0;
        while (queue.Count > 0)
        {
            var typeId = queue.Dequeue();
            if (!seen.Add(typeId)) continue;
            var name = _insp.GetTypeName(typeId);

            _logger.LogDebug("Emitting type {name} ({id})", name, typeId);

            // Generate explicit layout struct
            var code = _gen.GenerateUdt(typeId);
            var fileName = Path.Combine(outputDir, TypeSpec.SanitizeIdentifier(name) + ".g.cs");
            if (!File.Exists(fileName))
            {
                File.WriteAllText(fileName, code);
                _logger.LogDebug("Wrote struct {name} to {file}", name, fileName);
                written++;
            }
            else
            {
                _logger.LogTrace("Struct file already existed for {name}; skipping write", name);
            }

            // Generate class-based structure using Structure namespace
            try
            {
                var classCode = _gen.GenerateUdtAsClass(typeId, _moduleSym);
                var className = CodeGenerator.ToCSharpClassName(TypeSpec.SanitizeIdentifier(name));
                if (string.IsNullOrWhiteSpace(className))
                {
                    className = $"Type{typeId}";
                }
                else if (char.IsDigit(className[0]))
                {
                    className = "_" + className;
                }
                var classDir = Path.Combine(outputDir, "Managed");
                Directory.CreateDirectory(classDir);
                var classFile = Path.Combine(classDir, className + ".managed.g.cs");
                if (!File.Exists(classFile))
                {
                    File.WriteAllText(classFile, classCode);
                    _logger.LogDebug("Wrote managed wrapper {className} to {file}", className, classFile);
                }
                else
                {
                    _logger.LogTrace("Managed wrapper already existed for {className}; skipping write", className);
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "Failed to generate managed class for {name}", name);
            }

            if (_dyn != null && _ns != null && _moduleSym != null)
            {
                var dcode = _dyn.Generate(typeId, _ns, _moduleSym);
                var ddir = Path.Combine(outputDir, "Dynamic");
                Directory.CreateDirectory(ddir);
                var dfile = Path.Combine(ddir, TypeSpec.SanitizeIdentifier(name) + ".dynamic.g.cs");
                if (!File.Exists(dfile))
                {
                    File.WriteAllText(dfile, dcode);
                    _logger.LogDebug("Wrote dynamic wrapper for {name} to {file}", name, dfile);
                }
                else
                {
                    _logger.LogTrace("Dynamic wrapper already existed for {name}; skipping write", name);
                }
            }

            if (!flatten)
            {
                foreach (var f in _insp.GetUdtFields(typeId))
                {
                    var ts = _insp.ResolveType(f.TypeId);
                    if (ts.TryAsUdt(out _, out _))
                    {
                        _logger.LogTrace("Queueing dependency {dep} ({id})", _insp.GetTypeName(f.TypeId), f.TypeId);
                        queue.Enqueue(f.TypeId);
                    }
                }
            }
        }
        _logger.LogInformation("Finished generation for root type {name}; {count} struct file(s) written", rootName, written);
        return written;
    }
}
