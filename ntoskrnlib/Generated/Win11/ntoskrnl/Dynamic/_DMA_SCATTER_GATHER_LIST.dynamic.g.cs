using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_SCATTER_GATHER_LIST")]
    public sealed class _DMA_SCATTER_GATHER_LIST : DynamicStructure
    {
        public uint NumberOfElements { get; }
        public ulong Reserved { get; }
        public byte[] Elements { get; }

        public _DMA_SCATTER_GATHER_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_SCATTER_GATHER_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_SCATTER_GATHER_LIST.NumberOfElements),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_SCATTER_GATHER_LIST.Reserved),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DMA_SCATTER_GATHER_LIST.Elements),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_DMA_SCATTER_GATHER_LIST>((mem, ptr) => new _DMA_SCATTER_GATHER_LIST(mem, ptr), offsets);
        }
    }
}