#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _SECONDARY_INTERRUPT_LINE_STATE
    {
        [FieldOffset(0)]
        public uint Polarity;
        [FieldOffset(4)]
        public uint Mode;
        [FieldOffset(8)]
        public uint Vector;
        [FieldOffset(12)]
        public byte Unmasked;
    }
}