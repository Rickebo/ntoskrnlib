using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_DYNAMIC_HASH_TABLE_ENUMERATOR")]
    public sealed class RtlDynamicHashTableEnumerator : DynamicStructure
    {
        [Offset(0UL)]
        public RtlDynamicHashTableEntry HashEntry { get => ReadStructure<RtlDynamicHashTableEntry>(nameof(HashEntry)); set => WriteStructure(nameof(HashEntry), value); }

        [Offset(0UL)]
        public IntPtr CurEntry { get => ReadHere<IntPtr>(nameof(CurEntry)); set => WriteHere(nameof(CurEntry), value); }

        [Offset(24UL)]
        public IntPtr ChainHead { get => ReadHere<IntPtr>(nameof(ChainHead)); set => WriteHere(nameof(ChainHead), value); }

        [Offset(32UL)]
        public uint BucketIndex { get => ReadHere<uint>(nameof(BucketIndex)); set => WriteHere(nameof(BucketIndex), value); }

        public RtlDynamicHashTableEnumerator(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlDynamicHashTableEnumerator>();
        }
    }
}