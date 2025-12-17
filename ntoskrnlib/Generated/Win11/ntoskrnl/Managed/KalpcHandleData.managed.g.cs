using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KALPC_HANDLE_DATA")]
    public sealed class KalpcHandleData : DynamicStructure
    {
        [Offset(0UL)]
        public uint ObjectType { get => ReadHere<uint>(nameof(ObjectType)); set => WriteHere(nameof(ObjectType), value); }

        [Offset(4UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(8UL)]
        public ObDuplicateObjectState DuplicateContext { get => ReadStructure<ObDuplicateObjectState>(nameof(DuplicateContext)); set => WriteStructure(nameof(DuplicateContext), value); }

        public KalpcHandleData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KalpcHandleData>();
        }
    }
}