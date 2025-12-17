using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CMHIVE")]
    public sealed class Cmhive : DynamicStructure
    {
        [Offset(0UL)]
        public Hhive Hive { get => ReadStructure<Hhive>(nameof(Hive)); set => WriteStructure(nameof(Hive), value); }

        [Offset(1544UL)]
        [Length(6)]
        public DynamicArray FileHandles { get => ReadStructure<DynamicArray>(nameof(FileHandles)); set => WriteStructure(nameof(FileHandles), value); }

        [Offset(1592UL)]
        public ListEntry NotifyList { get => ReadStructure<ListEntry>(nameof(NotifyList)); set => WriteStructure(nameof(NotifyList), value); }

        [Offset(1608UL)]
        public ListEntry HiveList { get => ReadStructure<ListEntry>(nameof(HiveList)); set => WriteStructure(nameof(HiveList), value); }

        [Offset(1624UL)]
        public ListEntry PreloadedHiveList { get => ReadStructure<ListEntry>(nameof(PreloadedHiveList)); set => WriteStructure(nameof(PreloadedHiveList), value); }

        [Offset(1640UL)]
        public ExRundownRef HiveRundown { get => ReadStructure<ExRundownRef>(nameof(HiveRundown)); set => WriteStructure(nameof(HiveRundown), value); }

        [Offset(1648UL)]
        public IntPtr KcbCacheTable { get => ReadHere<IntPtr>(nameof(KcbCacheTable)); set => WriteHere(nameof(KcbCacheTable), value); }

        [Offset(1656UL)]
        public uint KcbCacheTableSize { get => ReadHere<uint>(nameof(KcbCacheTableSize)); set => WriteHere(nameof(KcbCacheTableSize), value); }

        [Offset(1664UL)]
        public IntPtr DeletedKcbTable { get => ReadHere<IntPtr>(nameof(DeletedKcbTable)); set => WriteHere(nameof(DeletedKcbTable), value); }

        [Offset(1672UL)]
        public uint DeletedKcbTableSize { get => ReadHere<uint>(nameof(DeletedKcbTableSize)); set => WriteHere(nameof(DeletedKcbTableSize), value); }

        [Offset(1676UL)]
        public uint Identity { get => ReadHere<uint>(nameof(Identity)); set => WriteHere(nameof(Identity), value); }

        [Offset(1680UL)]
        public CmsiRwLock HiveLock { get => ReadStructure<CmsiRwLock>(nameof(HiveLock)); set => WriteStructure(nameof(HiveLock), value); }

        [Offset(1688UL)]
        public RtlBitmap FlushDirtyVector { get => ReadStructure<RtlBitmap>(nameof(FlushDirtyVector)); set => WriteStructure(nameof(FlushDirtyVector), value); }

        [Offset(1704UL)]
        public uint FlushDirtyVectorSize { get => ReadHere<uint>(nameof(FlushDirtyVectorSize)); set => WriteHere(nameof(FlushDirtyVectorSize), value); }

        [Offset(1712UL)]
        public IntPtr FlushLogEntryOffsetArray { get => ReadHere<IntPtr>(nameof(FlushLogEntryOffsetArray)); set => WriteHere(nameof(FlushLogEntryOffsetArray), value); }

        [Offset(1720UL)]
        public uint FlushLogEntryOffsetArrayCount { get => ReadHere<uint>(nameof(FlushLogEntryOffsetArrayCount)); set => WriteHere(nameof(FlushLogEntryOffsetArrayCount), value); }

        [Offset(1724UL)]
        public uint FlushLogEntrySize { get => ReadHere<uint>(nameof(FlushLogEntrySize)); set => WriteHere(nameof(FlushLogEntrySize), value); }

        [Offset(1728UL)]
        public uint FlushHiveTruncated { get => ReadHere<uint>(nameof(FlushHiveTruncated)); set => WriteHere(nameof(FlushHiveTruncated), value); }

        [Offset(1732UL)]
        public byte FlushBaseBlockDirty { get => ReadHere<byte>(nameof(FlushBaseBlockDirty)); set => WriteHere(nameof(FlushBaseBlockDirty), value); }

        [Offset(1736UL)]
        public RtlBitmap CapturedUnreconciledVector { get => ReadStructure<RtlBitmap>(nameof(CapturedUnreconciledVector)); set => WriteStructure(nameof(CapturedUnreconciledVector), value); }

        [Offset(1752UL)]
        public uint CapturedUnreconciledVectorSize { get => ReadHere<uint>(nameof(CapturedUnreconciledVectorSize)); set => WriteHere(nameof(CapturedUnreconciledVectorSize), value); }

        [Offset(1760UL)]
        public IntPtr UnreconciledOffsetArray { get => ReadHere<IntPtr>(nameof(UnreconciledOffsetArray)); set => WriteHere(nameof(UnreconciledOffsetArray), value); }

        [Offset(1768UL)]
        public uint UnreconciledOffsetArrayCount { get => ReadHere<uint>(nameof(UnreconciledOffsetArrayCount)); set => WriteHere(nameof(UnreconciledOffsetArrayCount), value); }

        [Offset(1776UL)]
        public IntPtr UnreconciledBaseBlock { get => ReadHere<IntPtr>(nameof(UnreconciledBaseBlock)); set => WriteHere(nameof(UnreconciledBaseBlock), value); }

        [Offset(1784UL)]
        public ExPushLock SecurityLock { get => ReadStructure<ExPushLock>(nameof(SecurityLock)); set => WriteStructure(nameof(SecurityLock), value); }

        [Offset(1792UL)]
        public uint LastShrinkHiveSize { get => ReadHere<uint>(nameof(LastShrinkHiveSize)); set => WriteHere(nameof(LastShrinkHiveSize), value); }

        [Offset(1800UL)]
        public LargeInteger ActualFileSize { get => ReadStructure<LargeInteger>(nameof(ActualFileSize)); set => WriteStructure(nameof(ActualFileSize), value); }

        [Offset(1808UL)]
        [Length(2)]
        public DynamicArray LogFileSizes { get => ReadStructure<DynamicArray>(nameof(LogFileSizes)); set => WriteStructure(nameof(LogFileSizes), value); }

        [Offset(1824UL)]
        public UnicodeString FileFullPath { get => ReadStructure<UnicodeString>(nameof(FileFullPath)); set => WriteStructure(nameof(FileFullPath), value); }

        [Offset(1840UL)]
        public UnicodeString FileUserName { get => ReadStructure<UnicodeString>(nameof(FileUserName)); set => WriteStructure(nameof(FileUserName), value); }

        [Offset(1856UL)]
        public UnicodeString HiveRootPath { get => ReadStructure<UnicodeString>(nameof(HiveRootPath)); set => WriteStructure(nameof(HiveRootPath), value); }

        [Offset(1872UL)]
        public uint SecurityCount { get => ReadHere<uint>(nameof(SecurityCount)); set => WriteHere(nameof(SecurityCount), value); }

        [Offset(1876UL)]
        public uint SecurityCacheSize { get => ReadHere<uint>(nameof(SecurityCacheSize)); set => WriteHere(nameof(SecurityCacheSize), value); }

        [Offset(1880UL)]
        public int SecurityHitHint { get => ReadHere<int>(nameof(SecurityHitHint)); set => WriteHere(nameof(SecurityHitHint), value); }

        [Offset(1888UL)]
        public IntPtr SecurityCache { get => ReadHere<IntPtr>(nameof(SecurityCache)); set => WriteHere(nameof(SecurityCache), value); }

        [Offset(1896UL)]
        [Length(64)]
        public DynamicArray SecurityHash { get => ReadStructure<DynamicArray>(nameof(SecurityHash)); set => WriteStructure(nameof(SecurityHash), value); }

        [Offset(2920UL)]
        public uint UnloadEventCount { get => ReadHere<uint>(nameof(UnloadEventCount)); set => WriteHere(nameof(UnloadEventCount), value); }

        [Offset(2928UL)]
        public IntPtr UnloadEventArray { get => ReadHere<IntPtr>(nameof(UnloadEventArray)); set => WriteHere(nameof(UnloadEventArray), value); }

        [Offset(2936UL)]
        public IntPtr RootKcb { get => ReadHere<IntPtr>(nameof(RootKcb)); set => WriteHere(nameof(RootKcb), value); }

        [Offset(2944UL)]
        public byte Frozen { get => ReadHere<byte>(nameof(Frozen)); set => WriteHere(nameof(Frozen), value); }

        [Offset(2952UL)]
        public CmDirtyVectorLog DirtyVectorLog { get => ReadStructure<CmDirtyVectorLog>(nameof(DirtyVectorLog)); set => WriteStructure(nameof(DirtyVectorLog), value); }

        [Offset(4112UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(4120UL)]
        public ListEntry TrustClassEntry { get => ReadStructure<ListEntry>(nameof(TrustClassEntry)); set => WriteStructure(nameof(TrustClassEntry), value); }

        [Offset(4136UL)]
        public ulong DirtyTime { get => ReadHere<ulong>(nameof(DirtyTime)); set => WriteHere(nameof(DirtyTime), value); }

        [Offset(4144UL)]
        public ulong UnreconciledTime { get => ReadHere<ulong>(nameof(UnreconciledTime)); set => WriteHere(nameof(UnreconciledTime), value); }

        [Offset(4152UL)]
        public IntPtr CmRm { get => ReadHere<IntPtr>(nameof(CmRm)); set => WriteHere(nameof(CmRm), value); }

        [Offset(4160UL)]
        public uint CmRmInitFailPoint { get => ReadHere<uint>(nameof(CmRmInitFailPoint)); set => WriteHere(nameof(CmRmInitFailPoint), value); }

        [Offset(4164UL)]
        public int CmRmInitFailStatus { get => ReadHere<int>(nameof(CmRmInitFailStatus)); set => WriteHere(nameof(CmRmInitFailStatus), value); }

        [Offset(4168UL)]
        public IntPtr CreatorOwner { get => ReadHere<IntPtr>(nameof(CreatorOwner)); set => WriteHere(nameof(CreatorOwner), value); }

        [Offset(4176UL)]
        public IntPtr RundownThread { get => ReadHere<IntPtr>(nameof(RundownThread)); set => WriteHere(nameof(RundownThread), value); }

        [Offset(4184UL)]
        public LargeInteger LastWriteTime { get => ReadStructure<LargeInteger>(nameof(LastWriteTime)); set => WriteStructure(nameof(LastWriteTime), value); }

        [Offset(4192UL)]
        public HiveWriteWaitQueue FlushQueue { get => ReadStructure<HiveWriteWaitQueue>(nameof(FlushQueue)); set => WriteStructure(nameof(FlushQueue), value); }

        [Offset(4208UL)]
        public HiveWriteWaitQueue ReconcileQueue { get => ReadStructure<HiveWriteWaitQueue>(nameof(ReconcileQueue)); set => WriteStructure(nameof(ReconcileQueue), value); }

        [Offset(4224UL)]
        public uint FlushFlags { get => ReadHere<uint>(nameof(FlushFlags)); set => WriteHere(nameof(FlushFlags), value); }

        [Offset(4224UL)]
        public uint PrimaryFilePurged { get => ReadHere<uint>(nameof(PrimaryFilePurged)); set => WriteHere(nameof(PrimaryFilePurged), value); }

        [Offset(4224UL)]
        public uint DiskFileBad { get => ReadHere<uint>(nameof(DiskFileBad)); set => WriteHere(nameof(DiskFileBad), value); }

        [Offset(4228UL)]
        public uint PrimaryFileSizeBeforeLastFlush { get => ReadHere<uint>(nameof(PrimaryFileSizeBeforeLastFlush)); set => WriteHere(nameof(PrimaryFileSizeBeforeLastFlush), value); }

        [Offset(4232UL)]
        public int ReferenceCount { get => ReadHere<int>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(4236UL)]
        public int UnloadHistoryIndex { get => ReadHere<int>(nameof(UnloadHistoryIndex)); set => WriteHere(nameof(UnloadHistoryIndex), value); }

        [Offset(4240UL)]
        [Length(128)]
        public DynamicArray UnloadHistory { get => ReadStructure<DynamicArray>(nameof(UnloadHistory)); set => WriteStructure(nameof(UnloadHistory), value); }

        [Offset(4752UL)]
        public uint BootStart { get => ReadHere<uint>(nameof(BootStart)); set => WriteHere(nameof(BootStart), value); }

        [Offset(4756UL)]
        public uint UnaccessedStart { get => ReadHere<uint>(nameof(UnaccessedStart)); set => WriteHere(nameof(UnaccessedStart), value); }

        [Offset(4760UL)]
        public uint UnaccessedEnd { get => ReadHere<uint>(nameof(UnaccessedEnd)); set => WriteHere(nameof(UnaccessedEnd), value); }

        [Offset(4764UL)]
        public uint LoadedKeyCount { get => ReadHere<uint>(nameof(LoadedKeyCount)); set => WriteHere(nameof(LoadedKeyCount), value); }

        [Offset(4768UL)]
        public uint HandleClosePending { get => ReadHere<uint>(nameof(HandleClosePending)); set => WriteHere(nameof(HandleClosePending), value); }

        [Offset(4776UL)]
        public ExPushLock HandleClosePendingEvent { get => ReadStructure<ExPushLock>(nameof(HandleClosePendingEvent)); set => WriteStructure(nameof(HandleClosePendingEvent), value); }

        [Offset(4784UL)]
        public byte FinalFlushSucceeded { get => ReadHere<byte>(nameof(FinalFlushSucceeded)); set => WriteHere(nameof(FinalFlushSucceeded), value); }

        [Offset(4792UL)]
        public IntPtr VolumeContext { get => ReadHere<IntPtr>(nameof(VolumeContext)); set => WriteHere(nameof(VolumeContext), value); }

        [Offset(4800UL)]
        public uint LateUnloadWorkItemState { get => ReadHere<uint>(nameof(LateUnloadWorkItemState)); set => WriteHere(nameof(LateUnloadWorkItemState), value); }

        [Offset(4808UL)]
        public ExPushLock LateUnloadFinishedEvent { get => ReadStructure<ExPushLock>(nameof(LateUnloadFinishedEvent)); set => WriteStructure(nameof(LateUnloadFinishedEvent), value); }

        [Offset(4816UL)]
        public IntPtr LateUnloadWorkItem { get => ReadHere<IntPtr>(nameof(LateUnloadWorkItem)); set => WriteHere(nameof(LateUnloadWorkItem), value); }

        public Cmhive(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Cmhive>();
        }
    }
}