using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EVENT_DESCRIPTOR")]
    public sealed class _EVENT_DESCRIPTOR : DynamicStructure
    {
        public ushort Id { get; }
        public byte Version { get; }
        public byte Channel { get; }
        public byte Level { get; }
        public byte Opcode { get; }
        public ushort Task { get; }
        public ulong Keyword { get; }

        public _EVENT_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EVENT_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EVENT_DESCRIPTOR.Id),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EVENT_DESCRIPTOR.Version),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_EVENT_DESCRIPTOR.Channel),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_EVENT_DESCRIPTOR.Level),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_EVENT_DESCRIPTOR.Opcode),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_EVENT_DESCRIPTOR.Task),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_EVENT_DESCRIPTOR.Keyword),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_EVENT_DESCRIPTOR>((mem, ptr) => new _EVENT_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}