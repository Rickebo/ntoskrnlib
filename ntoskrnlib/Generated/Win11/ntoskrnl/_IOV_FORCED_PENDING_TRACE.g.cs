#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 512)]
    public partial struct _IOV_FORCED_PENDING_TRACE
    {
        [FieldOffset(0)]
        public IntPtr Irp;
        [FieldOffset(8)]
        public IntPtr Thread;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 62)]
        public IntPtr[] StackTrace;
    }
}