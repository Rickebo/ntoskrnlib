using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_SYNCH_COUNTERS")]
    public sealed class SynchCounters : DynamicStructure
    {
        [Offset(0UL)]
        public uint SpinLockAcquireCount { get => ReadHere<uint>(nameof(SpinLockAcquireCount)); set => WriteHere(nameof(SpinLockAcquireCount), value); }

        [Offset(4UL)]
        public uint SpinLockContentionCount { get => ReadHere<uint>(nameof(SpinLockContentionCount)); set => WriteHere(nameof(SpinLockContentionCount), value); }

        [Offset(8UL)]
        public uint SpinLockSpinCount { get => ReadHere<uint>(nameof(SpinLockSpinCount)); set => WriteHere(nameof(SpinLockSpinCount), value); }

        [Offset(12UL)]
        public uint IpiSendRequestBroadcastCount { get => ReadHere<uint>(nameof(IpiSendRequestBroadcastCount)); set => WriteHere(nameof(IpiSendRequestBroadcastCount), value); }

        [Offset(16UL)]
        public uint IpiSendRequestRoutineCount { get => ReadHere<uint>(nameof(IpiSendRequestRoutineCount)); set => WriteHere(nameof(IpiSendRequestRoutineCount), value); }

        [Offset(20UL)]
        public uint IpiSendSoftwareInterruptCount { get => ReadHere<uint>(nameof(IpiSendSoftwareInterruptCount)); set => WriteHere(nameof(IpiSendSoftwareInterruptCount), value); }

        [Offset(24UL)]
        public uint ExInitializeResourceCount { get => ReadHere<uint>(nameof(ExInitializeResourceCount)); set => WriteHere(nameof(ExInitializeResourceCount), value); }

        [Offset(28UL)]
        public uint ExReInitializeResourceCount { get => ReadHere<uint>(nameof(ExReInitializeResourceCount)); set => WriteHere(nameof(ExReInitializeResourceCount), value); }

        [Offset(32UL)]
        public uint ExDeleteResourceCount { get => ReadHere<uint>(nameof(ExDeleteResourceCount)); set => WriteHere(nameof(ExDeleteResourceCount), value); }

        [Offset(36UL)]
        public uint ExecutiveResourceAcquiresCount { get => ReadHere<uint>(nameof(ExecutiveResourceAcquiresCount)); set => WriteHere(nameof(ExecutiveResourceAcquiresCount), value); }

        [Offset(40UL)]
        public uint ExecutiveResourceContentionsCount { get => ReadHere<uint>(nameof(ExecutiveResourceContentionsCount)); set => WriteHere(nameof(ExecutiveResourceContentionsCount), value); }

        [Offset(44UL)]
        public uint ExecutiveResourceReleaseExclusiveCount { get => ReadHere<uint>(nameof(ExecutiveResourceReleaseExclusiveCount)); set => WriteHere(nameof(ExecutiveResourceReleaseExclusiveCount), value); }

        [Offset(48UL)]
        public uint ExecutiveResourceReleaseSharedCount { get => ReadHere<uint>(nameof(ExecutiveResourceReleaseSharedCount)); set => WriteHere(nameof(ExecutiveResourceReleaseSharedCount), value); }

        [Offset(52UL)]
        public uint ExecutiveResourceConvertsCount { get => ReadHere<uint>(nameof(ExecutiveResourceConvertsCount)); set => WriteHere(nameof(ExecutiveResourceConvertsCount), value); }

        [Offset(56UL)]
        public uint ExAcqResExclusiveAttempts { get => ReadHere<uint>(nameof(ExAcqResExclusiveAttempts)); set => WriteHere(nameof(ExAcqResExclusiveAttempts), value); }

        [Offset(60UL)]
        public uint ExAcqResExclusiveAcquiresExclusive { get => ReadHere<uint>(nameof(ExAcqResExclusiveAcquiresExclusive)); set => WriteHere(nameof(ExAcqResExclusiveAcquiresExclusive), value); }

        [Offset(64UL)]
        public uint ExAcqResExclusiveAcquiresExclusiveRecursive { get => ReadHere<uint>(nameof(ExAcqResExclusiveAcquiresExclusiveRecursive)); set => WriteHere(nameof(ExAcqResExclusiveAcquiresExclusiveRecursive), value); }

        [Offset(68UL)]
        public uint ExAcqResExclusiveWaits { get => ReadHere<uint>(nameof(ExAcqResExclusiveWaits)); set => WriteHere(nameof(ExAcqResExclusiveWaits), value); }

        [Offset(72UL)]
        public uint ExAcqResExclusiveNotAcquires { get => ReadHere<uint>(nameof(ExAcqResExclusiveNotAcquires)); set => WriteHere(nameof(ExAcqResExclusiveNotAcquires), value); }

        [Offset(76UL)]
        public uint ExAcqResSharedAttempts { get => ReadHere<uint>(nameof(ExAcqResSharedAttempts)); set => WriteHere(nameof(ExAcqResSharedAttempts), value); }

        [Offset(80UL)]
        public uint ExAcqResSharedAcquiresExclusive { get => ReadHere<uint>(nameof(ExAcqResSharedAcquiresExclusive)); set => WriteHere(nameof(ExAcqResSharedAcquiresExclusive), value); }

        [Offset(84UL)]
        public uint ExAcqResSharedAcquiresShared { get => ReadHere<uint>(nameof(ExAcqResSharedAcquiresShared)); set => WriteHere(nameof(ExAcqResSharedAcquiresShared), value); }

        [Offset(88UL)]
        public uint ExAcqResSharedAcquiresSharedRecursive { get => ReadHere<uint>(nameof(ExAcqResSharedAcquiresSharedRecursive)); set => WriteHere(nameof(ExAcqResSharedAcquiresSharedRecursive), value); }

        [Offset(92UL)]
        public uint ExAcqResSharedWaits { get => ReadHere<uint>(nameof(ExAcqResSharedWaits)); set => WriteHere(nameof(ExAcqResSharedWaits), value); }

        [Offset(96UL)]
        public uint ExAcqResSharedNotAcquires { get => ReadHere<uint>(nameof(ExAcqResSharedNotAcquires)); set => WriteHere(nameof(ExAcqResSharedNotAcquires), value); }

        [Offset(100UL)]
        public uint ExAcqResSharedStarveExclusiveAttempts { get => ReadHere<uint>(nameof(ExAcqResSharedStarveExclusiveAttempts)); set => WriteHere(nameof(ExAcqResSharedStarveExclusiveAttempts), value); }

        [Offset(104UL)]
        public uint ExAcqResSharedStarveExclusiveAcquiresExclusive { get => ReadHere<uint>(nameof(ExAcqResSharedStarveExclusiveAcquiresExclusive)); set => WriteHere(nameof(ExAcqResSharedStarveExclusiveAcquiresExclusive), value); }

        [Offset(108UL)]
        public uint ExAcqResSharedStarveExclusiveAcquiresShared { get => ReadHere<uint>(nameof(ExAcqResSharedStarveExclusiveAcquiresShared)); set => WriteHere(nameof(ExAcqResSharedStarveExclusiveAcquiresShared), value); }

        [Offset(112UL)]
        public uint ExAcqResSharedStarveExclusiveAcquiresSharedRecursive { get => ReadHere<uint>(nameof(ExAcqResSharedStarveExclusiveAcquiresSharedRecursive)); set => WriteHere(nameof(ExAcqResSharedStarveExclusiveAcquiresSharedRecursive), value); }

        [Offset(116UL)]
        public uint ExAcqResSharedStarveExclusiveWaits { get => ReadHere<uint>(nameof(ExAcqResSharedStarveExclusiveWaits)); set => WriteHere(nameof(ExAcqResSharedStarveExclusiveWaits), value); }

        [Offset(120UL)]
        public uint ExAcqResSharedStarveExclusiveNotAcquires { get => ReadHere<uint>(nameof(ExAcqResSharedStarveExclusiveNotAcquires)); set => WriteHere(nameof(ExAcqResSharedStarveExclusiveNotAcquires), value); }

        [Offset(124UL)]
        public uint ExAcqResSharedWaitForExclusiveAttempts { get => ReadHere<uint>(nameof(ExAcqResSharedWaitForExclusiveAttempts)); set => WriteHere(nameof(ExAcqResSharedWaitForExclusiveAttempts), value); }

        [Offset(128UL)]
        public uint ExAcqResSharedWaitForExclusiveAcquiresExclusive { get => ReadHere<uint>(nameof(ExAcqResSharedWaitForExclusiveAcquiresExclusive)); set => WriteHere(nameof(ExAcqResSharedWaitForExclusiveAcquiresExclusive), value); }

        [Offset(132UL)]
        public uint ExAcqResSharedWaitForExclusiveAcquiresShared { get => ReadHere<uint>(nameof(ExAcqResSharedWaitForExclusiveAcquiresShared)); set => WriteHere(nameof(ExAcqResSharedWaitForExclusiveAcquiresShared), value); }

        [Offset(136UL)]
        public uint ExAcqResSharedWaitForExclusiveAcquiresSharedRecursive { get => ReadHere<uint>(nameof(ExAcqResSharedWaitForExclusiveAcquiresSharedRecursive)); set => WriteHere(nameof(ExAcqResSharedWaitForExclusiveAcquiresSharedRecursive), value); }

        [Offset(140UL)]
        public uint ExAcqResSharedWaitForExclusiveWaits { get => ReadHere<uint>(nameof(ExAcqResSharedWaitForExclusiveWaits)); set => WriteHere(nameof(ExAcqResSharedWaitForExclusiveWaits), value); }

        [Offset(144UL)]
        public uint ExAcqResSharedWaitForExclusiveNotAcquires { get => ReadHere<uint>(nameof(ExAcqResSharedWaitForExclusiveNotAcquires)); set => WriteHere(nameof(ExAcqResSharedWaitForExclusiveNotAcquires), value); }

        [Offset(148UL)]
        public uint ExSetResOwnerPointerExclusive { get => ReadHere<uint>(nameof(ExSetResOwnerPointerExclusive)); set => WriteHere(nameof(ExSetResOwnerPointerExclusive), value); }

        [Offset(152UL)]
        public uint ExSetResOwnerPointerSharedNew { get => ReadHere<uint>(nameof(ExSetResOwnerPointerSharedNew)); set => WriteHere(nameof(ExSetResOwnerPointerSharedNew), value); }

        [Offset(156UL)]
        public uint ExSetResOwnerPointerSharedOld { get => ReadHere<uint>(nameof(ExSetResOwnerPointerSharedOld)); set => WriteHere(nameof(ExSetResOwnerPointerSharedOld), value); }

        [Offset(160UL)]
        public uint ExTryToAcqExclusiveAttempts { get => ReadHere<uint>(nameof(ExTryToAcqExclusiveAttempts)); set => WriteHere(nameof(ExTryToAcqExclusiveAttempts), value); }

        [Offset(164UL)]
        public uint ExTryToAcqExclusiveAcquires { get => ReadHere<uint>(nameof(ExTryToAcqExclusiveAcquires)); set => WriteHere(nameof(ExTryToAcqExclusiveAcquires), value); }

        [Offset(168UL)]
        public uint ExBoostExclusiveOwner { get => ReadHere<uint>(nameof(ExBoostExclusiveOwner)); set => WriteHere(nameof(ExBoostExclusiveOwner), value); }

        [Offset(172UL)]
        public uint ExBoostSharedOwners { get => ReadHere<uint>(nameof(ExBoostSharedOwners)); set => WriteHere(nameof(ExBoostSharedOwners), value); }

        [Offset(176UL)]
        public uint ExEtwSynchTrackingNotificationsCount { get => ReadHere<uint>(nameof(ExEtwSynchTrackingNotificationsCount)); set => WriteHere(nameof(ExEtwSynchTrackingNotificationsCount), value); }

        [Offset(180UL)]
        public uint ExEtwSynchTrackingNotificationsAccountedCount { get => ReadHere<uint>(nameof(ExEtwSynchTrackingNotificationsAccountedCount)); set => WriteHere(nameof(ExEtwSynchTrackingNotificationsAccountedCount), value); }

        public SynchCounters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SynchCounters>();
        }
    }
}