using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER_PADDING_INFO")]
    public sealed class ObjectHeaderPaddingInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint PaddingAmount { get => ReadHere<uint>(nameof(PaddingAmount)); set => WriteHere(nameof(PaddingAmount), value); }

        public ObjectHeaderPaddingInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectHeaderPaddingInfo>();
        }
    }
}