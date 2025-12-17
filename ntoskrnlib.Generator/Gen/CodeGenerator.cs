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

            // Skip fields with invalid names
            if (f.Tag != DbgHelp.SymTag.BaseClass &&
                (string.IsNullOrWhiteSpace(f.Name) ||
                 f.Name.StartsWith("<") ||
                 f.Name.StartsWith("__unnamed", StringComparison.OrdinalIgnoreCase)))
            {
                continue;
            }

            var ts = _insp.ResolveType(f.TypeId);

            // Skip fields with invalid type names (UDTs that reference unnamed types)
            if (!_flattenUdts && IsInvalidTypeSpec(ts))
            {
                continue;
            }
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
        // Some PDB types are named like "<unnamed-tag>" which is not a valid C# identifier or filename.
        // Derive a safe name for the managed wrapper from a sanitized identifier.
        var safeName = TypeSpec.SanitizeIdentifier(nameOriginal);
        var className = ToCSharpClassName(safeName);
        if (string.IsNullOrWhiteSpace(className))
        {
            className = $"Type{typeId}";
        }
        else if (char.IsDigit(className[0]))
        {
            className = "_" + className;
        }

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

            // Skip fields with invalid names
            if (f.Tag != DbgHelp.SymTag.BaseClass &&
                (string.IsNullOrWhiteSpace(f.Name) ||
                 f.Name.StartsWith("<") ||
                 f.Name.StartsWith("__unnamed", StringComparison.OrdinalIgnoreCase)))
            {
                continue;
            }

            var ts = _insp.ResolveType(f.TypeId);

            // Skip fields with invalid type names (UDTs that reference unnamed types)
            if (!_flattenUdts && IsInvalidTypeSpec(ts))
            {
                continue;
            }

            // Check if property name matches the enclosing type name
            if (string.Equals(fieldName, className, StringComparison.OrdinalIgnoreCase) && f.Tag != DbgHelp.SymTag.BaseClass)
            {
                fieldName = "Base" + fieldName;
            }
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
                // Flattened UDTs use DynamicArray
                propType = SyntaxFactory.IdentifierName("DynamicArray");

                // Add Length attribute for flattened UDTs
                var lengthAttr = SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("Length"))
                    .WithArgumentList(
                        SyntaxFactory.AttributeArgumentList(
                            SyntaxFactory.SingletonSeparatedList(
                                SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.LiteralExpression(
                                        SyntaxKind.NumericLiteralExpression,
                                        SyntaxFactory.Literal((int)udtSize))))));
                attrLists.Add(SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(lengthAttr)));
            }
            else if (ts.TryAsArray(out var elemSpec, out var arrayCount))
            {
                // Arrays use DynamicArray
                propType = SyntaxFactory.IdentifierName("DynamicArray");

                // Add Length attribute for arrays
                var lengthAttr = SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("Length"))
                    .WithArgumentList(
                        SyntaxFactory.AttributeArgumentList(
                            SyntaxFactory.SingletonSeparatedList(
                                SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.LiteralExpression(
                                        SyntaxKind.NumericLiteralExpression,
                                        SyntaxFactory.Literal((int)arrayCount))))));
                attrLists.Add(SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(lengthAttr)));
            }
            else if (ts.TryAsUdt(out var udtName, out _))
            {
                // For managed classes, use the managed class name (PascalCase)
                var managedClassName = ToCSharpClassName(udtName);
                propType = TypeFromName(managedClassName);
            }
            else
            {
                propType = TypeFromName(ts.ToCSharpFieldType());
            }

            PropertyDeclarationSyntax propDecl;

            // Determine if this is a managed UDT type or array (both use DynamicStructure)
            bool isManagedUdt = (!_flattenUdts && ts.TryAsUdt(out _, out _)) || ts.TryAsArray(out _, out _) || (_flattenUdts && ts.TryAsUdt(out _, out _));

            if (isManagedUdt)
            {
                // For managed class properties: use ReadStructure<T>(nameof(PropertyName)) and WriteStructure(nameof(PropertyName), value)
                var getter = SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                    .WithExpressionBody(
                        SyntaxFactory.ArrowExpressionClause(
                            SyntaxFactory.InvocationExpression(
                                SyntaxFactory.GenericName("ReadStructure")
                                    .WithTypeArgumentList(
                                        SyntaxFactory.TypeArgumentList(
                                            SyntaxFactory.SingletonSeparatedList(propType))))
                                .WithArgumentList(
                                    SyntaxFactory.ArgumentList(
                                        SyntaxFactory.SingletonSeparatedList(
                                            SyntaxFactory.Argument(
                                                SyntaxFactory.InvocationExpression(
                                                    SyntaxFactory.IdentifierName("nameof"))
                                                    .WithArgumentList(
                                                        SyntaxFactory.ArgumentList(
                                                            SyntaxFactory.SingletonSeparatedList(
                                                                SyntaxFactory.Argument(
                                                                    SyntaxFactory.IdentifierName(fieldName)))))))))))
                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

                var setter = SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                    .WithExpressionBody(
                        SyntaxFactory.ArrowExpressionClause(
                            SyntaxFactory.InvocationExpression(
                                SyntaxFactory.IdentifierName("WriteStructure"))
                                .WithArgumentList(
                                    SyntaxFactory.ArgumentList(
                                        SyntaxFactory.SeparatedList(new[]
                                        {
                                            SyntaxFactory.Argument(
                                                SyntaxFactory.InvocationExpression(
                                                    SyntaxFactory.IdentifierName("nameof"))
                                                    .WithArgumentList(
                                                        SyntaxFactory.ArgumentList(
                                                            SyntaxFactory.SingletonSeparatedList(
                                                                SyntaxFactory.Argument(
                                                                    SyntaxFactory.IdentifierName(fieldName)))))),
                                            SyntaxFactory.Argument(SyntaxFactory.IdentifierName("value"))
                                        })))))
                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

                propDecl = SyntaxFactory.PropertyDeclaration(propType, SyntaxFactory.Identifier(fieldName))
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                    .WithAccessorList(
                        SyntaxFactory.AccessorList(
                            SyntaxFactory.List(new[] { getter, setter })))
                    .WithAttributeLists(SyntaxFactory.List(attrLists));
            }
            else
            {
                // For primitive types, structs, and arrays: use ReadHere<T>(nameof(PropertyName)) and WriteHere(nameof(PropertyName), value)
                var getter = SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                    .WithExpressionBody(
                        SyntaxFactory.ArrowExpressionClause(
                            SyntaxFactory.InvocationExpression(
                                SyntaxFactory.GenericName("ReadHere")
                                    .WithTypeArgumentList(
                                        SyntaxFactory.TypeArgumentList(
                                            SyntaxFactory.SingletonSeparatedList(propType))))
                                .WithArgumentList(
                                    SyntaxFactory.ArgumentList(
                                        SyntaxFactory.SingletonSeparatedList(
                                            SyntaxFactory.Argument(
                                                SyntaxFactory.InvocationExpression(
                                                    SyntaxFactory.IdentifierName("nameof"))
                                                    .WithArgumentList(
                                                        SyntaxFactory.ArgumentList(
                                                            SyntaxFactory.SingletonSeparatedList(
                                                                SyntaxFactory.Argument(
                                                                    SyntaxFactory.IdentifierName(fieldName)))))))))))
                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

                var setter = SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                    .WithExpressionBody(
                        SyntaxFactory.ArrowExpressionClause(
                            SyntaxFactory.InvocationExpression(
                                SyntaxFactory.IdentifierName("WriteHere"))
                                .WithArgumentList(
                                    SyntaxFactory.ArgumentList(
                                        SyntaxFactory.SeparatedList(new[]
                                        {
                                            SyntaxFactory.Argument(
                                                SyntaxFactory.InvocationExpression(
                                                    SyntaxFactory.IdentifierName("nameof"))
                                                    .WithArgumentList(
                                                        SyntaxFactory.ArgumentList(
                                                            SyntaxFactory.SingletonSeparatedList(
                                                                SyntaxFactory.Argument(
                                                                    SyntaxFactory.IdentifierName(fieldName)))))),
                                            SyntaxFactory.Argument(SyntaxFactory.IdentifierName("value"))
                                        })))))
                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

                propDecl = SyntaxFactory.PropertyDeclaration(propType, SyntaxFactory.Identifier(fieldName))
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                    .WithAccessorList(
                        SyntaxFactory.AccessorList(
                            SyntaxFactory.List(new[] { getter, setter })))
                    .WithAttributeLists(SyntaxFactory.List(attrLists));
            }

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

    private static bool IsInvalidTypeSpec(TypeSpec ts)
    {
        // Check if it's a UDT with an invalid name
        if (ts.TryAsUdt(out var udtName, out var _))
        {
            if (string.IsNullOrWhiteSpace(udtName) ||
                udtName.StartsWith("<") ||
                udtName.StartsWith("__unnamed", StringComparison.OrdinalIgnoreCase) ||
                udtName.All(c => c == '_'))
            {
                return true;
            }
        }

        // Check if it's an array with an invalid element type
        if (ts.TryAsArray(out var elemSpec, out var _))
        {
            if (IsInvalidTypeSpec(elemSpec))
            {
                return true;
            }
        }

        return false;
    }
}
