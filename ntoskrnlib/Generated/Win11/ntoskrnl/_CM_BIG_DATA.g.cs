#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _CM_BIG_DATA
    {
        [FieldOffset(0)]
        public ushort Signature;
        [FieldOffset(2)]
        public ushort Count;
        [FieldOffset(4)]
        public uint List;
    }
}