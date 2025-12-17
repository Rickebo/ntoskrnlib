using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PNP_DEVICE_EVENT_LIST")]
    public sealed class _PNP_DEVICE_EVENT_LIST : DynamicStructure
    {
        public int Status { get; }
        public _KMUTANT EventQueueMutex { get; }
        public _FAST_MUTEX Lock { get; }
        public _LIST_ENTRY List { get; }

        public _PNP_DEVICE_EVENT_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PNP_DEVICE_EVENT_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PNP_DEVICE_EVENT_LIST.Status),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_LIST.EventQueueMutex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_LIST.Lock),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_EVENT_LIST.List),
                    new ulong[]
                    {
                        120UL
                    }
                }
            };
            Register<_PNP_DEVICE_EVENT_LIST>((mem, ptr) => new _PNP_DEVICE_EVENT_LIST(mem, ptr), offsets);
        }
    }
}