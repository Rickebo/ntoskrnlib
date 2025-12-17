#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _VF_KE_CRITICAL_REGION_TRACE
    {
        [FieldOffset(0)]
        public IntPtr Thread;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public IntPtr[] StackTrace;
    }
}