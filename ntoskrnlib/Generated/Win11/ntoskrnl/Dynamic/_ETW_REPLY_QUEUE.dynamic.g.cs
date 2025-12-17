using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_REPLY_QUEUE")]
    public sealed class _ETW_REPLY_QUEUE : DynamicStructure
    {
        public _KQUEUE Queue { get; }
        public int EventsLost { get; }

        public _ETW_REPLY_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_REPLY_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_REPLY_QUEUE.Queue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_REPLY_QUEUE.EventsLost),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_ETW_REPLY_QUEUE>((mem, ptr) => new _ETW_REPLY_QUEUE(mem, ptr), offsets);
        }
    }
}