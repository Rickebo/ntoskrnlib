using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PS_TRUSTLET_TKSESSION_ID")]
    public sealed class _PS_TRUSTLET_TKSESSION_ID : DynamicStructure
    {
        public ulong[] SessionId { get; }

        public _PS_TRUSTLET_TKSESSION_ID(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_TRUSTLET_TKSESSION_ID()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_TRUSTLET_TKSESSION_ID.SessionId),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PS_TRUSTLET_TKSESSION_ID>((mem, ptr) => new _PS_TRUSTLET_TKSESSION_ID(mem, ptr), offsets);
        }
    }
}