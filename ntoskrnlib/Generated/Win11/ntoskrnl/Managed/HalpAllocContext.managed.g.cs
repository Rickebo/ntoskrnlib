using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HALP_ALLOC_CONTEXT")]
    public sealed class HalpAllocContext : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry BufferList { get => ReadStructure<ListEntry>(nameof(BufferList)); set => WriteStructure(nameof(BufferList), value); }

        [Offset(16UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        public HalpAllocContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalpAllocContext>();
        }
    }
}