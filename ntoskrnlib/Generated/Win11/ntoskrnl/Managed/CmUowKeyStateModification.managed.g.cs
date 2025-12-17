using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_UOW_KEY_STATE_MODIFICATION")]
    public sealed class CmUowKeyStateModification : DynamicStructure
    {
        [Offset(0UL)]
        public uint RefCount { get => ReadHere<uint>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(4UL)]
        [Length(2)]
        public DynamicArray SubKeyListCount { get => ReadStructure<DynamicArray>(nameof(SubKeyListCount)); set => WriteStructure(nameof(SubKeyListCount), value); }

        [Offset(12UL)]
        [Length(2)]
        public DynamicArray NewSubKeyList { get => ReadStructure<DynamicArray>(nameof(NewSubKeyList)); set => WriteStructure(nameof(NewSubKeyList), value); }

        public CmUowKeyStateModification(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmUowKeyStateModification>();
        }
    }
}