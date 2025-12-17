#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MI_AVAILABLE_PAGES_HUGE_GRANULARITY
    {
        [FieldOffset(0)]
        public uint SmallAvailablePages;
        [FieldOffset(0)]
        public uint LargeFreeZeroPages;
        [FieldOffset(0)]
        public uint Spare;
        [FieldOffset(0)]
        public uint EntireValue;
        [FieldOffset(0)]
        public int EntireValueSigned;
        [FieldOffset(0)]
        public int EntireValueVolatile;
    }
}