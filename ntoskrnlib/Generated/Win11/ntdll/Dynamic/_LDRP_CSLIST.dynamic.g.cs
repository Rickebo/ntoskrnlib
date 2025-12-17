using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_LDRP_CSLIST")]
    public sealed class _LDRP_CSLIST : DynamicStructure
    {
        public IntPtr Tail { get; }

        public _LDRP_CSLIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LDRP_CSLIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LDRP_CSLIST.Tail),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_LDRP_CSLIST>((mem, ptr) => new _LDRP_CSLIST(mem, ptr), offsets);
        }
    }
}