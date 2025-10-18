using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ntoskrnlib.Interop;
using ntoskrnlib.Symbols;

namespace ntoskrnlib.Gen;

internal sealed class CodeGenerator
{
    private readonly TypeInspector _insp;
    private readonly bool _flattenUdts;
    private readonly string? _ns;
    public CodeGenerator(TypeInspector insp, bool flattenUdts = false, string? @namespace = null)
    {
        _insp = insp;
        _flattenUdts = flattenUdts;
        _ns = @namespace;
    }

    public string GenerateUdt(uint typeId)
    {
        var name = TypeSpec.SanitizeIdentifier(_insp.GetTypeName(typeId));
        var size = _insp.GetTypeLength(typeId);
        var sb = new StringBuilder();
        if (!string.IsNullOrWhiteSpace(_ns))
        {
            sb.AppendLine($"namespace {_ns};");
            sb.AppendLine();
        }
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Runtime.InteropServices;");
        sb.AppendLine();
        sb.AppendLine("#pragma warning disable 0649 // Field is never assigned");
        sb.AppendLine($"[StructLayout(LayoutKind.Explicit, Size={(long)size})]");
        sb.AppendLine($"public partial struct {name}");
        sb.AppendLine("{");

        var fields = _insp.GetUdtFields(typeId);
        int syntheticBaseIdx = 0;
        foreach (var f in fields)
        {
            var fieldName = f.Tag == DbgHelp.SymTag.BaseClass
                ? $"__base{syntheticBaseIdx++}"
                : TypeSpec.SanitizeIdentifier(f.Name);

            var ts = _insp.ResolveType(f.TypeId);
            string csType = ts.ToCSharpFieldType();

            sb.AppendLine($"    [FieldOffset({f.Offset})]");
            if (_flattenUdts && ts.TryAsUdt(out var udtName, out var udtSize))
            {
                sb.AppendLine($"    [MarshalAs(UnmanagedType.ByValArray, SizeConst={(int)udtSize})]");
                sb.AppendLine($"    public byte[] {fieldName};");
            }
            else if (ts.TryAsArray(out var elemSpec, out var count))
            {
                // Marshal fixed-size inline array
                // Determine element type name
                string elemType = elemSpec.ToCSharpFieldType().TrimEnd('[' ,']');
                sb.AppendLine($"    [MarshalAs(UnmanagedType.ByValArray, SizeConst={count})]");
                sb.AppendLine($"    public {elemType}[] {fieldName};");
            }
            else
            {
                sb.AppendLine($"    public {csType} {fieldName};");
            }
            sb.AppendLine();
        }

        sb.AppendLine("}");
        return sb.ToString();
    }
}
