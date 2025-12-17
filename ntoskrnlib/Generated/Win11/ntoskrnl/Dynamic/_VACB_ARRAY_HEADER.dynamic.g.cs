using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VACB_ARRAY_HEADER")]
    public sealed class _VACB_ARRAY_HEADER : DynamicStructure
    {
        public uint VacbArrayIndex { get; }
        public uint MappingCount { get; }
        public uint HighestMappedIndex { get; }
        public uint Reserved { get; }

        public _VACB_ARRAY_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VACB_ARRAY_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VACB_ARRAY_HEADER.VacbArrayIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VACB_ARRAY_HEADER.MappingCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_VACB_ARRAY_HEADER.HighestMappedIndex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VACB_ARRAY_HEADER.Reserved),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_VACB_ARRAY_HEADER>((mem, ptr) => new _VACB_ARRAY_HEADER(mem, ptr), offsets);
        }
    }
}