using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PNP_REPLACE_PROCESSOR_LIST")]
    public sealed class PnpReplaceProcessorList : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Affinity { get => ReadHere<IntPtr>(nameof(Affinity)); set => WriteHere(nameof(Affinity), value); }

        [Offset(8UL)]
        public uint GroupCount { get => ReadHere<uint>(nameof(GroupCount)); set => WriteHere(nameof(GroupCount), value); }

        [Offset(12UL)]
        public uint AllocatedCount { get => ReadHere<uint>(nameof(AllocatedCount)); set => WriteHere(nameof(AllocatedCount), value); }

        [Offset(16UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(20UL)]
        [Length(1)]
        public DynamicArray ApicIds { get => ReadStructure<DynamicArray>(nameof(ApicIds)); set => WriteStructure(nameof(ApicIds), value); }

        public PnpReplaceProcessorList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PnpReplaceProcessorList>();
        }
    }
}