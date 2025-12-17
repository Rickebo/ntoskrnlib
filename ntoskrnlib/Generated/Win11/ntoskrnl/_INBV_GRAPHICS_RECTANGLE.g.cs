#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _INBV_GRAPHICS_RECTANGLE
    {
        [FieldOffset(0)]
        public uint Height;
        [FieldOffset(4)]
        public uint Width;
        [FieldOffset(8)]
        public uint PixelFormat;
        [FieldOffset(12)]
        public uint Size;
        [FieldOffset(16)]
        public IntPtr Data;
    }
}