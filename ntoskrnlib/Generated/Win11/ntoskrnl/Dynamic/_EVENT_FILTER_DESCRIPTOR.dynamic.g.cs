using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EVENT_FILTER_DESCRIPTOR")]
    public sealed class _EVENT_FILTER_DESCRIPTOR : DynamicStructure
    {
        public ulong Ptr { get; }
        public uint Size { get; }
        public uint Type { get; }

        public _EVENT_FILTER_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EVENT_FILTER_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EVENT_FILTER_DESCRIPTOR.Ptr),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EVENT_FILTER_DESCRIPTOR.Size),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EVENT_FILTER_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_EVENT_FILTER_DESCRIPTOR>((mem, ptr) => new _EVENT_FILTER_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}