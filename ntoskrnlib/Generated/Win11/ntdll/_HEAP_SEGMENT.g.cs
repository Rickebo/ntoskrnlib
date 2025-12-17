#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _HEAP_SEGMENT
    {
        [FieldOffset(0)]
        public _HEAP_ENTRY Entry;
        [FieldOffset(16)]
        public uint SegmentSignature;
        [FieldOffset(20)]
        public uint SegmentFlags;
        [FieldOffset(24)]
        public _LIST_ENTRY SegmentListEntry;
        [FieldOffset(40)]
        public IntPtr Heap;
        [FieldOffset(48)]
        public IntPtr BaseAddress;
        [FieldOffset(56)]
        public uint NumberOfPages;
        [FieldOffset(64)]
        public IntPtr FirstEntry;
        [FieldOffset(72)]
        public IntPtr LastValidEntry;
        [FieldOffset(80)]
        public uint NumberOfUnCommittedPages;
        [FieldOffset(84)]
        public uint NumberOfUnCommittedRanges;
        [FieldOffset(88)]
        public ushort SegmentAllocatorBackTraceIndex;
        [FieldOffset(90)]
        public ushort Reserved;
        [FieldOffset(96)]
        public _LIST_ENTRY UCRSegmentList;
    }
}