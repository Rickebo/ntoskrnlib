using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_IO_PAGE_STATE")]
    public sealed class MiIoPageState : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray TypeCell { get => ReadStructure<DynamicArray>(nameof(TypeCell)); set => WriteStructure(nameof(TypeCell), value); }

        [Offset(128UL)]
        public RtlAvlTree InvariantIoSpace { get => ReadStructure<RtlAvlTree>(nameof(InvariantIoSpace)); set => WriteStructure(nameof(InvariantIoSpace), value); }

        [Offset(136UL)]
        public RtlAvlTree ExclusionSpace { get => ReadStructure<RtlAvlTree>(nameof(ExclusionSpace)); set => WriteStructure(nameof(ExclusionSpace), value); }

        [Offset(144UL)]
        public int IoPfnPruneLock { get => ReadHere<int>(nameof(IoPfnPruneLock)); set => WriteHere(nameof(IoPfnPruneLock), value); }

        [Offset(152UL)]
        public WorkQueueItem UnmappedNodeWorkItem { get => ReadStructure<WorkQueueItem>(nameof(UnmappedNodeWorkItem)); set => WriteStructure(nameof(UnmappedNodeWorkItem), value); }

        [Offset(184UL)]
        public MiIoCacheStats IoCacheStats { get => ReadStructure<MiIoCacheStats>(nameof(IoCacheStats)); set => WriteStructure(nameof(IoCacheStats), value); }

        public MiIoPageState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiIoPageState>();
        }
    }
}