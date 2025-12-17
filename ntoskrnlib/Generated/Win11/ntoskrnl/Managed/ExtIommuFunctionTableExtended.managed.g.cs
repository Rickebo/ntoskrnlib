using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_FUNCTION_TABLE_EXTENDED")]
    public sealed class ExtIommuFunctionTableExtended : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr FindDevice { get => ReadHere<IntPtr>(nameof(FindDevice)); set => WriteHere(nameof(FindDevice), value); }

        [Offset(8UL)]
        public IntPtr SetDeviceSvmCapabilities { get => ReadHere<IntPtr>(nameof(SetDeviceSvmCapabilities)); set => WriteHere(nameof(SetDeviceSvmCapabilities), value); }

        [Offset(16UL)]
        public IntPtr SetDevicePasidTable { get => ReadHere<IntPtr>(nameof(SetDevicePasidTable)); set => WriteHere(nameof(SetDevicePasidTable), value); }

        [Offset(24UL)]
        public IntPtr GrowPasidTable { get => ReadHere<IntPtr>(nameof(GrowPasidTable)); set => WriteHere(nameof(GrowPasidTable), value); }

        [Offset(32UL)]
        public IntPtr SetPasidAddressSpace { get => ReadHere<IntPtr>(nameof(SetPasidAddressSpace)); set => WriteHere(nameof(SetPasidAddressSpace), value); }

        [Offset(40UL)]
        public IntPtr FlushTb { get => ReadHere<IntPtr>(nameof(FlushTb)); set => WriteHere(nameof(FlushTb), value); }

        [Offset(48UL)]
        public IntPtr FlushDeviceTbOnly { get => ReadHere<IntPtr>(nameof(FlushDeviceTbOnly)); set => WriteHere(nameof(FlushDeviceTbOnly), value); }

        [Offset(56UL)]
        public IntPtr DismissPageFault { get => ReadHere<IntPtr>(nameof(DismissPageFault)); set => WriteHere(nameof(DismissPageFault), value); }

        [Offset(64UL)]
        public IntPtr GetPageFault { get => ReadHere<IntPtr>(nameof(GetPageFault)); set => WriteHere(nameof(GetPageFault), value); }

        [Offset(72UL)]
        public IntPtr SetMessageInterruptRouting { get => ReadHere<IntPtr>(nameof(SetMessageInterruptRouting)); set => WriteHere(nameof(SetMessageInterruptRouting), value); }

        [Offset(80UL)]
        public IntPtr EnableInterrupt { get => ReadHere<IntPtr>(nameof(EnableInterrupt)); set => WriteHere(nameof(EnableInterrupt), value); }

        [Offset(88UL)]
        public IntPtr DisableInterrupt { get => ReadHere<IntPtr>(nameof(DisableInterrupt)); set => WriteHere(nameof(DisableInterrupt), value); }

        [Offset(96UL)]
        public IntPtr HandleInterrupt { get => ReadHere<IntPtr>(nameof(HandleInterrupt)); set => WriteHere(nameof(HandleInterrupt), value); }

        [Offset(104UL)]
        public IntPtr CheckForReservedRegion { get => ReadHere<IntPtr>(nameof(CheckForReservedRegion)); set => WriteHere(nameof(CheckForReservedRegion), value); }

        [Offset(112UL)]
        public IntPtr MarkHiberRegions { get => ReadHere<IntPtr>(nameof(MarkHiberRegions)); set => WriteHere(nameof(MarkHiberRegions), value); }

        [Offset(120UL)]
        public IntPtr DrainSvmPageRequests { get => ReadHere<IntPtr>(nameof(DrainSvmPageRequests)); set => WriteHere(nameof(DrainSvmPageRequests), value); }

        [Offset(128UL)]
        public IntPtr CancelPageRequests { get => ReadHere<IntPtr>(nameof(CancelPageRequests)); set => WriteHere(nameof(CancelPageRequests), value); }

        [Offset(136UL)]
        public IntPtr EnumerateReservedDevices { get => ReadHere<IntPtr>(nameof(EnumerateReservedDevices)); set => WriteHere(nameof(EnumerateReservedDevices), value); }

        [Offset(144UL)]
        public IntPtr ProcessReservedDomains { get => ReadHere<IntPtr>(nameof(ProcessReservedDomains)); set => WriteHere(nameof(ProcessReservedDomains), value); }

        [Offset(152UL)]
        public IntPtr QueryAcpiDeviceMapping { get => ReadHere<IntPtr>(nameof(QueryAcpiDeviceMapping)); set => WriteHere(nameof(QueryAcpiDeviceMapping), value); }

        [Offset(160UL)]
        public IntPtr GetRidAcpiMapCount { get => ReadHere<IntPtr>(nameof(GetRidAcpiMapCount)); set => WriteHere(nameof(GetRidAcpiMapCount), value); }

        [Offset(168UL)]
        public IntPtr ConfigureAts { get => ReadHere<IntPtr>(nameof(ConfigureAts)); set => WriteHere(nameof(ConfigureAts), value); }

        [Offset(176UL)]
        public IntPtr SetDeviceSvmCapabilitiesLegacy { get => ReadHere<IntPtr>(nameof(SetDeviceSvmCapabilitiesLegacy)); set => WriteHere(nameof(SetDeviceSvmCapabilitiesLegacy), value); }

        public ExtIommuFunctionTableExtended(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuFunctionTableExtended>();
        }
    }
}