using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_ENTRY_EXTRA")]
    public sealed class HeapEntryExtra : DynamicStructure
    {
        [Offset(0UL)]
        public ushort AllocatorBackTraceIndex { get => ReadHere<ushort>(nameof(AllocatorBackTraceIndex)); set => WriteHere(nameof(AllocatorBackTraceIndex), value); }

        [Offset(2UL)]
        public ushort TagIndex { get => ReadHere<ushort>(nameof(TagIndex)); set => WriteHere(nameof(TagIndex), value); }

        [Offset(8UL)]
        public ulong Settable { get => ReadHere<ulong>(nameof(Settable)); set => WriteHere(nameof(Settable), value); }

        [Offset(0UL)]
        public ulong ZeroInit { get => ReadHere<ulong>(nameof(ZeroInit)); set => WriteHere(nameof(ZeroInit), value); }

        [Offset(8UL)]
        public ulong ZeroInit1 { get => ReadHere<ulong>(nameof(ZeroInit1)); set => WriteHere(nameof(ZeroInit1), value); }

        public HeapEntryExtra(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapEntryExtra>();
        }
    }
}