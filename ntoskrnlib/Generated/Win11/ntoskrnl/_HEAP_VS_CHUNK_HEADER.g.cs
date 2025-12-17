#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HEAP_VS_CHUNK_HEADER
    {
        [FieldOffset(0)]
        public _HEAP_VS_CHUNK_HEADER_SIZE Sizes;
        [FieldOffset(8)]
        public uint EncodedSegmentPageOffset;
        [FieldOffset(8)]
        public uint UnusedBytes;
        [FieldOffset(8)]
        public uint SkipDuringWalk;
        [FieldOffset(8)]
        public uint Spare;
        [FieldOffset(8)]
        public uint AllocatedChunkBits;
    }
}