using System;
using System.Collections.Generic;
using System.IO;
using Dia2Lib;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ntoskrnlib.Gen;

internal sealed class DiaEmitter
{
    private readonly DiaInspector _dia;
    private readonly string _ns;
    private readonly string? _moduleSym;

    public DiaEmitter(DiaInspector dia, string ns, string? moduleSym = null)
    {
        _dia = dia;
        _ns = ns;
        _moduleSym = moduleSym;
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

            var code = ProgramHelpers.GenerateFromDia(typeName, _dia, sym, flatten, _ns);
            var file = Path.Combine(outputDir, ProgramHelpers.Sanitize(typeName) + ".g.cs");
            if (!File.Exists(file))
            {
                File.WriteAllText(file, code);
                written++;
            }

            // Generate managed class
            try
            {
                var managedCode = GenerateManagedClass(typeName, sym, flatten);
                var className = CodeGenerator.ToCSharpClassName(typeName);
                var managedDir = Path.Combine(outputDir, "Managed");
                Directory.CreateDirectory(managedDir);
                var managedFile = Path.Combine(managedDir, className + ".managed.g.cs");
                if (!File.Exists(managedFile))
                {
                    File.WriteAllText(managedFile, managedCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[WARNING] Failed to generate managed class for {typeName}: {ex.Message}");
            }

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

    private string GenerateManagedClass(string typeName, IDiaSymbol sym, bool flatten)
    {
        var className = CodeGenerator.ToCSharpClassName(typeName);

        // compilation unit with usings
        var cu = SyntaxFactory.CompilationUnit()
            .WithUsings(
                SyntaxFactory.List(new UsingDirectiveSyntax[]
                {
                    SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System")),
                    SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Collections.Generic")),
                    SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("ntoskrnlib.Structure"))
                }));

        var symbolName = !string.IsNullOrWhiteSpace(_moduleSym) ? $"{_moduleSym}!{typeName}" : typeName;
        var dynAttr = SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("DynamicStructure"))
            .WithArgumentList(
                SyntaxFactory.AttributeArgumentList(
                    SyntaxFactory.SingletonSeparatedList(
                        SyntaxFactory.AttributeArgument(
                            SyntaxFactory.LiteralExpression(
                                SyntaxKind.StringLiteralExpression,
                                SyntaxFactory.Literal(symbolName))))));

        var classDecl = SyntaxFactory.ClassDeclaration(className)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.SealedKeyword))
            .WithBaseList(
                SyntaxFactory.BaseList(
                    SyntaxFactory.SingletonSeparatedList<BaseTypeSyntax>(
                        SyntaxFactory.SimpleBaseType(
                            SyntaxFactory.IdentifierName("DynamicStructure")))))
            .WithAttributeLists(SyntaxFactory.SingletonList(
                SyntaxFactory.AttributeList(
                    SyntaxFactory.SingletonSeparatedList(dynAttr))));

        foreach (var (fieldName, offset, fieldType) in _dia.GetFields(sym))
        {
            var sanitizedFieldName = ProgramHelpers.Sanitize(fieldName);

            // Determine property type
            var csType = DetermineCSharpType(fieldType, flatten);
            TypeSyntax propType = csType.EndsWith("[]", StringComparison.Ordinal)
                ? SyntaxFactory.ArrayType(
                    TypeFromName(csType.Substring(0, csType.Length - 2)))
                    .WithRankSpecifiers(SyntaxFactory.SingletonList(
                        SyntaxFactory.ArrayRankSpecifier(
                            SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(
                                SyntaxFactory.OmittedArraySizeExpression()))))
                : TypeFromName(csType);

            // [Offset(offsetUL)]
            var offsetAttr = SyntaxFactory.Attribute(
                    SyntaxFactory.IdentifierName("Offset"))
                .WithArgumentList(
                    SyntaxFactory.AttributeArgumentList(
                        SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.AttributeArgument(
                                SyntaxFactory.ParseExpression($"{offset}UL")))));

            var propDecl = SyntaxFactory.PropertyDeclaration(propType,
                    SyntaxFactory.Identifier(sanitizedFieldName))
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
                .WithAttributeLists(SyntaxFactory.SingletonList(
                    SyntaxFactory.AttributeList(
                        SyntaxFactory.SingletonSeparatedList(offsetAttr))));

            classDecl = classDecl.AddMembers(propDecl);
        }

        // ctor
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
        var registerMethod = SyntaxFactory.MethodDeclaration(
                SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.VoidKeyword)), "Register")
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                          SyntaxFactory.Token(SyntaxKind.StaticKeyword))
            .WithAttributeLists(SyntaxFactory.SingletonList(
                SyntaxFactory.AttributeList(
                    SyntaxFactory.SingletonSeparatedList(regAttr))))
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
            var nsDecl = SyntaxFactory.NamespaceDeclaration(
                SyntaxFactory.ParseName(_ns!)).AddMembers(classDecl);
            cu = cu.AddMembers(nsDecl);
        }
        else
        {
            cu = cu.AddMembers(classDecl);
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

    private static string DetermineCSharpType(IDiaSymbol fieldType, bool flatten)
    {
        var tag = (SymTagEnum)fieldType.symTag;

        // Handle arrays
        if (tag == SymTagEnum.SymTagArrayType)
        {
            var elemType = fieldType.type;
            if (elemType != null)
            {
                var elemTypeName = GetBasicTypeName(elemType);
                return $"{elemTypeName}[]";
            }
            return "byte[]";
        }

        // Handle pointers
        if (tag == SymTagEnum.SymTagPointerType)
        {
            return "ulong"; // Treat pointers as ulong
        }

        // Handle UDTs
        if (tag == SymTagEnum.SymTagUDT)
        {
            if (flatten)
            {
                // Flatten as byte array
                var size = fieldType.length;
                return "byte[]";
            }
            // Keep as structured type name
            var udtName = fieldType.name;
            return ProgramHelpers.Sanitize(udtName ?? "UnknownType");
        }

        return GetBasicTypeName(fieldType);
    }

    private static string GetBasicTypeName(IDiaSymbol type)
    {
        var baseType = type.baseType;
        var size = (int)type.length;

        // Handle basic types based on size and signed/unsigned flag
        // baseType 7 = unsigned, baseType 14 = signed (enum types)
        var isUnsigned = baseType == 7 || baseType == 14;

        var cs = size switch
        {
            1 => isUnsigned ? "byte" : "sbyte",
            2 => isUnsigned ? "ushort" : "short",
            4 => isUnsigned ? "uint" : "int",
            8 => isUnsigned ? "ulong" : "long",
            _ => "byte"
        };

        // Handle special cases
        return baseType switch
        {
            0 => "void",  // btVoid
            1 => "void",  // btNoType
            6 => size == 4 ? "float" : "double",  // btFloat
            8 => "byte",  // btBCD
            10 => "bool", // btBool
            16 => "char", // btWChar
            _ => cs
        };
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
