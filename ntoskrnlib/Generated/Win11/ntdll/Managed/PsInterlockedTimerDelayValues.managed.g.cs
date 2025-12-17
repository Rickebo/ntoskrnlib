using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PS_INTERLOCKED_TIMER_DELAY_VALUES")]
    public sealed class PsInterlockedTimerDelayValues : DynamicStructure
    {
        [Offset(0UL)]
        public ulong DelayMs { get => ReadHere<ulong>(nameof(DelayMs)); set => WriteHere(nameof(DelayMs), value); }

        [Offset(0UL)]
        public ulong CoalescingWindowMs { get => ReadHere<ulong>(nameof(CoalescingWindowMs)); set => WriteHere(nameof(CoalescingWindowMs), value); }

        [Offset(0UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ulong NewTimerWheel { get => ReadHere<ulong>(nameof(NewTimerWheel)); set => WriteHere(nameof(NewTimerWheel), value); }

        [Offset(0UL)]
        public ulong Retry { get => ReadHere<ulong>(nameof(Retry)); set => WriteHere(nameof(Retry), value); }

        [Offset(0UL)]
        public ulong Locked { get => ReadHere<ulong>(nameof(Locked)); set => WriteHere(nameof(Locked), value); }

        [Offset(0UL)]
        public ulong All { get => ReadHere<ulong>(nameof(All)); set => WriteHere(nameof(All), value); }

        public PsInterlockedTimerDelayValues(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsInterlockedTimerDelayValues>();
        }
    }
}