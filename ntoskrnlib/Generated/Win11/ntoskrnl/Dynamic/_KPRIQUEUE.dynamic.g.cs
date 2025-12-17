using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KPRIQUEUE")]
    public sealed class _KPRIQUEUE : DynamicStructure
    {
        public _DISPATCHER_HEADER Header { get; }
        public byte[] EntryListHead { get; }
        public int[] CurrentCount { get; }
        public uint MaximumCount { get; }
        public _LIST_ENTRY ThreadListHead { get; }

        public _KPRIQUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPRIQUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPRIQUEUE.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRIQUEUE.EntryListHead),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KPRIQUEUE.CurrentCount),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_KPRIQUEUE.MaximumCount),
                    new ulong[]
                    {
                        664UL
                    }
                },
                {
                    nameof(_KPRIQUEUE.ThreadListHead),
                    new ulong[]
                    {
                        672UL
                    }
                }
            };
            Register<_KPRIQUEUE>((mem, ptr) => new _KPRIQUEUE(mem, ptr), offsets);
        }
    }
}