using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_COMPONENT_HASH")]
    public sealed class _CM_COMPONENT_HASH : DynamicStructure
    {
        public uint Hash { get; }

        public _CM_COMPONENT_HASH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_COMPONENT_HASH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_COMPONENT_HASH.Hash),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_CM_COMPONENT_HASH>((mem, ptr) => new _CM_COMPONENT_HASH(mem, ptr), offsets);
        }
    }
}