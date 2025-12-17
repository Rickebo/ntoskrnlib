using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DIRTY_PAGE_STATISTICS")]
    public sealed class DirtyPageStatistics : DynamicStructure
    {
        [Offset(0UL)]
        public ulong DirtyPages { get => ReadHere<ulong>(nameof(DirtyPages)); set => WriteHere(nameof(DirtyPages), value); }

        [Offset(8UL)]
        public ulong DirtyPagesLastScan { get => ReadHere<ulong>(nameof(DirtyPagesLastScan)); set => WriteHere(nameof(DirtyPagesLastScan), value); }

        [Offset(16UL)]
        public uint DirtyPagesScheduledLastScan { get => ReadHere<uint>(nameof(DirtyPagesScheduledLastScan)); set => WriteHere(nameof(DirtyPagesScheduledLastScan), value); }

        public DirtyPageStatistics(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DirtyPageStatistics>();
        }
    }
}