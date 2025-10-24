using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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
        var originalName = _insp.GetTypeName(typeId);
        var className = TypeSpec.SanitizeIdentifier(originalName);

        // using directives
        var cu = SyntaxFactory.CompilationUnit()
            .WithUsings(SyntaxFactory.List(new UsingDirectiveSyntax[]
            {
                SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System")),
                SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Collections.Generic")),
                SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("ntoskrnlib.Structure"))
            }));

        // [DynamicStructure("prefix!Type")] attribute
        var dynAttr = SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("DynamicStructure"))
            .WithArgumentList(
                SyntaxFactory.AttributeArgumentList(
                    SyntaxFactory.SingletonSeparatedList(
                        SyntaxFactory.AttributeArgument(
                            SyntaxFactory.LiteralExpression(
                                SyntaxKind.StringLiteralExpression,
                                SyntaxFactory.Literal($"{moduleSymbolPrefix}!{originalName}"))))));

        // class declaration sealed : DynamicStructure
        var classDecl = SyntaxFactory.ClassDeclaration(className)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.SealedKeyword))
            .WithBaseList(
                SyntaxFactory.BaseList(
                    SyntaxFactory.SingletonSeparatedList<BaseTypeSyntax>(
                        SyntaxFactory.SimpleBaseType(SyntaxFactory.IdentifierName("DynamicStructure")))))
            .WithAttributeLists(SyntaxFactory.SingletonList(SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(dynAttr))));

        // Properties (metadata only)
        foreach (var f in _insp.GetUdtFields(typeId))
        {
            var propName = TypeSpec.SanitizeIdentifier(f.Name);
            var ts = _insp.ResolveType(f.TypeId);
            var csType = ts.ToCSharpFieldType();
            var propType = ToTypeSyntax(csType);

            var propDecl = SyntaxFactory.PropertyDeclaration(propType, SyntaxFactory.Identifier(propName))
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .WithAccessorList(
                    SyntaxFactory.AccessorList(
                        SyntaxFactory.List(new[]
                        {
                            SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                        })));
            classDecl = classDecl.AddMembers(propDecl);
        }

        // ctor: public Class(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress) { }
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

        // static ctor builds dictionary and calls Register<T>((mem,ptr)=>new T(mem,ptr), offsets)
        var dictType = SyntaxFactory.GenericName("Dictionary")
            .WithTypeArgumentList(SyntaxFactory.TypeArgumentList(
                SyntaxFactory.SeparatedList<TypeSyntax>(new SyntaxNodeOrToken[]
                {
                    SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.StringKeyword)),
                    SyntaxFactory.Token(SyntaxKind.CommaToken),
                    SyntaxFactory.ArrayType(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ULongKeyword)))
                        .WithRankSpecifiers(SyntaxFactory.SingletonList(
                            SyntaxFactory.ArrayRankSpecifier(
                                SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(SyntaxFactory.OmittedArraySizeExpression()))))
                })));

        // Initializer expressions for offsets
        var inits = new System.Collections.Generic.List<ExpressionSyntax>();
        foreach (var f in _insp.GetUdtFields(typeId))
        {
            var propName = TypeSpec.SanitizeIdentifier(f.Name);
            var nameOf = SyntaxFactory.InvocationExpression(SyntaxFactory.IdentifierName("nameof"))
                .WithArgumentList(SyntaxFactory.ArgumentList(
                    SyntaxFactory.SingletonSeparatedList(
                        SyntaxFactory.Argument(
                            SyntaxFactory.MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                SyntaxFactory.IdentifierName(className),
                                SyntaxFactory.IdentifierName(propName))))));

            var valueArray = SyntaxFactory.ArrayCreationExpression(
                    SyntaxFactory.ArrayType(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ULongKeyword)))
                        .WithRankSpecifiers(SyntaxFactory.SingletonList(
                            SyntaxFactory.ArrayRankSpecifier(
                                SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(SyntaxFactory.OmittedArraySizeExpression())))))
                .WithInitializer(
                    SyntaxFactory.InitializerExpression(SyntaxKind.ArrayInitializerExpression,
                        SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(
                            SyntaxFactory.ParseExpression($"{f.Offset}UL"))));

            var kv = SyntaxFactory.InitializerExpression(
                SyntaxKind.ComplexElementInitializerExpression,
                SyntaxFactory.SeparatedList<ExpressionSyntax>(new SyntaxNodeOrToken[]
                {
                    nameOf,
                    SyntaxFactory.Token(SyntaxKind.CommaToken),
                    valueArray
                }));
            inits.Add(kv);
        }

        var dictCreation = SyntaxFactory.ObjectCreationExpression(
                SyntaxFactory.GenericName("Dictionary")
                    .WithTypeArgumentList(SyntaxFactory.TypeArgumentList(
                        SyntaxFactory.SeparatedList<TypeSyntax>(new SyntaxNodeOrToken[]
                        {
                            SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.StringKeyword)),
                            SyntaxFactory.Token(SyntaxKind.CommaToken),
                            SyntaxFactory.ArrayType(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.ULongKeyword)))
                                .WithRankSpecifiers(SyntaxFactory.SingletonList(
                                    SyntaxFactory.ArrayRankSpecifier(
                                        SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(SyntaxFactory.OmittedArraySizeExpression()))))
                        }))))
            .WithArgumentList(SyntaxFactory.ArgumentList())
            .WithInitializer(
                SyntaxFactory.InitializerExpression(SyntaxKind.CollectionInitializerExpression,
                    SyntaxFactory.SeparatedList(inits)));

        var offsetsDecl = SyntaxFactory.LocalDeclarationStatement(
            SyntaxFactory.VariableDeclaration(dictType)
                .WithVariables(
                    SyntaxFactory.SingletonSeparatedList(
                        SyntaxFactory.VariableDeclarator("offsets")
                            .WithInitializer(SyntaxFactory.EqualsValueClause(dictCreation)))));

        // Register<Class>((mem,ptr)=>new Class(mem,ptr), offsets)
        var lambda = SyntaxFactory.ParenthesizedLambdaExpression()
            .WithParameterList(SyntaxFactory.ParameterList(
                SyntaxFactory.SeparatedList(new[]
                {
                    SyntaxFactory.Parameter(SyntaxFactory.Identifier("mem")),
                    SyntaxFactory.Parameter(SyntaxFactory.Identifier("ptr"))
                })))
            .WithExpressionBody(
                SyntaxFactory.ObjectCreationExpression(SyntaxFactory.IdentifierName(className))
                    .WithArgumentList(SyntaxFactory.ArgumentList(
                        SyntaxFactory.SeparatedList(new[]
                        {
                            SyntaxFactory.Argument(SyntaxFactory.IdentifierName("mem")),
                            SyntaxFactory.Argument(SyntaxFactory.IdentifierName("ptr"))
                        }))));

        var registerCall = SyntaxFactory.ExpressionStatement(
            SyntaxFactory.InvocationExpression(
                    SyntaxFactory.GenericName("Register")
                        .WithTypeArgumentList(
                            SyntaxFactory.TypeArgumentList(
                                SyntaxFactory.SingletonSeparatedList<TypeSyntax>(SyntaxFactory.IdentifierName(className)))))
                .WithArgumentList(
                    SyntaxFactory.ArgumentList(
                        SyntaxFactory.SeparatedList(new[]
                        {
                            SyntaxFactory.Argument(lambda),
                            SyntaxFactory.Argument(SyntaxFactory.IdentifierName("offsets"))
                        }))));

        var staticCtor = SyntaxFactory.ConstructorDeclaration(className)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.StaticKeyword))
            .WithBody(SyntaxFactory.Block(offsetsDecl, registerCall));

        classDecl = classDecl.AddMembers(staticCtor);

        var nsDecl = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName($"{ns}.Dynamic"))
            .AddMembers(classDecl);
        cu = cu.AddMembers(nsDecl);

        return cu.NormalizeWhitespace().ToFullString();
    }

    private static TypeSyntax ToTypeSyntax(string csType)
    {
        if (csType.EndsWith("[]", System.StringComparison.Ordinal))
        {
            var elem = csType.Substring(0, csType.Length - 2);
            return SyntaxFactory.ArrayType(BasicType(elem))
                .WithRankSpecifiers(SyntaxFactory.SingletonList(
                    SyntaxFactory.ArrayRankSpecifier(
                        SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(SyntaxFactory.OmittedArraySizeExpression()))));
        }
        return BasicType(csType);
    }

    private static TypeSyntax BasicType(string name)
    {
        return name switch
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
            _ => SyntaxFactory.IdentifierName(name)
        };
    }
}
