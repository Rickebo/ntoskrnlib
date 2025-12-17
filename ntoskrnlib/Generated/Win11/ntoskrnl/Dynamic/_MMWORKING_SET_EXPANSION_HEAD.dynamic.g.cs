using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMWORKING_SET_EXPANSION_HEAD")]
    public sealed class _MMWORKING_SET_EXPANSION_HEAD : DynamicStructure
    {
        public _LIST_ENTRY ListHead { get; }

        public _MMWORKING_SET_EXPANSION_HEAD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMWORKING_SET_EXPANSION_HEAD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMWORKING_SET_EXPANSION_HEAD.ListHead),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMWORKING_SET_EXPANSION_HEAD>((mem, ptr) => new _MMWORKING_SET_EXPANSION_HEAD(mem, ptr), offsets);
        }
    }
}