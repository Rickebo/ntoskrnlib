using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KALPC_DIRECT_EVENT")]
    public sealed class _KALPC_DIRECT_EVENT : DynamicStructure
    {
        public ulong Value { get; }
        public ulong DirectType { get; }
        public ulong EventReferenced { get; }
        public ulong EventObjectBits { get; }

        public _KALPC_DIRECT_EVENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KALPC_DIRECT_EVENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KALPC_DIRECT_EVENT.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KALPC_DIRECT_EVENT.DirectType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KALPC_DIRECT_EVENT.EventReferenced),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KALPC_DIRECT_EVENT.EventObjectBits),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KALPC_DIRECT_EVENT>((mem, ptr) => new _KALPC_DIRECT_EVENT(mem, ptr), offsets);
        }
    }
}