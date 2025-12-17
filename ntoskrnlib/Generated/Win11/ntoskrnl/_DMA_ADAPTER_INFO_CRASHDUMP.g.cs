#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _DMA_ADAPTER_INFO_CRASHDUMP
    {
        [FieldOffset(0)]
        public _DEVICE_DESCRIPTION DeviceDescription;
        [FieldOffset(64)]
        public ulong DeviceIdSize;
        [FieldOffset(72)]
        public IntPtr DeviceId;
    }
}