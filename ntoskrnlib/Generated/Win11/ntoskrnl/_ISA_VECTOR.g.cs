#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 10)]
    public partial struct _ISA_VECTOR
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Length;
        [FieldOffset(2)]
        public byte Bus;
        [FieldOffset(3)]
        public byte Source;
        [FieldOffset(4)]
        public uint GlobalSystemInterruptVector;
        [FieldOffset(8)]
        public ushort Flags;
    }
}