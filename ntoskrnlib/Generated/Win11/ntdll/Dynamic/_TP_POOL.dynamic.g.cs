using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TP_POOL")]
    public sealed class _TP_POOL : DynamicStructure
    {
        public _TPP_REFCOUNT Refcount { get; }
        public _TPP_POOL_QUEUE_STATE QueueState { get; }
        public byte[] TaskQueue { get; }
        public IntPtr NumaNode { get; }
        public IntPtr ProximityInfo { get; }
        public IntPtr WorkerFactory { get; }
        public IntPtr CompletionPort { get; }
        public _RTL_SRWLOCK Lock { get; }
        public _LIST_ENTRY PoolObjectList { get; }
        public _LIST_ENTRY WorkerList { get; }
        public _TPP_TIMER_QUEUE TimerQueue { get; }
        public _RTL_SRWLOCK ShutdownLock { get; }
        public byte ShutdownInitiated { get; }
        public byte Released { get; }
        public ushort PoolFlags { get; }
        public _LIST_ENTRY PoolLinks { get; }
        public _TPP_CALLER AllocCaller { get; }
        public _TPP_CALLER ReleaseCaller { get; }
        public int AvailableWorkerCount { get; }
        public int LongRunningWorkerCount { get; }
        public uint LastProcCount { get; }
        public int NodeStatus { get; }
        public int BindingCount { get; }
        public uint CallbackChecksDisabled { get; }
        public uint TrimTarget { get; }
        public uint TrimmedThrdCount { get; }
        public uint SelectedCpuSetCount { get; }
        public _RTL_CONDITION_VARIABLE TrimComplete { get; }
        public _LIST_ENTRY TrimmedWorkerList { get; }

        public _TP_POOL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_POOL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TP_POOL.Refcount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TP_POOL.QueueState),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TP_POOL.TaskQueue),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TP_POOL.NumaNode),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_TP_POOL.ProximityInfo),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_TP_POOL.WorkerFactory),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_TP_POOL.CompletionPort),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_TP_POOL.Lock),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_TP_POOL.PoolObjectList),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_TP_POOL.WorkerList),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_TP_POOL.TimerQueue),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_TP_POOL.ShutdownLock),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_TP_POOL.ShutdownInitiated),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(_TP_POOL.Released),
                    new ulong[]
                    {
                        377UL
                    }
                },
                {
                    nameof(_TP_POOL.PoolFlags),
                    new ulong[]
                    {
                        378UL
                    }
                },
                {
                    nameof(_TP_POOL.PoolLinks),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_TP_POOL.AllocCaller),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_TP_POOL.ReleaseCaller),
                    new ulong[]
                    {
                        408UL
                    }
                },
                {
                    nameof(_TP_POOL.AvailableWorkerCount),
                    new ulong[]
                    {
                        416UL
                    }
                },
                {
                    nameof(_TP_POOL.LongRunningWorkerCount),
                    new ulong[]
                    {
                        420UL
                    }
                },
                {
                    nameof(_TP_POOL.LastProcCount),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_TP_POOL.NodeStatus),
                    new ulong[]
                    {
                        428UL
                    }
                },
                {
                    nameof(_TP_POOL.BindingCount),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_TP_POOL.CallbackChecksDisabled),
                    new ulong[]
                    {
                        436UL
                    }
                },
                {
                    nameof(_TP_POOL.TrimTarget),
                    new ulong[]
                    {
                        436UL
                    }
                },
                {
                    nameof(_TP_POOL.TrimmedThrdCount),
                    new ulong[]
                    {
                        436UL
                    }
                },
                {
                    nameof(_TP_POOL.SelectedCpuSetCount),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_TP_POOL.TrimComplete),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_TP_POOL.TrimmedWorkerList),
                    new ulong[]
                    {
                        456UL
                    }
                }
            };
            Register<_TP_POOL>((mem, ptr) => new _TP_POOL(mem, ptr), offsets);
        }
    }
}