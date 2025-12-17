using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_CORE")]
    public sealed class MiPartitionCore : DynamicStructure
    {
        [Offset(0UL)]
        public ushort PartitionId { get => ReadHere<ushort>(nameof(PartitionId)); set => WriteHere(nameof(PartitionId), value); }

        [Offset(4UL)]
        public MiPartitionFlags Flags { get => ReadStructure<MiPartitionFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(8UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(12UL)]
        public byte MemoryConfigurationChanged { get => ReadHere<byte>(nameof(MemoryConfigurationChanged)); set => WriteHere(nameof(MemoryConfigurationChanged), value); }

        [Offset(16UL)]
        public IntPtr NodeInformation { get => ReadHere<IntPtr>(nameof(NodeInformation)); set => WriteHere(nameof(NodeInformation), value); }

        [Offset(24UL)]
        public RtlAvlTree PageRoot { get => ReadStructure<RtlAvlTree>(nameof(PageRoot)); set => WriteStructure(nameof(PageRoot), value); }

        [Offset(32UL)]
        public IntPtr MemoryNodeRuns { get => ReadHere<IntPtr>(nameof(MemoryNodeRuns)); set => WriteHere(nameof(MemoryNodeRuns), value); }

        [Offset(40UL)]
        public WorkQueueItem PfnUnmapWorkItem { get => ReadStructure<WorkQueueItem>(nameof(PfnUnmapWorkItem)); set => WriteStructure(nameof(PfnUnmapWorkItem), value); }

        [Offset(72UL)]
        public ulong PfnUnmapCount { get => ReadHere<ulong>(nameof(PfnUnmapCount)); set => WriteHere(nameof(PfnUnmapCount), value); }

        [Offset(80UL)]
        public IntPtr MemoryRuns { get => ReadHere<IntPtr>(nameof(MemoryRuns)); set => WriteHere(nameof(MemoryRuns), value); }

        [Offset(88UL)]
        public Kevent ExitEvent { get => ReadStructure<Kevent>(nameof(ExitEvent)); set => WriteStructure(nameof(ExitEvent), value); }

        [Offset(112UL)]
        public Kevent ConductorNeededEvent { get => ReadStructure<Kevent>(nameof(ConductorNeededEvent)); set => WriteStructure(nameof(ConductorNeededEvent), value); }

        [Offset(136UL)]
        [Length(6)]
        public DynamicArray SystemThreadHandles { get => ReadStructure<DynamicArray>(nameof(SystemThreadHandles)); set => WriteStructure(nameof(SystemThreadHandles), value); }

        [Offset(184UL)]
        public IntPtr PartitionObject { get => ReadHere<IntPtr>(nameof(PartitionObject)); set => WriteHere(nameof(PartitionObject), value); }

        [Offset(192UL)]
        public ExPushLock DynamicMemoryPushLock { get => ReadStructure<ExPushLock>(nameof(DynamicMemoryPushLock)); set => WriteStructure(nameof(DynamicMemoryPushLock), value); }

        [Offset(200UL)]
        public int DynamicMemoryLock { get => ReadHere<int>(nameof(DynamicMemoryLock)); set => WriteHere(nameof(DynamicMemoryLock), value); }

        [Offset(204UL)]
        public byte PfnUnmapActive { get => ReadHere<byte>(nameof(PfnUnmapActive)); set => WriteHere(nameof(PfnUnmapActive), value); }

        [Offset(208UL)]
        public Kevent TemporaryMemoryEvent { get => ReadStructure<Kevent>(nameof(TemporaryMemoryEvent)); set => WriteStructure(nameof(TemporaryMemoryEvent), value); }

        [Offset(232UL)]
        public IntPtr RootDirectory { get => ReadHere<IntPtr>(nameof(RootDirectory)); set => WriteHere(nameof(RootDirectory), value); }

        [Offset(240UL)]
        public IntPtr KernelObjectsDirectory { get => ReadHere<IntPtr>(nameof(KernelObjectsDirectory)); set => WriteHere(nameof(KernelObjectsDirectory), value); }

        [Offset(248UL)]
        [Length(11)]
        public DynamicArray MemoryEvents { get => ReadStructure<DynamicArray>(nameof(MemoryEvents)); set => WriteStructure(nameof(MemoryEvents), value); }

        [Offset(336UL)]
        [Length(11)]
        public DynamicArray MemoryEventHandles { get => ReadStructure<DynamicArray>(nameof(MemoryEventHandles)); set => WriteStructure(nameof(MemoryEventHandles), value); }

        [Offset(424UL)]
        public ulong TotalHugeIoRanges { get => ReadHere<ulong>(nameof(TotalHugeIoRanges)); set => WriteHere(nameof(TotalHugeIoRanges), value); }

        [Offset(432UL)]
        public ulong NonChargedSecurePages { get => ReadHere<ulong>(nameof(NonChargedSecurePages)); set => WriteHere(nameof(NonChargedSecurePages), value); }

        [Offset(448UL)]
        public SlistHeader FreeKernelShadowStackCacheEntries { get => ReadStructure<SlistHeader>(nameof(FreeKernelShadowStackCacheEntries)); set => WriteStructure(nameof(FreeKernelShadowStackCacheEntries), value); }

        [Offset(464UL)]
        public ulong KernelShadowStackPages { get => ReadHere<ulong>(nameof(KernelShadowStackPages)); set => WriteHere(nameof(KernelShadowStackPages), value); }

        public MiPartitionCore(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPartitionCore>();
        }
    }
}