#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _HAL_HV_DMA_HYBRID_PASSTHROUGH_RESERVED_REGIONS
    {
        [FieldOffset(0)]
        public ulong UnitSizePages;
        [FieldOffset(8)]
        public _RTL_BITMAP ReservedUnitMap;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public uint[] ReservedUnitMapBuffer;
    }
}