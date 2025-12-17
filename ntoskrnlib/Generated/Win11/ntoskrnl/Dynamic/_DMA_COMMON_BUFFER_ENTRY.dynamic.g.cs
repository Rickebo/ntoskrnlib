using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_COMMON_BUFFER_ENTRY")]
    public sealed class _DMA_COMMON_BUFFER_ENTRY : DynamicStructure
    {
        public IntPtr VirtualAddress { get; }
        public _LARGE_INTEGER LogicalAddress { get; }

        public _DMA_COMMON_BUFFER_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_COMMON_BUFFER_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_COMMON_BUFFER_ENTRY.VirtualAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_COMMON_BUFFER_ENTRY.LogicalAddress),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DMA_COMMON_BUFFER_ENTRY>((mem, ptr) => new _DMA_COMMON_BUFFER_ENTRY(mem, ptr), offsets);
        }
    }
}