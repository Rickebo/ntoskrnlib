using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PO_NOTIFY_ORDER_LEVEL")]
    public sealed class _PO_NOTIFY_ORDER_LEVEL : DynamicStructure
    {
        public uint DeviceCount { get; }
        public uint ActiveCount { get; }
        public _LIST_ENTRY WaitSleep { get; }
        public _LIST_ENTRY ReadySleep { get; }
        public _LIST_ENTRY ReadyS0 { get; }
        public _LIST_ENTRY WaitS0 { get; }

        public _PO_NOTIFY_ORDER_LEVEL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PO_NOTIFY_ORDER_LEVEL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PO_NOTIFY_ORDER_LEVEL.DeviceCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PO_NOTIFY_ORDER_LEVEL.ActiveCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PO_NOTIFY_ORDER_LEVEL.WaitSleep),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PO_NOTIFY_ORDER_LEVEL.ReadySleep),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PO_NOTIFY_ORDER_LEVEL.ReadyS0),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PO_NOTIFY_ORDER_LEVEL.WaitS0),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_PO_NOTIFY_ORDER_LEVEL>((mem, ptr) => new _PO_NOTIFY_ORDER_LEVEL(mem, ptr), offsets);
        }
    }
}