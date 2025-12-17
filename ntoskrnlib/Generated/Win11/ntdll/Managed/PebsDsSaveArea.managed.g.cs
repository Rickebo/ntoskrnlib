using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PEBS_DS_SAVE_AREA")]
    public sealed class PebsDsSaveArea : DynamicStructure
    {
        [Offset(0UL)]
        public PebsDsSaveAREA32 As32Bit { get => ReadStructure<PebsDsSaveAREA32>(nameof(As32Bit)); set => WriteStructure(nameof(As32Bit), value); }

        [Offset(0UL)]
        public PebsDsSaveAREA64 As64Bit { get => ReadStructure<PebsDsSaveAREA64>(nameof(As64Bit)); set => WriteStructure(nameof(As64Bit), value); }

        public PebsDsSaveArea(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PebsDsSaveArea>();
        }
    }
}