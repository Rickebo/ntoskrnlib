using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_HV_DMA_CREATE_DOMAIN_INFO")]
    public sealed class HalHvDmaCreateDomainInfo : DynamicStructure
    {
        [Offset(0UL)]
        public HalHvDmaDomainInfo DomainInfo { get => ReadStructure<HalHvDmaDomainInfo>(nameof(DomainInfo)); set => WriteStructure(nameof(DomainInfo), value); }

        [Offset(8UL)]
        public byte InheritPassthroughDomain { get => ReadHere<byte>(nameof(InheritPassthroughDomain)); set => WriteHere(nameof(InheritPassthroughDomain), value); }

        [Offset(9UL)]
        public byte ForwardProgressRequired { get => ReadHere<byte>(nameof(ForwardProgressRequired)); set => WriteHere(nameof(ForwardProgressRequired), value); }

        public HalHvDmaCreateDomainInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalHvDmaCreateDomainInfo>();
        }
    }
}