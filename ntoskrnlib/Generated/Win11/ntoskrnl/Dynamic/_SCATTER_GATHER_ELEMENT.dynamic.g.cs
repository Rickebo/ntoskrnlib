using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SCATTER_GATHER_ELEMENT")]
    public sealed class _SCATTER_GATHER_ELEMENT : DynamicStructure
    {
        public _LARGE_INTEGER Address { get; }
        public uint Length { get; }
        public ulong Reserved { get; }

        public _SCATTER_GATHER_ELEMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SCATTER_GATHER_ELEMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SCATTER_GATHER_ELEMENT.Address),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SCATTER_GATHER_ELEMENT.Length),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SCATTER_GATHER_ELEMENT.Reserved),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_SCATTER_GATHER_ELEMENT>((mem, ptr) => new _SCATTER_GATHER_ELEMENT(mem, ptr), offsets);
        }
    }
}