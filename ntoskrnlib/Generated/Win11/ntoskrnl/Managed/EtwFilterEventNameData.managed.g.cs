using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_FILTER_EVENT_NAME_DATA")]
    public sealed class EtwFilterEventNameData : DynamicStructure
    {
        [Offset(0UL)]
        public byte FilterIn { get => ReadHere<byte>(nameof(FilterIn)); set => WriteHere(nameof(FilterIn), value); }

        [Offset(1UL)]
        public byte Level { get => ReadHere<byte>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(8UL)]
        public ulong MatchAnyKeyword { get => ReadHere<ulong>(nameof(MatchAnyKeyword)); set => WriteHere(nameof(MatchAnyKeyword), value); }

        [Offset(16UL)]
        public ulong MatchAllKeyword { get => ReadHere<ulong>(nameof(MatchAllKeyword)); set => WriteHere(nameof(MatchAllKeyword), value); }

        [Offset(24UL)]
        public RtlHashTable NameTable { get => ReadStructure<RtlHashTable>(nameof(NameTable)); set => WriteStructure(nameof(NameTable), value); }

        public EtwFilterEventNameData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwFilterEventNameData>();
        }
    }
}