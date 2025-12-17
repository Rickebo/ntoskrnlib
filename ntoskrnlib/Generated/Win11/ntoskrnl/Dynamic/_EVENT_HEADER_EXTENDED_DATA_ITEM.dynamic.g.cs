using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EVENT_HEADER_EXTENDED_DATA_ITEM")]
    public sealed class _EVENT_HEADER_EXTENDED_DATA_ITEM : DynamicStructure
    {
        public ushort Reserved1 { get; }
        public ushort ExtType { get; }
        public ushort Linkage { get; }
        public ushort Reserved2 { get; }
        public ushort DataSize { get; }
        public ulong DataPtr { get; }

        public _EVENT_HEADER_EXTENDED_DATA_ITEM(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EVENT_HEADER_EXTENDED_DATA_ITEM()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EVENT_HEADER_EXTENDED_DATA_ITEM.Reserved1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EVENT_HEADER_EXTENDED_DATA_ITEM.ExtType),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_EVENT_HEADER_EXTENDED_DATA_ITEM.Linkage),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_EVENT_HEADER_EXTENDED_DATA_ITEM.Reserved2),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_EVENT_HEADER_EXTENDED_DATA_ITEM.DataSize),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_EVENT_HEADER_EXTENDED_DATA_ITEM.DataPtr),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_EVENT_HEADER_EXTENDED_DATA_ITEM>((mem, ptr) => new _EVENT_HEADER_EXTENDED_DATA_ITEM(mem, ptr), offsets);
        }
    }
}