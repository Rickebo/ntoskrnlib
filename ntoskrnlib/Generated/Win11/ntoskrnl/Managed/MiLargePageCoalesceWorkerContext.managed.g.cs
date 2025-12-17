using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT")]
    public sealed class MiLargePageCoalesceWorkerContext : DynamicStructure
    {
        [Offset(0UL)]
        public Kevent CandidatesExistEvent { get => ReadStructure<Kevent>(nameof(CandidatesExistEvent)); set => WriteStructure(nameof(CandidatesExistEvent), value); }

        [Offset(24UL)]
        public ulong InProgressBitmapIndex { get => ReadHere<ulong>(nameof(InProgressBitmapIndex)); set => WriteHere(nameof(InProgressBitmapIndex), value); }

        [Offset(32UL)]
        public int DemandCoalesceAttempted { get => ReadHere<int>(nameof(DemandCoalesceAttempted)); set => WriteHere(nameof(DemandCoalesceAttempted), value); }

        [Offset(36UL)]
        public int DemandCoalesceTimedOut { get => ReadHere<int>(nameof(DemandCoalesceTimedOut)); set => WriteHere(nameof(DemandCoalesceTimedOut), value); }

        [Offset(40UL)]
        public int DemandCoalesceTimedOutCSwitch { get => ReadHere<int>(nameof(DemandCoalesceTimedOutCSwitch)); set => WriteHere(nameof(DemandCoalesceTimedOutCSwitch), value); }

        [Offset(44UL)]
        public int DemandCoalesceSucceeded { get => ReadHere<int>(nameof(DemandCoalesceSucceeded)); set => WriteHere(nameof(DemandCoalesceSucceeded), value); }

        public MiLargePageCoalesceWorkerContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiLargePageCoalesceWorkerContext>();
        }
    }
}