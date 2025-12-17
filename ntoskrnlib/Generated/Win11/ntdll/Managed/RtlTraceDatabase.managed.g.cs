using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_TRACE_DATABASE")]
    public sealed class RtlTraceDatabase : DynamicStructure
    {
        [Offset(0UL)]
        public uint Magic { get => ReadHere<uint>(nameof(Magic)); set => WriteHere(nameof(Magic), value); }

        [Offset(4UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(8UL)]
        public uint Tag { get => ReadHere<uint>(nameof(Tag)); set => WriteHere(nameof(Tag), value); }

        [Offset(16UL)]
        public IntPtr SegmentList { get => ReadHere<IntPtr>(nameof(SegmentList)); set => WriteHere(nameof(SegmentList), value); }

        [Offset(24UL)]
        public ulong MaximumSize { get => ReadHere<ulong>(nameof(MaximumSize)); set => WriteHere(nameof(MaximumSize), value); }

        [Offset(32UL)]
        public ulong CurrentSize { get => ReadHere<ulong>(nameof(CurrentSize)); set => WriteHere(nameof(CurrentSize), value); }

        [Offset(40UL)]
        public IntPtr Owner { get => ReadHere<IntPtr>(nameof(Owner)); set => WriteHere(nameof(Owner), value); }

        [Offset(48UL)]
        public RtlCriticalSection Lock { get => ReadStructure<RtlCriticalSection>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(88UL)]
        public uint NoOfBuckets { get => ReadHere<uint>(nameof(NoOfBuckets)); set => WriteHere(nameof(NoOfBuckets), value); }

        [Offset(96UL)]
        public IntPtr Buckets { get => ReadHere<IntPtr>(nameof(Buckets)); set => WriteHere(nameof(Buckets), value); }

        [Offset(104UL)]
        public IntPtr HashFunction { get => ReadHere<IntPtr>(nameof(HashFunction)); set => WriteHere(nameof(HashFunction), value); }

        [Offset(112UL)]
        public ulong NoOfTraces { get => ReadHere<ulong>(nameof(NoOfTraces)); set => WriteHere(nameof(NoOfTraces), value); }

        [Offset(120UL)]
        public ulong NoOfHits { get => ReadHere<ulong>(nameof(NoOfHits)); set => WriteHere(nameof(NoOfHits), value); }

        [Offset(128UL)]
        [Length(16)]
        public DynamicArray HashCounter { get => ReadStructure<DynamicArray>(nameof(HashCounter)); set => WriteStructure(nameof(HashCounter), value); }

        public RtlTraceDatabase(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlTraceDatabase>();
        }
    }
}