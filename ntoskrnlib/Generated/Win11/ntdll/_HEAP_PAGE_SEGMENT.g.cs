#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8192)]
    public partial struct _HEAP_PAGE_SEGMENT
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public ulong Signature;
        [FieldOffset(24)]
        public IntPtr SegmentCommitState;
        [FieldOffset(32)]
        public byte UnusedWatermark;
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public _HEAP_PAGE_RANGE_DESCRIPTOR[] DescArray;
    }
}