using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_QUERY_MEMORY")]
    public sealed class _DBGKD_QUERY_MEMORY : DynamicStructure
    {
        public ulong Address { get; }
        public ulong Reserved { get; }
        public uint AddressSpace { get; }
        public uint Flags { get; }

        public _DBGKD_QUERY_MEMORY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_QUERY_MEMORY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_QUERY_MEMORY.Address),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_QUERY_MEMORY.Reserved),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_QUERY_MEMORY.AddressSpace),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DBGKD_QUERY_MEMORY.Flags),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_DBGKD_QUERY_MEMORY>((mem, ptr) => new _DBGKD_QUERY_MEMORY(mem, ptr), offsets);
        }
    }
}