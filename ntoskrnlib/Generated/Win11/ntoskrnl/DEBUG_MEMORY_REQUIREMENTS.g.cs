#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct DEBUG_MEMORY_REQUIREMENTS
    {
        [FieldOffset(0)]
        public _LARGE_INTEGER Start;
        [FieldOffset(8)]
        public _LARGE_INTEGER MaxEnd;
        [FieldOffset(16)]
        public IntPtr VirtualAddress;
        [FieldOffset(24)]
        public uint Length;
        [FieldOffset(28)]
        public byte Cached;
        [FieldOffset(29)]
        public byte Aligned;
    }
}