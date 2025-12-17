using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_ALIGNED_SLIST")]
    public sealed class MiAlignedSlist : DynamicStructure
    {
        [Offset(0UL)]
        public SlistHeader SList { get => ReadStructure<SlistHeader>(nameof(SList)); set => WriteStructure(nameof(SList), value); }

        public MiAlignedSlist(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiAlignedSlist>();
        }
    }
}