using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_WNF_STATE_NAME")]
    public sealed class WnfStateName : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray Data { get => ReadStructure<DynamicArray>(nameof(Data)); set => WriteStructure(nameof(Data), value); }

        public WnfStateName(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfStateName>();
        }
    }
}