using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KGROUP_MASK")]
    public sealed class _KGROUP_MASK : DynamicStructure
    {
        public ulong[] Masks { get; }

        public _KGROUP_MASK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KGROUP_MASK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KGROUP_MASK.Masks),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KGROUP_MASK>((mem, ptr) => new _KGROUP_MASK(mem, ptr), offsets);
        }
    }
}