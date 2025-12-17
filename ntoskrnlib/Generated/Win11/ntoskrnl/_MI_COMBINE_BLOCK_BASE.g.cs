#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _MI_COMBINE_BLOCK_BASE
    {
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(8)]
        public uint NumberOfActiveBlocks;
        [FieldOffset(16)]
        public IntPtr Pcs;
    }
}