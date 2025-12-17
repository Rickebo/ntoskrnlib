using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WORK_QUEUE_ENTRY")]
    public sealed class _WORK_QUEUE_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY WorkQueueLinks { get; }
        public _unnamed_tag_ Parameters { get; }
        public uint Function { get; }
        public IntPtr Partition { get; }
        public IntPtr PrivateVolumeCacheMap { get; }
        public IntPtr NumaNode { get; }

        public _WORK_QUEUE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WORK_QUEUE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WORK_QUEUE_ENTRY.WorkQueueLinks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WORK_QUEUE_ENTRY.Parameters),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WORK_QUEUE_ENTRY.Function),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_WORK_QUEUE_ENTRY.Partition),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_WORK_QUEUE_ENTRY.PrivateVolumeCacheMap),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_WORK_QUEUE_ENTRY.NumaNode),
                    new ulong[]
                    {
                        152UL
                    }
                }
            };
            Register<_WORK_QUEUE_ENTRY>((mem, ptr) => new _WORK_QUEUE_ENTRY(mem, ptr), offsets);
        }
    }
}