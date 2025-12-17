using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PNP_DEVICE_EVENT_ENTRY")]
    public sealed class _PNP_DEVICE_EVENT_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public uint Argument { get; }
        public int ArgumentStatus { get; }
        public IntPtr CallerEvent { get; }
        public IntPtr Callback { get; }
        public IntPtr Context { get; }
        public IntPtr VetoType { get; }
        public IntPtr VetoName { get; }
        public uint RefCount { get; }
        public uint Lock { get; }
        public byte Cancel { get; }
        public IntPtr Parent { get; }
        public _GUID ActivityId { get; }
        public IntPtr Watchdog { get; }
        public IntPtr PdcActivatorHandle { get; }
        public _PLUGPLAY_EVENT_BLOCK Data { get; }

        public _PNP_DEVICE_EVENT_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PNP_DEVICE_EVENT_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.Argument),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.ArgumentStatus),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.CallerEvent),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.Callback),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.Context),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.VetoType),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.VetoName),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.RefCount),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.Lock),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.Cancel),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.Parent),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.ActivityId),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.Watchdog),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.PdcActivatorHandle),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_ENTRY.Data),
                    new ulong[]
                    {
                        120UL
                    }
                }
            };
            Register<_PNP_DEVICE_EVENT_ENTRY>((mem, ptr) => new _PNP_DEVICE_EVENT_ENTRY(mem, ptr), offsets);
        }
    }
}