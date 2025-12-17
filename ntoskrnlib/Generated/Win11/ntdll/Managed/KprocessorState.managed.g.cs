using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KPROCESSOR_STATE")]
    public sealed class KprocessorState : DynamicStructure
    {
        [Offset(0UL)]
        public KspecialRegisters SpecialRegisters { get => ReadStructure<KspecialRegisters>(nameof(SpecialRegisters)); set => WriteStructure(nameof(SpecialRegisters), value); }

        [Offset(240UL)]
        public Context ContextFrame { get => ReadStructure<Context>(nameof(ContextFrame)); set => WriteStructure(nameof(ContextFrame), value); }

        public KprocessorState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KprocessorState>();
        }
    }
}