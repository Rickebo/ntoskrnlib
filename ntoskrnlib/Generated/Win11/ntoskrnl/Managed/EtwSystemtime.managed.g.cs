using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_SYSTEMTIME")]
    public sealed class EtwSystemtime : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Year { get => ReadHere<ushort>(nameof(Year)); set => WriteHere(nameof(Year), value); }

        [Offset(2UL)]
        public ushort Month { get => ReadHere<ushort>(nameof(Month)); set => WriteHere(nameof(Month), value); }

        [Offset(4UL)]
        public ushort DayOfWeek { get => ReadHere<ushort>(nameof(DayOfWeek)); set => WriteHere(nameof(DayOfWeek), value); }

        [Offset(6UL)]
        public ushort Day { get => ReadHere<ushort>(nameof(Day)); set => WriteHere(nameof(Day), value); }

        [Offset(8UL)]
        public ushort Hour { get => ReadHere<ushort>(nameof(Hour)); set => WriteHere(nameof(Hour), value); }

        [Offset(10UL)]
        public ushort Minute { get => ReadHere<ushort>(nameof(Minute)); set => WriteHere(nameof(Minute), value); }

        [Offset(12UL)]
        public ushort Second { get => ReadHere<ushort>(nameof(Second)); set => WriteHere(nameof(Second), value); }

        [Offset(14UL)]
        public ushort Milliseconds { get => ReadHere<ushort>(nameof(Milliseconds)); set => WriteHere(nameof(Milliseconds), value); }

        public EtwSystemtime(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwSystemtime>();
        }
    }
}