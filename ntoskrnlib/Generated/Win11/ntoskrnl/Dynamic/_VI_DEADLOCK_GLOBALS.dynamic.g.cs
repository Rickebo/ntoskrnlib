using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VI_DEADLOCK_GLOBALS")]
    public sealed class _VI_DEADLOCK_GLOBALS : DynamicStructure
    {
        public long TimeAcquire { get; }
        public long TimeRelease { get; }
        public IntPtr ResourceDatabase { get; }
        public ulong ResourceDatabaseCount { get; }
        public byte[] ResourceAddressRange { get; }
        public IntPtr ThreadDatabase { get; }
        public ulong ThreadDatabaseCount { get; }
        public byte[] ThreadAddressRange { get; }
        public uint AllocationFailures { get; }
        public uint NodesTrimmedBasedOnAge { get; }
        public uint NodesTrimmedBasedOnCount { get; }
        public uint NodesSearched { get; }
        public uint MaxNodesSearched { get; }
        public uint SequenceNumber { get; }
        public uint RecursionDepthLimit { get; }
        public uint SearchedNodesLimit { get; }
        public uint DepthLimitHits { get; }
        public uint SearchLimitHits { get; }
        public uint StackLimitHits { get; }
        public uint ABC_ACB_Skipped { get; }
        public uint OutOfOrderReleases { get; }
        public uint NodesReleasedOutOfOrder { get; }
        public uint TotalReleases { get; }
        public uint RootNodesDeleted { get; }
        public uint ForgetHistoryCounter { get; }
        public IntPtr Instigator { get; }
        public uint NumberOfParticipants { get; }
        public byte[] Participant { get; }
        public int ChildrenCountWatermark { get; }
        public uint StackType { get; }
        public ulong StackLowLimit { get; }
        public ulong StackHighLimit { get; }

        public _VI_DEADLOCK_GLOBALS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VI_DEADLOCK_GLOBALS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VI_DEADLOCK_GLOBALS.TimeAcquire),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.TimeRelease),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.ResourceDatabase),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.ResourceDatabaseCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.ResourceAddressRange),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.ThreadDatabase),
                    new ulong[]
                    {
                        16400UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.ThreadDatabaseCount),
                    new ulong[]
                    {
                        16408UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.ThreadAddressRange),
                    new ulong[]
                    {
                        16416UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.AllocationFailures),
                    new ulong[]
                    {
                        32784UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.NodesTrimmedBasedOnAge),
                    new ulong[]
                    {
                        32788UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.NodesTrimmedBasedOnCount),
                    new ulong[]
                    {
                        32792UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.NodesSearched),
                    new ulong[]
                    {
                        32796UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.MaxNodesSearched),
                    new ulong[]
                    {
                        32800UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.SequenceNumber),
                    new ulong[]
                    {
                        32804UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.RecursionDepthLimit),
                    new ulong[]
                    {
                        32808UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.SearchedNodesLimit),
                    new ulong[]
                    {
                        32812UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.DepthLimitHits),
                    new ulong[]
                    {
                        32816UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.SearchLimitHits),
                    new ulong[]
                    {
                        32820UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.StackLimitHits),
                    new ulong[]
                    {
                        32824UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.ABC_ACB_Skipped),
                    new ulong[]
                    {
                        32828UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.OutOfOrderReleases),
                    new ulong[]
                    {
                        32832UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.NodesReleasedOutOfOrder),
                    new ulong[]
                    {
                        32836UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.TotalReleases),
                    new ulong[]
                    {
                        32840UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.RootNodesDeleted),
                    new ulong[]
                    {
                        32844UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.ForgetHistoryCounter),
                    new ulong[]
                    {
                        32848UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.Instigator),
                    new ulong[]
                    {
                        32856UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.NumberOfParticipants),
                    new ulong[]
                    {
                        32864UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.Participant),
                    new ulong[]
                    {
                        32872UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.ChildrenCountWatermark),
                    new ulong[]
                    {
                        33128UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.StackType),
                    new ulong[]
                    {
                        33132UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.StackLowLimit),
                    new ulong[]
                    {
                        33136UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_GLOBALS.StackHighLimit),
                    new ulong[]
                    {
                        33144UL
                    }
                }
            };
            Register<_VI_DEADLOCK_GLOBALS>((mem, ptr) => new _VI_DEADLOCK_GLOBALS(mem, ptr), offsets);
        }
    }
}