using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KALPC_MESSAGE")]
    public sealed class _KALPC_MESSAGE : DynamicStructure
    {
        public _LIST_ENTRY Entry { get; }
        public IntPtr PortQueue { get; }
        public IntPtr OwnerPort { get; }
        public IntPtr WaitingThread { get; }
        public _unnamed_tag_ u1 { get; }
        public int SequenceNo { get; }
        public IntPtr QuotaProcess { get; }
        public IntPtr QuotaBlock { get; }
        public IntPtr CancelSequencePort { get; }
        public IntPtr CancelQueuePort { get; }
        public int CancelSequenceNo { get; }
        public _LIST_ENTRY CancelListEntry { get; }
        public IntPtr Reserve { get; }
        public _KALPC_MESSAGE_ATTRIBUTES MessageAttributes { get; }
        public IntPtr DataUserVa { get; }
        public IntPtr CommunicationInfo { get; }
        public IntPtr ConnectionPort { get; }
        public IntPtr ServerThread { get; }
        public IntPtr WakeReference { get; }
        public IntPtr WakeReference2 { get; }
        public IntPtr ExtensionBuffer { get; }
        public ulong ExtensionBufferSize { get; }
        public _PORT_MESSAGE PortMessage { get; }

        public _KALPC_MESSAGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KALPC_MESSAGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KALPC_MESSAGE.Entry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.PortQueue),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.OwnerPort),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.WaitingThread),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.u1),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.SequenceNo),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.QuotaProcess),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.QuotaBlock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.CancelSequencePort),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.CancelQueuePort),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.CancelSequenceNo),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.CancelListEntry),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.Reserve),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.MessageAttributes),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.DataUserVa),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.CommunicationInfo),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.ConnectionPort),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.ServerThread),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.WakeReference),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.WakeReference2),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.ExtensionBuffer),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.ExtensionBufferSize),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE.PortMessage),
                    new ulong[]
                    {
                        240UL
                    }
                }
            };
            Register<_KALPC_MESSAGE>((mem, ptr) => new _KALPC_MESSAGE(mem, ptr), offsets);
        }
    }
}