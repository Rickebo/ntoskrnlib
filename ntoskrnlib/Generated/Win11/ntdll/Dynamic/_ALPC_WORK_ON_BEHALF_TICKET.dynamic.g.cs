using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ALPC_WORK_ON_BEHALF_TICKET")]
    public sealed class _ALPC_WORK_ON_BEHALF_TICKET : DynamicStructure
    {
        public uint ThreadId { get; }
        public uint ThreadCreationTimeLow { get; }

        public _ALPC_WORK_ON_BEHALF_TICKET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ALPC_WORK_ON_BEHALF_TICKET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ALPC_WORK_ON_BEHALF_TICKET.ThreadId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ALPC_WORK_ON_BEHALF_TICKET.ThreadCreationTimeLow),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_ALPC_WORK_ON_BEHALF_TICKET>((mem, ptr) => new _ALPC_WORK_ON_BEHALF_TICKET(mem, ptr), offsets);
        }
    }
}