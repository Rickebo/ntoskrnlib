using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PNP_REBALANCE_FLAGS")]
    public sealed class PnpRebalanceFlags : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        [Offset(0UL)]
        public uint AsUlong { get => ReadHere<uint>(nameof(AsUlong)); set => WriteHere(nameof(AsUlong), value); }

        public PnpRebalanceFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PnpRebalanceFlags>();
        }
    }
}