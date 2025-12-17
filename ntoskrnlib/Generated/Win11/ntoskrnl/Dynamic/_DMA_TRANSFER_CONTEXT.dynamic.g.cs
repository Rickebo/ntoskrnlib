using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_TRANSFER_CONTEXT")]
    public sealed class _DMA_TRANSFER_CONTEXT : DynamicStructure
    {
        public uint Version { get; }
        public _DMA_TRANSFER_CONTEXT_V1 V1 { get; }

        public _DMA_TRANSFER_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_TRANSFER_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_TRANSFER_CONTEXT.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_TRANSFER_CONTEXT.V1),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DMA_TRANSFER_CONTEXT>((mem, ptr) => new _DMA_TRANSFER_CONTEXT(mem, ptr), offsets);
        }
    }
}