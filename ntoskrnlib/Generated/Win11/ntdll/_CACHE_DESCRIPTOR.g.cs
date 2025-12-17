#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _CACHE_DESCRIPTOR
    {
        [FieldOffset(0)]
        public byte Level;
        [FieldOffset(1)]
        public byte Associativity;
        [FieldOffset(2)]
        public ushort LineSize;
        [FieldOffset(4)]
        public uint Size;
        [FieldOffset(8)]
        public uint Type;
    }
}