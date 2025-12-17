using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WORK_QUEUE_ITEM")]
    public sealed class _WORK_QUEUE_ITEM : DynamicStructure
    {
        public _LIST_ENTRY List { get; }
        public IntPtr WorkerRoutine { get; }
        public IntPtr Parameter { get; }

        public _WORK_QUEUE_ITEM(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WORK_QUEUE_ITEM()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WORK_QUEUE_ITEM.List),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WORK_QUEUE_ITEM.WorkerRoutine),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WORK_QUEUE_ITEM.Parameter),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_WORK_QUEUE_ITEM>((mem, ptr) => new _WORK_QUEUE_ITEM(mem, ptr), offsets);
        }
    }
}