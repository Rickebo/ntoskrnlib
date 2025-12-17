using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMAR_PAGE_TABLE_STATE")]
    public sealed class DmarPageTableState : DynamicStructure
    {
        public DmarPageTableState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmarPageTableState>();
        }
    }
}