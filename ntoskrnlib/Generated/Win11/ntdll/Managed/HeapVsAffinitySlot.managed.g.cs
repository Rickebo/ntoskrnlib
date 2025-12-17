using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_VS_AFFINITY_SLOT")]
    public sealed class HeapVsAffinitySlot : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr VsContext { get => ReadHere<IntPtr>(nameof(VsContext)); set => WriteHere(nameof(VsContext), value); }

        [Offset(8UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(16UL)]
        public RtlRbTree FreeChunkTree { get => ReadStructure<RtlRbTree>(nameof(FreeChunkTree)); set => WriteStructure(nameof(FreeChunkTree), value); }

        [Offset(32UL)]
        public ListEntry SubsegmentList { get => ReadStructure<ListEntry>(nameof(SubsegmentList)); set => WriteStructure(nameof(SubsegmentList), value); }

        [Offset(64UL)]
        public HeapVsDelayFreeContext DelayFreeContext { get => ReadStructure<HeapVsDelayFreeContext>(nameof(DelayFreeContext)); set => WriteStructure(nameof(DelayFreeContext), value); }

        public HeapVsAffinitySlot(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapVsAffinitySlot>();
        }
    }
}