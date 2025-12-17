using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSHARED_READY_QUEUE")]
    public sealed class _KSHARED_READY_QUEUE : DynamicStructure
    {
        public ulong Lock { get; }
        public uint ReadySummary { get; }
        public uint ReadyThreadCount { get; }
        public ulong ReadyQueueExpectedRunTime { get; }
        public ulong[] Spare1 { get; }
        public byte[] ReadyListHead { get; }
        public byte[] RunningSummary { get; }
        public byte[] HeteroRunningSummary { get; }
        public byte Span { get; }
        public byte LowProcIndex { get; }
        public byte QueueIndex { get; }
        public byte NormalPriorityQueueIndex { get; }
        public byte ProcCount { get; }
        public byte ScanOwner { get; }
        public ushort Group { get; }
        public ulong Affinity { get; }
        public IntPtr SubNode { get; }
        public ulong[] Spare2 { get; }
        public ulong SoftParkElectionLock { get; }
        public ulong SoftParkElectionGeneration { get; }
        public uint SoftParkElectionThreadCount { get; }
        public byte SoftParkElectionScheduled { get; }
        public byte[] Spare4 { get; }
        public ulong SoftParkElectionRunTime { get; }
        public _KDPC SoftParkElectionDpc { get; }
        public _KSHARED_READY_QUEUE_HETERO_STATISTICS SoftParkElectionHeteroStats { get; }
        public _KSHARED_READY_QUEUE_AFFINITY_STATISTICS SoftParkElectionAffinityStats { get; }
        public ulong ForceParkDutyCyclingArmedMask { get; }

        public _KSHARED_READY_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSHARED_READY_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSHARED_READY_QUEUE.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.ReadySummary),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.ReadyThreadCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.ReadyQueueExpectedRunTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.Spare1),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.ReadyListHead),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.RunningSummary),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.HeteroRunningSummary),
                    new ulong[]
                    {
                        640UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.Span),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.LowProcIndex),
                    new ulong[]
                    {
                        705UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.QueueIndex),
                    new ulong[]
                    {
                        706UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.NormalPriorityQueueIndex),
                    new ulong[]
                    {
                        707UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.ProcCount),
                    new ulong[]
                    {
                        708UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.ScanOwner),
                    new ulong[]
                    {
                        709UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.Group),
                    new ulong[]
                    {
                        710UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.Affinity),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.SubNode),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.Spare2),
                    new ulong[]
                    {
                        728UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.SoftParkElectionLock),
                    new ulong[]
                    {
                        768UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.SoftParkElectionGeneration),
                    new ulong[]
                    {
                        776UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.SoftParkElectionThreadCount),
                    new ulong[]
                    {
                        784UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.SoftParkElectionScheduled),
                    new ulong[]
                    {
                        788UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.Spare4),
                    new ulong[]
                    {
                        789UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.SoftParkElectionRunTime),
                    new ulong[]
                    {
                        792UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.SoftParkElectionDpc),
                    new ulong[]
                    {
                        800UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.SoftParkElectionHeteroStats),
                    new ulong[]
                    {
                        864UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.SoftParkElectionAffinityStats),
                    new ulong[]
                    {
                        1760UL
                    }
                },
                {
                    nameof(_KSHARED_READY_QUEUE.ForceParkDutyCyclingArmedMask),
                    new ulong[]
                    {
                        1768UL
                    }
                }
            };
            Register<_KSHARED_READY_QUEUE>((mem, ptr) => new _KSHARED_READY_QUEUE(mem, ptr), offsets);
        }
    }
}