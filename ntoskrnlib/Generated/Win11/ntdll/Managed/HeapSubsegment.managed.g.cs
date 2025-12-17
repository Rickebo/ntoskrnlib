using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_SUBSEGMENT")]
    public sealed class HeapSubsegment : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr LocalInfo { get => ReadHere<IntPtr>(nameof(LocalInfo)); set => WriteHere(nameof(LocalInfo), value); }

        [Offset(8UL)]
        public IntPtr UserBlocks { get => ReadHere<IntPtr>(nameof(UserBlocks)); set => WriteHere(nameof(UserBlocks), value); }

        [Offset(16UL)]
        public SlistHeader DelayFreeList { get => ReadStructure<SlistHeader>(nameof(DelayFreeList)); set => WriteStructure(nameof(DelayFreeList), value); }

        [Offset(32UL)]
        public InterlockSeq AggregateExchg { get => ReadStructure<InterlockSeq>(nameof(AggregateExchg)); set => WriteStructure(nameof(AggregateExchg), value); }

        [Offset(36UL)]
        public ushort BlockSize { get => ReadHere<ushort>(nameof(BlockSize)); set => WriteHere(nameof(BlockSize), value); }

        [Offset(38UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(40UL)]
        public ushort BlockCount { get => ReadHere<ushort>(nameof(BlockCount)); set => WriteHere(nameof(BlockCount), value); }

        [Offset(42UL)]
        public byte SizeIndex { get => ReadHere<byte>(nameof(SizeIndex)); set => WriteHere(nameof(SizeIndex), value); }

        [Offset(43UL)]
        public byte AffinityIndex { get => ReadHere<byte>(nameof(AffinityIndex)); set => WriteHere(nameof(AffinityIndex), value); }

        [Offset(36UL)]
        [Length(2)]
        public DynamicArray Alignment { get => ReadStructure<DynamicArray>(nameof(Alignment)); set => WriteStructure(nameof(Alignment), value); }

        [Offset(44UL)]
        public uint Lock { get => ReadHere<uint>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(48UL)]
        public SingleListEntry SFreeListEntry { get => ReadStructure<SingleListEntry>(nameof(SFreeListEntry)); set => WriteStructure(nameof(SFreeListEntry), value); }

        public HeapSubsegment(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapSubsegment>();
        }
    }
}