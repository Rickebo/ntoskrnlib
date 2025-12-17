using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_RESOURCE_LIST")]
    public sealed class CmResourceList : DynamicStructure
    {
        [Offset(0UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(4UL)]
        [Length(1)]
        public DynamicArray List { get => ReadStructure<DynamicArray>(nameof(List)); set => WriteStructure(nameof(List), value); }

        public CmResourceList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmResourceList>();
        }
    }
}