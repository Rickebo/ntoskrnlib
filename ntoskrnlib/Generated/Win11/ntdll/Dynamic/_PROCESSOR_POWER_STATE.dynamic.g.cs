using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PROCESSOR_POWER_STATE")]
    public sealed class _PROCESSOR_POWER_STATE : DynamicStructure
    {
        public IntPtr IdleStates { get; }
        public IntPtr IdleAccounting { get; }
        public ulong IdleTimeLast { get; }
        public ulong IdleTimeTotal { get; }
        public ulong IdleSequenceNumber { get; }
        public ulong IdleTimeEntry { get; }
        public ulong IdleTimeExpiration { get; }
        public long IdleWakeTime { get; }
        public uint IdleWakeLatencyLimit { get; }
        public byte NonInterruptibleTransition { get; }
        public byte PepWokenTransition { get; }
        public byte HvTargetState { get; }
        public uint TargetIdleState { get; }
        public _PROC_IDLE_POLICY IdlePolicy { get; }
        public _PPM_IDLE_SYNCHRONIZATION_STATE Synchronization { get; }
        public _PROC_FEEDBACK PerfFeedback { get; }
        public uint Hypervisor { get; }
        public uint LastSysTime { get; }
        public ulong WmiDispatchPtr { get; }
        public int WmiInterfaceEnabled { get; }
        public _PPM_FFH_THROTTLE_STATE_INFO FFHThrottleStateInfo { get; }
        public _KDPC PerfActionDpc { get; }
        public int PerfActionMask { get; }
        public _PROC_IDLE_SNAP HvIdleCheck { get; }
        public _PROC_PERF_CHECK_CONTEXT CheckContext { get; }
        public IntPtr Concurrency { get; }
        public IntPtr ClassConcurrency { get; }
        public byte ArchitecturalEfficiencyClass { get; }
        public byte PerformanceSchedulingClass { get; }
        public byte EfficiencySchedulingClass { get; }
        public byte Reserved { get; }
        public byte Parked { get; }
        public byte SoftParked { get; }
        public byte LongPriorQosPeriod { get; }
        public ulong SnapTimeLast { get; }
        public ulong EnergyConsumed { get; }
        public ulong ActiveTime { get; }
        public ulong TotalTime { get; }
        public IntPtr FxDevice { get; }
        public ulong LastQosTransitionTime { get; }
        public ulong QosTransitionHysteresis { get; }
        public uint RequestedQosClass { get; }
        public uint ResolvedQosClass { get; }
        public ushort QosEquivalencyMask { get; }
        public ushort HwFeedbackTableOffset { get; }
        public byte HwFeedbackParkHint { get; }
        public byte HeteroCoreType { get; }
        public ushort HwFeedbackTableIndex { get; }
        public IntPtr HwFeedbackClassList { get; }
        public IntPtr EeCyclesWorkloadClassList { get; }
        public IntPtr PerfCyclesWorkloadClassList { get; }
        public byte ContainmentGroupType { get; }
        public ushort[] FrequencyBucketThresholds { get; }

        public _PROCESSOR_POWER_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESSOR_POWER_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESSOR_POWER_STATE.IdleStates),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.IdleAccounting),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.IdleTimeLast),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.IdleTimeTotal),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.IdleSequenceNumber),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.IdleTimeEntry),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.IdleTimeExpiration),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.IdleWakeTime),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.IdleWakeLatencyLimit),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.NonInterruptibleTransition),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.PepWokenTransition),
                    new ulong[]
                    {
                        61UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.HvTargetState),
                    new ulong[]
                    {
                        62UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.TargetIdleState),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.IdlePolicy),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.Synchronization),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.PerfFeedback),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.Hypervisor),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.LastSysTime),
                    new ulong[]
                    {
                        228UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.WmiDispatchPtr),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.WmiInterfaceEnabled),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.FFHThrottleStateInfo),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.PerfActionDpc),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.PerfActionMask),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.HvIdleCheck),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.CheckContext),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.Concurrency),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.ClassConcurrency),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.ArchitecturalEfficiencyClass),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.PerformanceSchedulingClass),
                    new ulong[]
                    {
                        457UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.EfficiencySchedulingClass),
                    new ulong[]
                    {
                        458UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.Reserved),
                    new ulong[]
                    {
                        459UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.Parked),
                    new ulong[]
                    {
                        460UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.SoftParked),
                    new ulong[]
                    {
                        461UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.LongPriorQosPeriod),
                    new ulong[]
                    {
                        462UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.SnapTimeLast),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.EnergyConsumed),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.ActiveTime),
                    new ulong[]
                    {
                        472UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.TotalTime),
                    new ulong[]
                    {
                        480UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.FxDevice),
                    new ulong[]
                    {
                        488UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.LastQosTransitionTime),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.QosTransitionHysteresis),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.RequestedQosClass),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.ResolvedQosClass),
                    new ulong[]
                    {
                        516UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.QosEquivalencyMask),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.HwFeedbackTableOffset),
                    new ulong[]
                    {
                        522UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.HwFeedbackParkHint),
                    new ulong[]
                    {
                        524UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.HeteroCoreType),
                    new ulong[]
                    {
                        525UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.HwFeedbackTableIndex),
                    new ulong[]
                    {
                        526UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.HwFeedbackClassList),
                    new ulong[]
                    {
                        528UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.EeCyclesWorkloadClassList),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.PerfCyclesWorkloadClassList),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.ContainmentGroupType),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(_PROCESSOR_POWER_STATE.FrequencyBucketThresholds),
                    new ulong[]
                    {
                        554UL
                    }
                }
            };
            Register<_PROCESSOR_POWER_STATE>((mem, ptr) => new _PROCESSOR_POWER_STATE(mem, ptr), offsets);
        }
    }
}