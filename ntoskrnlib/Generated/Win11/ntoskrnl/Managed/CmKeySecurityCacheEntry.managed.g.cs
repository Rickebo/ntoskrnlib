using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_KEY_SECURITY_CACHE_ENTRY")]
    public sealed class CmKeySecurityCacheEntry : DynamicStructure
    {
        [Offset(0UL)]
        public uint Cell { get => ReadHere<uint>(nameof(Cell)); set => WriteHere(nameof(Cell), value); }

        [Offset(8UL)]
        public IntPtr CachedSecurity { get => ReadHere<IntPtr>(nameof(CachedSecurity)); set => WriteHere(nameof(CachedSecurity), value); }

        public CmKeySecurityCacheEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmKeySecurityCacheEntry>();
        }
    }
}