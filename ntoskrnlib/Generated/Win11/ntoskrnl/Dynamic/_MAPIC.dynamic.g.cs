using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MAPIC")]
    public sealed class _MAPIC : DynamicStructure
    {
        public _DESCRIPTION_HEADER Header { get; }
        public uint LocalAPICAddress { get; }
        public uint Flags { get; }
        public uint[] APICTables { get; }

        public _MAPIC(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MAPIC()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MAPIC.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MAPIC.LocalAPICAddress),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_MAPIC.Flags),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MAPIC.APICTables),
                    new ulong[]
                    {
                        44UL
                    }
                }
            };
            Register<_MAPIC>((mem, ptr) => new _MAPIC(mem, ptr), offsets);
        }
    }
}