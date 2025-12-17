#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _DPH_HEAP_BLOCK
    {
        [FieldOffset(0)]
        public IntPtr pNextAlloc;
        [FieldOffset(0)]
        public _LIST_ENTRY AvailableEntry;
        [FieldOffset(0)]
        public _RTL_BALANCED_LINKS TableLinks;
        [FieldOffset(32)]
        public IntPtr pUserAllocation;
        [FieldOffset(40)]
        public IntPtr pVirtualBlock;
        [FieldOffset(48)]
        public ulong nVirtualBlockSize;
        [FieldOffset(56)]
        public ulong nVirtualAccessSize;
        [FieldOffset(64)]
        public ulong nUserRequestedSize;
        [FieldOffset(72)]
        public ulong nUserActualSize;
        [FieldOffset(80)]
        public IntPtr UserValue;
        [FieldOffset(88)]
        public uint UserFlags;
        [FieldOffset(96)]
        public IntPtr StackTrace;
        [FieldOffset(104)]
        public _LIST_ENTRY AdjacencyEntry;
        [FieldOffset(120)]
        public IntPtr pVirtualRegion;
    }
}