using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TRIAGE_EX_WORK_QUEUE")]
    public sealed class _TRIAGE_EX_WORK_QUEUE : DynamicStructure
    {
        public _KPRIQUEUE WorkPriQueue { get; }

        public _TRIAGE_EX_WORK_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TRIAGE_EX_WORK_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TRIAGE_EX_WORK_QUEUE.WorkPriQueue),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_TRIAGE_EX_WORK_QUEUE>((mem, ptr) => new _TRIAGE_EX_WORK_QUEUE(mem, ptr), offsets);
        }
    }
}