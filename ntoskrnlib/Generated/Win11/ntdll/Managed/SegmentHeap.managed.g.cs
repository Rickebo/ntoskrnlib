using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_SEGMENT_HEAP")]
    public sealed class SegmentHeap : DynamicStructure
    {
        [Offset(0UL)]
        public RtlHpEnvHandle EnvHandle { get => ReadStructure<RtlHpEnvHandle>(nameof(EnvHandle)); set => WriteStructure(nameof(EnvHandle), value); }

        [Offset(16UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(20UL)]
        public uint GlobalFlags { get => ReadHere<uint>(nameof(GlobalFlags)); set => WriteHere(nameof(GlobalFlags), value); }

        [Offset(24UL)]
        public uint Interceptor { get => ReadHere<uint>(nameof(Interceptor)); set => WriteHere(nameof(Interceptor), value); }

        [Offset(28UL)]
        public ushort ProcessHeapListIndex { get => ReadHere<ushort>(nameof(ProcessHeapListIndex)); set => WriteHere(nameof(ProcessHeapListIndex), value); }

        [Offset(30UL)]
        public ushort AllocatedFromMetadata { get => ReadHere<ushort>(nameof(AllocatedFromMetadata)); set => WriteHere(nameof(AllocatedFromMetadata), value); }

        [Offset(30UL)]
        public ushort ReadOnly { get => ReadHere<ushort>(nameof(ReadOnly)); set => WriteHere(nameof(ReadOnly), value); }

        [Offset(30UL)]
        public ushort InternalFlags { get => ReadHere<ushort>(nameof(InternalFlags)); set => WriteHere(nameof(InternalFlags), value); }

        [Offset(32UL)]
        public RtlpHeapCommitLimitData CommitLimitData { get => ReadStructure<RtlpHeapCommitLimitData>(nameof(CommitLimitData)); set => WriteStructure(nameof(CommitLimitData), value); }

        [Offset(48UL)]
        public ulong ReservedMustBeZero { get => ReadHere<ulong>(nameof(ReservedMustBeZero)); set => WriteHere(nameof(ReservedMustBeZero), value); }

        [Offset(56UL)]
        public IntPtr UserContext { get => ReadHere<IntPtr>(nameof(UserContext)); set => WriteHere(nameof(UserContext), value); }

        [Offset(64UL)]
        public ulong LargeMetadataLock { get => ReadHere<ulong>(nameof(LargeMetadataLock)); set => WriteHere(nameof(LargeMetadataLock), value); }

        [Offset(72UL)]
        public RtlRbTree LargeAllocMetadata { get => ReadStructure<RtlRbTree>(nameof(LargeAllocMetadata)); set => WriteStructure(nameof(LargeAllocMetadata), value); }

        [Offset(88UL)]
        public ulong LargeReservedPages { get => ReadHere<ulong>(nameof(LargeReservedPages)); set => WriteHere(nameof(LargeReservedPages), value); }

        [Offset(96UL)]
        public ulong LargeCommittedPages { get => ReadHere<ulong>(nameof(LargeCommittedPages)); set => WriteHere(nameof(LargeCommittedPages), value); }

        [Offset(104UL)]
        public ulong Tag { get => ReadHere<ulong>(nameof(Tag)); set => WriteHere(nameof(Tag), value); }

        [Offset(112UL)]
        public RtlRunOnce StackTraceInitVar { get => ReadStructure<RtlRunOnce>(nameof(StackTraceInitVar)); set => WriteStructure(nameof(StackTraceInitVar), value); }

        [Offset(128UL)]
        public HeapRuntimeMemoryStats MemStats { get => ReadStructure<HeapRuntimeMemoryStats>(nameof(MemStats)); set => WriteStructure(nameof(MemStats), value); }

        [Offset(224UL)]
        public uint GlobalLockOwner { get => ReadHere<uint>(nameof(GlobalLockOwner)); set => WriteHere(nameof(GlobalLockOwner), value); }

        [Offset(232UL)]
        public ulong ContextExtendLock { get => ReadHere<ulong>(nameof(ContextExtendLock)); set => WriteHere(nameof(ContextExtendLock), value); }

        [Offset(240UL)]
        public IntPtr AllocatedBase { get => ReadHere<IntPtr>(nameof(AllocatedBase)); set => WriteHere(nameof(AllocatedBase), value); }

        [Offset(248UL)]
        public IntPtr UncommittedBase { get => ReadHere<IntPtr>(nameof(UncommittedBase)); set => WriteHere(nameof(UncommittedBase), value); }

        [Offset(256UL)]
        public IntPtr ReservedLimit { get => ReadHere<IntPtr>(nameof(ReservedLimit)); set => WriteHere(nameof(ReservedLimit), value); }

        [Offset(264UL)]
        public IntPtr ReservedRegionEnd { get => ReadHere<IntPtr>(nameof(ReservedRegionEnd)); set => WriteHere(nameof(ReservedRegionEnd), value); }

        [Offset(272UL)]
        public RtlHpHeapVaCallbacksEncoded CallbacksEncoded { get => ReadStructure<RtlHpHeapVaCallbacksEncoded>(nameof(CallbacksEncoded)); set => WriteStructure(nameof(CallbacksEncoded), value); }

        [Offset(320UL)]
        [Length(2)]
        public DynamicArray SegContexts { get => ReadStructure<DynamicArray>(nameof(SegContexts)); set => WriteStructure(nameof(SegContexts), value); }

        [Offset(704UL)]
        public HeapVsContext VsContext { get => ReadStructure<HeapVsContext>(nameof(VsContext)); set => WriteStructure(nameof(VsContext), value); }

        [Offset(832UL)]
        public HeapLfhContext LfhContext { get => ReadStructure<HeapLfhContext>(nameof(LfhContext)); set => WriteStructure(nameof(LfhContext), value); }

        public SegmentHeap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SegmentHeap>();
        }
    }
}