using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EVENT_DATA_DESCRIPTOR")]
    public sealed class _EVENT_DATA_DESCRIPTOR : DynamicStructure
    {
        public ulong Ptr { get; }
        public uint Size { get; }
        public uint Reserved { get; }
        public byte Type { get; }
        public byte Reserved1 { get; }
        public ushort Reserved2 { get; }

        public _EVENT_DATA_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EVENT_DATA_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EVENT_DATA_DESCRIPTOR.Ptr),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EVENT_DATA_DESCRIPTOR.Size),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EVENT_DATA_DESCRIPTOR.Reserved),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_EVENT_DATA_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_EVENT_DATA_DESCRIPTOR.Reserved1),
                    new ulong[]
                    {
                        13UL
                    }
                },
                {
                    nameof(_EVENT_DATA_DESCRIPTOR.Reserved2),
                    new ulong[]
                    {
                        14UL
                    }
                }
            };
            Register<_EVENT_DATA_DESCRIPTOR>((mem, ptr) => new _EVENT_DATA_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}