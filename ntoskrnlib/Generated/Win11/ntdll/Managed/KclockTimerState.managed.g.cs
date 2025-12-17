using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KCLOCK_TIMER_STATE")]
    public sealed class KclockTimerState : DynamicStructure
    {
        [Offset(0UL)]
        public ulong NextTickDueTime { get => ReadHere<ulong>(nameof(NextTickDueTime)); set => WriteHere(nameof(NextTickDueTime), value); }

        [Offset(8UL)]
        public uint TimeIncrement { get => ReadHere<uint>(nameof(TimeIncrement)); set => WriteHere(nameof(TimeIncrement), value); }

        [Offset(12UL)]
        public uint LastRequestedTimeIncrement { get => ReadHere<uint>(nameof(LastRequestedTimeIncrement)); set => WriteHere(nameof(LastRequestedTimeIncrement), value); }

        [Offset(16UL)]
        public uint OneShotState { get => ReadHere<uint>(nameof(OneShotState)); set => WriteHere(nameof(OneShotState), value); }

        [Offset(20UL)]
        public uint ExpectedWakeReason { get => ReadHere<uint>(nameof(ExpectedWakeReason)); set => WriteHere(nameof(ExpectedWakeReason), value); }

        [Offset(24UL)]
        [Length(7)]
        public DynamicArray ClockTimerEntries { get => ReadStructure<DynamicArray>(nameof(ClockTimerEntries)); set => WriteStructure(nameof(ClockTimerEntries), value); }

        [Offset(136UL)]
        public byte ClockActive { get => ReadHere<byte>(nameof(ClockActive)); set => WriteHere(nameof(ClockActive), value); }

        [Offset(137UL)]
        public byte ClockArmedForIdle { get => ReadHere<byte>(nameof(ClockArmedForIdle)); set => WriteHere(nameof(ClockArmedForIdle), value); }

        [Offset(140UL)]
        public uint ClockTickTraceIndex { get => ReadHere<uint>(nameof(ClockTickTraceIndex)); set => WriteHere(nameof(ClockTickTraceIndex), value); }

        [Offset(144UL)]
        public uint ClockIncrementTraceIndex { get => ReadHere<uint>(nameof(ClockIncrementTraceIndex)); set => WriteHere(nameof(ClockIncrementTraceIndex), value); }

        [Offset(152UL)]
        [Length(16)]
        public DynamicArray ClockTickTraces { get => ReadStructure<DynamicArray>(nameof(ClockTickTraces)); set => WriteStructure(nameof(ClockTickTraces), value); }

        [Offset(792UL)]
        [Length(16)]
        public DynamicArray ClockIncrementTraces { get => ReadStructure<DynamicArray>(nameof(ClockIncrementTraces)); set => WriteStructure(nameof(ClockIncrementTraces), value); }

        public KclockTimerState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KclockTimerState>();
        }
    }
}