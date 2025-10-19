using System;
using System.Collections.Generic;
using System.IO;
using ntoskrnlib.Interop;

namespace ntoskrnlib.Gen;

internal sealed class UdtEmitter
{
    private readonly TypeInspector _insp;
    private readonly CodeGenerator _gen;

    public UdtEmitter(TypeInspector insp, CodeGenerator gen)
    {
        _insp = insp;
        _gen = gen;
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
            var code = _gen.GenerateUdt(typeId);
            var fileName = Path.Combine(outputDir, TypeSpec.SanitizeIdentifier(name) + ".g.cs");
            File.WriteAllText(fileName, code);
            written++;

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

