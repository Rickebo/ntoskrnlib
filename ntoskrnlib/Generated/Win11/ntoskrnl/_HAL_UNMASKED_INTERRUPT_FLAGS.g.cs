#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _HAL_UNMASKED_INTERRUPT_FLAGS
    {
        [FieldOffset(0)]
        public ushort SecondaryInterrupt;
        [FieldOffset(0)]
        public ushort Reserved;
        [FieldOffset(0)]
        public ushort AsUSHORT;
    }
}