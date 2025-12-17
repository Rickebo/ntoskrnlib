using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KEVENT")]
    public sealed class Kevent : DynamicStructure
    {
        [Offset(0UL)]
        public DispatcherHeader Header { get => ReadStructure<DispatcherHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        public Kevent(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kevent>();
        }
    }
}