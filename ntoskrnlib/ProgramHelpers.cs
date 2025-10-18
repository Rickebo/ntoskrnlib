using System;
using System.Runtime.Versioning;
using ntoskrnlib.Gen;

namespace ntoskrnlib;

internal static class ProgramHelpers
{
    public static string Sanitize(string name)
    {
        var sb = new System.Text.StringBuilder(name.Length);
        foreach (var ch in name)
        {
            if (char.IsLetterOrDigit(ch) || ch == '_') sb.Append(ch); else sb.Append('_');
        }
        return sb.ToString();
    }

    [SupportedOSPlatform("windows")]
    public static string GenerateFromDia(string displayName, DiaInspector dia, Dia2Lib.IDiaSymbol udt, bool flatten)
    {
        var name = TypeSpec.SanitizeIdentifier(displayName.Contains('!') ? displayName.Split('!')[1] : displayName);
        var size = DiaInspector.GetTypeLength(udt);
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Runtime.InteropServices;");
        sb.AppendLine();
        sb.AppendLine("#pragma warning disable 0649 // Field is never assigned");
        sb.AppendLine($"[StructLayout(LayoutKind.Explicit, Size={(long)size})]");
        sb.AppendLine($"public struct {name}");
        sb.AppendLine("{");
        foreach (var (fname, ofs, ftype) in dia.GetFields(udt))
        {
            string fieldName = TypeSpec.SanitizeIdentifier(fname);
            var tag = (Dia2Lib.SymTagEnum)ftype.symTag;
            string csType = "IntPtr";
            switch (tag)
            {
                case Dia2Lib.SymTagEnum.SymTagPointerType:
                    csType = "IntPtr"; break;
                case Dia2Lib.SymTagEnum.SymTagBaseType:
                    csType = ftype.length switch
                    {
                        1 => ftype.baseType == 7 || ftype.baseType == 14 ? "byte" : "sbyte",
                        2 => ftype.baseType == 7 || ftype.baseType == 14 ? "ushort" : "short",
                        4 => ftype.baseType == 7 || ftype.baseType == 14 ? "uint" : "int",
                        8 => ftype.baseType == 7 || ftype.baseType == 14 ? "ulong" : "long",
                        _ => "byte"
                    };
                    break;
                case Dia2Lib.SymTagEnum.SymTagUDT:
                    if (flatten)
                    {
                        var usz = ftype.length;
                        sb.AppendLine($"    [FieldOffset({ofs})]");
                        sb.AppendLine($"    [MarshalAs(UnmanagedType.ByValArray, SizeConst={(int)usz})]");
                        sb.AppendLine($"    public byte[] {fieldName};");
                        continue;
                    }
                    csType = TypeSpec.SanitizeIdentifier(ftype.name ?? "Anon");
                    break;
                case Dia2Lib.SymTagEnum.SymTagArrayType:
                    var al = ftype.length;
                    var elem = ftype.type;
                    string elemCs = "byte";
                    if (elem != null && (Dia2Lib.SymTagEnum)elem.symTag == Dia2Lib.SymTagEnum.SymTagBaseType)
                    {
                        elemCs = elem.length switch
                        {
                            1 => elem.baseType == 7 || elem.baseType == 14 ? "byte" : "sbyte",
                            2 => elem.baseType == 7 || elem.baseType == 14 ? "ushort" : "short",
                            4 => elem.baseType == 7 || elem.baseType == 14 ? "uint" : "int",
                            8 => elem.baseType == 7 || elem.baseType == 14 ? "ulong" : "long",
                            _ => "byte"
                        };
                    }
                    int count = (int)(al / Math.Max(1, (elem == null ? 1 : DiaInspector.GetTypeLength(elem))));
                    sb.AppendLine($"    [FieldOffset({ofs})]");
                    sb.AppendLine($"    [MarshalAs(UnmanagedType.ByValArray, SizeConst={count})]");
                    sb.AppendLine($"    public {elemCs}[] {fieldName};");
                    continue;
            }
            sb.AppendLine($"    [FieldOffset({ofs})]");
            sb.AppendLine($"    public {csType} {fieldName};");
        }
        sb.AppendLine("}");
        return sb.ToString();
    }
}

