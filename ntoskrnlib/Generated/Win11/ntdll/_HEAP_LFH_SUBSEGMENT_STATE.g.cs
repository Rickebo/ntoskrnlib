#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _HEAP_LFH_SUBSEGMENT_STATE
    {
        [FieldOffset(0)]
        public ushort DelayFreeList;
        [FieldOffset(2)]
        public ushort DelayFreeCount;
        [FieldOffset(4)]
        public ushort Owner;
        [FieldOffset(6)]
        public byte Location;
        [FieldOffset(0)]
        public int DelayFreeFields;
        [FieldOffset(4)]
        public int OwnerLocation;
        [FieldOffset(0)]
        public _HEAP_LFH_BLOCK_LIST FreeList;
        [FieldOffset(0)]
        public IntPtr AllBits;
    }
}