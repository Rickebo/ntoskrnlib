using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_INTERFACE_STATE_CHANGE_FIELDS")]
    public sealed class IommuInterfaceStateChangeFields : DynamicStructure
    {
        [Offset(0UL)]
        public uint AvailableDomainTypes { get => ReadHere<uint>(nameof(AvailableDomainTypes)); set => WriteHere(nameof(AvailableDomainTypes), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public uint AsULONG { get => ReadHere<uint>(nameof(AsULONG)); set => WriteHere(nameof(AsULONG), value); }

        public IommuInterfaceStateChangeFields(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuInterfaceStateChangeFields>();
        }
    }
}