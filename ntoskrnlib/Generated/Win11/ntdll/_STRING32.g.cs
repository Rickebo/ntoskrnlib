#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _STRING32
    {
        [FieldOffset(0)]
        public ushort Length;
        [FieldOffset(2)]
        public ushort MaximumLength;
        [FieldOffset(4)]
        public uint Buffer;
    }
}