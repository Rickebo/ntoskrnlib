using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_WORK_POOL_ITEM")]
    public sealed class _POP_FX_WORK_POOL_ITEM : DynamicStructure
    {
        public IntPtr WorkPool { get; }
        public _WORK_QUEUE_ITEM WorkItem { get; }

        public _POP_FX_WORK_POOL_ITEM(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_WORK_POOL_ITEM()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_WORK_POOL_ITEM.WorkPool),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_POOL_ITEM.WorkItem),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_POP_FX_WORK_POOL_ITEM>((mem, ptr) => new _POP_FX_WORK_POOL_ITEM(mem, ptr), offsets);
        }
    }
}