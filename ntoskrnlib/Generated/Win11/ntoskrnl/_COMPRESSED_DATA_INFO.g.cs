#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _COMPRESSED_DATA_INFO
    {
        [FieldOffset(0)]
        public ushort CompressionFormatAndEngine;
        [FieldOffset(2)]
        public byte CompressionUnitShift;
        [FieldOffset(3)]
        public byte ChunkShift;
        [FieldOffset(4)]
        public byte ClusterShift;
        [FieldOffset(5)]
        public byte Reserved;
        [FieldOffset(6)]
        public ushort NumberOfChunks;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] CompressedChunkSizes;
    }
}