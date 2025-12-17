using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_UCR_DESCRIPTOR")]
    public sealed class _HEAP_UCR_DESCRIPTOR : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public _LIST_ENTRY SegmentEntry { get; }
        public IntPtr Address { get; }
        public ulong Size { get; }

        public _HEAP_UCR_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_UCR_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_UCR_DESCRIPTOR.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_UCR_DESCRIPTOR.SegmentEntry),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_UCR_DESCRIPTOR.Address),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_UCR_DESCRIPTOR.Size),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_HEAP_UCR_DESCRIPTOR>((mem, ptr) => new _HEAP_UCR_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}