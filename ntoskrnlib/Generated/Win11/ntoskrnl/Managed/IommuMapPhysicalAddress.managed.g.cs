using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_MAP_PHYSICAL_ADDRESS")]
    public sealed class IommuMapPhysicalAddress : DynamicStructure
    {
        [Offset(0UL)]
        public uint MapType { get => ReadHere<uint>(nameof(MapType)); set => WriteHere(nameof(MapType), value); }

        [Offset(8UL)]
        public UnnamedTag Mdl { get => ReadStructure<UnnamedTag>(nameof(Mdl)); set => WriteStructure(nameof(Mdl), value); }

        [Offset(8UL)]
        public UnnamedTag ContiguousRange { get => ReadStructure<UnnamedTag>(nameof(ContiguousRange)); set => WriteStructure(nameof(ContiguousRange), value); }

        [Offset(8UL)]
        public UnnamedTag PfnArray { get => ReadStructure<UnnamedTag>(nameof(PfnArray)); set => WriteStructure(nameof(PfnArray), value); }

        public IommuMapPhysicalAddress(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuMapPhysicalAddress>();
        }
    }
}