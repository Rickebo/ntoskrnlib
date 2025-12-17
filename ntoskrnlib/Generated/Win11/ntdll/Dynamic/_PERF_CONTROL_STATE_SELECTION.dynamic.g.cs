using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PERF_CONTROL_STATE_SELECTION")]
    public sealed class _PERF_CONTROL_STATE_SELECTION : DynamicStructure
    {
        public ulong SelectedState { get; }
        public ulong SelectedResourcePriority { get; }
        public uint SelectedPercent { get; }
        public uint SelectedFrequency { get; }
        public uint MinPercent { get; }
        public uint MaxPercent { get; }
        public uint TolerancePercent { get; }
        public uint EppPercent { get; }
        public uint AutonomousActivityWindow { get; }
        public uint ResourcePriorityPercent { get; }
        public byte Autonomous { get; }
        public byte InheritFromDomain { get; }

        public _PERF_CONTROL_STATE_SELECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PERF_CONTROL_STATE_SELECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PERF_CONTROL_STATE_SELECTION.SelectedState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PERF_CONTROL_STATE_SELECTION.SelectedResourcePriority),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PERF_CONTROL_STATE_SELECTION.SelectedPercent),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PERF_CONTROL_STATE_SELECTION.SelectedFrequency),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PERF_CONTROL_STATE_SELECTION.MinPercent),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PERF_CONTROL_STATE_SELECTION.MaxPercent),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_PERF_CONTROL_STATE_SELECTION.TolerancePercent),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PERF_CONTROL_STATE_SELECTION.EppPercent),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_PERF_CONTROL_STATE_SELECTION.AutonomousActivityWindow),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PERF_CONTROL_STATE_SELECTION.ResourcePriorityPercent),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_PERF_CONTROL_STATE_SELECTION.Autonomous),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PERF_CONTROL_STATE_SELECTION.InheritFromDomain),
                    new ulong[]
                    {
                        49UL
                    }
                }
            };
            Register<_PERF_CONTROL_STATE_SELECTION>((mem, ptr) => new _PERF_CONTROL_STATE_SELECTION(mem, ptr), offsets);
        }
    }
}