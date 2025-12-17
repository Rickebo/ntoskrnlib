using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_STOP_ON_VALUES")]
    public sealed class HeapStopOnValues : DynamicStructure
    {
        [Offset(0UL)]
        public ulong AllocAddress { get => ReadHere<ulong>(nameof(AllocAddress)); set => WriteHere(nameof(AllocAddress), value); }

        [Offset(8UL)]
        public HeapStopOnTag AllocTag { get => ReadStructure<HeapStopOnTag>(nameof(AllocTag)); set => WriteStructure(nameof(AllocTag), value); }

        [Offset(16UL)]
        public ulong ReAllocAddress { get => ReadHere<ulong>(nameof(ReAllocAddress)); set => WriteHere(nameof(ReAllocAddress), value); }

        [Offset(24UL)]
        public HeapStopOnTag ReAllocTag { get => ReadStructure<HeapStopOnTag>(nameof(ReAllocTag)); set => WriteStructure(nameof(ReAllocTag), value); }

        [Offset(32UL)]
        public ulong FreeAddress { get => ReadHere<ulong>(nameof(FreeAddress)); set => WriteHere(nameof(FreeAddress), value); }

        [Offset(40UL)]
        public HeapStopOnTag FreeTag { get => ReadStructure<HeapStopOnTag>(nameof(FreeTag)); set => WriteStructure(nameof(FreeTag), value); }

        public HeapStopOnValues(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapStopOnValues>();
        }
    }
}