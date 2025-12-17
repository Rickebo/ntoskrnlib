using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_BUFFER_QUEUE")]
    public sealed class _ETW_BUFFER_QUEUE : DynamicStructure
    {
        public IntPtr QueueTail { get; }
        public _SINGLE_LIST_ENTRY QueueEntry { get; }

        public _ETW_BUFFER_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_BUFFER_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_BUFFER_QUEUE.QueueTail),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_BUFFER_QUEUE.QueueEntry),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_ETW_BUFFER_QUEUE>((mem, ptr) => new _ETW_BUFFER_QUEUE(mem, ptr), offsets);
        }
    }
}