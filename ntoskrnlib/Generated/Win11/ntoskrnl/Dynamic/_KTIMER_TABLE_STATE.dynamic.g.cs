using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTIMER_TABLE_STATE")]
    public sealed class _KTIMER_TABLE_STATE : DynamicStructure
    {
        public ulong[] LastTimerExpiration { get; }
        public uint[] LastTimerHand { get; }

        public _KTIMER_TABLE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTIMER_TABLE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTIMER_TABLE_STATE.LastTimerExpiration),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTIMER_TABLE_STATE.LastTimerHand),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_KTIMER_TABLE_STATE>((mem, ptr) => new _KTIMER_TABLE_STATE(mem, ptr), offsets);
        }
    }
}