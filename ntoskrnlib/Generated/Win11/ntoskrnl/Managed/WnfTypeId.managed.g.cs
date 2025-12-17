using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_TYPE_ID")]
    public sealed class WnfTypeId : DynamicStructure
    {
        [Offset(0UL)]
        public Guid TypeId { get => ReadStructure<Guid>(nameof(TypeId)); set => WriteStructure(nameof(TypeId), value); }

        public WnfTypeId(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfTypeId>();
        }
    }
}