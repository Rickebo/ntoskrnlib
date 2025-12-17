using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTRANSITION_STACK")]
    public sealed class KtransitionStack : DynamicStructure
    {
        [Offset(0UL)]
        [Length(512)]
        public DynamicArray Stack { get => ReadStructure<DynamicArray>(nameof(Stack)); set => WriteStructure(nameof(Stack), value); }

        [Offset(0UL)]
        [Length(464)]
        public DynamicArray IstStack { get => ReadStructure<DynamicArray>(nameof(IstStack)); set => WriteStructure(nameof(IstStack), value); }

        [Offset(464UL)]
        public KistBaseFrame IstFrame { get => ReadStructure<KistBaseFrame>(nameof(IstFrame)); set => WriteStructure(nameof(IstFrame), value); }

        public KtransitionStack(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KtransitionStack>();
        }
    }
}