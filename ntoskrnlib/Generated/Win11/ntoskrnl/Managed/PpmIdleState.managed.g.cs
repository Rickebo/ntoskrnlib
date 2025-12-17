using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PPM_IDLE_STATE")]
    public sealed class PpmIdleState : DynamicStructure
    {
        [Offset(0UL)]
        public KaffinityEx DomainMembers { get => ReadStructure<KaffinityEx>(nameof(DomainMembers)); set => WriteStructure(nameof(DomainMembers), value); }

        [Offset(264UL)]
        public UnicodeString Name { get => ReadStructure<UnicodeString>(nameof(Name)); set => WriteStructure(nameof(Name), value); }

        [Offset(280UL)]
        public uint Latency { get => ReadHere<uint>(nameof(Latency)); set => WriteHere(nameof(Latency), value); }

        [Offset(284UL)]
        public uint BreakEvenDuration { get => ReadHere<uint>(nameof(BreakEvenDuration)); set => WriteHere(nameof(BreakEvenDuration), value); }

        [Offset(288UL)]
        public uint Power { get => ReadHere<uint>(nameof(Power)); set => WriteHere(nameof(Power), value); }

        [Offset(292UL)]
        public uint StateFlags { get => ReadHere<uint>(nameof(StateFlags)); set => WriteHere(nameof(StateFlags), value); }

        [Offset(296UL)]
        public PpmVetoAccounting VetoAccounting { get => ReadStructure<PpmVetoAccounting>(nameof(VetoAccounting)); set => WriteStructure(nameof(VetoAccounting), value); }

        [Offset(336UL)]
        public byte StateType { get => ReadHere<byte>(nameof(StateType)); set => WriteHere(nameof(StateType), value); }

        [Offset(337UL)]
        public byte InterruptsEnabled { get => ReadHere<byte>(nameof(InterruptsEnabled)); set => WriteHere(nameof(InterruptsEnabled), value); }

        [Offset(338UL)]
        public byte Interruptible { get => ReadHere<byte>(nameof(Interruptible)); set => WriteHere(nameof(Interruptible), value); }

        [Offset(339UL)]
        public byte ContextRetained { get => ReadHere<byte>(nameof(ContextRetained)); set => WriteHere(nameof(ContextRetained), value); }

        [Offset(340UL)]
        public byte CacheCoherent { get => ReadHere<byte>(nameof(CacheCoherent)); set => WriteHere(nameof(CacheCoherent), value); }

        [Offset(341UL)]
        public byte WakesSpuriously { get => ReadHere<byte>(nameof(WakesSpuriously)); set => WriteHere(nameof(WakesSpuriously), value); }

        [Offset(342UL)]
        public byte PlatformOnly { get => ReadHere<byte>(nameof(PlatformOnly)); set => WriteHere(nameof(PlatformOnly), value); }

        [Offset(343UL)]
        public byte NoCState { get => ReadHere<byte>(nameof(NoCState)); set => WriteHere(nameof(NoCState), value); }

        public PpmIdleState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmIdleState>();
        }
    }
}