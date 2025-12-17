using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_LARGE_ALLOC_DATA")]
    public sealed class _HEAP_LARGE_ALLOC_DATA : DynamicStructure
    {
        public _RTL_BALANCED_NODE TreeNode { get; }
        public ulong VirtualAddress { get; }
        public ulong UnusedBytes { get; }
        public ulong ExtraPresent { get; }
        public ulong GuardPageCount { get; }
        public ulong GuardPageAlignment { get; }
        public ulong Spare { get; }
        public ulong AllocatedPages { get; }

        public _HEAP_LARGE_ALLOC_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LARGE_ALLOC_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LARGE_ALLOC_DATA.TreeNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LARGE_ALLOC_DATA.VirtualAddress),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_LARGE_ALLOC_DATA.UnusedBytes),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_LARGE_ALLOC_DATA.ExtraPresent),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_LARGE_ALLOC_DATA.GuardPageCount),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_LARGE_ALLOC_DATA.GuardPageAlignment),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_LARGE_ALLOC_DATA.Spare),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_LARGE_ALLOC_DATA.AllocatedPages),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_HEAP_LARGE_ALLOC_DATA>((mem, ptr) => new _HEAP_LARGE_ALLOC_DATA(mem, ptr), offsets);
        }
    }
}