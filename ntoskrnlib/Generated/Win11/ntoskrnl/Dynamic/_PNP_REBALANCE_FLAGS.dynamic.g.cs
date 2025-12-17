using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PNP_REBALANCE_FLAGS")]
    public sealed class _PNP_REBALANCE_FLAGS : DynamicStructure
    {
        public _unnamed_tag_ u { get; }
        public uint AsUlong { get; }

        public _PNP_REBALANCE_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PNP_REBALANCE_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PNP_REBALANCE_FLAGS.u),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PNP_REBALANCE_FLAGS.AsUlong),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PNP_REBALANCE_FLAGS>((mem, ptr) => new _PNP_REBALANCE_FLAGS(mem, ptr), offsets);
        }
    }
}