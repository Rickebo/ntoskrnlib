using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_QUEUE")]
    public sealed class TppQueue : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Queue { get => ReadStructure<ListEntry>(nameof(Queue)); set => WriteStructure(nameof(Queue), value); }

        [Offset(16UL)]
        public RtlSrwlock Lock { get => ReadStructure<RtlSrwlock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        public TppQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppQueue>();
        }
    }
}