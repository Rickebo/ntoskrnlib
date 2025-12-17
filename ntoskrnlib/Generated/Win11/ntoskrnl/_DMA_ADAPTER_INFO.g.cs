#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _DMA_ADAPTER_INFO
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public _DMA_ADAPTER_INFO_V1 V1;
        [FieldOffset(0)]
        public ulong Reserved;
        [FieldOffset(8)]
        public _DMA_ADAPTER_INFO_CRASHDUMP Crashdump;
    }
}