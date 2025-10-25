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

            // Skip invalid or unnamed types (e.g., <unnamed-tag>, <unnamed-type-*>)
            if (string.IsNullOrWhiteSpace(typeName) ||
                typeName.StartsWith("<") ||
                typeName.StartsWith("__unnamed", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            // Skip if sanitized name is empty or only underscores/whitespace
            var sanitizedName = ProgramHelpers.Sanitize(typeName);
            if (string.IsNullOrWhiteSpace(sanitizedName) || sanitizedName.All(c => c == '_'))
            {
                continue;
            }

            var code = ProgramHelpers.GenerateFromDia(typeName, _dia, sym, flatten, _ns);
            var file = Path.Combine(outputDir, sanitizedName + ".g.cs");
            if (!File.Exists(file))
            {
                File.WriteAllText(file, code);
                written++;
            }

            // Generate managed class
            try
            {
                var className = CodeGenerator.ToCSharpClassName(typeName);
                // Validate class name
                if (string.IsNullOrWhiteSpace(className) || className.All(c => c == '_'))
                {
                    Console.WriteLine($"[WARNING] Skipping managed class generation for {typeName}: invalid class name");
                }
                else
                {
                    var managedCode = GenerateManagedClass(typeName, sym, flatten);
                    var managedDir = Path.Combine(outputDir, "Managed");
                    Directory.CreateDirectory(managedDir);
                    var managedFile = Path.Combine(managedDir, className + ".managed.g.cs");
                    if (!File.Exists(managedFile))
                    {
                        File.WriteAllText(managedFile, managedCode);
                    }
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

            // Skip fields with invalid names
            if (string.IsNullOrWhiteSpace(fieldName) ||
                fieldName.StartsWith("<") ||
                fieldName.StartsWith("__unnamed", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            // Determine property type (use managed class names for managed types)
            var csType = DetermineCSharpType(fieldType, flatten, useManagedTypes: true);

            // Skip fields with invalid type names (UDTs that reference unnamed types)
            if (!flatten && IsInvalidTypeName(fieldType))
            {
                continue;
            }

            // Check if property name matches the enclosing type name
            if (string.Equals(sanitizedFieldName, className, StringComparison.OrdinalIgnoreCase))
            {
                sanitizedFieldName = "Base" + sanitizedFieldName;
            }
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

            PropertyDeclarationSyntax propDecl;
            var tag = (SymTagEnum)fieldType.symTag;

            // Add Length attribute for arrays
            var attributes = new List<AttributeListSyntax>
            {
                SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(offsetAttr))
            };

            if (tag == SymTagEnum.SymTagArrayType)
            {
                // Calculate array length
                var arrayLength = fieldType.length;
                var elemType = fieldType.type;
                int elemSize = 1;
                if (elemType != null)
                {
                    elemSize = (int)DiaInspector.GetTypeLength(elemType);
                }
                int arrayCount = elemSize > 0 ? (int)(arrayLength / (ulong)elemSize) : (int)arrayLength;

                var lengthAttr = SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("Length"))
                    .WithArgumentList(
                        SyntaxFactory.AttributeArgumentList(
                            SyntaxFactory.SingletonSeparatedList(
                                SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.LiteralExpression(
                                        SyntaxKind.NumericLiteralExpression,
                                        SyntaxFactory.Literal(arrayCount))))));
                attributes.Add(SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(lengthAttr)));
            }
            else if (flatten && tag == SymTagEnum.SymTagUDT)
            {
                // For flattened UDTs, use the size in bytes as length
                var udtLength = (int)fieldType.length;
                var lengthAttr = SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("Length"))
                    .WithArgumentList(
                        SyntaxFactory.AttributeArgumentList(
                            SyntaxFactory.SingletonSeparatedList(
                                SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.LiteralExpression(
                                        SyntaxKind.NumericLiteralExpression,
                                        SyntaxFactory.Literal(udtLength))))));
                attributes.Add(SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(lengthAttr)));
            }

            // Determine if this is a managed UDT type or array (both use DynamicStructure)
            bool isManagedUdt = (!flatten && tag == SymTagEnum.SymTagUDT) || tag == SymTagEnum.SymTagArrayType || (flatten && tag == SymTagEnum.SymTagUDT);

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
                                                                    SyntaxFactory.IdentifierName(sanitizedFieldName)))))))))))
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
                                                                    SyntaxFactory.IdentifierName(sanitizedFieldName)))))),
                                            SyntaxFactory.Argument(SyntaxFactory.IdentifierName("value"))
                                        })))))
                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

                propDecl = SyntaxFactory.PropertyDeclaration(propType, SyntaxFactory.Identifier(sanitizedFieldName))
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                    .WithAccessorList(
                        SyntaxFactory.AccessorList(
                            SyntaxFactory.List(new[] { getter, setter })))
                    .WithAttributeLists(SyntaxFactory.List(attributes));
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
                                                                    SyntaxFactory.IdentifierName(sanitizedFieldName)))))))))))
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
                                                                    SyntaxFactory.IdentifierName(sanitizedFieldName)))))),
                                            SyntaxFactory.Argument(SyntaxFactory.IdentifierName("value"))
                                        })))))
                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

                propDecl = SyntaxFactory.PropertyDeclaration(propType, SyntaxFactory.Identifier(sanitizedFieldName))
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                    .WithAccessorList(
                        SyntaxFactory.AccessorList(
                            SyntaxFactory.List(new[] { getter, setter })))
                    .WithAttributeLists(SyntaxFactory.List(attributes));
            }

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

    private static string DetermineCSharpType(IDiaSymbol fieldType, bool flatten, bool useManagedTypes = false)
    {
        var tag = (SymTagEnum)fieldType.symTag;

        // Handle arrays - use DynamicArray for managed types
        if (tag == SymTagEnum.SymTagArrayType)
        {
            return "DynamicArray";
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
                // Flatten as DynamicArray
                return "DynamicArray";
            }
            // Keep as structured type name
            var udtName = fieldType.name;
            var sanitizedName = ProgramHelpers.Sanitize(udtName ?? "UnknownType");

            // For managed types, convert to managed class name (PascalCase)
            if (useManagedTypes)
            {
                return CodeGenerator.ToCSharpClassName(sanitizedName);
            }

            return sanitizedName;
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
            0 => "byte",  // btVoid
            1 => "byte",  // btNoType
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

    private static bool IsInvalidTypeName(IDiaSymbol fieldType)
    {
        var tag = (SymTagEnum)fieldType.symTag;

        // For UDTs, check if the type name is invalid
        if (tag == SymTagEnum.SymTagUDT)
        {
            var typeName = fieldType.name;
            if (string.IsNullOrWhiteSpace(typeName) ||
                typeName.StartsWith("<") ||
                typeName.StartsWith("__unnamed", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        // For arrays, check the element type
        if (tag == SymTagEnum.SymTagArrayType)
        {
            var elemType = fieldType.type;
            if (elemType != null && IsInvalidTypeName(elemType))
            {
                return true;
            }
        }

        // For pointers, we generally keep them as they'll be IntPtr/ulong anyway

        return false;
    }
}
