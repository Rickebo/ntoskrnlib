using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_DYNAMIC_HASH_TABLE")]
    public sealed class RtlDynamicHashTable : DynamicStructure
    {
        [Offset(0UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(4UL)]
        public uint Shift { get => ReadHere<uint>(nameof(Shift)); set => WriteHere(nameof(Shift), value); }

        [Offset(8UL)]
        public uint TableSize { get => ReadHere<uint>(nameof(TableSize)); set => WriteHere(nameof(TableSize), value); }

        [Offset(12UL)]
        public uint Pivot { get => ReadHere<uint>(nameof(Pivot)); set => WriteHere(nameof(Pivot), value); }

        [Offset(16UL)]
        public uint DivisorMask { get => ReadHere<uint>(nameof(DivisorMask)); set => WriteHere(nameof(DivisorMask), value); }

        [Offset(20UL)]
        public uint NumEntries { get => ReadHere<uint>(nameof(NumEntries)); set => WriteHere(nameof(NumEntries), value); }

        [Offset(24UL)]
        public uint NonEmptyBuckets { get => ReadHere<uint>(nameof(NonEmptyBuckets)); set => WriteHere(nameof(NonEmptyBuckets), value); }

        [Offset(28UL)]
        public uint NumEnumerators { get => ReadHere<uint>(nameof(NumEnumerators)); set => WriteHere(nameof(NumEnumerators), value); }

        [Offset(32UL)]
        public IntPtr Directory { get => ReadHere<IntPtr>(nameof(Directory)); set => WriteHere(nameof(Directory), value); }

        public RtlDynamicHashTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlDynamicHashTable>();
        }
    }
}