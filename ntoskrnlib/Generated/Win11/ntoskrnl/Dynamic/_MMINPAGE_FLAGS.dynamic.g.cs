using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMINPAGE_FLAGS")]
    public sealed class _MMINPAGE_FLAGS : DynamicStructure
    {
        public uint GetExtents { get; }
        public uint VmType { get; }
        public uint VaPrefetchReadBlock { get; }
        public uint CollidedFlowThrough { get; }
        public uint ForceCollisions { get; }
        public uint InPageExpanded { get; }
        public uint IssuedAtLowPriority { get; }
        public uint FaultFromStore { get; }
        public uint PagePriority { get; }
        public uint ClusteredPagePriority { get; }
        public uint MakeClusterValid { get; }
        public uint ZeroLastPage { get; }
        public uint UserFault { get; }
        public uint StandbyProtectionNeeded { get; }
        public uint PteChanged { get; }
        public uint PageFileFault { get; }
        public uint PageFilePageHashActive { get; }
        public uint CoalescedIo { get; }
        public uint VmLockNotNeeded { get; }
        public uint PartitionReferenced { get; }
        public uint Spare0 { get; }
        public uint Spare1 { get; }

        public _MMINPAGE_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMINPAGE_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMINPAGE_FLAGS.GetExtents),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.VmType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.VaPrefetchReadBlock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.CollidedFlowThrough),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.ForceCollisions),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.InPageExpanded),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.IssuedAtLowPriority),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.FaultFromStore),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.PagePriority),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.ClusteredPagePriority),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.MakeClusterValid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.ZeroLastPage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.UserFault),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.StandbyProtectionNeeded),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.PteChanged),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.PageFileFault),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.PageFilePageHashActive),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.CoalescedIo),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.VmLockNotNeeded),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.PartitionReferenced),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.Spare0),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_FLAGS.Spare1),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMINPAGE_FLAGS>((mem, ptr) => new _MMINPAGE_FLAGS(mem, ptr), offsets);
        }
    }
}