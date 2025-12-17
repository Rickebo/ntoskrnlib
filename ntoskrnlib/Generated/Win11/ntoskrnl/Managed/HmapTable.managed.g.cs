using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HMAP_TABLE")]
    public sealed class HmapTable : DynamicStructure
    {
        [Offset(0UL)]
        [Length(512)]
        public DynamicArray Table { get => ReadStructure<DynamicArray>(nameof(Table)); set => WriteStructure(nameof(Table), value); }

        public HmapTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HmapTable>();
        }
    }
}