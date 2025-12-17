#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 14400)]
    public partial struct _HEAP_VAMGR_CTX
    {
        [FieldOffset(0)]
        public _HEAP_VAMGR_VASPACE VaSpace;
        [FieldOffset(2144)]
        public ulong AllocatorLock;
        [FieldOffset(2152)]
        public uint DefaultRegionSize;
        [FieldOffset(2156)]
        public uint AllocatorCount;
        [FieldOffset(2160)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public _HEAP_VAMGR_ALLOCATOR[] Allocators;
    }
}