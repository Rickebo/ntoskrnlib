using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_TAG_ENTRY")]
    public sealed class HeapTagEntry : DynamicStructure
    {
        [Offset(0UL)]
        public uint Allocs { get => ReadHere<uint>(nameof(Allocs)); set => WriteHere(nameof(Allocs), value); }

        [Offset(4UL)]
        public uint Frees { get => ReadHere<uint>(nameof(Frees)); set => WriteHere(nameof(Frees), value); }

        [Offset(8UL)]
        public ulong Size { get => ReadHere<ulong>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(16UL)]
        public ushort TagIndex { get => ReadHere<ushort>(nameof(TagIndex)); set => WriteHere(nameof(TagIndex), value); }

        [Offset(18UL)]
        public ushort CreatorBackTraceIndex { get => ReadHere<ushort>(nameof(CreatorBackTraceIndex)); set => WriteHere(nameof(CreatorBackTraceIndex), value); }

        [Offset(20UL)]
        [Length(24)]
        public DynamicArray TagName { get => ReadStructure<DynamicArray>(nameof(TagName)); set => WriteStructure(nameof(TagName), value); }

        public HeapTagEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapTagEntry>();
        }
    }
}