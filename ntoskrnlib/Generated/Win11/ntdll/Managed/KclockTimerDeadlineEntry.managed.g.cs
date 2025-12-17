using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KCLOCK_TIMER_DEADLINE_ENTRY")]
    public sealed class KclockTimerDeadlineEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ulong DueTime { get => ReadHere<ulong>(nameof(DueTime)); set => WriteHere(nameof(DueTime), value); }

        [Offset(8UL)]
        public uint TolerableDelay { get => ReadHere<uint>(nameof(TolerableDelay)); set => WriteHere(nameof(TolerableDelay), value); }

        [Offset(12UL)]
        public byte TypeFlags { get => ReadHere<byte>(nameof(TypeFlags)); set => WriteHere(nameof(TypeFlags), value); }

        [Offset(12UL)]
        public byte Valid { get => ReadHere<byte>(nameof(Valid)); set => WriteHere(nameof(Valid), value); }

        [Offset(12UL)]
        public byte NoWake { get => ReadHere<byte>(nameof(NoWake)); set => WriteHere(nameof(NoWake), value); }

        [Offset(12UL)]
        public byte Unused { get => ReadHere<byte>(nameof(Unused)); set => WriteHere(nameof(Unused), value); }

        public KclockTimerDeadlineEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KclockTimerDeadlineEntry>();
        }
    }
}