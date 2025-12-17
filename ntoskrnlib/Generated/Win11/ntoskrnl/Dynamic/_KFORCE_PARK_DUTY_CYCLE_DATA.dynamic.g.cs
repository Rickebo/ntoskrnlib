using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KFORCE_PARK_DUTY_CYCLE_DATA")]
    public sealed class _KFORCE_PARK_DUTY_CYCLE_DATA : DynamicStructure
    {
        public _KDPC DutyCycleDpc { get; }
        public _KTIMER2 StartSingleDutyCycleTimer { get; }
        public _KTIMER2 StopSingleDutyCycleTimer { get; }
        public uint CurrentState { get; }
        public uint DpcTransition { get; }

        public _KFORCE_PARK_DUTY_CYCLE_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KFORCE_PARK_DUTY_CYCLE_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KFORCE_PARK_DUTY_CYCLE_DATA.DutyCycleDpc),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KFORCE_PARK_DUTY_CYCLE_DATA.StartSingleDutyCycleTimer),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KFORCE_PARK_DUTY_CYCLE_DATA.StopSingleDutyCycleTimer),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_KFORCE_PARK_DUTY_CYCLE_DATA.CurrentState),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_KFORCE_PARK_DUTY_CYCLE_DATA.DpcTransition),
                    new ulong[]
                    {
                        340UL
                    }
                }
            };
            Register<_KFORCE_PARK_DUTY_CYCLE_DATA>((mem, ptr) => new _KFORCE_PARK_DUTY_CYCLE_DATA(mem, ptr), offsets);
        }
    }
}