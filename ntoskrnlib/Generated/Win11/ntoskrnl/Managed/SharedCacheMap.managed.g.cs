using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SHARED_CACHE_MAP")]
    public sealed class SharedCacheMap : DynamicStructure
    {
        [Offset(0UL)]
        public short NodeTypeCode { get => ReadHere<short>(nameof(NodeTypeCode)); set => WriteHere(nameof(NodeTypeCode), value); }

        [Offset(2UL)]
        public short NodeByteSize { get => ReadHere<short>(nameof(NodeByteSize)); set => WriteHere(nameof(NodeByteSize), value); }

        [Offset(4UL)]
        public uint OpenCount { get => ReadHere<uint>(nameof(OpenCount)); set => WriteHere(nameof(OpenCount), value); }

        [Offset(8UL)]
        public LargeInteger FileSize { get => ReadStructure<LargeInteger>(nameof(FileSize)); set => WriteStructure(nameof(FileSize), value); }

        [Offset(16UL)]
        public ListEntry BcbList { get => ReadStructure<ListEntry>(nameof(BcbList)); set => WriteStructure(nameof(BcbList), value); }

        [Offset(32UL)]
        public LargeInteger SectionSize { get => ReadStructure<LargeInteger>(nameof(SectionSize)); set => WriteStructure(nameof(SectionSize), value); }

        [Offset(40UL)]
        public LargeInteger ValidDataLength { get => ReadStructure<LargeInteger>(nameof(ValidDataLength)); set => WriteStructure(nameof(ValidDataLength), value); }

        [Offset(48UL)]
        public LargeInteger ValidDataGoal { get => ReadStructure<LargeInteger>(nameof(ValidDataGoal)); set => WriteStructure(nameof(ValidDataGoal), value); }

        [Offset(56UL)]
        [Length(4)]
        public DynamicArray InitialVacbs { get => ReadStructure<DynamicArray>(nameof(InitialVacbs)); set => WriteStructure(nameof(InitialVacbs), value); }

        [Offset(88UL)]
        public IntPtr Vacbs { get => ReadHere<IntPtr>(nameof(Vacbs)); set => WriteHere(nameof(Vacbs), value); }

        [Offset(96UL)]
        public ExFastRef FileObjectFastRef { get => ReadStructure<ExFastRef>(nameof(FileObjectFastRef)); set => WriteStructure(nameof(FileObjectFastRef), value); }

        [Offset(104UL)]
        public ExPushLock VacbLock { get => ReadStructure<ExPushLock>(nameof(VacbLock)); set => WriteStructure(nameof(VacbLock), value); }

        [Offset(112UL)]
        public uint DirtyPages { get => ReadHere<uint>(nameof(DirtyPages)); set => WriteHere(nameof(DirtyPages), value); }

        [Offset(120UL)]
        public ListEntry LoggedStreamLinks { get => ReadStructure<ListEntry>(nameof(LoggedStreamLinks)); set => WriteStructure(nameof(LoggedStreamLinks), value); }

        [Offset(136UL)]
        public ListEntry SharedCacheMapLinks { get => ReadStructure<ListEntry>(nameof(SharedCacheMapLinks)); set => WriteStructure(nameof(SharedCacheMapLinks), value); }

        [Offset(152UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(156UL)]
        public uint Flags2 { get => ReadHere<uint>(nameof(Flags2)); set => WriteHere(nameof(Flags2), value); }

        [Offset(160UL)]
        public int Status { get => ReadHere<int>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        [Offset(168UL)]
        public IntPtr Mbcb { get => ReadHere<IntPtr>(nameof(Mbcb)); set => WriteHere(nameof(Mbcb), value); }

        [Offset(176UL)]
        public IntPtr Section { get => ReadHere<IntPtr>(nameof(Section)); set => WriteHere(nameof(Section), value); }

        [Offset(184UL)]
        public IntPtr CreateEvent { get => ReadHere<IntPtr>(nameof(CreateEvent)); set => WriteHere(nameof(CreateEvent), value); }

        [Offset(192UL)]
        public IntPtr WaitOnActiveCount { get => ReadHere<IntPtr>(nameof(WaitOnActiveCount)); set => WriteHere(nameof(WaitOnActiveCount), value); }

        [Offset(200UL)]
        public uint PagesToWrite { get => ReadHere<uint>(nameof(PagesToWrite)); set => WriteHere(nameof(PagesToWrite), value); }

        [Offset(208UL)]
        public long BeyondLastFlush { get => ReadHere<long>(nameof(BeyondLastFlush)); set => WriteHere(nameof(BeyondLastFlush), value); }

        [Offset(216UL)]
        public IntPtr Callbacks { get => ReadHere<IntPtr>(nameof(Callbacks)); set => WriteHere(nameof(Callbacks), value); }

        [Offset(216UL)]
        public IntPtr CallbacksEx { get => ReadHere<IntPtr>(nameof(CallbacksEx)); set => WriteHere(nameof(CallbacksEx), value); }

        [Offset(224UL)]
        public IntPtr LazyWriteContext { get => ReadHere<IntPtr>(nameof(LazyWriteContext)); set => WriteHere(nameof(LazyWriteContext), value); }

        [Offset(232UL)]
        public ListEntry PrivateList { get => ReadStructure<ListEntry>(nameof(PrivateList)); set => WriteStructure(nameof(PrivateList), value); }

        [Offset(248UL)]
        public LoggedStreamCallbackV1 V1 { get => ReadStructure<LoggedStreamCallbackV1>(nameof(V1)); set => WriteStructure(nameof(V1), value); }

        [Offset(248UL)]
        public LoggedStreamCallbackV2 V2 { get => ReadStructure<LoggedStreamCallbackV2>(nameof(V2)); set => WriteStructure(nameof(V2), value); }

        [Offset(264UL)]
        public LargeInteger LargestLSN { get => ReadStructure<LargeInteger>(nameof(LargestLSN)); set => WriteStructure(nameof(LargestLSN), value); }

        [Offset(272UL)]
        public uint DirtyPageThreshold { get => ReadHere<uint>(nameof(DirtyPageThreshold)); set => WriteHere(nameof(DirtyPageThreshold), value); }

        [Offset(276UL)]
        public uint LazyWritePassCount { get => ReadHere<uint>(nameof(LazyWritePassCount)); set => WriteHere(nameof(LazyWritePassCount), value); }

        [Offset(280UL)]
        public IntPtr UninitializeEvent { get => ReadHere<IntPtr>(nameof(UninitializeEvent)); set => WriteHere(nameof(UninitializeEvent), value); }

        [Offset(288UL)]
        public FastMutex BcbLock { get => ReadStructure<FastMutex>(nameof(BcbLock)); set => WriteStructure(nameof(BcbLock), value); }

        [Offset(344UL)]
        public LargeInteger LastUnmapBehindOffset { get => ReadStructure<LargeInteger>(nameof(LastUnmapBehindOffset)); set => WriteStructure(nameof(LastUnmapBehindOffset), value); }

        [Offset(352UL)]
        public Kevent Event { get => ReadStructure<Kevent>(nameof(Event)); set => WriteStructure(nameof(Event), value); }

        [Offset(376UL)]
        public LargeInteger HighWaterMappingOffset { get => ReadStructure<LargeInteger>(nameof(HighWaterMappingOffset)); set => WriteStructure(nameof(HighWaterMappingOffset), value); }

        [Offset(384UL)]
        public PrivateCacheMap PrivateCacheMap { get => ReadStructure<PrivateCacheMap>(nameof(PrivateCacheMap)); set => WriteStructure(nameof(PrivateCacheMap), value); }

        [Offset(504UL)]
        public IntPtr WriteBehindWorkQueueEntry { get => ReadHere<IntPtr>(nameof(WriteBehindWorkQueueEntry)); set => WriteHere(nameof(WriteBehindWorkQueueEntry), value); }

        [Offset(512UL)]
        public IntPtr VolumeCacheMap { get => ReadHere<IntPtr>(nameof(VolumeCacheMap)); set => WriteHere(nameof(VolumeCacheMap), value); }

        [Offset(520UL)]
        public uint ProcImagePathHash { get => ReadHere<uint>(nameof(ProcImagePathHash)); set => WriteHere(nameof(ProcImagePathHash), value); }

        [Offset(524UL)]
        public uint WritesInProgress { get => ReadHere<uint>(nameof(WritesInProgress)); set => WriteHere(nameof(WritesInProgress), value); }

        [Offset(528UL)]
        public uint AsyncReadRequestCount { get => ReadHere<uint>(nameof(AsyncReadRequestCount)); set => WriteHere(nameof(AsyncReadRequestCount), value); }

        [Offset(536UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(544UL)]
        public uint InternalRefCount { get => ReadHere<uint>(nameof(InternalRefCount)); set => WriteHere(nameof(InternalRefCount), value); }

        [Offset(548UL)]
        public uint NumMappedVacb { get => ReadHere<uint>(nameof(NumMappedVacb)); set => WriteHere(nameof(NumMappedVacb), value); }

        [Offset(552UL)]
        public uint NumActiveVacb { get => ReadHere<uint>(nameof(NumActiveVacb)); set => WriteHere(nameof(NumActiveVacb), value); }

        [Offset(556UL)]
        public uint IdealNodeForWriteBehind { get => ReadHere<uint>(nameof(IdealNodeForWriteBehind)); set => WriteHere(nameof(IdealNodeForWriteBehind), value); }

        [Offset(560UL)]
        public uint IdealNodeNumber { get => ReadHere<uint>(nameof(IdealNodeNumber)); set => WriteHere(nameof(IdealNodeNumber), value); }

        [Offset(568UL)]
        public ListEntry VolSharedCacheMapLinks { get => ReadStructure<ListEntry>(nameof(VolSharedCacheMapLinks)); set => WriteStructure(nameof(VolSharedCacheMapLinks), value); }

        [Offset(584UL)]
        public ListEntry VolLoggedStreamLinks { get => ReadStructure<ListEntry>(nameof(VolLoggedStreamLinks)); set => WriteStructure(nameof(VolLoggedStreamLinks), value); }

        [Offset(600UL)]
        public IntPtr PrivateVolumeCacheMap { get => ReadHere<IntPtr>(nameof(PrivateVolumeCacheMap)); set => WriteHere(nameof(PrivateVolumeCacheMap), value); }

        [Offset(608UL)]
        public uint SectionSizeIncrement { get => ReadHere<uint>(nameof(SectionSizeIncrement)); set => WriteHere(nameof(SectionSizeIncrement), value); }

        public SharedCacheMap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SharedCacheMap>();
        }
    }
}