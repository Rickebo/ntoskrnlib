using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_COMPRESSED_DATA_INFO")]
    public sealed class _COMPRESSED_DATA_INFO : DynamicStructure
    {
        public ushort CompressionFormatAndEngine { get; }
        public byte CompressionUnitShift { get; }
        public byte ChunkShift { get; }
        public byte ClusterShift { get; }
        public byte Reserved { get; }
        public ushort NumberOfChunks { get; }
        public uint[] CompressedChunkSizes { get; }

        public _COMPRESSED_DATA_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _COMPRESSED_DATA_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_COMPRESSED_DATA_INFO.CompressionFormatAndEngine),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_COMPRESSED_DATA_INFO.CompressionUnitShift),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_COMPRESSED_DATA_INFO.ChunkShift),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_COMPRESSED_DATA_INFO.ClusterShift),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_COMPRESSED_DATA_INFO.Reserved),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_COMPRESSED_DATA_INFO.NumberOfChunks),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_COMPRESSED_DATA_INFO.CompressedChunkSizes),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_COMPRESSED_DATA_INFO>((mem, ptr) => new _COMPRESSED_DATA_INFO(mem, ptr), offsets);
        }
    }
}