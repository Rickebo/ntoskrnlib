#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _HEAP_LIST_LOOKUP
    {
        [FieldOffset(0)]
        public IntPtr ExtendedLookup;
        [FieldOffset(8)]
        public uint ArraySize;
        [FieldOffset(12)]
        public uint ExtraItem;
        [FieldOffset(16)]
        public uint ItemCount;
        [FieldOffset(20)]
        public uint OutOfRangeItems;
        [FieldOffset(24)]
        public uint BaseIndex;
        [FieldOffset(32)]
        public IntPtr ListHead;
        [FieldOffset(40)]
        public IntPtr ListsInUseUlong;
        [FieldOffset(48)]
        public IntPtr ListHints;
    }
}