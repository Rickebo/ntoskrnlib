using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_VS_CHUNK_HEADER")]
    public sealed class HeapVsChunkHeader : DynamicStructure
    {
        [Offset(0UL)]
        public HeapVsChunkHeaderSize Sizes { get => ReadStructure<HeapVsChunkHeaderSize>(nameof(Sizes)); set => WriteStructure(nameof(Sizes), value); }

        [Offset(8UL)]
        public uint EncodedSegmentPageOffset { get => ReadHere<uint>(nameof(EncodedSegmentPageOffset)); set => WriteHere(nameof(EncodedSegmentPageOffset), value); }

        [Offset(8UL)]
        public uint UnusedBytes { get => ReadHere<uint>(nameof(UnusedBytes)); set => WriteHere(nameof(UnusedBytes), value); }

        [Offset(8UL)]
        public uint SkipDuringWalk { get => ReadHere<uint>(nameof(SkipDuringWalk)); set => WriteHere(nameof(SkipDuringWalk), value); }

        [Offset(8UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(8UL)]
        public uint AllocatedChunkBits { get => ReadHere<uint>(nameof(AllocatedChunkBits)); set => WriteHere(nameof(AllocatedChunkBits), value); }

        public HeapVsChunkHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapVsChunkHeader>();
        }
    }
}