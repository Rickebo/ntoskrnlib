using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_FILL_MEMORY")]
    public sealed class _DBGKD_FILL_MEMORY : DynamicStructure
    {
        public ulong Address { get; }
        public uint Length { get; }
        public ushort Flags { get; }
        public ushort PatternLength { get; }

        public _DBGKD_FILL_MEMORY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_FILL_MEMORY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_FILL_MEMORY.Address),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_FILL_MEMORY.Length),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_FILL_MEMORY.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DBGKD_FILL_MEMORY.PatternLength),
                    new ulong[]
                    {
                        14UL
                    }
                }
            };
            Register<_DBGKD_FILL_MEMORY>((mem, ptr) => new _DBGKD_FILL_MEMORY(mem, ptr), offsets);
        }
    }
}