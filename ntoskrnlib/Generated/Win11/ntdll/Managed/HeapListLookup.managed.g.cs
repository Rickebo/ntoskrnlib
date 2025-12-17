using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_LIST_LOOKUP")]
    public sealed class HeapListLookup : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ExtendedLookup { get => ReadHere<IntPtr>(nameof(ExtendedLookup)); set => WriteHere(nameof(ExtendedLookup), value); }

        [Offset(8UL)]
        public uint ArraySize { get => ReadHere<uint>(nameof(ArraySize)); set => WriteHere(nameof(ArraySize), value); }

        [Offset(12UL)]
        public uint ExtraItem { get => ReadHere<uint>(nameof(ExtraItem)); set => WriteHere(nameof(ExtraItem), value); }

        [Offset(16UL)]
        public uint ItemCount { get => ReadHere<uint>(nameof(ItemCount)); set => WriteHere(nameof(ItemCount), value); }

        [Offset(20UL)]
        public uint OutOfRangeItems { get => ReadHere<uint>(nameof(OutOfRangeItems)); set => WriteHere(nameof(OutOfRangeItems), value); }

        [Offset(24UL)]
        public uint BaseIndex { get => ReadHere<uint>(nameof(BaseIndex)); set => WriteHere(nameof(BaseIndex), value); }

        [Offset(32UL)]
        public IntPtr ListHead { get => ReadHere<IntPtr>(nameof(ListHead)); set => WriteHere(nameof(ListHead), value); }

        [Offset(40UL)]
        public IntPtr ListsInUseUlong { get => ReadHere<IntPtr>(nameof(ListsInUseUlong)); set => WriteHere(nameof(ListsInUseUlong), value); }

        [Offset(48UL)]
        public IntPtr ListHints { get => ReadHere<IntPtr>(nameof(ListHints)); set => WriteHere(nameof(ListHints), value); }

        public HeapListLookup(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapListLookup>();
        }
    }
}