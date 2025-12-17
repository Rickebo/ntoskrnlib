using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_HV_DMA_DOMAIN_INFO")]
    public sealed class _HAL_HV_DMA_DOMAIN_INFO : DynamicStructure
    {
        public uint DomainId { get; }
        public byte IsStage1 { get; }

        public _HAL_HV_DMA_DOMAIN_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_HV_DMA_DOMAIN_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_HV_DMA_DOMAIN_INFO.DomainId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_DOMAIN_INFO.IsStage1),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_HAL_HV_DMA_DOMAIN_INFO>((mem, ptr) => new _HAL_HV_DMA_DOMAIN_INFO(mem, ptr), offsets);
        }
    }
}