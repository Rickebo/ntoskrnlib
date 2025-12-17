#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PPM_POLICY_SETTINGS_MASK
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] Buffer;
        [FieldOffset(0)]
        public ulong PerfDecreaseTime;
        [FieldOffset(0)]
        public ulong PerfIncreaseTime;
        [FieldOffset(0)]
        public ulong PerfDecreasePolicy;
        [FieldOffset(0)]
        public ulong PerfIncreasePolicy;
        [FieldOffset(0)]
        public ulong PerfDecreaseThreshold;
        [FieldOffset(0)]
        public ulong PerfIncreaseThreshold;
        [FieldOffset(0)]
        public ulong PerfMinPolicy;
        [FieldOffset(0)]
        public ulong PerfMaxPolicy;
        [FieldOffset(0)]
        public ulong PerfTimeCheck;
        [FieldOffset(0)]
        public ulong PerfBoostPolicy;
        [FieldOffset(0)]
        public ulong PerfBoostMode;
        [FieldOffset(0)]
        public ulong ThrottlingPolicy;
        [FieldOffset(0)]
        public ulong PerfHistoryCount;
        [FieldOffset(0)]
        public ulong ParkingPerfState;
        [FieldOffset(0)]
        public ulong LatencyHintPerf;
        [FieldOffset(0)]
        public ulong LatencyHintEpp;
        [FieldOffset(0)]
        public ulong LatencyHintUnpark;
        [FieldOffset(0)]
        public ulong CPMinCores;
        [FieldOffset(0)]
        public ulong CPMaxCores;
        [FieldOffset(0)]
        public ulong CPDecreasePolicy;
        [FieldOffset(0)]
        public ulong CPIncreasePolicy;
        [FieldOffset(0)]
        public ulong CPDecreaseTime;
        [FieldOffset(0)]
        public ulong CPIncreaseTime;
        [FieldOffset(0)]
        public ulong CPOverUtilizationThreshold;
        [FieldOffset(0)]
        public ulong CPDistributeUtility;
        [FieldOffset(0)]
        public ulong CPConcurrencyThreshold;
        [FieldOffset(0)]
        public ulong CPHeadroomThreshold;
        [FieldOffset(0)]
        public ulong CPDistributeThreshold;
        [FieldOffset(0)]
        public ulong IdleAllowScaling;
        [FieldOffset(0)]
        public ulong IdleDisabled;
        [FieldOffset(0)]
        public ulong IdleTimeCheck;
        [FieldOffset(0)]
        public ulong IdleDemoteThreshold;
        [FieldOffset(0)]
        public ulong IdlePromoteThreshold;
        [FieldOffset(0)]
        public ulong EnergyPerfPreference;
        [FieldOffset(0)]
        public ulong AutonomousActivityWindow;
        [FieldOffset(0)]
        public ulong AutonomousMode;
        [FieldOffset(0)]
        public ulong DutyCycling;
        [FieldOffset(0)]
        public ulong FrequencyCap;
        [FieldOffset(0)]
        public ulong IdleStateMax;
        [FieldOffset(0)]
        public ulong ResponsivenessDisableThreshold;
        [FieldOffset(0)]
        public ulong ResponsivenessEnableThreshold;
        [FieldOffset(0)]
        public ulong ResponsivenessDisableTime;
        [FieldOffset(0)]
        public ulong ResponsivenessEnableTime;
        [FieldOffset(0)]
        public ulong ResponsivenessEppCeiling;
        [FieldOffset(0)]
        public ulong ResponsivenessPerfFloor;
        [FieldOffset(0)]
        public ulong SoftParkLatency;
        [FieldOffset(0)]
        public ulong ModuleUnparkPolicy;
        [FieldOffset(0)]
        public ulong ComplexUnparkPolicy;
        [FieldOffset(0)]
        public ulong SmtUnparkPolicy;
        [FieldOffset(0)]
        public ulong RestrictionCount;
        [FieldOffset(0)]
        public ulong ResourcePriority;
        [FieldOffset(0)]
        public ulong HeteroDecreaseTime;
        [FieldOffset(0)]
        public ulong HeteroIncreaseTime;
        [FieldOffset(0)]
        public ulong HeteroDecreaseThreshold;
        [FieldOffset(0)]
        public ulong HeteroIncreaseThreshold;
        [FieldOffset(0)]
        public ulong Class0FloorPerformance;
        [FieldOffset(0)]
        public ulong Class1InitialPerformance;
        [FieldOffset(0)]
        public ulong SchedulingPolicy;
        [FieldOffset(0)]
        public ulong ShortSchedulingPolicy;
        [FieldOffset(0)]
        public ulong ShortThreadRuntimeThreshold;
        [FieldOffset(0)]
        public ulong ShortThreadArchClassUpperThreshold;
        [FieldOffset(0)]
        public ulong ShortThreadArchClassLowerThreshold;
        [FieldOffset(0)]
        public ulong LongThreadArchClassUpperThreshold;
        [FieldOffset(0)]
        public ulong LongThreadArchClassLowerThreshold;
        [FieldOffset(8)]
        public ulong HeteroPolicy;
        [FieldOffset(8)]
        public ulong HeteroContainmentIncreaseTime;
        [FieldOffset(8)]
        public ulong HeteroContainmentDecreaseTime;
        [FieldOffset(8)]
        public ulong HeteroEfficiencyContainmentThreshold;
        [FieldOffset(8)]
        public ulong HeteroHybridContainmentThreshold;
        [FieldOffset(8)]
        public ulong HeteroContainmentPolicy;
    }
}