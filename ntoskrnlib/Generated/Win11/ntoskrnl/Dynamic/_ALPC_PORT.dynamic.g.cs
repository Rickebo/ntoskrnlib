using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ALPC_PORT")]
    public sealed class _ALPC_PORT : DynamicStructure
    {
        public _LIST_ENTRY PortListEntry { get; }
        public IntPtr CommunicationInfo { get; }
        public IntPtr OwnerProcess { get; }
        public IntPtr CompletionPort { get; }
        public IntPtr CompletionKey { get; }
        public IntPtr CompletionPacketLookaside { get; }
        public IntPtr PortContext { get; }
        public _SECURITY_CLIENT_CONTEXT StaticSecurity { get; }
        public _EX_PUSH_LOCK IncomingQueueLock { get; }
        public _LIST_ENTRY MainQueue { get; }
        public _LIST_ENTRY LargeMessageQueue { get; }
        public _EX_PUSH_LOCK PendingQueueLock { get; }
        public _LIST_ENTRY PendingQueue { get; }
        public _EX_PUSH_LOCK DirectQueueLock { get; }
        public _LIST_ENTRY DirectQueue { get; }
        public _EX_PUSH_LOCK WaitQueueLock { get; }
        public _LIST_ENTRY WaitQueue { get; }
        public IntPtr Semaphore { get; }
        public IntPtr DummyEvent { get; }
        public _ALPC_PORT_ATTRIBUTES PortAttributes { get; }
        public _EX_PUSH_LOCK ResourceListLock { get; }
        public _LIST_ENTRY ResourceListHead { get; }
        public _EX_PUSH_LOCK PortObjectLock { get; }
        public IntPtr CompletionList { get; }
        public IntPtr CallbackObject { get; }
        public IntPtr CallbackContext { get; }
        public _LIST_ENTRY CanceledQueue { get; }
        public int SequenceNo { get; }
        public int ReferenceNo { get; }
        public IntPtr ReferenceNoWait { get; }
        public _unnamed_tag_ u1 { get; }
        public IntPtr TargetQueuePort { get; }
        public IntPtr TargetSequencePort { get; }
        public IntPtr CachedMessage { get; }
        public uint MainQueueLength { get; }
        public uint LargeMessageQueueLength { get; }
        public uint PendingQueueLength { get; }
        public uint DirectQueueLength { get; }
        public uint CanceledQueueLength { get; }
        public uint WaitQueueLength { get; }

        public _ALPC_PORT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ALPC_PORT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ALPC_PORT.PortListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ALPC_PORT.CommunicationInfo),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ALPC_PORT.OwnerProcess),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ALPC_PORT.CompletionPort),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ALPC_PORT.CompletionKey),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ALPC_PORT.CompletionPacketLookaside),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ALPC_PORT.PortContext),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_ALPC_PORT.StaticSecurity),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_ALPC_PORT.IncomingQueueLock),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_ALPC_PORT.MainQueue),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_ALPC_PORT.LargeMessageQueue),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_ALPC_PORT.PendingQueueLock),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_ALPC_PORT.PendingQueue),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_ALPC_PORT.DirectQueueLock),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_ALPC_PORT.DirectQueue),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_ALPC_PORT.WaitQueueLock),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_ALPC_PORT.WaitQueue),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_ALPC_PORT.Semaphore),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_ALPC_PORT.DummyEvent),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_ALPC_PORT.PortAttributes),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_ALPC_PORT.ResourceListLock),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_ALPC_PORT.ResourceListHead),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_ALPC_PORT.PortObjectLock),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_ALPC_PORT.CompletionList),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_ALPC_PORT.CallbackObject),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_ALPC_PORT.CallbackContext),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(_ALPC_PORT.CanceledQueue),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_ALPC_PORT.SequenceNo),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_ALPC_PORT.ReferenceNo),
                    new ulong[]
                    {
                        404UL
                    }
                },
                {
                    nameof(_ALPC_PORT.ReferenceNoWait),
                    new ulong[]
                    {
                        408UL
                    }
                },
                {
                    nameof(_ALPC_PORT.u1),
                    new ulong[]
                    {
                        416UL
                    }
                },
                {
                    nameof(_ALPC_PORT.TargetQueuePort),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_ALPC_PORT.TargetSequencePort),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_ALPC_PORT.CachedMessage),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_ALPC_PORT.MainQueueLength),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_ALPC_PORT.LargeMessageQueueLength),
                    new ulong[]
                    {
                        452UL
                    }
                },
                {
                    nameof(_ALPC_PORT.PendingQueueLength),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_ALPC_PORT.DirectQueueLength),
                    new ulong[]
                    {
                        460UL
                    }
                },
                {
                    nameof(_ALPC_PORT.CanceledQueueLength),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_ALPC_PORT.WaitQueueLength),
                    new ulong[]
                    {
                        468UL
                    }
                }
            };
            Register<_ALPC_PORT>((mem, ptr) => new _ALPC_PORT(mem, ptr), offsets);
        }
    }
}