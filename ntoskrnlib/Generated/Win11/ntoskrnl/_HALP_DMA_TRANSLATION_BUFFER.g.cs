#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _HALP_DMA_TRANSLATION_BUFFER
    {
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(8)]
        public uint EntryCount;
        [FieldOffset(16)]
        public IntPtr Entries;
    }
}