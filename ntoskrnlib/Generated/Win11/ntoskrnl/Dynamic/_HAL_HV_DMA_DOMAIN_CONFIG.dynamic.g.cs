using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_HV_DMA_DOMAIN_CONFIG")]
    public sealed class _HAL_HV_DMA_DOMAIN_CONFIG : DynamicStructure
    {
        public uint Type { get; }
        public _HAL_HV_DMA_DOMAIN_CONFIG_ARM64 Arm64 { get; }
        public _HAL_HV_DMA_DOMAIN_CONFIG_X64 X64 { get; }

        public _HAL_HV_DMA_DOMAIN_CONFIG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_HV_DMA_DOMAIN_CONFIG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG.Arm64),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG.X64),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HAL_HV_DMA_DOMAIN_CONFIG>((mem, ptr) => new _HAL_HV_DMA_DOMAIN_CONFIG(mem, ptr), offsets);
        }
    }
}