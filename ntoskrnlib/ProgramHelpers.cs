using System;
using System.Runtime.Versioning;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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

        var cu = SyntaxFactory.CompilationUnit()
            .WithUsings(SyntaxFactory.List(new UsingDirectiveSyntax[]
            {
                SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System")),
                SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Runtime.InteropServices"))
            }));

        var pragma = SyntaxFactory.Trivia(
            SyntaxFactory.PragmaWarningDirectiveTrivia(
                    SyntaxFactory.Token(SyntaxKind.DisableKeyword), true)
                .WithErrorCodes(
                    SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(
                        SyntaxFactory.IdentifierName("CS0649"))));
        cu = cu.WithLeadingTrivia(pragma, SyntaxFactory.ElasticCarriageReturnLineFeed);

        var structLayoutAttr = SyntaxFactory.Attribute(SyntaxFactory.ParseName("StructLayout"))
            .WithArgumentList(
                SyntaxFactory.AttributeArgumentList(
                    SyntaxFactory.SeparatedList<AttributeArgumentSyntax>(
                        SyntaxFactory.NodeOrTokenList(
                            SyntaxFactory.AttributeArgument(
                                SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                                    SyntaxFactory.IdentifierName("LayoutKind"),
                                    SyntaxFactory.IdentifierName("Explicit"))),
                            SyntaxFactory.Token(SyntaxKind.CommaToken),
                            SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, SyntaxFactory.Literal((int)size)))
                                .WithNameEquals(SyntaxFactory.NameEquals("Size"))
                        ))));

        var structDecl = SyntaxFactory.StructDeclaration(name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .WithAttributeLists(
                SyntaxFactory.SingletonList(
                    SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(structLayoutAttr))));

        foreach (var (fname, ofs, ftype) in dia.GetFields(udt))
        {
            var fieldName = TypeSpec.SanitizeIdentifier(fname);
            var tag = (Dia2Lib.SymTagEnum)ftype.symTag;

            var fieldOffsetAttr = SyntaxFactory.Attribute(SyntaxFactory.ParseName("FieldOffset"))
                .WithArgumentList(SyntaxFactory.AttributeArgumentList(
                    SyntaxFactory.SingletonSeparatedList(
                        SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(
                            SyntaxKind.NumericLiteralExpression, SyntaxFactory.Literal((int)ofs))))));

            var attrLists = new System.Collections.Generic.List<AttributeListSyntax>
            {
                SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(fieldOffsetAttr))
            };

            TypeSyntax fieldType;
            switch (tag)
            {
                case Dia2Lib.SymTagEnum.SymTagPointerType:
                    fieldType = SyntaxFactory.IdentifierName("IntPtr");
                    break;
                case Dia2Lib.SymTagEnum.SymTagBaseType:
                    fieldType = BaseTypeFromDia(ftype);
                    break;
                case Dia2Lib.SymTagEnum.SymTagUDT:
                    if (flatten)
                    {
                        fieldType = SyntaxFactory.ArrayType(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ByteKeyword)))
                            .WithRankSpecifiers(SyntaxFactory.SingletonList(
                                SyntaxFactory.ArrayRankSpecifier(
                                    SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(SyntaxFactory.OmittedArraySizeExpression()))));
                        var margs1 = SyntaxFactory.SeparatedList<AttributeArgumentSyntax>(
                            SyntaxFactory.NodeOrTokenList(
                                SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        SyntaxFactory.IdentifierName("UnmanagedType"),
                                        SyntaxFactory.IdentifierName("ByValArray"))),
                                SyntaxFactory.Token(SyntaxKind.CommaToken),
                                SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, SyntaxFactory.Literal((int)ftype.length)))
                                    .WithNameEquals(SyntaxFactory.NameEquals("SizeConst"))
                            ));
                        var marshalAttr = SyntaxFactory.Attribute(SyntaxFactory.ParseName("MarshalAs"))
                            .WithArgumentList(SyntaxFactory.AttributeArgumentList(margs1));
                        attrLists.Add(SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(marshalAttr)));
                    }
                    else
                    {
                        fieldType = SyntaxFactory.IdentifierName(TypeSpec.SanitizeIdentifier(ftype.name ?? "Anon"));
                    }
                    break;
                case Dia2Lib.SymTagEnum.SymTagArrayType:
                    {
                        var al = ftype.length;
                        var elem = ftype.type;
                        var elemType = elem != null && (Dia2Lib.SymTagEnum)elem.symTag == Dia2Lib.SymTagEnum.SymTagBaseType
                            ? BaseTypeFromDia(elem)
                            : SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ByteKeyword));
                        int elemSize = elem == null ? 1 : (int)DiaInspector.GetTypeLength(elem);
                        int count = Math.Max(1, (int)((long)al / Math.Max(1, elemSize)));
                        fieldType = SyntaxFactory.ArrayType(elemType)
                            .WithRankSpecifiers(SyntaxFactory.SingletonList(
                                SyntaxFactory.ArrayRankSpecifier(
                                    SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(SyntaxFactory.OmittedArraySizeExpression()))));
                        var margs2 = SyntaxFactory.SeparatedList<AttributeArgumentSyntax>(
                            SyntaxFactory.NodeOrTokenList(
                                SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        SyntaxFactory.IdentifierName("UnmanagedType"),
                                        SyntaxFactory.IdentifierName("ByValArray"))),
                                SyntaxFactory.Token(SyntaxKind.CommaToken),
                                SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, SyntaxFactory.Literal(count)))
                                    .WithNameEquals(SyntaxFactory.NameEquals("SizeConst"))
                            ));
                        var marshalAttr = SyntaxFactory.Attribute(SyntaxFactory.ParseName("MarshalAs"))
                            .WithArgumentList(SyntaxFactory.AttributeArgumentList(margs2));
                        attrLists.Add(SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(marshalAttr)));
                        break;
                    }
                default:
                    fieldType = SyntaxFactory.IdentifierName("IntPtr");
                    break;
            }

            var fieldDecl = SyntaxFactory.FieldDeclaration(
                    SyntaxFactory.VariableDeclaration(fieldType)
                        .WithVariables(SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.VariableDeclarator(SyntaxFactory.Identifier(fieldName)))))
                .WithAttributeLists(SyntaxFactory.List(attrLists))
                .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)));
            var structWithField = structDecl.AddMembers(fieldDecl);
            structDecl = structWithField;
        }

        cu = cu.AddMembers(structDecl);
        return cu.NormalizeWhitespace().ToFullString();
    }

    private static TypeSyntax BaseTypeFromDia(Dia2Lib.IDiaSymbol t)
    {
        string cs = t.length switch
        {
            1 => t.baseType == 7 || t.baseType == 14 ? "byte" : "sbyte",
            2 => t.baseType == 7 || t.baseType == 14 ? "ushort" : "short",
            4 => t.baseType == 7 || t.baseType == 14 ? "uint" : "int",
            8 => t.baseType == 7 || t.baseType == 14 ? "ulong" : "long",
            _ => "byte"
        };
        return cs switch
        {
            "byte" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ByteKeyword)),
            "sbyte" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.SByteKeyword)),
            "short" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ShortKeyword)),
            "ushort" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.UShortKeyword)),
            "int" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.IntKeyword)),
            "uint" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.UIntKeyword)),
            "long" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.LongKeyword)),
            "ulong" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ULongKeyword)),
            _ => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ByteKeyword))
        };
    }
}
