using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_ORDERING")]
    public sealed class _ARBITER_ORDERING : DynamicStructure
    {
        public ulong Start { get; }
        public ulong End { get; }

        public _ARBITER_ORDERING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_ORDERING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_ORDERING.Start),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARBITER_ORDERING.End),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_ARBITER_ORDERING>((mem, ptr) => new _ARBITER_ORDERING(mem, ptr), offsets);
        }
    }
}