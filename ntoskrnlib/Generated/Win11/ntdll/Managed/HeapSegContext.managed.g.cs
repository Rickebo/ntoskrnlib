using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_SEG_CONTEXT")]
    public sealed class HeapSegContext : DynamicStructure
    {
        [Offset(0UL)]
        public ulong SegmentMask { get => ReadHere<ulong>(nameof(SegmentMask)); set => WriteHere(nameof(SegmentMask), value); }

        [Offset(8UL)]
        public byte UnitShift { get => ReadHere<byte>(nameof(UnitShift)); set => WriteHere(nameof(UnitShift), value); }

        [Offset(9UL)]
        public byte PagesPerUnitShift { get => ReadHere<byte>(nameof(PagesPerUnitShift)); set => WriteHere(nameof(PagesPerUnitShift), value); }

        [Offset(10UL)]
        public byte FirstDescriptorIndex { get => ReadHere<byte>(nameof(FirstDescriptorIndex)); set => WriteHere(nameof(FirstDescriptorIndex), value); }

        [Offset(11UL)]
        public byte CachedCommitSoftShift { get => ReadHere<byte>(nameof(CachedCommitSoftShift)); set => WriteHere(nameof(CachedCommitSoftShift), value); }

        [Offset(12UL)]
        public byte CachedCommitHighShift { get => ReadHere<byte>(nameof(CachedCommitHighShift)); set => WriteHere(nameof(CachedCommitHighShift), value); }

        [Offset(13UL)]
        public UnnamedTag Flags { get => ReadStructure<UnnamedTag>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(16UL)]
        public uint MaxAllocationSize { get => ReadHere<uint>(nameof(MaxAllocationSize)); set => WriteHere(nameof(MaxAllocationSize), value); }

        [Offset(20UL)]
        public short OlpStatsOffset { get => ReadHere<short>(nameof(OlpStatsOffset)); set => WriteHere(nameof(OlpStatsOffset), value); }

        [Offset(22UL)]
        public short MemStatsOffset { get => ReadHere<short>(nameof(MemStatsOffset)); set => WriteHere(nameof(MemStatsOffset), value); }

        [Offset(24UL)]
        public IntPtr LfhContext { get => ReadHere<IntPtr>(nameof(LfhContext)); set => WriteHere(nameof(LfhContext), value); }

        [Offset(32UL)]
        public IntPtr VsContext { get => ReadHere<IntPtr>(nameof(VsContext)); set => WriteHere(nameof(VsContext), value); }

        [Offset(40UL)]
        public RtlHpEnvHandle EnvHandle { get => ReadStructure<RtlHpEnvHandle>(nameof(EnvHandle)); set => WriteStructure(nameof(EnvHandle), value); }

        [Offset(56UL)]
        public IntPtr Heap { get => ReadHere<IntPtr>(nameof(Heap)); set => WriteHere(nameof(Heap), value); }

        [Offset(64UL)]
        public ulong SegmentLock { get => ReadHere<ulong>(nameof(SegmentLock)); set => WriteHere(nameof(SegmentLock), value); }

        [Offset(72UL)]
        public ListEntry SegmentListHead { get => ReadStructure<ListEntry>(nameof(SegmentListHead)); set => WriteStructure(nameof(SegmentListHead), value); }

        [Offset(88UL)]
        public ulong SegmentCount { get => ReadHere<ulong>(nameof(SegmentCount)); set => WriteHere(nameof(SegmentCount), value); }

        [Offset(96UL)]
        public RtlRbTree FreePageRanges { get => ReadStructure<RtlRbTree>(nameof(FreePageRanges)); set => WriteStructure(nameof(FreePageRanges), value); }

        [Offset(112UL)]
        public ulong FreeSegmentListLock { get => ReadHere<ulong>(nameof(FreeSegmentListLock)); set => WriteHere(nameof(FreeSegmentListLock), value); }

        [Offset(120UL)]
        [Length(2)]
        public DynamicArray FreeSegmentList { get => ReadStructure<DynamicArray>(nameof(FreeSegmentList)); set => WriteStructure(nameof(FreeSegmentList), value); }

        public HeapSegContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapSegContext>();
        }
    }
}