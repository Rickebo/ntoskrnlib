using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_HV_DMA_DOMAIN_CONFIG_X64")]
    public sealed class _HAL_HV_DMA_DOMAIN_CONFIG_X64 : DynamicStructure
    {
        public _LARGE_INTEGER FirstLevelPageTableRoot { get; }
        public byte TranslationEnabled { get; }
        public byte Blocked { get; }

        public _HAL_HV_DMA_DOMAIN_CONFIG_X64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_HV_DMA_DOMAIN_CONFIG_X64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG_X64.FirstLevelPageTableRoot),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG_X64.TranslationEnabled),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_DOMAIN_CONFIG_X64.Blocked),
                    new ulong[]
                    {
                        9UL
                    }
                }
            };
            Register<_HAL_HV_DMA_DOMAIN_CONFIG_X64>((mem, ptr) => new _HAL_HV_DMA_DOMAIN_CONFIG_X64(mem, ptr), offsets);
        }
    }
}