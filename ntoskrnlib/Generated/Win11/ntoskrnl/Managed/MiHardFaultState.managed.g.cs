using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_HARD_FAULT_STATE")]
    public sealed class MiHardFaultState : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr SwapPfn { get => ReadHere<IntPtr>(nameof(SwapPfn)); set => WriteHere(nameof(SwapPfn), value); }

        [Offset(8UL)]
        public MiStoreInpageCompleteFlags StoreFlags { get => ReadStructure<MiStoreInpageCompleteFlags>(nameof(StoreFlags)); set => WriteStructure(nameof(StoreFlags), value); }

        public MiHardFaultState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiHardFaultState>();
        }
    }
}