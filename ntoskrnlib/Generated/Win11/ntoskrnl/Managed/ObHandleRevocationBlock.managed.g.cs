using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OB_HANDLE_REVOCATION_BLOCK")]
    public sealed class ObHandleRevocationBlock : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry RevocationInfos { get => ReadStructure<ListEntry>(nameof(RevocationInfos)); set => WriteStructure(nameof(RevocationInfos), value); }

        [Offset(16UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(24UL)]
        public ExRundownRef Rundown { get => ReadStructure<ExRundownRef>(nameof(Rundown)); set => WriteStructure(nameof(Rundown), value); }

        public ObHandleRevocationBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObHandleRevocationBlock>();
        }
    }
}