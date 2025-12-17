using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_CROSS_PARTITION_CHARGES")]
    public sealed class MiCrossPartitionCharges : DynamicStructure
    {
        [Offset(0UL)]
        public ulong CurrentCharges { get => ReadHere<ulong>(nameof(CurrentCharges)); set => WriteHere(nameof(CurrentCharges), value); }

        [Offset(8UL)]
        public ulong ChargeFailures { get => ReadHere<ulong>(nameof(ChargeFailures)); set => WriteHere(nameof(ChargeFailures), value); }

        [Offset(16UL)]
        public ulong ChargePeak { get => ReadHere<ulong>(nameof(ChargePeak)); set => WriteHere(nameof(ChargePeak), value); }

        [Offset(24UL)]
        public ulong MaximumAllowed { get => ReadHere<ulong>(nameof(MaximumAllowed)); set => WriteHere(nameof(MaximumAllowed), value); }

        public MiCrossPartitionCharges(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiCrossPartitionCharges>();
        }
    }
}