using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER_HANDLE_INFO")]
    public sealed class ObjectHeaderHandleInfo : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr HandleCountDataBase { get => ReadHere<IntPtr>(nameof(HandleCountDataBase)); set => WriteHere(nameof(HandleCountDataBase), value); }

        [Offset(0UL)]
        public ObjectHandleCountEntry SingleEntry { get => ReadStructure<ObjectHandleCountEntry>(nameof(SingleEntry)); set => WriteStructure(nameof(SingleEntry), value); }

        public ObjectHeaderHandleInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectHeaderHandleInfo>();
        }
    }
}