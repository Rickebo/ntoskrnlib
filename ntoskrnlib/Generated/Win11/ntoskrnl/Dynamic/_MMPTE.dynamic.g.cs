using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPTE")]
    public sealed class _MMPTE : DynamicStructure
    {
        public _unnamed_tag_ u { get; }

        public _MMPTE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPTE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPTE.u),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMPTE>((mem, ptr) => new _MMPTE(mem, ptr), offsets);
        }
    }
}