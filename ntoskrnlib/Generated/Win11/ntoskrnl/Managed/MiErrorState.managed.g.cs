using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_ERROR_STATE")]
    public sealed class MiErrorState : DynamicStructure
    {
        [Offset(0UL)]
        public MiBadMemoryEventEntry BadMemoryEventEntry { get => ReadStructure<MiBadMemoryEventEntry>(nameof(BadMemoryEventEntry)); set => WriteStructure(nameof(BadMemoryEventEntry), value); }

        [Offset(56UL)]
        public MiProbeRaiseTracker ProbeRaises { get => ReadStructure<MiProbeRaiseTracker>(nameof(ProbeRaises)); set => WriteStructure(nameof(ProbeRaises), value); }

        [Offset(120UL)]
        public MiForcedCommits ForcedCommits { get => ReadStructure<MiForcedCommits>(nameof(ForcedCommits)); set => WriteStructure(nameof(ForcedCommits), value); }

        [Offset(128UL)]
        public uint PrePhase0BugCheckParameter { get => ReadHere<uint>(nameof(PrePhase0BugCheckParameter)); set => WriteHere(nameof(PrePhase0BugCheckParameter), value); }

        [Offset(132UL)]
        public uint WsleFailures { get => ReadHere<uint>(nameof(WsleFailures)); set => WriteHere(nameof(WsleFailures), value); }

        [Offset(136UL)]
        public byte PendingBadPages { get => ReadHere<byte>(nameof(PendingBadPages)); set => WriteHere(nameof(PendingBadPages), value); }

        [Offset(137UL)]
        public byte FatalGraphicsFailures { get => ReadHere<byte>(nameof(FatalGraphicsFailures)); set => WriteHere(nameof(FatalGraphicsFailures), value); }

        [Offset(138UL)]
        public byte BadPagesInsertSignalState { get => ReadHere<byte>(nameof(BadPagesInsertSignalState)); set => WriteHere(nameof(BadPagesInsertSignalState), value); }

        [Offset(140UL)]
        public uint PageHashErrorBehavior { get => ReadHere<uint>(nameof(PageHashErrorBehavior)); set => WriteHere(nameof(PageHashErrorBehavior), value); }

        [Offset(144UL)]
        public uint PageHashReadErrors { get => ReadHere<uint>(nameof(PageHashReadErrors)); set => WriteHere(nameof(PageHashReadErrors), value); }

        [Offset(148UL)]
        public uint PageHashStandbyErrors { get => ReadHere<uint>(nameof(PageHashStandbyErrors)); set => WriteHere(nameof(PageHashStandbyErrors), value); }

        [Offset(152UL)]
        public uint PageHashTransferErrors { get => ReadHere<uint>(nameof(PageHashTransferErrors)); set => WriteHere(nameof(PageHashTransferErrors), value); }

        [Offset(156UL)]
        public uint PageHashAllocationErrors { get => ReadHere<uint>(nameof(PageHashAllocationErrors)); set => WriteHere(nameof(PageHashAllocationErrors), value); }

        [Offset(160UL)]
        public ulong FailedHashPageFrameIndex { get => ReadHere<ulong>(nameof(FailedHashPageFrameIndex)); set => WriteHere(nameof(FailedHashPageFrameIndex), value); }

        [Offset(168UL)]
        public uint CheckZeroCount { get => ReadHere<uint>(nameof(CheckZeroCount)); set => WriteHere(nameof(CheckZeroCount), value); }

        [Offset(172UL)]
        public uint ZeroedPageSingleBitErrorsDetected { get => ReadHere<uint>(nameof(ZeroedPageSingleBitErrorsDetected)); set => WriteHere(nameof(ZeroedPageSingleBitErrorsDetected), value); }

        [Offset(176UL)]
        public uint BadPagesDetected { get => ReadHere<uint>(nameof(BadPagesDetected)); set => WriteHere(nameof(BadPagesDetected), value); }

        [Offset(180UL)]
        public uint BadPagesInserted { get => ReadHere<uint>(nameof(BadPagesInserted)); set => WriteHere(nameof(BadPagesInserted), value); }

        [Offset(184UL)]
        public WorkQueueItem BadPageInsertWorkItem { get => ReadStructure<WorkQueueItem>(nameof(BadPageInsertWorkItem)); set => WriteStructure(nameof(BadPageInsertWorkItem), value); }

        [Offset(216UL)]
        public uint ScrubPasses { get => ReadHere<uint>(nameof(ScrubPasses)); set => WriteHere(nameof(ScrubPasses), value); }

        [Offset(220UL)]
        public uint ScrubBadPagesFound { get => ReadHere<uint>(nameof(ScrubBadPagesFound)); set => WriteHere(nameof(ScrubBadPagesFound), value); }

        [Offset(224UL)]
        public uint UserViewFailures { get => ReadHere<uint>(nameof(UserViewFailures)); set => WriteHere(nameof(UserViewFailures), value); }

        [Offset(228UL)]
        public uint UserViewCollisionFailures { get => ReadHere<uint>(nameof(UserViewCollisionFailures)); set => WriteHere(nameof(UserViewCollisionFailures), value); }

        [Offset(232UL)]
        public uint UserAllocateFailures { get => ReadHere<uint>(nameof(UserAllocateFailures)); set => WriteHere(nameof(UserAllocateFailures), value); }

        [Offset(236UL)]
        public uint UserAllocateCollisionFailures { get => ReadHere<uint>(nameof(UserAllocateCollisionFailures)); set => WriteHere(nameof(UserAllocateCollisionFailures), value); }

        [Offset(240UL)]
        public MiResavailFailures ResavailFailures { get => ReadStructure<MiResavailFailures>(nameof(ResavailFailures)); set => WriteStructure(nameof(ResavailFailures), value); }

        [Offset(248UL)]
        public uint BadPhysicalMapsEarly { get => ReadHere<uint>(nameof(BadPhysicalMapsEarly)); set => WriteHere(nameof(BadPhysicalMapsEarly), value); }

        [Offset(252UL)]
        public uint BadPhysicalMaps { get => ReadHere<uint>(nameof(BadPhysicalMaps)); set => WriteHere(nameof(BadPhysicalMaps), value); }

        public MiErrorState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiErrorState>();
        }
    }
}