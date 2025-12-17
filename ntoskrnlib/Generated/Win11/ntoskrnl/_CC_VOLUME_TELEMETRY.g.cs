#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2480)]
    public partial struct _CC_VOLUME_TELEMETRY
    {
        [FieldOffset(0)]
        public _GUID DeviceGuid;
        [FieldOffset(16)]
        public ulong TotalDirtyPages;
        [FieldOffset(24)]
        public ulong MaxDirtyPages;
        [FieldOffset(32)]
        public ulong TotalDirtyPageThreshold;
        [FieldOffset(40)]
        public ulong TopDirtyPageThreshold;
        [FieldOffset(48)]
        public ulong BottomDirtyPageThreshold;
        [FieldOffset(56)]
        public ulong DirtyPageSamples;
        [FieldOffset(64)]
        public ulong TotalPagesQueuedToDisk;
        [FieldOffset(72)]
        public ulong MaxPagesQueuedToDisk;
        [FieldOffset(80)]
        public ulong PagesQueuedToDiskSamples;
        [FieldOffset(88)]
        public ulong TotalLoggedPagesQueuedToDisk;
        [FieldOffset(96)]
        public ulong MaxLoggedPagesQueuedToDisk;
        [FieldOffset(104)]
        public ulong LoggedPagesQueuedToDiskSamples;
        [FieldOffset(112)]
        public ulong ReadTotalBytes;
        [FieldOffset(120)]
        public ulong ReadPagedInTotalBytes;
        [FieldOffset(128)]
        public ulong ReadAheadTotalBytes;
        [FieldOffset(136)]
        public ulong TotalSynchronousReadIoCount;
        [FieldOffset(144)]
        public ulong TotalSynchronousNonBlockingReadIoCount;
        [FieldOffset(152)]
        public ulong TotalFailedSynchronousNonBlockingReadIoCount;
        [FieldOffset(160)]
        public ulong TotalWrites;
        [FieldOffset(168)]
        public ulong TotalHardThrottleWrites;
        [FieldOffset(176)]
        public ulong TotalSoftThrottleWrites;
        [FieldOffset(184)]
        public ulong TotalLazyWriterCalls;
        [FieldOffset(192)]
        public ulong TotalLazyWriterLatency;
        [FieldOffset(200)]
        public ulong TotalLazyWriterPagesFlushed;
        [FieldOffset(208)]
        public ulong TotalLazyWriterAvgPagesPerSecond;
        [FieldOffset(216)]
        public ulong SynchronousReadIoMaxLatency;
        [FieldOffset(224)]
        public ulong SynchronousReadIoNonBlockingMaxLatency;
        [FieldOffset(232)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] SynchronousReadIoCounts;
        [FieldOffset(328)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] SynchronousReadTotalLatency;
        [FieldOffset(424)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] SynchronousReadNonBlockingIoCounts;
        [FieldOffset(520)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] SynchronousReadNonBlockingTotalLatency;
        [FieldOffset(616)]
        public ulong TotalSynchronousWriteIoCount;
        [FieldOffset(624)]
        public ulong TotalSynchronousNonBlockingWriteIoCount;
        [FieldOffset(632)]
        public ulong TotalFailedSynchronousNonBlockingWriteIoCount;
        [FieldOffset(640)]
        public ulong SynchronousWriteIoMaxLatency;
        [FieldOffset(648)]
        public ulong SynchronousWriteIoNonBlockingMaxLatency;
        [FieldOffset(656)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] SynchronousWriteIoCounts;
        [FieldOffset(752)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] SynchronousWriteTotalLatency;
        [FieldOffset(848)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] SynchronousWriteNonBlockingIoCounts;
        [FieldOffset(944)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] SynchronousWriteNonBlockingTotalLatency;
        [FieldOffset(1040)]
        public ulong TotalAsynchronousReadIoCount;
        [FieldOffset(1048)]
        public ulong AsynchronousReadIoMaxLatency;
        [FieldOffset(1056)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] AsynchronousReadIoCounts;
        [FieldOffset(1152)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] AsynchronousReadTotalLatency;
        [FieldOffset(1248)]
        public ulong CumulativeTotalDirtyPages;
        [FieldOffset(1256)]
        public ulong CumulativeMaxDirtyPages;
        [FieldOffset(1264)]
        public ulong CumulativeDirtyPageThreshold;
        [FieldOffset(1272)]
        public ulong CumulativeTopDirtyPageThreshold;
        [FieldOffset(1280)]
        public ulong CumulativeBottomDirtyPageThreshold;
        [FieldOffset(1288)]
        public ulong CumulativeDirtyPageSamples;
        [FieldOffset(1296)]
        public ulong CumulativeTotalPagesQueuedToDisk;
        [FieldOffset(1304)]
        public ulong CumulativeMaxPagesQueuedToDisk;
        [FieldOffset(1312)]
        public ulong CumulativePagesQueuedToDiskSamples;
        [FieldOffset(1320)]
        public ulong CumulativeTotalLoggedPagesQueuedToDisk;
        [FieldOffset(1328)]
        public ulong CumulativeMaxLoggedPagesQueuedToDisk;
        [FieldOffset(1336)]
        public ulong CumulativeLoggedPagesQueuedToDiskSamples;
        [FieldOffset(1344)]
        public ulong CumulativeReadTotalBytes;
        [FieldOffset(1352)]
        public ulong CumulativeReadPagedInTotalBytes;
        [FieldOffset(1360)]
        public ulong CumulativeReadAheadTotalBytes;
        [FieldOffset(1368)]
        public ulong CumulativeTotalSynchronousReadIoCount;
        [FieldOffset(1376)]
        public ulong CumulativeTotalSynchronousNonBlockingReadIoCount;
        [FieldOffset(1384)]
        public ulong CumulativeTotalFailedSynchronousNonBlockingReadIoCount;
        [FieldOffset(1392)]
        public ulong CumulativeTotalWrites;
        [FieldOffset(1400)]
        public ulong CumulativeTotalHardThrottleWrites;
        [FieldOffset(1408)]
        public ulong CumulativeTotalSoftThrottleWrites;
        [FieldOffset(1416)]
        public ulong CumulativeLazyWriterCalls;
        [FieldOffset(1424)]
        public ulong CumulativeLazyWriterLatency;
        [FieldOffset(1432)]
        public ulong CumulativeLazyWriterPagesFlushed;
        [FieldOffset(1440)]
        public ulong CumulativeLazyWriterAvgPagesPerSecond;
        [FieldOffset(1448)]
        public ulong CumulativeSynchronousReadIoMaxLatency;
        [FieldOffset(1456)]
        public ulong CumulativeSynchronousReadIoNonBlockingMaxLatency;
        [FieldOffset(1464)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] CumulativeSynchronousReadIoCounts;
        [FieldOffset(1560)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] CumulativeSynchronousReadTotalLatency;
        [FieldOffset(1656)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] CumulativeSynchronousReadNonBlockingIoCounts;
        [FieldOffset(1752)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] CumulativeSynchronousReadNonBlockingTotalLatency;
        [FieldOffset(1848)]
        public ulong CumulativeTotalSynchronousWriteIoCount;
        [FieldOffset(1856)]
        public ulong CumulativeTotalSynchronousNonBlockingWriteIoCount;
        [FieldOffset(1864)]
        public ulong CumulativeTotalFailedSynchronousNonBlockingWriteIoCount;
        [FieldOffset(1872)]
        public ulong CumulativeSynchronousWriteIoMaxLatency;
        [FieldOffset(1880)]
        public ulong CumulativeSynchronousWriteIoNonBlockingMaxLatency;
        [FieldOffset(1888)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] CumulativeSynchronousWriteIoCounts;
        [FieldOffset(1984)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] CumulativeSynchronousWriteTotalLatency;
        [FieldOffset(2080)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] CumulativeSynchronousWriteNonBlockingIoCounts;
        [FieldOffset(2176)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] CumulativeSynchronousWriteNonBlockingTotalLatency;
        [FieldOffset(2272)]
        public ulong CumulativeTotalAsynchronousReadIoCount;
        [FieldOffset(2280)]
        public ulong CumulativeAsynchronousReadIoMaxLatency;
        [FieldOffset(2288)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] CumulativeAsynchronousReadIoCounts;
        [FieldOffset(2384)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public ulong[] CumulativeAsynchronousReadTotalLatency;
    }
}