#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _PROCESSOR_NUMBER
    {
        [FieldOffset(0)]
        public ushort Group;
        [FieldOffset(2)]
        public byte Number;
        [FieldOffset(3)]
        public byte Reserved;
    }
}