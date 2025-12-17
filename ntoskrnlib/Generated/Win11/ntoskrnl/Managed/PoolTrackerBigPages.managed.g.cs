using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POOL_TRACKER_BIG_PAGES")]
    public sealed class PoolTrackerBigPages : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Va { get => ReadHere<ulong>(nameof(Va)); set => WriteHere(nameof(Va), value); }

        [Offset(8UL)]
        public uint Key { get => ReadHere<uint>(nameof(Key)); set => WriteHere(nameof(Key), value); }

        [Offset(12UL)]
        public uint Pattern { get => ReadHere<uint>(nameof(Pattern)); set => WriteHere(nameof(Pattern), value); }

        [Offset(12UL)]
        public uint PoolFlags { get => ReadHere<uint>(nameof(PoolFlags)); set => WriteHere(nameof(PoolFlags), value); }

        [Offset(12UL)]
        public uint SlushSize { get => ReadHere<uint>(nameof(SlushSize)); set => WriteHere(nameof(SlushSize), value); }

        [Offset(16UL)]
        public ulong NumberOfBytes { get => ReadHere<ulong>(nameof(NumberOfBytes)); set => WriteHere(nameof(NumberOfBytes), value); }

        [Offset(24UL)]
        public IntPtr ProcessBilled { get => ReadHere<IntPtr>(nameof(ProcessBilled)); set => WriteHere(nameof(ProcessBilled), value); }

        public PoolTrackerBigPages(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoolTrackerBigPages>();
        }
    }
}