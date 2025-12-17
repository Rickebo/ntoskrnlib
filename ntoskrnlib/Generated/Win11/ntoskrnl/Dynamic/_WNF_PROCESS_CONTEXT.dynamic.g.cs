using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_PROCESS_CONTEXT")]
    public sealed class _WNF_PROCESS_CONTEXT : DynamicStructure
    {
        public _WNF_NODE_HEADER Header { get; }
        public IntPtr Process { get; }
        public _LIST_ENTRY WnfProcessesListEntry { get; }
        public byte[] ImplicitScopeInstances { get; }
        public _WNF_LOCK TemporaryNamesListLock { get; }
        public _LIST_ENTRY TemporaryNamesListHead { get; }
        public _WNF_LOCK ProcessSubscriptionListLock { get; }
        public _LIST_ENTRY ProcessSubscriptionListHead { get; }
        public _WNF_LOCK DeliveryPendingListLock { get; }
        public _LIST_ENTRY DeliveryPendingListHead { get; }
        public IntPtr NotificationEvent { get; }

        public _WNF_PROCESS_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_PROCESS_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_PROCESS_CONTEXT.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_PROCESS_CONTEXT.Process),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WNF_PROCESS_CONTEXT.WnfProcessesListEntry),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WNF_PROCESS_CONTEXT.ImplicitScopeInstances),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WNF_PROCESS_CONTEXT.TemporaryNamesListLock),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WNF_PROCESS_CONTEXT.TemporaryNamesListHead),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_WNF_PROCESS_CONTEXT.ProcessSubscriptionListLock),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_WNF_PROCESS_CONTEXT.ProcessSubscriptionListHead),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_WNF_PROCESS_CONTEXT.DeliveryPendingListLock),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_WNF_PROCESS_CONTEXT.DeliveryPendingListHead),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_WNF_PROCESS_CONTEXT.NotificationEvent),
                    new ulong[]
                    {
                        128UL
                    }
                }
            };
            Register<_WNF_PROCESS_CONTEXT>((mem, ptr) => new _WNF_PROCESS_CONTEXT(mem, ptr), offsets);
        }
    }
}