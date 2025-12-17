using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_GEN_ADDR")]
    public sealed class _GEN_ADDR : DynamicStructure
    {
        public byte AddressSpaceID { get; }
        public byte BitWidth { get; }
        public byte BitOffset { get; }
        public byte AccessSize { get; }
        public _LARGE_INTEGER Address { get; }

        public _GEN_ADDR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GEN_ADDR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GEN_ADDR.AddressSpaceID),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GEN_ADDR.BitWidth),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_GEN_ADDR.BitOffset),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_GEN_ADDR.AccessSize),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_GEN_ADDR.Address),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_GEN_ADDR>((mem, ptr) => new _GEN_ADDR(mem, ptr), offsets);
        }
    }
}