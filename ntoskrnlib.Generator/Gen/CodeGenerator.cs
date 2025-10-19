using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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

        // using directives
        var cu = SyntaxFactory.CompilationUnit()
            .WithUsings(
                SyntaxFactory.List(new UsingDirectiveSyntax[]
                {
                    SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System")),
                    SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Runtime.InteropServices"))
                }));

        // #pragma warning disable CS0649
        var pragma = SyntaxFactory.Trivia(
            SyntaxFactory.PragmaWarningDirectiveTrivia(
                    SyntaxFactory.Token(SyntaxKind.DisableKeyword),
                    isActive: true)
                .WithErrorCodes(
                    SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(
                        SyntaxFactory.IdentifierName("CS0649"))));
        cu = cu.WithLeadingTrivia(pragma, SyntaxFactory.ElasticCarriageReturnLineFeed);

        // StructLayout attribute
        var structLayoutAttr = SyntaxFactory.Attribute(
            SyntaxFactory.ParseName("StructLayout"))
            .WithArgumentList(
                SyntaxFactory.AttributeArgumentList(
                    SyntaxFactory.SeparatedList<AttributeArgumentSyntax>(
                        SyntaxFactory.NodeOrTokenList(
                            SyntaxFactory.AttributeArgument(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    SyntaxFactory.IdentifierName("LayoutKind"),
                                    SyntaxFactory.IdentifierName("Explicit"))),
                            SyntaxFactory.Token(SyntaxKind.CommaToken),
                            SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.LiteralExpression(
                                        SyntaxKind.NumericLiteralExpression,
                                        SyntaxFactory.Literal(checked((int)size))))
                                .WithNameEquals(SyntaxFactory.NameEquals("Size"))
                        ))));

        var structDecl = SyntaxFactory.StructDeclaration(name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword))
            .WithAttributeLists(
                SyntaxFactory.SingletonList(
                    SyntaxFactory.AttributeList(
                        SyntaxFactory.SingletonSeparatedList(structLayoutAttr))));

        // Fields
        var fields = _insp.GetUdtFields(typeId);
        int syntheticBaseIdx = 0;
        foreach (var f in fields)
        {
            var fieldName = f.Tag == DbgHelp.SymTag.BaseClass
                ? $"__base{syntheticBaseIdx++}"
                : TypeSpec.SanitizeIdentifier(f.Name);

            var ts = _insp.ResolveType(f.TypeId);
            TypeSyntax fieldType;
            var attrLists = new System.Collections.Generic.List<AttributeListSyntax>();

            // [FieldOffset(ofs)]
            var fieldOffsetAttr = SyntaxFactory.Attribute(SyntaxFactory.ParseName("FieldOffset"))
                .WithArgumentList(
                    SyntaxFactory.AttributeArgumentList(
                        SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.AttributeArgument(
                                SyntaxFactory.LiteralExpression(
                                    SyntaxKind.NumericLiteralExpression,
                                    SyntaxFactory.Literal((int)f.Offset))))));
            attrLists.Add(SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(fieldOffsetAttr)));

            if (_flattenUdts && ts.TryAsUdt(out var _, out var udtSize))
            {
                // Flatten as byte[] with MarshalAs(ByValArray, SizeConst=...)
                fieldType = SyntaxFactory.ArrayType(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ByteKeyword)))
                    .WithRankSpecifiers(SyntaxFactory.SingletonList(
                        SyntaxFactory.ArrayRankSpecifier(
                            SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(SyntaxFactory.OmittedArraySizeExpression()))));

                attrLists.Add(MarshalAsByValArrayAttributeList(checked((int)udtSize)));
            }
            else if (ts.TryAsArray(out var elemSpec, out var count))
            {
                // Inline arrays: T[] with MarshalAs(ByValArray, SizeConst=count)
                var elemTypeName = elemSpec.ToCSharpFieldType().TrimEnd(']', '[');
                fieldType = SyntaxFactory.ArrayType(TypeFromName(elemTypeName))
                    .WithRankSpecifiers(SyntaxFactory.SingletonList(
                        SyntaxFactory.ArrayRankSpecifier(
                            SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(SyntaxFactory.OmittedArraySizeExpression()))));

                attrLists.Add(MarshalAsByValArrayAttributeList(count));
            }
            else
            {
                fieldType = TypeFromName(ts.ToCSharpFieldType());
            }

            var fieldDecl = SyntaxFactory.FieldDeclaration(
                    SyntaxFactory.VariableDeclaration(fieldType)
                        .WithVariables(SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.VariableDeclarator(SyntaxFactory.Identifier(fieldName)))))
                .WithAttributeLists(SyntaxFactory.List(attrLists))
                .WithModifiers(default); // default: fields are public below

            // Make field public
            fieldDecl = fieldDecl.WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)));
            structDecl = structDecl.AddMembers(fieldDecl);
        }

        MemberDeclarationSyntax topDecl = structDecl;
        if (!string.IsNullOrWhiteSpace(_ns))
        {
            topDecl = SyntaxFactory.FileScopedNamespaceDeclaration(SyntaxFactory.ParseName(_ns!)).AddMembers(structDecl);
        }

        cu = cu.AddMembers(topDecl);
        return cu.NormalizeWhitespace().ToFullString();
    }

    private static TypeSyntax TypeFromName(string csType)
    {
        return csType switch
        {
            "byte" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ByteKeyword)),
            "sbyte" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.SByteKeyword)),
            "short" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ShortKeyword)),
            "ushort" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.UShortKeyword)),
            "int" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.IntKeyword)),
            "uint" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.UIntKeyword)),
            "long" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.LongKeyword)),
            "ulong" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ULongKeyword)),
            "float" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.FloatKeyword)),
            "double" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.DoubleKeyword)),
            "decimal" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.DecimalKeyword)),
            "bool" => SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.BoolKeyword)),
            "IntPtr" => SyntaxFactory.IdentifierName("IntPtr"),
            _ => SyntaxFactory.IdentifierName(csType)
        };
    }

    private static AttributeListSyntax MarshalAsByValArrayAttributeList(int sizeConst)
    {
        var args = SyntaxFactory.SeparatedList<AttributeArgumentSyntax>(
            SyntaxFactory.NodeOrTokenList(
                SyntaxFactory.AttributeArgument(
                    SyntaxFactory.MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        SyntaxFactory.IdentifierName("UnmanagedType"),
                        SyntaxFactory.IdentifierName("ByValArray"))),
                SyntaxFactory.Token(SyntaxKind.CommaToken),
                SyntaxFactory.AttributeArgument(
                        SyntaxFactory.LiteralExpression(
                            SyntaxKind.NumericLiteralExpression,
                            SyntaxFactory.Literal(sizeConst)))
                    .WithNameEquals(SyntaxFactory.NameEquals("SizeConst"))
            ));

        var attr = SyntaxFactory.Attribute(SyntaxFactory.ParseName("MarshalAs"))
            .WithArgumentList(SyntaxFactory.AttributeArgumentList(args));
        return SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(attr));
    }
}
