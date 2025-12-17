using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_IOMMU_INTERFACE_V2")]
    public sealed class DmaIommuInterfaceV2 : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr CreateDomainEx { get => ReadHere<IntPtr>(nameof(CreateDomainEx)); set => WriteHere(nameof(CreateDomainEx), value); }

        [Offset(8UL)]
        public IntPtr DeleteDomain { get => ReadHere<IntPtr>(nameof(DeleteDomain)); set => WriteHere(nameof(DeleteDomain), value); }

        [Offset(16UL)]
        public IntPtr AttachDeviceEx { get => ReadHere<IntPtr>(nameof(AttachDeviceEx)); set => WriteHere(nameof(AttachDeviceEx), value); }

        [Offset(24UL)]
        public IntPtr DetachDeviceEx { get => ReadHere<IntPtr>(nameof(DetachDeviceEx)); set => WriteHere(nameof(DetachDeviceEx), value); }

        [Offset(32UL)]
        public IntPtr FlushDomain { get => ReadHere<IntPtr>(nameof(FlushDomain)); set => WriteHere(nameof(FlushDomain), value); }

        [Offset(40UL)]
        public IntPtr FlushDomainByVaList { get => ReadHere<IntPtr>(nameof(FlushDomainByVaList)); set => WriteHere(nameof(FlushDomainByVaList), value); }

        [Offset(48UL)]
        public IntPtr QueryInputMappings { get => ReadHere<IntPtr>(nameof(QueryInputMappings)); set => WriteHere(nameof(QueryInputMappings), value); }

        [Offset(56UL)]
        public IntPtr MapLogicalRangeEx { get => ReadHere<IntPtr>(nameof(MapLogicalRangeEx)); set => WriteHere(nameof(MapLogicalRangeEx), value); }

        [Offset(64UL)]
        public IntPtr UnmapLogicalRange { get => ReadHere<IntPtr>(nameof(UnmapLogicalRange)); set => WriteHere(nameof(UnmapLogicalRange), value); }

        [Offset(72UL)]
        public IntPtr MapIdentityRangeEx { get => ReadHere<IntPtr>(nameof(MapIdentityRangeEx)); set => WriteHere(nameof(MapIdentityRangeEx), value); }

        [Offset(80UL)]
        public IntPtr UnmapIdentityRangeEx { get => ReadHere<IntPtr>(nameof(UnmapIdentityRangeEx)); set => WriteHere(nameof(UnmapIdentityRangeEx), value); }

        [Offset(88UL)]
        public IntPtr SetDeviceFaultReportingEx { get => ReadHere<IntPtr>(nameof(SetDeviceFaultReportingEx)); set => WriteHere(nameof(SetDeviceFaultReportingEx), value); }

        [Offset(96UL)]
        public IntPtr ConfigureDomain { get => ReadHere<IntPtr>(nameof(ConfigureDomain)); set => WriteHere(nameof(ConfigureDomain), value); }

        [Offset(104UL)]
        public IntPtr QueryAvailableDomainTypes { get => ReadHere<IntPtr>(nameof(QueryAvailableDomainTypes)); set => WriteHere(nameof(QueryAvailableDomainTypes), value); }

        [Offset(112UL)]
        public IntPtr RegisterInterfaceStateChangeCallback { get => ReadHere<IntPtr>(nameof(RegisterInterfaceStateChangeCallback)); set => WriteHere(nameof(RegisterInterfaceStateChangeCallback), value); }

        [Offset(120UL)]
        public IntPtr UnregisterInterfaceStateChangeCallback { get => ReadHere<IntPtr>(nameof(UnregisterInterfaceStateChangeCallback)); set => WriteHere(nameof(UnregisterInterfaceStateChangeCallback), value); }

        [Offset(128UL)]
        public IntPtr ReserveLogicalAddressRange { get => ReadHere<IntPtr>(nameof(ReserveLogicalAddressRange)); set => WriteHere(nameof(ReserveLogicalAddressRange), value); }

        [Offset(136UL)]
        public IntPtr FreeReservedLogicalAddressRange { get => ReadHere<IntPtr>(nameof(FreeReservedLogicalAddressRange)); set => WriteHere(nameof(FreeReservedLogicalAddressRange), value); }

        [Offset(144UL)]
        public IntPtr MapReservedLogicalRange { get => ReadHere<IntPtr>(nameof(MapReservedLogicalRange)); set => WriteHere(nameof(MapReservedLogicalRange), value); }

        [Offset(152UL)]
        public IntPtr UnmapReservedLogicalRange { get => ReadHere<IntPtr>(nameof(UnmapReservedLogicalRange)); set => WriteHere(nameof(UnmapReservedLogicalRange), value); }

        [Offset(160UL)]
        public IntPtr CreateDevice { get => ReadHere<IntPtr>(nameof(CreateDevice)); set => WriteHere(nameof(CreateDevice), value); }

        [Offset(168UL)]
        public IntPtr DeleteDevice { get => ReadHere<IntPtr>(nameof(DeleteDevice)); set => WriteHere(nameof(DeleteDevice), value); }

        public DmaIommuInterfaceV2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaIommuInterfaceV2>();
        }
    }
}