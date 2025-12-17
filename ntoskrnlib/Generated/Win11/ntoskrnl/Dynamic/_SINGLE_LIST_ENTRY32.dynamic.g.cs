using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SINGLE_LIST_ENTRY32")]
    public sealed class _SINGLE_LIST_ENTRY32 : DynamicStructure
    {
        public uint Next { get; }

        public _SINGLE_LIST_ENTRY32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SINGLE_LIST_ENTRY32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SINGLE_LIST_ENTRY32.Next),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_SINGLE_LIST_ENTRY32>((mem, ptr) => new _SINGLE_LIST_ENTRY32(mem, ptr), offsets);
        }
    }
}