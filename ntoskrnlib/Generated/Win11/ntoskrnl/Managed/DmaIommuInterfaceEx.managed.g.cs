using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_IOMMU_INTERFACE_EX")]
    public sealed class DmaIommuInterfaceEx : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Size { get => ReadHere<ulong>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(16UL)]
        public DmaIommuInterfaceV1 V1 { get => ReadStructure<DmaIommuInterfaceV1>(nameof(V1)); set => WriteStructure(nameof(V1), value); }

        [Offset(16UL)]
        public DmaIommuInterfaceV2 V2 { get => ReadStructure<DmaIommuInterfaceV2>(nameof(V2)); set => WriteStructure(nameof(V2), value); }

        [Offset(16UL)]
        public DmaIommuInterfaceV3 V3 { get => ReadStructure<DmaIommuInterfaceV3>(nameof(V3)); set => WriteStructure(nameof(V3), value); }

        public DmaIommuInterfaceEx(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaIommuInterfaceEx>();
        }
    }
}