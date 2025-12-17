using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SECONDARY_IC_LIST_ENTRY")]
    public sealed class _SECONDARY_IC_LIST_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public uint GsivBase { get; }
        public uint GsivSize { get; }
        public _SECONDARY_INTERRUPT_PROVIDER_INTERFACE Interface { get; }
        public int BusyCount { get; }
        public int ExclusiveWaiterCount { get; }
        public _KEVENT NotificationEvent { get; }
        public _LIST_ENTRY SignalListEntry { get; }
        public byte[] State { get; }

        public _SECONDARY_IC_LIST_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SECONDARY_IC_LIST_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SECONDARY_IC_LIST_ENTRY.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SECONDARY_IC_LIST_ENTRY.GsivBase),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SECONDARY_IC_LIST_ENTRY.GsivSize),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_SECONDARY_IC_LIST_ENTRY.Interface),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SECONDARY_IC_LIST_ENTRY.BusyCount),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_SECONDARY_IC_LIST_ENTRY.ExclusiveWaiterCount),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_SECONDARY_IC_LIST_ENTRY.NotificationEvent),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_SECONDARY_IC_LIST_ENTRY.SignalListEntry),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_SECONDARY_IC_LIST_ENTRY.State),
                    new ulong[]
                    {
                        160UL
                    }
                }
            };
            Register<_SECONDARY_IC_LIST_ENTRY>((mem, ptr) => new _SECONDARY_IC_LIST_ENTRY(mem, ptr), offsets);
        }
    }
}