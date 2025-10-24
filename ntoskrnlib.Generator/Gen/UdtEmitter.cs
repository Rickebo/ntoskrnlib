using System;
using System.Collections.Generic;
using System.IO;
using ntoskrnlib.Interop;

namespace ntoskrnlib.Gen;

[System.Runtime.Versioning.SupportedOSPlatform("windows")]
internal sealed class UdtEmitter
{
    private readonly TypeInspector _insp;
    private readonly CodeGenerator _gen;
    private readonly DynamicWrapperGenerator? _dyn;
    private readonly string? _ns;
    private readonly string? _moduleSym;

    public UdtEmitter(TypeInspector insp, CodeGenerator gen, DynamicWrapperGenerator? dyn = null, string? @namespace = null, string? moduleSymbolPrefix = null)
    {
        _insp = insp;
        _gen = gen;
        _dyn = dyn;
        _ns = @namespace;
        _moduleSym = moduleSymbolPrefix;
    }

    public int GenerateWithDependencies(uint rootTypeId, string outputDir, bool flatten)
    {
        var queue = new Queue<uint>();
        var seen = new HashSet<uint>();
        queue.Enqueue(rootTypeId);
        int written = 0;
        while (queue.Count > 0)
        {
            var typeId = queue.Dequeue();
            if (!seen.Add(typeId)) continue;
            var name = _insp.GetTypeName(typeId);

            // Generate explicit layout struct
            var code = _gen.GenerateUdt(typeId);
            var fileName = Path.Combine(outputDir, TypeSpec.SanitizeIdentifier(name) + ".g.cs");
            if (!File.Exists(fileName))
            {
                File.WriteAllText(fileName, code);
                written++;
            }

            // Generate class-based structure using Structure namespace
            var classCode = _gen.GenerateUdtAsClass(typeId, _moduleSym);
            var classDir = Path.Combine(outputDir, "Managed");
            Directory.CreateDirectory(classDir);
            var classFile = Path.Combine(classDir, TypeSpec.SanitizeIdentifier(name) + ".managed.g.cs");
            if (!File.Exists(classFile))
            {
                File.WriteAllText(classFile, classCode);
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
                }
            }

            if (!flatten)
            {
                foreach (var f in _insp.GetUdtFields(typeId))
                {
                    var ts = _insp.ResolveType(f.TypeId);
                    if (ts.TryAsUdt(out _, out _))
                    {
                        queue.Enqueue(f.TypeId);
                    }
                }
            }
        }
        return written;
    }
}
