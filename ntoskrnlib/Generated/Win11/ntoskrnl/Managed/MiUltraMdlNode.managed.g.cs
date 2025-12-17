using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_ULTRA_MDL_NODE")]
    public sealed class MiUltraMdlNode : DynamicStructure
    {
        [Offset(0UL)]
        [Length(8)]
        public DynamicArray UltraMdlMaps { get => ReadStructure<DynamicArray>(nameof(UltraMdlMaps)); set => WriteStructure(nameof(UltraMdlMaps), value); }

        public MiUltraMdlNode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiUltraMdlNode>();
        }
    }
}