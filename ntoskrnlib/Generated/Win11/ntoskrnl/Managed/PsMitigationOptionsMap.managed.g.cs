using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PS_MITIGATION_OPTIONS_MAP")]
    public sealed class PsMitigationOptionsMap : DynamicStructure
    {
        [Offset(0UL)]
        [Length(3)]
        public DynamicArray Map { get => ReadStructure<DynamicArray>(nameof(Map)); set => WriteStructure(nameof(Map), value); }

        public PsMitigationOptionsMap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsMitigationOptionsMap>();
        }
    }
}