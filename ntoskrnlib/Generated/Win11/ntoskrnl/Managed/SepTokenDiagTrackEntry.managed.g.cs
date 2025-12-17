using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SEP_TOKEN_DIAG_TRACK_ENTRY")]
    public sealed class SepTokenDiagTrackEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ProcessCid { get => ReadHere<IntPtr>(nameof(ProcessCid)); set => WriteHere(nameof(ProcessCid), value); }

        [Offset(8UL)]
        public IntPtr ThreadCid { get => ReadHere<IntPtr>(nameof(ThreadCid)); set => WriteHere(nameof(ThreadCid), value); }

        [Offset(16UL)]
        [Length(16)]
        public DynamicArray ImageFileName { get => ReadStructure<DynamicArray>(nameof(ImageFileName)); set => WriteStructure(nameof(ImageFileName), value); }

        [Offset(32UL)]
        public uint CreateMethod { get => ReadHere<uint>(nameof(CreateMethod)); set => WriteHere(nameof(CreateMethod), value); }

        [Offset(40UL)]
        [Length(30)]
        public DynamicArray CreateTrace { get => ReadStructure<DynamicArray>(nameof(CreateTrace)); set => WriteStructure(nameof(CreateTrace), value); }

        [Offset(280UL)]
        public int Count { get => ReadHere<int>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(284UL)]
        public int CaptureCount { get => ReadHere<int>(nameof(CaptureCount)); set => WriteHere(nameof(CaptureCount), value); }

        public SepTokenDiagTrackEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SepTokenDiagTrackEntry>();
        }
    }
}