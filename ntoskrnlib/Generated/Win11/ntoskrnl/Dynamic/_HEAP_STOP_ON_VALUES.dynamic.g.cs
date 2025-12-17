using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_STOP_ON_VALUES")]
    public sealed class _HEAP_STOP_ON_VALUES : DynamicStructure
    {
        public ulong AllocAddress { get; }
        public _HEAP_STOP_ON_TAG AllocTag { get; }
        public ulong ReAllocAddress { get; }
        public _HEAP_STOP_ON_TAG ReAllocTag { get; }
        public ulong FreeAddress { get; }
        public _HEAP_STOP_ON_TAG FreeTag { get; }

        public _HEAP_STOP_ON_VALUES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_STOP_ON_VALUES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_STOP_ON_VALUES.AllocAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_STOP_ON_VALUES.AllocTag),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_STOP_ON_VALUES.ReAllocAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_STOP_ON_VALUES.ReAllocTag),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_STOP_ON_VALUES.FreeAddress),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_STOP_ON_VALUES.FreeTag),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_HEAP_STOP_ON_VALUES>((mem, ptr) => new _HEAP_STOP_ON_VALUES(mem, ptr), offsets);
        }
    }
}