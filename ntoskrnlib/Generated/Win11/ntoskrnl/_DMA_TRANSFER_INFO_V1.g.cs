#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _DMA_TRANSFER_INFO_V1
    {
        [FieldOffset(0)]
        public uint MapRegisterCount;
        [FieldOffset(4)]
        public uint ScatterGatherElementCount;
        [FieldOffset(8)]
        public uint ScatterGatherListSize;
    }
}