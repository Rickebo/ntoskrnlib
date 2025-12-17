#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 424)]
    public partial struct _VF_POOL_TRACE
    {
        [FieldOffset(0)]
        public IntPtr Address;
        [FieldOffset(8)]
        public ulong Size;
        [FieldOffset(16)]
        public IntPtr Thread;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
        public IntPtr[] StackTrace;
    }
}