using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_COMPRESSED_DATA_INFO")]
    public sealed class CompressedDataInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ushort CompressionFormatAndEngine { get => ReadHere<ushort>(nameof(CompressionFormatAndEngine)); set => WriteHere(nameof(CompressionFormatAndEngine), value); }

        [Offset(2UL)]
        public byte CompressionUnitShift { get => ReadHere<byte>(nameof(CompressionUnitShift)); set => WriteHere(nameof(CompressionUnitShift), value); }

        [Offset(3UL)]
        public byte ChunkShift { get => ReadHere<byte>(nameof(ChunkShift)); set => WriteHere(nameof(ChunkShift), value); }

        [Offset(4UL)]
        public byte ClusterShift { get => ReadHere<byte>(nameof(ClusterShift)); set => WriteHere(nameof(ClusterShift), value); }

        [Offset(5UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(6UL)]
        public ushort NumberOfChunks { get => ReadHere<ushort>(nameof(NumberOfChunks)); set => WriteHere(nameof(NumberOfChunks), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray CompressedChunkSizes { get => ReadStructure<DynamicArray>(nameof(CompressedChunkSizes)); set => WriteStructure(nameof(CompressedChunkSizes), value); }

        public CompressedDataInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CompressedDataInfo>();
        }
    }
}