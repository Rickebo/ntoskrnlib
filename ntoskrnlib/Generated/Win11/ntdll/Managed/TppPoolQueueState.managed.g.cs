using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_POOL_QUEUE_STATE")]
    public sealed class TppPoolQueueState : DynamicStructure
    {
        [Offset(0UL)]
        public long Exchange { get => ReadHere<long>(nameof(Exchange)); set => WriteHere(nameof(Exchange), value); }

        [Offset(0UL)]
        public int RunningThreadGoal { get => ReadHere<int>(nameof(RunningThreadGoal)); set => WriteHere(nameof(RunningThreadGoal), value); }

        [Offset(0UL)]
        public uint PendingReleaseCount { get => ReadHere<uint>(nameof(PendingReleaseCount)); set => WriteHere(nameof(PendingReleaseCount), value); }

        [Offset(4UL)]
        public uint QueueLength { get => ReadHere<uint>(nameof(QueueLength)); set => WriteHere(nameof(QueueLength), value); }

        public TppPoolQueueState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppPoolQueueState>();
        }
    }
}