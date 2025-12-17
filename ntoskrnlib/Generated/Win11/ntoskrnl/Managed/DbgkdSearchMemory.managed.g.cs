using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_SEARCH_MEMORY")]
    public sealed class DbgkdSearchMemory : DynamicStructure
    {
        [Offset(0UL)]
        public ulong SearchAddress { get => ReadHere<ulong>(nameof(SearchAddress)); set => WriteHere(nameof(SearchAddress), value); }

        [Offset(0UL)]
        public ulong FoundAddress { get => ReadHere<ulong>(nameof(FoundAddress)); set => WriteHere(nameof(FoundAddress), value); }

        [Offset(8UL)]
        public ulong SearchLength { get => ReadHere<ulong>(nameof(SearchLength)); set => WriteHere(nameof(SearchLength), value); }

        [Offset(16UL)]
        public uint PatternLength { get => ReadHere<uint>(nameof(PatternLength)); set => WriteHere(nameof(PatternLength), value); }

        public DbgkdSearchMemory(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdSearchMemory>();
        }
    }
}