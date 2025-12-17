#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _STRING64
    {
        [FieldOffset(0)]
        public ushort Length;
        [FieldOffset(2)]
        public ushort MaximumLength;
        [FieldOffset(8)]
        public ulong Buffer;
    }
}