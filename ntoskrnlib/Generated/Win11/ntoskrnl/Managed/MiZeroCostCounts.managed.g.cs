using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_ZERO_COST_COUNTS")]
    public sealed class MiZeroCostCounts : DynamicStructure
    {
        [Offset(0UL)]
        public ulong NativeSum { get => ReadHere<ulong>(nameof(NativeSum)); set => WriteHere(nameof(NativeSum), value); }

        [Offset(8UL)]
        public ulong AlternateSum { get => ReadHere<ulong>(nameof(AlternateSum)); set => WriteHere(nameof(AlternateSum), value); }

        public MiZeroCostCounts(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiZeroCostCounts>();
        }
    }
}