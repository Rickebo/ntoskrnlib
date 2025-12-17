using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ALPC_COMMUNICATION_INFO")]
    public sealed class _ALPC_COMMUNICATION_INFO : DynamicStructure
    {
        public IntPtr ConnectionPort { get; }
        public IntPtr ServerCommunicationPort { get; }
        public IntPtr ClientCommunicationPort { get; }
        public _LIST_ENTRY CommunicationList { get; }
        public _ALPC_HANDLE_TABLE HandleTable { get; }
        public IntPtr CloseMessage { get; }

        public _ALPC_COMMUNICATION_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ALPC_COMMUNICATION_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ALPC_COMMUNICATION_INFO.ConnectionPort),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ALPC_COMMUNICATION_INFO.ServerCommunicationPort),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ALPC_COMMUNICATION_INFO.ClientCommunicationPort),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ALPC_COMMUNICATION_INFO.CommunicationList),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ALPC_COMMUNICATION_INFO.HandleTable),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ALPC_COMMUNICATION_INFO.CloseMessage),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_ALPC_COMMUNICATION_INFO>((mem, ptr) => new _ALPC_COMMUNICATION_INFO(mem, ptr), offsets);
        }
    }
}