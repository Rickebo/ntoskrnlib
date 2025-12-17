using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_QUERY_ARBITRATE_PARAMETERS")]
    public sealed class _ARBITER_QUERY_ARBITRATE_PARAMETERS : DynamicStructure
    {
        public IntPtr ArbitrationList { get; }

        public _ARBITER_QUERY_ARBITRATE_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_QUERY_ARBITRATE_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_QUERY_ARBITRATE_PARAMETERS.ArbitrationList),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ARBITER_QUERY_ARBITRATE_PARAMETERS>((mem, ptr) => new _ARBITER_QUERY_ARBITRATE_PARAMETERS(mem, ptr), offsets);
        }
    }
}