using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TRIAGE_PNP_DEVICE_COMPLETION_QUEUE")]
    public sealed class _TRIAGE_PNP_DEVICE_COMPLETION_QUEUE : DynamicStructure
    {
        public _LIST_ENTRY DispatchedList { get; }

        public _TRIAGE_PNP_DEVICE_COMPLETION_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TRIAGE_PNP_DEVICE_COMPLETION_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TRIAGE_PNP_DEVICE_COMPLETION_QUEUE.DispatchedList),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_TRIAGE_PNP_DEVICE_COMPLETION_QUEUE>((mem, ptr) => new _TRIAGE_PNP_DEVICE_COMPLETION_QUEUE(mem, ptr), offsets);
        }
    }
}