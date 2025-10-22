using System;
using System.Collections.Generic;
using System.Text;
using ntoskrnlib.Structure; // for attribute reference in generated code

namespace ntoskrnlib.Gen;

internal sealed class DynamicWrapperGenerator
{
    private readonly TypeInspector _insp;

    public DynamicWrapperGenerator(TypeInspector insp)
    {
        _insp = insp;
    }

    public string Generate(uint typeId, string ns, string moduleSymbolPrefix)
    {
        var nameOriginal = _insp.GetTypeName(typeId);
        var name = TypeSpec.SanitizeIdentifier(nameOriginal);
        var sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine("using ntoskrnlib.Structure;");
        sb.AppendLine();
        sb.AppendLine($"namespace {ns}.Dynamic");
        sb.AppendLine("{");
        sb.AppendLine($"    [DynamicStructure(\"{moduleSymbolPrefix}!{nameOriginal}\")] ");
        sb.AppendLine($"    public sealed class {name} : DynamicStructure");
        sb.AppendLine("    {");
        // Properties as metadata (not used at runtime; offsets dictionary is supplied)
        foreach (var f in _insp.GetUdtFields(typeId))
        {
            var fieldName = TypeSpec.SanitizeIdentifier(f.Name);
            var ts = _insp.ResolveType(f.TypeId);
            var csType = ts.ToCSharpFieldType();
            sb.AppendLine($"        public {csType} {fieldName} {{ get; }}");
        }
        sb.AppendLine();
        sb.AppendLine($"        public {name}(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress) {{ }}");
        sb.AppendLine();
        sb.AppendLine($"        static {name}()");
        sb.AppendLine("        {");
        sb.AppendLine("            var offsets = new Dictionary<string, ulong[]>");
        sb.AppendLine("            {");
        bool first = true;
        foreach (var f in _insp.GetUdtFields(typeId))
        {
            if (!first) sb.AppendLine(","); else first = false;
            var fieldName = TypeSpec.SanitizeIdentifier(f.Name);
            sb.Append($"                {{ nameof({name}.{fieldName}), new []{{ {f.Offset}UL }} }}");
        }
        sb.AppendLine();
        sb.AppendLine("            };");
        sb.AppendLine($"            Register<{name}>((mem, ptr) => new {name}(mem, ptr), offsets);");
        sb.AppendLine("        }");
        sb.AppendLine("    }");
        sb.AppendLine("}");
        return sb.ToString();
    }
}

