using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SUBSECTION_ENTRY1")]
    public sealed class MiSubsectionENTRY1 : DynamicStructure
    {
        [Offset(0UL)]
        public uint CrossPartitionReferences { get => ReadHere<uint>(nameof(CrossPartitionReferences)); set => WriteHere(nameof(CrossPartitionReferences), value); }

        [Offset(0UL)]
        public uint SubsectionMappedLarge { get => ReadHere<uint>(nameof(SubsectionMappedLarge)); set => WriteHere(nameof(SubsectionMappedLarge), value); }

        public MiSubsectionENTRY1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSubsectionENTRY1>();
        }
    }
}