using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_COMMON_BUFFER_VECTOR")]
    public sealed class _DMA_COMMON_BUFFER_VECTOR : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public ulong SizeOfEntries { get; }
        public uint NumberOfEntries { get; }
        public IntPtr Domain { get; }
        public IntPtr Mdl { get; }
        public IntPtr BaseAddress { get; }
        public ulong BaseLogicalAddress { get; }
        public IntPtr Entries { get; }
        public byte LogicalAddressMapped { get; }

        public _DMA_COMMON_BUFFER_VECTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_COMMON_BUFFER_VECTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_COMMON_BUFFER_VECTOR.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_COMMON_BUFFER_VECTOR.SizeOfEntries),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DMA_COMMON_BUFFER_VECTOR.NumberOfEntries),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DMA_COMMON_BUFFER_VECTOR.Domain),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DMA_COMMON_BUFFER_VECTOR.Mdl),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DMA_COMMON_BUFFER_VECTOR.BaseAddress),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DMA_COMMON_BUFFER_VECTOR.BaseLogicalAddress),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DMA_COMMON_BUFFER_VECTOR.Entries),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DMA_COMMON_BUFFER_VECTOR.LogicalAddressMapped),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_DMA_COMMON_BUFFER_VECTOR>((mem, ptr) => new _DMA_COMMON_BUFFER_VECTOR(mem, ptr), offsets);
        }
    }
}