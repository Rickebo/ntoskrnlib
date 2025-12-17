using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_VAMGR_RANGE")]
    public sealed class HeapVamgrRange : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedNode RbNode { get => ReadStructure<RtlBalancedNode>(nameof(RbNode)); set => WriteStructure(nameof(RbNode), value); }

        [Offset(0UL)]
        public SingleListEntry Next { get => ReadStructure<SingleListEntry>(nameof(Next)); set => WriteStructure(nameof(Next), value); }

        [Offset(0UL)]
        public byte Allocated { get => ReadHere<byte>(nameof(Allocated)); set => WriteHere(nameof(Allocated), value); }

        [Offset(0UL)]
        public byte Internal { get => ReadHere<byte>(nameof(Internal)); set => WriteHere(nameof(Internal), value); }

        [Offset(0UL)]
        public byte Standalone { get => ReadHere<byte>(nameof(Standalone)); set => WriteHere(nameof(Standalone), value); }

        [Offset(0UL)]
        public byte Spare0 { get => ReadHere<byte>(nameof(Spare0)); set => WriteHere(nameof(Spare0), value); }

        [Offset(1UL)]
        public byte AllocatorIndex { get => ReadHere<byte>(nameof(AllocatorIndex)); set => WriteHere(nameof(AllocatorIndex), value); }

        [Offset(2UL)]
        public ushort CommitBitmap { get => ReadHere<ushort>(nameof(CommitBitmap)); set => WriteHere(nameof(CommitBitmap), value); }

        [Offset(8UL)]
        [Length(2)]
        public DynamicArray OwnerCtx { get => ReadStructure<DynamicArray>(nameof(OwnerCtx)); set => WriteStructure(nameof(OwnerCtx), value); }

        [Offset(24UL)]
        public ulong SizeInChunks { get => ReadHere<ulong>(nameof(SizeInChunks)); set => WriteHere(nameof(SizeInChunks), value); }

        [Offset(24UL)]
        public ushort ChunkCount { get => ReadHere<ushort>(nameof(ChunkCount)); set => WriteHere(nameof(ChunkCount), value); }

        [Offset(26UL)]
        public ushort PrevChunkCount { get => ReadHere<ushort>(nameof(PrevChunkCount)); set => WriteHere(nameof(PrevChunkCount), value); }

        [Offset(24UL)]
        public ulong Signature { get => ReadHere<ulong>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        public HeapVamgrRange(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapVamgrRange>();
        }
    }
}