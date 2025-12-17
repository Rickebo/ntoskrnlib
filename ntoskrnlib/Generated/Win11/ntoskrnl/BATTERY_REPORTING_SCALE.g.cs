#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct BATTERY_REPORTING_SCALE
    {
        [FieldOffset(0)]
        public uint Granularity;
        [FieldOffset(4)]
        public uint Capacity;
    }
}