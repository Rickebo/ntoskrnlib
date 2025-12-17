using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_TRACE_SEGMENT")]
    public sealed class RtlTraceSegment : DynamicStructure
    {
        [Offset(0UL)]
        public uint Magic { get => ReadHere<uint>(nameof(Magic)); set => WriteHere(nameof(Magic), value); }

        [Offset(8UL)]
        public IntPtr Database { get => ReadHere<IntPtr>(nameof(Database)); set => WriteHere(nameof(Database), value); }

        [Offset(16UL)]
        public IntPtr NextSegment { get => ReadHere<IntPtr>(nameof(NextSegment)); set => WriteHere(nameof(NextSegment), value); }

        [Offset(24UL)]
        public ulong TotalSize { get => ReadHere<ulong>(nameof(TotalSize)); set => WriteHere(nameof(TotalSize), value); }

        [Offset(32UL)]
        public IntPtr SegmentStart { get => ReadHere<IntPtr>(nameof(SegmentStart)); set => WriteHere(nameof(SegmentStart), value); }

        [Offset(40UL)]
        public IntPtr SegmentEnd { get => ReadHere<IntPtr>(nameof(SegmentEnd)); set => WriteHere(nameof(SegmentEnd), value); }

        [Offset(48UL)]
        public IntPtr SegmentFree { get => ReadHere<IntPtr>(nameof(SegmentFree)); set => WriteHere(nameof(SegmentFree), value); }

        public RtlTraceSegment(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlTraceSegment>();
        }
    }
}