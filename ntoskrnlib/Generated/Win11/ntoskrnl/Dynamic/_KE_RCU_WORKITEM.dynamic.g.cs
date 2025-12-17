using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KE_RCU_WORKITEM")]
    public sealed class _KE_RCU_WORKITEM : DynamicStructure
    {
        public ulong[] Placeholder { get; }

        public _KE_RCU_WORKITEM(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KE_RCU_WORKITEM()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KE_RCU_WORKITEM.Placeholder),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KE_RCU_WORKITEM>((mem, ptr) => new _KE_RCU_WORKITEM(mem, ptr), offsets);
        }
    }
}