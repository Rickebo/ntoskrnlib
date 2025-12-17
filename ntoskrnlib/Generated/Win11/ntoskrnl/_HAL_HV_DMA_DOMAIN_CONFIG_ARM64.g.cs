#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _HAL_HV_DMA_DOMAIN_CONFIG_ARM64
    {
        [FieldOffset(0)]
        public _LARGE_INTEGER Ttbr0;
        [FieldOffset(8)]
        public _LARGE_INTEGER Ttbr1;
        [FieldOffset(16)]
        public uint Mair0;
        [FieldOffset(20)]
        public uint Mair1;
        [FieldOffset(24)]
        public byte InputSize0;
        [FieldOffset(25)]
        public byte InputSize1;
        [FieldOffset(26)]
        public ushort Asid;
        [FieldOffset(28)]
        public byte CoherentTableWalks;
        [FieldOffset(29)]
        public byte TranslationEnabled;
    }
}