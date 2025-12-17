using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTLP_HP_HEAP_MANAGER")]
    public sealed class RtlpHpHeapManager : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Globals { get => ReadHere<IntPtr>(nameof(Globals)); set => WriteHere(nameof(Globals), value); }

        [Offset(8UL)]
        public RtlpHpAllocTracker AllocTracker { get => ReadStructure<RtlpHpAllocTracker>(nameof(AllocTracker)); set => WriteStructure(nameof(AllocTracker), value); }

        [Offset(88UL)]
        public HeapVamgrCtx VaMgr { get => ReadStructure<HeapVamgrCtx>(nameof(VaMgr)); set => WriteStructure(nameof(VaMgr), value); }

        [Offset(14488UL)]
        [Length(4)]
        public DynamicArray MetadataHeaps { get => ReadStructure<DynamicArray>(nameof(MetadataHeaps)); set => WriteStructure(nameof(MetadataHeaps), value); }

        [Offset(14552UL)]
        public RtlHpSubAllocatorConfigs SubAllocConfigs { get => ReadStructure<RtlHpSubAllocatorConfigs>(nameof(SubAllocConfigs)); set => WriteStructure(nameof(SubAllocConfigs), value); }

        public RtlpHpHeapManager(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlpHpHeapManager>();
        }
    }
}