using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROCESSOR_IDLE_CONSTRAINTS")]
    public sealed class ProcessorIdleConstraints : DynamicStructure
    {
        [Offset(0UL)]
        public ulong TotalTime { get => ReadHere<ulong>(nameof(TotalTime)); set => WriteHere(nameof(TotalTime), value); }

        [Offset(8UL)]
        public ulong IdleTime { get => ReadHere<ulong>(nameof(IdleTime)); set => WriteHere(nameof(IdleTime), value); }

        [Offset(16UL)]
        public ulong ExpectedIdleDuration { get => ReadHere<ulong>(nameof(ExpectedIdleDuration)); set => WriteHere(nameof(ExpectedIdleDuration), value); }

        [Offset(24UL)]
        public ulong MaxIdleDuration { get => ReadHere<ulong>(nameof(MaxIdleDuration)); set => WriteHere(nameof(MaxIdleDuration), value); }

        [Offset(32UL)]
        public uint OverrideState { get => ReadHere<uint>(nameof(OverrideState)); set => WriteHere(nameof(OverrideState), value); }

        [Offset(36UL)]
        public uint TimeCheck { get => ReadHere<uint>(nameof(TimeCheck)); set => WriteHere(nameof(TimeCheck), value); }

        [Offset(40UL)]
        public byte PromotePercent { get => ReadHere<byte>(nameof(PromotePercent)); set => WriteHere(nameof(PromotePercent), value); }

        [Offset(41UL)]
        public byte DemotePercent { get => ReadHere<byte>(nameof(DemotePercent)); set => WriteHere(nameof(DemotePercent), value); }

        [Offset(42UL)]
        public byte Parked { get => ReadHere<byte>(nameof(Parked)); set => WriteHere(nameof(Parked), value); }

        [Offset(43UL)]
        public byte Interruptible { get => ReadHere<byte>(nameof(Interruptible)); set => WriteHere(nameof(Interruptible), value); }

        [Offset(44UL)]
        public byte PlatformIdle { get => ReadHere<byte>(nameof(PlatformIdle)); set => WriteHere(nameof(PlatformIdle), value); }

        [Offset(45UL)]
        public byte ExpectedWakeReason { get => ReadHere<byte>(nameof(ExpectedWakeReason)); set => WriteHere(nameof(ExpectedWakeReason), value); }

        [Offset(46UL)]
        public byte IdleStateMax { get => ReadHere<byte>(nameof(IdleStateMax)); set => WriteHere(nameof(IdleStateMax), value); }

        public ProcessorIdleConstraints(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessorIdleConstraints>();
        }
    }
}