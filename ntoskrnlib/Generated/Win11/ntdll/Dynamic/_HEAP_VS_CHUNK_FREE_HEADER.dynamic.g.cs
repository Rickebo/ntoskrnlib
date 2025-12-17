using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_VS_CHUNK_FREE_HEADER")]
    public sealed class _HEAP_VS_CHUNK_FREE_HEADER : DynamicStructure
    {
        public _HEAP_VS_CHUNK_HEADER Header { get; }
        public ulong OverlapsHeader { get; }
        public _RTL_BALANCED_NODE Node { get; }

        public _HEAP_VS_CHUNK_FREE_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_VS_CHUNK_FREE_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_VS_CHUNK_FREE_HEADER.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_CHUNK_FREE_HEADER.OverlapsHeader),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_CHUNK_FREE_HEADER.Node),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HEAP_VS_CHUNK_FREE_HEADER>((mem, ptr) => new _HEAP_VS_CHUNK_FREE_HEADER(mem, ptr), offsets);
        }
    }
}