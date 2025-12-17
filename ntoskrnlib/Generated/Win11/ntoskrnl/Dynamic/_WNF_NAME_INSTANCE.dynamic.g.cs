using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_NAME_INSTANCE")]
    public sealed class _WNF_NAME_INSTANCE : DynamicStructure
    {
        public _WNF_NODE_HEADER Header { get; }
        public _EX_RUNDOWN_REF RunRef { get; }
        public _RTL_BALANCED_NODE TreeLinks { get; }
        public _WNF_STATE_NAME_STRUCT StateName { get; }
        public IntPtr ScopeInstance { get; }
        public _WNF_STATE_NAME_REGISTRATION StateNameInfo { get; }
        public _WNF_LOCK StateDataLock { get; }
        public IntPtr StateData { get; }
        public uint CurrentChangeStamp { get; }
        public IntPtr PermanentDataStore { get; }
        public _WNF_LOCK StateSubscriptionListLock { get; }
        public _LIST_ENTRY StateSubscriptionListHead { get; }
        public _LIST_ENTRY TemporaryNameListEntry { get; }
        public IntPtr CreatorProcess { get; }
        public int DataSubscribersCount { get; }
        public int CurrentDeliveryCount { get; }

        public _WNF_NAME_INSTANCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_NAME_INSTANCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_NAME_INSTANCE.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.RunRef),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.TreeLinks),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.StateName),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.ScopeInstance),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.StateNameInfo),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.StateDataLock),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.StateData),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.CurrentChangeStamp),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.PermanentDataStore),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.StateSubscriptionListLock),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.StateSubscriptionListHead),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.TemporaryNameListEntry),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.CreatorProcess),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.DataSubscribersCount),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_WNF_NAME_INSTANCE.CurrentDeliveryCount),
                    new ulong[]
                    {
                        164UL
                    }
                }
            };
            Register<_WNF_NAME_INSTANCE>((mem, ptr) => new _WNF_NAME_INSTANCE(mem, ptr), offsets);
        }
    }
}