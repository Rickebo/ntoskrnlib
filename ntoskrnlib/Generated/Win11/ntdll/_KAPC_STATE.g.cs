#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _KAPC_STATE
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _LIST_ENTRY[] ApcListHead;
        [FieldOffset(32)]
        public IntPtr Process;
        [FieldOffset(40)]
        public byte InProgressFlags;
        [FieldOffset(40)]
        public byte KernelApcInProgress;
        [FieldOffset(40)]
        public byte SpecialApcInProgress;
        [FieldOffset(41)]
        public byte KernelApcPending;
        [FieldOffset(42)]
        public byte UserApcPendingAll;
        [FieldOffset(42)]
        public byte SpecialUserApcPending;
        [FieldOffset(42)]
        public byte UserApcPending;
    }
}