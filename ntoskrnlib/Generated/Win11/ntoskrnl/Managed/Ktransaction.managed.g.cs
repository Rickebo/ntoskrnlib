using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTRANSACTION")]
    public sealed class Ktransaction : DynamicStructure
    {
        [Offset(0UL)]
        public Kevent OutcomeEvent { get => ReadStructure<Kevent>(nameof(OutcomeEvent)); set => WriteStructure(nameof(OutcomeEvent), value); }

        [Offset(24UL)]
        public uint cookie { get => ReadHere<uint>(nameof(cookie)); set => WriteHere(nameof(cookie), value); }

        [Offset(32UL)]
        public Kmutant Mutex { get => ReadStructure<Kmutant>(nameof(Mutex)); set => WriteStructure(nameof(Mutex), value); }

        [Offset(88UL)]
        public IntPtr TreeTx { get => ReadHere<IntPtr>(nameof(TreeTx)); set => WriteHere(nameof(TreeTx), value); }

        [Offset(96UL)]
        public KtmobjectNamespaceLink GlobalNamespaceLink { get => ReadStructure<KtmobjectNamespaceLink>(nameof(GlobalNamespaceLink)); set => WriteStructure(nameof(GlobalNamespaceLink), value); }

        [Offset(136UL)]
        public KtmobjectNamespaceLink TmNamespaceLink { get => ReadStructure<KtmobjectNamespaceLink>(nameof(TmNamespaceLink)); set => WriteStructure(nameof(TmNamespaceLink), value); }

        [Offset(176UL)]
        public Guid UOW { get => ReadStructure<Guid>(nameof(UOW)); set => WriteStructure(nameof(UOW), value); }

        [Offset(192UL)]
        public uint State { get => ReadHere<uint>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(196UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(200UL)]
        public ListEntry EnlistmentHead { get => ReadStructure<ListEntry>(nameof(EnlistmentHead)); set => WriteStructure(nameof(EnlistmentHead), value); }

        [Offset(216UL)]
        public uint EnlistmentCount { get => ReadHere<uint>(nameof(EnlistmentCount)); set => WriteHere(nameof(EnlistmentCount), value); }

        [Offset(220UL)]
        public uint RecoverableEnlistmentCount { get => ReadHere<uint>(nameof(RecoverableEnlistmentCount)); set => WriteHere(nameof(RecoverableEnlistmentCount), value); }

        [Offset(224UL)]
        public uint PrePrepareRequiredEnlistmentCount { get => ReadHere<uint>(nameof(PrePrepareRequiredEnlistmentCount)); set => WriteHere(nameof(PrePrepareRequiredEnlistmentCount), value); }

        [Offset(228UL)]
        public uint PrepareRequiredEnlistmentCount { get => ReadHere<uint>(nameof(PrepareRequiredEnlistmentCount)); set => WriteHere(nameof(PrepareRequiredEnlistmentCount), value); }

        [Offset(232UL)]
        public uint OutcomeRequiredEnlistmentCount { get => ReadHere<uint>(nameof(OutcomeRequiredEnlistmentCount)); set => WriteHere(nameof(OutcomeRequiredEnlistmentCount), value); }

        [Offset(236UL)]
        public uint PendingResponses { get => ReadHere<uint>(nameof(PendingResponses)); set => WriteHere(nameof(PendingResponses), value); }

        [Offset(240UL)]
        public IntPtr SuperiorEnlistment { get => ReadHere<IntPtr>(nameof(SuperiorEnlistment)); set => WriteHere(nameof(SuperiorEnlistment), value); }

        [Offset(248UL)]
        public ClsLsn LastLsn { get => ReadStructure<ClsLsn>(nameof(LastLsn)); set => WriteStructure(nameof(LastLsn), value); }

        [Offset(256UL)]
        public ListEntry PromotedEntry { get => ReadStructure<ListEntry>(nameof(PromotedEntry)); set => WriteStructure(nameof(PromotedEntry), value); }

        [Offset(272UL)]
        public IntPtr PromoterTransaction { get => ReadHere<IntPtr>(nameof(PromoterTransaction)); set => WriteHere(nameof(PromoterTransaction), value); }

        [Offset(280UL)]
        public IntPtr PromotePropagation { get => ReadHere<IntPtr>(nameof(PromotePropagation)); set => WriteHere(nameof(PromotePropagation), value); }

        [Offset(288UL)]
        public uint IsolationLevel { get => ReadHere<uint>(nameof(IsolationLevel)); set => WriteHere(nameof(IsolationLevel), value); }

        [Offset(292UL)]
        public uint IsolationFlags { get => ReadHere<uint>(nameof(IsolationFlags)); set => WriteHere(nameof(IsolationFlags), value); }

        [Offset(296UL)]
        public LargeInteger Timeout { get => ReadStructure<LargeInteger>(nameof(Timeout)); set => WriteStructure(nameof(Timeout), value); }

        [Offset(304UL)]
        public UnicodeString Description { get => ReadStructure<UnicodeString>(nameof(Description)); set => WriteStructure(nameof(Description), value); }

        [Offset(320UL)]
        public IntPtr RollbackThread { get => ReadHere<IntPtr>(nameof(RollbackThread)); set => WriteHere(nameof(RollbackThread), value); }

        [Offset(328UL)]
        public WorkQueueItem RollbackWorkItem { get => ReadStructure<WorkQueueItem>(nameof(RollbackWorkItem)); set => WriteStructure(nameof(RollbackWorkItem), value); }

        [Offset(360UL)]
        public Kdpc RollbackDpc { get => ReadStructure<Kdpc>(nameof(RollbackDpc)); set => WriteStructure(nameof(RollbackDpc), value); }

        [Offset(424UL)]
        public Ktimer RollbackTimer { get => ReadStructure<Ktimer>(nameof(RollbackTimer)); set => WriteStructure(nameof(RollbackTimer), value); }

        [Offset(488UL)]
        public ListEntry LsnOrderedEntry { get => ReadStructure<ListEntry>(nameof(LsnOrderedEntry)); set => WriteStructure(nameof(LsnOrderedEntry), value); }

        [Offset(504UL)]
        public uint Outcome { get => ReadHere<uint>(nameof(Outcome)); set => WriteHere(nameof(Outcome), value); }

        [Offset(512UL)]
        public IntPtr Tm { get => ReadHere<IntPtr>(nameof(Tm)); set => WriteHere(nameof(Tm), value); }

        [Offset(520UL)]
        public long CommitReservation { get => ReadHere<long>(nameof(CommitReservation)); set => WriteHere(nameof(CommitReservation), value); }

        [Offset(528UL)]
        [Length(10)]
        public DynamicArray TransactionHistory { get => ReadStructure<DynamicArray>(nameof(TransactionHistory)); set => WriteStructure(nameof(TransactionHistory), value); }

        [Offset(608UL)]
        public uint TransactionHistoryCount { get => ReadHere<uint>(nameof(TransactionHistoryCount)); set => WriteHere(nameof(TransactionHistoryCount), value); }

        [Offset(616UL)]
        public IntPtr DTCPrivateInformation { get => ReadHere<IntPtr>(nameof(DTCPrivateInformation)); set => WriteHere(nameof(DTCPrivateInformation), value); }

        [Offset(624UL)]
        public uint DTCPrivateInformationLength { get => ReadHere<uint>(nameof(DTCPrivateInformationLength)); set => WriteHere(nameof(DTCPrivateInformationLength), value); }

        [Offset(632UL)]
        public Kmutant DTCPrivateInformationMutex { get => ReadStructure<Kmutant>(nameof(DTCPrivateInformationMutex)); set => WriteStructure(nameof(DTCPrivateInformationMutex), value); }

        [Offset(688UL)]
        public IntPtr PromotedTxSelfHandle { get => ReadHere<IntPtr>(nameof(PromotedTxSelfHandle)); set => WriteHere(nameof(PromotedTxSelfHandle), value); }

        [Offset(696UL)]
        public uint PendingPromotionCount { get => ReadHere<uint>(nameof(PendingPromotionCount)); set => WriteHere(nameof(PendingPromotionCount), value); }

        [Offset(704UL)]
        public Kevent PromotionCompletedEvent { get => ReadStructure<Kevent>(nameof(PromotionCompletedEvent)); set => WriteStructure(nameof(PromotionCompletedEvent), value); }

        public Ktransaction(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Ktransaction>();
        }
    }
}