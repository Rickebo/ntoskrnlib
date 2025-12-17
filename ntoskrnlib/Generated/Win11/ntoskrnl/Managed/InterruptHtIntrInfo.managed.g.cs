using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_HT_INTR_INFO")]
    public sealed class InterruptHtIntrInfo : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag LowPart { get => ReadStructure<UnnamedTag>(nameof(LowPart)); set => WriteStructure(nameof(LowPart), value); }

        [Offset(4UL)]
        public UnnamedTag HighPart { get => ReadStructure<UnnamedTag>(nameof(HighPart)); set => WriteStructure(nameof(HighPart), value); }

        public InterruptHtIntrInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InterruptHtIntrInfo>();
        }
    }
}