using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TIME_FIELDS")]
    public sealed class TimeFields : DynamicStructure
    {
        [Offset(0UL)]
        public short Year { get => ReadHere<short>(nameof(Year)); set => WriteHere(nameof(Year), value); }

        [Offset(2UL)]
        public short Month { get => ReadHere<short>(nameof(Month)); set => WriteHere(nameof(Month), value); }

        [Offset(4UL)]
        public short Day { get => ReadHere<short>(nameof(Day)); set => WriteHere(nameof(Day), value); }

        [Offset(6UL)]
        public short Hour { get => ReadHere<short>(nameof(Hour)); set => WriteHere(nameof(Hour), value); }

        [Offset(8UL)]
        public short Minute { get => ReadHere<short>(nameof(Minute)); set => WriteHere(nameof(Minute), value); }

        [Offset(10UL)]
        public short Second { get => ReadHere<short>(nameof(Second)); set => WriteHere(nameof(Second), value); }

        [Offset(12UL)]
        public short Milliseconds { get => ReadHere<short>(nameof(Milliseconds)); set => WriteHere(nameof(Milliseconds), value); }

        [Offset(14UL)]
        public short Weekday { get => ReadHere<short>(nameof(Weekday)); set => WriteHere(nameof(Weekday), value); }

        public TimeFields(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TimeFields>();
        }
    }
}