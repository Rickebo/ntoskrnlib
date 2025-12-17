#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 272)]
    public partial struct _CC_FLUSH_PACKET
    {
        [FieldOffset(0)]
        public IntPtr Partition;
        [FieldOffset(8)]
        public IntPtr PrivateVolumeCacheMap;
        [FieldOffset(16)]
        public IntPtr SharedCacheMap;
        [FieldOffset(24)]
        public IntPtr SectionObjectPointer;
        [FieldOffset(32)]
        public _LARGE_INTEGER TargetOffset;
        [FieldOffset(40)]
        public _LARGE_INTEGER NextFileOffset;
        [FieldOffset(48)]
        public uint NextLength;
        [FieldOffset(52)]
        public uint BytesWritten;
        [FieldOffset(56)]
        public uint MmFlushFlags;
        [FieldOffset(60)]
        public uint HotSpot;
        [FieldOffset(64)]
        public uint VerifyRequired;
        [FieldOffset(72)]
        public IntPtr FlushEvent;
        [FieldOffset(80)]
        public _LARGE_INTEGER FlushLargestLsn;
        [FieldOffset(88)]
        public IntPtr LargestLsn;
        [FieldOffset(96)]
        public IntPtr CallersFileOffset;
        [FieldOffset(104)]
        public uint CallersLength;
        [FieldOffset(108)]
        public byte MarkWritethrough;
        [FieldOffset(112)]
        public IntPtr CallersIoStatus;
        [FieldOffset(120)]
        public IntPtr FirstBcb;
        [FieldOffset(128)]
        public int FirstFailureStatus;
        [FieldOffset(132)]
        public byte IsLazyWriter;
        [FieldOffset(133)]
        public byte FastLazyWrite;
        [FieldOffset(134)]
        public byte ForceFullFlush;
        [FieldOffset(135)]
        public byte PerformedFlushForMemMapped;
        [FieldOffset(136)]
        public byte TeardownFlagBeforeFlush;
        [FieldOffset(137)]
        public byte ShouldRetryTeardown;
        [FieldOffset(138)]
        public byte FlushForImageSection;
        [FieldOffset(139)]
        public byte ForceSynchronousLazyWrite;
        [FieldOffset(140)]
        public uint AcquireForLazyWriteOutFlags;
        [FieldOffset(144)]
        public byte FlushDontTrustHints;
        [FieldOffset(152)]
        public _LARGE_INTEGER StartTick;
        [FieldOffset(160)]
        public _LARGE_INTEGER EndTick;
        [FieldOffset(168)]
        public IntPtr FsContext;
        [FieldOffset(176)]
        public IntPtr WorkEntry;
        [FieldOffset(184)]
        public IntPtr DeferredWritesList;
        [FieldOffset(192)]
        public IntPtr CoalescingState;
        [FieldOffset(200)]
        public byte DoSinglePassFlush;
        [FieldOffset(201)]
        public byte RecordedSinglePassStartOffset;
        [FieldOffset(208)]
        public _LARGE_INTEGER SinglePassStartOffset;
        [FieldOffset(216)]
        public ulong DirtyPagesAtStart;
        [FieldOffset(224)]
        public ulong TotalBytesWritten;
        [FieldOffset(232)]
        public _LARGE_INTEGER LwFlushStart;
        [FieldOffset(240)]
        public _LARGE_INTEGER LwFlushEnd;
        [FieldOffset(248)]
        public uint TotalPagesFlushed;
        [FieldOffset(252)]
        public uint PagesToWrite;
        [FieldOffset(256)]
        public uint RequeueToHeadCount;
        [FieldOffset(264)]
        public IntPtr WorkQueueEntry;
    }
}