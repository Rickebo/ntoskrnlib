using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTM")]
    public sealed class Ktm : DynamicStructure
    {
        [Offset(0UL)]
        public uint cookie { get => ReadHere<uint>(nameof(cookie)); set => WriteHere(nameof(cookie), value); }

        [Offset(8UL)]
        public Kmutant Mutex { get => ReadStructure<Kmutant>(nameof(Mutex)); set => WriteStructure(nameof(Mutex), value); }

        [Offset(64UL)]
        public uint State { get => ReadHere<uint>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(72UL)]
        public KtmobjectNamespaceLink NamespaceLink { get => ReadStructure<KtmobjectNamespaceLink>(nameof(NamespaceLink)); set => WriteStructure(nameof(NamespaceLink), value); }

        [Offset(112UL)]
        public Guid TmIdentity { get => ReadStructure<Guid>(nameof(TmIdentity)); set => WriteStructure(nameof(TmIdentity), value); }

        [Offset(128UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(132UL)]
        public uint VolatileFlags { get => ReadHere<uint>(nameof(VolatileFlags)); set => WriteHere(nameof(VolatileFlags), value); }

        [Offset(136UL)]
        public UnicodeString LogFileName { get => ReadStructure<UnicodeString>(nameof(LogFileName)); set => WriteStructure(nameof(LogFileName), value); }

        [Offset(152UL)]
        public IntPtr LogFileObject { get => ReadHere<IntPtr>(nameof(LogFileObject)); set => WriteHere(nameof(LogFileObject), value); }

        [Offset(160UL)]
        public IntPtr MarshallingContext { get => ReadHere<IntPtr>(nameof(MarshallingContext)); set => WriteHere(nameof(MarshallingContext), value); }

        [Offset(168UL)]
        public IntPtr LogManagementContext { get => ReadHere<IntPtr>(nameof(LogManagementContext)); set => WriteHere(nameof(LogManagementContext), value); }

        [Offset(176UL)]
        public KtmobjectNamespace Transactions { get => ReadStructure<KtmobjectNamespace>(nameof(Transactions)); set => WriteStructure(nameof(Transactions), value); }

        [Offset(344UL)]
        public KtmobjectNamespace ResourceManagers { get => ReadStructure<KtmobjectNamespace>(nameof(ResourceManagers)); set => WriteStructure(nameof(ResourceManagers), value); }

        [Offset(512UL)]
        public Kmutant LsnOrderedMutex { get => ReadStructure<Kmutant>(nameof(LsnOrderedMutex)); set => WriteStructure(nameof(LsnOrderedMutex), value); }

        [Offset(568UL)]
        public ListEntry LsnOrderedList { get => ReadStructure<ListEntry>(nameof(LsnOrderedList)); set => WriteStructure(nameof(LsnOrderedList), value); }

        [Offset(584UL)]
        public LargeInteger CommitVirtualClock { get => ReadStructure<LargeInteger>(nameof(CommitVirtualClock)); set => WriteStructure(nameof(CommitVirtualClock), value); }

        [Offset(592UL)]
        public FastMutex CommitVirtualClockMutex { get => ReadStructure<FastMutex>(nameof(CommitVirtualClockMutex)); set => WriteStructure(nameof(CommitVirtualClockMutex), value); }

        [Offset(648UL)]
        public ClsLsn BaseLsn { get => ReadStructure<ClsLsn>(nameof(BaseLsn)); set => WriteStructure(nameof(BaseLsn), value); }

        [Offset(656UL)]
        public ClsLsn CurrentReadLsn { get => ReadStructure<ClsLsn>(nameof(CurrentReadLsn)); set => WriteStructure(nameof(CurrentReadLsn), value); }

        [Offset(664UL)]
        public ClsLsn LastRecoveredLsn { get => ReadStructure<ClsLsn>(nameof(LastRecoveredLsn)); set => WriteStructure(nameof(LastRecoveredLsn), value); }

        [Offset(672UL)]
        public IntPtr TmRmHandle { get => ReadHere<IntPtr>(nameof(TmRmHandle)); set => WriteHere(nameof(TmRmHandle), value); }

        [Offset(680UL)]
        public IntPtr TmRm { get => ReadHere<IntPtr>(nameof(TmRm)); set => WriteHere(nameof(TmRm), value); }

        [Offset(688UL)]
        public Kevent LogFullNotifyEvent { get => ReadStructure<Kevent>(nameof(LogFullNotifyEvent)); set => WriteStructure(nameof(LogFullNotifyEvent), value); }

        [Offset(712UL)]
        public WorkQueueItem CheckpointWorkItem { get => ReadStructure<WorkQueueItem>(nameof(CheckpointWorkItem)); set => WriteStructure(nameof(CheckpointWorkItem), value); }

        [Offset(744UL)]
        public ClsLsn CheckpointTargetLsn { get => ReadStructure<ClsLsn>(nameof(CheckpointTargetLsn)); set => WriteStructure(nameof(CheckpointTargetLsn), value); }

        [Offset(752UL)]
        public WorkQueueItem LogFullCompletedWorkItem { get => ReadStructure<WorkQueueItem>(nameof(LogFullCompletedWorkItem)); set => WriteStructure(nameof(LogFullCompletedWorkItem), value); }

        [Offset(784UL)]
        public Eresource LogWriteResource { get => ReadStructure<Eresource>(nameof(LogWriteResource)); set => WriteStructure(nameof(LogWriteResource), value); }

        [Offset(888UL)]
        public uint LogFlags { get => ReadHere<uint>(nameof(LogFlags)); set => WriteHere(nameof(LogFlags), value); }

        [Offset(892UL)]
        public int LogFullStatus { get => ReadHere<int>(nameof(LogFullStatus)); set => WriteHere(nameof(LogFullStatus), value); }

        [Offset(896UL)]
        public int RecoveryStatus { get => ReadHere<int>(nameof(RecoveryStatus)); set => WriteHere(nameof(RecoveryStatus), value); }

        [Offset(904UL)]
        public ClsLsn LastCheckBaseLsn { get => ReadStructure<ClsLsn>(nameof(LastCheckBaseLsn)); set => WriteStructure(nameof(LastCheckBaseLsn), value); }

        [Offset(912UL)]
        public ListEntry RestartOrderedList { get => ReadStructure<ListEntry>(nameof(RestartOrderedList)); set => WriteStructure(nameof(RestartOrderedList), value); }

        [Offset(928UL)]
        public WorkQueueItem OfflineWorkItem { get => ReadStructure<WorkQueueItem>(nameof(OfflineWorkItem)); set => WriteStructure(nameof(OfflineWorkItem), value); }

        public Ktm(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Ktm>();
        }
    }
}