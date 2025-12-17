using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_REQUEST_MAILBOX")]
    public sealed class RequestMailbox : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public ulong RequestSummary { get => ReadHere<ulong>(nameof(RequestSummary)); set => WriteHere(nameof(RequestSummary), value); }

        [Offset(16UL)]
        public KrequestPacket RequestPacket { get => ReadStructure<KrequestPacket>(nameof(RequestPacket)); set => WriteStructure(nameof(RequestPacket), value); }

        [Offset(48UL)]
        public IntPtr SubNodeTargetCountAddr { get => ReadHere<IntPtr>(nameof(SubNodeTargetCountAddr)); set => WriteHere(nameof(SubNodeTargetCountAddr), value); }

        [Offset(56UL)]
        public int SubNodeTargetCount { get => ReadHere<int>(nameof(SubNodeTargetCount)); set => WriteHere(nameof(SubNodeTargetCount), value); }

        public RequestMailbox(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RequestMailbox>();
        }
    }
}