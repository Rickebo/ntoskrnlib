using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTIMER_TABLE")]
    public sealed class _KTIMER_TABLE : DynamicStructure
    {
        public byte[] TimerExpiry { get; }
        public byte[] TimerEntries { get; }
        public _KTIMER_TABLE_STATE TableState { get; }

        public _KTIMER_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTIMER_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTIMER_TABLE.TimerExpiry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTIMER_TABLE.TimerEntries),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_KTIMER_TABLE.TableState),
                    new ulong[]
                    {
                        16896UL
                    }
                }
            };
            Register<_KTIMER_TABLE>((mem, ptr) => new _KTIMER_TABLE(mem, ptr), offsets);
        }
    }
}