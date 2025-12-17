using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CHILD_LIST")]
    public sealed class _CHILD_LIST : DynamicStructure
    {
        public uint Count { get; }
        public uint List { get; }

        public _CHILD_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CHILD_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CHILD_LIST.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CHILD_LIST.List),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_CHILD_LIST>((mem, ptr) => new _CHILD_LIST(mem, ptr), offsets);
        }
    }
}