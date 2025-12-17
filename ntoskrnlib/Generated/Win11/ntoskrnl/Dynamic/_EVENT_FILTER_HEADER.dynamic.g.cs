using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EVENT_FILTER_HEADER")]
    public sealed class _EVENT_FILTER_HEADER : DynamicStructure
    {
        public ushort Id { get; }
        public byte Version { get; }
        public byte[] Reserved { get; }
        public ulong InstanceId { get; }
        public uint Size { get; }
        public uint NextOffset { get; }

        public _EVENT_FILTER_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EVENT_FILTER_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EVENT_FILTER_HEADER.Id),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EVENT_FILTER_HEADER.Version),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_EVENT_FILTER_HEADER.Reserved),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_EVENT_FILTER_HEADER.InstanceId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EVENT_FILTER_HEADER.Size),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EVENT_FILTER_HEADER.NextOffset),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_EVENT_FILTER_HEADER>((mem, ptr) => new _EVENT_FILTER_HEADER(mem, ptr), offsets);
        }
    }
}