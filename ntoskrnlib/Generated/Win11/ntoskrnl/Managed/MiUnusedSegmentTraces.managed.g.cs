using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_UNUSED_SEGMENT_TRACES")]
    public sealed class MiUnusedSegmentTraces : DynamicStructure
    {
        [Offset(0UL)]
        public ulong ElapsedTime { get => ReadHere<ulong>(nameof(ElapsedTime)); set => WriteHere(nameof(ElapsedTime), value); }

        [Offset(8UL)]
        public ulong PagesMoved { get => ReadHere<ulong>(nameof(PagesMoved)); set => WriteHere(nameof(PagesMoved), value); }

        [Offset(16UL)]
        public ulong PagesFlushed { get => ReadHere<ulong>(nameof(PagesFlushed)); set => WriteHere(nameof(PagesFlushed), value); }

        [Offset(24UL)]
        public uint NumberOfThreads { get => ReadHere<uint>(nameof(NumberOfThreads)); set => WriteHere(nameof(NumberOfThreads), value); }

        public MiUnusedSegmentTraces(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiUnusedSegmentTraces>();
        }
    }
}