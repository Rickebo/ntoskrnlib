using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!__WIL__WNF_STATE_NAME")]
    public sealed class WilWnfStateName : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray Data { get => ReadStructure<DynamicArray>(nameof(Data)); set => WriteStructure(nameof(Data), value); }

        public WilWnfStateName(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WilWnfStateName>();
        }
    }
}