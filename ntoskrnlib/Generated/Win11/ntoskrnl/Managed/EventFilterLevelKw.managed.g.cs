using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EVENT_FILTER_LEVEL_KW")]
    public sealed class EventFilterLevelKw : DynamicStructure
    {
        [Offset(0UL)]
        public ulong MatchAnyKeyword { get => ReadHere<ulong>(nameof(MatchAnyKeyword)); set => WriteHere(nameof(MatchAnyKeyword), value); }

        [Offset(8UL)]
        public ulong MatchAllKeyword { get => ReadHere<ulong>(nameof(MatchAllKeyword)); set => WriteHere(nameof(MatchAllKeyword), value); }

        [Offset(16UL)]
        public byte Level { get => ReadHere<byte>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(17UL)]
        public byte FilterIn { get => ReadHere<byte>(nameof(FilterIn)); set => WriteHere(nameof(FilterIn), value); }

        public EventFilterLevelKw(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EventFilterLevelKw>();
        }
    }
}