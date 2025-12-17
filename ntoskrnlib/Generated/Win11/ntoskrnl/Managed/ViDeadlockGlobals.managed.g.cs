using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VI_DEADLOCK_GLOBALS")]
    public sealed class ViDeadlockGlobals : DynamicStructure
    {
        [Offset(0UL)]
        public long TimeAcquire { get => ReadHere<long>(nameof(TimeAcquire)); set => WriteHere(nameof(TimeAcquire), value); }

        [Offset(8UL)]
        public long TimeRelease { get => ReadHere<long>(nameof(TimeRelease)); set => WriteHere(nameof(TimeRelease), value); }

        [Offset(16UL)]
        public IntPtr ResourceDatabase { get => ReadHere<IntPtr>(nameof(ResourceDatabase)); set => WriteHere(nameof(ResourceDatabase), value); }

        [Offset(24UL)]
        public ulong ResourceDatabaseCount { get => ReadHere<ulong>(nameof(ResourceDatabaseCount)); set => WriteHere(nameof(ResourceDatabaseCount), value); }

        [Offset(32UL)]
        [Length(1023)]
        public DynamicArray ResourceAddressRange { get => ReadStructure<DynamicArray>(nameof(ResourceAddressRange)); set => WriteStructure(nameof(ResourceAddressRange), value); }

        [Offset(16400UL)]
        public IntPtr ThreadDatabase { get => ReadHere<IntPtr>(nameof(ThreadDatabase)); set => WriteHere(nameof(ThreadDatabase), value); }

        [Offset(16408UL)]
        public ulong ThreadDatabaseCount { get => ReadHere<ulong>(nameof(ThreadDatabaseCount)); set => WriteHere(nameof(ThreadDatabaseCount), value); }

        [Offset(16416UL)]
        [Length(1023)]
        public DynamicArray ThreadAddressRange { get => ReadStructure<DynamicArray>(nameof(ThreadAddressRange)); set => WriteStructure(nameof(ThreadAddressRange), value); }

        [Offset(32784UL)]
        public uint AllocationFailures { get => ReadHere<uint>(nameof(AllocationFailures)); set => WriteHere(nameof(AllocationFailures), value); }

        [Offset(32788UL)]
        public uint NodesTrimmedBasedOnAge { get => ReadHere<uint>(nameof(NodesTrimmedBasedOnAge)); set => WriteHere(nameof(NodesTrimmedBasedOnAge), value); }

        [Offset(32792UL)]
        public uint NodesTrimmedBasedOnCount { get => ReadHere<uint>(nameof(NodesTrimmedBasedOnCount)); set => WriteHere(nameof(NodesTrimmedBasedOnCount), value); }

        [Offset(32796UL)]
        public uint NodesSearched { get => ReadHere<uint>(nameof(NodesSearched)); set => WriteHere(nameof(NodesSearched), value); }

        [Offset(32800UL)]
        public uint MaxNodesSearched { get => ReadHere<uint>(nameof(MaxNodesSearched)); set => WriteHere(nameof(MaxNodesSearched), value); }

        [Offset(32804UL)]
        public uint SequenceNumber { get => ReadHere<uint>(nameof(SequenceNumber)); set => WriteHere(nameof(SequenceNumber), value); }

        [Offset(32808UL)]
        public uint RecursionDepthLimit { get => ReadHere<uint>(nameof(RecursionDepthLimit)); set => WriteHere(nameof(RecursionDepthLimit), value); }

        [Offset(32812UL)]
        public uint SearchedNodesLimit { get => ReadHere<uint>(nameof(SearchedNodesLimit)); set => WriteHere(nameof(SearchedNodesLimit), value); }

        [Offset(32816UL)]
        public uint DepthLimitHits { get => ReadHere<uint>(nameof(DepthLimitHits)); set => WriteHere(nameof(DepthLimitHits), value); }

        [Offset(32820UL)]
        public uint SearchLimitHits { get => ReadHere<uint>(nameof(SearchLimitHits)); set => WriteHere(nameof(SearchLimitHits), value); }

        [Offset(32824UL)]
        public uint StackLimitHits { get => ReadHere<uint>(nameof(StackLimitHits)); set => WriteHere(nameof(StackLimitHits), value); }

        [Offset(32828UL)]
        public uint ABC_ACB_Skipped { get => ReadHere<uint>(nameof(ABC_ACB_Skipped)); set => WriteHere(nameof(ABC_ACB_Skipped), value); }

        [Offset(32832UL)]
        public uint OutOfOrderReleases { get => ReadHere<uint>(nameof(OutOfOrderReleases)); set => WriteHere(nameof(OutOfOrderReleases), value); }

        [Offset(32836UL)]
        public uint NodesReleasedOutOfOrder { get => ReadHere<uint>(nameof(NodesReleasedOutOfOrder)); set => WriteHere(nameof(NodesReleasedOutOfOrder), value); }

        [Offset(32840UL)]
        public uint TotalReleases { get => ReadHere<uint>(nameof(TotalReleases)); set => WriteHere(nameof(TotalReleases), value); }

        [Offset(32844UL)]
        public uint RootNodesDeleted { get => ReadHere<uint>(nameof(RootNodesDeleted)); set => WriteHere(nameof(RootNodesDeleted), value); }

        [Offset(32848UL)]
        public uint ForgetHistoryCounter { get => ReadHere<uint>(nameof(ForgetHistoryCounter)); set => WriteHere(nameof(ForgetHistoryCounter), value); }

        [Offset(32856UL)]
        public IntPtr Instigator { get => ReadHere<IntPtr>(nameof(Instigator)); set => WriteHere(nameof(Instigator), value); }

        [Offset(32864UL)]
        public uint NumberOfParticipants { get => ReadHere<uint>(nameof(NumberOfParticipants)); set => WriteHere(nameof(NumberOfParticipants), value); }

        [Offset(32872UL)]
        [Length(32)]
        public DynamicArray Participant { get => ReadStructure<DynamicArray>(nameof(Participant)); set => WriteStructure(nameof(Participant), value); }

        [Offset(33128UL)]
        public int ChildrenCountWatermark { get => ReadHere<int>(nameof(ChildrenCountWatermark)); set => WriteHere(nameof(ChildrenCountWatermark), value); }

        [Offset(33132UL)]
        public uint StackType { get => ReadHere<uint>(nameof(StackType)); set => WriteHere(nameof(StackType), value); }

        [Offset(33136UL)]
        public ulong StackLowLimit { get => ReadHere<ulong>(nameof(StackLowLimit)); set => WriteHere(nameof(StackLowLimit), value); }

        [Offset(33144UL)]
        public ulong StackHighLimit { get => ReadHere<ulong>(nameof(StackHighLimit)); set => WriteHere(nameof(StackHighLimit), value); }

        public ViDeadlockGlobals(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ViDeadlockGlobals>();
        }
    }
}