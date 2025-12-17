#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 240)]
    public partial struct _TP_WORK
    {
        [FieldOffset(0)]
        public _TPP_CLEANUP_GROUP_MEMBER CleanupGroupMember;
        [FieldOffset(200)]
        public _TP_TASK Task;
        [FieldOffset(232)]
        public _TPP_WORK_STATE WorkState;
    }
}