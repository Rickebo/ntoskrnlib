#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _DBGKD_FILL_MEMORY
    {
        [FieldOffset(0)]
        public ulong Address;
        [FieldOffset(8)]
        public uint Length;
        [FieldOffset(12)]
        public ushort Flags;
        [FieldOffset(14)]
        public ushort PatternLength;
    }
}