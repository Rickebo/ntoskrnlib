#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 248)]
    public partial struct _VI_DEADLOCK_RESOURCE
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public uint NodeCount;
        [FieldOffset(4)]
        public uint RecursionCount;
        [FieldOffset(8)]
        public IntPtr ResourceAddress;
        [FieldOffset(16)]
        public IntPtr ThreadOwner;
        [FieldOffset(24)]
        public _LIST_ENTRY ResourceList;
        [FieldOffset(40)]
        public _LIST_ENTRY HashChainList;
        [FieldOffset(40)]
        public _LIST_ENTRY FreeListEntry;
        [FieldOffset(56)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public IntPtr[] StackTrace;
        [FieldOffset(120)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public IntPtr[] LastAcquireTrace;
        [FieldOffset(184)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public IntPtr[] LastReleaseTrace;
    }
}