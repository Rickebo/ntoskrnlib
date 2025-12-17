using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ALPC_COMMUNICATION_INFO")]
    public sealed class AlpcCommunicationInfo : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ConnectionPort { get => ReadHere<IntPtr>(nameof(ConnectionPort)); set => WriteHere(nameof(ConnectionPort), value); }

        [Offset(8UL)]
        public IntPtr ServerCommunicationPort { get => ReadHere<IntPtr>(nameof(ServerCommunicationPort)); set => WriteHere(nameof(ServerCommunicationPort), value); }

        [Offset(16UL)]
        public IntPtr ClientCommunicationPort { get => ReadHere<IntPtr>(nameof(ClientCommunicationPort)); set => WriteHere(nameof(ClientCommunicationPort), value); }

        [Offset(24UL)]
        public ListEntry CommunicationList { get => ReadStructure<ListEntry>(nameof(CommunicationList)); set => WriteStructure(nameof(CommunicationList), value); }

        [Offset(40UL)]
        public AlpcHandleTable HandleTable { get => ReadStructure<AlpcHandleTable>(nameof(HandleTable)); set => WriteStructure(nameof(HandleTable), value); }

        [Offset(72UL)]
        public IntPtr CloseMessage { get => ReadHere<IntPtr>(nameof(CloseMessage)); set => WriteHere(nameof(CloseMessage), value); }

        public AlpcCommunicationInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AlpcCommunicationInfo>();
        }
    }
}