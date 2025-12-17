using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_ZEROING")]
    public sealed class MiPartitionZeroing : DynamicStructure
    {
        [Offset(0UL)]
        public WorkQueueItem RebalanceZeroFreeWorkItem { get => ReadStructure<WorkQueueItem>(nameof(RebalanceZeroFreeWorkItem)); set => WriteStructure(nameof(RebalanceZeroFreeWorkItem), value); }

        [Offset(32UL)]
        public int BackgroundZeroingDisabled { get => ReadHere<int>(nameof(BackgroundZeroingDisabled)); set => WriteHere(nameof(BackgroundZeroingDisabled), value); }

        [Offset(36UL)]
        public int BootEnginesCalibrating { get => ReadHere<int>(nameof(BootEnginesCalibrating)); set => WriteHere(nameof(BootEnginesCalibrating), value); }

        [Offset(40UL)]
        public Kevent BootEnginesCalibrationWaiters { get => ReadStructure<Kevent>(nameof(BootEnginesCalibrationWaiters)); set => WriteStructure(nameof(BootEnginesCalibrationWaiters), value); }

        [Offset(64UL)]
        public int ZeroFreePageSlistMinimum { get => ReadHere<int>(nameof(ZeroFreePageSlistMinimum)); set => WriteHere(nameof(ZeroFreePageSlistMinimum), value); }

        [Offset(68UL)]
        public uint BackgroundZeroingPreference { get => ReadHere<uint>(nameof(BackgroundZeroingPreference)); set => WriteHere(nameof(BackgroundZeroingPreference), value); }

        public MiPartitionZeroing(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPartitionZeroing>();
        }
    }
}