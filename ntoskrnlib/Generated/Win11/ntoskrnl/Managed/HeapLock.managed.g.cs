using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_LOCK")]
    public sealed class HeapLock : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag Lock { get => ReadStructure<UnnamedTag>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        public HeapLock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLock>();
        }
    }
}