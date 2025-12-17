using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_ALPC_WORK_ON_BEHALF_TICKET")]
    public sealed class AlpcWorkOnBehalfTicket : DynamicStructure
    {
        [Offset(0UL)]
        public uint ThreadId { get => ReadHere<uint>(nameof(ThreadId)); set => WriteHere(nameof(ThreadId), value); }

        [Offset(4UL)]
        public uint ThreadCreationTimeLow { get => ReadHere<uint>(nameof(ThreadCreationTimeLow)); set => WriteHere(nameof(ThreadCreationTimeLow), value); }

        public AlpcWorkOnBehalfTicket(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AlpcWorkOnBehalfTicket>();
        }
    }
}