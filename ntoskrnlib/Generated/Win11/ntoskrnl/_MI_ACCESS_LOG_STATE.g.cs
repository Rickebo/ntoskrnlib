#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public partial struct _MI_ACCESS_LOG_STATE
    {
        [FieldOffset(0)]
        public IntPtr CcAccessLog;
        [FieldOffset(8)]
        public _WORK_QUEUE_ITEM DisableAccessLoggingWorkItem;
        [FieldOffset(40)]
        public uint DisableAccessLoggingState;
        [FieldOffset(44)]
        public uint Enabled;
        [FieldOffset(48)]
        public uint MinLoggingPriority;
        [FieldOffset(56)]
        public IntPtr PfnRepurposeLog;
        [FieldOffset(64)]
        public _KDPC AllocatePfnRepurposeDpc;
        [FieldOffset(128)]
        public int AccessLoggingLock;
    }
}