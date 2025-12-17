#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public partial struct _MI_ERROR_STATE
    {
        [FieldOffset(0)]
        public _MI_BAD_MEMORY_EVENT_ENTRY BadMemoryEventEntry;
        [FieldOffset(56)]
        public _MI_PROBE_RAISE_TRACKER ProbeRaises;
        [FieldOffset(120)]
        public _MI_FORCED_COMMITS ForcedCommits;
        [FieldOffset(128)]
        public uint PrePhase0BugCheckParameter;
        [FieldOffset(132)]
        public uint WsleFailures;
        [FieldOffset(136)]
        public byte PendingBadPages;
        [FieldOffset(137)]
        public byte FatalGraphicsFailures;
        [FieldOffset(138)]
        public byte BadPagesInsertSignalState;
        [FieldOffset(140)]
        public uint PageHashErrorBehavior;
        [FieldOffset(144)]
        public uint PageHashReadErrors;
        [FieldOffset(148)]
        public uint PageHashStandbyErrors;
        [FieldOffset(152)]
        public uint PageHashTransferErrors;
        [FieldOffset(156)]
        public uint PageHashAllocationErrors;
        [FieldOffset(160)]
        public ulong FailedHashPageFrameIndex;
        [FieldOffset(168)]
        public uint CheckZeroCount;
        [FieldOffset(172)]
        public uint ZeroedPageSingleBitErrorsDetected;
        [FieldOffset(176)]
        public uint BadPagesDetected;
        [FieldOffset(180)]
        public uint BadPagesInserted;
        [FieldOffset(184)]
        public _WORK_QUEUE_ITEM BadPageInsertWorkItem;
        [FieldOffset(216)]
        public uint ScrubPasses;
        [FieldOffset(220)]
        public uint ScrubBadPagesFound;
        [FieldOffset(224)]
        public uint UserViewFailures;
        [FieldOffset(228)]
        public uint UserViewCollisionFailures;
        [FieldOffset(232)]
        public uint UserAllocateFailures;
        [FieldOffset(236)]
        public uint UserAllocateCollisionFailures;
        [FieldOffset(240)]
        public _MI_RESAVAIL_FAILURES ResavailFailures;
        [FieldOffset(248)]
        public uint BadPhysicalMapsEarly;
        [FieldOffset(252)]
        public uint BadPhysicalMaps;
    }
}