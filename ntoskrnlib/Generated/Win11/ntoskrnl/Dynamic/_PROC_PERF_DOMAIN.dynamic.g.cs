using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROC_PERF_DOMAIN")]
    public sealed class _PROC_PERF_DOMAIN : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public IntPtr Master { get; }
        public _KAFFINITY_EX Members { get; }
        public ulong DomainContext { get; }
        public uint ProcessorCount { get; }
        public byte EfficiencyClass { get; }
        public byte NominalPerformanceClass { get; }
        public byte PerformanceClass { get; }
        public uint Presence { get; }
        public IntPtr Processors { get; }
        public IntPtr GetFFHThrottleState { get; }
        public IntPtr TimeWindowHandler { get; }
        public IntPtr BoostPolicyHandler { get; }
        public IntPtr BoostModeHandler { get; }
        public IntPtr AutonomousActivityWindowHandler { get; }
        public IntPtr AutonomousModeHandler { get; }
        public IntPtr ReinitializeHandler { get; }
        public IntPtr PerfSelectionHandler { get; }
        public IntPtr PerfPriorityHandler { get; }
        public IntPtr PerfControlHandler { get; }
        public IntPtr PerfControlHandlerHidden { get; }
        public IntPtr DomainPerfControlHandler { get; }
        public IntPtr PerfUpdateHwDebugData { get; }
        public IntPtr PerfQueryProcMeasurementCapabilities { get; }
        public IntPtr PerfQueryProcMeasurementValues { get; }
        public uint Id { get; }
        public uint MaxFrequency { get; }
        public uint NominalFrequency { get; }
        public uint MaxPercent { get; }
        public uint MinPerfPercent { get; }
        public uint MinThrottlePercent { get; }
        public uint AdvertizedMaximumFrequency { get; }
        public ulong MinimumRelativePerformance { get; }
        public ulong NominalRelativePerformance { get; }
        public byte NominalRelativePerformancePercent { get; }
        public byte Coordination { get; }
        public byte HardPlatformCap { get; }
        public byte AffinitizeControl { get; }
        public byte EfficientThrottle { get; }
        public byte AllowSchedulerDirectedPerfStates { get; }
        public byte InitiateAllProcessors { get; }
        public byte AllowVmPerfSelection { get; }
        public byte TurboRangeKnown { get; }
        public uint VmFrequencyStepMhz { get; }
        public uint VmHighestFrequencyMhz { get; }
        public uint VmNominalFrequencyMhz { get; }
        public uint VmLowestFrequencyMhz { get; }
        public uint VmThrottlePriorityCount { get; }
        public byte AutonomousMode { get; }
        public byte AutonomousCapability { get; }
        public byte ProvideGuidance { get; }
        public byte EppSupported { get; }
        public uint DesiredPercent { get; }
        public uint GuaranteedPercent { get; }
        public byte EngageResponsivenessOverrides { get; }
        public byte[] QosPolicies { get; }
        public uint[] QosDisableReasons { get; }
        public ushort[] QosEquivalencyMasks { get; }
        public byte QosSupported { get; }
        public uint SelectionGeneration { get; }
        public byte[] QosSelection { get; }
        public ulong PerfChangeTime { get; }
        public uint PerfChangeIntervalCount { get; }
        public byte Force { get; }
        public byte Update { get; }
        public byte Apply { get; }

        public _PROC_PERF_DOMAIN(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_PERF_DOMAIN()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_PERF_DOMAIN.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.Master),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.Members),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.DomainContext),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.ProcessorCount),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.EfficiencyClass),
                    new ulong[]
                    {
                        300UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.NominalPerformanceClass),
                    new ulong[]
                    {
                        301UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.PerformanceClass),
                    new ulong[]
                    {
                        302UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.Presence),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.Processors),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.GetFFHThrottleState),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.TimeWindowHandler),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.BoostPolicyHandler),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.BoostModeHandler),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.AutonomousActivityWindowHandler),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.AutonomousModeHandler),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.ReinitializeHandler),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.PerfSelectionHandler),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.PerfPriorityHandler),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.PerfControlHandler),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.PerfControlHandlerHidden),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.DomainPerfControlHandler),
                    new ulong[]
                    {
                        408UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.PerfUpdateHwDebugData),
                    new ulong[]
                    {
                        416UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.PerfQueryProcMeasurementCapabilities),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.PerfQueryProcMeasurementValues),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.Id),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.MaxFrequency),
                    new ulong[]
                    {
                        444UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.NominalFrequency),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.MaxPercent),
                    new ulong[]
                    {
                        452UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.MinPerfPercent),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.MinThrottlePercent),
                    new ulong[]
                    {
                        460UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.AdvertizedMaximumFrequency),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.MinimumRelativePerformance),
                    new ulong[]
                    {
                        472UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.NominalRelativePerformance),
                    new ulong[]
                    {
                        480UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.NominalRelativePerformancePercent),
                    new ulong[]
                    {
                        488UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.Coordination),
                    new ulong[]
                    {
                        489UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.HardPlatformCap),
                    new ulong[]
                    {
                        490UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.AffinitizeControl),
                    new ulong[]
                    {
                        491UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.EfficientThrottle),
                    new ulong[]
                    {
                        492UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.AllowSchedulerDirectedPerfStates),
                    new ulong[]
                    {
                        493UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.InitiateAllProcessors),
                    new ulong[]
                    {
                        494UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.AllowVmPerfSelection),
                    new ulong[]
                    {
                        495UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.TurboRangeKnown),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.VmFrequencyStepMhz),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.VmHighestFrequencyMhz),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.VmNominalFrequencyMhz),
                    new ulong[]
                    {
                        508UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.VmLowestFrequencyMhz),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.VmThrottlePriorityCount),
                    new ulong[]
                    {
                        516UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.AutonomousMode),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.AutonomousCapability),
                    new ulong[]
                    {
                        521UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.ProvideGuidance),
                    new ulong[]
                    {
                        522UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.EppSupported),
                    new ulong[]
                    {
                        523UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.DesiredPercent),
                    new ulong[]
                    {
                        524UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.GuaranteedPercent),
                    new ulong[]
                    {
                        528UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.EngageResponsivenessOverrides),
                    new ulong[]
                    {
                        532UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.QosPolicies),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.QosDisableReasons),
                    new ulong[]
                    {
                        760UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.QosEquivalencyMasks),
                    new ulong[]
                    {
                        788UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.QosSupported),
                    new ulong[]
                    {
                        802UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.SelectionGeneration),
                    new ulong[]
                    {
                        804UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.QosSelection),
                    new ulong[]
                    {
                        808UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.PerfChangeTime),
                    new ulong[]
                    {
                        1200UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.PerfChangeIntervalCount),
                    new ulong[]
                    {
                        1208UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.Force),
                    new ulong[]
                    {
                        1212UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.Update),
                    new ulong[]
                    {
                        1213UL
                    }
                },
                {
                    nameof(_PROC_PERF_DOMAIN.Apply),
                    new ulong[]
                    {
                        1214UL
                    }
                }
            };
            Register<_PROC_PERF_DOMAIN>((mem, ptr) => new _PROC_PERF_DOMAIN(mem, ptr), offsets);
        }
    }
}