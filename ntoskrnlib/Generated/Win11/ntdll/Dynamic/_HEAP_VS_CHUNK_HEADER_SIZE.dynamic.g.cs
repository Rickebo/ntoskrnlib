using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_VS_CHUNK_HEADER_SIZE")]
    public sealed class _HEAP_VS_CHUNK_HEADER_SIZE : DynamicStructure
    {
        public uint MemoryCost { get; }
        public uint UnsafeSize { get; }
        public uint UnsafePrevSize { get; }
        public uint Allocated { get; }
        public ushort KeyUShort { get; }
        public uint KeyULong { get; }
        public ulong HeaderBits { get; }

        public _HEAP_VS_CHUNK_HEADER_SIZE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_VS_CHUNK_HEADER_SIZE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_VS_CHUNK_HEADER_SIZE.MemoryCost),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_CHUNK_HEADER_SIZE.UnsafeSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_CHUNK_HEADER_SIZE.UnsafePrevSize),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HEAP_VS_CHUNK_HEADER_SIZE.Allocated),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HEAP_VS_CHUNK_HEADER_SIZE.KeyUShort),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_CHUNK_HEADER_SIZE.KeyULong),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_CHUNK_HEADER_SIZE.HeaderBits),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_VS_CHUNK_HEADER_SIZE>((mem, ptr) => new _HEAP_VS_CHUNK_HEADER_SIZE(mem, ptr), offsets);
        }
    }
}