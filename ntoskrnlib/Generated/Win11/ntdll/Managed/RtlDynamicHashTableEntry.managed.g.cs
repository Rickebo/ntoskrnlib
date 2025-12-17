using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_DYNAMIC_HASH_TABLE_ENTRY")]
    public sealed class RtlDynamicHashTableEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Linkage { get => ReadStructure<ListEntry>(nameof(Linkage)); set => WriteStructure(nameof(Linkage), value); }

        [Offset(16UL)]
        public ulong Signature { get => ReadHere<ulong>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        public RtlDynamicHashTableEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlDynamicHashTableEntry>();
        }
    }
}