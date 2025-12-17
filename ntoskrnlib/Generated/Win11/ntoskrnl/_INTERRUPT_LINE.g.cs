#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _INTERRUPT_LINE
    {
        [FieldOffset(0)]
        public uint UnitId;
        [FieldOffset(4)]
        public int Line;
    }
}