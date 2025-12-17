using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_WORK_ORDER")]
    public sealed class _POP_FX_WORK_ORDER : DynamicStructure
    {
        public _WORK_QUEUE_ITEM WorkItem { get; }
        public int WorkCount { get; }
        public IntPtr Context { get; }
        public IntPtr WatchdogTimerInfo { get; }

        public _POP_FX_WORK_ORDER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_WORK_ORDER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_WORK_ORDER.WorkItem),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_ORDER.WorkCount),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_ORDER.Context),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_ORDER.WatchdogTimerInfo),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_POP_FX_WORK_ORDER>((mem, ptr) => new _POP_FX_WORK_ORDER(mem, ptr), offsets);
        }
    }
}