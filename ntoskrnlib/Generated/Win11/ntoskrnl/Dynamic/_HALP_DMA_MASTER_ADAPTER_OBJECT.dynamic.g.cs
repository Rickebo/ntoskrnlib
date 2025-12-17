using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_MASTER_ADAPTER_OBJECT")]
    public sealed class _HALP_DMA_MASTER_ADAPTER_OBJECT : DynamicStructure
    {
        public _HALP_DMA_ADAPTER_OBJECT AdapterObject { get; }
        public ulong QueueLock { get; }
        public _LIST_ENTRY ContiguousAdapterQueue { get; }
        public _LIST_ENTRY ScatterAdapterQueue { get; }
        public uint MapBufferSize { get; }
        public _LARGE_INTEGER MapBufferPhysicalAddress { get; }
        public uint ContiguousPageCount { get; }
        public uint ContiguousPageLimit { get; }
        public uint ScatterPageCount { get; }
        public uint ScatterPageLimit { get; }

        public _HALP_DMA_MASTER_ADAPTER_OBJECT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HALP_DMA_MASTER_ADAPTER_OBJECT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HALP_DMA_MASTER_ADAPTER_OBJECT.AdapterObject),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HALP_DMA_MASTER_ADAPTER_OBJECT.QueueLock),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_HALP_DMA_MASTER_ADAPTER_OBJECT.ContiguousAdapterQueue),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_HALP_DMA_MASTER_ADAPTER_OBJECT.ScatterAdapterQueue),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_HALP_DMA_MASTER_ADAPTER_OBJECT.MapBufferSize),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_HALP_DMA_MASTER_ADAPTER_OBJECT.MapBufferPhysicalAddress),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_HALP_DMA_MASTER_ADAPTER_OBJECT.ContiguousPageCount),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_HALP_DMA_MASTER_ADAPTER_OBJECT.ContiguousPageLimit),
                    new ulong[]
                    {
                        220UL
                    }
                },
                {
                    nameof(_HALP_DMA_MASTER_ADAPTER_OBJECT.ScatterPageCount),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_HALP_DMA_MASTER_ADAPTER_OBJECT.ScatterPageLimit),
                    new ulong[]
                    {
                        228UL
                    }
                }
            };
            Register<_HALP_DMA_MASTER_ADAPTER_OBJECT>((mem, ptr) => new _HALP_DMA_MASTER_ADAPTER_OBJECT(mem, ptr), offsets);
        }
    }
}