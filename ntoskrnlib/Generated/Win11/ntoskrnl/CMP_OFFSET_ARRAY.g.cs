#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct CMP_OFFSET_ARRAY
    {
        [FieldOffset(0)]
        public uint FileOffset;
        [FieldOffset(8)]
        public IntPtr DataBuffer;
        [FieldOffset(16)]
        public uint DataLength;
    }
}