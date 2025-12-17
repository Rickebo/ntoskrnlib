using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_IO_CACHE_STATS")]
    public sealed class MiIoCacheStats : DynamicStructure
    {
        [Offset(0UL)]
        public uint UnmappedCacheFlush { get => ReadHere<uint>(nameof(UnmappedCacheFlush)); set => WriteHere(nameof(UnmappedCacheFlush), value); }

        [Offset(4UL)]
        public uint UnmappedCacheConflict { get => ReadHere<uint>(nameof(UnmappedCacheConflict)); set => WriteHere(nameof(UnmappedCacheConflict), value); }

        [Offset(8UL)]
        public uint PermanentIoAttributeConflict { get => ReadHere<uint>(nameof(PermanentIoAttributeConflict)); set => WriteHere(nameof(PermanentIoAttributeConflict), value); }

        [Offset(12UL)]
        public uint PermanentIoNodeConflict { get => ReadHere<uint>(nameof(PermanentIoNodeConflict)); set => WriteHere(nameof(PermanentIoNodeConflict), value); }

        [Offset(16UL)]
        public uint ExclusionReferenceConflict { get => ReadHere<uint>(nameof(ExclusionReferenceConflict)); set => WriteHere(nameof(ExclusionReferenceConflict), value); }

        public MiIoCacheStats(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiIoCacheStats>();
        }
    }
}