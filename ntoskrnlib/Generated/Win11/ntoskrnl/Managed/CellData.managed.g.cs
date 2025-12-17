using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CELL_DATA")]
    public sealed class CellData : DynamicStructure
    {
        [Offset(0UL)]
        public U u { get => ReadStructure<U>(nameof(u)); set => WriteStructure(nameof(u), value); }

        public CellData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CellData>();
        }
    }
}