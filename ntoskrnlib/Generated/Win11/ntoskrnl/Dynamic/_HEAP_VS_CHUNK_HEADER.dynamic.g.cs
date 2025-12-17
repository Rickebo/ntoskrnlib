using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_VS_CHUNK_HEADER")]
    public sealed class _HEAP_VS_CHUNK_HEADER : DynamicStructure
    {
        public _HEAP_VS_CHUNK_HEADER_SIZE Sizes { get; }
        public uint EncodedSegmentPageOffset { get; }
        public uint UnusedBytes { get; }
        public uint SkipDuringWalk { get; }
        public uint Spare { get; }
        public uint AllocatedChunkBits { get; }

        public _HEAP_VS_CHUNK_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_VS_CHUNK_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_VS_CHUNK_HEADER.Sizes),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_CHUNK_HEADER.EncodedSegmentPageOffset),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_VS_CHUNK_HEADER.UnusedBytes),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_VS_CHUNK_HEADER.SkipDuringWalk),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_VS_CHUNK_HEADER.Spare),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_VS_CHUNK_HEADER.AllocatedChunkBits),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HEAP_VS_CHUNK_HEADER>((mem, ptr) => new _HEAP_VS_CHUNK_HEADER(mem, ptr), offsets);
        }
    }
}