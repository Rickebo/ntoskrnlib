using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FAST_OWNER_ENTRY")]
    public sealed class _FAST_OWNER_ENTRY : DynamicStructure
    {
        public byte[] Reserved { get; }

        public _FAST_OWNER_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FAST_OWNER_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FAST_OWNER_ENTRY.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_FAST_OWNER_ENTRY>((mem, ptr) => new _FAST_OWNER_ENTRY(mem, ptr), offsets);
        }
    }
}