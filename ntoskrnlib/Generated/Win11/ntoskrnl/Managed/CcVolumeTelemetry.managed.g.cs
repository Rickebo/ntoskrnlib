using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CC_VOLUME_TELEMETRY")]
    public sealed class CcVolumeTelemetry : DynamicStructure
    {
        [Offset(0UL)]
        public Guid DeviceGuid { get => ReadStructure<Guid>(nameof(DeviceGuid)); set => WriteStructure(nameof(DeviceGuid), value); }

        [Offset(16UL)]
        public ulong TotalDirtyPages { get => ReadHere<ulong>(nameof(TotalDirtyPages)); set => WriteHere(nameof(TotalDirtyPages), value); }

        [Offset(24UL)]
        public ulong MaxDirtyPages { get => ReadHere<ulong>(nameof(MaxDirtyPages)); set => WriteHere(nameof(MaxDirtyPages), value); }

        [Offset(32UL)]
        public ulong TotalDirtyPageThreshold { get => ReadHere<ulong>(nameof(TotalDirtyPageThreshold)); set => WriteHere(nameof(TotalDirtyPageThreshold), value); }

        [Offset(40UL)]
        public ulong TopDirtyPageThreshold { get => ReadHere<ulong>(nameof(TopDirtyPageThreshold)); set => WriteHere(nameof(TopDirtyPageThreshold), value); }

        [Offset(48UL)]
        public ulong BottomDirtyPageThreshold { get => ReadHere<ulong>(nameof(BottomDirtyPageThreshold)); set => WriteHere(nameof(BottomDirtyPageThreshold), value); }

        [Offset(56UL)]
        public ulong DirtyPageSamples { get => ReadHere<ulong>(nameof(DirtyPageSamples)); set => WriteHere(nameof(DirtyPageSamples), value); }

        [Offset(64UL)]
        public ulong TotalPagesQueuedToDisk { get => ReadHere<ulong>(nameof(TotalPagesQueuedToDisk)); set => WriteHere(nameof(TotalPagesQueuedToDisk), value); }

        [Offset(72UL)]
        public ulong MaxPagesQueuedToDisk { get => ReadHere<ulong>(nameof(MaxPagesQueuedToDisk)); set => WriteHere(nameof(MaxPagesQueuedToDisk), value); }

        [Offset(80UL)]
        public ulong PagesQueuedToDiskSamples { get => ReadHere<ulong>(nameof(PagesQueuedToDiskSamples)); set => WriteHere(nameof(PagesQueuedToDiskSamples), value); }

        [Offset(88UL)]
        public ulong TotalLoggedPagesQueuedToDisk { get => ReadHere<ulong>(nameof(TotalLoggedPagesQueuedToDisk)); set => WriteHere(nameof(TotalLoggedPagesQueuedToDisk), value); }

        [Offset(96UL)]
        public ulong MaxLoggedPagesQueuedToDisk { get => ReadHere<ulong>(nameof(MaxLoggedPagesQueuedToDisk)); set => WriteHere(nameof(MaxLoggedPagesQueuedToDisk), value); }

        [Offset(104UL)]
        public ulong LoggedPagesQueuedToDiskSamples { get => ReadHere<ulong>(nameof(LoggedPagesQueuedToDiskSamples)); set => WriteHere(nameof(LoggedPagesQueuedToDiskSamples), value); }

        [Offset(112UL)]
        public ulong ReadTotalBytes { get => ReadHere<ulong>(nameof(ReadTotalBytes)); set => WriteHere(nameof(ReadTotalBytes), value); }

        [Offset(120UL)]
        public ulong ReadPagedInTotalBytes { get => ReadHere<ulong>(nameof(ReadPagedInTotalBytes)); set => WriteHere(nameof(ReadPagedInTotalBytes), value); }

        [Offset(128UL)]
        public ulong ReadAheadTotalBytes { get => ReadHere<ulong>(nameof(ReadAheadTotalBytes)); set => WriteHere(nameof(ReadAheadTotalBytes), value); }

        [Offset(136UL)]
        public ulong TotalSynchronousReadIoCount { get => ReadHere<ulong>(nameof(TotalSynchronousReadIoCount)); set => WriteHere(nameof(TotalSynchronousReadIoCount), value); }

        [Offset(144UL)]
        public ulong TotalSynchronousNonBlockingReadIoCount { get => ReadHere<ulong>(nameof(TotalSynchronousNonBlockingReadIoCount)); set => WriteHere(nameof(TotalSynchronousNonBlockingReadIoCount), value); }

        [Offset(152UL)]
        public ulong TotalFailedSynchronousNonBlockingReadIoCount { get => ReadHere<ulong>(nameof(TotalFailedSynchronousNonBlockingReadIoCount)); set => WriteHere(nameof(TotalFailedSynchronousNonBlockingReadIoCount), value); }

        [Offset(160UL)]
        public ulong TotalWrites { get => ReadHere<ulong>(nameof(TotalWrites)); set => WriteHere(nameof(TotalWrites), value); }

        [Offset(168UL)]
        public ulong TotalHardThrottleWrites { get => ReadHere<ulong>(nameof(TotalHardThrottleWrites)); set => WriteHere(nameof(TotalHardThrottleWrites), value); }

        [Offset(176UL)]
        public ulong TotalSoftThrottleWrites { get => ReadHere<ulong>(nameof(TotalSoftThrottleWrites)); set => WriteHere(nameof(TotalSoftThrottleWrites), value); }

        [Offset(184UL)]
        public ulong TotalLazyWriterCalls { get => ReadHere<ulong>(nameof(TotalLazyWriterCalls)); set => WriteHere(nameof(TotalLazyWriterCalls), value); }

        [Offset(192UL)]
        public ulong TotalLazyWriterLatency { get => ReadHere<ulong>(nameof(TotalLazyWriterLatency)); set => WriteHere(nameof(TotalLazyWriterLatency), value); }

        [Offset(200UL)]
        public ulong TotalLazyWriterPagesFlushed { get => ReadHere<ulong>(nameof(TotalLazyWriterPagesFlushed)); set => WriteHere(nameof(TotalLazyWriterPagesFlushed), value); }

        [Offset(208UL)]
        public ulong TotalLazyWriterAvgPagesPerSecond { get => ReadHere<ulong>(nameof(TotalLazyWriterAvgPagesPerSecond)); set => WriteHere(nameof(TotalLazyWriterAvgPagesPerSecond), value); }

        [Offset(216UL)]
        public ulong SynchronousReadIoMaxLatency { get => ReadHere<ulong>(nameof(SynchronousReadIoMaxLatency)); set => WriteHere(nameof(SynchronousReadIoMaxLatency), value); }

        [Offset(224UL)]
        public ulong SynchronousReadIoNonBlockingMaxLatency { get => ReadHere<ulong>(nameof(SynchronousReadIoNonBlockingMaxLatency)); set => WriteHere(nameof(SynchronousReadIoNonBlockingMaxLatency), value); }

        [Offset(232UL)]
        [Length(12)]
        public DynamicArray SynchronousReadIoCounts { get => ReadStructure<DynamicArray>(nameof(SynchronousReadIoCounts)); set => WriteStructure(nameof(SynchronousReadIoCounts), value); }

        [Offset(328UL)]
        [Length(12)]
        public DynamicArray SynchronousReadTotalLatency { get => ReadStructure<DynamicArray>(nameof(SynchronousReadTotalLatency)); set => WriteStructure(nameof(SynchronousReadTotalLatency), value); }

        [Offset(424UL)]
        [Length(12)]
        public DynamicArray SynchronousReadNonBlockingIoCounts { get => ReadStructure<DynamicArray>(nameof(SynchronousReadNonBlockingIoCounts)); set => WriteStructure(nameof(SynchronousReadNonBlockingIoCounts), value); }

        [Offset(520UL)]
        [Length(12)]
        public DynamicArray SynchronousReadNonBlockingTotalLatency { get => ReadStructure<DynamicArray>(nameof(SynchronousReadNonBlockingTotalLatency)); set => WriteStructure(nameof(SynchronousReadNonBlockingTotalLatency), value); }

        [Offset(616UL)]
        public ulong TotalSynchronousWriteIoCount { get => ReadHere<ulong>(nameof(TotalSynchronousWriteIoCount)); set => WriteHere(nameof(TotalSynchronousWriteIoCount), value); }

        [Offset(624UL)]
        public ulong TotalSynchronousNonBlockingWriteIoCount { get => ReadHere<ulong>(nameof(TotalSynchronousNonBlockingWriteIoCount)); set => WriteHere(nameof(TotalSynchronousNonBlockingWriteIoCount), value); }

        [Offset(632UL)]
        public ulong TotalFailedSynchronousNonBlockingWriteIoCount { get => ReadHere<ulong>(nameof(TotalFailedSynchronousNonBlockingWriteIoCount)); set => WriteHere(nameof(TotalFailedSynchronousNonBlockingWriteIoCount), value); }

        [Offset(640UL)]
        public ulong SynchronousWriteIoMaxLatency { get => ReadHere<ulong>(nameof(SynchronousWriteIoMaxLatency)); set => WriteHere(nameof(SynchronousWriteIoMaxLatency), value); }

        [Offset(648UL)]
        public ulong SynchronousWriteIoNonBlockingMaxLatency { get => ReadHere<ulong>(nameof(SynchronousWriteIoNonBlockingMaxLatency)); set => WriteHere(nameof(SynchronousWriteIoNonBlockingMaxLatency), value); }

        [Offset(656UL)]
        [Length(12)]
        public DynamicArray SynchronousWriteIoCounts { get => ReadStructure<DynamicArray>(nameof(SynchronousWriteIoCounts)); set => WriteStructure(nameof(SynchronousWriteIoCounts), value); }

        [Offset(752UL)]
        [Length(12)]
        public DynamicArray SynchronousWriteTotalLatency { get => ReadStructure<DynamicArray>(nameof(SynchronousWriteTotalLatency)); set => WriteStructure(nameof(SynchronousWriteTotalLatency), value); }

        [Offset(848UL)]
        [Length(12)]
        public DynamicArray SynchronousWriteNonBlockingIoCounts { get => ReadStructure<DynamicArray>(nameof(SynchronousWriteNonBlockingIoCounts)); set => WriteStructure(nameof(SynchronousWriteNonBlockingIoCounts), value); }

        [Offset(944UL)]
        [Length(12)]
        public DynamicArray SynchronousWriteNonBlockingTotalLatency { get => ReadStructure<DynamicArray>(nameof(SynchronousWriteNonBlockingTotalLatency)); set => WriteStructure(nameof(SynchronousWriteNonBlockingTotalLatency), value); }

        [Offset(1040UL)]
        public ulong TotalAsynchronousReadIoCount { get => ReadHere<ulong>(nameof(TotalAsynchronousReadIoCount)); set => WriteHere(nameof(TotalAsynchronousReadIoCount), value); }

        [Offset(1048UL)]
        public ulong AsynchronousReadIoMaxLatency { get => ReadHere<ulong>(nameof(AsynchronousReadIoMaxLatency)); set => WriteHere(nameof(AsynchronousReadIoMaxLatency), value); }

        [Offset(1056UL)]
        [Length(12)]
        public DynamicArray AsynchronousReadIoCounts { get => ReadStructure<DynamicArray>(nameof(AsynchronousReadIoCounts)); set => WriteStructure(nameof(AsynchronousReadIoCounts), value); }

        [Offset(1152UL)]
        [Length(12)]
        public DynamicArray AsynchronousReadTotalLatency { get => ReadStructure<DynamicArray>(nameof(AsynchronousReadTotalLatency)); set => WriteStructure(nameof(AsynchronousReadTotalLatency), value); }

        [Offset(1248UL)]
        public ulong CumulativeTotalDirtyPages { get => ReadHere<ulong>(nameof(CumulativeTotalDirtyPages)); set => WriteHere(nameof(CumulativeTotalDirtyPages), value); }

        [Offset(1256UL)]
        public ulong CumulativeMaxDirtyPages { get => ReadHere<ulong>(nameof(CumulativeMaxDirtyPages)); set => WriteHere(nameof(CumulativeMaxDirtyPages), value); }

        [Offset(1264UL)]
        public ulong CumulativeDirtyPageThreshold { get => ReadHere<ulong>(nameof(CumulativeDirtyPageThreshold)); set => WriteHere(nameof(CumulativeDirtyPageThreshold), value); }

        [Offset(1272UL)]
        public ulong CumulativeTopDirtyPageThreshold { get => ReadHere<ulong>(nameof(CumulativeTopDirtyPageThreshold)); set => WriteHere(nameof(CumulativeTopDirtyPageThreshold), value); }

        [Offset(1280UL)]
        public ulong CumulativeBottomDirtyPageThreshold { get => ReadHere<ulong>(nameof(CumulativeBottomDirtyPageThreshold)); set => WriteHere(nameof(CumulativeBottomDirtyPageThreshold), value); }

        [Offset(1288UL)]
        public ulong CumulativeDirtyPageSamples { get => ReadHere<ulong>(nameof(CumulativeDirtyPageSamples)); set => WriteHere(nameof(CumulativeDirtyPageSamples), value); }

        [Offset(1296UL)]
        public ulong CumulativeTotalPagesQueuedToDisk { get => ReadHere<ulong>(nameof(CumulativeTotalPagesQueuedToDisk)); set => WriteHere(nameof(CumulativeTotalPagesQueuedToDisk), value); }

        [Offset(1304UL)]
        public ulong CumulativeMaxPagesQueuedToDisk { get => ReadHere<ulong>(nameof(CumulativeMaxPagesQueuedToDisk)); set => WriteHere(nameof(CumulativeMaxPagesQueuedToDisk), value); }

        [Offset(1312UL)]
        public ulong CumulativePagesQueuedToDiskSamples { get => ReadHere<ulong>(nameof(CumulativePagesQueuedToDiskSamples)); set => WriteHere(nameof(CumulativePagesQueuedToDiskSamples), value); }

        [Offset(1320UL)]
        public ulong CumulativeTotalLoggedPagesQueuedToDisk { get => ReadHere<ulong>(nameof(CumulativeTotalLoggedPagesQueuedToDisk)); set => WriteHere(nameof(CumulativeTotalLoggedPagesQueuedToDisk), value); }

        [Offset(1328UL)]
        public ulong CumulativeMaxLoggedPagesQueuedToDisk { get => ReadHere<ulong>(nameof(CumulativeMaxLoggedPagesQueuedToDisk)); set => WriteHere(nameof(CumulativeMaxLoggedPagesQueuedToDisk), value); }

        [Offset(1336UL)]
        public ulong CumulativeLoggedPagesQueuedToDiskSamples { get => ReadHere<ulong>(nameof(CumulativeLoggedPagesQueuedToDiskSamples)); set => WriteHere(nameof(CumulativeLoggedPagesQueuedToDiskSamples), value); }

        [Offset(1344UL)]
        public ulong CumulativeReadTotalBytes { get => ReadHere<ulong>(nameof(CumulativeReadTotalBytes)); set => WriteHere(nameof(CumulativeReadTotalBytes), value); }

        [Offset(1352UL)]
        public ulong CumulativeReadPagedInTotalBytes { get => ReadHere<ulong>(nameof(CumulativeReadPagedInTotalBytes)); set => WriteHere(nameof(CumulativeReadPagedInTotalBytes), value); }

        [Offset(1360UL)]
        public ulong CumulativeReadAheadTotalBytes { get => ReadHere<ulong>(nameof(CumulativeReadAheadTotalBytes)); set => WriteHere(nameof(CumulativeReadAheadTotalBytes), value); }

        [Offset(1368UL)]
        public ulong CumulativeTotalSynchronousReadIoCount { get => ReadHere<ulong>(nameof(CumulativeTotalSynchronousReadIoCount)); set => WriteHere(nameof(CumulativeTotalSynchronousReadIoCount), value); }

        [Offset(1376UL)]
        public ulong CumulativeTotalSynchronousNonBlockingReadIoCount { get => ReadHere<ulong>(nameof(CumulativeTotalSynchronousNonBlockingReadIoCount)); set => WriteHere(nameof(CumulativeTotalSynchronousNonBlockingReadIoCount), value); }

        [Offset(1384UL)]
        public ulong CumulativeTotalFailedSynchronousNonBlockingReadIoCount { get => ReadHere<ulong>(nameof(CumulativeTotalFailedSynchronousNonBlockingReadIoCount)); set => WriteHere(nameof(CumulativeTotalFailedSynchronousNonBlockingReadIoCount), value); }

        [Offset(1392UL)]
        public ulong CumulativeTotalWrites { get => ReadHere<ulong>(nameof(CumulativeTotalWrites)); set => WriteHere(nameof(CumulativeTotalWrites), value); }

        [Offset(1400UL)]
        public ulong CumulativeTotalHardThrottleWrites { get => ReadHere<ulong>(nameof(CumulativeTotalHardThrottleWrites)); set => WriteHere(nameof(CumulativeTotalHardThrottleWrites), value); }

        [Offset(1408UL)]
        public ulong CumulativeTotalSoftThrottleWrites { get => ReadHere<ulong>(nameof(CumulativeTotalSoftThrottleWrites)); set => WriteHere(nameof(CumulativeTotalSoftThrottleWrites), value); }

        [Offset(1416UL)]
        public ulong CumulativeLazyWriterCalls { get => ReadHere<ulong>(nameof(CumulativeLazyWriterCalls)); set => WriteHere(nameof(CumulativeLazyWriterCalls), value); }

        [Offset(1424UL)]
        public ulong CumulativeLazyWriterLatency { get => ReadHere<ulong>(nameof(CumulativeLazyWriterLatency)); set => WriteHere(nameof(CumulativeLazyWriterLatency), value); }

        [Offset(1432UL)]
        public ulong CumulativeLazyWriterPagesFlushed { get => ReadHere<ulong>(nameof(CumulativeLazyWriterPagesFlushed)); set => WriteHere(nameof(CumulativeLazyWriterPagesFlushed), value); }

        [Offset(1440UL)]
        public ulong CumulativeLazyWriterAvgPagesPerSecond { get => ReadHere<ulong>(nameof(CumulativeLazyWriterAvgPagesPerSecond)); set => WriteHere(nameof(CumulativeLazyWriterAvgPagesPerSecond), value); }

        [Offset(1448UL)]
        public ulong CumulativeSynchronousReadIoMaxLatency { get => ReadHere<ulong>(nameof(CumulativeSynchronousReadIoMaxLatency)); set => WriteHere(nameof(CumulativeSynchronousReadIoMaxLatency), value); }

        [Offset(1456UL)]
        public ulong CumulativeSynchronousReadIoNonBlockingMaxLatency { get => ReadHere<ulong>(nameof(CumulativeSynchronousReadIoNonBlockingMaxLatency)); set => WriteHere(nameof(CumulativeSynchronousReadIoNonBlockingMaxLatency), value); }

        [Offset(1464UL)]
        [Length(12)]
        public DynamicArray CumulativeSynchronousReadIoCounts { get => ReadStructure<DynamicArray>(nameof(CumulativeSynchronousReadIoCounts)); set => WriteStructure(nameof(CumulativeSynchronousReadIoCounts), value); }

        [Offset(1560UL)]
        [Length(12)]
        public DynamicArray CumulativeSynchronousReadTotalLatency { get => ReadStructure<DynamicArray>(nameof(CumulativeSynchronousReadTotalLatency)); set => WriteStructure(nameof(CumulativeSynchronousReadTotalLatency), value); }

        [Offset(1656UL)]
        [Length(12)]
        public DynamicArray CumulativeSynchronousReadNonBlockingIoCounts { get => ReadStructure<DynamicArray>(nameof(CumulativeSynchronousReadNonBlockingIoCounts)); set => WriteStructure(nameof(CumulativeSynchronousReadNonBlockingIoCounts), value); }

        [Offset(1752UL)]
        [Length(12)]
        public DynamicArray CumulativeSynchronousReadNonBlockingTotalLatency { get => ReadStructure<DynamicArray>(nameof(CumulativeSynchronousReadNonBlockingTotalLatency)); set => WriteStructure(nameof(CumulativeSynchronousReadNonBlockingTotalLatency), value); }

        [Offset(1848UL)]
        public ulong CumulativeTotalSynchronousWriteIoCount { get => ReadHere<ulong>(nameof(CumulativeTotalSynchronousWriteIoCount)); set => WriteHere(nameof(CumulativeTotalSynchronousWriteIoCount), value); }

        [Offset(1856UL)]
        public ulong CumulativeTotalSynchronousNonBlockingWriteIoCount { get => ReadHere<ulong>(nameof(CumulativeTotalSynchronousNonBlockingWriteIoCount)); set => WriteHere(nameof(CumulativeTotalSynchronousNonBlockingWriteIoCount), value); }

        [Offset(1864UL)]
        public ulong CumulativeTotalFailedSynchronousNonBlockingWriteIoCount { get => ReadHere<ulong>(nameof(CumulativeTotalFailedSynchronousNonBlockingWriteIoCount)); set => WriteHere(nameof(CumulativeTotalFailedSynchronousNonBlockingWriteIoCount), value); }

        [Offset(1872UL)]
        public ulong CumulativeSynchronousWriteIoMaxLatency { get => ReadHere<ulong>(nameof(CumulativeSynchronousWriteIoMaxLatency)); set => WriteHere(nameof(CumulativeSynchronousWriteIoMaxLatency), value); }

        [Offset(1880UL)]
        public ulong CumulativeSynchronousWriteIoNonBlockingMaxLatency { get => ReadHere<ulong>(nameof(CumulativeSynchronousWriteIoNonBlockingMaxLatency)); set => WriteHere(nameof(CumulativeSynchronousWriteIoNonBlockingMaxLatency), value); }

        [Offset(1888UL)]
        [Length(12)]
        public DynamicArray CumulativeSynchronousWriteIoCounts { get => ReadStructure<DynamicArray>(nameof(CumulativeSynchronousWriteIoCounts)); set => WriteStructure(nameof(CumulativeSynchronousWriteIoCounts), value); }

        [Offset(1984UL)]
        [Length(12)]
        public DynamicArray CumulativeSynchronousWriteTotalLatency { get => ReadStructure<DynamicArray>(nameof(CumulativeSynchronousWriteTotalLatency)); set => WriteStructure(nameof(CumulativeSynchronousWriteTotalLatency), value); }

        [Offset(2080UL)]
        [Length(12)]
        public DynamicArray CumulativeSynchronousWriteNonBlockingIoCounts { get => ReadStructure<DynamicArray>(nameof(CumulativeSynchronousWriteNonBlockingIoCounts)); set => WriteStructure(nameof(CumulativeSynchronousWriteNonBlockingIoCounts), value); }

        [Offset(2176UL)]
        [Length(12)]
        public DynamicArray CumulativeSynchronousWriteNonBlockingTotalLatency { get => ReadStructure<DynamicArray>(nameof(CumulativeSynchronousWriteNonBlockingTotalLatency)); set => WriteStructure(nameof(CumulativeSynchronousWriteNonBlockingTotalLatency), value); }

        [Offset(2272UL)]
        public ulong CumulativeTotalAsynchronousReadIoCount { get => ReadHere<ulong>(nameof(CumulativeTotalAsynchronousReadIoCount)); set => WriteHere(nameof(CumulativeTotalAsynchronousReadIoCount), value); }

        [Offset(2280UL)]
        public ulong CumulativeAsynchronousReadIoMaxLatency { get => ReadHere<ulong>(nameof(CumulativeAsynchronousReadIoMaxLatency)); set => WriteHere(nameof(CumulativeAsynchronousReadIoMaxLatency), value); }

        [Offset(2288UL)]
        [Length(12)]
        public DynamicArray CumulativeAsynchronousReadIoCounts { get => ReadStructure<DynamicArray>(nameof(CumulativeAsynchronousReadIoCounts)); set => WriteStructure(nameof(CumulativeAsynchronousReadIoCounts), value); }

        [Offset(2384UL)]
        [Length(12)]
        public DynamicArray CumulativeAsynchronousReadTotalLatency { get => ReadStructure<DynamicArray>(nameof(CumulativeAsynchronousReadTotalLatency)); set => WriteStructure(nameof(CumulativeAsynchronousReadTotalLatency), value); }

        public CcVolumeTelemetry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CcVolumeTelemetry>();
        }
    }
}