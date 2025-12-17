using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_STORE_INPAGE_COMPLETE_FLAGS")]
    public sealed class MiStoreInpageCompleteFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint EntireFlags { get => ReadHere<uint>(nameof(EntireFlags)); set => WriteHere(nameof(EntireFlags), value); }

        [Offset(0UL)]
        public uint StoreFault { get => ReadHere<uint>(nameof(StoreFault)); set => WriteHere(nameof(StoreFault), value); }

        [Offset(0UL)]
        public uint LowResourceFailure { get => ReadHere<uint>(nameof(LowResourceFailure)); set => WriteHere(nameof(LowResourceFailure), value); }

        [Offset(0UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        public MiStoreInpageCompleteFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiStoreInpageCompleteFlags>();
        }
    }
}