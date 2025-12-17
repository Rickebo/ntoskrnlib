using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CC_FLUSH_PACKET")]
    public sealed class CcFlushPacket : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(8UL)]
        public IntPtr PrivateVolumeCacheMap { get => ReadHere<IntPtr>(nameof(PrivateVolumeCacheMap)); set => WriteHere(nameof(PrivateVolumeCacheMap), value); }

        [Offset(16UL)]
        public IntPtr SharedCacheMap { get => ReadHere<IntPtr>(nameof(SharedCacheMap)); set => WriteHere(nameof(SharedCacheMap), value); }

        [Offset(24UL)]
        public IntPtr SectionObjectPointer { get => ReadHere<IntPtr>(nameof(SectionObjectPointer)); set => WriteHere(nameof(SectionObjectPointer), value); }

        [Offset(32UL)]
        public LargeInteger TargetOffset { get => ReadStructure<LargeInteger>(nameof(TargetOffset)); set => WriteStructure(nameof(TargetOffset), value); }

        [Offset(40UL)]
        public LargeInteger NextFileOffset { get => ReadStructure<LargeInteger>(nameof(NextFileOffset)); set => WriteStructure(nameof(NextFileOffset), value); }

        [Offset(48UL)]
        public uint NextLength { get => ReadHere<uint>(nameof(NextLength)); set => WriteHere(nameof(NextLength), value); }

        [Offset(52UL)]
        public uint BytesWritten { get => ReadHere<uint>(nameof(BytesWritten)); set => WriteHere(nameof(BytesWritten), value); }

        [Offset(56UL)]
        public uint MmFlushFlags { get => ReadHere<uint>(nameof(MmFlushFlags)); set => WriteHere(nameof(MmFlushFlags), value); }

        [Offset(60UL)]
        public uint HotSpot { get => ReadHere<uint>(nameof(HotSpot)); set => WriteHere(nameof(HotSpot), value); }

        [Offset(64UL)]
        public uint VerifyRequired { get => ReadHere<uint>(nameof(VerifyRequired)); set => WriteHere(nameof(VerifyRequired), value); }

        [Offset(72UL)]
        public IntPtr FlushEvent { get => ReadHere<IntPtr>(nameof(FlushEvent)); set => WriteHere(nameof(FlushEvent), value); }

        [Offset(80UL)]
        public LargeInteger FlushLargestLsn { get => ReadStructure<LargeInteger>(nameof(FlushLargestLsn)); set => WriteStructure(nameof(FlushLargestLsn), value); }

        [Offset(88UL)]
        public IntPtr LargestLsn { get => ReadHere<IntPtr>(nameof(LargestLsn)); set => WriteHere(nameof(LargestLsn), value); }

        [Offset(96UL)]
        public IntPtr CallersFileOffset { get => ReadHere<IntPtr>(nameof(CallersFileOffset)); set => WriteHere(nameof(CallersFileOffset), value); }

        [Offset(104UL)]
        public uint CallersLength { get => ReadHere<uint>(nameof(CallersLength)); set => WriteHere(nameof(CallersLength), value); }

        [Offset(108UL)]
        public byte MarkWritethrough { get => ReadHere<byte>(nameof(MarkWritethrough)); set => WriteHere(nameof(MarkWritethrough), value); }

        [Offset(112UL)]
        public IntPtr CallersIoStatus { get => ReadHere<IntPtr>(nameof(CallersIoStatus)); set => WriteHere(nameof(CallersIoStatus), value); }

        [Offset(120UL)]
        public IntPtr FirstBcb { get => ReadHere<IntPtr>(nameof(FirstBcb)); set => WriteHere(nameof(FirstBcb), value); }

        [Offset(128UL)]
        public int FirstFailureStatus { get => ReadHere<int>(nameof(FirstFailureStatus)); set => WriteHere(nameof(FirstFailureStatus), value); }

        [Offset(132UL)]
        public byte IsLazyWriter { get => ReadHere<byte>(nameof(IsLazyWriter)); set => WriteHere(nameof(IsLazyWriter), value); }

        [Offset(133UL)]
        public byte FastLazyWrite { get => ReadHere<byte>(nameof(FastLazyWrite)); set => WriteHere(nameof(FastLazyWrite), value); }

        [Offset(134UL)]
        public byte ForceFullFlush { get => ReadHere<byte>(nameof(ForceFullFlush)); set => WriteHere(nameof(ForceFullFlush), value); }

        [Offset(135UL)]
        public byte PerformedFlushForMemMapped { get => ReadHere<byte>(nameof(PerformedFlushForMemMapped)); set => WriteHere(nameof(PerformedFlushForMemMapped), value); }

        [Offset(136UL)]
        public byte TeardownFlagBeforeFlush { get => ReadHere<byte>(nameof(TeardownFlagBeforeFlush)); set => WriteHere(nameof(TeardownFlagBeforeFlush), value); }

        [Offset(137UL)]
        public byte ShouldRetryTeardown { get => ReadHere<byte>(nameof(ShouldRetryTeardown)); set => WriteHere(nameof(ShouldRetryTeardown), value); }

        [Offset(138UL)]
        public byte FlushForImageSection { get => ReadHere<byte>(nameof(FlushForImageSection)); set => WriteHere(nameof(FlushForImageSection), value); }

        [Offset(139UL)]
        public byte ForceSynchronousLazyWrite { get => ReadHere<byte>(nameof(ForceSynchronousLazyWrite)); set => WriteHere(nameof(ForceSynchronousLazyWrite), value); }

        [Offset(140UL)]
        public uint AcquireForLazyWriteOutFlags { get => ReadHere<uint>(nameof(AcquireForLazyWriteOutFlags)); set => WriteHere(nameof(AcquireForLazyWriteOutFlags), value); }

        [Offset(144UL)]
        public byte FlushDontTrustHints { get => ReadHere<byte>(nameof(FlushDontTrustHints)); set => WriteHere(nameof(FlushDontTrustHints), value); }

        [Offset(152UL)]
        public LargeInteger StartTick { get => ReadStructure<LargeInteger>(nameof(StartTick)); set => WriteStructure(nameof(StartTick), value); }

        [Offset(160UL)]
        public LargeInteger EndTick { get => ReadStructure<LargeInteger>(nameof(EndTick)); set => WriteStructure(nameof(EndTick), value); }

        [Offset(168UL)]
        public IntPtr FsContext { get => ReadHere<IntPtr>(nameof(FsContext)); set => WriteHere(nameof(FsContext), value); }

        [Offset(176UL)]
        public IntPtr WorkEntry { get => ReadHere<IntPtr>(nameof(WorkEntry)); set => WriteHere(nameof(WorkEntry), value); }

        [Offset(184UL)]
        public IntPtr DeferredWritesList { get => ReadHere<IntPtr>(nameof(DeferredWritesList)); set => WriteHere(nameof(DeferredWritesList), value); }

        [Offset(192UL)]
        public IntPtr CoalescingState { get => ReadHere<IntPtr>(nameof(CoalescingState)); set => WriteHere(nameof(CoalescingState), value); }

        [Offset(200UL)]
        public byte DoSinglePassFlush { get => ReadHere<byte>(nameof(DoSinglePassFlush)); set => WriteHere(nameof(DoSinglePassFlush), value); }

        [Offset(201UL)]
        public byte RecordedSinglePassStartOffset { get => ReadHere<byte>(nameof(RecordedSinglePassStartOffset)); set => WriteHere(nameof(RecordedSinglePassStartOffset), value); }

        [Offset(208UL)]
        public LargeInteger SinglePassStartOffset { get => ReadStructure<LargeInteger>(nameof(SinglePassStartOffset)); set => WriteStructure(nameof(SinglePassStartOffset), value); }

        [Offset(216UL)]
        public ulong DirtyPagesAtStart { get => ReadHere<ulong>(nameof(DirtyPagesAtStart)); set => WriteHere(nameof(DirtyPagesAtStart), value); }

        [Offset(224UL)]
        public ulong TotalBytesWritten { get => ReadHere<ulong>(nameof(TotalBytesWritten)); set => WriteHere(nameof(TotalBytesWritten), value); }

        [Offset(232UL)]
        public LargeInteger LwFlushStart { get => ReadStructure<LargeInteger>(nameof(LwFlushStart)); set => WriteStructure(nameof(LwFlushStart), value); }

        [Offset(240UL)]
        public LargeInteger LwFlushEnd { get => ReadStructure<LargeInteger>(nameof(LwFlushEnd)); set => WriteStructure(nameof(LwFlushEnd), value); }

        [Offset(248UL)]
        public uint TotalPagesFlushed { get => ReadHere<uint>(nameof(TotalPagesFlushed)); set => WriteHere(nameof(TotalPagesFlushed), value); }

        [Offset(252UL)]
        public uint PagesToWrite { get => ReadHere<uint>(nameof(PagesToWrite)); set => WriteHere(nameof(PagesToWrite), value); }

        [Offset(256UL)]
        public uint RequeueToHeadCount { get => ReadHere<uint>(nameof(RequeueToHeadCount)); set => WriteHere(nameof(RequeueToHeadCount), value); }

        [Offset(264UL)]
        public IntPtr WorkQueueEntry { get => ReadHere<IntPtr>(nameof(WorkQueueEntry)); set => WriteHere(nameof(WorkQueueEntry), value); }

        public CcFlushPacket(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CcFlushPacket>();
        }
    }
}