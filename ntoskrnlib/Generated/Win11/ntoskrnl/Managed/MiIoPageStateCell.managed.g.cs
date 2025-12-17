using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_IO_PAGE_STATE_CELL")]
    public sealed class MiIoPageStateCell : DynamicStructure
    {
        [Offset(0UL)]
        public RtlAvlTree PfnRoot { get => ReadStructure<RtlAvlTree>(nameof(PfnRoot)); set => WriteStructure(nameof(PfnRoot), value); }

        [Offset(8UL)]
        public ulong UnmappedNodeCount { get => ReadHere<ulong>(nameof(UnmappedNodeCount)); set => WriteHere(nameof(UnmappedNodeCount), value); }

        [Offset(16UL)]
        public ulong UnmappedHugeIoSpaceNodeCount { get => ReadHere<ulong>(nameof(UnmappedHugeIoSpaceNodeCount)); set => WriteHere(nameof(UnmappedHugeIoSpaceNodeCount), value); }

        [Offset(24UL)]
        public ulong TotalNodeCount { get => ReadHere<ulong>(nameof(TotalNodeCount)); set => WriteHere(nameof(TotalNodeCount), value); }

        [Offset(32UL)]
        public ulong ResumePageForDeleteScans { get => ReadHere<ulong>(nameof(ResumePageForDeleteScans)); set => WriteHere(nameof(ResumePageForDeleteScans), value); }

        public MiIoPageStateCell(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiIoPageStateCell>();
        }
    }
}