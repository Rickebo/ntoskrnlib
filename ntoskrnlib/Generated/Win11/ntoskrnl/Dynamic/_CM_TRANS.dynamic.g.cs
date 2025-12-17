using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_TRANS")]
    public sealed class _CM_TRANS : DynamicStructure
    {
        public _LIST_ENTRY TransactionListEntry { get; }
        public _LIST_ENTRY KCBUoWListHead { get; }
        public _LIST_ENTRY LazyCommitListEntry { get; }
        public uint Prepared { get; }
        public uint Aborted { get; }
        public uint Committed { get; }
        public uint Initializing { get; }
        public uint Invalid { get; }
        public uint UseReservation { get; }
        public uint TmCallbacksActive { get; }
        public uint LightWeight { get; }
        public uint Freed1 { get; }
        public uint Freed2 { get; }
        public uint Spare1 { get; }
        public uint Freed { get; }
        public uint Spare { get; }
        public uint TransState { get; }
        public _CM_TRANS_PTR Trans { get; }
        public IntPtr CmRm { get; }
        public IntPtr KtmEnlistmentObject { get; }
        public IntPtr KtmEnlistmentHandle { get; }
        public _GUID KtmUow { get; }
        public ulong StartLsn { get; }
        public uint HiveCount { get; }
        public byte[] HiveArray { get; }

        public _CM_TRANS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_TRANS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_TRANS.TransactionListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_TRANS.KCBUoWListHead),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CM_TRANS.LazyCommitListEntry),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CM_TRANS.Prepared),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_TRANS.Aborted),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_TRANS.Committed),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_TRANS.Initializing),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_TRANS.Invalid),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_TRANS.UseReservation),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_TRANS.TmCallbacksActive),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_TRANS.LightWeight),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_TRANS.Freed1),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_TRANS.Freed2),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_TRANS.Spare1),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_TRANS.Freed),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_TRANS.Spare),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_TRANS.TransState),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_TRANS.Trans),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CM_TRANS.CmRm),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_CM_TRANS.KtmEnlistmentObject),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_CM_TRANS.KtmEnlistmentHandle),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_CM_TRANS.KtmUow),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CM_TRANS.StartLsn),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_CM_TRANS.HiveCount),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_CM_TRANS.HiveArray),
                    new ulong[]
                    {
                        120UL
                    }
                }
            };
            Register<_CM_TRANS>((mem, ptr) => new _CM_TRANS(mem, ptr), offsets);
        }
    }
}