using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_QUEUE_ENTRY")]
    public sealed class _ETW_QUEUE_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr DataBlock { get; }
        public IntPtr RegEntry { get; }
        public IntPtr ReplyObject { get; }
        public IntPtr WakeReference { get; }
        public ushort RegIndex { get; }
        public ushort ReplyIndex { get; }
        public uint Flags { get; }

        public _ETW_QUEUE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_QUEUE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_QUEUE_ENTRY.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_QUEUE_ENTRY.DataBlock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_QUEUE_ENTRY.RegEntry),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ETW_QUEUE_ENTRY.ReplyObject),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ETW_QUEUE_ENTRY.WakeReference),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ETW_QUEUE_ENTRY.RegIndex),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ETW_QUEUE_ENTRY.ReplyIndex),
                    new ulong[]
                    {
                        50UL
                    }
                },
                {
                    nameof(_ETW_QUEUE_ENTRY.Flags),
                    new ulong[]
                    {
                        52UL
                    }
                }
            };
            Register<_ETW_QUEUE_ENTRY>((mem, ptr) => new _ETW_QUEUE_ENTRY(mem, ptr), offsets);
        }
    }
}