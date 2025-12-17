#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 288)]
    public partial struct _TP_IO
    {
        [FieldOffset(0)]
        public _TPP_CLEANUP_GROUP_MEMBER CleanupGroupMember;
        [FieldOffset(200)]
        public _TP_DIRECT Direct;
        [FieldOffset(272)]
        public IntPtr File;
        [FieldOffset(280)]
        public int PendingIrpCount;
    }
}