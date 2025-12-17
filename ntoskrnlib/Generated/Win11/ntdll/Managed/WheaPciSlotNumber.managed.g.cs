using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_WHEA_PCI_SLOT_NUMBER")]
    public sealed class WheaPciSlotNumber : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        public WheaPciSlotNumber(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaPciSlotNumber>();
        }
    }
}