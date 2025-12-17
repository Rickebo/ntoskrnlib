#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32904)]
    public partial struct _STACK_TABLE
    {
        [FieldOffset(0)]
        public ushort NumStackTraces;
        [FieldOffset(2)]
        public ushort TraceCapacity;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public IntPtr[] StackTrace;
        [FieldOffset(136)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16381)]
        public ushort[] StackTableHash;
    }
}