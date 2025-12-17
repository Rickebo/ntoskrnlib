using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KQUEUE")]
    public sealed class _KQUEUE : DynamicStructure
    {
        public _DISPATCHER_HEADER Header { get; }
        public _LIST_ENTRY EntryListHead { get; }
        public uint CurrentCount { get; }
        public uint MaximumCount { get; }
        public _LIST_ENTRY ThreadListHead { get; }

        public _KQUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KQUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KQUEUE.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KQUEUE.EntryListHead),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KQUEUE.CurrentCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KQUEUE.MaximumCount),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_KQUEUE.ThreadListHead),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_KQUEUE>((mem, ptr) => new _KQUEUE(mem, ptr), offsets);
        }
    }
}