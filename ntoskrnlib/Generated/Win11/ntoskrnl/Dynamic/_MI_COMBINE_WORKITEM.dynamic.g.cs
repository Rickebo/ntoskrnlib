using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_COMBINE_WORKITEM")]
    public sealed class _MI_COMBINE_WORKITEM : DynamicStructure
    {
        public IntPtr NextEntry { get; }
        public _WORK_QUEUE_ITEM WorkItem { get; }

        public _MI_COMBINE_WORKITEM(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_COMBINE_WORKITEM()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_COMBINE_WORKITEM.NextEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_COMBINE_WORKITEM.WorkItem),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_MI_COMBINE_WORKITEM>((mem, ptr) => new _MI_COMBINE_WORKITEM(mem, ptr), offsets);
        }
    }
}