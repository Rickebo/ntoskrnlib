using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_VIRTUAL_ALLOC_ENTRY")]
    public sealed class _HEAP_VIRTUAL_ALLOC_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY Entry { get; }
        public _HEAP_ENTRY_EXTRA ExtraStuff { get; }
        public ulong CommitSize { get; }
        public ulong ReserveSize { get; }
        public _HEAP_ENTRY BusyBlock { get; }

        public _HEAP_VIRTUAL_ALLOC_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_VIRTUAL_ALLOC_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_VIRTUAL_ALLOC_ENTRY.Entry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VIRTUAL_ALLOC_ENTRY.ExtraStuff),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_VIRTUAL_ALLOC_ENTRY.CommitSize),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_VIRTUAL_ALLOC_ENTRY.ReserveSize),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HEAP_VIRTUAL_ALLOC_ENTRY.BusyBlock),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_HEAP_VIRTUAL_ALLOC_ENTRY>((mem, ptr) => new _HEAP_VIRTUAL_ALLOC_ENTRY(mem, ptr), offsets);
        }
    }
}