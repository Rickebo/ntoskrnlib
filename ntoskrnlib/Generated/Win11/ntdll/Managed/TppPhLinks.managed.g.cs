using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_PH_LINKS")]
    public sealed class TppPhLinks : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Siblings { get => ReadStructure<ListEntry>(nameof(Siblings)); set => WriteStructure(nameof(Siblings), value); }

        [Offset(16UL)]
        public ListEntry Children { get => ReadStructure<ListEntry>(nameof(Children)); set => WriteStructure(nameof(Children), value); }

        [Offset(32UL)]
        public long Key { get => ReadHere<long>(nameof(Key)); set => WriteHere(nameof(Key), value); }

        public TppPhLinks(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppPhLinks>();
        }
    }
}