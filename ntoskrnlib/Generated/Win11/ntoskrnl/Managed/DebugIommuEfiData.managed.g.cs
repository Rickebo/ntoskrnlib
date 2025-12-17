using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEBUG_IOMMU_EFI_DATA")]
    public sealed class DebugIommuEfiData : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr PciIoProtocolHandle { get => ReadHere<IntPtr>(nameof(PciIoProtocolHandle)); set => WriteHere(nameof(PciIoProtocolHandle), value); }

        [Offset(8UL)]
        public IntPtr Mapping { get => ReadHere<IntPtr>(nameof(Mapping)); set => WriteHere(nameof(Mapping), value); }

        public DebugIommuEfiData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DebugIommuEfiData>();
        }
    }
}