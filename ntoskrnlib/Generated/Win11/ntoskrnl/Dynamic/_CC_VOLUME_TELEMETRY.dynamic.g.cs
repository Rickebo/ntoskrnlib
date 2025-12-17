using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CC_VOLUME_TELEMETRY")]
    public sealed class _CC_VOLUME_TELEMETRY : DynamicStructure
    {
        public _GUID DeviceGuid { get; }
        public ulong TotalDirtyPages { get; }
        public ulong MaxDirtyPages { get; }
        public ulong TotalDirtyPageThreshold { get; }
        public ulong TopDirtyPageThreshold { get; }
        public ulong BottomDirtyPageThreshold { get; }
        public ulong DirtyPageSamples { get; }
        public ulong TotalPagesQueuedToDisk { get; }
        public ulong MaxPagesQueuedToDisk { get; }
        public ulong PagesQueuedToDiskSamples { get; }
        public ulong TotalLoggedPagesQueuedToDisk { get; }
        public ulong MaxLoggedPagesQueuedToDisk { get; }
        public ulong LoggedPagesQueuedToDiskSamples { get; }
        public ulong ReadTotalBytes { get; }
        public ulong ReadPagedInTotalBytes { get; }
        public ulong ReadAheadTotalBytes { get; }
        public ulong TotalSynchronousReadIoCount { get; }
        public ulong TotalSynchronousNonBlockingReadIoCount { get; }
        public ulong TotalFailedSynchronousNonBlockingReadIoCount { get; }
        public ulong TotalWrites { get; }
        public ulong TotalHardThrottleWrites { get; }
        public ulong TotalSoftThrottleWrites { get; }
        public ulong TotalLazyWriterCalls { get; }
        public ulong TotalLazyWriterLatency { get; }
        public ulong TotalLazyWriterPagesFlushed { get; }
        public ulong TotalLazyWriterAvgPagesPerSecond { get; }
        public ulong SynchronousReadIoMaxLatency { get; }
        public ulong SynchronousReadIoNonBlockingMaxLatency { get; }
        public ulong[] SynchronousReadIoCounts { get; }
        public ulong[] SynchronousReadTotalLatency { get; }
        public ulong[] SynchronousReadNonBlockingIoCounts { get; }
        public ulong[] SynchronousReadNonBlockingTotalLatency { get; }
        public ulong TotalSynchronousWriteIoCount { get; }
        public ulong TotalSynchronousNonBlockingWriteIoCount { get; }
        public ulong TotalFailedSynchronousNonBlockingWriteIoCount { get; }
        public ulong SynchronousWriteIoMaxLatency { get; }
        public ulong SynchronousWriteIoNonBlockingMaxLatency { get; }
        public ulong[] SynchronousWriteIoCounts { get; }
        public ulong[] SynchronousWriteTotalLatency { get; }
        public ulong[] SynchronousWriteNonBlockingIoCounts { get; }
        public ulong[] SynchronousWriteNonBlockingTotalLatency { get; }
        public ulong TotalAsynchronousReadIoCount { get; }
        public ulong AsynchronousReadIoMaxLatency { get; }
        public ulong[] AsynchronousReadIoCounts { get; }
        public ulong[] AsynchronousReadTotalLatency { get; }
        public ulong CumulativeTotalDirtyPages { get; }
        public ulong CumulativeMaxDirtyPages { get; }
        public ulong CumulativeDirtyPageThreshold { get; }
        public ulong CumulativeTopDirtyPageThreshold { get; }
        public ulong CumulativeBottomDirtyPageThreshold { get; }
        public ulong CumulativeDirtyPageSamples { get; }
        public ulong CumulativeTotalPagesQueuedToDisk { get; }
        public ulong CumulativeMaxPagesQueuedToDisk { get; }
        public ulong CumulativePagesQueuedToDiskSamples { get; }
        public ulong CumulativeTotalLoggedPagesQueuedToDisk { get; }
        public ulong CumulativeMaxLoggedPagesQueuedToDisk { get; }
        public ulong CumulativeLoggedPagesQueuedToDiskSamples { get; }
        public ulong CumulativeReadTotalBytes { get; }
        public ulong CumulativeReadPagedInTotalBytes { get; }
        public ulong CumulativeReadAheadTotalBytes { get; }
        public ulong CumulativeTotalSynchronousReadIoCount { get; }
        public ulong CumulativeTotalSynchronousNonBlockingReadIoCount { get; }
        public ulong CumulativeTotalFailedSynchronousNonBlockingReadIoCount { get; }
        public ulong CumulativeTotalWrites { get; }
        public ulong CumulativeTotalHardThrottleWrites { get; }
        public ulong CumulativeTotalSoftThrottleWrites { get; }
        public ulong CumulativeLazyWriterCalls { get; }
        public ulong CumulativeLazyWriterLatency { get; }
        public ulong CumulativeLazyWriterPagesFlushed { get; }
        public ulong CumulativeLazyWriterAvgPagesPerSecond { get; }
        public ulong CumulativeSynchronousReadIoMaxLatency { get; }
        public ulong CumulativeSynchronousReadIoNonBlockingMaxLatency { get; }
        public ulong[] CumulativeSynchronousReadIoCounts { get; }
        public ulong[] CumulativeSynchronousReadTotalLatency { get; }
        public ulong[] CumulativeSynchronousReadNonBlockingIoCounts { get; }
        public ulong[] CumulativeSynchronousReadNonBlockingTotalLatency { get; }
        public ulong CumulativeTotalSynchronousWriteIoCount { get; }
        public ulong CumulativeTotalSynchronousNonBlockingWriteIoCount { get; }
        public ulong CumulativeTotalFailedSynchronousNonBlockingWriteIoCount { get; }
        public ulong CumulativeSynchronousWriteIoMaxLatency { get; }
        public ulong CumulativeSynchronousWriteIoNonBlockingMaxLatency { get; }
        public ulong[] CumulativeSynchronousWriteIoCounts { get; }
        public ulong[] CumulativeSynchronousWriteTotalLatency { get; }
        public ulong[] CumulativeSynchronousWriteNonBlockingIoCounts { get; }
        public ulong[] CumulativeSynchronousWriteNonBlockingTotalLatency { get; }
        public ulong CumulativeTotalAsynchronousReadIoCount { get; }
        public ulong CumulativeAsynchronousReadIoMaxLatency { get; }
        public ulong[] CumulativeAsynchronousReadIoCounts { get; }
        public ulong[] CumulativeAsynchronousReadTotalLatency { get; }

        public _CC_VOLUME_TELEMETRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CC_VOLUME_TELEMETRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CC_VOLUME_TELEMETRY.DeviceGuid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalDirtyPages),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.MaxDirtyPages),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalDirtyPageThreshold),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TopDirtyPageThreshold),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.BottomDirtyPageThreshold),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.DirtyPageSamples),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalPagesQueuedToDisk),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.MaxPagesQueuedToDisk),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.PagesQueuedToDiskSamples),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalLoggedPagesQueuedToDisk),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.MaxLoggedPagesQueuedToDisk),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.LoggedPagesQueuedToDiskSamples),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.ReadTotalBytes),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.ReadPagedInTotalBytes),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.ReadAheadTotalBytes),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalSynchronousReadIoCount),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalSynchronousNonBlockingReadIoCount),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalFailedSynchronousNonBlockingReadIoCount),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalWrites),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalHardThrottleWrites),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalSoftThrottleWrites),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalLazyWriterCalls),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalLazyWriterLatency),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalLazyWriterPagesFlushed),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalLazyWriterAvgPagesPerSecond),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.SynchronousReadIoMaxLatency),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.SynchronousReadIoNonBlockingMaxLatency),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.SynchronousReadIoCounts),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.SynchronousReadTotalLatency),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.SynchronousReadNonBlockingIoCounts),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.SynchronousReadNonBlockingTotalLatency),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalSynchronousWriteIoCount),
                    new ulong[]
                    {
                        616UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalSynchronousNonBlockingWriteIoCount),
                    new ulong[]
                    {
                        624UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalFailedSynchronousNonBlockingWriteIoCount),
                    new ulong[]
                    {
                        632UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.SynchronousWriteIoMaxLatency),
                    new ulong[]
                    {
                        640UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.SynchronousWriteIoNonBlockingMaxLatency),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.SynchronousWriteIoCounts),
                    new ulong[]
                    {
                        656UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.SynchronousWriteTotalLatency),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.SynchronousWriteNonBlockingIoCounts),
                    new ulong[]
                    {
                        848UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.SynchronousWriteNonBlockingTotalLatency),
                    new ulong[]
                    {
                        944UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.TotalAsynchronousReadIoCount),
                    new ulong[]
                    {
                        1040UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.AsynchronousReadIoMaxLatency),
                    new ulong[]
                    {
                        1048UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.AsynchronousReadIoCounts),
                    new ulong[]
                    {
                        1056UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.AsynchronousReadTotalLatency),
                    new ulong[]
                    {
                        1152UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeTotalDirtyPages),
                    new ulong[]
                    {
                        1248UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeMaxDirtyPages),
                    new ulong[]
                    {
                        1256UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeDirtyPageThreshold),
                    new ulong[]
                    {
                        1264UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeTopDirtyPageThreshold),
                    new ulong[]
                    {
                        1272UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeBottomDirtyPageThreshold),
                    new ulong[]
                    {
                        1280UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeDirtyPageSamples),
                    new ulong[]
                    {
                        1288UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeTotalPagesQueuedToDisk),
                    new ulong[]
                    {
                        1296UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeMaxPagesQueuedToDisk),
                    new ulong[]
                    {
                        1304UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativePagesQueuedToDiskSamples),
                    new ulong[]
                    {
                        1312UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeTotalLoggedPagesQueuedToDisk),
                    new ulong[]
                    {
                        1320UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeMaxLoggedPagesQueuedToDisk),
                    new ulong[]
                    {
                        1328UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeLoggedPagesQueuedToDiskSamples),
                    new ulong[]
                    {
                        1336UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeReadTotalBytes),
                    new ulong[]
                    {
                        1344UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeReadPagedInTotalBytes),
                    new ulong[]
                    {
                        1352UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeReadAheadTotalBytes),
                    new ulong[]
                    {
                        1360UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeTotalSynchronousReadIoCount),
                    new ulong[]
                    {
                        1368UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeTotalSynchronousNonBlockingReadIoCount),
                    new ulong[]
                    {
                        1376UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeTotalFailedSynchronousNonBlockingReadIoCount),
                    new ulong[]
                    {
                        1384UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeTotalWrites),
                    new ulong[]
                    {
                        1392UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeTotalHardThrottleWrites),
                    new ulong[]
                    {
                        1400UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeTotalSoftThrottleWrites),
                    new ulong[]
                    {
                        1408UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeLazyWriterCalls),
                    new ulong[]
                    {
                        1416UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeLazyWriterLatency),
                    new ulong[]
                    {
                        1424UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeLazyWriterPagesFlushed),
                    new ulong[]
                    {
                        1432UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeLazyWriterAvgPagesPerSecond),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeSynchronousReadIoMaxLatency),
                    new ulong[]
                    {
                        1448UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeSynchronousReadIoNonBlockingMaxLatency),
                    new ulong[]
                    {
                        1456UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeSynchronousReadIoCounts),
                    new ulong[]
                    {
                        1464UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeSynchronousReadTotalLatency),
                    new ulong[]
                    {
                        1560UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeSynchronousReadNonBlockingIoCounts),
                    new ulong[]
                    {
                        1656UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeSynchronousReadNonBlockingTotalLatency),
                    new ulong[]
                    {
                        1752UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeTotalSynchronousWriteIoCount),
                    new ulong[]
                    {
                        1848UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeTotalSynchronousNonBlockingWriteIoCount),
                    new ulong[]
                    {
                        1856UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeTotalFailedSynchronousNonBlockingWriteIoCount),
                    new ulong[]
                    {
                        1864UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeSynchronousWriteIoMaxLatency),
                    new ulong[]
                    {
                        1872UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeSynchronousWriteIoNonBlockingMaxLatency),
                    new ulong[]
                    {
                        1880UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeSynchronousWriteIoCounts),
                    new ulong[]
                    {
                        1888UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeSynchronousWriteTotalLatency),
                    new ulong[]
                    {
                        1984UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeSynchronousWriteNonBlockingIoCounts),
                    new ulong[]
                    {
                        2080UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeSynchronousWriteNonBlockingTotalLatency),
                    new ulong[]
                    {
                        2176UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeTotalAsynchronousReadIoCount),
                    new ulong[]
                    {
                        2272UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeAsynchronousReadIoMaxLatency),
                    new ulong[]
                    {
                        2280UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeAsynchronousReadIoCounts),
                    new ulong[]
                    {
                        2288UL
                    }
                },
                {
                    nameof(_CC_VOLUME_TELEMETRY.CumulativeAsynchronousReadTotalLatency),
                    new ulong[]
                    {
                        2384UL
                    }
                }
            };
            Register<_CC_VOLUME_TELEMETRY>((mem, ptr) => new _CC_VOLUME_TELEMETRY(mem, ptr), offsets);
        }
    }
}