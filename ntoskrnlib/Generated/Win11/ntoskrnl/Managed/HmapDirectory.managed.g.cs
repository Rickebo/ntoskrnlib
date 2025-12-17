using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HMAP_DIRECTORY")]
    public sealed class HmapDirectory : DynamicStructure
    {
        [Offset(0UL)]
        [Length(1024)]
        public DynamicArray Directory { get => ReadStructure<DynamicArray>(nameof(Directory)); set => WriteStructure(nameof(Directory), value); }

        public HmapDirectory(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HmapDirectory>();
        }
    }
}