using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_HV_DMA_HYBRID_PASSTHROUGH_RESERVED_REGIONS")]
    public sealed class _HAL_HV_DMA_HYBRID_PASSTHROUGH_RESERVED_REGIONS : DynamicStructure
    {
        public ulong UnitSizePages { get; }
        public _RTL_BITMAP ReservedUnitMap { get; }
        public uint[] ReservedUnitMapBuffer { get; }

        public _HAL_HV_DMA_HYBRID_PASSTHROUGH_RESERVED_REGIONS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_HV_DMA_HYBRID_PASSTHROUGH_RESERVED_REGIONS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_HV_DMA_HYBRID_PASSTHROUGH_RESERVED_REGIONS.UnitSizePages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_HYBRID_PASSTHROUGH_RESERVED_REGIONS.ReservedUnitMap),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HAL_HV_DMA_HYBRID_PASSTHROUGH_RESERVED_REGIONS.ReservedUnitMapBuffer),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_HAL_HV_DMA_HYBRID_PASSTHROUGH_RESERVED_REGIONS>((mem, ptr) => new _HAL_HV_DMA_HYBRID_PASSTHROUGH_RESERVED_REGIONS(mem, ptr), offsets);
        }
    }
}