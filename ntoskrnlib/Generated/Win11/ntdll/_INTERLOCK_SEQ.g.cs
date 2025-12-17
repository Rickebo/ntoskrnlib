#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _INTERLOCK_SEQ
    {
        [FieldOffset(0)]
        public ushort Depth;
        [FieldOffset(2)]
        public ushort Hint;
        [FieldOffset(2)]
        public ushort Lock;
        [FieldOffset(2)]
        public ushort Hint16;
        [FieldOffset(0)]
        public int Exchg;
    }
}