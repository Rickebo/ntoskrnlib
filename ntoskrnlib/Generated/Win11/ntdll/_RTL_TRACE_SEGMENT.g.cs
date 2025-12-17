#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _RTL_TRACE_SEGMENT
    {
        [FieldOffset(0)]
        public uint Magic;
        [FieldOffset(8)]
        public IntPtr Database;
        [FieldOffset(16)]
        public IntPtr NextSegment;
        [FieldOffset(24)]
        public ulong TotalSize;
        [FieldOffset(32)]
        public IntPtr SegmentStart;
        [FieldOffset(40)]
        public IntPtr SegmentEnd;
        [FieldOffset(48)]
        public IntPtr SegmentFree;
    }
}