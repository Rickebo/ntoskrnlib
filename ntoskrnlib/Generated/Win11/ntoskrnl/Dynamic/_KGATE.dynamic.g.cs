using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KGATE")]
    public sealed class _KGATE : DynamicStructure
    {
        public _DISPATCHER_HEADER Header { get; }

        public _KGATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KGATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KGATE.Header),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KGATE>((mem, ptr) => new _KGATE(mem, ptr), offsets);
        }
    }
}