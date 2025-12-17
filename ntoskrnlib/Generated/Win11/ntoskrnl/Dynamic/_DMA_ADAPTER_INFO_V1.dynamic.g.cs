using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_ADAPTER_INFO_V1")]
    public sealed class _DMA_ADAPTER_INFO_V1 : DynamicStructure
    {
        public uint ReadDmaCounterAvailable { get; }
        public uint ScatterGatherLimit { get; }
        public uint DmaAddressWidth { get; }
        public uint Flags { get; }
        public uint MinimumTransferUnit { get; }

        public _DMA_ADAPTER_INFO_V1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_ADAPTER_INFO_V1()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_ADAPTER_INFO_V1.ReadDmaCounterAvailable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_ADAPTER_INFO_V1.ScatterGatherLimit),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DMA_ADAPTER_INFO_V1.DmaAddressWidth),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DMA_ADAPTER_INFO_V1.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DMA_ADAPTER_INFO_V1.MinimumTransferUnit),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_DMA_ADAPTER_INFO_V1>((mem, ptr) => new _DMA_ADAPTER_INFO_V1(mem, ptr), offsets);
        }
    }
}