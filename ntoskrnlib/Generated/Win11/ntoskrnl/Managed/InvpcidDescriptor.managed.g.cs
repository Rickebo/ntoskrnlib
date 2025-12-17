using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INVPCID_DESCRIPTOR")]
    public sealed class InvpcidDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag IndividualAddress { get => ReadStructure<UnnamedTag>(nameof(IndividualAddress)); set => WriteStructure(nameof(IndividualAddress), value); }

        [Offset(0UL)]
        public UnnamedTag SingleContext { get => ReadStructure<UnnamedTag>(nameof(SingleContext)); set => WriteStructure(nameof(SingleContext), value); }

        [Offset(0UL)]
        public UnnamedTag AllContextAndGlobals { get => ReadStructure<UnnamedTag>(nameof(AllContextAndGlobals)); set => WriteStructure(nameof(AllContextAndGlobals), value); }

        [Offset(0UL)]
        public UnnamedTag AllContext { get => ReadStructure<UnnamedTag>(nameof(AllContext)); set => WriteStructure(nameof(AllContext), value); }

        public InvpcidDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InvpcidDescriptor>();
        }
    }
}