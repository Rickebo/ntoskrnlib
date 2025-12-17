using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using ntoskrnlib.Interop;
using ntoskrnlib.Symbols;

namespace ntoskrnlib.Gen;

[SupportedOSPlatform("windows")]
internal sealed class TypeInspector
{
    private readonly SymbolSession _session;
    private readonly IntPtr _proc;
    private readonly ulong _modBase;

    public TypeInspector(SymbolSession session)
    {
        _session = session;
        _proc = session.ProcessHandle;
        _modBase = session.ModuleBase;
    }

    public ulong GetTypeLength(uint typeId)
    {
        if (!DbgHelp.SymGetTypeInfo(_proc, _modBase, typeId, DbgHelp.TI_GET_LENGTH, out ulong len))
            throw new InvalidOperationException("TI_GET_LENGTH failed: " + DbgHelp.GetLastErrorMessage());
        return len;
    }

    public DbgHelp.SymTag GetSymTag(uint typeId)
    {
        if (!DbgHelp.SymGetTypeInfo(_proc, _modBase, typeId, DbgHelp.TI_GET_SYMTAG, out uint tag))
            throw new InvalidOperationException("TI_GET_SYMTAG failed: " + DbgHelp.GetLastErrorMessage());
        return (DbgHelp.SymTag)tag;
    }

    public string GetTypeName(uint typeId)
    {
        if (!DbgHelp.SymGetTypeInfo(_proc, _modBase, typeId, DbgHelp.TI_GET_NAME, out IntPtr pStr))
            return $"Type_{typeId}";
        try
        {
            var s = DbgHelp.SymGetTypeInfoReturnsUnicodeStrings
                ? Marshal.PtrToStringUni(pStr)
                : Marshal.PtrToStringAnsi(pStr);
            return s ?? $"Type_{typeId}";
        }
        finally
        {
            DbgHelp.LocalFree(pStr);
        }
    }

    public bool TryGetTypeIdByName(string name, out uint typeId)
    {
        if (TryGetTypeIdByNameCore(_modBase, name, out typeId)) return true;

        // Fallbacks: try fully-qualified names via common module aliases across DbgHelp/WinDbg
        var modBaseName = System.IO.Path.GetFileNameWithoutExtension(_session.ModulePath);
        string[] prefixes = new[] { "nt", "ntkrnlmp", modBaseName, modBaseName + ".exe" };
        foreach (var pfx in prefixes)
        {
            if (TryGetTypeIdByNameCore(0, pfx + "!" + name, out typeId)) return true;
        }
        // As a last resort, enumerate by name mask
        if (TryFindTypeByEnum(name, out typeId)) return true;
        typeId = 0;
        return false;
    }

    private bool TryGetTypeIdByNameCore(ulong modBase, string name, out uint typeId)
    {
        unsafe
        {
            const int MaxNameLen = 1024;
            int size = Marshal.SizeOf<DbgHelp.SYMBOL_INFO>() + MaxNameLen;
            IntPtr mem = Marshal.AllocHGlobal(size);
            try
            {
                Span<byte> span = new Span<byte>((void*)mem, size);
                span.Clear();
                var p = (DbgHelp.SYMBOL_INFO*)mem;
                p->SizeOfStruct = (uint)Marshal.SizeOf<DbgHelp.SYMBOL_INFO>();
                p->MaxNameLen = MaxNameLen;
                if (!DbgHelp.SymGetTypeFromName(_proc, modBase, name, mem))
                {
                    if (string.Equals(Environment.GetEnvironmentVariable("NTOSKRNLLIB_DBGHELP_TRACE"), "1", StringComparison.Ordinal))
                    {
                        System.Console.Error.WriteLine($"SymGetTypeFromName failed for '{name}' (modBase={(modBase==0?"0":"0x"+modBase.ToString("X"))}): {DbgHelp.GetLastErrorMessage()}");
                    }
                    typeId = 0;
                    return false;
                }
                typeId = p->TypeIndex;
                return true;
            }
            finally
            {
                Marshal.FreeHGlobal(mem);
            }
        }
    }

