using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KCLOCK_TIMER_DEADLINE_ENTRY")]
    public sealed class _KCLOCK_TIMER_DEADLINE_ENTRY : DynamicStructure
    {
        public ulong DueTime { get; }
        public uint TolerableDelay { get; }
        public byte TypeFlags { get; }
        public byte Valid { get; }
        public byte NoWake { get; }
        public byte Unused { get; }

        public _KCLOCK_TIMER_DEADLINE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KCLOCK_TIMER_DEADLINE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KCLOCK_TIMER_DEADLINE_ENTRY.DueTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_DEADLINE_ENTRY.TolerableDelay),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_DEADLINE_ENTRY.TypeFlags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_DEADLINE_ENTRY.Valid),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_DEADLINE_ENTRY.NoWake),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_DEADLINE_ENTRY.Unused),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_KCLOCK_TIMER_DEADLINE_ENTRY>((mem, ptr) => new _KCLOCK_TIMER_DEADLINE_ENTRY(mem, ptr), offsets);
        }
    }
}