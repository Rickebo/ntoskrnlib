using System;
using System.Collections.Generic;
using System.IO;
using Dia2Lib;

namespace ntoskrnlib.Gen;

internal sealed class DiaEmitter
{
    private readonly DiaInspector _dia;

    public DiaEmitter(DiaInspector dia)
    {
        _dia = dia;
    }

    public int GenerateWithDependencies(string rootDisplayName, string outputDir, bool flatten)
    {
        var root = _dia.FindUdt(rootDisplayName);
        if (root == null) return 0;

        var queue = new Queue<(string displayName, IDiaSymbol sym)>();
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        string rootName = rootDisplayName.Contains('!') ? rootDisplayName.Split('!')[1] : rootDisplayName;
        queue.Enqueue((rootName, root));
        int written = 0;

        while (queue.Count > 0)
        {
            var (disp, sym) = queue.Dequeue();
            var typeName = sym.name ?? disp;
            if (!seen.Add(typeName)) continue;

            var code = ProgramHelpers.GenerateFromDia(typeName, _dia, sym, flatten);
            var file = Path.Combine(outputDir, ProgramHelpers.Sanitize(typeName) + ".g.cs");
            File.WriteAllText(file, code);
            written++;

            if (!flatten)
            {
                foreach (var (_, _, ftype) in _dia.GetFields(sym))
                {
                    var target = UnwrapToUdt(ftype);
                    if (target != null && target.name is string dn && !seen.Contains(dn))
                    {
                        queue.Enqueue((dn, target));
                    }
                }
            }
        }

        return written;
    }

    private static IDiaSymbol? UnwrapToUdt(IDiaSymbol t)
    {
        // Follow pointers/arrays to the element type
        while (true)
        {
            var tag = (SymTagEnum)t.symTag;
            if (tag == SymTagEnum.SymTagPointerType || tag == SymTagEnum.SymTagArrayType)
            {
                var next = t.type;
                if (next == null) return null;
                t = next;
                continue;
            }
            break;
        }
        return (SymTagEnum)t.symTag == SymTagEnum.SymTagUDT ? t : null;
    }
}

