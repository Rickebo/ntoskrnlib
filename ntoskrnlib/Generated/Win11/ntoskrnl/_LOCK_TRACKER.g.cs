#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public partial struct _LOCK_TRACKER
    {
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE LockTrackerNode;
        [FieldOffset(24)]
        public IntPtr Mdl;
        [FieldOffset(32)]
        public IntPtr StartVa;
        [FieldOffset(40)]
        public ulong Count;
        [FieldOffset(48)]
        public uint Offset;
        [FieldOffset(52)]
        public uint Length;
        [FieldOffset(56)]
        public uint Who;
        [FieldOffset(60)]
        public uint Hash;
        [FieldOffset(64)]
        public ulong Page;
        [FieldOffset(72)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
        public IntPtr[] StackTrace;
        [FieldOffset(184)]
        public IntPtr Process;
    }
}