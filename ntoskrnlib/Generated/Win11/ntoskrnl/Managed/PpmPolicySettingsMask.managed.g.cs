using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PPM_POLICY_SETTINGS_MASK")]
    public sealed class PpmPolicySettingsMask : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray Buffer { get => ReadStructure<DynamicArray>(nameof(Buffer)); set => WriteStructure(nameof(Buffer), value); }

        [Offset(0UL)]
        public ulong PerfDecreaseTime { get => ReadHere<ulong>(nameof(PerfDecreaseTime)); set => WriteHere(nameof(PerfDecreaseTime), value); }

        [Offset(0UL)]
        public ulong PerfIncreaseTime { get => ReadHere<ulong>(nameof(PerfIncreaseTime)); set => WriteHere(nameof(PerfIncreaseTime), value); }

        [Offset(0UL)]
        public ulong PerfDecreasePolicy { get => ReadHere<ulong>(nameof(PerfDecreasePolicy)); set => WriteHere(nameof(PerfDecreasePolicy), value); }

        [Offset(0UL)]
        public ulong PerfIncreasePolicy { get => ReadHere<ulong>(nameof(PerfIncreasePolicy)); set => WriteHere(nameof(PerfIncreasePolicy), value); }

        [Offset(0UL)]
        public ulong PerfDecreaseThreshold { get => ReadHere<ulong>(nameof(PerfDecreaseThreshold)); set => WriteHere(nameof(PerfDecreaseThreshold), value); }

        [Offset(0UL)]
        public ulong PerfIncreaseThreshold { get => ReadHere<ulong>(nameof(PerfIncreaseThreshold)); set => WriteHere(nameof(PerfIncreaseThreshold), value); }

        [Offset(0UL)]
        public ulong PerfMinPolicy { get => ReadHere<ulong>(nameof(PerfMinPolicy)); set => WriteHere(nameof(PerfMinPolicy), value); }

        [Offset(0UL)]
        public ulong PerfMaxPolicy { get => ReadHere<ulong>(nameof(PerfMaxPolicy)); set => WriteHere(nameof(PerfMaxPolicy), value); }

        [Offset(0UL)]
        public ulong PerfTimeCheck { get => ReadHere<ulong>(nameof(PerfTimeCheck)); set => WriteHere(nameof(PerfTimeCheck), value); }

        [Offset(0UL)]
        public ulong PerfBoostPolicy { get => ReadHere<ulong>(nameof(PerfBoostPolicy)); set => WriteHere(nameof(PerfBoostPolicy), value); }

        [Offset(0UL)]
        public ulong PerfBoostMode { get => ReadHere<ulong>(nameof(PerfBoostMode)); set => WriteHere(nameof(PerfBoostMode), value); }

        [Offset(0UL)]
        public ulong ThrottlingPolicy { get => ReadHere<ulong>(nameof(ThrottlingPolicy)); set => WriteHere(nameof(ThrottlingPolicy), value); }

        [Offset(0UL)]
        public ulong PerfHistoryCount { get => ReadHere<ulong>(nameof(PerfHistoryCount)); set => WriteHere(nameof(PerfHistoryCount), value); }

        [Offset(0UL)]
        public ulong ParkingPerfState { get => ReadHere<ulong>(nameof(ParkingPerfState)); set => WriteHere(nameof(ParkingPerfState), value); }

        [Offset(0UL)]
        public ulong LatencyHintPerf { get => ReadHere<ulong>(nameof(LatencyHintPerf)); set => WriteHere(nameof(LatencyHintPerf), value); }

        [Offset(0UL)]
        public ulong LatencyHintEpp { get => ReadHere<ulong>(nameof(LatencyHintEpp)); set => WriteHere(nameof(LatencyHintEpp), value); }

        [Offset(0UL)]
        public ulong LatencyHintUnpark { get => ReadHere<ulong>(nameof(LatencyHintUnpark)); set => WriteHere(nameof(LatencyHintUnpark), value); }

        [Offset(0UL)]
        public ulong CPMinCores { get => ReadHere<ulong>(nameof(CPMinCores)); set => WriteHere(nameof(CPMinCores), value); }

        [Offset(0UL)]
        public ulong CPMaxCores { get => ReadHere<ulong>(nameof(CPMaxCores)); set => WriteHere(nameof(CPMaxCores), value); }

        [Offset(0UL)]
        public ulong CPDecreasePolicy { get => ReadHere<ulong>(nameof(CPDecreasePolicy)); set => WriteHere(nameof(CPDecreasePolicy), value); }

        [Offset(0UL)]
        public ulong CPIncreasePolicy { get => ReadHere<ulong>(nameof(CPIncreasePolicy)); set => WriteHere(nameof(CPIncreasePolicy), value); }

        [Offset(0UL)]
        public ulong CPDecreaseTime { get => ReadHere<ulong>(nameof(CPDecreaseTime)); set => WriteHere(nameof(CPDecreaseTime), value); }

        [Offset(0UL)]
        public ulong CPIncreaseTime { get => ReadHere<ulong>(nameof(CPIncreaseTime)); set => WriteHere(nameof(CPIncreaseTime), value); }

        [Offset(0UL)]
        public ulong CPOverUtilizationThreshold { get => ReadHere<ulong>(nameof(CPOverUtilizationThreshold)); set => WriteHere(nameof(CPOverUtilizationThreshold), value); }

        [Offset(0UL)]
        public ulong CPDistributeUtility { get => ReadHere<ulong>(nameof(CPDistributeUtility)); set => WriteHere(nameof(CPDistributeUtility), value); }

        [Offset(0UL)]
        public ulong CPConcurrencyThreshold { get => ReadHere<ulong>(nameof(CPConcurrencyThreshold)); set => WriteHere(nameof(CPConcurrencyThreshold), value); }

        [Offset(0UL)]
        public ulong CPHeadroomThreshold { get => ReadHere<ulong>(nameof(CPHeadroomThreshold)); set => WriteHere(nameof(CPHeadroomThreshold), value); }

        [Offset(0UL)]
        public ulong CPDistributeThreshold { get => ReadHere<ulong>(nameof(CPDistributeThreshold)); set => WriteHere(nameof(CPDistributeThreshold), value); }

        [Offset(0UL)]
        public ulong IdleAllowScaling { get => ReadHere<ulong>(nameof(IdleAllowScaling)); set => WriteHere(nameof(IdleAllowScaling), value); }

        [Offset(0UL)]
        public ulong IdleDisabled { get => ReadHere<ulong>(nameof(IdleDisabled)); set => WriteHere(nameof(IdleDisabled), value); }

        [Offset(0UL)]
        public ulong IdleTimeCheck { get => ReadHere<ulong>(nameof(IdleTimeCheck)); set => WriteHere(nameof(IdleTimeCheck), value); }

        [Offset(0UL)]
        public ulong IdleDemoteThreshold { get => ReadHere<ulong>(nameof(IdleDemoteThreshold)); set => WriteHere(nameof(IdleDemoteThreshold), value); }

        [Offset(0UL)]
        public ulong IdlePromoteThreshold { get => ReadHere<ulong>(nameof(IdlePromoteThreshold)); set => WriteHere(nameof(IdlePromoteThreshold), value); }

        [Offset(0UL)]
        public ulong EnergyPerfPreference { get => ReadHere<ulong>(nameof(EnergyPerfPreference)); set => WriteHere(nameof(EnergyPerfPreference), value); }

        [Offset(0UL)]
        public ulong AutonomousActivityWindow { get => ReadHere<ulong>(nameof(AutonomousActivityWindow)); set => WriteHere(nameof(AutonomousActivityWindow), value); }

        [Offset(0UL)]
        public ulong AutonomousMode { get => ReadHere<ulong>(nameof(AutonomousMode)); set => WriteHere(nameof(AutonomousMode), value); }

        [Offset(0UL)]
        public ulong DutyCycling { get => ReadHere<ulong>(nameof(DutyCycling)); set => WriteHere(nameof(DutyCycling), value); }

        [Offset(0UL)]
        public ulong FrequencyCap { get => ReadHere<ulong>(nameof(FrequencyCap)); set => WriteHere(nameof(FrequencyCap), value); }

        [Offset(0UL)]
        public ulong IdleStateMax { get => ReadHere<ulong>(nameof(IdleStateMax)); set => WriteHere(nameof(IdleStateMax), value); }

        [Offset(0UL)]
        public ulong ResponsivenessDisableThreshold { get => ReadHere<ulong>(nameof(ResponsivenessDisableThreshold)); set => WriteHere(nameof(ResponsivenessDisableThreshold), value); }

        [Offset(0UL)]
        public ulong ResponsivenessEnableThreshold { get => ReadHere<ulong>(nameof(ResponsivenessEnableThreshold)); set => WriteHere(nameof(ResponsivenessEnableThreshold), value); }

        [Offset(0UL)]
        public ulong ResponsivenessDisableTime { get => ReadHere<ulong>(nameof(ResponsivenessDisableTime)); set => WriteHere(nameof(ResponsivenessDisableTime), value); }

        [Offset(0UL)]
        public ulong ResponsivenessEnableTime { get => ReadHere<ulong>(nameof(ResponsivenessEnableTime)); set => WriteHere(nameof(ResponsivenessEnableTime), value); }

        [Offset(0UL)]
        public ulong ResponsivenessEppCeiling { get => ReadHere<ulong>(nameof(ResponsivenessEppCeiling)); set => WriteHere(nameof(ResponsivenessEppCeiling), value); }

        [Offset(0UL)]
        public ulong ResponsivenessPerfFloor { get => ReadHere<ulong>(nameof(ResponsivenessPerfFloor)); set => WriteHere(nameof(ResponsivenessPerfFloor), value); }

        [Offset(0UL)]
        public ulong SoftParkLatency { get => ReadHere<ulong>(nameof(SoftParkLatency)); set => WriteHere(nameof(SoftParkLatency), value); }

        [Offset(0UL)]
        public ulong ModuleUnparkPolicy { get => ReadHere<ulong>(nameof(ModuleUnparkPolicy)); set => WriteHere(nameof(ModuleUnparkPolicy), value); }

        [Offset(0UL)]
        public ulong ComplexUnparkPolicy { get => ReadHere<ulong>(nameof(ComplexUnparkPolicy)); set => WriteHere(nameof(ComplexUnparkPolicy), value); }

        [Offset(0UL)]
        public ulong SmtUnparkPolicy { get => ReadHere<ulong>(nameof(SmtUnparkPolicy)); set => WriteHere(nameof(SmtUnparkPolicy), value); }

        [Offset(0UL)]
        public ulong RestrictionCount { get => ReadHere<ulong>(nameof(RestrictionCount)); set => WriteHere(nameof(RestrictionCount), value); }

        [Offset(0UL)]
        public ulong ResourcePriority { get => ReadHere<ulong>(nameof(ResourcePriority)); set => WriteHere(nameof(ResourcePriority), value); }

        [Offset(0UL)]
        public ulong HeteroDecreaseTime { get => ReadHere<ulong>(nameof(HeteroDecreaseTime)); set => WriteHere(nameof(HeteroDecreaseTime), value); }

        [Offset(0UL)]
        public ulong HeteroIncreaseTime { get => ReadHere<ulong>(nameof(HeteroIncreaseTime)); set => WriteHere(nameof(HeteroIncreaseTime), value); }

        [Offset(0UL)]
        public ulong HeteroDecreaseThreshold { get => ReadHere<ulong>(nameof(HeteroDecreaseThreshold)); set => WriteHere(nameof(HeteroDecreaseThreshold), value); }

        [Offset(0UL)]
        public ulong HeteroIncreaseThreshold { get => ReadHere<ulong>(nameof(HeteroIncreaseThreshold)); set => WriteHere(nameof(HeteroIncreaseThreshold), value); }

        [Offset(0UL)]
        public ulong Class0FloorPerformance { get => ReadHere<ulong>(nameof(Class0FloorPerformance)); set => WriteHere(nameof(Class0FloorPerformance), value); }

        [Offset(0UL)]
        public ulong Class1InitialPerformance { get => ReadHere<ulong>(nameof(Class1InitialPerformance)); set => WriteHere(nameof(Class1InitialPerformance), value); }

        [Offset(0UL)]
        public ulong SchedulingPolicy { get => ReadHere<ulong>(nameof(SchedulingPolicy)); set => WriteHere(nameof(SchedulingPolicy), value); }

        [Offset(0UL)]
        public ulong ShortSchedulingPolicy { get => ReadHere<ulong>(nameof(ShortSchedulingPolicy)); set => WriteHere(nameof(ShortSchedulingPolicy), value); }

        [Offset(0UL)]
        public ulong ShortThreadRuntimeThreshold { get => ReadHere<ulong>(nameof(ShortThreadRuntimeThreshold)); set => WriteHere(nameof(ShortThreadRuntimeThreshold), value); }

        [Offset(0UL)]
        public ulong ShortThreadArchClassUpperThreshold { get => ReadHere<ulong>(nameof(ShortThreadArchClassUpperThreshold)); set => WriteHere(nameof(ShortThreadArchClassUpperThreshold), value); }

        [Offset(0UL)]
        public ulong ShortThreadArchClassLowerThreshold { get => ReadHere<ulong>(nameof(ShortThreadArchClassLowerThreshold)); set => WriteHere(nameof(ShortThreadArchClassLowerThreshold), value); }

        [Offset(0UL)]
        public ulong LongThreadArchClassUpperThreshold { get => ReadHere<ulong>(nameof(LongThreadArchClassUpperThreshold)); set => WriteHere(nameof(LongThreadArchClassUpperThreshold), value); }

        [Offset(0UL)]
        public ulong LongThreadArchClassLowerThreshold { get => ReadHere<ulong>(nameof(LongThreadArchClassLowerThreshold)); set => WriteHere(nameof(LongThreadArchClassLowerThreshold), value); }

        [Offset(8UL)]
        public ulong HeteroPolicy { get => ReadHere<ulong>(nameof(HeteroPolicy)); set => WriteHere(nameof(HeteroPolicy), value); }

        [Offset(8UL)]
        public ulong HeteroContainmentIncreaseTime { get => ReadHere<ulong>(nameof(HeteroContainmentIncreaseTime)); set => WriteHere(nameof(HeteroContainmentIncreaseTime), value); }

        [Offset(8UL)]
        public ulong HeteroContainmentDecreaseTime { get => ReadHere<ulong>(nameof(HeteroContainmentDecreaseTime)); set => WriteHere(nameof(HeteroContainmentDecreaseTime), value); }

        [Offset(8UL)]
        public ulong HeteroEfficiencyContainmentThreshold { get => ReadHere<ulong>(nameof(HeteroEfficiencyContainmentThreshold)); set => WriteHere(nameof(HeteroEfficiencyContainmentThreshold), value); }

        [Offset(8UL)]
        public ulong HeteroHybridContainmentThreshold { get => ReadHere<ulong>(nameof(HeteroHybridContainmentThreshold)); set => WriteHere(nameof(HeteroHybridContainmentThreshold), value); }

        [Offset(8UL)]
        public ulong HeteroContainmentPolicy { get => ReadHere<ulong>(nameof(HeteroContainmentPolicy)); set => WriteHere(nameof(HeteroContainmentPolicy), value); }

        public PpmPolicySettingsMask(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmPolicySettingsMask>();
        }
    }
}