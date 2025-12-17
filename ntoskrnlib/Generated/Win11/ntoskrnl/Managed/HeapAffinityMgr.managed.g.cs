using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_AFFINITY_MGR")]
    public sealed class HeapAffinityMgr : DynamicStructure
    {
        [Offset(0UL)]
        public sbyte MapInProgress { get => ReadHere<sbyte>(nameof(MapInProgress)); set => WriteHere(nameof(MapInProgress), value); }

        [Offset(1UL)]
        public sbyte ContentionCount { get => ReadHere<sbyte>(nameof(ContentionCount)); set => WriteHere(nameof(ContentionCount), value); }

        [Offset(2UL)]
        public byte ContentionCountLimit { get => ReadHere<byte>(nameof(ContentionCountLimit)); set => WriteHere(nameof(ContentionCountLimit), value); }

        [Offset(3UL)]
        public byte ConservativeAffinity { get => ReadHere<byte>(nameof(ConservativeAffinity)); set => WriteHere(nameof(ConservativeAffinity), value); }

        [Offset(8UL)]
        public ulong LastContentionTime { get => ReadHere<ulong>(nameof(LastContentionTime)); set => WriteHere(nameof(LastContentionTime), value); }

        public HeapAffinityMgr(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapAffinityMgr>();
        }
    }
}