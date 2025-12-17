#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 440)]
    public partial struct _PROCESS_EXTENDED_ENERGY_VALUES_V1
    {
        [FieldOffset(0)]
        public _PROCESS_ENERGY_VALUES Base;
        [FieldOffset(272)]
        public _PROCESS_ENERGY_VALUES_EXTENSION Extension;
        [FieldOffset(432)]
        public ulong NpuWorkUnits;
    }
}