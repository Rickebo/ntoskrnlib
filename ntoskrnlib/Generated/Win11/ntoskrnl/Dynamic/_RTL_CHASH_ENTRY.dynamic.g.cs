using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_CHASH_ENTRY")]
    public sealed class _RTL_CHASH_ENTRY : DynamicStructure
    {
        public ulong Key { get; }

        public _RTL_CHASH_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_CHASH_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_CHASH_ENTRY.Key),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_RTL_CHASH_ENTRY>((mem, ptr) => new _RTL_CHASH_ENTRY(mem, ptr), offsets);
        }
    }
}