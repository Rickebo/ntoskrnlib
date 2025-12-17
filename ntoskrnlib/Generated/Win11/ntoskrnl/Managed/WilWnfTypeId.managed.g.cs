using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!__WIL__WNF_TYPE_ID")]
    public sealed class WilWnfTypeId : DynamicStructure
    {
        [Offset(0UL)]
        public Guid TypeId { get => ReadStructure<Guid>(nameof(TypeId)); set => WriteStructure(nameof(TypeId), value); }

        public WilWnfTypeId(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WilWnfTypeId>();
        }
    }
}