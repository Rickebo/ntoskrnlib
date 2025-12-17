using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SEP_SID_VALUES_BLOCK")]
    public sealed class SepSidValuesBlock : DynamicStructure
    {
        [Offset(0UL)]
        public uint BlockLength { get => ReadHere<uint>(nameof(BlockLength)); set => WriteHere(nameof(BlockLength), value); }

        [Offset(8UL)]
        public long ReferenceCount { get => ReadHere<long>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(16UL)]
        public uint SidCount { get => ReadHere<uint>(nameof(SidCount)); set => WriteHere(nameof(SidCount), value); }

        [Offset(24UL)]
        public ulong SidValuesStart { get => ReadHere<ulong>(nameof(SidValuesStart)); set => WriteHere(nameof(SidValuesStart), value); }

        public SepSidValuesBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SepSidValuesBlock>();
        }
    }
}