using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_HV_DMA_CREATE_DOMAIN_INFO")]
    public sealed class _HAL_HV_DMA_CREATE_DOMAIN_INFO : DynamicStructure
    {
        public _HAL_HV_DMA_DOMAIN_INFO DomainInfo { get; }
        public byte InheritPassthroughDomain { get; }
        public byte ForwardProgressRequired { get; }

        public _HAL_HV_DMA_CREATE_DOMAIN_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_HV_DMA_CREATE_DOMAIN_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_HV_DMA_CREATE_DOMAIN_INFO.DomainInfo),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_CREATE_DOMAIN_INFO.InheritPassthroughDomain),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_CREATE_DOMAIN_INFO.ForwardProgressRequired),
                    new ulong[]
                    {
                        9UL
                    }
                }
            };
            Register<_HAL_HV_DMA_CREATE_DOMAIN_INFO>((mem, ptr) => new _HAL_HV_DMA_CREATE_DOMAIN_INFO(mem, ptr), offsets);
        }
    }
}