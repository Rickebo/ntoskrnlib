using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KI_RESCHEDULE_CONTEXT_ENTRY")]
    public sealed class _KI_RESCHEDULE_CONTEXT_ENTRY : DynamicStructure
    {
        public IntPtr Prcb { get; }
        public IntPtr SharedReadyQueue { get; }
        public IntPtr CompareThread { get; }
        public IntPtr NewThread { get; }
        public byte Idle { get; }
        public byte IsolationWidth { get; }
        public byte CanCheckDeferredPreemption { get; }
        public byte PartialYield { get; }
        public byte FullYield { get; }
        public byte IsolationPlaceholder { get; }
        public byte SpareCompateThreadStateFlags { get; }
        public byte AllCompareThreadStateFlags { get; }
        public byte ReadyTransition { get; }
        public byte SpareNewThreadStateFlags { get; }
        public byte AllNewThreadStateFlags { get; }
        public byte SkipStandbyReschedule { get; }
        public byte DoNotSetPreemptionBit { get; }
        public byte SpareCommitFlags { get; }
        public byte AllCommitFlags { get; }
        public byte NewThreadReferenced { get; }
        public byte LogEtw { get; }
        public byte IssuePriorityKick { get; }
        public byte DispatchInterruptIfHalted { get; }
        public byte DispatchInterruptAlways { get; }
        public byte SpareCompletionFlags { get; }
        public byte AllCompletionFlags { get; }
        public sbyte KickPriority { get; }
        public byte[] Spare { get; }

        public _KI_RESCHEDULE_CONTEXT_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KI_RESCHEDULE_CONTEXT_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.Prcb),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.SharedReadyQueue),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.CompareThread),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.NewThread),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.Idle),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.IsolationWidth),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.CanCheckDeferredPreemption),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.PartialYield),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.FullYield),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.IsolationPlaceholder),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.SpareCompateThreadStateFlags),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.AllCompareThreadStateFlags),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.ReadyTransition),
                    new ulong[]
                    {
                        33UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.SpareNewThreadStateFlags),
                    new ulong[]
                    {
                        33UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.AllNewThreadStateFlags),
                    new ulong[]
                    {
                        33UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.SkipStandbyReschedule),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.DoNotSetPreemptionBit),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.SpareCommitFlags),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.AllCommitFlags),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.NewThreadReferenced),
                    new ulong[]
                    {
                        35UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.LogEtw),
                    new ulong[]
                    {
                        35UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.IssuePriorityKick),
                    new ulong[]
                    {
                        35UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.DispatchInterruptIfHalted),
                    new ulong[]
                    {
                        35UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.DispatchInterruptAlways),
                    new ulong[]
                    {
                        35UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.SpareCompletionFlags),
                    new ulong[]
                    {
                        35UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.AllCompletionFlags),
                    new ulong[]
                    {
                        35UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.KickPriority),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT_ENTRY.Spare),
                    new ulong[]
                    {
                        37UL
                    }
                }
            };
            Register<_KI_RESCHEDULE_CONTEXT_ENTRY>((mem, ptr) => new _KI_RESCHEDULE_CONTEXT_ENTRY(mem, ptr), offsets);
        }
    }
}