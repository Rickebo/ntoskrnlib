using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_TRANSFER_INFO")]
    public sealed class _DMA_TRANSFER_INFO : DynamicStructure
    {
        public uint Version { get; }
        public _DMA_TRANSFER_INFO_V1 V1 { get; }
        public _DMA_TRANSFER_INFO_V2 V2 { get; }

        public _DMA_TRANSFER_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_TRANSFER_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_TRANSFER_INFO.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_TRANSFER_INFO.V1),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DMA_TRANSFER_INFO.V2),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_DMA_TRANSFER_INFO>((mem, ptr) => new _DMA_TRANSFER_INFO(mem, ptr), offsets);
        }
    }
}