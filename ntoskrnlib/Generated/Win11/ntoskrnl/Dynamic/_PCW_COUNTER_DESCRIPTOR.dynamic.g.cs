using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PCW_COUNTER_DESCRIPTOR")]
    public sealed class _PCW_COUNTER_DESCRIPTOR : DynamicStructure
    {
        public ushort Id { get; }
        public ushort StructIndex { get; }
        public ushort Offset { get; }
        public ushort Size { get; }

        public _PCW_COUNTER_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PCW_COUNTER_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PCW_COUNTER_DESCRIPTOR.Id),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PCW_COUNTER_DESCRIPTOR.StructIndex),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PCW_COUNTER_DESCRIPTOR.Offset),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PCW_COUNTER_DESCRIPTOR.Size),
                    new ulong[]
                    {
                        6UL
                    }
                }
            };
            Register<_PCW_COUNTER_DESCRIPTOR>((mem, ptr) => new _PCW_COUNTER_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}