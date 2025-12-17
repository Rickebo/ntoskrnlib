#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _I386_LOADER_BLOCK
    {
        [FieldOffset(0)]
        public IntPtr CommonDataArea;
        [FieldOffset(8)]
        public uint MachineType;
        [FieldOffset(12)]
        public uint VirtualBias;
    }
}