using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMDEREFERENCE_SEGMENT_HEADER")]
    public sealed class MmdereferenceSegmentHeader : DynamicStructure
    {
        [Offset(0UL)]
        public Kevent Event { get => ReadStructure<Kevent>(nameof(Event)); set => WriteStructure(nameof(Event), value); }

        [Offset(24UL)]
        public ListEntry ControlAreaDeleteListHead { get => ReadStructure<ListEntry>(nameof(ControlAreaDeleteListHead)); set => WriteStructure(nameof(ControlAreaDeleteListHead), value); }

        [Offset(40UL)]
        public ListEntry UnusedSegmentDeleteListHead { get => ReadStructure<ListEntry>(nameof(UnusedSegmentDeleteListHead)); set => WriteStructure(nameof(UnusedSegmentDeleteListHead), value); }

        [Offset(56UL)]
        public ListEntry PagefileExtensionListHead { get => ReadStructure<ListEntry>(nameof(PagefileExtensionListHead)); set => WriteStructure(nameof(PagefileExtensionListHead), value); }

        public MmdereferenceSegmentHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmdereferenceSegmentHeader>();
        }
    }
}