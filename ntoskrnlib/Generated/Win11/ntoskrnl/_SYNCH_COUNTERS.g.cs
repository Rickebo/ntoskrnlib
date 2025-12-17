#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 184)]
    public partial struct _SYNCH_COUNTERS
    {
        [FieldOffset(0)]
        public uint SpinLockAcquireCount;
        [FieldOffset(4)]
        public uint SpinLockContentionCount;
        [FieldOffset(8)]
        public uint SpinLockSpinCount;
        [FieldOffset(12)]
        public uint IpiSendRequestBroadcastCount;
        [FieldOffset(16)]
        public uint IpiSendRequestRoutineCount;
        [FieldOffset(20)]
        public uint IpiSendSoftwareInterruptCount;
        [FieldOffset(24)]
        public uint ExInitializeResourceCount;
        [FieldOffset(28)]
        public uint ExReInitializeResourceCount;
        [FieldOffset(32)]
        public uint ExDeleteResourceCount;
        [FieldOffset(36)]
        public uint ExecutiveResourceAcquiresCount;
        [FieldOffset(40)]
        public uint ExecutiveResourceContentionsCount;
        [FieldOffset(44)]
        public uint ExecutiveResourceReleaseExclusiveCount;
        [FieldOffset(48)]
        public uint ExecutiveResourceReleaseSharedCount;
        [FieldOffset(52)]
        public uint ExecutiveResourceConvertsCount;
        [FieldOffset(56)]
        public uint ExAcqResExclusiveAttempts;
        [FieldOffset(60)]
        public uint ExAcqResExclusiveAcquiresExclusive;
        [FieldOffset(64)]
        public uint ExAcqResExclusiveAcquiresExclusiveRecursive;
        [FieldOffset(68)]
        public uint ExAcqResExclusiveWaits;
        [FieldOffset(72)]
        public uint ExAcqResExclusiveNotAcquires;
        [FieldOffset(76)]
        public uint ExAcqResSharedAttempts;
        [FieldOffset(80)]
        public uint ExAcqResSharedAcquiresExclusive;
        [FieldOffset(84)]
        public uint ExAcqResSharedAcquiresShared;
        [FieldOffset(88)]
        public uint ExAcqResSharedAcquiresSharedRecursive;
        [FieldOffset(92)]
        public uint ExAcqResSharedWaits;
        [FieldOffset(96)]
        public uint ExAcqResSharedNotAcquires;
        [FieldOffset(100)]
        public uint ExAcqResSharedStarveExclusiveAttempts;
        [FieldOffset(104)]
        public uint ExAcqResSharedStarveExclusiveAcquiresExclusive;
        [FieldOffset(108)]
        public uint ExAcqResSharedStarveExclusiveAcquiresShared;
        [FieldOffset(112)]
        public uint ExAcqResSharedStarveExclusiveAcquiresSharedRecursive;
        [FieldOffset(116)]
        public uint ExAcqResSharedStarveExclusiveWaits;
        [FieldOffset(120)]
        public uint ExAcqResSharedStarveExclusiveNotAcquires;
        [FieldOffset(124)]
        public uint ExAcqResSharedWaitForExclusiveAttempts;
        [FieldOffset(128)]
        public uint ExAcqResSharedWaitForExclusiveAcquiresExclusive;
        [FieldOffset(132)]
        public uint ExAcqResSharedWaitForExclusiveAcquiresShared;
        [FieldOffset(136)]
        public uint ExAcqResSharedWaitForExclusiveAcquiresSharedRecursive;
        [FieldOffset(140)]
        public uint ExAcqResSharedWaitForExclusiveWaits;
        [FieldOffset(144)]
        public uint ExAcqResSharedWaitForExclusiveNotAcquires;
        [FieldOffset(148)]
        public uint ExSetResOwnerPointerExclusive;
        [FieldOffset(152)]
        public uint ExSetResOwnerPointerSharedNew;
        [FieldOffset(156)]
        public uint ExSetResOwnerPointerSharedOld;
        [FieldOffset(160)]
        public uint ExTryToAcqExclusiveAttempts;
        [FieldOffset(164)]
        public uint ExTryToAcqExclusiveAcquires;
        [FieldOffset(168)]
        public uint ExBoostExclusiveOwner;
        [FieldOffset(172)]
        public uint ExBoostSharedOwners;
        [FieldOffset(176)]
        public uint ExEtwSynchTrackingNotificationsCount;
        [FieldOffset(180)]
        public uint ExEtwSynchTrackingNotificationsAccountedCount;
    }
}