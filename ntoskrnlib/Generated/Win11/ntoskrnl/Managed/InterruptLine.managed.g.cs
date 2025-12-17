using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_LINE")]
    public sealed class InterruptLine : DynamicStructure
    {
        [Offset(0UL)]
        public uint UnitId { get => ReadHere<uint>(nameof(UnitId)); set => WriteHere(nameof(UnitId), value); }

        [Offset(4UL)]
        public int Line { get => ReadHere<int>(nameof(Line)); set => WriteHere(nameof(Line), value); }

        public InterruptLine(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InterruptLine>();
        }
    }
}