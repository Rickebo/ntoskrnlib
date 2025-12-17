#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public partial struct _RTL_TRACE_DATABASE
    {
        [FieldOffset(0)]
        public uint Magic;
        [FieldOffset(4)]
        public uint Flags;
        [FieldOffset(8)]
        public uint Tag;
        [FieldOffset(16)]
        public IntPtr SegmentList;
        [FieldOffset(24)]
        public ulong MaximumSize;
        [FieldOffset(32)]
        public ulong CurrentSize;
        [FieldOffset(40)]
        public IntPtr Owner;
        [FieldOffset(48)]
        public _RTL_CRITICAL_SECTION Lock;
        [FieldOffset(88)]
        public uint NoOfBuckets;
        [FieldOffset(96)]
        public IntPtr Buckets;
        [FieldOffset(104)]
        public IntPtr HashFunction;
        [FieldOffset(112)]
        public ulong NoOfTraces;
        [FieldOffset(120)]
        public ulong NoOfHits;
        [FieldOffset(128)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public uint[] HashCounter;
    }
}