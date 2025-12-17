using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_DESCRIPTOR_KEY")]
    public sealed class _HEAP_DESCRIPTOR_KEY : DynamicStructure
    {
        public uint Key { get; }
        public uint EncodedCommittedPageCount { get; }
        public uint LargePageCost { get; }
        public uint UnitCount { get; }

        public _HEAP_DESCRIPTOR_KEY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_DESCRIPTOR_KEY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_DESCRIPTOR_KEY.Key),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_DESCRIPTOR_KEY.EncodedCommittedPageCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_DESCRIPTOR_KEY.LargePageCost),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_DESCRIPTOR_KEY.UnitCount),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_DESCRIPTOR_KEY>((mem, ptr) => new _HEAP_DESCRIPTOR_KEY(mem, ptr), offsets);
        }
    }
}