using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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

        if (!string.IsNullOrWhiteSpace(_ns))
        {
            var nsDecl = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(_ns!))
                .AddMembers(structDecl);
            cu = cu.AddMembers(nsDecl);
        }
        else
        {
            cu = cu.AddMembers(structDecl);
        }
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

    /// <summary>
    /// Converts a Windows-style type name to C# PascalCase naming convention.
    /// Examples: _EPROCESS -> Eprocess, _RTL_USER_PROCESS_PARAMETERS -> RtlUserProcessParameters
    /// </summary>
    public static string ToCSharpClassName(string typeName)
    {
        // Remove leading underscores
        var cleaned = typeName.TrimStart('_');

        // Split on underscores
        var parts = cleaned.Split('_', StringSplitOptions.RemoveEmptyEntries);

        // Convert each part to PascalCase
        var result = new StringBuilder();
        foreach (var part in parts)
        {
            if (part.Length == 0) continue;

            // If the part is all uppercase or all lowercase, capitalize first letter and lowercase the rest
            if (part.All(char.IsUpper) || part.All(char.IsLower))
            {
                result.Append(char.ToUpperInvariant(part[0]));
                if (part.Length > 1)
                    result.Append(part.Substring(1).ToLowerInvariant());
            }
            else
            {
                // Mixed case, keep as is
                result.Append(part);
            }
        }

        return result.ToString();
    }

    /// <summary>
    /// Generates a class-based structure that inherits from DynamicStructure using Roslyn.
    /// This provides a managed, reflection-based alternative to the explicit layout struct.
    /// </summary>
    public string GenerateUdtAsClass(uint typeId, string? moduleSymbolPrefix = null)
    {
        var nameOriginal = _insp.GetTypeName(typeId);
        var className = ToCSharpClassName(nameOriginal);

        // compilation unit with usings
        var cu = SyntaxFactory.CompilationUnit()
            .WithUsings(
                SyntaxFactory.List(new UsingDirectiveSyntax[]
                {
                    SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System")),
                    SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Collections.Generic")),
                    SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("ntoskrnlib.Structure"))
                }));

        // [DynamicStructure("module!Type")] attribute
        var symbolName = !string.IsNullOrWhiteSpace(moduleSymbolPrefix)
            ? $"{moduleSymbolPrefix}!{nameOriginal}"
            : nameOriginal;
        var dynAttr = SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("DynamicStructure"))
            .WithArgumentList(
                SyntaxFactory.AttributeArgumentList(
                    SyntaxFactory.SingletonSeparatedList(
                        SyntaxFactory.AttributeArgument(
                            SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(symbolName))))));

        // class declaration sealed : DynamicStructure
        var classDecl = SyntaxFactory.ClassDeclaration(className)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.SealedKeyword))
            .WithBaseList(
                SyntaxFactory.BaseList(
                    SyntaxFactory.SingletonSeparatedList<BaseTypeSyntax>(
                        SyntaxFactory.SimpleBaseType(SyntaxFactory.IdentifierName("DynamicStructure")))))
            .WithAttributeLists(SyntaxFactory.SingletonList(SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(dynAttr))));

        // properties with [Offset] attribute
        int syntheticBaseIdx = 0;
        foreach (var f in _insp.GetUdtFields(typeId))
        {
            var fieldName = f.Tag == DbgHelp.SymTag.BaseClass
                ? $"__base{syntheticBaseIdx++}"
                : TypeSpec.SanitizeIdentifier(f.Name);

            var ts = _insp.ResolveType(f.TypeId);
            TypeSyntax propType;
            var attrLists = new List<AttributeListSyntax>();

            // [Offset(ofsUL)]
            var offsetAttr = SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("Offset"))
                .WithArgumentList(
                    SyntaxFactory.AttributeArgumentList(
                        SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.AttributeArgument(
                                SyntaxFactory.ParseExpression($"{f.Offset}UL")))));
            attrLists.Add(SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(offsetAttr)));

            if (_flattenUdts && ts.TryAsUdt(out _, out var udtSize))
            {
                propType = SyntaxFactory.ArrayType(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ByteKeyword)))
                    .WithRankSpecifiers(SyntaxFactory.SingletonList(
                        SyntaxFactory.ArrayRankSpecifier(
                            SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(SyntaxFactory.OmittedArraySizeExpression()))));
            }
            else if (ts.TryAsArray(out var elemSpec, out var _))
            {
                var elemTypeName = elemSpec.ToCSharpFieldType().TrimEnd(']', '[');
                propType = SyntaxFactory.ArrayType(TypeFromName(elemTypeName))
                    .WithRankSpecifiers(SyntaxFactory.SingletonList(
                        SyntaxFactory.ArrayRankSpecifier(
                            SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(SyntaxFactory.OmittedArraySizeExpression()))));
            }
            else
            {
                propType = TypeFromName(ts.ToCSharpFieldType());
            }

            var propDecl = SyntaxFactory.PropertyDeclaration(propType, SyntaxFactory.Identifier(fieldName))
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .WithAccessorList(
                    SyntaxFactory.AccessorList(
                        SyntaxFactory.List(new[]
                        {
                            SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                            SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                        })))
                .WithAttributeLists(SyntaxFactory.List(attrLists));

            classDecl = classDecl.AddMembers(propDecl);
        }

        // ctor: (IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress) { }
        var ctorDecl = SyntaxFactory.ConstructorDeclaration(className)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .WithParameterList(
                SyntaxFactory.ParameterList(
                    SyntaxFactory.SeparatedList(new[]
                    {
                        SyntaxFactory.Parameter(SyntaxFactory.Identifier("memory")).WithType(SyntaxFactory.IdentifierName("IMemorySource")),
                        SyntaxFactory.Parameter(SyntaxFactory.Identifier("baseAddress")).WithType(SyntaxFactory.IdentifierName("MemoryPointer"))
                    })))
            .WithInitializer(
                SyntaxFactory.ConstructorInitializer(
                    SyntaxKind.BaseConstructorInitializer,
                    SyntaxFactory.ArgumentList(
                        SyntaxFactory.SeparatedList(new[]
                        {
                            SyntaxFactory.Argument(SyntaxFactory.IdentifierName("memory")),
                            SyntaxFactory.Argument(SyntaxFactory.IdentifierName("baseAddress"))
                        }))))
            .WithBody(SyntaxFactory.Block());
        classDecl = classDecl.AddMembers(ctorDecl);

        // [RegisterMethod] public static void Register() { DynamicStructure.Register<ClassName>(); }
        var regAttr = SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("RegisterMethod"));
        var registerMethod = SyntaxFactory.MethodDeclaration(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.VoidKeyword)), "Register")
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword))
            .WithAttributeLists(SyntaxFactory.SingletonList(SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(regAttr))))
            .WithBody(
                SyntaxFactory.Block(
                    SyntaxFactory.ExpressionStatement(
                        SyntaxFactory.InvocationExpression(
                                SyntaxFactory.GenericName("DynamicStructure.Register")
                                    .WithTypeArgumentList(
                                        SyntaxFactory.TypeArgumentList(
                                            SyntaxFactory.SingletonSeparatedList<TypeSyntax>(
                                                SyntaxFactory.IdentifierName(className)))))
                            .WithArgumentList(SyntaxFactory.ArgumentList()))));
        classDecl = classDecl.AddMembers(registerMethod);

        if (!string.IsNullOrWhiteSpace(_ns))
        {
            var nsDecl = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(_ns!)).AddMembers(classDecl);
            cu = cu.AddMembers(nsDecl);
        }
        else
        {
            cu = cu.AddMembers(classDecl);
        }

        return cu.NormalizeWhitespace().ToFullString();
    }
}
