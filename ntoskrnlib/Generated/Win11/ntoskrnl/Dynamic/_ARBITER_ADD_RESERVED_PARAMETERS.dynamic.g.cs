using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_ADD_RESERVED_PARAMETERS")]
    public sealed class _ARBITER_ADD_RESERVED_PARAMETERS : DynamicStructure
    {
        public IntPtr ReserveDevice { get; }

        public _ARBITER_ADD_RESERVED_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_ADD_RESERVED_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_ADD_RESERVED_PARAMETERS.ReserveDevice),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ARBITER_ADD_RESERVED_PARAMETERS>((mem, ptr) => new _ARBITER_ADD_RESERVED_PARAMETERS(mem, ptr), offsets);
        }
    }
}