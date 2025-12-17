using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PROCESSOR_IDLE_CONSTRAINTS")]
    public sealed class _PROCESSOR_IDLE_CONSTRAINTS : DynamicStructure
    {
        public ulong TotalTime { get; }
        public ulong IdleTime { get; }
        public ulong ExpectedIdleDuration { get; }
        public ulong MaxIdleDuration { get; }
        public uint OverrideState { get; }
        public uint TimeCheck { get; }
        public byte PromotePercent { get; }
        public byte DemotePercent { get; }
        public byte Parked { get; }
        public byte Interruptible { get; }
        public byte PlatformIdle { get; }
        public byte ExpectedWakeReason { get; }
        public byte IdleStateMax { get; }

        public _PROCESSOR_IDLE_CONSTRAINTS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESSOR_IDLE_CONSTRAINTS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESSOR_IDLE_CONSTRAINTS.TotalTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESSOR_IDLE_CONSTRAINTS.IdleTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROCESSOR_IDLE_CONSTRAINTS.ExpectedIdleDuration),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROCESSOR_IDLE_CONSTRAINTS.MaxIdleDuration),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROCESSOR_IDLE_CONSTRAINTS.OverrideState),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PROCESSOR_IDLE_CONSTRAINTS.TimeCheck),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_PROCESSOR_IDLE_CONSTRAINTS.PromotePercent),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PROCESSOR_IDLE_CONSTRAINTS.DemotePercent),
                    new ulong[]
                    {
                        41UL
                    }
                },
                {
                    nameof(_PROCESSOR_IDLE_CONSTRAINTS.Parked),
                    new ulong[]
                    {
                        42UL
                    }
                },
                {
                    nameof(_PROCESSOR_IDLE_CONSTRAINTS.Interruptible),
                    new ulong[]
                    {
                        43UL
                    }
                },
                {
                    nameof(_PROCESSOR_IDLE_CONSTRAINTS.PlatformIdle),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_PROCESSOR_IDLE_CONSTRAINTS.ExpectedWakeReason),
                    new ulong[]
                    {
                        45UL
                    }
                },
                {
                    nameof(_PROCESSOR_IDLE_CONSTRAINTS.IdleStateMax),
                    new ulong[]
                    {
                        46UL
                    }
                }
            };
            Register<_PROCESSOR_IDLE_CONSTRAINTS>((mem, ptr) => new _PROCESSOR_IDLE_CONSTRAINTS(mem, ptr), offsets);
        }
    }
}