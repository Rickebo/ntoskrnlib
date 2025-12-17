using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CACHED_KSTACK_LIST")]
    public sealed class _CACHED_KSTACK_LIST : DynamicStructure
    {
        public _SLIST_HEADER SListHead { get; }
        public _MI_KSTACK_ALLOCATIONS Counters { get; }
        public uint CurrentIndex { get; }
        public uint InUseAtOnce { get; }
        public uint MinimumFree { get; }
        public byte NonIdealStacksPresent { get; }

        public _CACHED_KSTACK_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CACHED_KSTACK_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CACHED_KSTACK_LIST.SListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CACHED_KSTACK_LIST.Counters),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CACHED_KSTACK_LIST.CurrentIndex),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CACHED_KSTACK_LIST.InUseAtOnce),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_CACHED_KSTACK_LIST.MinimumFree),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_CACHED_KSTACK_LIST.NonIdealStacksPresent),
                    new ulong[]
                    {
                        44UL
                    }
                }
            };
            Register<_CACHED_KSTACK_LIST>((mem, ptr) => new _CACHED_KSTACK_LIST(mem, ptr), offsets);
        }
    }
}