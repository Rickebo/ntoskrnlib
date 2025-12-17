#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 232)]
    public partial struct _HALP_DMA_MASTER_ADAPTER_OBJECT
    {
        [FieldOffset(0)]
        public _HALP_DMA_ADAPTER_OBJECT AdapterObject;
        [FieldOffset(160)]
        public ulong QueueLock;
        [FieldOffset(168)]
        public _LIST_ENTRY ContiguousAdapterQueue;
        [FieldOffset(184)]
        public _LIST_ENTRY ScatterAdapterQueue;
        [FieldOffset(200)]
        public uint MapBufferSize;
        [FieldOffset(208)]
        public _LARGE_INTEGER MapBufferPhysicalAddress;
        [FieldOffset(216)]
        public uint ContiguousPageCount;
        [FieldOffset(220)]
        public uint ContiguousPageLimit;
        [FieldOffset(224)]
        public uint ScatterPageCount;
        [FieldOffset(228)]
        public uint ScatterPageLimit;
    }
}