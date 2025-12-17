using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_HV_DMA_DOMAIN_CONFIG_ARM64")]
    public sealed class _HAL_HV_DMA_DOMAIN_CONFIG_ARM64 : DynamicStructure
    {
        public _LARGE_INTEGER Ttbr0 { get; }
        public _LARGE_INTEGER Ttbr1 { get; }
        public uint Mair0 { get; }
        public uint Mair1 { get; }
        public byte InputSize0 { get; }
        public byte InputSize1 { get; }
        public ushort Asid { get; }
        public byte CoherentTableWalks { get; }
        public byte TranslationEnabled { get; }

        public _HAL_HV_DMA_DOMAIN_CONFIG_ARM64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_HV_DMA_DOMAIN_CONFIG_ARM64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG_ARM64.Ttbr0),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG_ARM64.Ttbr1),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG_ARM64.Mair0),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG_ARM64.Mair1),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG_ARM64.InputSize0),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG_ARM64.InputSize1),
                    new ulong[]
                    {
                        25UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG_ARM64.Asid),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG_ARM64.CoherentTableWalks),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG_ARM64.TranslationEnabled),
                    new ulong[]
                    {
                        29UL
                    }
                }
            };
            Register<_HAL_HV_DMA_DOMAIN_CONFIG_ARM64>((mem, ptr) => new _HAL_HV_DMA_DOMAIN_CONFIG_ARM64(mem, ptr), offsets);
        }
    }
}