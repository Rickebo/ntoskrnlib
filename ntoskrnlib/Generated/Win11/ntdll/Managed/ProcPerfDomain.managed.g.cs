using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PROC_PERF_DOMAIN")]
    public sealed class ProcPerfDomain : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public IntPtr Master { get => ReadHere<IntPtr>(nameof(Master)); set => WriteHere(nameof(Master), value); }

        [Offset(24UL)]
        public KaffinityEx Members { get => ReadStructure<KaffinityEx>(nameof(Members)); set => WriteStructure(nameof(Members), value); }

        [Offset(288UL)]
        public ulong DomainContext { get => ReadHere<ulong>(nameof(DomainContext)); set => WriteHere(nameof(DomainContext), value); }

        [Offset(296UL)]
        public uint ProcessorCount { get => ReadHere<uint>(nameof(ProcessorCount)); set => WriteHere(nameof(ProcessorCount), value); }

        [Offset(300UL)]
        public byte EfficiencyClass { get => ReadHere<byte>(nameof(EfficiencyClass)); set => WriteHere(nameof(EfficiencyClass), value); }

        [Offset(301UL)]
        public byte NominalPerformanceClass { get => ReadHere<byte>(nameof(NominalPerformanceClass)); set => WriteHere(nameof(NominalPerformanceClass), value); }

        [Offset(302UL)]
        public byte PerformanceClass { get => ReadHere<byte>(nameof(PerformanceClass)); set => WriteHere(nameof(PerformanceClass), value); }

        [Offset(304UL)]
        public uint Presence { get => ReadHere<uint>(nameof(Presence)); set => WriteHere(nameof(Presence), value); }

        [Offset(312UL)]
        public IntPtr Processors { get => ReadHere<IntPtr>(nameof(Processors)); set => WriteHere(nameof(Processors), value); }

        [Offset(320UL)]
        public IntPtr GetFFHThrottleState { get => ReadHere<IntPtr>(nameof(GetFFHThrottleState)); set => WriteHere(nameof(GetFFHThrottleState), value); }

        [Offset(328UL)]
        public IntPtr TimeWindowHandler { get => ReadHere<IntPtr>(nameof(TimeWindowHandler)); set => WriteHere(nameof(TimeWindowHandler), value); }

        [Offset(336UL)]
        public IntPtr BoostPolicyHandler { get => ReadHere<IntPtr>(nameof(BoostPolicyHandler)); set => WriteHere(nameof(BoostPolicyHandler), value); }

        [Offset(344UL)]
        public IntPtr BoostModeHandler { get => ReadHere<IntPtr>(nameof(BoostModeHandler)); set => WriteHere(nameof(BoostModeHandler), value); }

        [Offset(352UL)]
        public IntPtr AutonomousActivityWindowHandler { get => ReadHere<IntPtr>(nameof(AutonomousActivityWindowHandler)); set => WriteHere(nameof(AutonomousActivityWindowHandler), value); }

        [Offset(360UL)]
        public IntPtr AutonomousModeHandler { get => ReadHere<IntPtr>(nameof(AutonomousModeHandler)); set => WriteHere(nameof(AutonomousModeHandler), value); }

        [Offset(368UL)]
        public IntPtr ReinitializeHandler { get => ReadHere<IntPtr>(nameof(ReinitializeHandler)); set => WriteHere(nameof(ReinitializeHandler), value); }

        [Offset(376UL)]
        public IntPtr PerfSelectionHandler { get => ReadHere<IntPtr>(nameof(PerfSelectionHandler)); set => WriteHere(nameof(PerfSelectionHandler), value); }

        [Offset(384UL)]
        public IntPtr PerfPriorityHandler { get => ReadHere<IntPtr>(nameof(PerfPriorityHandler)); set => WriteHere(nameof(PerfPriorityHandler), value); }

        [Offset(392UL)]
        public IntPtr PerfControlHandler { get => ReadHere<IntPtr>(nameof(PerfControlHandler)); set => WriteHere(nameof(PerfControlHandler), value); }

        [Offset(400UL)]
        public IntPtr PerfControlHandlerHidden { get => ReadHere<IntPtr>(nameof(PerfControlHandlerHidden)); set => WriteHere(nameof(PerfControlHandlerHidden), value); }

        [Offset(408UL)]
        public IntPtr DomainPerfControlHandler { get => ReadHere<IntPtr>(nameof(DomainPerfControlHandler)); set => WriteHere(nameof(DomainPerfControlHandler), value); }

        [Offset(416UL)]
        public IntPtr PerfUpdateHwDebugData { get => ReadHere<IntPtr>(nameof(PerfUpdateHwDebugData)); set => WriteHere(nameof(PerfUpdateHwDebugData), value); }

        [Offset(424UL)]
        public IntPtr PerfQueryProcMeasurementCapabilities { get => ReadHere<IntPtr>(nameof(PerfQueryProcMeasurementCapabilities)); set => WriteHere(nameof(PerfQueryProcMeasurementCapabilities), value); }

        [Offset(432UL)]
        public IntPtr PerfQueryProcMeasurementValues { get => ReadHere<IntPtr>(nameof(PerfQueryProcMeasurementValues)); set => WriteHere(nameof(PerfQueryProcMeasurementValues), value); }

        [Offset(440UL)]
        public uint Id { get => ReadHere<uint>(nameof(Id)); set => WriteHere(nameof(Id), value); }

        [Offset(444UL)]
        public uint MaxFrequency { get => ReadHere<uint>(nameof(MaxFrequency)); set => WriteHere(nameof(MaxFrequency), value); }

        [Offset(448UL)]
        public uint NominalFrequency { get => ReadHere<uint>(nameof(NominalFrequency)); set => WriteHere(nameof(NominalFrequency), value); }

        [Offset(452UL)]
        public uint MaxPercent { get => ReadHere<uint>(nameof(MaxPercent)); set => WriteHere(nameof(MaxPercent), value); }

        [Offset(456UL)]
        public uint MinPerfPercent { get => ReadHere<uint>(nameof(MinPerfPercent)); set => WriteHere(nameof(MinPerfPercent), value); }

        [Offset(460UL)]
        public uint MinThrottlePercent { get => ReadHere<uint>(nameof(MinThrottlePercent)); set => WriteHere(nameof(MinThrottlePercent), value); }

        [Offset(464UL)]
        public uint AdvertizedMaximumFrequency { get => ReadHere<uint>(nameof(AdvertizedMaximumFrequency)); set => WriteHere(nameof(AdvertizedMaximumFrequency), value); }

        [Offset(472UL)]
        public ulong MinimumRelativePerformance { get => ReadHere<ulong>(nameof(MinimumRelativePerformance)); set => WriteHere(nameof(MinimumRelativePerformance), value); }

        [Offset(480UL)]
        public ulong NominalRelativePerformance { get => ReadHere<ulong>(nameof(NominalRelativePerformance)); set => WriteHere(nameof(NominalRelativePerformance), value); }

        [Offset(488UL)]
        public byte NominalRelativePerformancePercent { get => ReadHere<byte>(nameof(NominalRelativePerformancePercent)); set => WriteHere(nameof(NominalRelativePerformancePercent), value); }

        [Offset(489UL)]
        public byte Coordination { get => ReadHere<byte>(nameof(Coordination)); set => WriteHere(nameof(Coordination), value); }

        [Offset(490UL)]
        public byte HardPlatformCap { get => ReadHere<byte>(nameof(HardPlatformCap)); set => WriteHere(nameof(HardPlatformCap), value); }

        [Offset(491UL)]
        public byte AffinitizeControl { get => ReadHere<byte>(nameof(AffinitizeControl)); set => WriteHere(nameof(AffinitizeControl), value); }

        [Offset(492UL)]
        public byte EfficientThrottle { get => ReadHere<byte>(nameof(EfficientThrottle)); set => WriteHere(nameof(EfficientThrottle), value); }

        [Offset(493UL)]
        public byte AllowSchedulerDirectedPerfStates { get => ReadHere<byte>(nameof(AllowSchedulerDirectedPerfStates)); set => WriteHere(nameof(AllowSchedulerDirectedPerfStates), value); }

        [Offset(494UL)]
        public byte InitiateAllProcessors { get => ReadHere<byte>(nameof(InitiateAllProcessors)); set => WriteHere(nameof(InitiateAllProcessors), value); }

        [Offset(495UL)]
        public byte AllowVmPerfSelection { get => ReadHere<byte>(nameof(AllowVmPerfSelection)); set => WriteHere(nameof(AllowVmPerfSelection), value); }

        [Offset(496UL)]
        public byte TurboRangeKnown { get => ReadHere<byte>(nameof(TurboRangeKnown)); set => WriteHere(nameof(TurboRangeKnown), value); }

        [Offset(500UL)]
        public uint VmFrequencyStepMhz { get => ReadHere<uint>(nameof(VmFrequencyStepMhz)); set => WriteHere(nameof(VmFrequencyStepMhz), value); }

        [Offset(504UL)]
        public uint VmHighestFrequencyMhz { get => ReadHere<uint>(nameof(VmHighestFrequencyMhz)); set => WriteHere(nameof(VmHighestFrequencyMhz), value); }

        [Offset(508UL)]
        public uint VmNominalFrequencyMhz { get => ReadHere<uint>(nameof(VmNominalFrequencyMhz)); set => WriteHere(nameof(VmNominalFrequencyMhz), value); }

        [Offset(512UL)]
        public uint VmLowestFrequencyMhz { get => ReadHere<uint>(nameof(VmLowestFrequencyMhz)); set => WriteHere(nameof(VmLowestFrequencyMhz), value); }

        [Offset(516UL)]
        public uint VmThrottlePriorityCount { get => ReadHere<uint>(nameof(VmThrottlePriorityCount)); set => WriteHere(nameof(VmThrottlePriorityCount), value); }

        [Offset(520UL)]
        public byte AutonomousMode { get => ReadHere<byte>(nameof(AutonomousMode)); set => WriteHere(nameof(AutonomousMode), value); }

        [Offset(521UL)]
        public byte AutonomousCapability { get => ReadHere<byte>(nameof(AutonomousCapability)); set => WriteHere(nameof(AutonomousCapability), value); }

        [Offset(522UL)]
        public byte ProvideGuidance { get => ReadHere<byte>(nameof(ProvideGuidance)); set => WriteHere(nameof(ProvideGuidance), value); }

        [Offset(523UL)]
        public byte EppSupported { get => ReadHere<byte>(nameof(EppSupported)); set => WriteHere(nameof(EppSupported), value); }

        [Offset(524UL)]
        public uint DesiredPercent { get => ReadHere<uint>(nameof(DesiredPercent)); set => WriteHere(nameof(DesiredPercent), value); }

        [Offset(528UL)]
        public uint GuaranteedPercent { get => ReadHere<uint>(nameof(GuaranteedPercent)); set => WriteHere(nameof(GuaranteedPercent), value); }

        [Offset(532UL)]
        public byte EngageResponsivenessOverrides { get => ReadHere<byte>(nameof(EngageResponsivenessOverrides)); set => WriteHere(nameof(EngageResponsivenessOverrides), value); }

        [Offset(536UL)]
        [Length(7)]
        public DynamicArray QosPolicies { get => ReadStructure<DynamicArray>(nameof(QosPolicies)); set => WriteStructure(nameof(QosPolicies), value); }

        [Offset(760UL)]
        [Length(7)]
        public DynamicArray QosDisableReasons { get => ReadStructure<DynamicArray>(nameof(QosDisableReasons)); set => WriteStructure(nameof(QosDisableReasons), value); }

        [Offset(788UL)]
        [Length(7)]
        public DynamicArray QosEquivalencyMasks { get => ReadStructure<DynamicArray>(nameof(QosEquivalencyMasks)); set => WriteStructure(nameof(QosEquivalencyMasks), value); }

        [Offset(802UL)]
        public byte QosSupported { get => ReadHere<byte>(nameof(QosSupported)); set => WriteHere(nameof(QosSupported), value); }

        [Offset(804UL)]
        public uint SelectionGeneration { get => ReadHere<uint>(nameof(SelectionGeneration)); set => WriteHere(nameof(SelectionGeneration), value); }

        [Offset(808UL)]
        [Length(7)]
        public DynamicArray QosSelection { get => ReadStructure<DynamicArray>(nameof(QosSelection)); set => WriteStructure(nameof(QosSelection), value); }

        [Offset(1200UL)]
        public ulong PerfChangeTime { get => ReadHere<ulong>(nameof(PerfChangeTime)); set => WriteHere(nameof(PerfChangeTime), value); }

        [Offset(1208UL)]
        public uint PerfChangeIntervalCount { get => ReadHere<uint>(nameof(PerfChangeIntervalCount)); set => WriteHere(nameof(PerfChangeIntervalCount), value); }

        [Offset(1212UL)]
        public byte Force { get => ReadHere<byte>(nameof(Force)); set => WriteHere(nameof(Force), value); }

        [Offset(1213UL)]
        public byte Update { get => ReadHere<byte>(nameof(Update)); set => WriteHere(nameof(Update), value); }

        [Offset(1214UL)]
        public byte Apply { get => ReadHere<byte>(nameof(Apply)); set => WriteHere(nameof(Apply), value); }

        public ProcPerfDomain(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcPerfDomain>();
        }
    }
}