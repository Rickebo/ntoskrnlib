using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_SUBSCRIPTION")]
    public sealed class _WNF_SUBSCRIPTION : DynamicStructure
    {
        public _WNF_NODE_HEADER Header { get; }
        public _EX_RUNDOWN_REF RunRef { get; }
        public ulong SubscriptionId { get; }
        public _LIST_ENTRY ProcessSubscriptionListEntry { get; }
        public IntPtr Process { get; }
        public IntPtr NameInstance { get; }
        public _WNF_STATE_NAME_STRUCT StateName { get; }
        public _LIST_ENTRY StateSubscriptionListEntry { get; }
        public ulong CallbackRoutine { get; }
        public IntPtr CallbackContext { get; }
        public uint CurrentChangeStamp { get; }
        public uint SubscribedEventSet { get; }
        public _LIST_ENTRY PendingSubscriptionListEntry { get; }
        public uint SubscriptionState { get; }
        public uint SignaledEventSet { get; }
        public uint InDeliveryEventSet { get; }

        public _WNF_SUBSCRIPTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_SUBSCRIPTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_SUBSCRIPTION.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.RunRef),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.SubscriptionId),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.ProcessSubscriptionListEntry),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.Process),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.NameInstance),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.StateName),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.StateSubscriptionListEntry),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.CallbackRoutine),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.CallbackContext),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.CurrentChangeStamp),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.SubscribedEventSet),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.PendingSubscriptionListEntry),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.SubscriptionState),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.SignaledEventSet),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_WNF_SUBSCRIPTION.InDeliveryEventSet),
                    new ulong[]
                    {
                        128UL
                    }
                }
            };
            Register<_WNF_SUBSCRIPTION>((mem, ptr) => new _WNF_SUBSCRIPTION(mem, ptr), offsets);
        }
    }
}