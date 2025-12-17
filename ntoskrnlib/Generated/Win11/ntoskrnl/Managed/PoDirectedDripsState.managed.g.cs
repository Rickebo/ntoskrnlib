using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PO_DIRECTED_DRIPS_STATE")]
    public sealed class PoDirectedDripsState : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry QueueLink { get => ReadStructure<ListEntry>(nameof(QueueLink)); set => WriteStructure(nameof(QueueLink), value); }

        [Offset(16UL)]
        public ListEntry VisitedQueueLink { get => ReadStructure<ListEntry>(nameof(VisitedQueueLink)); set => WriteStructure(nameof(VisitedQueueLink), value); }

        [Offset(32UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(36UL)]
        public uint CachedFlags { get => ReadHere<uint>(nameof(CachedFlags)); set => WriteHere(nameof(CachedFlags), value); }

        [Offset(40UL)]
        public uint DeviceUsageCount { get => ReadHere<uint>(nameof(DeviceUsageCount)); set => WriteHere(nameof(DeviceUsageCount), value); }

        [Offset(48UL)]
        public IntPtr Diagnostic { get => ReadHere<IntPtr>(nameof(Diagnostic)); set => WriteHere(nameof(Diagnostic), value); }

        public PoDirectedDripsState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoDirectedDripsState>();
        }
    }
}