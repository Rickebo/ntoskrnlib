using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_VS_CONTEXT")]
    public sealed class HeapVsContext : DynamicStructure
    {
        [Offset(0UL)]
        public ushort SlotMapRef { get => ReadHere<ushort>(nameof(SlotMapRef)); set => WriteHere(nameof(SlotMapRef), value); }

        [Offset(2UL)]
        public byte AffinityMask { get => ReadHere<byte>(nameof(AffinityMask)); set => WriteHere(nameof(AffinityMask), value); }

        [Offset(3UL)]
        public byte LockType { get => ReadHere<byte>(nameof(LockType)); set => WriteHere(nameof(LockType), value); }

        [Offset(4UL)]
        public RtlHpVsConfig Config { get => ReadStructure<RtlHpVsConfig>(nameof(Config)); set => WriteStructure(nameof(Config), value); }

        [Offset(5UL)]
        public byte EliminatePointers { get => ReadHere<byte>(nameof(EliminatePointers)); set => WriteHere(nameof(EliminatePointers), value); }

        [Offset(6UL)]
        public short MemStatsOffset { get => ReadHere<short>(nameof(MemStatsOffset)); set => WriteHere(nameof(MemStatsOffset), value); }

        [Offset(8UL)]
        public IntPtr BackendCtx { get => ReadHere<IntPtr>(nameof(BackendCtx)); set => WriteHere(nameof(BackendCtx), value); }

        [Offset(16UL)]
        public HeapSuballocatorCallbacks Callbacks { get => ReadStructure<HeapSuballocatorCallbacks>(nameof(Callbacks)); set => WriteStructure(nameof(Callbacks), value); }

        [Offset(64UL)]
        public HeapAffinityMgr AffinityMgr { get => ReadStructure<HeapAffinityMgr>(nameof(AffinityMgr)); set => WriteStructure(nameof(AffinityMgr), value); }

        [Offset(80UL)]
        public ulong TotalCommittedUnits { get => ReadHere<ulong>(nameof(TotalCommittedUnits)); set => WriteHere(nameof(TotalCommittedUnits), value); }

        [Offset(88UL)]
        public ulong FreeCommittedUnits { get => ReadHere<ulong>(nameof(FreeCommittedUnits)); set => WriteHere(nameof(FreeCommittedUnits), value); }

        public HeapVsContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapVsContext>();
        }
    }
}