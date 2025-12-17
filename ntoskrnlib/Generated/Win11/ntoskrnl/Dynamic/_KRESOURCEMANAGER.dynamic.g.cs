using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KRESOURCEMANAGER")]
    public sealed class _KRESOURCEMANAGER : DynamicStructure
    {
        public _KEVENT NotificationAvailable { get; }
        public uint cookie { get; }
        public uint State { get; }
        public uint Flags { get; }
        public _KMUTANT Mutex { get; }
        public _KTMOBJECT_NAMESPACE_LINK NamespaceLink { get; }
        public _GUID RmId { get; }
        public _KQUEUE NotificationQueue { get; }
        public _KMUTANT NotificationMutex { get; }
        public _LIST_ENTRY EnlistmentHead { get; }
        public uint EnlistmentCount { get; }
        public IntPtr NotificationRoutine { get; }
        public IntPtr Key { get; }
        public _LIST_ENTRY ProtocolListHead { get; }
        public _LIST_ENTRY PendingPropReqListHead { get; }
        public _LIST_ENTRY CRMListEntry { get; }
        public IntPtr Tm { get; }
        public _UNICODE_STRING Description { get; }
        public _KTMOBJECT_NAMESPACE Enlistments { get; }
        public _KRESOURCEMANAGER_COMPLETION_BINDING CompletionBinding { get; }

        public _KRESOURCEMANAGER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KRESOURCEMANAGER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KRESOURCEMANAGER.NotificationAvailable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.cookie),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.State),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.Flags),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.Mutex),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.NamespaceLink),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.RmId),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.NotificationQueue),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.NotificationMutex),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.EnlistmentHead),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.EnlistmentCount),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.NotificationRoutine),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.Key),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.ProtocolListHead),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.PendingPropReqListHead),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.CRMListEntry),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.Tm),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.Description),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.Enlistments),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER.CompletionBinding),
                    new ulong[]
                    {
                        552UL
                    }
                }
            };
            Register<_KRESOURCEMANAGER>((mem, ptr) => new _KRESOURCEMANAGER(mem, ptr), offsets);
        }
    }
}