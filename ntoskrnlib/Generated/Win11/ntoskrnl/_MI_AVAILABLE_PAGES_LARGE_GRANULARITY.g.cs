#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _MI_AVAILABLE_PAGES_LARGE_GRANULARITY
    {
        [FieldOffset(0)]
        public ushort SmallAvailablePages;
        [FieldOffset(0)]
        public ushort MediumFreeZeroPages;
        [FieldOffset(0)]
        public ushort EntireValue;
        [FieldOffset(0)]
        public short EntireValueSigned;
        [FieldOffset(0)]
        public short EntireValueVolatile;
    }
}