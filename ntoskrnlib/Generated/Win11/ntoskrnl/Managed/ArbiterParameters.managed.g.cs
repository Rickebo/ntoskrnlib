using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARBITER_PARAMETERS")]
    public sealed class ArbiterParameters : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag Parameters { get => ReadStructure<UnnamedTag>(nameof(Parameters)); set => WriteStructure(nameof(Parameters), value); }

        public ArbiterParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArbiterParameters>();
        }
    }
}