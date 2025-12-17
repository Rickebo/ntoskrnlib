using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PPM_IDLE_STATES")]
    public sealed class _PPM_IDLE_STATES : DynamicStructure
    {
        public byte EnforceStateConstraints { get; }
        public byte IdleOverride { get; }
        public byte EstimateIdleDuration { get; }
        public byte ExitLatencyTraceEnabled { get; }
        public byte NonInterruptibleTransition { get; }
        public byte UnaccountedTransition { get; }
        public byte IdleDurationLimited { get; }
        public byte IdleCheckLimited { get; }
        public ulong IdleReevaluationDuration { get; }
        public byte StrictVetoBias { get; }
        public uint ExitLatencyCountdown { get; }
        public uint TargetState { get; }
        public uint ActualState { get; }
        public uint OldState { get; }
        public uint OverrideIndex { get; }
        public uint ProcessorIdleCount { get; }
        public uint Type { get; }
        public ulong LevelId { get; }
        public ushort ReasonFlags { get; }
        public int PreviousStatus { get; }
        public byte PreviouslyCancelled { get; }
        public byte PreviouslyDeniedCount { get; }
        public _KAFFINITY_EX PrimaryProcessorMask { get; }
        public _KAFFINITY_EX SecondaryProcessorMask { get; }
        public IntPtr IdlePreExecute { get; }
        public IntPtr IdleExecute { get; }
        public IntPtr IdlePreselect { get; }
        public IntPtr IdleTest { get; }
        public IntPtr IdleAvailabilityCheck { get; }
        public IntPtr IdleComplete { get; }
        public IntPtr IdleIsHalted { get; }
        public IntPtr IdleInitiateWake { get; }
        public IntPtr Context { get; }
        public _PROCESSOR_IDLE_CONSTRAINTS Constraints { get; }
        public _KAFFINITY_EX DeepIdleSnapshot { get; }
        public IntPtr Tracing { get; }
        public IntPtr CoordinatedTracing { get; }
        public _PPM_SELECTION_MENU ProcessorMenu { get; }
        public _PPM_SELECTION_MENU CoordinatedMenu { get; }
        public _PPM_COORDINATED_SELECTION CoordinatedSelection { get; }
        public byte[] State { get; }

        public _PPM_IDLE_STATES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_IDLE_STATES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_IDLE_STATES.EnforceStateConstraints),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.IdleOverride),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.EstimateIdleDuration),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.ExitLatencyTraceEnabled),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.NonInterruptibleTransition),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.UnaccountedTransition),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.IdleDurationLimited),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.IdleCheckLimited),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.IdleReevaluationDuration),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.StrictVetoBias),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.ExitLatencyCountdown),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.TargetState),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.ActualState),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.OldState),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.OverrideIndex),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.ProcessorIdleCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.Type),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.LevelId),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.ReasonFlags),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.PreviousStatus),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.PreviouslyCancelled),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.PreviouslyDeniedCount),
                    new ulong[]
                    {
                        65UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.PrimaryProcessorMask),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.SecondaryProcessorMask),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.IdlePreExecute),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.IdleExecute),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.IdlePreselect),
                    new ulong[]
                    {
                        616UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.IdleTest),
                    new ulong[]
                    {
                        624UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.IdleAvailabilityCheck),
                    new ulong[]
                    {
                        632UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.IdleComplete),
                    new ulong[]
                    {
                        640UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.IdleIsHalted),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.IdleInitiateWake),
                    new ulong[]
                    {
                        656UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.Context),
                    new ulong[]
                    {
                        664UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.Constraints),
                    new ulong[]
                    {
                        672UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.DeepIdleSnapshot),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.Tracing),
                    new ulong[]
                    {
                        984UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.CoordinatedTracing),
                    new ulong[]
                    {
                        992UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.ProcessorMenu),
                    new ulong[]
                    {
                        1000UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.CoordinatedMenu),
                    new ulong[]
                    {
                        1016UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.CoordinatedSelection),
                    new ulong[]
                    {
                        1032UL
                    }
                },
                {
                    nameof(_PPM_IDLE_STATES.State),
                    new ulong[]
                    {
                        1056UL
                    }
                }
            };
            Register<_PPM_IDLE_STATES>((mem, ptr) => new _PPM_IDLE_STATES(mem, ptr), offsets);
        }
    }
}