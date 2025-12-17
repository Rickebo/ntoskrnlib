#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _INBV_MODE_INFORMATION
    {
        [FieldOffset(0)]
        public uint Height;
        [FieldOffset(4)]
        public uint Width;
        [FieldOffset(8)]
        public uint Stride;
        [FieldOffset(12)]
        public uint PixelFormat;
    }
}