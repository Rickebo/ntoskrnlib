using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_VAMGR_CTX")]
    public sealed class HeapVamgrCtx : DynamicStructure
    {
        [Offset(0UL)]
        public HeapVamgrVaspace VaSpace { get => ReadStructure<HeapVamgrVaspace>(nameof(VaSpace)); set => WriteStructure(nameof(VaSpace), value); }

        [Offset(2144UL)]
        public ulong AllocatorLock { get => ReadHere<ulong>(nameof(AllocatorLock)); set => WriteHere(nameof(AllocatorLock), value); }

        [Offset(2152UL)]
        public uint DefaultRegionSize { get => ReadHere<uint>(nameof(DefaultRegionSize)); set => WriteHere(nameof(DefaultRegionSize), value); }

        [Offset(2156UL)]
        public uint AllocatorCount { get => ReadHere<uint>(nameof(AllocatorCount)); set => WriteHere(nameof(AllocatorCount), value); }

        [Offset(2160UL)]
        [Length(255)]
        public DynamicArray Allocators { get => ReadStructure<DynamicArray>(nameof(Allocators)); set => WriteStructure(nameof(Allocators), value); }

        public HeapVamgrCtx(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapVamgrCtx>();
        }
    }
}