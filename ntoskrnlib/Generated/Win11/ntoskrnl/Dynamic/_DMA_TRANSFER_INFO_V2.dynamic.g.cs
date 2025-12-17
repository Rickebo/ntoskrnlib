using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_TRANSFER_INFO_V2")]
    public sealed class _DMA_TRANSFER_INFO_V2 : DynamicStructure
    {
        public uint MapRegisterCount { get; }
        public uint ScatterGatherElementCount { get; }
        public uint ScatterGatherListSize { get; }
        public uint LogicalPageCount { get; }

        public _DMA_TRANSFER_INFO_V2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_TRANSFER_INFO_V2()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_TRANSFER_INFO_V2.MapRegisterCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_TRANSFER_INFO_V2.ScatterGatherElementCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DMA_TRANSFER_INFO_V2.ScatterGatherListSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DMA_TRANSFER_INFO_V2.LogicalPageCount),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_DMA_TRANSFER_INFO_V2>((mem, ptr) => new _DMA_TRANSFER_INFO_V2(mem, ptr), offsets);
        }
    }
}