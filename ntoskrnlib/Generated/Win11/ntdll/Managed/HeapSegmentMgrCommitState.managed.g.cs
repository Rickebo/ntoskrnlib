using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_SEGMENT_MGR_COMMIT_STATE")]
    public sealed class HeapSegmentMgrCommitState : DynamicStructure
    {
        [Offset(0UL)]
        public ushort CommittedPageCount { get => ReadHere<ushort>(nameof(CommittedPageCount)); set => WriteHere(nameof(CommittedPageCount), value); }

        [Offset(0UL)]
        public ushort Spare { get => ReadHere<ushort>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(0UL)]
        public ushort LargePageOperationInProgress { get => ReadHere<ushort>(nameof(LargePageOperationInProgress)); set => WriteHere(nameof(LargePageOperationInProgress), value); }

        [Offset(0UL)]
        public ushort LargePageCommit { get => ReadHere<ushort>(nameof(LargePageCommit)); set => WriteHere(nameof(LargePageCommit), value); }

        [Offset(0UL)]
        public ushort EntireUShortV { get => ReadHere<ushort>(nameof(EntireUShortV)); set => WriteHere(nameof(EntireUShortV), value); }

        [Offset(0UL)]
        public ushort EntireUShort { get => ReadHere<ushort>(nameof(EntireUShort)); set => WriteHere(nameof(EntireUShort), value); }

        public HeapSegmentMgrCommitState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapSegmentMgrCommitState>();
        }
    }
}