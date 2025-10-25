using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Dia2Lib; // from Microsoft.Diagnostics.Tracing.TraceEvent dependency

namespace ntoskrnlib.Gen;

[SupportedOSPlatform("windows")]
internal sealed class DiaInspector : IDisposable
{
    private IDiaDataSource _source;
    private IDiaSession _session;
    private IDiaSymbol _global;

    public DiaInspector(string exePath, string symbolPath)
    {
        _source = (IDiaDataSource)new DiaSource();
        // loadDataForExe triggers symsrv downloads via dbghelp if available
        _source.loadDataForExe(exePath, symbolPath, null);
        _source.openSession(out _session);
        _global = _session.globalScope;
    }

    [Flags]
    private enum NameSearchOptions : uint
    {
        nsfNone = 0x0,
        nsfCaseInsensitive = 0x1,
        nsfFNameExt = 0x2,
        nsfRegularExpression = 0x8,
        nsfUndecoratedName = 0x10
    }

    public IDiaSymbol? FindUdt(string name)
    {
        string bare = name.Contains('!') ? name.Split('!')[1] : name;
        // Try case-insensitive exact
        _global.findChildren(SymTagEnum.SymTagUDT, bare, (uint)NameSearchOptions.nsfCaseInsensitive, out IDiaEnumSymbols? udts);
        if (udts != null) { try { return udts.Item(0); } catch { } }
        // Try without leading underscore
        if (bare.StartsWith("_"))
        {
            var noUnderscore = bare.TrimStart('_');
            _global.findChildren(SymTagEnum.SymTagUDT, noUnderscore, (uint)NameSearchOptions.nsfCaseInsensitive, out udts);
            if (udts != null) { try { return udts.Item(0); } catch { } }
        }
        // Try wildcard
        _global.findChildren(SymTagEnum.SymTagUDT, "*" + bare + "*", (uint)(NameSearchOptions.nsfRegularExpression | NameSearchOptions.nsfCaseInsensitive), out udts);
        if (udts != null) { try { return udts.Item(0); } catch { } }
        return null;
    }

    public IEnumerable<(string name, uint offset, IDiaSymbol type)> GetFields(IDiaSymbol udt)
    {
        udt.findChildren(SymTagEnum.SymTagData, null, 0, out IDiaEnumSymbols? fields);
        if (fields == null) yield break;
        for (uint i = 0; ; i++)
        {
            IDiaSymbol f;
            try { f = fields.Item(i); }
            catch { break; }
            if (f == null) continue;
            var loc = f.locationType;
            const uint LocIsThisRel = 4; // Dia SDK enum LocationType LocIsThisRel
            if (loc == LocIsThisRel)
            {
                var fname = f.name;
                var ofs = f.offset;
                var ftype = f.type;
                if (fname != null && ftype != null)
                    yield return (fname, (uint)ofs, ftype);
            }
        }
    }

    public static string GetTypeName(IDiaSymbol t)
    {
        return t.name ?? "<anon>";
    }

    public static uint GetTypeLength(IDiaSymbol t)
    {
        return (uint)t.length;
    }

    public IEnumerable<string> EnumerateUdts()
    {
        _global.findChildren(SymTagEnum.SymTagUDT, null, 0, out IDiaEnumSymbols? udts);
        if (udts == null) yield break;
        for (uint i = 0; ; i++)
        {
            IDiaSymbol s;
            try { s = udts.Item(i); }
            catch { break; }
            if (s == null) continue;
            var n = s.name;
            // Skip invalid or unnamed types (e.g., <unnamed-tag>, <unnamed-type-*>, <lambda_*>, etc.)
            if (string.IsNullOrWhiteSpace(n) ||
                n.StartsWith("<") ||
                n.StartsWith("__unnamed", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }
            yield return n!;
        }
    }

    public void Dispose()
    {
        if (_global != null) Marshal.ReleaseComObject(_global);
        if (_session != null) Marshal.ReleaseComObject(_session);
        if (_source != null) Marshal.ReleaseComObject(_source);
    }
}
