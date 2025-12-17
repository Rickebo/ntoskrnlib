using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KCLOCK_TICK_TRACE")]
    public sealed class _KCLOCK_TICK_TRACE : DynamicStructure
    {
        public ulong PerformanceCounter { get; }
        public ulong PreInterruptTime { get; }
        public ulong PostInterruptTime { get; }
        public ulong TimeStampCounter { get; }
        public byte IsClockOwner { get; }

        public _KCLOCK_TICK_TRACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KCLOCK_TICK_TRACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KCLOCK_TICK_TRACE.PerformanceCounter),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KCLOCK_TICK_TRACE.PreInterruptTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KCLOCK_TICK_TRACE.PostInterruptTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KCLOCK_TICK_TRACE.TimeStampCounter),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KCLOCK_TICK_TRACE.IsClockOwner),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_KCLOCK_TICK_TRACE>((mem, ptr) => new _KCLOCK_TICK_TRACE(mem, ptr), offsets);
        }
    }
}