#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _DMA_TRANSFER_INFO
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public _DMA_TRANSFER_INFO_V1 V1;
        [FieldOffset(4)]
        public _DMA_TRANSFER_INFO_V2 V2;
    }
}