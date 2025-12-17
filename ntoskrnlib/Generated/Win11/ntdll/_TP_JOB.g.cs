#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 296)]
    public partial struct _TP_JOB
    {
        [FieldOffset(0)]
        public _TP_DIRECT Direct;
        [FieldOffset(72)]
        public _TPP_CLEANUP_GROUP_MEMBER CleanupGroupMember;
        [FieldOffset(272)]
        public IntPtr JobHandle;
        [FieldOffset(280)]
        public long CompletionState;
        [FieldOffset(280)]
        public long Rundown;
        [FieldOffset(280)]
        public long CompletionCount;
        [FieldOffset(288)]
        public _RTL_SRWLOCK RundownLock;
    }
}