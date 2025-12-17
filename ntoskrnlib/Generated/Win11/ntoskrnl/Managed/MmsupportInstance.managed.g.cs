using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMSUPPORT_INSTANCE")]
    public sealed class MmsupportInstance : DynamicStructure
    {
        [Offset(0UL)]
        public uint NextPageColor { get => ReadHere<uint>(nameof(NextPageColor)); set => WriteHere(nameof(NextPageColor), value); }

        [Offset(4UL)]
        public uint PageFaultCount { get => ReadHere<uint>(nameof(PageFaultCount)); set => WriteHere(nameof(PageFaultCount), value); }

        [Offset(8UL)]
        public ulong TrimmedPageCount { get => ReadHere<ulong>(nameof(TrimmedPageCount)); set => WriteHere(nameof(TrimmedPageCount), value); }

        [Offset(16UL)]
        public IntPtr VmWorkingSetList { get => ReadHere<IntPtr>(nameof(VmWorkingSetList)); set => WriteHere(nameof(VmWorkingSetList), value); }

        [Offset(24UL)]
        public ListEntry WorkingSetExpansionLinks { get => ReadStructure<ListEntry>(nameof(WorkingSetExpansionLinks)); set => WriteStructure(nameof(WorkingSetExpansionLinks), value); }

        [Offset(40UL)]
        [Length(8)]
        public DynamicArray AgeDistribution { get => ReadStructure<DynamicArray>(nameof(AgeDistribution)); set => WriteStructure(nameof(AgeDistribution), value); }

        [Offset(104UL)]
        public IntPtr ExitOutswapGate { get => ReadHere<IntPtr>(nameof(ExitOutswapGate)); set => WriteHere(nameof(ExitOutswapGate), value); }

        [Offset(112UL)]
        public ulong MinimumWorkingSetSize { get => ReadHere<ulong>(nameof(MinimumWorkingSetSize)); set => WriteHere(nameof(MinimumWorkingSetSize), value); }

        [Offset(120UL)]
        public ulong MaximumWorkingSetSize { get => ReadHere<ulong>(nameof(MaximumWorkingSetSize)); set => WriteHere(nameof(MaximumWorkingSetSize), value); }

        [Offset(128UL)]
        public ulong WorkingSetLeafSize { get => ReadHere<ulong>(nameof(WorkingSetLeafSize)); set => WriteHere(nameof(WorkingSetLeafSize), value); }

        [Offset(136UL)]
        public ulong WorkingSetLeafPrivateSize { get => ReadHere<ulong>(nameof(WorkingSetLeafPrivateSize)); set => WriteHere(nameof(WorkingSetLeafPrivateSize), value); }

        [Offset(144UL)]
        public ulong WorkingSetSize { get => ReadHere<ulong>(nameof(WorkingSetSize)); set => WriteHere(nameof(WorkingSetSize), value); }

        [Offset(152UL)]
        public ulong WorkingSetPrivateSize { get => ReadHere<ulong>(nameof(WorkingSetPrivateSize)); set => WriteHere(nameof(WorkingSetPrivateSize), value); }

        [Offset(160UL)]
        public ulong PeakWorkingSetSize { get => ReadHere<ulong>(nameof(PeakWorkingSetSize)); set => WriteHere(nameof(PeakWorkingSetSize), value); }

        [Offset(168UL)]
        public uint HardFaultCount { get => ReadHere<uint>(nameof(HardFaultCount)); set => WriteHere(nameof(HardFaultCount), value); }

        [Offset(172UL)]
        public ushort LastTrimStamp { get => ReadHere<ushort>(nameof(LastTrimStamp)); set => WriteHere(nameof(LastTrimStamp), value); }

        [Offset(174UL)]
        public ushort PartitionId { get => ReadHere<ushort>(nameof(PartitionId)); set => WriteHere(nameof(PartitionId), value); }

        [Offset(176UL)]
        public ulong SelfmapLock { get => ReadHere<ulong>(nameof(SelfmapLock)); set => WriteHere(nameof(SelfmapLock), value); }

        [Offset(184UL)]
        public MmsupportFlags Flags { get => ReadStructure<MmsupportFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(188UL)]
        public uint InterlockedFlags { get => ReadHere<uint>(nameof(InterlockedFlags)); set => WriteHere(nameof(InterlockedFlags), value); }

        public MmsupportInstance(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmsupportInstance>();
        }
    }
}