using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_HV_DMA_DOMAIN_INFO")]
    public sealed class HalHvDmaDomainInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint DomainId { get => ReadHere<uint>(nameof(DomainId)); set => WriteHere(nameof(DomainId), value); }

        [Offset(4UL)]
        public byte IsStage1 { get => ReadHere<byte>(nameof(IsStage1)); set => WriteHere(nameof(IsStage1), value); }

        public HalHvDmaDomainInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalHvDmaDomainInfo>();
        }
    }
}