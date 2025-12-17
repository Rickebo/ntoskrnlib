using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_ADAPTER_INFO")]
    public sealed class _DMA_ADAPTER_INFO : DynamicStructure
    {
        public uint Version { get; }
        public _DMA_ADAPTER_INFO_V1 V1 { get; }
        public ulong Reserved { get; }
        public _DMA_ADAPTER_INFO_CRASHDUMP Crashdump { get; }

        public _DMA_ADAPTER_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_ADAPTER_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_ADAPTER_INFO.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_ADAPTER_INFO.V1),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DMA_ADAPTER_INFO.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_ADAPTER_INFO.Crashdump),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DMA_ADAPTER_INFO>((mem, ptr) => new _DMA_ADAPTER_INFO(mem, ptr), offsets);
        }
    }
}