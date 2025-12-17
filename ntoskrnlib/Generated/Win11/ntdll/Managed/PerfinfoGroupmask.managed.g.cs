using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PERFINFO_GROUPMASK")]
    public sealed class PerfinfoGroupmask : DynamicStructure
    {
        [Offset(0UL)]
        [Length(8)]
        public DynamicArray Masks { get => ReadStructure<DynamicArray>(nameof(Masks)); set => WriteStructure(nameof(Masks), value); }

        public PerfinfoGroupmask(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PerfinfoGroupmask>();
        }
    }
}