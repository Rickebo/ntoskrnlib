#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _HAL_HV_DMA_DOMAIN_CONFIG
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(8)]
        public _HAL_HV_DMA_DOMAIN_CONFIG_ARM64 Arm64;
        [FieldOffset(8)]
        public _HAL_HV_DMA_DOMAIN_CONFIG_X64 X64;
    }
}