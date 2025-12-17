using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_INTERFACE_STATE_CHANGE")]
    public sealed class IommuInterfaceStateChange : DynamicStructure
    {
        [Offset(0UL)]
        public IommuInterfaceStateChangeFields PresentFields { get => ReadStructure<IommuInterfaceStateChangeFields>(nameof(PresentFields)); set => WriteStructure(nameof(PresentFields), value); }

        [Offset(4UL)]
        public uint AvailableDomainTypes { get => ReadHere<uint>(nameof(AvailableDomainTypes)); set => WriteHere(nameof(AvailableDomainTypes), value); }

        public IommuInterfaceStateChange(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuInterfaceStateChange>();
        }
    }
}