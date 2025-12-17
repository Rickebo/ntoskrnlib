using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_PAGE_RANGE_DESCRIPTOR")]
    public sealed class _HEAP_PAGE_RANGE_DESCRIPTOR : DynamicStructure
    {
        public _RTL_BALANCED_NODE TreeNode { get; }
        public uint TreeSignature { get; }
        public uint UnusedBytes { get; }
        public ushort ExtraPresent { get; }
        public ushort Spare0 { get; }
        public byte RangeFlags { get; }
        public byte CommittedPageCount { get; }
        public byte UnitOffset { get; }
        public byte Spare { get; }
        public _HEAP_DESCRIPTOR_KEY Key { get; }
        public byte[] Align { get; }
        public byte UnitSize { get; }

        public _HEAP_PAGE_RANGE_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_PAGE_RANGE_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_PAGE_RANGE_DESCRIPTOR.TreeNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_RANGE_DESCRIPTOR.TreeSignature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_RANGE_DESCRIPTOR.UnusedBytes),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_RANGE_DESCRIPTOR.ExtraPresent),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_RANGE_DESCRIPTOR.Spare0),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_RANGE_DESCRIPTOR.RangeFlags),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_RANGE_DESCRIPTOR.CommittedPageCount),
                    new ulong[]
                    {
                        25UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_RANGE_DESCRIPTOR.UnitOffset),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_RANGE_DESCRIPTOR.Spare),
                    new ulong[]
                    {
                        27UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_RANGE_DESCRIPTOR.Key),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_RANGE_DESCRIPTOR.Align),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_RANGE_DESCRIPTOR.UnitSize),
                    new ulong[]
                    {
                        31UL
                    }
                }
            };
            Register<_HEAP_PAGE_RANGE_DESCRIPTOR>((mem, ptr) => new _HEAP_PAGE_RANGE_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}