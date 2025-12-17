using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EX_PARTITION")]
    public sealed class ExPartition : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr PartitionObject { get => ReadHere<IntPtr>(nameof(PartitionObject)); set => WriteHere(nameof(PartitionObject), value); }

        [Offset(8UL)]
        public IntPtr WorkQueues { get => ReadHere<IntPtr>(nameof(WorkQueues)); set => WriteHere(nameof(WorkQueues), value); }

        [Offset(16UL)]
        public IntPtr WorkQueueManagers { get => ReadHere<IntPtr>(nameof(WorkQueueManagers)); set => WriteHere(nameof(WorkQueueManagers), value); }

        [Offset(24UL)]
        public int QueueAllocationMask { get => ReadHere<int>(nameof(QueueAllocationMask)); set => WriteHere(nameof(QueueAllocationMask), value); }

        public ExPartition(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExPartition>();
        }
    }
}