using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EPARTITION")]
    public sealed class Epartition : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr MmPartition { get => ReadHere<IntPtr>(nameof(MmPartition)); set => WriteHere(nameof(MmPartition), value); }

        [Offset(8UL)]
        public IntPtr CcPartition { get => ReadHere<IntPtr>(nameof(CcPartition)); set => WriteHere(nameof(CcPartition), value); }

        [Offset(16UL)]
        public IntPtr ExPartition { get => ReadHere<IntPtr>(nameof(ExPartition)); set => WriteHere(nameof(ExPartition), value); }

        [Offset(24UL)]
        public IntPtr SmPartition { get => ReadHere<IntPtr>(nameof(SmPartition)); set => WriteHere(nameof(SmPartition), value); }

        [Offset(32UL)]
        public IntPtr PfPartition { get => ReadHere<IntPtr>(nameof(PfPartition)); set => WriteHere(nameof(PfPartition), value); }

        [Offset(40UL)]
        public long HardReferenceCount { get => ReadHere<long>(nameof(HardReferenceCount)); set => WriteHere(nameof(HardReferenceCount), value); }

        [Offset(48UL)]
        public long OpenHandleCount { get => ReadHere<long>(nameof(OpenHandleCount)); set => WriteHere(nameof(OpenHandleCount), value); }

        [Offset(56UL)]
        public ListEntry ActivePartitionLinks { get => ReadStructure<ListEntry>(nameof(ActivePartitionLinks)); set => WriteStructure(nameof(ActivePartitionLinks), value); }

        [Offset(72UL)]
        public IntPtr ParentPartition { get => ReadHere<IntPtr>(nameof(ParentPartition)); set => WriteHere(nameof(ParentPartition), value); }

        [Offset(80UL)]
        public WorkQueueItem TeardownWorkItem { get => ReadStructure<WorkQueueItem>(nameof(TeardownWorkItem)); set => WriteStructure(nameof(TeardownWorkItem), value); }

        [Offset(112UL)]
        public ExPushLock TeardownLock { get => ReadStructure<ExPushLock>(nameof(TeardownLock)); set => WriteStructure(nameof(TeardownLock), value); }

        [Offset(120UL)]
        public IntPtr SystemProcess { get => ReadHere<IntPtr>(nameof(SystemProcess)); set => WriteHere(nameof(SystemProcess), value); }

        [Offset(128UL)]
        public IntPtr SystemProcessHandle { get => ReadHere<IntPtr>(nameof(SystemProcessHandle)); set => WriteHere(nameof(SystemProcessHandle), value); }

        [Offset(136UL)]
        public uint PartitionFlags { get => ReadHere<uint>(nameof(PartitionFlags)); set => WriteHere(nameof(PartitionFlags), value); }

        [Offset(136UL)]
        public uint PairedWithJob { get => ReadHere<uint>(nameof(PairedWithJob)); set => WriteHere(nameof(PairedWithJob), value); }

        public Epartition(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Epartition>();
        }
    }
}