using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_VAMGR_ALLOCATOR")]
    public sealed class HeapVamgrAllocator : DynamicStructure
    {
        [Offset(0UL)]
        public ulong TreeLock { get => ReadHere<ulong>(nameof(TreeLock)); set => WriteHere(nameof(TreeLock), value); }

        [Offset(8UL)]
        public RtlRbTree FreeRanges { get => ReadStructure<RtlRbTree>(nameof(FreeRanges)); set => WriteStructure(nameof(FreeRanges), value); }

        [Offset(24UL)]
        public IntPtr VaSpace { get => ReadHere<IntPtr>(nameof(VaSpace)); set => WriteHere(nameof(VaSpace), value); }

        [Offset(32UL)]
        public IntPtr ContextHandle { get => ReadHere<IntPtr>(nameof(ContextHandle)); set => WriteHere(nameof(ContextHandle), value); }

        [Offset(40UL)]
        public ushort ChunksPerRegion { get => ReadHere<ushort>(nameof(ChunksPerRegion)); set => WriteHere(nameof(ChunksPerRegion), value); }

        [Offset(42UL)]
        public ushort RefCount { get => ReadHere<ushort>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(44UL)]
        public byte AllocatorIndex { get => ReadHere<byte>(nameof(AllocatorIndex)); set => WriteHere(nameof(AllocatorIndex), value); }

        [Offset(45UL)]
        public byte NumaNode { get => ReadHere<byte>(nameof(NumaNode)); set => WriteHere(nameof(NumaNode), value); }

        [Offset(46UL)]
        public byte LockType { get => ReadHere<byte>(nameof(LockType)); set => WriteHere(nameof(LockType), value); }

        [Offset(46UL)]
        public byte MemoryType { get => ReadHere<byte>(nameof(MemoryType)); set => WriteHere(nameof(MemoryType), value); }

        [Offset(46UL)]
        public byte ConstrainedVA { get => ReadHere<byte>(nameof(ConstrainedVA)); set => WriteHere(nameof(ConstrainedVA), value); }

        [Offset(46UL)]
        public byte AllowFreeHead { get => ReadHere<byte>(nameof(AllowFreeHead)); set => WriteHere(nameof(AllowFreeHead), value); }

        [Offset(46UL)]
        public byte Spare0 { get => ReadHere<byte>(nameof(Spare0)); set => WriteHere(nameof(Spare0), value); }

        [Offset(47UL)]
        public byte Spare1 { get => ReadHere<byte>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        public HeapVamgrAllocator(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapVamgrAllocator>();
        }
    }
}