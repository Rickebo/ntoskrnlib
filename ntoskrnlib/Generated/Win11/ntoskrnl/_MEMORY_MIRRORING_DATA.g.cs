#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _MEMORY_MIRRORING_DATA
    {
        [FieldOffset(0)]
        public uint MemoryRangeCount;
        [FieldOffset(4)]
        public uint IoSpaceRangeCount;
        [FieldOffset(8)]
        public IntPtr MemoryRanges;
        [FieldOffset(16)]
        public IntPtr IoSpaceRanges;
    }
}