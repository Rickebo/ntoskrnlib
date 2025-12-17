using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_RESOURCE_LIST")]
    public sealed class _CM_RESOURCE_LIST : DynamicStructure
    {
        public uint Count { get; }
        public byte[] List { get; }

        public _CM_RESOURCE_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_RESOURCE_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_RESOURCE_LIST.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_RESOURCE_LIST.List),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_CM_RESOURCE_LIST>((mem, ptr) => new _CM_RESOURCE_LIST(mem, ptr), offsets);
        }
    }
}