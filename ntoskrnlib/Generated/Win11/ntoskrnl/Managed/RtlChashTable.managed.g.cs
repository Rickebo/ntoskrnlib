using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_CHASH_TABLE")]
    public sealed class RtlChashTable : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Table { get => ReadHere<IntPtr>(nameof(Table)); set => WriteHere(nameof(Table), value); }

        [Offset(8UL)]
        public uint EntrySizeShift { get => ReadHere<uint>(nameof(EntrySizeShift)); set => WriteHere(nameof(EntrySizeShift), value); }

        [Offset(12UL)]
        public uint EntryMax { get => ReadHere<uint>(nameof(EntryMax)); set => WriteHere(nameof(EntryMax), value); }

        [Offset(16UL)]
        public uint EntryCount { get => ReadHere<uint>(nameof(EntryCount)); set => WriteHere(nameof(EntryCount), value); }

        public RtlChashTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlChashTable>();
        }
    }
}