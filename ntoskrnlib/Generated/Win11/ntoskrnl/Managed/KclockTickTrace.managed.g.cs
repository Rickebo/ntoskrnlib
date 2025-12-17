using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KCLOCK_TICK_TRACE")]
    public sealed class KclockTickTrace : DynamicStructure
    {
        [Offset(0UL)]
        public ulong PerformanceCounter { get => ReadHere<ulong>(nameof(PerformanceCounter)); set => WriteHere(nameof(PerformanceCounter), value); }

        [Offset(8UL)]
        public ulong PreInterruptTime { get => ReadHere<ulong>(nameof(PreInterruptTime)); set => WriteHere(nameof(PreInterruptTime), value); }

        [Offset(16UL)]
        public ulong PostInterruptTime { get => ReadHere<ulong>(nameof(PostInterruptTime)); set => WriteHere(nameof(PostInterruptTime), value); }

        [Offset(24UL)]
        public ulong TimeStampCounter { get => ReadHere<ulong>(nameof(TimeStampCounter)); set => WriteHere(nameof(TimeStampCounter), value); }

        [Offset(32UL)]
        public byte IsClockOwner { get => ReadHere<byte>(nameof(IsClockOwner)); set => WriteHere(nameof(IsClockOwner), value); }

        public KclockTickTrace(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KclockTickTrace>();
        }
    }
}