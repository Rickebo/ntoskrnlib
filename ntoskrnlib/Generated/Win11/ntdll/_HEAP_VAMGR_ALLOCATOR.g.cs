#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _HEAP_VAMGR_ALLOCATOR
    {
        [FieldOffset(0)]
        public ulong TreeLock;
        [FieldOffset(8)]
        public _RTL_RB_TREE FreeRanges;
        [FieldOffset(24)]
        public IntPtr VaSpace;
        [FieldOffset(32)]
        public IntPtr ContextHandle;
        [FieldOffset(40)]
        public ushort ChunksPerRegion;
        [FieldOffset(42)]
        public ushort RefCount;
        [FieldOffset(44)]
        public byte AllocatorIndex;
        [FieldOffset(45)]
        public byte NumaNode;
        [FieldOffset(46)]
        public byte LockType;
        [FieldOffset(46)]
        public byte MemoryType;
        [FieldOffset(46)]
        public byte ConstrainedVA;
        [FieldOffset(46)]
        public byte AllowFreeHead;
        [FieldOffset(46)]
        public byte Spare0;
        [FieldOffset(47)]
        public byte Spare1;
    }
}