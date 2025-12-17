#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT
    {
        [FieldOffset(0)]
        public _KEVENT CandidatesExistEvent;
        [FieldOffset(24)]
        public ulong InProgressBitmapIndex;
        [FieldOffset(32)]
        public int DemandCoalesceAttempted;
        [FieldOffset(36)]
        public int DemandCoalesceTimedOut;
        [FieldOffset(40)]
        public int DemandCoalesceTimedOutCSwitch;
        [FieldOffset(44)]
        public int DemandCoalesceSucceeded;
    }
}