#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _MI_PAGEFILE_BITMAPS_CACHE_ENTRY
    {
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE LengthTreeNode;
        [FieldOffset(0)]
        public _LIST_ENTRY FreeListEntry;
        [FieldOffset(24)]
        public _RTL_BALANCED_NODE LocationTreeNode;
        [FieldOffset(48)]
        public uint StartingIndex;
        [FieldOffset(52)]
        public uint Length;
    }
}