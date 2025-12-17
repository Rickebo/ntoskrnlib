#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 728)]
    public partial struct _KTRANSACTION
    {
        [FieldOffset(0)]
        public _KEVENT OutcomeEvent;
        [FieldOffset(24)]
        public uint cookie;
        [FieldOffset(32)]
        public _KMUTANT Mutex;
        [FieldOffset(88)]
        public IntPtr TreeTx;
        [FieldOffset(96)]
        public _KTMOBJECT_NAMESPACE_LINK GlobalNamespaceLink;
        [FieldOffset(136)]
        public _KTMOBJECT_NAMESPACE_LINK TmNamespaceLink;
        [FieldOffset(176)]
        public _GUID UOW;
        [FieldOffset(192)]
        public uint State;
        [FieldOffset(196)]
        public uint Flags;
        [FieldOffset(200)]
        public _LIST_ENTRY EnlistmentHead;
        [FieldOffset(216)]
        public uint EnlistmentCount;
        [FieldOffset(220)]
        public uint RecoverableEnlistmentCount;
        [FieldOffset(224)]
        public uint PrePrepareRequiredEnlistmentCount;
        [FieldOffset(228)]
        public uint PrepareRequiredEnlistmentCount;
        [FieldOffset(232)]
        public uint OutcomeRequiredEnlistmentCount;
        [FieldOffset(236)]
        public uint PendingResponses;
        [FieldOffset(240)]
        public IntPtr SuperiorEnlistment;
        [FieldOffset(248)]
        public _CLS_LSN LastLsn;
        [FieldOffset(256)]
        public _LIST_ENTRY PromotedEntry;
        [FieldOffset(272)]
        public IntPtr PromoterTransaction;
        [FieldOffset(280)]
        public IntPtr PromotePropagation;
        [FieldOffset(288)]
        public uint IsolationLevel;
        [FieldOffset(292)]
        public uint IsolationFlags;
        [FieldOffset(296)]
        public _LARGE_INTEGER Timeout;
        [FieldOffset(304)]
        public _UNICODE_STRING Description;
        [FieldOffset(320)]
        public IntPtr RollbackThread;
        [FieldOffset(328)]
        public _WORK_QUEUE_ITEM RollbackWorkItem;
        [FieldOffset(360)]
        public _KDPC RollbackDpc;
        [FieldOffset(424)]
        public _KTIMER RollbackTimer;
        [FieldOffset(488)]
        public _LIST_ENTRY LsnOrderedEntry;
        [FieldOffset(504)]
        public uint Outcome;
        [FieldOffset(512)]
        public IntPtr Tm;
        [FieldOffset(520)]
        public long CommitReservation;
        [FieldOffset(528)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public _KTRANSACTION_HISTORY[] TransactionHistory;
        [FieldOffset(608)]
        public uint TransactionHistoryCount;
        [FieldOffset(616)]
        public IntPtr DTCPrivateInformation;
        [FieldOffset(624)]
        public uint DTCPrivateInformationLength;
        [FieldOffset(632)]
        public _KMUTANT DTCPrivateInformationMutex;
        [FieldOffset(688)]
        public IntPtr PromotedTxSelfHandle;
        [FieldOffset(696)]
        public uint PendingPromotionCount;
        [FieldOffset(704)]
        public _KEVENT PromotionCompletedEvent;
    }
}