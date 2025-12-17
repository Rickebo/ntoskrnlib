using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_VAMGR_VASPACE")]
    public sealed class HeapVamgrVaspace : DynamicStructure
    {
        [Offset(0UL)]
        public uint AddressSpaceType { get => ReadHere<uint>(nameof(AddressSpaceType)); set => WriteHere(nameof(AddressSpaceType), value); }

        [Offset(8UL)]
        public ulong BaseAddress { get => ReadHere<ulong>(nameof(BaseAddress)); set => WriteHere(nameof(BaseAddress), value); }

        [Offset(16UL)]
        public RtlSparseArray VaRangeArray { get => ReadStructure<RtlSparseArray>(nameof(VaRangeArray)); set => WriteStructure(nameof(VaRangeArray), value); }

        [Offset(16UL)]
        [Length(2128)]
        public DynamicArray VaRangeArrayBuffer { get => ReadStructure<DynamicArray>(nameof(VaRangeArrayBuffer)); set => WriteStructure(nameof(VaRangeArrayBuffer), value); }

        public HeapVamgrVaspace(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapVamgrVaspace>();
        }
    }
}