using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ALPC_PORT")]
    public sealed class AlpcPort : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry PortListEntry { get => ReadStructure<ListEntry>(nameof(PortListEntry)); set => WriteStructure(nameof(PortListEntry), value); }

        [Offset(16UL)]
        public IntPtr CommunicationInfo { get => ReadHere<IntPtr>(nameof(CommunicationInfo)); set => WriteHere(nameof(CommunicationInfo), value); }

        [Offset(24UL)]
        public IntPtr OwnerProcess { get => ReadHere<IntPtr>(nameof(OwnerProcess)); set => WriteHere(nameof(OwnerProcess), value); }

        [Offset(32UL)]
        public IntPtr CompletionPort { get => ReadHere<IntPtr>(nameof(CompletionPort)); set => WriteHere(nameof(CompletionPort), value); }

        [Offset(40UL)]
        public IntPtr CompletionKey { get => ReadHere<IntPtr>(nameof(CompletionKey)); set => WriteHere(nameof(CompletionKey), value); }

        [Offset(48UL)]
        public IntPtr CompletionPacketLookaside { get => ReadHere<IntPtr>(nameof(CompletionPacketLookaside)); set => WriteHere(nameof(CompletionPacketLookaside), value); }

        [Offset(56UL)]
        public IntPtr PortContext { get => ReadHere<IntPtr>(nameof(PortContext)); set => WriteHere(nameof(PortContext), value); }

        [Offset(64UL)]
        public SecurityClientContext StaticSecurity { get => ReadStructure<SecurityClientContext>(nameof(StaticSecurity)); set => WriteStructure(nameof(StaticSecurity), value); }

        [Offset(136UL)]
        public ExPushLock IncomingQueueLock { get => ReadStructure<ExPushLock>(nameof(IncomingQueueLock)); set => WriteStructure(nameof(IncomingQueueLock), value); }

        [Offset(144UL)]
        public ListEntry MainQueue { get => ReadStructure<ListEntry>(nameof(MainQueue)); set => WriteStructure(nameof(MainQueue), value); }

        [Offset(160UL)]
        public ListEntry LargeMessageQueue { get => ReadStructure<ListEntry>(nameof(LargeMessageQueue)); set => WriteStructure(nameof(LargeMessageQueue), value); }

        [Offset(176UL)]
        public ExPushLock PendingQueueLock { get => ReadStructure<ExPushLock>(nameof(PendingQueueLock)); set => WriteStructure(nameof(PendingQueueLock), value); }

        [Offset(184UL)]
        public ListEntry PendingQueue { get => ReadStructure<ListEntry>(nameof(PendingQueue)); set => WriteStructure(nameof(PendingQueue), value); }

        [Offset(200UL)]
        public ExPushLock DirectQueueLock { get => ReadStructure<ExPushLock>(nameof(DirectQueueLock)); set => WriteStructure(nameof(DirectQueueLock), value); }

        [Offset(208UL)]
        public ListEntry DirectQueue { get => ReadStructure<ListEntry>(nameof(DirectQueue)); set => WriteStructure(nameof(DirectQueue), value); }

        [Offset(224UL)]
        public ExPushLock WaitQueueLock { get => ReadStructure<ExPushLock>(nameof(WaitQueueLock)); set => WriteStructure(nameof(WaitQueueLock), value); }

        [Offset(232UL)]
        public ListEntry WaitQueue { get => ReadStructure<ListEntry>(nameof(WaitQueue)); set => WriteStructure(nameof(WaitQueue), value); }

        [Offset(248UL)]
        public IntPtr Semaphore { get => ReadHere<IntPtr>(nameof(Semaphore)); set => WriteHere(nameof(Semaphore), value); }

        [Offset(248UL)]
        public IntPtr DummyEvent { get => ReadHere<IntPtr>(nameof(DummyEvent)); set => WriteHere(nameof(DummyEvent), value); }

        [Offset(256UL)]
        public AlpcPortAttributes PortAttributes { get => ReadStructure<AlpcPortAttributes>(nameof(PortAttributes)); set => WriteStructure(nameof(PortAttributes), value); }

        [Offset(328UL)]
        public ExPushLock ResourceListLock { get => ReadStructure<ExPushLock>(nameof(ResourceListLock)); set => WriteStructure(nameof(ResourceListLock), value); }

        [Offset(336UL)]
        public ListEntry ResourceListHead { get => ReadStructure<ListEntry>(nameof(ResourceListHead)); set => WriteStructure(nameof(ResourceListHead), value); }

        [Offset(352UL)]
        public ExPushLock PortObjectLock { get => ReadStructure<ExPushLock>(nameof(PortObjectLock)); set => WriteStructure(nameof(PortObjectLock), value); }

        [Offset(360UL)]
        public IntPtr CompletionList { get => ReadHere<IntPtr>(nameof(CompletionList)); set => WriteHere(nameof(CompletionList), value); }

        [Offset(368UL)]
        public IntPtr CallbackObject { get => ReadHere<IntPtr>(nameof(CallbackObject)); set => WriteHere(nameof(CallbackObject), value); }

        [Offset(376UL)]
        public IntPtr CallbackContext { get => ReadHere<IntPtr>(nameof(CallbackContext)); set => WriteHere(nameof(CallbackContext), value); }

        [Offset(384UL)]
        public ListEntry CanceledQueue { get => ReadStructure<ListEntry>(nameof(CanceledQueue)); set => WriteStructure(nameof(CanceledQueue), value); }

        [Offset(400UL)]
        public int SequenceNo { get => ReadHere<int>(nameof(SequenceNo)); set => WriteHere(nameof(SequenceNo), value); }

        [Offset(404UL)]
        public int ReferenceNo { get => ReadHere<int>(nameof(ReferenceNo)); set => WriteHere(nameof(ReferenceNo), value); }

        [Offset(408UL)]
        public IntPtr ReferenceNoWait { get => ReadHere<IntPtr>(nameof(ReferenceNoWait)); set => WriteHere(nameof(ReferenceNoWait), value); }

        [Offset(416UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(424UL)]
        public IntPtr TargetQueuePort { get => ReadHere<IntPtr>(nameof(TargetQueuePort)); set => WriteHere(nameof(TargetQueuePort), value); }

        [Offset(432UL)]
        public IntPtr TargetSequencePort { get => ReadHere<IntPtr>(nameof(TargetSequencePort)); set => WriteHere(nameof(TargetSequencePort), value); }

        [Offset(440UL)]
        public IntPtr CachedMessage { get => ReadHere<IntPtr>(nameof(CachedMessage)); set => WriteHere(nameof(CachedMessage), value); }

        [Offset(448UL)]
        public uint MainQueueLength { get => ReadHere<uint>(nameof(MainQueueLength)); set => WriteHere(nameof(MainQueueLength), value); }

        [Offset(452UL)]
        public uint LargeMessageQueueLength { get => ReadHere<uint>(nameof(LargeMessageQueueLength)); set => WriteHere(nameof(LargeMessageQueueLength), value); }

        [Offset(456UL)]
        public uint PendingQueueLength { get => ReadHere<uint>(nameof(PendingQueueLength)); set => WriteHere(nameof(PendingQueueLength), value); }

        [Offset(460UL)]
        public uint DirectQueueLength { get => ReadHere<uint>(nameof(DirectQueueLength)); set => WriteHere(nameof(DirectQueueLength), value); }

        [Offset(464UL)]
        public uint CanceledQueueLength { get => ReadHere<uint>(nameof(CanceledQueueLength)); set => WriteHere(nameof(CanceledQueueLength), value); }

        [Offset(468UL)]
        public uint WaitQueueLength { get => ReadHere<uint>(nameof(WaitQueueLength)); set => WriteHere(nameof(WaitQueueLength), value); }

        public AlpcPort(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AlpcPort>();
        }
    }
}