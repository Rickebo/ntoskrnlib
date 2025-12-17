using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_DISPATCHER_HEADER")]
    public sealed class DispatcherHeader : DynamicStructure
    {
        [Offset(0UL)]
        public int Lock { get => ReadHere<int>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(0UL)]
        public int LockNV { get => ReadHere<int>(nameof(LockNV)); set => WriteHere(nameof(LockNV), value); }

        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Signalling { get => ReadHere<byte>(nameof(Signalling)); set => WriteHere(nameof(Signalling), value); }

        [Offset(2UL)]
        public byte Size { get => ReadHere<byte>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(3UL)]
        public byte Reserved1 { get => ReadHere<byte>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(0UL)]
        public byte TimerType { get => ReadHere<byte>(nameof(TimerType)); set => WriteHere(nameof(TimerType), value); }

        [Offset(1UL)]
        public byte TimerControlFlags { get => ReadHere<byte>(nameof(TimerControlFlags)); set => WriteHere(nameof(TimerControlFlags), value); }

        [Offset(1UL)]
        public byte Absolute { get => ReadHere<byte>(nameof(Absolute)); set => WriteHere(nameof(Absolute), value); }

        [Offset(1UL)]
        public byte Wake { get => ReadHere<byte>(nameof(Wake)); set => WriteHere(nameof(Wake), value); }

        [Offset(1UL)]
        public byte EncodedTolerableDelay { get => ReadHere<byte>(nameof(EncodedTolerableDelay)); set => WriteHere(nameof(EncodedTolerableDelay), value); }

        [Offset(2UL)]
        public byte Hand { get => ReadHere<byte>(nameof(Hand)); set => WriteHere(nameof(Hand), value); }

        [Offset(3UL)]
        public byte TimerMiscFlags { get => ReadHere<byte>(nameof(TimerMiscFlags)); set => WriteHere(nameof(TimerMiscFlags), value); }

        [Offset(3UL)]
        public byte Index { get => ReadHere<byte>(nameof(Index)); set => WriteHere(nameof(Index), value); }

        [Offset(3UL)]
        public byte Inserted { get => ReadHere<byte>(nameof(Inserted)); set => WriteHere(nameof(Inserted), value); }

        [Offset(3UL)]
        public byte Expired { get => ReadHere<byte>(nameof(Expired)); set => WriteHere(nameof(Expired), value); }

        [Offset(0UL)]
        public byte Timer2Type { get => ReadHere<byte>(nameof(Timer2Type)); set => WriteHere(nameof(Timer2Type), value); }

        [Offset(1UL)]
        public byte Timer2Flags { get => ReadHere<byte>(nameof(Timer2Flags)); set => WriteHere(nameof(Timer2Flags), value); }

        [Offset(1UL)]
        public byte Timer2Inserted { get => ReadHere<byte>(nameof(Timer2Inserted)); set => WriteHere(nameof(Timer2Inserted), value); }

        [Offset(1UL)]
        public byte Timer2Expiring { get => ReadHere<byte>(nameof(Timer2Expiring)); set => WriteHere(nameof(Timer2Expiring), value); }

        [Offset(1UL)]
        public byte Timer2CancelPending { get => ReadHere<byte>(nameof(Timer2CancelPending)); set => WriteHere(nameof(Timer2CancelPending), value); }

        [Offset(1UL)]
        public byte Timer2SetPending { get => ReadHere<byte>(nameof(Timer2SetPending)); set => WriteHere(nameof(Timer2SetPending), value); }

        [Offset(1UL)]
        public byte Timer2Running { get => ReadHere<byte>(nameof(Timer2Running)); set => WriteHere(nameof(Timer2Running), value); }

        [Offset(1UL)]
        public byte Timer2Disabled { get => ReadHere<byte>(nameof(Timer2Disabled)); set => WriteHere(nameof(Timer2Disabled), value); }

        [Offset(1UL)]
        public byte Timer2ReservedFlags { get => ReadHere<byte>(nameof(Timer2ReservedFlags)); set => WriteHere(nameof(Timer2ReservedFlags), value); }

        [Offset(2UL)]
        public byte Timer2ComponentId { get => ReadHere<byte>(nameof(Timer2ComponentId)); set => WriteHere(nameof(Timer2ComponentId), value); }

        [Offset(3UL)]
        public byte Timer2RelativeId { get => ReadHere<byte>(nameof(Timer2RelativeId)); set => WriteHere(nameof(Timer2RelativeId), value); }

        [Offset(0UL)]
        public byte QueueType { get => ReadHere<byte>(nameof(QueueType)); set => WriteHere(nameof(QueueType), value); }

        [Offset(1UL)]
        public byte QueueControlFlags { get => ReadHere<byte>(nameof(QueueControlFlags)); set => WriteHere(nameof(QueueControlFlags), value); }

        [Offset(1UL)]
        public byte Abandoned { get => ReadHere<byte>(nameof(Abandoned)); set => WriteHere(nameof(Abandoned), value); }

        [Offset(1UL)]
        public byte DisableIncrement { get => ReadHere<byte>(nameof(DisableIncrement)); set => WriteHere(nameof(DisableIncrement), value); }

        [Offset(1UL)]
        public byte QueueReservedControlFlags { get => ReadHere<byte>(nameof(QueueReservedControlFlags)); set => WriteHere(nameof(QueueReservedControlFlags), value); }

        [Offset(2UL)]
        public byte QueueSize { get => ReadHere<byte>(nameof(QueueSize)); set => WriteHere(nameof(QueueSize), value); }

        [Offset(3UL)]
        public byte QueueReserved { get => ReadHere<byte>(nameof(QueueReserved)); set => WriteHere(nameof(QueueReserved), value); }

        [Offset(0UL)]
        public byte ThreadType { get => ReadHere<byte>(nameof(ThreadType)); set => WriteHere(nameof(ThreadType), value); }

        [Offset(1UL)]
        public byte ThreadReserved { get => ReadHere<byte>(nameof(ThreadReserved)); set => WriteHere(nameof(ThreadReserved), value); }

        [Offset(2UL)]
        public byte ThreadControlFlags { get => ReadHere<byte>(nameof(ThreadControlFlags)); set => WriteHere(nameof(ThreadControlFlags), value); }

        [Offset(2UL)]
        public byte CycleProfiling { get => ReadHere<byte>(nameof(CycleProfiling)); set => WriteHere(nameof(CycleProfiling), value); }

        [Offset(2UL)]
        public byte CounterProfiling { get => ReadHere<byte>(nameof(CounterProfiling)); set => WriteHere(nameof(CounterProfiling), value); }

        [Offset(2UL)]
        public byte GroupScheduling { get => ReadHere<byte>(nameof(GroupScheduling)); set => WriteHere(nameof(GroupScheduling), value); }

        [Offset(2UL)]
        public byte AffinitySet { get => ReadHere<byte>(nameof(AffinitySet)); set => WriteHere(nameof(AffinitySet), value); }

        [Offset(2UL)]
        public byte Tagged { get => ReadHere<byte>(nameof(Tagged)); set => WriteHere(nameof(Tagged), value); }

        [Offset(2UL)]
        public byte EnergyProfiling { get => ReadHere<byte>(nameof(EnergyProfiling)); set => WriteHere(nameof(EnergyProfiling), value); }

        [Offset(2UL)]
        public byte SchedulerAssist { get => ReadHere<byte>(nameof(SchedulerAssist)); set => WriteHere(nameof(SchedulerAssist), value); }

        [Offset(2UL)]
        public byte ThreadReservedControlFlags { get => ReadHere<byte>(nameof(ThreadReservedControlFlags)); set => WriteHere(nameof(ThreadReservedControlFlags), value); }

        [Offset(3UL)]
        public byte DebugActive { get => ReadHere<byte>(nameof(DebugActive)); set => WriteHere(nameof(DebugActive), value); }

        [Offset(3UL)]
        public byte ActiveDR7 { get => ReadHere<byte>(nameof(ActiveDR7)); set => WriteHere(nameof(ActiveDR7), value); }

        [Offset(3UL)]
        public byte Instrumented { get => ReadHere<byte>(nameof(Instrumented)); set => WriteHere(nameof(Instrumented), value); }

        [Offset(3UL)]
        public byte Minimal { get => ReadHere<byte>(nameof(Minimal)); set => WriteHere(nameof(Minimal), value); }

        [Offset(3UL)]
        public byte Reserved4 { get => ReadHere<byte>(nameof(Reserved4)); set => WriteHere(nameof(Reserved4), value); }

        [Offset(3UL)]
        public byte AltSyscall { get => ReadHere<byte>(nameof(AltSyscall)); set => WriteHere(nameof(AltSyscall), value); }

        [Offset(3UL)]
        public byte Emulation { get => ReadHere<byte>(nameof(Emulation)); set => WriteHere(nameof(Emulation), value); }

        [Offset(3UL)]
        public byte Reserved5 { get => ReadHere<byte>(nameof(Reserved5)); set => WriteHere(nameof(Reserved5), value); }

        [Offset(0UL)]
        public byte MutantType { get => ReadHere<byte>(nameof(MutantType)); set => WriteHere(nameof(MutantType), value); }

        [Offset(1UL)]
        public byte MutantSize { get => ReadHere<byte>(nameof(MutantSize)); set => WriteHere(nameof(MutantSize), value); }

        [Offset(2UL)]
        public byte DpcActive { get => ReadHere<byte>(nameof(DpcActive)); set => WriteHere(nameof(DpcActive), value); }

        [Offset(3UL)]
        public byte MutantReserved { get => ReadHere<byte>(nameof(MutantReserved)); set => WriteHere(nameof(MutantReserved), value); }

        [Offset(4UL)]
        public int SignalState { get => ReadHere<int>(nameof(SignalState)); set => WriteHere(nameof(SignalState), value); }

        [Offset(8UL)]
        public ListEntry WaitListHead { get => ReadStructure<ListEntry>(nameof(WaitListHead)); set => WriteStructure(nameof(WaitListHead), value); }

        public DispatcherHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DispatcherHeader>();
        }
    }
}