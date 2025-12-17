using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KE_RCU_WORKITEM")]
    public sealed class KeRcuWorkitem : DynamicStructure
    {
        [Offset(0UL)]
        [Length(6)]
        public DynamicArray Placeholder { get => ReadStructure<DynamicArray>(nameof(Placeholder)); set => WriteStructure(nameof(Placeholder), value); }

        public KeRcuWorkitem(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KeRcuWorkitem>();
        }
    }
}