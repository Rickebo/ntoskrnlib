#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _DMA_TRANSFER_INFO_V2
    {
        [FieldOffset(0)]
        public uint MapRegisterCount;
        [FieldOffset(4)]
        public uint ScatterGatherElementCount;
        [FieldOffset(8)]
        public uint ScatterGatherListSize;
        [FieldOffset(12)]
        public uint LogicalPageCount;
    }
}