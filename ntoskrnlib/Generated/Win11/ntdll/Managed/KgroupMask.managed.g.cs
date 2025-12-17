using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KGROUP_MASK")]
    public sealed class KgroupMask : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray Masks { get => ReadStructure<DynamicArray>(nameof(Masks)); set => WriteStructure(nameof(Masks), value); }

        public KgroupMask(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KgroupMask>();
        }
    }
}