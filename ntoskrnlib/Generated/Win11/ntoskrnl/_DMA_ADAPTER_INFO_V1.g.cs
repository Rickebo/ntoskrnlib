#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _DMA_ADAPTER_INFO_V1
    {
        [FieldOffset(0)]
        public uint ReadDmaCounterAvailable;
        [FieldOffset(4)]
        public uint ScatterGatherLimit;
        [FieldOffset(8)]
        public uint DmaAddressWidth;
        [FieldOffset(12)]
        public uint Flags;
        [FieldOffset(16)]
        public uint MinimumTransferUnit;
    }
}