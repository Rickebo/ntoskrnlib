using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_IOMMU_INTERFACE_V1")]
    public sealed class DmaIommuInterfaceV1 : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr CreateDomain { get => ReadHere<IntPtr>(nameof(CreateDomain)); set => WriteHere(nameof(CreateDomain), value); }

        [Offset(8UL)]
        public IntPtr DeleteDomain { get => ReadHere<IntPtr>(nameof(DeleteDomain)); set => WriteHere(nameof(DeleteDomain), value); }

        [Offset(16UL)]
        public IntPtr AttachDevice { get => ReadHere<IntPtr>(nameof(AttachDevice)); set => WriteHere(nameof(AttachDevice), value); }

        [Offset(24UL)]
        public IntPtr DetachDevice { get => ReadHere<IntPtr>(nameof(DetachDevice)); set => WriteHere(nameof(DetachDevice), value); }

        [Offset(32UL)]
        public IntPtr FlushDomain { get => ReadHere<IntPtr>(nameof(FlushDomain)); set => WriteHere(nameof(FlushDomain), value); }

        [Offset(40UL)]
        public IntPtr FlushDomainByVaList { get => ReadHere<IntPtr>(nameof(FlushDomainByVaList)); set => WriteHere(nameof(FlushDomainByVaList), value); }

        [Offset(48UL)]
        public IntPtr QueryInputMappings { get => ReadHere<IntPtr>(nameof(QueryInputMappings)); set => WriteHere(nameof(QueryInputMappings), value); }

        [Offset(56UL)]
        public IntPtr MapLogicalRange { get => ReadHere<IntPtr>(nameof(MapLogicalRange)); set => WriteHere(nameof(MapLogicalRange), value); }

        [Offset(64UL)]
        public IntPtr UnmapLogicalRange { get => ReadHere<IntPtr>(nameof(UnmapLogicalRange)); set => WriteHere(nameof(UnmapLogicalRange), value); }

        [Offset(72UL)]
        public IntPtr MapIdentityRange { get => ReadHere<IntPtr>(nameof(MapIdentityRange)); set => WriteHere(nameof(MapIdentityRange), value); }

        [Offset(80UL)]
        public IntPtr UnmapIdentityRange { get => ReadHere<IntPtr>(nameof(UnmapIdentityRange)); set => WriteHere(nameof(UnmapIdentityRange), value); }

        [Offset(88UL)]
        public IntPtr SetDeviceFaultReporting { get => ReadHere<IntPtr>(nameof(SetDeviceFaultReporting)); set => WriteHere(nameof(SetDeviceFaultReporting), value); }

        [Offset(96UL)]
        public IntPtr ConfigureDomain { get => ReadHere<IntPtr>(nameof(ConfigureDomain)); set => WriteHere(nameof(ConfigureDomain), value); }

        public DmaIommuInterfaceV1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaIommuInterfaceV1>();
        }
    }
}