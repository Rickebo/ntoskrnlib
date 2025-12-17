#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HALP_DMA_TRANSLATION_BUFFER_POSITION
    {
        [FieldOffset(0)]
        public IntPtr Buffer;
        [FieldOffset(8)]
        public uint Offset;
    }
}