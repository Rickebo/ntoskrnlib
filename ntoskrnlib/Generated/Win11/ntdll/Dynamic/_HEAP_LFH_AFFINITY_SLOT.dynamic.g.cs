using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_LFH_AFFINITY_SLOT")]
    public sealed class _HEAP_LFH_AFFINITY_SLOT : DynamicStructure
    {
        public _HEAP_LFH_SUBSEGMENT_OWNER State { get; }
        public _HEAP_LFH_FAST_REF ActiveSubsegment { get; }

        public _HEAP_LFH_AFFINITY_SLOT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_AFFINITY_SLOT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_AFFINITY_SLOT.State),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_AFFINITY_SLOT.ActiveSubsegment),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_HEAP_LFH_AFFINITY_SLOT>((mem, ptr) => new _HEAP_LFH_AFFINITY_SLOT(mem, ptr), offsets);
        }
    }
}