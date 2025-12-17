using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KALPC_WORK_ON_BEHALF_DATA")]
    public sealed class KalpcWorkOnBehalfData : DynamicStructure
    {
        [Offset(0UL)]
        public AlpcWorkOnBehalfTicket Ticket { get => ReadStructure<AlpcWorkOnBehalfTicket>(nameof(Ticket)); set => WriteStructure(nameof(Ticket), value); }

        public KalpcWorkOnBehalfData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KalpcWorkOnBehalfData>();
        }
    }
}