using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_ADAPTER")]
    public sealed class _DMA_ADAPTER : DynamicStructure
    {
        public ushort Version { get; }
        public ushort Size { get; }
        public IntPtr DmaOperations { get; }

        public _DMA_ADAPTER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_ADAPTER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_ADAPTER.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_ADAPTER.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DMA_ADAPTER.DmaOperations),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DMA_ADAPTER>((mem, ptr) => new _DMA_ADAPTER(mem, ptr), offsets);
        }
    }
}