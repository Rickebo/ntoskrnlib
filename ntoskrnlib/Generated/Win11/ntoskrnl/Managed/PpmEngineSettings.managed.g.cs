using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PPM_ENGINE_SETTINGS")]
    public sealed class PpmEngineSettings : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray ExplicitSetting { get => ReadStructure<DynamicArray>(nameof(ExplicitSetting)); set => WriteStructure(nameof(ExplicitSetting), value); }

        [Offset(32UL)]
        public byte ThrottlingPolicy { get => ReadHere<byte>(nameof(ThrottlingPolicy)); set => WriteHere(nameof(ThrottlingPolicy), value); }

        [Offset(36UL)]
        public uint PerfTimeCheck { get => ReadHere<uint>(nameof(PerfTimeCheck)); set => WriteHere(nameof(PerfTimeCheck), value); }

        [Offset(40UL)]
        [Length(2)]
        public DynamicArray PerfHistoryCount { get => ReadStructure<DynamicArray>(nameof(PerfHistoryCount)); set => WriteStructure(nameof(PerfHistoryCount), value); }

        [Offset(42UL)]
        [Length(2)]
        public DynamicArray PerfMinPolicy { get => ReadStructure<DynamicArray>(nameof(PerfMinPolicy)); set => WriteStructure(nameof(PerfMinPolicy), value); }

        [Offset(44UL)]
        [Length(2)]
        public DynamicArray PerfMaxPolicy { get => ReadStructure<DynamicArray>(nameof(PerfMaxPolicy)); set => WriteStructure(nameof(PerfMaxPolicy), value); }

        [Offset(46UL)]
        [Length(2)]
        public DynamicArray PerfDecreaseTime { get => ReadStructure<DynamicArray>(nameof(PerfDecreaseTime)); set => WriteStructure(nameof(PerfDecreaseTime), value); }

        [Offset(48UL)]
        [Length(2)]
        public DynamicArray PerfIncreaseTime { get => ReadStructure<DynamicArray>(nameof(PerfIncreaseTime)); set => WriteStructure(nameof(PerfIncreaseTime), value); }

        [Offset(50UL)]
        [Length(2)]
        public DynamicArray PerfDecreasePolicy { get => ReadStructure<DynamicArray>(nameof(PerfDecreasePolicy)); set => WriteStructure(nameof(PerfDecreasePolicy), value); }

        [Offset(52UL)]
        [Length(2)]
        public DynamicArray PerfIncreasePolicy { get => ReadStructure<DynamicArray>(nameof(PerfIncreasePolicy)); set => WriteStructure(nameof(PerfIncreasePolicy), value); }

        [Offset(54UL)]
        [Length(2)]
        public DynamicArray PerfDecreaseThreshold { get => ReadStructure<DynamicArray>(nameof(PerfDecreaseThreshold)); set => WriteStructure(nameof(PerfDecreaseThreshold), value); }

        [Offset(56UL)]
        [Length(2)]
        public DynamicArray PerfIncreaseThreshold { get => ReadStructure<DynamicArray>(nameof(PerfIncreaseThreshold)); set => WriteStructure(nameof(PerfIncreaseThreshold), value); }

        [Offset(60UL)]
        [Length(2)]
        public DynamicArray PerfFrequencyCap { get => ReadStructure<DynamicArray>(nameof(PerfFrequencyCap)); set => WriteStructure(nameof(PerfFrequencyCap), value); }

        [Offset(68UL)]
        public uint PerfBoostPolicy { get => ReadHere<uint>(nameof(PerfBoostPolicy)); set => WriteHere(nameof(PerfBoostPolicy), value); }

        [Offset(72UL)]
        public uint PerfBoostMode { get => ReadHere<uint>(nameof(PerfBoostMode)); set => WriteHere(nameof(PerfBoostMode), value); }

        [Offset(76UL)]
        public uint PerfReductionTolerance { get => ReadHere<uint>(nameof(PerfReductionTolerance)); set => WriteHere(nameof(PerfReductionTolerance), value); }

        [Offset(80UL)]
        [Length(2)]
        public DynamicArray EnergyPerfPreference { get => ReadStructure<DynamicArray>(nameof(EnergyPerfPreference)); set => WriteStructure(nameof(EnergyPerfPreference), value); }

        [Offset(88UL)]
        public uint AutonomousActivityWindow { get => ReadHere<uint>(nameof(AutonomousActivityWindow)); set => WriteHere(nameof(AutonomousActivityWindow), value); }

        [Offset(92UL)]
        public byte AutonomousPreference { get => ReadHere<byte>(nameof(AutonomousPreference)); set => WriteHere(nameof(AutonomousPreference), value); }

        [Offset(93UL)]
        [Length(2)]
        public DynamicArray LatencyHintPerf { get => ReadStructure<DynamicArray>(nameof(LatencyHintPerf)); set => WriteStructure(nameof(LatencyHintPerf), value); }

        [Offset(95UL)]
        [Length(2)]
        public DynamicArray LatencyHintEpp { get => ReadStructure<DynamicArray>(nameof(LatencyHintEpp)); set => WriteStructure(nameof(LatencyHintEpp), value); }

        [Offset(97UL)]
        [Length(2)]
        public DynamicArray LatencyHintUnpark { get => ReadStructure<DynamicArray>(nameof(LatencyHintUnpark)); set => WriteStructure(nameof(LatencyHintUnpark), value); }

        [Offset(100UL)]
        [Length(2)]
        public DynamicArray ResponsivenessDisableThreshold { get => ReadStructure<DynamicArray>(nameof(ResponsivenessDisableThreshold)); set => WriteStructure(nameof(ResponsivenessDisableThreshold), value); }

        [Offset(108UL)]
        [Length(2)]
        public DynamicArray ResponsivenessEnableThreshold { get => ReadStructure<DynamicArray>(nameof(ResponsivenessEnableThreshold)); set => WriteStructure(nameof(ResponsivenessEnableThreshold), value); }

        [Offset(116UL)]
        [Length(2)]
        public DynamicArray ResponsivenessDisableTime { get => ReadStructure<DynamicArray>(nameof(ResponsivenessDisableTime)); set => WriteStructure(nameof(ResponsivenessDisableTime), value); }

        [Offset(118UL)]
        [Length(2)]
        public DynamicArray ResponsivenessEnableTime { get => ReadStructure<DynamicArray>(nameof(ResponsivenessEnableTime)); set => WriteStructure(nameof(ResponsivenessEnableTime), value); }

        [Offset(120UL)]
        [Length(2)]
        public DynamicArray ResponsivenessEppCeiling { get => ReadStructure<DynamicArray>(nameof(ResponsivenessEppCeiling)); set => WriteStructure(nameof(ResponsivenessEppCeiling), value); }

        [Offset(128UL)]
        [Length(2)]
        public DynamicArray ResponsivenessPerfFloor { get => ReadStructure<DynamicArray>(nameof(ResponsivenessPerfFloor)); set => WriteStructure(nameof(ResponsivenessPerfFloor), value); }

        [Offset(136UL)]
        public byte DutyCycling { get => ReadHere<byte>(nameof(DutyCycling)); set => WriteHere(nameof(DutyCycling), value); }

        [Offset(137UL)]
        [Length(2)]
        public DynamicArray ParkingPerfState { get => ReadStructure<DynamicArray>(nameof(ParkingPerfState)); set => WriteStructure(nameof(ParkingPerfState), value); }

        [Offset(139UL)]
        public byte DistributeUtility { get => ReadHere<byte>(nameof(DistributeUtility)); set => WriteHere(nameof(DistributeUtility), value); }

        [Offset(140UL)]
        public byte CoreParkingOverUtilizationThreshold { get => ReadHere<byte>(nameof(CoreParkingOverUtilizationThreshold)); set => WriteHere(nameof(CoreParkingOverUtilizationThreshold), value); }

        [Offset(141UL)]
        public byte CoreParkingConcurrencyThreshold { get => ReadHere<byte>(nameof(CoreParkingConcurrencyThreshold)); set => WriteHere(nameof(CoreParkingConcurrencyThreshold), value); }

        [Offset(142UL)]
        public byte CoreParkingHeadroomThreshold { get => ReadHere<byte>(nameof(CoreParkingHeadroomThreshold)); set => WriteHere(nameof(CoreParkingHeadroomThreshold), value); }

        [Offset(143UL)]
        public byte CoreParkingDistributionThreshold { get => ReadHere<byte>(nameof(CoreParkingDistributionThreshold)); set => WriteHere(nameof(CoreParkingDistributionThreshold), value); }

        [Offset(144UL)]
        public byte CoreParkingDecreasePolicy { get => ReadHere<byte>(nameof(CoreParkingDecreasePolicy)); set => WriteHere(nameof(CoreParkingDecreasePolicy), value); }

        [Offset(145UL)]
        public byte CoreParkingIncreasePolicy { get => ReadHere<byte>(nameof(CoreParkingIncreasePolicy)); set => WriteHere(nameof(CoreParkingIncreasePolicy), value); }

        [Offset(148UL)]
        public uint CoreParkingDecreaseTime { get => ReadHere<uint>(nameof(CoreParkingDecreaseTime)); set => WriteHere(nameof(CoreParkingDecreaseTime), value); }

        [Offset(152UL)]
        public uint CoreParkingIncreaseTime { get => ReadHere<uint>(nameof(CoreParkingIncreaseTime)); set => WriteHere(nameof(CoreParkingIncreaseTime), value); }

        [Offset(156UL)]
        [Length(2)]
        public DynamicArray CoreParkingMinCores { get => ReadStructure<DynamicArray>(nameof(CoreParkingMinCores)); set => WriteStructure(nameof(CoreParkingMinCores), value); }

        [Offset(158UL)]
        [Length(2)]
        public DynamicArray CoreParkingMaxCores { get => ReadStructure<DynamicArray>(nameof(CoreParkingMaxCores)); set => WriteStructure(nameof(CoreParkingMaxCores), value); }

        [Offset(160UL)]
        public uint SoftParkLatency { get => ReadHere<uint>(nameof(SoftParkLatency)); set => WriteHere(nameof(SoftParkLatency), value); }

        [Offset(164UL)]
        public byte AllowScaling { get => ReadHere<byte>(nameof(AllowScaling)); set => WriteHere(nameof(AllowScaling), value); }

        [Offset(165UL)]
        public byte IdleDisabled { get => ReadHere<byte>(nameof(IdleDisabled)); set => WriteHere(nameof(IdleDisabled), value); }

        [Offset(168UL)]
        public uint IdleTimeCheck { get => ReadHere<uint>(nameof(IdleTimeCheck)); set => WriteHere(nameof(IdleTimeCheck), value); }

        [Offset(172UL)]
        public byte IdleDemotePercent { get => ReadHere<byte>(nameof(IdleDemotePercent)); set => WriteHere(nameof(IdleDemotePercent), value); }

        [Offset(173UL)]
        public byte IdlePromotePercent { get => ReadHere<byte>(nameof(IdlePromotePercent)); set => WriteHere(nameof(IdlePromotePercent), value); }

        [Offset(174UL)]
        public byte IdleStateMax { get => ReadHere<byte>(nameof(IdleStateMax)); set => WriteHere(nameof(IdleStateMax), value); }

        [Offset(175UL)]
        [Length(2)]
        public DynamicArray ResourcePriority { get => ReadStructure<DynamicArray>(nameof(ResourcePriority)); set => WriteStructure(nameof(ResourcePriority), value); }

        [Offset(177UL)]
        public byte HeteroDecreaseTime { get => ReadHere<byte>(nameof(HeteroDecreaseTime)); set => WriteHere(nameof(HeteroDecreaseTime), value); }

        [Offset(178UL)]
        public byte HeteroIncreaseTime { get => ReadHere<byte>(nameof(HeteroIncreaseTime)); set => WriteHere(nameof(HeteroIncreaseTime), value); }

        [Offset(179UL)]
        [Length(2)]
        public DynamicArray HeteroDecreaseThreshold { get => ReadStructure<DynamicArray>(nameof(HeteroDecreaseThreshold)); set => WriteStructure(nameof(HeteroDecreaseThreshold), value); }

        [Offset(307UL)]
        [Length(2)]
        public DynamicArray HeteroIncreaseThreshold { get => ReadStructure<DynamicArray>(nameof(HeteroIncreaseThreshold)); set => WriteStructure(nameof(HeteroIncreaseThreshold), value); }

        [Offset(435UL)]
        public byte Class0FloorPerformance { get => ReadHere<byte>(nameof(Class0FloorPerformance)); set => WriteHere(nameof(Class0FloorPerformance), value); }

        [Offset(436UL)]
        public byte Class1InitialPerformance { get => ReadHere<byte>(nameof(Class1InitialPerformance)); set => WriteHere(nameof(Class1InitialPerformance), value); }

        [Offset(440UL)]
        public uint ShortThreadRuntimeThreshold { get => ReadHere<uint>(nameof(ShortThreadRuntimeThreshold)); set => WriteHere(nameof(ShortThreadRuntimeThreshold), value); }

        [Offset(444UL)]
        [Length(2)]
        public DynamicArray ThreadPolicies { get => ReadStructure<DynamicArray>(nameof(ThreadPolicies)); set => WriteStructure(nameof(ThreadPolicies), value); }

        [Offset(452UL)]
        [Length(2)]
        public DynamicArray ArchClassLowerThreshold { get => ReadStructure<DynamicArray>(nameof(ArchClassLowerThreshold)); set => WriteStructure(nameof(ArchClassLowerThreshold), value); }

        [Offset(454UL)]
        [Length(2)]
        public DynamicArray ArchClassUpperThreshold { get => ReadStructure<DynamicArray>(nameof(ArchClassUpperThreshold)); set => WriteStructure(nameof(ArchClassUpperThreshold), value); }

        [Offset(456UL)]
        public byte ModuleUnparkPolicy { get => ReadHere<byte>(nameof(ModuleUnparkPolicy)); set => WriteHere(nameof(ModuleUnparkPolicy), value); }

        [Offset(457UL)]
        public byte ComplexUnparkPolicy { get => ReadHere<byte>(nameof(ComplexUnparkPolicy)); set => WriteHere(nameof(ComplexUnparkPolicy), value); }

        [Offset(458UL)]
        public byte SmtUnparkPolicy { get => ReadHere<byte>(nameof(SmtUnparkPolicy)); set => WriteHere(nameof(SmtUnparkPolicy), value); }

        [Offset(460UL)]
        public uint HeteroPolicy { get => ReadHere<uint>(nameof(HeteroPolicy)); set => WriteHere(nameof(HeteroPolicy), value); }

        [Offset(464UL)]
        public uint HeteroContainmentDecreaseTime { get => ReadHere<uint>(nameof(HeteroContainmentDecreaseTime)); set => WriteHere(nameof(HeteroContainmentDecreaseTime), value); }

        [Offset(468UL)]
        public uint HeteroContainmentIncreaseTime { get => ReadHere<uint>(nameof(HeteroContainmentIncreaseTime)); set => WriteHere(nameof(HeteroContainmentIncreaseTime), value); }

        [Offset(472UL)]
        public uint HeteroEfficiencyContainmentThreshold { get => ReadHere<uint>(nameof(HeteroEfficiencyContainmentThreshold)); set => WriteHere(nameof(HeteroEfficiencyContainmentThreshold), value); }

        [Offset(476UL)]
        public uint HeteroHybridContainmentThreshold { get => ReadHere<uint>(nameof(HeteroHybridContainmentThreshold)); set => WriteHere(nameof(HeteroHybridContainmentThreshold), value); }

        [Offset(480UL)]
        public uint HeteroContainmentPolicy { get => ReadHere<uint>(nameof(HeteroContainmentPolicy)); set => WriteHere(nameof(HeteroContainmentPolicy), value); }

        [Offset(484UL)]
        public byte RestrictionCount { get => ReadHere<byte>(nameof(RestrictionCount)); set => WriteHere(nameof(RestrictionCount), value); }

        public PpmEngineSettings(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmEngineSettings>();
        }
    }
}