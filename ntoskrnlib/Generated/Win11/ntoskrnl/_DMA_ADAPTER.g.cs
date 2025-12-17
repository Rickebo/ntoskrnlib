#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _DMA_ADAPTER
    {
        [FieldOffset(0)]
        public ushort Version;
        [FieldOffset(2)]
        public ushort Size;
        [FieldOffset(8)]
        public IntPtr DmaOperations;
    }
}