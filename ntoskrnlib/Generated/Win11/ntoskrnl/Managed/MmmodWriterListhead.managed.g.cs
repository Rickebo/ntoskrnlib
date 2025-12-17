using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMMOD_WRITER_LISTHEAD")]
    public sealed class MmmodWriterListhead : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListHead { get => ReadStructure<ListEntry>(nameof(ListHead)); set => WriteStructure(nameof(ListHead), value); }

        [Offset(16UL)]
        public Kevent Event { get => ReadStructure<Kevent>(nameof(Event)); set => WriteStructure(nameof(Event), value); }

        public MmmodWriterListhead(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmmodWriterListhead>();
        }
    }
}