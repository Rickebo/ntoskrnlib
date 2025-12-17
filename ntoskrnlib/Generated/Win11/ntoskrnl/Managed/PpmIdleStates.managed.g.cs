using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PPM_IDLE_STATES")]
    public sealed class PpmIdleStates : DynamicStructure
    {
        [Offset(0UL)]
        public byte EnforceStateConstraints { get => ReadHere<byte>(nameof(EnforceStateConstraints)); set => WriteHere(nameof(EnforceStateConstraints), value); }

        [Offset(1UL)]
        public byte IdleOverride { get => ReadHere<byte>(nameof(IdleOverride)); set => WriteHere(nameof(IdleOverride), value); }

        [Offset(2UL)]
        public byte EstimateIdleDuration { get => ReadHere<byte>(nameof(EstimateIdleDuration)); set => WriteHere(nameof(EstimateIdleDuration), value); }

        [Offset(3UL)]
        public byte ExitLatencyTraceEnabled { get => ReadHere<byte>(nameof(ExitLatencyTraceEnabled)); set => WriteHere(nameof(ExitLatencyTraceEnabled), value); }

        [Offset(4UL)]
        public byte NonInterruptibleTransition { get => ReadHere<byte>(nameof(NonInterruptibleTransition)); set => WriteHere(nameof(NonInterruptibleTransition), value); }

        [Offset(5UL)]
        public byte UnaccountedTransition { get => ReadHere<byte>(nameof(UnaccountedTransition)); set => WriteHere(nameof(UnaccountedTransition), value); }

        [Offset(6UL)]
        public byte IdleDurationLimited { get => ReadHere<byte>(nameof(IdleDurationLimited)); set => WriteHere(nameof(IdleDurationLimited), value); }

        [Offset(7UL)]
        public byte IdleCheckLimited { get => ReadHere<byte>(nameof(IdleCheckLimited)); set => WriteHere(nameof(IdleCheckLimited), value); }

        [Offset(8UL)]
        public ulong IdleReevaluationDuration { get => ReadHere<ulong>(nameof(IdleReevaluationDuration)); set => WriteHere(nameof(IdleReevaluationDuration), value); }

        [Offset(16UL)]
        public byte StrictVetoBias { get => ReadHere<byte>(nameof(StrictVetoBias)); set => WriteHere(nameof(StrictVetoBias), value); }

        [Offset(20UL)]
        public uint ExitLatencyCountdown { get => ReadHere<uint>(nameof(ExitLatencyCountdown)); set => WriteHere(nameof(ExitLatencyCountdown), value); }

        [Offset(24UL)]
        public uint TargetState { get => ReadHere<uint>(nameof(TargetState)); set => WriteHere(nameof(TargetState), value); }

        [Offset(28UL)]
        public uint ActualState { get => ReadHere<uint>(nameof(ActualState)); set => WriteHere(nameof(ActualState), value); }

        [Offset(32UL)]
        public uint OldState { get => ReadHere<uint>(nameof(OldState)); set => WriteHere(nameof(OldState), value); }

        [Offset(36UL)]
        public uint OverrideIndex { get => ReadHere<uint>(nameof(OverrideIndex)); set => WriteHere(nameof(OverrideIndex), value); }

        [Offset(40UL)]
        public uint ProcessorIdleCount { get => ReadHere<uint>(nameof(ProcessorIdleCount)); set => WriteHere(nameof(ProcessorIdleCount), value); }

        [Offset(44UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(48UL)]
        public ulong LevelId { get => ReadHere<ulong>(nameof(LevelId)); set => WriteHere(nameof(LevelId), value); }

        [Offset(56UL)]
        public ushort ReasonFlags { get => ReadHere<ushort>(nameof(ReasonFlags)); set => WriteHere(nameof(ReasonFlags), value); }

        [Offset(60UL)]
        public int PreviousStatus { get => ReadHere<int>(nameof(PreviousStatus)); set => WriteHere(nameof(PreviousStatus), value); }

        [Offset(64UL)]
        public byte PreviouslyCancelled { get => ReadHere<byte>(nameof(PreviouslyCancelled)); set => WriteHere(nameof(PreviouslyCancelled), value); }

        [Offset(65UL)]
        public byte PreviouslyDeniedCount { get => ReadHere<byte>(nameof(PreviouslyDeniedCount)); set => WriteHere(nameof(PreviouslyDeniedCount), value); }

        [Offset(72UL)]
        public KaffinityEx PrimaryProcessorMask { get => ReadStructure<KaffinityEx>(nameof(PrimaryProcessorMask)); set => WriteStructure(nameof(PrimaryProcessorMask), value); }

        [Offset(336UL)]
        public KaffinityEx SecondaryProcessorMask { get => ReadStructure<KaffinityEx>(nameof(SecondaryProcessorMask)); set => WriteStructure(nameof(SecondaryProcessorMask), value); }

        [Offset(600UL)]
        public IntPtr IdlePreExecute { get => ReadHere<IntPtr>(nameof(IdlePreExecute)); set => WriteHere(nameof(IdlePreExecute), value); }

        [Offset(608UL)]
        public IntPtr IdleExecute { get => ReadHere<IntPtr>(nameof(IdleExecute)); set => WriteHere(nameof(IdleExecute), value); }

        [Offset(616UL)]
        public IntPtr IdlePreselect { get => ReadHere<IntPtr>(nameof(IdlePreselect)); set => WriteHere(nameof(IdlePreselect), value); }

        [Offset(624UL)]
        public IntPtr IdleTest { get => ReadHere<IntPtr>(nameof(IdleTest)); set => WriteHere(nameof(IdleTest), value); }

        [Offset(632UL)]
        public IntPtr IdleAvailabilityCheck { get => ReadHere<IntPtr>(nameof(IdleAvailabilityCheck)); set => WriteHere(nameof(IdleAvailabilityCheck), value); }

        [Offset(640UL)]
        public IntPtr IdleComplete { get => ReadHere<IntPtr>(nameof(IdleComplete)); set => WriteHere(nameof(IdleComplete), value); }

        [Offset(648UL)]
        public IntPtr IdleIsHalted { get => ReadHere<IntPtr>(nameof(IdleIsHalted)); set => WriteHere(nameof(IdleIsHalted), value); }

        [Offset(656UL)]
        public IntPtr IdleInitiateWake { get => ReadHere<IntPtr>(nameof(IdleInitiateWake)); set => WriteHere(nameof(IdleInitiateWake), value); }

        [Offset(664UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(672UL)]
        public ProcessorIdleConstraints Constraints { get => ReadStructure<ProcessorIdleConstraints>(nameof(Constraints)); set => WriteStructure(nameof(Constraints), value); }

        [Offset(720UL)]
        public KaffinityEx DeepIdleSnapshot { get => ReadStructure<KaffinityEx>(nameof(DeepIdleSnapshot)); set => WriteStructure(nameof(DeepIdleSnapshot), value); }

        [Offset(984UL)]
        public IntPtr Tracing { get => ReadHere<IntPtr>(nameof(Tracing)); set => WriteHere(nameof(Tracing), value); }

        [Offset(992UL)]
        public IntPtr CoordinatedTracing { get => ReadHere<IntPtr>(nameof(CoordinatedTracing)); set => WriteHere(nameof(CoordinatedTracing), value); }

        [Offset(1000UL)]
        public PpmSelectionMenu ProcessorMenu { get => ReadStructure<PpmSelectionMenu>(nameof(ProcessorMenu)); set => WriteStructure(nameof(ProcessorMenu), value); }

        [Offset(1016UL)]
        public PpmSelectionMenu CoordinatedMenu { get => ReadStructure<PpmSelectionMenu>(nameof(CoordinatedMenu)); set => WriteStructure(nameof(CoordinatedMenu), value); }

        [Offset(1032UL)]
        public PpmCoordinatedSelection CoordinatedSelection { get => ReadStructure<PpmCoordinatedSelection>(nameof(CoordinatedSelection)); set => WriteStructure(nameof(CoordinatedSelection), value); }

        [Offset(1056UL)]
        [Length(1)]
        public DynamicArray State { get => ReadStructure<DynamicArray>(nameof(State)); set => WriteStructure(nameof(State), value); }

        public PpmIdleStates(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmIdleStates>();
        }
    }
}