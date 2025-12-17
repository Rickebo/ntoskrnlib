using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PPM_POLICY_SETTINGS_MASK")]
    public sealed class _PPM_POLICY_SETTINGS_MASK : DynamicStructure
    {
        public ulong[] Buffer { get; }
        public ulong PerfDecreaseTime { get; }
        public ulong PerfIncreaseTime { get; }
        public ulong PerfDecreasePolicy { get; }
        public ulong PerfIncreasePolicy { get; }
        public ulong PerfDecreaseThreshold { get; }
        public ulong PerfIncreaseThreshold { get; }
        public ulong PerfMinPolicy { get; }
        public ulong PerfMaxPolicy { get; }
        public ulong PerfTimeCheck { get; }
        public ulong PerfBoostPolicy { get; }
        public ulong PerfBoostMode { get; }
        public ulong ThrottlingPolicy { get; }
        public ulong PerfHistoryCount { get; }
        public ulong ParkingPerfState { get; }
        public ulong LatencyHintPerf { get; }
        public ulong LatencyHintEpp { get; }
        public ulong LatencyHintUnpark { get; }
        public ulong CPMinCores { get; }
        public ulong CPMaxCores { get; }
        public ulong CPDecreasePolicy { get; }
        public ulong CPIncreasePolicy { get; }
        public ulong CPDecreaseTime { get; }
        public ulong CPIncreaseTime { get; }
        public ulong CPOverUtilizationThreshold { get; }
        public ulong CPDistributeUtility { get; }
        public ulong CPConcurrencyThreshold { get; }
        public ulong CPHeadroomThreshold { get; }
        public ulong CPDistributeThreshold { get; }
        public ulong IdleAllowScaling { get; }
        public ulong IdleDisabled { get; }
        public ulong IdleTimeCheck { get; }
        public ulong IdleDemoteThreshold { get; }
        public ulong IdlePromoteThreshold { get; }
        public ulong EnergyPerfPreference { get; }
        public ulong AutonomousActivityWindow { get; }
        public ulong AutonomousMode { get; }
        public ulong DutyCycling { get; }
        public ulong FrequencyCap { get; }
        public ulong IdleStateMax { get; }
        public ulong ResponsivenessDisableThreshold { get; }
        public ulong ResponsivenessEnableThreshold { get; }
        public ulong ResponsivenessDisableTime { get; }
        public ulong ResponsivenessEnableTime { get; }
        public ulong ResponsivenessEppCeiling { get; }
        public ulong ResponsivenessPerfFloor { get; }
        public ulong SoftParkLatency { get; }
        public ulong ModuleUnparkPolicy { get; }
        public ulong ComplexUnparkPolicy { get; }
        public ulong SmtUnparkPolicy { get; }
        public ulong RestrictionCount { get; }
        public ulong ResourcePriority { get; }
        public ulong HeteroDecreaseTime { get; }
        public ulong HeteroIncreaseTime { get; }
        public ulong HeteroDecreaseThreshold { get; }
        public ulong HeteroIncreaseThreshold { get; }
        public ulong Class0FloorPerformance { get; }
        public ulong Class1InitialPerformance { get; }
        public ulong SchedulingPolicy { get; }
        public ulong ShortSchedulingPolicy { get; }
        public ulong ShortThreadRuntimeThreshold { get; }
        public ulong ShortThreadArchClassUpperThreshold { get; }
        public ulong ShortThreadArchClassLowerThreshold { get; }
        public ulong LongThreadArchClassUpperThreshold { get; }
        public ulong LongThreadArchClassLowerThreshold { get; }
        public ulong HeteroPolicy { get; }
        public ulong HeteroContainmentIncreaseTime { get; }
        public ulong HeteroContainmentDecreaseTime { get; }
        public ulong HeteroEfficiencyContainmentThreshold { get; }
        public ulong HeteroHybridContainmentThreshold { get; }
        public ulong HeteroContainmentPolicy { get; }

        public _PPM_POLICY_SETTINGS_MASK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_POLICY_SETTINGS_MASK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.Buffer),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.PerfDecreaseTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.PerfIncreaseTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.PerfDecreasePolicy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.PerfIncreasePolicy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.PerfDecreaseThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.PerfIncreaseThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.PerfMinPolicy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.PerfMaxPolicy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.PerfTimeCheck),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.PerfBoostPolicy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.PerfBoostMode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ThrottlingPolicy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.PerfHistoryCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ParkingPerfState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.LatencyHintPerf),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.LatencyHintEpp),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.LatencyHintUnpark),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.CPMinCores),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.CPMaxCores),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.CPDecreasePolicy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.CPIncreasePolicy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.CPDecreaseTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.CPIncreaseTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.CPOverUtilizationThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.CPDistributeUtility),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.CPConcurrencyThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.CPHeadroomThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.CPDistributeThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.IdleAllowScaling),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.IdleDisabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.IdleTimeCheck),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.IdleDemoteThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.IdlePromoteThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.EnergyPerfPreference),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.AutonomousActivityWindow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.AutonomousMode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.DutyCycling),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.FrequencyCap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.IdleStateMax),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ResponsivenessDisableThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ResponsivenessEnableThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ResponsivenessDisableTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ResponsivenessEnableTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ResponsivenessEppCeiling),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ResponsivenessPerfFloor),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.SoftParkLatency),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ModuleUnparkPolicy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ComplexUnparkPolicy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.SmtUnparkPolicy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.RestrictionCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ResourcePriority),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.HeteroDecreaseTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.HeteroIncreaseTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.HeteroDecreaseThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.HeteroIncreaseThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.Class0FloorPerformance),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.Class1InitialPerformance),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.SchedulingPolicy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ShortSchedulingPolicy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ShortThreadRuntimeThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ShortThreadArchClassUpperThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.ShortThreadArchClassLowerThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.LongThreadArchClassUpperThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.LongThreadArchClassLowerThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.HeteroPolicy),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.HeteroContainmentIncreaseTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.HeteroContainmentDecreaseTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.HeteroEfficiencyContainmentThreshold),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.HeteroHybridContainmentThreshold),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_POLICY_SETTINGS_MASK.HeteroContainmentPolicy),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PPM_POLICY_SETTINGS_MASK>((mem, ptr) => new _PPM_POLICY_SETTINGS_MASK(mem, ptr), offsets);
        }
    }
}