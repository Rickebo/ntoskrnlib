using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_IN_USE_PAGE_NOTIFY_FLAGS")]
    public sealed class WheaInUsePageNotifyFlags : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag Bits { get => ReadStructure<UnnamedTag>(nameof(Bits)); set => WriteStructure(nameof(Bits), value); }

        [Offset(0UL)]
        public byte AsUCHAR { get => ReadHere<byte>(nameof(AsUCHAR)); set => WriteHere(nameof(AsUCHAR), value); }

        public WheaInUsePageNotifyFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaInUsePageNotifyFlags>();
        }
    }
}