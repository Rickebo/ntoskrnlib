using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_DISPATCHER")]
    public sealed class _WNF_DISPATCHER : DynamicStructure
    {
        public _WNF_NODE_HEADER Header { get; }
        public _WORK_QUEUE_ITEM WorkItem { get; }
        public int State { get; }

        public _WNF_DISPATCHER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_DISPATCHER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_DISPATCHER.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_DISPATCHER.WorkItem),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WNF_DISPATCHER.State),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_WNF_DISPATCHER>((mem, ptr) => new _WNF_DISPATCHER(mem, ptr), offsets);
        }
    }
}