using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KCLOCK_TIMER_STATE")]
    public sealed class _KCLOCK_TIMER_STATE : DynamicStructure
    {
        public ulong NextTickDueTime { get; }
        public uint TimeIncrement { get; }
        public uint LastRequestedTimeIncrement { get; }
        public uint OneShotState { get; }
        public uint ExpectedWakeReason { get; }
        public byte[] ClockTimerEntries { get; }
        public byte ClockActive { get; }
        public byte ClockArmedForIdle { get; }
        public uint ClockTickTraceIndex { get; }
        public uint ClockIncrementTraceIndex { get; }
        public byte[] ClockTickTraces { get; }
        public byte[] ClockIncrementTraces { get; }

        public _KCLOCK_TIMER_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KCLOCK_TIMER_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KCLOCK_TIMER_STATE.NextTickDueTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_STATE.TimeIncrement),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_STATE.LastRequestedTimeIncrement),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_STATE.OneShotState),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_STATE.ExpectedWakeReason),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_STATE.ClockTimerEntries),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_STATE.ClockActive),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_STATE.ClockArmedForIdle),
                    new ulong[]
                    {
                        137UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_STATE.ClockTickTraceIndex),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_STATE.ClockIncrementTraceIndex),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_STATE.ClockTickTraces),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_KCLOCK_TIMER_STATE.ClockIncrementTraces),
                    new ulong[]
                    {
                        792UL
                    }
                }
            };
            Register<_KCLOCK_TIMER_STATE>((mem, ptr) => new _KCLOCK_TIMER_STATE(mem, ptr), offsets);
        }
    }
}