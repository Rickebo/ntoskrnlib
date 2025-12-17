#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _POWER_SEQUENCE
    {
        [FieldOffset(0)]
        public uint SequenceD1;
        [FieldOffset(4)]
        public uint SequenceD2;
        [FieldOffset(8)]
        public uint SequenceD3;
    }
}