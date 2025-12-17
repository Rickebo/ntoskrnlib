using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_SYNCH_COUNTERS")]
    public sealed class _SYNCH_COUNTERS : DynamicStructure
    {
        public uint SpinLockAcquireCount { get; }
        public uint SpinLockContentionCount { get; }
        public uint SpinLockSpinCount { get; }
        public uint IpiSendRequestBroadcastCount { get; }
        public uint IpiSendRequestRoutineCount { get; }
        public uint IpiSendSoftwareInterruptCount { get; }
        public uint ExInitializeResourceCount { get; }
        public uint ExReInitializeResourceCount { get; }
        public uint ExDeleteResourceCount { get; }
        public uint ExecutiveResourceAcquiresCount { get; }
        public uint ExecutiveResourceContentionsCount { get; }
        public uint ExecutiveResourceReleaseExclusiveCount { get; }
        public uint ExecutiveResourceReleaseSharedCount { get; }
        public uint ExecutiveResourceConvertsCount { get; }
        public uint ExAcqResExclusiveAttempts { get; }
        public uint ExAcqResExclusiveAcquiresExclusive { get; }
        public uint ExAcqResExclusiveAcquiresExclusiveRecursive { get; }
        public uint ExAcqResExclusiveWaits { get; }
        public uint ExAcqResExclusiveNotAcquires { get; }
        public uint ExAcqResSharedAttempts { get; }
        public uint ExAcqResSharedAcquiresExclusive { get; }
        public uint ExAcqResSharedAcquiresShared { get; }
        public uint ExAcqResSharedAcquiresSharedRecursive { get; }
        public uint ExAcqResSharedWaits { get; }
        public uint ExAcqResSharedNotAcquires { get; }
        public uint ExAcqResSharedStarveExclusiveAttempts { get; }
        public uint ExAcqResSharedStarveExclusiveAcquiresExclusive { get; }
        public uint ExAcqResSharedStarveExclusiveAcquiresShared { get; }
        public uint ExAcqResSharedStarveExclusiveAcquiresSharedRecursive { get; }
        public uint ExAcqResSharedStarveExclusiveWaits { get; }
        public uint ExAcqResSharedStarveExclusiveNotAcquires { get; }
        public uint ExAcqResSharedWaitForExclusiveAttempts { get; }
        public uint ExAcqResSharedWaitForExclusiveAcquiresExclusive { get; }
        public uint ExAcqResSharedWaitForExclusiveAcquiresShared { get; }
        public uint ExAcqResSharedWaitForExclusiveAcquiresSharedRecursive { get; }
        public uint ExAcqResSharedWaitForExclusiveWaits { get; }
        public uint ExAcqResSharedWaitForExclusiveNotAcquires { get; }
        public uint ExSetResOwnerPointerExclusive { get; }
        public uint ExSetResOwnerPointerSharedNew { get; }
        public uint ExSetResOwnerPointerSharedOld { get; }
        public uint ExTryToAcqExclusiveAttempts { get; }
        public uint ExTryToAcqExclusiveAcquires { get; }
        public uint ExBoostExclusiveOwner { get; }
        public uint ExBoostSharedOwners { get; }
        public uint ExEtwSynchTrackingNotificationsCount { get; }
        public uint ExEtwSynchTrackingNotificationsAccountedCount { get; }

        public _SYNCH_COUNTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SYNCH_COUNTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SYNCH_COUNTERS.SpinLockAcquireCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.SpinLockContentionCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.SpinLockSpinCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.IpiSendRequestBroadcastCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.IpiSendRequestRoutineCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.IpiSendSoftwareInterruptCount),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExInitializeResourceCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExReInitializeResourceCount),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExDeleteResourceCount),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExecutiveResourceAcquiresCount),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExecutiveResourceContentionsCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExecutiveResourceReleaseExclusiveCount),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExecutiveResourceReleaseSharedCount),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExecutiveResourceConvertsCount),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResExclusiveAttempts),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResExclusiveAcquiresExclusive),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResExclusiveAcquiresExclusiveRecursive),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResExclusiveWaits),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResExclusiveNotAcquires),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedAttempts),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedAcquiresExclusive),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedAcquiresShared),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedAcquiresSharedRecursive),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedWaits),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedNotAcquires),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedStarveExclusiveAttempts),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedStarveExclusiveAcquiresExclusive),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedStarveExclusiveAcquiresShared),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedStarveExclusiveAcquiresSharedRecursive),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedStarveExclusiveWaits),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedStarveExclusiveNotAcquires),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedWaitForExclusiveAttempts),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedWaitForExclusiveAcquiresExclusive),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedWaitForExclusiveAcquiresShared),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedWaitForExclusiveAcquiresSharedRecursive),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedWaitForExclusiveWaits),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExAcqResSharedWaitForExclusiveNotAcquires),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExSetResOwnerPointerExclusive),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExSetResOwnerPointerSharedNew),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExSetResOwnerPointerSharedOld),
                    new ulong[]
                    {
                        156UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExTryToAcqExclusiveAttempts),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExTryToAcqExclusiveAcquires),
                    new ulong[]
                    {
                        164UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExBoostExclusiveOwner),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExBoostSharedOwners),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExEtwSynchTrackingNotificationsCount),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_SYNCH_COUNTERS.ExEtwSynchTrackingNotificationsAccountedCount),
                    new ulong[]
                    {
                        180UL
                    }
                }
            };
            Register<_SYNCH_COUNTERS>((mem, ptr) => new _SYNCH_COUNTERS(mem, ptr), offsets);
        }
    }
}