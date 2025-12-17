using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROCESSOR_POWER_STATE")]
    public sealed class ProcessorPowerState : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr IdleStates { get => ReadHere<IntPtr>(nameof(IdleStates)); set => WriteHere(nameof(IdleStates), value); }

        [Offset(8UL)]
        public IntPtr IdleAccounting { get => ReadHere<IntPtr>(nameof(IdleAccounting)); set => WriteHere(nameof(IdleAccounting), value); }

        [Offset(16UL)]
        public ulong IdleTimeLast { get => ReadHere<ulong>(nameof(IdleTimeLast)); set => WriteHere(nameof(IdleTimeLast), value); }

        [Offset(24UL)]
        public ulong IdleTimeTotal { get => ReadHere<ulong>(nameof(IdleTimeTotal)); set => WriteHere(nameof(IdleTimeTotal), value); }

        [Offset(32UL)]
        public ulong IdleSequenceNumber { get => ReadHere<ulong>(nameof(IdleSequenceNumber)); set => WriteHere(nameof(IdleSequenceNumber), value); }

        [Offset(40UL)]
        public ulong IdleTimeEntry { get => ReadHere<ulong>(nameof(IdleTimeEntry)); set => WriteHere(nameof(IdleTimeEntry), value); }

        [Offset(48UL)]
        public ulong IdleTimeExpiration { get => ReadHere<ulong>(nameof(IdleTimeExpiration)); set => WriteHere(nameof(IdleTimeExpiration), value); }

        [Offset(48UL)]
        public long IdleWakeTime { get => ReadHere<long>(nameof(IdleWakeTime)); set => WriteHere(nameof(IdleWakeTime), value); }

        [Offset(56UL)]
        public uint IdleWakeLatencyLimit { get => ReadHere<uint>(nameof(IdleWakeLatencyLimit)); set => WriteHere(nameof(IdleWakeLatencyLimit), value); }

        [Offset(60UL)]
        public byte NonInterruptibleTransition { get => ReadHere<byte>(nameof(NonInterruptibleTransition)); set => WriteHere(nameof(NonInterruptibleTransition), value); }

        [Offset(61UL)]
        public byte PepWokenTransition { get => ReadHere<byte>(nameof(PepWokenTransition)); set => WriteHere(nameof(PepWokenTransition), value); }

        [Offset(62UL)]
        public byte HvTargetState { get => ReadHere<byte>(nameof(HvTargetState)); set => WriteHere(nameof(HvTargetState), value); }

        [Offset(64UL)]
        public uint TargetIdleState { get => ReadHere<uint>(nameof(TargetIdleState)); set => WriteHere(nameof(TargetIdleState), value); }

        [Offset(68UL)]
        public ProcIdlePolicy IdlePolicy { get => ReadStructure<ProcIdlePolicy>(nameof(IdlePolicy)); set => WriteStructure(nameof(IdlePolicy), value); }

        [Offset(76UL)]
        public PpmIdleSynchronizationState Synchronization { get => ReadStructure<PpmIdleSynchronizationState>(nameof(Synchronization)); set => WriteStructure(nameof(Synchronization), value); }

        [Offset(80UL)]
        public ProcFeedback PerfFeedback { get => ReadStructure<ProcFeedback>(nameof(PerfFeedback)); set => WriteStructure(nameof(PerfFeedback), value); }

        [Offset(224UL)]
        public uint Hypervisor { get => ReadHere<uint>(nameof(Hypervisor)); set => WriteHere(nameof(Hypervisor), value); }

        [Offset(228UL)]
        public uint LastSysTime { get => ReadHere<uint>(nameof(LastSysTime)); set => WriteHere(nameof(LastSysTime), value); }

        [Offset(232UL)]
        public ulong WmiDispatchPtr { get => ReadHere<ulong>(nameof(WmiDispatchPtr)); set => WriteHere(nameof(WmiDispatchPtr), value); }

        [Offset(240UL)]
        public int WmiInterfaceEnabled { get => ReadHere<int>(nameof(WmiInterfaceEnabled)); set => WriteHere(nameof(WmiInterfaceEnabled), value); }

        [Offset(248UL)]
        public PpmFfhThrottleStateInfo FFHThrottleStateInfo { get => ReadStructure<PpmFfhThrottleStateInfo>(nameof(FFHThrottleStateInfo)); set => WriteStructure(nameof(FFHThrottleStateInfo), value); }

        [Offset(280UL)]
        public Kdpc PerfActionDpc { get => ReadStructure<Kdpc>(nameof(PerfActionDpc)); set => WriteStructure(nameof(PerfActionDpc), value); }

        [Offset(344UL)]
        public int PerfActionMask { get => ReadHere<int>(nameof(PerfActionMask)); set => WriteHere(nameof(PerfActionMask), value); }

        [Offset(352UL)]
        public ProcIdleSnap HvIdleCheck { get => ReadStructure<ProcIdleSnap>(nameof(HvIdleCheck)); set => WriteStructure(nameof(HvIdleCheck), value); }

        [Offset(368UL)]
        public ProcPerfCheckContext CheckContext { get => ReadStructure<ProcPerfCheckContext>(nameof(CheckContext)); set => WriteStructure(nameof(CheckContext), value); }

        [Offset(440UL)]
        public IntPtr Concurrency { get => ReadHere<IntPtr>(nameof(Concurrency)); set => WriteHere(nameof(Concurrency), value); }

        [Offset(448UL)]
        public IntPtr ClassConcurrency { get => ReadHere<IntPtr>(nameof(ClassConcurrency)); set => WriteHere(nameof(ClassConcurrency), value); }

        [Offset(456UL)]
        public byte ArchitecturalEfficiencyClass { get => ReadHere<byte>(nameof(ArchitecturalEfficiencyClass)); set => WriteHere(nameof(ArchitecturalEfficiencyClass), value); }

        [Offset(457UL)]
        public byte PerformanceSchedulingClass { get => ReadHere<byte>(nameof(PerformanceSchedulingClass)); set => WriteHere(nameof(PerformanceSchedulingClass), value); }

        [Offset(458UL)]
        public byte EfficiencySchedulingClass { get => ReadHere<byte>(nameof(EfficiencySchedulingClass)); set => WriteHere(nameof(EfficiencySchedulingClass), value); }

        [Offset(459UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(460UL)]
        public byte Parked { get => ReadHere<byte>(nameof(Parked)); set => WriteHere(nameof(Parked), value); }

        [Offset(461UL)]
        public byte SoftParked { get => ReadHere<byte>(nameof(SoftParked)); set => WriteHere(nameof(SoftParked), value); }

        [Offset(462UL)]
        public byte LongPriorQosPeriod { get => ReadHere<byte>(nameof(LongPriorQosPeriod)); set => WriteHere(nameof(LongPriorQosPeriod), value); }

        [Offset(464UL)]
        public ulong SnapTimeLast { get => ReadHere<ulong>(nameof(SnapTimeLast)); set => WriteHere(nameof(SnapTimeLast), value); }

        [Offset(464UL)]
        public ulong EnergyConsumed { get => ReadHere<ulong>(nameof(EnergyConsumed)); set => WriteHere(nameof(EnergyConsumed), value); }

        [Offset(472UL)]
        public ulong ActiveTime { get => ReadHere<ulong>(nameof(ActiveTime)); set => WriteHere(nameof(ActiveTime), value); }

        [Offset(480UL)]
        public ulong TotalTime { get => ReadHere<ulong>(nameof(TotalTime)); set => WriteHere(nameof(TotalTime), value); }

        [Offset(488UL)]
        public IntPtr FxDevice { get => ReadHere<IntPtr>(nameof(FxDevice)); set => WriteHere(nameof(FxDevice), value); }

        [Offset(496UL)]
        public ulong LastQosTransitionTime { get => ReadHere<ulong>(nameof(LastQosTransitionTime)); set => WriteHere(nameof(LastQosTransitionTime), value); }

        [Offset(504UL)]
        public ulong QosTransitionHysteresis { get => ReadHere<ulong>(nameof(QosTransitionHysteresis)); set => WriteHere(nameof(QosTransitionHysteresis), value); }

        [Offset(512UL)]
        public uint RequestedQosClass { get => ReadHere<uint>(nameof(RequestedQosClass)); set => WriteHere(nameof(RequestedQosClass), value); }

        [Offset(516UL)]
        public uint ResolvedQosClass { get => ReadHere<uint>(nameof(ResolvedQosClass)); set => WriteHere(nameof(ResolvedQosClass), value); }

        [Offset(520UL)]
        public ushort QosEquivalencyMask { get => ReadHere<ushort>(nameof(QosEquivalencyMask)); set => WriteHere(nameof(QosEquivalencyMask), value); }

        [Offset(522UL)]
        public ushort HwFeedbackTableOffset { get => ReadHere<ushort>(nameof(HwFeedbackTableOffset)); set => WriteHere(nameof(HwFeedbackTableOffset), value); }

        [Offset(524UL)]
        public byte HwFeedbackParkHint { get => ReadHere<byte>(nameof(HwFeedbackParkHint)); set => WriteHere(nameof(HwFeedbackParkHint), value); }

        [Offset(525UL)]
        public byte HeteroCoreType { get => ReadHere<byte>(nameof(HeteroCoreType)); set => WriteHere(nameof(HeteroCoreType), value); }

        [Offset(526UL)]
        public ushort HwFeedbackTableIndex { get => ReadHere<ushort>(nameof(HwFeedbackTableIndex)); set => WriteHere(nameof(HwFeedbackTableIndex), value); }

        [Offset(528UL)]
        public IntPtr HwFeedbackClassList { get => ReadHere<IntPtr>(nameof(HwFeedbackClassList)); set => WriteHere(nameof(HwFeedbackClassList), value); }

        [Offset(536UL)]
        public IntPtr EeCyclesWorkloadClassList { get => ReadHere<IntPtr>(nameof(EeCyclesWorkloadClassList)); set => WriteHere(nameof(EeCyclesWorkloadClassList), value); }

        [Offset(544UL)]
        public IntPtr PerfCyclesWorkloadClassList { get => ReadHere<IntPtr>(nameof(PerfCyclesWorkloadClassList)); set => WriteHere(nameof(PerfCyclesWorkloadClassList), value); }

        [Offset(552UL)]
        public byte ContainmentGroupType { get => ReadHere<byte>(nameof(ContainmentGroupType)); set => WriteHere(nameof(ContainmentGroupType), value); }

        [Offset(554UL)]
        [Length(4)]
        public DynamicArray FrequencyBucketThresholds { get => ReadStructure<DynamicArray>(nameof(FrequencyBucketThresholds)); set => WriteStructure(nameof(FrequencyBucketThresholds), value); }

        public ProcessorPowerState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessorPowerState>();
        }
    }
}