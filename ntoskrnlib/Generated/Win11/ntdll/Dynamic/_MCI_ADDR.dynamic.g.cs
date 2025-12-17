using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_MCI_ADDR")]
    public sealed class _MCI_ADDR : DynamicStructure
    {
        public uint Address { get; }
        public uint Reserved { get; }
        public ulong QuadPart { get; }

        public _MCI_ADDR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MCI_ADDR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MCI_ADDR.Address),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_ADDR.Reserved),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MCI_ADDR.QuadPart),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MCI_ADDR>((mem, ptr) => new _MCI_ADDR(mem, ptr), offsets);
        }
    }
}