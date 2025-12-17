using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_PARAMETERS")]
    public sealed class _ARBITER_PARAMETERS : DynamicStructure
    {
        public _unnamed_tag_ Parameters { get; }

        public _ARBITER_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_PARAMETERS.Parameters),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ARBITER_PARAMETERS>((mem, ptr) => new _ARBITER_PARAMETERS(mem, ptr), offsets);
        }
    }
}