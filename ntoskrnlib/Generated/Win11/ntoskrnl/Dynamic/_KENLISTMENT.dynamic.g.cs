using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KENLISTMENT")]
    public sealed class _KENLISTMENT : DynamicStructure
    {
        public uint cookie { get; }
        public _KTMOBJECT_NAMESPACE_LINK NamespaceLink { get; }
        public _GUID EnlistmentId { get; }
        public _KMUTANT Mutex { get; }
        public _LIST_ENTRY NextSameTx { get; }
        public _LIST_ENTRY NextSameRm { get; }
        public IntPtr ResourceManager { get; }
        public IntPtr Transaction { get; }
        public uint State { get; }
        public uint Flags { get; }
        public uint NotificationMask { get; }
        public IntPtr Key { get; }
        public uint KeyRefCount { get; }
        public IntPtr RecoveryInformation { get; }
        public uint RecoveryInformationLength { get; }
        public IntPtr DynamicNameInformation { get; }
        public uint DynamicNameInformationLength { get; }
        public IntPtr FinalNotification { get; }
        public IntPtr SupSubEnlistment { get; }
        public IntPtr SupSubEnlHandle { get; }
        public IntPtr SubordinateTxHandle { get; }
        public _GUID CrmEnlistmentEnId { get; }
        public _GUID CrmEnlistmentTmId { get; }
        public _GUID CrmEnlistmentRmId { get; }
        public uint NextHistory { get; }
        public byte[] History { get; }

        public _KENLISTMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KENLISTMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KENLISTMENT.cookie),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KENLISTMENT.NamespaceLink),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KENLISTMENT.EnlistmentId),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KENLISTMENT.Mutex),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KENLISTMENT.NextSameTx),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KENLISTMENT.NextSameRm),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KENLISTMENT.ResourceManager),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_KENLISTMENT.Transaction),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_KENLISTMENT.State),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_KENLISTMENT.Flags),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_KENLISTMENT.NotificationMask),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_KENLISTMENT.Key),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_KENLISTMENT.KeyRefCount),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_KENLISTMENT.RecoveryInformation),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_KENLISTMENT.RecoveryInformationLength),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_KENLISTMENT.DynamicNameInformation),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_KENLISTMENT.DynamicNameInformationLength),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_KENLISTMENT.FinalNotification),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_KENLISTMENT.SupSubEnlistment),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_KENLISTMENT.SupSubEnlHandle),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_KENLISTMENT.SubordinateTxHandle),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_KENLISTMENT.CrmEnlistmentEnId),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_KENLISTMENT.CrmEnlistmentTmId),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_KENLISTMENT.CrmEnlistmentRmId),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_KENLISTMENT.NextHistory),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_KENLISTMENT.History),
                    new ulong[]
                    {
                        316UL
                    }
                }
            };
            Register<_KENLISTMENT>((mem, ptr) => new _KENLISTMENT(mem, ptr), offsets);
        }
    }
}