    private bool TryFindTypeByEnum(string name, out uint typeId)
    {
        uint found = 0;
        unsafe
        {
            bool Callback(DbgHelp.SYMBOL_INFO* pInfo, uint size, IntPtr ctx)
            {
                if (pInfo == null) return false;
                found = pInfo->TypeIndex; // first match is good enough
                return false; // stop after first
            }

            var del = new DbgHelp.SymEnumTypesProc(Callback);
            string mask = name.Contains('!') ? name : "*" + name + "*";
            if (DbgHelp.SymEnumTypesByName(_proc, _modBase, mask, del, IntPtr.Zero) && found != 0)
            {
                typeId = found;
                return true;
            }
        }
        typeId = 0;
        return false;
    }

    public IEnumerable<(uint typeId, string name)> EnumerateUdts()
    {
        var raw = new List<(uint typeIndex, uint index, string name)>();
        unsafe
        {
            bool Callback(DbgHelp.SYMBOL_INFO* pInfo, uint size, IntPtr ctx)
            {
                // Only UDTs
                if (pInfo == null) return true;
                var tag = (DbgHelp.SymTag)pInfo->Tag;
                if (tag == DbgHelp.SymTag.UDT)
                {
                    byte* namePtr = &pInfo->Name;
                    var name = Marshal.PtrToStringAnsi((IntPtr)namePtr, (int)pInfo->NameLen) ?? $"Type_{pInfo->TypeIndex}";
                    raw.Add((pInfo->TypeIndex, pInfo->Index, name));

                    if (raw.Count <= 10)
                    {
                        Console.WriteLine($"[Symbols] UDT enum '{name}': TypeIndex={pInfo->TypeIndex} Index={pInfo->Index} ModBase=0x{pInfo->ModBase:X}");
                    }
                }
                return true;
            }

            var del = new DbgHelp.SymEnumTypesProc(Callback);
            if (!DbgHelp.SymEnumTypes(_proc, _modBase, del, IntPtr.Zero))
                throw new InvalidOperationException("SymEnumTypes failed: " + DbgHelp.GetLastErrorMessage());
        }

        static bool TryGetTypeLength(IntPtr proc, ulong modBase, uint candidate)
            => candidate != 0 && DbgHelp.SymGetTypeInfo(proc, modBase, candidate, DbgHelp.TI_GET_LENGTH, out ulong _);

        // Different dbghelp builds populate SYMBOL_INFO.TypeIndex vs SYMBOL_INFO.Index differently for SymEnumTypes.
        // Pick the field that produces valid type info for this module, falling back to name lookup if needed.
        bool typeIndexLooksValid = false;
        bool indexLooksValid = false;
        int probe = 0;
        foreach (var e in raw)
        {
            if (!typeIndexLooksValid && TryGetTypeLength(_proc, _modBase, e.typeIndex)) typeIndexLooksValid = true;
            if (!indexLooksValid && TryGetTypeLength(_proc, _modBase, e.index)) indexLooksValid = true;
            if (++probe >= 32) break;
        }

        Console.WriteLine($"[Symbols] SymEnumTypes id mapping: TypeIndexValid={typeIndexLooksValid} IndexValid={indexLooksValid}");

        var list = new List<(uint, string)>(raw.Count);
        foreach (var e in raw)
        {
            uint id;
            if (typeIndexLooksValid) id = e.typeIndex;
            else if (indexLooksValid) id = e.index;
            else if (TryGetTypeIdByName(e.name, out var resolved))
            {
                id = resolved;
                if (list.Count < 10)
                {
                    var ok = DbgHelp.SymGetTypeInfo(_proc, _modBase, id, DbgHelp.TI_GET_LENGTH, out ulong len);
                    Console.WriteLine($"[Symbols] Resolved '{e.name}' -> {id} (lenOk={ok}, len={(ok ? len : 0)})");
                }
            }
            else continue;

            list.Add((id, e.name));
        }

        return list;
    }

