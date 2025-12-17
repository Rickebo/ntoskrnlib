using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_PATH_HASH")]
    public sealed class _CM_PATH_HASH : DynamicStructure
    {
        public uint Hash { get; }

        public _CM_PATH_HASH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_PATH_HASH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_PATH_HASH.Hash),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_CM_PATH_HASH>((mem, ptr) => new _CM_PATH_HASH(mem, ptr), offsets);
        }
    }
}