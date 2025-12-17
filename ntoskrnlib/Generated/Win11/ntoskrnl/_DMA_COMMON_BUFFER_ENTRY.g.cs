#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _DMA_COMMON_BUFFER_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr VirtualAddress;
        [FieldOffset(8)]
        public _LARGE_INTEGER LogicalAddress;
    }
}