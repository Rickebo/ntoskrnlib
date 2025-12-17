using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_DYNAMIC_HASH_TABLE_CONTEXT")]
    public sealed class RtlDynamicHashTableContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ChainHead { get => ReadHere<IntPtr>(nameof(ChainHead)); set => WriteHere(nameof(ChainHead), value); }

        [Offset(8UL)]
        public IntPtr PrevLinkage { get => ReadHere<IntPtr>(nameof(PrevLinkage)); set => WriteHere(nameof(PrevLinkage), value); }

        [Offset(16UL)]
        public ulong Signature { get => ReadHere<ulong>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        public RtlDynamicHashTableContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlDynamicHashTableContext>();
        }
    }
}