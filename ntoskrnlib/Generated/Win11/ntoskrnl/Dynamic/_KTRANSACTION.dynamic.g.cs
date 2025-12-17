using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTRANSACTION")]
    public sealed class _KTRANSACTION : DynamicStructure
    {
        public _KEVENT OutcomeEvent { get; }
        public uint cookie { get; }
        public _KMUTANT Mutex { get; }
        public IntPtr TreeTx { get; }
        public _KTMOBJECT_NAMESPACE_LINK GlobalNamespaceLink { get; }
        public _KTMOBJECT_NAMESPACE_LINK TmNamespaceLink { get; }
        public _GUID UOW { get; }
        public uint State { get; }
        public uint Flags { get; }
        public _LIST_ENTRY EnlistmentHead { get; }
        public uint EnlistmentCount { get; }
        public uint RecoverableEnlistmentCount { get; }
        public uint PrePrepareRequiredEnlistmentCount { get; }
        public uint PrepareRequiredEnlistmentCount { get; }
        public uint OutcomeRequiredEnlistmentCount { get; }
        public uint PendingResponses { get; }
        public IntPtr SuperiorEnlistment { get; }
        public _CLS_LSN LastLsn { get; }
        public _LIST_ENTRY PromotedEntry { get; }
        public IntPtr PromoterTransaction { get; }
        public IntPtr PromotePropagation { get; }
        public uint IsolationLevel { get; }
        public uint IsolationFlags { get; }
        public _LARGE_INTEGER Timeout { get; }
        public _UNICODE_STRING Description { get; }
        public IntPtr RollbackThread { get; }
        public _WORK_QUEUE_ITEM RollbackWorkItem { get; }
        public _KDPC RollbackDpc { get; }
        public _KTIMER RollbackTimer { get; }
        public _LIST_ENTRY LsnOrderedEntry { get; }
        public uint Outcome { get; }
        public IntPtr Tm { get; }
        public long CommitReservation { get; }
        public byte[] TransactionHistory { get; }
        public uint TransactionHistoryCount { get; }
        public IntPtr DTCPrivateInformation { get; }
        public uint DTCPrivateInformationLength { get; }
        public _KMUTANT DTCPrivateInformationMutex { get; }
        public IntPtr PromotedTxSelfHandle { get; }
        public uint PendingPromotionCount { get; }
        public _KEVENT PromotionCompletedEvent { get; }

        public _KTRANSACTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTRANSACTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTRANSACTION.OutcomeEvent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTRANSACTION.cookie),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KTRANSACTION.Mutex),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KTRANSACTION.TreeTx),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_KTRANSACTION.GlobalNamespaceLink),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_KTRANSACTION.TmNamespaceLink),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KTRANSACTION.UOW),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_KTRANSACTION.State),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_KTRANSACTION.Flags),
                    new ulong[]
                    {
                        196UL
                    }
                },
                {
                    nameof(_KTRANSACTION.EnlistmentHead),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_KTRANSACTION.EnlistmentCount),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_KTRANSACTION.RecoverableEnlistmentCount),
                    new ulong[]
                    {
                        220UL
                    }
                },
                {
                    nameof(_KTRANSACTION.PrePrepareRequiredEnlistmentCount),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_KTRANSACTION.PrepareRequiredEnlistmentCount),
                    new ulong[]
                    {
                        228UL
                    }
                },
                {
                    nameof(_KTRANSACTION.OutcomeRequiredEnlistmentCount),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_KTRANSACTION.PendingResponses),
                    new ulong[]
                    {
                        236UL
                    }
                },
                {
                    nameof(_KTRANSACTION.SuperiorEnlistment),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_KTRANSACTION.LastLsn),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_KTRANSACTION.PromotedEntry),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_KTRANSACTION.PromoterTransaction),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_KTRANSACTION.PromotePropagation),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_KTRANSACTION.IsolationLevel),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_KTRANSACTION.IsolationFlags),
                    new ulong[]
                    {
                        292UL
                    }
                },
                {
                    nameof(_KTRANSACTION.Timeout),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_KTRANSACTION.Description),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_KTRANSACTION.RollbackThread),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KTRANSACTION.RollbackWorkItem),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_KTRANSACTION.RollbackDpc),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_KTRANSACTION.RollbackTimer),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_KTRANSACTION.LsnOrderedEntry),
                    new ulong[]
                    {
                        488UL
                    }
                },
                {
                    nameof(_KTRANSACTION.Outcome),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_KTRANSACTION.Tm),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_KTRANSACTION.CommitReservation),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_KTRANSACTION.TransactionHistory),
                    new ulong[]
                    {
                        528UL
                    }
                },
                {
                    nameof(_KTRANSACTION.TransactionHistoryCount),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_KTRANSACTION.DTCPrivateInformation),
                    new ulong[]
                    {
                        616UL
                    }
                },
                {
                    nameof(_KTRANSACTION.DTCPrivateInformationLength),
                    new ulong[]
                    {
                        624UL
                    }
                },
                {
                    nameof(_KTRANSACTION.DTCPrivateInformationMutex),
                    new ulong[]
                    {
                        632UL
                    }
                },
                {
                    nameof(_KTRANSACTION.PromotedTxSelfHandle),
                    new ulong[]
                    {
                        688UL
                    }
                },
                {
                    nameof(_KTRANSACTION.PendingPromotionCount),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(_KTRANSACTION.PromotionCompletedEvent),
                    new ulong[]
                    {
                        704UL
                    }
                }
            };
            Register<_KTRANSACTION>((mem, ptr) => new _KTRANSACTION(mem, ptr), offsets);
        }
    }
}