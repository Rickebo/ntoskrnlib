using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_REBUILD_LARGE_PAGE_TIMER")]
    public sealed class MiRebuildLargePageTimer : DynamicStructure
    {
        [Offset(0UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        [Offset(32UL)]
        public byte SecondsLeft { get => ReadHere<byte>(nameof(SecondsLeft)); set => WriteHere(nameof(SecondsLeft), value); }

        [Offset(33UL)]
        public byte RebuildActive { get => ReadHere<byte>(nameof(RebuildActive)); set => WriteHere(nameof(RebuildActive), value); }

        [Offset(34UL)]
        public byte NextPassDelta { get => ReadHere<byte>(nameof(NextPassDelta)); set => WriteHere(nameof(NextPassDelta), value); }

        [Offset(35UL)]
        public byte LargeSubPagesActive { get => ReadHere<byte>(nameof(LargeSubPagesActive)); set => WriteHere(nameof(LargeSubPagesActive), value); }

        public MiRebuildLargePageTimer(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiRebuildLargePageTimer>();
        }
    }
}