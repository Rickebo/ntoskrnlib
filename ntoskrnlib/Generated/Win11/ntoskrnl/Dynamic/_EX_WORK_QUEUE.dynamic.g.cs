using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EX_WORK_QUEUE")]
    public sealed class _EX_WORK_QUEUE : DynamicStructure
    {
        public _KPRIQUEUE WorkPriQueue { get; }
        public IntPtr Partition { get; }
        public IntPtr Node { get; }
        public uint WorkItemsProcessed { get; }
        public uint WorkItemsProcessedLastPass { get; }
        public int ThreadCount { get; }
        public int MinThreads { get; }
        public uint TryFailed { get; }
        public int MaxThreads { get; }
        public uint QueueIndex { get; }
        public IntPtr AllThreadsExitedEvent { get; }

        public _EX_WORK_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_WORK_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EX_WORK_QUEUE.WorkPriQueue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE.Partition),
                    new ulong[]
                    {
                        688UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE.Node),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE.WorkItemsProcessed),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE.WorkItemsProcessedLastPass),
                    new ulong[]
                    {
                        708UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE.ThreadCount),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE.MinThreads),
                    new ulong[]
                    {
                        716UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE.TryFailed),
                    new ulong[]
                    {
                        716UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE.MaxThreads),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE.QueueIndex),
                    new ulong[]
                    {
                        724UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE.AllThreadsExitedEvent),
                    new ulong[]
                    {
                        728UL
                    }
                }
            };
            Register<_EX_WORK_QUEUE>((mem, ptr) => new _EX_WORK_QUEUE(mem, ptr), offsets);
        }
    }
}