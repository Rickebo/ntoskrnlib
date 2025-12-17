using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_RUNTIME_MEMORY_STATS")]
    public sealed class HeapRuntimeMemoryStats : DynamicStructure
    {
        [Offset(0UL)]
        public ulong TotalReservedPages { get => ReadHere<ulong>(nameof(TotalReservedPages)); set => WriteHere(nameof(TotalReservedPages), value); }

        [Offset(8UL)]
        public ulong TotalCommittedPages { get => ReadHere<ulong>(nameof(TotalCommittedPages)); set => WriteHere(nameof(TotalCommittedPages), value); }

        [Offset(16UL)]
        public ulong FreeCommittedPages { get => ReadHere<ulong>(nameof(FreeCommittedPages)); set => WriteHere(nameof(FreeCommittedPages), value); }

        [Offset(24UL)]
        public ulong LfhFreeCommittedPages { get => ReadHere<ulong>(nameof(LfhFreeCommittedPages)); set => WriteHere(nameof(LfhFreeCommittedPages), value); }

        [Offset(32UL)]
        public ulong VsFreeCommittedPages { get => ReadHere<ulong>(nameof(VsFreeCommittedPages)); set => WriteHere(nameof(VsFreeCommittedPages), value); }

        [Offset(40UL)]
        [Length(2)]
        public DynamicArray LargePageStats { get => ReadStructure<DynamicArray>(nameof(LargePageStats)); set => WriteStructure(nameof(LargePageStats), value); }

        [Offset(72UL)]
        public RtlHpSegAllocPolicy LargePageUtilizationPolicy { get => ReadStructure<RtlHpSegAllocPolicy>(nameof(LargePageUtilizationPolicy)); set => WriteStructure(nameof(LargePageUtilizationPolicy), value); }

        public HeapRuntimeMemoryStats(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapRuntimeMemoryStats>();
        }
    }
}