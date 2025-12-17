#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HAL_HV_DMA_DOMAIN_CONFIG_X64
    {
        [FieldOffset(0)]
        public _LARGE_INTEGER FirstLevelPageTableRoot;
        [FieldOffset(8)]
        public byte TranslationEnabled;
        [FieldOffset(9)]
        public byte Blocked;
    }
}