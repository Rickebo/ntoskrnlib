using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PO_IRP_MANAGER")]
    public sealed class PoIrpManager : DynamicStructure
    {
        [Offset(0UL)]
        public PoIrpQueue DeviceIrpQueue { get => ReadStructure<PoIrpQueue>(nameof(DeviceIrpQueue)); set => WriteStructure(nameof(DeviceIrpQueue), value); }

        [Offset(16UL)]
        public PoIrpQueue SystemIrpQueue { get => ReadStructure<PoIrpQueue>(nameof(SystemIrpQueue)); set => WriteStructure(nameof(SystemIrpQueue), value); }

        public PoIrpManager(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoIrpManager>();
        }
    }
}