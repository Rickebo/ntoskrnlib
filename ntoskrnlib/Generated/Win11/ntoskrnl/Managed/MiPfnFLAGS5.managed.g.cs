using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PFN_FLAGS5")]
    public sealed class MiPfnFLAGS5 : DynamicStructure
    {
        [Offset(0UL)]
        public uint EntireField { get => ReadHere<uint>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        [Offset(0UL)]
        public UnnamedTag StandbyList { get => ReadStructure<UnnamedTag>(nameof(StandbyList)); set => WriteStructure(nameof(StandbyList), value); }

        [Offset(0UL)]
        public UnnamedTag MappedPageList { get => ReadStructure<UnnamedTag>(nameof(MappedPageList)); set => WriteStructure(nameof(MappedPageList), value); }

        [Offset(0UL)]
        public UnnamedTag Active { get => ReadStructure<UnnamedTag>(nameof(Active)); set => WriteStructure(nameof(Active), value); }

        public MiPfnFLAGS5(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPfnFLAGS5>();
        }
    }
}