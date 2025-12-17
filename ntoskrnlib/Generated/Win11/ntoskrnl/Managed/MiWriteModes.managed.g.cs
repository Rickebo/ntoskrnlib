using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_WRITE_MODES")]
    public sealed class MiWriteModes : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray WriteType { get => ReadStructure<DynamicArray>(nameof(WriteType)); set => WriteStructure(nameof(WriteType), value); }

        public MiWriteModes(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiWriteModes>();
        }
    }
}