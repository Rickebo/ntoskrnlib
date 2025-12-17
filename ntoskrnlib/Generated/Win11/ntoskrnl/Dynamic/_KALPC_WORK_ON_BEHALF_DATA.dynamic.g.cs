using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KALPC_WORK_ON_BEHALF_DATA")]
    public sealed class _KALPC_WORK_ON_BEHALF_DATA : DynamicStructure
    {
        public _ALPC_WORK_ON_BEHALF_TICKET Ticket { get; }

        public _KALPC_WORK_ON_BEHALF_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KALPC_WORK_ON_BEHALF_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KALPC_WORK_ON_BEHALF_DATA.Ticket),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KALPC_WORK_ON_BEHALF_DATA>((mem, ptr) => new _KALPC_WORK_ON_BEHALF_DATA(mem, ptr), offsets);
        }
    }
}