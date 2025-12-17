#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _HEAP_DESCRIPTOR_KEY
    {
        [FieldOffset(0)]
        public uint Key;
        [FieldOffset(0)]
        public uint EncodedCommittedPageCount;
        [FieldOffset(0)]
        public uint LargePageCost;
        [FieldOffset(0)]
        public uint UnitCount;
    }
}