using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEAP_WORK_QUEUE")]
    public sealed class _WHEAP_WORK_QUEUE : DynamicStructure
    {
        public _LIST_ENTRY ListHead { get; }
        public ulong ListLock { get; }
        public int ItemCount { get; }
        public _KDPC Dpc { get; }
        public _WORK_QUEUE_ITEM WorkItem { get; }
        public IntPtr WorkRoutine { get; }

        public _WHEAP_WORK_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEAP_WORK_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEAP_WORK_QUEUE.ListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEAP_WORK_QUEUE.ListLock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEAP_WORK_QUEUE.ItemCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEAP_WORK_QUEUE.Dpc),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WHEAP_WORK_QUEUE.WorkItem),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_WHEAP_WORK_QUEUE.WorkRoutine),
                    new ulong[]
                    {
                        128UL
                    }
                }
            };
            Register<_WHEAP_WORK_QUEUE>((mem, ptr) => new _WHEAP_WORK_QUEUE(mem, ptr), offsets);
        }
    }
}