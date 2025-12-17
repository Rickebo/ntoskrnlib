#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16920)]
    public partial struct _KTIMER_TABLE
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public IntPtr[] TimerExpiry;
        [FieldOffset(512)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] TimerEntries;
        [FieldOffset(16896)]
        public _KTIMER_TABLE_STATE TableState;
    }
}