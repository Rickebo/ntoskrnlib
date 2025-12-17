#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _HEAP_VS_CHUNK_HEADER_SIZE
    {
        [FieldOffset(0)]
        public uint MemoryCost;
        [FieldOffset(0)]
        public uint UnsafeSize;
        [FieldOffset(4)]
        public uint UnsafePrevSize;
        [FieldOffset(4)]
        public uint Allocated;
        [FieldOffset(0)]
        public ushort KeyUShort;
        [FieldOffset(0)]
        public uint KeyULong;
        [FieldOffset(0)]
        public ulong HeaderBits;
    }
}