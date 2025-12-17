using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_IOMMU_DISPATCH")]
    public sealed class HalIommuDispatch : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr HalIommuSupportEnabled { get => ReadHere<IntPtr>(nameof(HalIommuSupportEnabled)); set => WriteHere(nameof(HalIommuSupportEnabled), value); }

        [Offset(8UL)]
        public IntPtr HalIommuGetConfiguration { get => ReadHere<IntPtr>(nameof(HalIommuGetConfiguration)); set => WriteHere(nameof(HalIommuGetConfiguration), value); }

        [Offset(16UL)]
        public IntPtr HalIommuGetLibraryContext { get => ReadHere<IntPtr>(nameof(HalIommuGetLibraryContext)); set => WriteHere(nameof(HalIommuGetLibraryContext), value); }

        [Offset(24UL)]
        public IntPtr HalIommuMapDevice { get => ReadHere<IntPtr>(nameof(HalIommuMapDevice)); set => WriteHere(nameof(HalIommuMapDevice), value); }

        [Offset(32UL)]
        public IntPtr HalIommuEnableDevicePasid { get => ReadHere<IntPtr>(nameof(HalIommuEnableDevicePasid)); set => WriteHere(nameof(HalIommuEnableDevicePasid), value); }

        [Offset(40UL)]
        public IntPtr HalIommuSetAddressSpace { get => ReadHere<IntPtr>(nameof(HalIommuSetAddressSpace)); set => WriteHere(nameof(HalIommuSetAddressSpace), value); }

        [Offset(48UL)]
        public IntPtr HalIommuDisableDevicePasid { get => ReadHere<IntPtr>(nameof(HalIommuDisableDevicePasid)); set => WriteHere(nameof(HalIommuDisableDevicePasid), value); }

        [Offset(56UL)]
        public IntPtr HalIommuUnmapDevice { get => ReadHere<IntPtr>(nameof(HalIommuUnmapDevice)); set => WriteHere(nameof(HalIommuUnmapDevice), value); }

        [Offset(64UL)]
        public IntPtr HalIommuFreeLibraryContext { get => ReadHere<IntPtr>(nameof(HalIommuFreeLibraryContext)); set => WriteHere(nameof(HalIommuFreeLibraryContext), value); }

        [Offset(72UL)]
        public IntPtr HalIommuFlushTb { get => ReadHere<IntPtr>(nameof(HalIommuFlushTb)); set => WriteHere(nameof(HalIommuFlushTb), value); }

        [Offset(80UL)]
        public IntPtr HalIommuFlushAllPasid { get => ReadHere<IntPtr>(nameof(HalIommuFlushAllPasid)); set => WriteHere(nameof(HalIommuFlushAllPasid), value); }

        [Offset(88UL)]
        public IntPtr HalIommuProcessPageRequestQueue { get => ReadHere<IntPtr>(nameof(HalIommuProcessPageRequestQueue)); set => WriteHere(nameof(HalIommuProcessPageRequestQueue), value); }

        [Offset(96UL)]
        public IntPtr HalIommuFaultRoutine { get => ReadHere<IntPtr>(nameof(HalIommuFaultRoutine)); set => WriteHere(nameof(HalIommuFaultRoutine), value); }

        [Offset(104UL)]
        public IntPtr HalIommuReferenceAsid { get => ReadHere<IntPtr>(nameof(HalIommuReferenceAsid)); set => WriteHere(nameof(HalIommuReferenceAsid), value); }

        [Offset(112UL)]
        public IntPtr HalIommuDereferenceAsid { get => ReadHere<IntPtr>(nameof(HalIommuDereferenceAsid)); set => WriteHere(nameof(HalIommuDereferenceAsid), value); }

        [Offset(120UL)]
        public IntPtr HalIommuServicePageFault { get => ReadHere<IntPtr>(nameof(HalIommuServicePageFault)); set => WriteHere(nameof(HalIommuServicePageFault), value); }

        [Offset(128UL)]
        public IntPtr HalIommuDevicePowerChange { get => ReadHere<IntPtr>(nameof(HalIommuDevicePowerChange)); set => WriteHere(nameof(HalIommuDevicePowerChange), value); }

        [Offset(136UL)]
        public IntPtr HalIommuBeginDeviceReset { get => ReadHere<IntPtr>(nameof(HalIommuBeginDeviceReset)); set => WriteHere(nameof(HalIommuBeginDeviceReset), value); }

        [Offset(144UL)]
        public IntPtr HalIommuFinalizeDeviceReset { get => ReadHere<IntPtr>(nameof(HalIommuFinalizeDeviceReset)); set => WriteHere(nameof(HalIommuFinalizeDeviceReset), value); }

        [Offset(152UL)]
        public IntPtr HalIommuGetAtsSettings { get => ReadHere<IntPtr>(nameof(HalIommuGetAtsSettings)); set => WriteHere(nameof(HalIommuGetAtsSettings), value); }

        [Offset(160UL)]
        public IntPtr HalIommuCreateAtsDevice { get => ReadHere<IntPtr>(nameof(HalIommuCreateAtsDevice)); set => WriteHere(nameof(HalIommuCreateAtsDevice), value); }

        [Offset(168UL)]
        public IntPtr HalIommuDeleteAtsDevice { get => ReadHere<IntPtr>(nameof(HalIommuDeleteAtsDevice)); set => WriteHere(nameof(HalIommuDeleteAtsDevice), value); }

        [Offset(176UL)]
        public IntPtr HalIommuGetDomainTransitionSupport { get => ReadHere<IntPtr>(nameof(HalIommuGetDomainTransitionSupport)); set => WriteHere(nameof(HalIommuGetDomainTransitionSupport), value); }

        [Offset(184UL)]
        public IntPtr HalIommuSetDeviceMpam { get => ReadHere<IntPtr>(nameof(HalIommuSetDeviceMpam)); set => WriteHere(nameof(HalIommuSetDeviceMpam), value); }

        [Offset(192UL)]
        public IntPtr HalIommuGetDeviceMpam { get => ReadHere<IntPtr>(nameof(HalIommuGetDeviceMpam)); set => WriteHere(nameof(HalIommuGetDeviceMpam), value); }

        public HalIommuDispatch(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalIommuDispatch>();
        }
    }
}