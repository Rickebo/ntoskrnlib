using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EVENT_HEADER")]
    public sealed class _EVENT_HEADER : DynamicStructure
    {
        public ushort Size { get; }
        public ushort HeaderType { get; }
        public ushort Flags { get; }
        public ushort EventProperty { get; }
        public uint ThreadId { get; }
        public uint ProcessId { get; }
        public _LARGE_INTEGER TimeStamp { get; }
        public _GUID ProviderId { get; }
        public _EVENT_DESCRIPTOR EventDescriptor { get; }
        public uint KernelTime { get; }
        public uint UserTime { get; }
        public ulong ProcessorTime { get; }
        public _GUID ActivityId { get; }

        public _EVENT_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EVENT_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EVENT_HEADER.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EVENT_HEADER.HeaderType),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_EVENT_HEADER.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_EVENT_HEADER.EventProperty),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_EVENT_HEADER.ThreadId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EVENT_HEADER.ProcessId),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_EVENT_HEADER.TimeStamp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EVENT_HEADER.ProviderId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_EVENT_HEADER.EventDescriptor),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_EVENT_HEADER.KernelTime),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_EVENT_HEADER.UserTime),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_EVENT_HEADER.ProcessorTime),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_EVENT_HEADER.ActivityId),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_EVENT_HEADER>((mem, ptr) => new _EVENT_HEADER(mem, ptr), offsets);
        }
    }
}