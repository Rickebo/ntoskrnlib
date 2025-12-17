#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _VI_FAULT_TRACE
    {
        [FieldOffset(0)]
        public IntPtr Thread;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public IntPtr[] StackTrace;
    }
}