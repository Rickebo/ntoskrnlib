using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_UOW_SET_VALUE_LIST_DATA")]
    public sealed class CmUowSetValueListData : DynamicStructure
    {
        [Offset(0UL)]
        public uint RefCount { get => ReadHere<uint>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(4UL)]
        public ChildList ValueList { get => ReadStructure<ChildList>(nameof(ValueList)); set => WriteStructure(nameof(ValueList), value); }

        public CmUowSetValueListData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmUowSetValueListData>();
        }
    }
}