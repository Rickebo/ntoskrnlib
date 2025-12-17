using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MEMORY_ALLOCATION_DESCRIPTOR")]
    public sealed class _MEMORY_ALLOCATION_DESCRIPTOR : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public _RTL_BALANCED_NODE Node { get; }
        public uint MemoryType { get; }
        public ulong BasePage { get; }
        public ulong PageCount { get; }

        public _MEMORY_ALLOCATION_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MEMORY_ALLOCATION_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MEMORY_ALLOCATION_DESCRIPTOR.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MEMORY_ALLOCATION_DESCRIPTOR.Node),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MEMORY_ALLOCATION_DESCRIPTOR.MemoryType),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MEMORY_ALLOCATION_DESCRIPTOR.BasePage),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MEMORY_ALLOCATION_DESCRIPTOR.PageCount),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_MEMORY_ALLOCATION_DESCRIPTOR>((mem, ptr) => new _MEMORY_ALLOCATION_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}