#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial struct _DMA_TRANSFER_CONTEXT
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(8)]
        public _DMA_TRANSFER_CONTEXT_V1 V1;
    }
}