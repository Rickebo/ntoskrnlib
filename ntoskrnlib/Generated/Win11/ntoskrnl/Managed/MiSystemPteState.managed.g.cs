using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_PTE_STATE")]
    public sealed class MiSystemPteState : DynamicStructure
    {
        [Offset(0UL)]
        public NpagedLookasideList MdlTrackerLookaside { get => ReadStructure<NpagedLookasideList>(nameof(MdlTrackerLookaside)); set => WriteStructure(nameof(MdlTrackerLookaside), value); }

        [Offset(128UL)]
        public SlistHeader DeadPteTrackerSListHead { get => ReadStructure<SlistHeader>(nameof(DeadPteTrackerSListHead)); set => WriteStructure(nameof(DeadPteTrackerSListHead), value); }

        [Offset(144UL)]
        public int PteTrackerLock { get => ReadHere<int>(nameof(PteTrackerLock)); set => WriteHere(nameof(PteTrackerLock), value); }

        [Offset(152UL)]
        public IntPtr CachedPteHeads { get => ReadHere<IntPtr>(nameof(CachedPteHeads)); set => WriteHere(nameof(CachedPteHeads), value); }

        [Offset(160UL)]
        public MiSystemPteType SystemViewPteInfo { get => ReadStructure<MiSystemPteType>(nameof(SystemViewPteInfo)); set => WriteStructure(nameof(SystemViewPteInfo), value); }

        [Offset(256UL)]
        public MiSystemPteType NonCachedMappingsPteInfo { get => ReadStructure<MiSystemPteType>(nameof(NonCachedMappingsPteInfo)); set => WriteStructure(nameof(NonCachedMappingsPteInfo), value); }

        [Offset(352UL)]
        [Length(2)]
        public DynamicArray KernelStackPteInfo { get => ReadStructure<DynamicArray>(nameof(KernelStackPteInfo)); set => WriteStructure(nameof(KernelStackPteInfo), value); }

        [Offset(544UL)]
        public uint StackGrowthFailures { get => ReadHere<uint>(nameof(StackGrowthFailures)); set => WriteHere(nameof(StackGrowthFailures), value); }

        [Offset(548UL)]
        public byte KernelStackPages { get => ReadHere<byte>(nameof(KernelStackPages)); set => WriteHere(nameof(KernelStackPages), value); }

        [Offset(549UL)]
        public byte TrackPtesAborted { get => ReadHere<byte>(nameof(TrackPtesAborted)); set => WriteHere(nameof(TrackPtesAborted), value); }

        [Offset(550UL)]
        public byte AdjustCounter { get => ReadHere<byte>(nameof(AdjustCounter)); set => WriteHere(nameof(AdjustCounter), value); }

        [Offset(552UL)]
        public int ReservedMappingLock { get => ReadHere<int>(nameof(ReservedMappingLock)); set => WriteHere(nameof(ReservedMappingLock), value); }

        [Offset(560UL)]
        public RtlAvlTree ReservedMappingTree { get => ReadStructure<RtlAvlTree>(nameof(ReservedMappingTree)); set => WriteStructure(nameof(ReservedMappingTree), value); }

        [Offset(568UL)]
        public MiPageChainHead ReservedMappingPageTablePfns { get => ReadStructure<MiPageChainHead>(nameof(ReservedMappingPageTablePfns)); set => WriteStructure(nameof(ReservedMappingPageTablePfns), value); }

        [Offset(592UL)]
        public RtlAvlTree OutswappedKernelStackRoot { get => ReadStructure<RtlAvlTree>(nameof(OutswappedKernelStackRoot)); set => WriteStructure(nameof(OutswappedKernelStackRoot), value); }

        [Offset(600UL)]
        public int OutswappedKernelStackLock { get => ReadHere<int>(nameof(OutswappedKernelStackLock)); set => WriteHere(nameof(OutswappedKernelStackLock), value); }

        [Offset(608UL)]
        public MiUltraVaContext UltraSpaceContext { get => ReadStructure<MiUltraVaContext>(nameof(UltraSpaceContext)); set => WriteStructure(nameof(UltraSpaceContext), value); }

        [Offset(672UL)]
        public uint NumberOfUltraMdlMaps { get => ReadHere<uint>(nameof(NumberOfUltraMdlMaps)); set => WriteHere(nameof(NumberOfUltraMdlMaps), value); }

        [Offset(680UL)]
        public IntPtr UltraMdlNodeMappings { get => ReadHere<IntPtr>(nameof(UltraMdlNodeMappings)); set => WriteHere(nameof(UltraMdlNodeMappings), value); }

        [Offset(688UL)]
        public IntPtr UltraSpaceLowPpe { get => ReadHere<IntPtr>(nameof(UltraSpaceLowPpe)); set => WriteHere(nameof(UltraSpaceLowPpe), value); }

        [Offset(696UL)]
        public IntPtr UltraSpaceHighPpe { get => ReadHere<IntPtr>(nameof(UltraSpaceHighPpe)); set => WriteHere(nameof(UltraSpaceHighPpe), value); }

        [Offset(704UL)]
        public ExPushLock SystemSpaceViewLock { get => ReadStructure<ExPushLock>(nameof(SystemSpaceViewLock)); set => WriteStructure(nameof(SystemSpaceViewLock), value); }

        [Offset(712UL)]
        public RtlAvlTree ViewRoot { get => ReadStructure<RtlAvlTree>(nameof(ViewRoot)); set => WriteStructure(nameof(ViewRoot), value); }

        [Offset(720UL)]
        public uint ViewCount { get => ReadHere<uint>(nameof(ViewCount)); set => WriteHere(nameof(ViewCount), value); }

        [Offset(768UL)]
        [Length(4)]
        public DynamicArray WorkingSetLockArray { get => ReadStructure<DynamicArray>(nameof(WorkingSetLockArray)); set => WriteStructure(nameof(WorkingSetLockArray), value); }

        [Offset(1024UL)]
        [Length(4)]
        public DynamicArray SystemDataViewsWorkingSetLockArray { get => ReadStructure<DynamicArray>(nameof(SystemDataViewsWorkingSetLockArray)); set => WriteStructure(nameof(SystemDataViewsWorkingSetLockArray), value); }

        [Offset(1280UL)]
        [Length(256)]
        public DynamicArray SystemViewBuckets { get => ReadStructure<DynamicArray>(nameof(SystemViewBuckets)); set => WriteStructure(nameof(SystemViewBuckets), value); }

        public MiSystemPteState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSystemPteState>();
        }
    }
}