    public IReadOnlyList<FieldInfo> GetUdtFields(uint udtTypeId)
    {
        if (GetSymTag(udtTypeId) != DbgHelp.SymTag.UDT)
            throw new ArgumentException("Type is not a UDT", nameof(udtTypeId));

        if (!DbgHelp.SymGetTypeInfo(_proc, _modBase, udtTypeId, DbgHelp.TI_GET_CHILDRENCOUNT, out uint count))
            throw new InvalidOperationException("TI_GET_CHILDRENCOUNT failed: " + DbgHelp.GetLastErrorMessage());

        var results = new List<FieldInfo>((int)count);
        if (count == 0) return results;

        int alloc = Marshal.SizeOf<DbgHelp.TI_FINDCHILDREN_PARAMS>() + sizeof(uint) * (int)count;
        IntPtr mem = Marshal.AllocHGlobal(alloc);
        try
        {
            unsafe
            {
                var p = (DbgHelp.TI_FINDCHILDREN_PARAMS*)mem;
                p->Count = count;
                p->Start = 0;
            }

            // Query children ids
            if (!DbgHelp.SymGetTypeInfo(_proc, _modBase, udtTypeId, DbgHelp.TI_FINDCHILDREN, mem))
                throw new InvalidOperationException("TI_FINDCHILDREN failed: " + DbgHelp.GetLastErrorMessage());
            // Note: cast back to struct to read array
            unsafe
            {
                var p = (DbgHelp.TI_FINDCHILDREN_PARAMS*)mem;
                uint* childIds = (uint*)((byte*)mem + sizeof(uint) * 2);
                for (int i = 0; i < p->Count; i++)
                {
                    uint childId = childIds[i];

                    if (!DbgHelp.SymGetTypeInfo(_proc, _modBase, childId, DbgHelp.TI_GET_SYMTAG, out uint childTag))
                        continue;

                    var tag = (DbgHelp.SymTag)childTag;
                    switch (tag)
                    {
                        case DbgHelp.SymTag.Data:
                        case DbgHelp.SymTag.BaseClass:
                            int ofs = 0;
                            DbgHelp.SymGetTypeInfo(_proc, _modBase, childId, DbgHelp.TI_GET_OFFSET, out ofs);
                            uint fieldTypeId = 0;
                            DbgHelp.SymGetTypeInfo(_proc, _modBase, childId, DbgHelp.TI_GET_TYPEID, out fieldTypeId);
                            string name = GetName(childId);
                            results.Add(new FieldInfo(name, (uint)ofs, fieldTypeId, tag));
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        finally
        {
            Marshal.FreeHGlobal(mem);
        }
        return results;
    }

    private string GetName(uint typeId)
    {
        if (!DbgHelp.SymGetTypeInfo(_proc, _modBase, typeId, DbgHelp.TI_GET_NAME, out IntPtr pStr))
            return $"Field_{typeId}";
        try
        {
            return (DbgHelp.SymGetTypeInfoReturnsUnicodeStrings
                ? Marshal.PtrToStringUni(pStr)
                : Marshal.PtrToStringAnsi(pStr)) ?? $"Field_{typeId}";
        }
        finally
        {
            DbgHelp.LocalFree(pStr);
        }
    }

    public TypeSpec ResolveType(uint typeId)
    {
        var tag = GetSymTag(typeId);
        switch (tag)
        {
            case DbgHelp.SymTag.BaseType:
                if (!DbgHelp.SymGetTypeInfo(_proc, _modBase, typeId, DbgHelp.TI_GET_BASETYPE, out uint bt))
                    throw new InvalidOperationException("TI_GET_BASETYPE failed");
                if (!DbgHelp.SymGetTypeInfo(_proc, _modBase, typeId, DbgHelp.TI_GET_LENGTH, out ulong len))
                    throw new InvalidOperationException("TI_GET_LENGTH failed");
                return TypeSpec.FromBasic((DbgHelp.BasicType)bt, len);
            case DbgHelp.SymTag.PointerType:
                return TypeSpec.Pointer;
            case DbgHelp.SymTag.ArrayType:
                // Try to get element type and count
                uint elemTypeId = 0;
                DbgHelp.SymGetTypeInfo(_proc, _modBase, typeId, DbgHelp.TI_GET_TYPEID, out elemTypeId);
                ulong count = 0;
                DbgHelp.SymGetTypeInfo(_proc, _modBase, typeId, DbgHelp.TI_GET_ARRAYCOUNT, out count);
                return TypeSpec.Array(ResolveType(elemTypeId), (int)count);
            case DbgHelp.SymTag.Typedef:
                uint aliased = 0;
                if (DbgHelp.SymGetTypeInfo(_proc, _modBase, typeId, DbgHelp.TI_GET_TYPEID, out aliased))
                    return ResolveType(aliased);
                return TypeSpec.Unknown(GetTypeName(typeId));
            case DbgHelp.SymTag.Enum:
                // treat as underlying base type size
                ulong elen = GetTypeLength(typeId);
                return TypeSpec.Enum(elen, GetTypeName(typeId));
            case DbgHelp.SymTag.UDT:
                return TypeSpec.Udt(GetTypeName(typeId), (long)GetTypeLength(typeId));
            default:
                return TypeSpec.Unknown($"{tag}:{GetTypeName(typeId)}");
        }
    }
}

internal readonly record struct FieldInfo(string Name, uint Offset, uint TypeId, DbgHelp.SymTag Tag);

internal abstract record TypeSpec
{
    public static TypeSpec Pointer => new PointerSpec();
    public static TypeSpec FromBasic(DbgHelp.BasicType bt, ulong len) => new BasicSpec(bt, len);
    public static TypeSpec Array(TypeSpec elem, int count) => new ArraySpec(elem, count);
    public static TypeSpec Udt(string name, long size) => new UdtSpec(name, size);
    public static TypeSpec Enum(ulong size, string name) => new EnumSpec(size, name);
    public static TypeSpec Unknown(string desc) => new UnknownSpec(desc);

    public virtual string ToCSharpFieldType()
    {
        return "byte";
    }

    public virtual bool TryAsArray(out TypeSpec element, out int count)
    {
        element = null!;
        count = 0;
        return false;
    }

    public virtual bool TryAsUdt(out string name, out long size)
    {
        name = string.Empty;
        size = 0;
        return false;
    }

    private sealed record PointerSpec : TypeSpec
    {
        public override string ToCSharpFieldType() => "IntPtr"; // portable pointer
    }

    private sealed record BasicSpec(DbgHelp.BasicType Base, ulong Size) : TypeSpec
    {
        public override string ToCSharpFieldType()
        {
            bool unsigned = Base is DbgHelp.BasicType.btUInt or DbgHelp.BasicType.btULong;
            return Size switch
            {
                1 => unsigned ? "byte" : "sbyte",
                2 => unsigned ? "ushort" : "short",
                4 => unsigned ? "uint" : "int",
                8 => unsigned ? "ulong" : "long",
                _ => "byte"
            };
        }
    }

    private sealed record ArraySpec(TypeSpec Element, int Count) : TypeSpec
    {
        public override string ToCSharpFieldType()
        {
            // Represent inline arrays with MarshalAs(ByValArray)
            return Element is BasicSpec or EnumSpec ? Element.ToCSharpFieldType() + "[]" : "byte[]";
        }
        public override bool TryAsArray(out TypeSpec element, out int count)
        {
            element = Element;
            count = Count;
            return true;
        }
    }

    private sealed record UdtSpec(string Name, long Size) : TypeSpec
    {
        public override string ToCSharpFieldType() => SanitizeIdentifier(Name);
        public override bool TryAsUdt(out string name, out long size)
        {
            name = SanitizeIdentifier(Name);
            size = Size;
            return true;
        }
    }

    private sealed record EnumSpec(ulong Size, string Name) : TypeSpec
    {
        public override string ToCSharpFieldType()
        {
            return Size switch
            {
                1 => "byte",
                2 => "ushort",
                4 => "uint",
                8 => "ulong",
                _ => "int"
            };
        }
    }

    private sealed record UnknownSpec(string Desc) : TypeSpec
    {
        public override string ToCSharpFieldType() => "IntPtr"; // fallback
    }

    public static string SanitizeIdentifier(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) return "_";
        var sb = new StringBuilder(name.Length);
        foreach (var ch in name)
        {
            if (char.IsLetterOrDigit(ch) || ch == '_' ) sb.Append(ch);
            else sb.Append('_');
        }
        // Prefix @ if C# keyword
        return IsKeyword(sb.ToString()) ? "@" + sb : sb.ToString();
    }

    private static bool IsKeyword(string s)
    {
        return s is "class" or "struct" or "event" or "params" or "namespace" or "ref" or "out" or "in" or "checked" or "unchecked" or "object" or "string" or "int" or "long" or "float" or "double" or "decimal" or "bool" or "byte" or "sbyte" or "short" or "ushort" or "uint" or "ulong";
    }
}
