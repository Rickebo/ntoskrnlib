using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KFORCE_PARK_DUTY_CYCLE_DATA")]
    public sealed class KforceParkDutyCycleData : DynamicStructure
    {
        [Offset(0UL)]
        public Kdpc DutyCycleDpc { get => ReadStructure<Kdpc>(nameof(DutyCycleDpc)); set => WriteStructure(nameof(DutyCycleDpc), value); }

        [Offset(64UL)]
        public KTIMER2 StartSingleDutyCycleTimer { get => ReadStructure<KTIMER2>(nameof(StartSingleDutyCycleTimer)); set => WriteStructure(nameof(StartSingleDutyCycleTimer), value); }

        [Offset(200UL)]
        public KTIMER2 StopSingleDutyCycleTimer { get => ReadStructure<KTIMER2>(nameof(StopSingleDutyCycleTimer)); set => WriteStructure(nameof(StopSingleDutyCycleTimer), value); }

        [Offset(336UL)]
        public uint CurrentState { get => ReadHere<uint>(nameof(CurrentState)); set => WriteHere(nameof(CurrentState), value); }

        [Offset(340UL)]
        public uint DpcTransition { get => ReadHere<uint>(nameof(DpcTransition)); set => WriteHere(nameof(DpcTransition), value); }

        public KforceParkDutyCycleData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KforceParkDutyCycleData>();
        }
    }
}