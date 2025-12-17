using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_ACTIVE_PFN")]
    public sealed class MiActivePfn : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag Leaf { get => ReadStructure<UnnamedTag>(nameof(Leaf)); set => WriteStructure(nameof(Leaf), value); }

        [Offset(0UL)]
        public UnnamedTag PageTable { get => ReadStructure<UnnamedTag>(nameof(PageTable)); set => WriteStructure(nameof(PageTable), value); }

        [Offset(0UL)]
        public ulong EntireActiveField { get => ReadHere<ulong>(nameof(EntireActiveField)); set => WriteHere(nameof(EntireActiveField), value); }

        public MiActivePfn(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiActivePfn>();
        }
    }
}