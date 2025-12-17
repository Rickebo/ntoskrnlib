using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_INSTANCE")]
    public sealed class _ARBITER_INSTANCE : DynamicStructure
    {
        public uint Signature { get; }
        public IntPtr MutexEvent { get; }
        public IntPtr Name { get; }
        public IntPtr OrderingName { get; }
        public int ResourceType { get; }
        public IntPtr Allocation { get; }
        public IntPtr PossibleAllocation { get; }
        public _ARBITER_ORDERING_LIST OrderingList { get; }
        public _ARBITER_ORDERING_LIST ReservedList { get; }
        public int ReferenceCount { get; }
        public IntPtr Interface { get; }
        public uint AllocationStackMaxSize { get; }
        public IntPtr AllocationStack { get; }
        public IntPtr UnpackRequirement { get; }
        public IntPtr PackResource { get; }
        public IntPtr UnpackResource { get; }
        public IntPtr ScoreRequirement { get; }
        public IntPtr TestAllocation { get; }
        public IntPtr RetestAllocation { get; }
        public IntPtr CommitAllocation { get; }
        public IntPtr RollbackAllocation { get; }
        public IntPtr BootAllocation { get; }
        public IntPtr QueryArbitrate { get; }
        public IntPtr QueryConflict { get; }
        public IntPtr AddReserved { get; }
        public IntPtr StartArbiter { get; }
        public IntPtr PreprocessEntry { get; }
        public IntPtr AllocateEntry { get; }
        public IntPtr GetNextAllocationRange { get; }
        public IntPtr FindSuitableRange { get; }
        public IntPtr AddAllocation { get; }
        public IntPtr BacktrackAllocation { get; }
        public IntPtr OverrideConflict { get; }
        public IntPtr InitializeRangeList { get; }
        public IntPtr DeleteOwnerRanges { get; }
        public byte TransactionInProgress { get; }
        public IntPtr TransactionEvent { get; }
        public IntPtr Extension { get; }
        public IntPtr BusDeviceObject { get; }
        public IntPtr ConflictCallbackContext { get; }
        public IntPtr ConflictCallback { get; }

        public _ARBITER_INSTANCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_INSTANCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_INSTANCE.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.MutexEvent),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.Name),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.OrderingName),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.ResourceType),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.Allocation),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.PossibleAllocation),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.OrderingList),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.ReservedList),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.ReferenceCount),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.Interface),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.AllocationStackMaxSize),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.AllocationStack),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.UnpackRequirement),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.PackResource),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.UnpackResource),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.ScoreRequirement),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.TestAllocation),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.RetestAllocation),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.CommitAllocation),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.RollbackAllocation),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.BootAllocation),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.QueryArbitrate),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.QueryConflict),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.AddReserved),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.StartArbiter),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.PreprocessEntry),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.AllocateEntry),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.GetNextAllocationRange),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.FindSuitableRange),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.AddAllocation),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.BacktrackAllocation),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.OverrideConflict),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.InitializeRangeList),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.DeleteOwnerRanges),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.TransactionInProgress),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.TransactionEvent),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.Extension),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.BusDeviceObject),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.ConflictCallbackContext),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_ARBITER_INSTANCE.ConflictCallback),
                    new ulong[]
                    {
                        336UL
                    }
                }
            };
            Register<_ARBITER_INSTANCE>((mem, ptr) => new _ARBITER_INSTANCE(mem, ptr), offsets);
        }
    }
}