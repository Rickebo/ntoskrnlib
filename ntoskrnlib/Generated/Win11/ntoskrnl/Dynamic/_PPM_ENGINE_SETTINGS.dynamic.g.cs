using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PPM_ENGINE_SETTINGS")]
    public sealed class _PPM_ENGINE_SETTINGS : DynamicStructure
    {
        public byte[] ExplicitSetting { get; }
        public byte ThrottlingPolicy { get; }
        public uint PerfTimeCheck { get; }
        public byte[] PerfHistoryCount { get; }
        public byte[] PerfMinPolicy { get; }
        public byte[] PerfMaxPolicy { get; }
        public byte[] PerfDecreaseTime { get; }
        public byte[] PerfIncreaseTime { get; }
        public byte[] PerfDecreasePolicy { get; }
        public byte[] PerfIncreasePolicy { get; }
        public byte[] PerfDecreaseThreshold { get; }
        public byte[] PerfIncreaseThreshold { get; }
        public uint[] PerfFrequencyCap { get; }
        public uint PerfBoostPolicy { get; }
        public uint PerfBoostMode { get; }
        public uint PerfReductionTolerance { get; }
        public uint[] EnergyPerfPreference { get; }
        public uint AutonomousActivityWindow { get; }
        public byte AutonomousPreference { get; }
        public byte[] LatencyHintPerf { get; }
        public byte[] LatencyHintEpp { get; }
        public byte[] LatencyHintUnpark { get; }
        public uint[] ResponsivenessDisableThreshold { get; }
        public uint[] ResponsivenessEnableThreshold { get; }
        public byte[] ResponsivenessDisableTime { get; }
        public byte[] ResponsivenessEnableTime { get; }
        public uint[] ResponsivenessEppCeiling { get; }
        public uint[] ResponsivenessPerfFloor { get; }
        public byte DutyCycling { get; }
        public byte[] ParkingPerfState { get; }
        public byte DistributeUtility { get; }
        public byte CoreParkingOverUtilizationThreshold { get; }
        public byte CoreParkingConcurrencyThreshold { get; }
        public byte CoreParkingHeadroomThreshold { get; }
        public byte CoreParkingDistributionThreshold { get; }
        public byte CoreParkingDecreasePolicy { get; }
        public byte CoreParkingIncreasePolicy { get; }
        public uint CoreParkingDecreaseTime { get; }
        public uint CoreParkingIncreaseTime { get; }
        public byte[] CoreParkingMinCores { get; }
        public byte[] CoreParkingMaxCores { get; }
        public uint SoftParkLatency { get; }
        public byte AllowScaling { get; }
        public byte IdleDisabled { get; }
        public uint IdleTimeCheck { get; }
        public byte IdleDemotePercent { get; }
        public byte IdlePromotePercent { get; }
        public byte IdleStateMax { get; }
        public byte[] ResourcePriority { get; }
        public byte HeteroDecreaseTime { get; }
        public byte HeteroIncreaseTime { get; }
        public byte[] HeteroDecreaseThreshold { get; }
        public byte[] HeteroIncreaseThreshold { get; }
        public byte Class0FloorPerformance { get; }
        public byte Class1InitialPerformance { get; }
        public uint ShortThreadRuntimeThreshold { get; }
        public uint[] ThreadPolicies { get; }
        public byte[] ArchClassLowerThreshold { get; }
        public byte[] ArchClassUpperThreshold { get; }
        public byte ModuleUnparkPolicy { get; }
        public byte ComplexUnparkPolicy { get; }
        public byte SmtUnparkPolicy { get; }
        public uint HeteroPolicy { get; }
        public uint HeteroContainmentDecreaseTime { get; }
        public uint HeteroContainmentIncreaseTime { get; }
        public uint HeteroEfficiencyContainmentThreshold { get; }
        public uint HeteroHybridContainmentThreshold { get; }
        public uint HeteroContainmentPolicy { get; }
        public byte RestrictionCount { get; }

        public _PPM_ENGINE_SETTINGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_ENGINE_SETTINGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_ENGINE_SETTINGS.ExplicitSetting),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ThrottlingPolicy),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.PerfTimeCheck),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.PerfHistoryCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.PerfMinPolicy),
                    new ulong[]
                    {
                        42UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.PerfMaxPolicy),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.PerfDecreaseTime),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.PerfIncreaseTime),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.PerfDecreasePolicy),
                    new ulong[]
                    {
                        50UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.PerfIncreasePolicy),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.PerfDecreaseThreshold),
                    new ulong[]
                    {
                        54UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.PerfIncreaseThreshold),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.PerfFrequencyCap),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.PerfBoostPolicy),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.PerfBoostMode),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.PerfReductionTolerance),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.EnergyPerfPreference),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.AutonomousActivityWindow),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.AutonomousPreference),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.LatencyHintPerf),
                    new ulong[]
                    {
                        93UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.LatencyHintEpp),
                    new ulong[]
                    {
                        95UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.LatencyHintUnpark),
                    new ulong[]
                    {
                        97UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ResponsivenessDisableThreshold),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ResponsivenessEnableThreshold),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ResponsivenessDisableTime),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ResponsivenessEnableTime),
                    new ulong[]
                    {
                        118UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ResponsivenessEppCeiling),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ResponsivenessPerfFloor),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.DutyCycling),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ParkingPerfState),
                    new ulong[]
                    {
                        137UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.DistributeUtility),
                    new ulong[]
                    {
                        139UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.CoreParkingOverUtilizationThreshold),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.CoreParkingConcurrencyThreshold),
                    new ulong[]
                    {
                        141UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.CoreParkingHeadroomThreshold),
                    new ulong[]
                    {
                        142UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.CoreParkingDistributionThreshold),
                    new ulong[]
                    {
                        143UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.CoreParkingDecreasePolicy),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.CoreParkingIncreasePolicy),
                    new ulong[]
                    {
                        145UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.CoreParkingDecreaseTime),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.CoreParkingIncreaseTime),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.CoreParkingMinCores),
                    new ulong[]
                    {
                        156UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.CoreParkingMaxCores),
                    new ulong[]
                    {
                        158UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.SoftParkLatency),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.AllowScaling),
                    new ulong[]
                    {
                        164UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.IdleDisabled),
                    new ulong[]
                    {
                        165UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.IdleTimeCheck),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.IdleDemotePercent),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.IdlePromotePercent),
                    new ulong[]
                    {
                        173UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.IdleStateMax),
                    new ulong[]
                    {
                        174UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ResourcePriority),
                    new ulong[]
                    {
                        175UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.HeteroDecreaseTime),
                    new ulong[]
                    {
                        177UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.HeteroIncreaseTime),
                    new ulong[]
                    {
                        178UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.HeteroDecreaseThreshold),
                    new ulong[]
                    {
                        179UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.HeteroIncreaseThreshold),
                    new ulong[]
                    {
                        307UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.Class0FloorPerformance),
                    new ulong[]
                    {
                        435UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.Class1InitialPerformance),
                    new ulong[]
                    {
                        436UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ShortThreadRuntimeThreshold),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ThreadPolicies),
                    new ulong[]
                    {
                        444UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ArchClassLowerThreshold),
                    new ulong[]
                    {
                        452UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ArchClassUpperThreshold),
                    new ulong[]
                    {
                        454UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ModuleUnparkPolicy),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.ComplexUnparkPolicy),
                    new ulong[]
                    {
                        457UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.SmtUnparkPolicy),
                    new ulong[]
                    {
                        458UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.HeteroPolicy),
                    new ulong[]
                    {
                        460UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.HeteroContainmentDecreaseTime),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.HeteroContainmentIncreaseTime),
                    new ulong[]
                    {
                        468UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.HeteroEfficiencyContainmentThreshold),
                    new ulong[]
                    {
                        472UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.HeteroHybridContainmentThreshold),
                    new ulong[]
                    {
                        476UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.HeteroContainmentPolicy),
                    new ulong[]
                    {
                        480UL
                    }
                },
                {
                    nameof(_PPM_ENGINE_SETTINGS.RestrictionCount),
                    new ulong[]
                    {
                        484UL
                    }
                }
            };
            Register<_PPM_ENGINE_SETTINGS>((mem, ptr) => new _PPM_ENGINE_SETTINGS(mem, ptr), offsets);
        }
    }
}