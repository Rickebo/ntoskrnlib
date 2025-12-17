#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 240)]
    public partial struct _KI_RESCHEDULE_CONTEXT
    {
        [FieldOffset(0)]
        public byte ProcessorCount;
        [FieldOffset(1)]
        public byte ScanStart;
        [FieldOffset(4)]
        public uint MaximumThreadIsolationWidth;
        [FieldOffset(8)]
        public uint IsolationWidth;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _KI_RESCHEDULE_CONTEXT_ENTRY[] ProcessorEntries;
        [FieldOffset(176)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _KI_SHARED_READY_QUEUE_LOCK_HANDLE[] SharedReadyLockQueues;
    }
}