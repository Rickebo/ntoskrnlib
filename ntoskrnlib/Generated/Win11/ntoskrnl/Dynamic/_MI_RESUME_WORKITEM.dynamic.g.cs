using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_RESUME_WORKITEM")]
    public sealed class _MI_RESUME_WORKITEM : DynamicStructure
    {
        public _KEVENT ResumeCompleteEvent { get; }
        public _WORK_QUEUE_ITEM WorkItem { get; }

        public _MI_RESUME_WORKITEM(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_RESUME_WORKITEM()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_RESUME_WORKITEM.ResumeCompleteEvent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_RESUME_WORKITEM.WorkItem),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MI_RESUME_WORKITEM>((mem, ptr) => new _MI_RESUME_WORKITEM(mem, ptr), offsets);
        }
    }
}