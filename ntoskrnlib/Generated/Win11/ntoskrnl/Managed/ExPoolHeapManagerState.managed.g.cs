using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EX_POOL_HEAP_MANAGER_STATE")]
    public sealed class ExPoolHeapManagerState : DynamicStructure
    {
        [Offset(0UL)]
        public RtlpHpHeapManager HeapManager { get => ReadStructure<RtlpHpHeapManager>(nameof(HeapManager)); set => WriteStructure(nameof(HeapManager), value); }

        [Offset(14560UL)]
        public ExPushLock PrivatePoolListLock { get => ReadStructure<ExPushLock>(nameof(PrivatePoolListLock)); set => WriteStructure(nameof(PrivatePoolListLock), value); }

        [Offset(14568UL)]
        [Length(2)]
        public DynamicArray PrivatePools { get => ReadStructure<DynamicArray>(nameof(PrivatePools)); set => WriteStructure(nameof(PrivatePools), value); }

        [Offset(14600UL)]
        public ulong PrivatePoolContextCookie { get => ReadHere<ulong>(nameof(PrivatePoolContextCookie)); set => WriteHere(nameof(PrivatePoolContextCookie), value); }

        [Offset(14608UL)]
        public uint NumberOfPools { get => ReadHere<uint>(nameof(NumberOfPools)); set => WriteHere(nameof(NumberOfPools), value); }

        [Offset(14656UL)]
        [Length(64)]
        public DynamicArray PoolNode { get => ReadStructure<DynamicArray>(nameof(PoolNode)); set => WriteStructure(nameof(PoolNode), value); }

        [Offset(551232UL)]
        [Length(4)]
        public DynamicArray SpecialHeaps { get => ReadStructure<DynamicArray>(nameof(SpecialHeaps)); set => WriteStructure(nameof(SpecialHeaps), value); }

        public ExPoolHeapManagerState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExPoolHeapManagerState>();
        }
    }
}