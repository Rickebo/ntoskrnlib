using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_VS_CHUNK_HEADER_SIZE")]
    public sealed class HeapVsChunkHeaderSize : DynamicStructure
    {
        [Offset(0UL)]
        public uint MemoryCost { get => ReadHere<uint>(nameof(MemoryCost)); set => WriteHere(nameof(MemoryCost), value); }

        [Offset(0UL)]
        public uint UnsafeSize { get => ReadHere<uint>(nameof(UnsafeSize)); set => WriteHere(nameof(UnsafeSize), value); }

        [Offset(4UL)]
        public uint UnsafePrevSize { get => ReadHere<uint>(nameof(UnsafePrevSize)); set => WriteHere(nameof(UnsafePrevSize), value); }

        [Offset(4UL)]
        public uint Allocated { get => ReadHere<uint>(nameof(Allocated)); set => WriteHere(nameof(Allocated), value); }

        [Offset(0UL)]
        public ushort KeyUShort { get => ReadHere<ushort>(nameof(KeyUShort)); set => WriteHere(nameof(KeyUShort), value); }

        [Offset(0UL)]
        public uint KeyULong { get => ReadHere<uint>(nameof(KeyULong)); set => WriteHere(nameof(KeyULong), value); }

        [Offset(0UL)]
        public ulong HeaderBits { get => ReadHere<ulong>(nameof(HeaderBits)); set => WriteHere(nameof(HeaderBits), value); }

        public HeapVsChunkHeaderSize(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapVsChunkHeaderSize>();
        }
    }
}