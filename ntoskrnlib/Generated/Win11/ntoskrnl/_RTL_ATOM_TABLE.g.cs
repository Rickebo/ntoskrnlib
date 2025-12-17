#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _RTL_ATOM_TABLE
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(4)]
        public int ReferenceCount;
        [FieldOffset(8)]
        public _EX_PUSH_LOCK PushLock;
        [FieldOffset(16)]
        public IntPtr ExHandleTable;
        [FieldOffset(24)]
        public uint Flags;
        [FieldOffset(28)]
        public uint NumberOfBuckets;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public IntPtr[] Buckets;
    }
}