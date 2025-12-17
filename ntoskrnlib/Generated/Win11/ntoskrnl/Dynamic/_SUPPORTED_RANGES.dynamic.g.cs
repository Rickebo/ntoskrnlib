using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SUPPORTED_RANGES")]
    public sealed class _SUPPORTED_RANGES : DynamicStructure
    {
        public ushort Version { get; }
        public byte Sorted { get; }
        public byte Reserved { get; }
        public uint NoIO { get; }
        public _SUPPORTED_RANGE IO { get; }
        public uint NoMemory { get; }
        public _SUPPORTED_RANGE Memory { get; }
        public uint NoPrefetchMemory { get; }
        public _SUPPORTED_RANGE PrefetchMemory { get; }
        public uint NoDma { get; }
        public _SUPPORTED_RANGE Dma { get; }

        public _SUPPORTED_RANGES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SUPPORTED_RANGES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SUPPORTED_RANGES.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SUPPORTED_RANGES.Sorted),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_SUPPORTED_RANGES.Reserved),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_SUPPORTED_RANGES.NoIO),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_SUPPORTED_RANGES.IO),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SUPPORTED_RANGES.NoMemory),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_SUPPORTED_RANGES.Memory),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_SUPPORTED_RANGES.NoPrefetchMemory),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_SUPPORTED_RANGES.PrefetchMemory),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_SUPPORTED_RANGES.NoDma),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_SUPPORTED_RANGES.Dma),
                    new ulong[]
                    {
                        152UL
                    }
                }
            };
            Register<_SUPPORTED_RANGES>((mem, ptr) => new _SUPPORTED_RANGES(mem, ptr), offsets);
        }
    }
}