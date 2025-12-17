using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOADER_PARAMETER_BLOCK")]
    public sealed class LoaderParameterBlock : DynamicStructure
    {
        [Offset(0UL)]
        public uint OsMajorVersion { get => ReadHere<uint>(nameof(OsMajorVersion)); set => WriteHere(nameof(OsMajorVersion), value); }

        [Offset(4UL)]
        public uint OsMinorVersion { get => ReadHere<uint>(nameof(OsMinorVersion)); set => WriteHere(nameof(OsMinorVersion), value); }

        [Offset(8UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(12UL)]
        public uint OsLoaderSecurityVersion { get => ReadHere<uint>(nameof(OsLoaderSecurityVersion)); set => WriteHere(nameof(OsLoaderSecurityVersion), value); }

        [Offset(16UL)]
        public ListEntry LoadOrderListHead { get => ReadStructure<ListEntry>(nameof(LoadOrderListHead)); set => WriteStructure(nameof(LoadOrderListHead), value); }

        [Offset(32UL)]
        public ListEntry MemoryDescriptorListHead { get => ReadStructure<ListEntry>(nameof(MemoryDescriptorListHead)); set => WriteStructure(nameof(MemoryDescriptorListHead), value); }

        [Offset(48UL)]
        public ListEntry BootDriverListHead { get => ReadStructure<ListEntry>(nameof(BootDriverListHead)); set => WriteStructure(nameof(BootDriverListHead), value); }

        [Offset(64UL)]
        public ListEntry EarlyLaunchListHead { get => ReadStructure<ListEntry>(nameof(EarlyLaunchListHead)); set => WriteStructure(nameof(EarlyLaunchListHead), value); }

        [Offset(80UL)]
        public ListEntry CoreDriverListHead { get => ReadStructure<ListEntry>(nameof(CoreDriverListHead)); set => WriteStructure(nameof(CoreDriverListHead), value); }

        [Offset(96UL)]
        public ListEntry CoreExtensionsDriverListHead { get => ReadStructure<ListEntry>(nameof(CoreExtensionsDriverListHead)); set => WriteStructure(nameof(CoreExtensionsDriverListHead), value); }

        [Offset(112UL)]
        public ListEntry TpmCoreDriverListHead { get => ReadStructure<ListEntry>(nameof(TpmCoreDriverListHead)); set => WriteStructure(nameof(TpmCoreDriverListHead), value); }

        [Offset(128UL)]
        public ulong KernelStack { get => ReadHere<ulong>(nameof(KernelStack)); set => WriteHere(nameof(KernelStack), value); }

        [Offset(136UL)]
        public ulong Prcb { get => ReadHere<ulong>(nameof(Prcb)); set => WriteHere(nameof(Prcb), value); }

        [Offset(144UL)]
        public ulong Process { get => ReadHere<ulong>(nameof(Process)); set => WriteHere(nameof(Process), value); }

        [Offset(152UL)]
        public ulong Thread { get => ReadHere<ulong>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(160UL)]
        public uint KernelStackSize { get => ReadHere<uint>(nameof(KernelStackSize)); set => WriteHere(nameof(KernelStackSize), value); }

        [Offset(164UL)]
        public uint RegistryLength { get => ReadHere<uint>(nameof(RegistryLength)); set => WriteHere(nameof(RegistryLength), value); }

        [Offset(168UL)]
        public IntPtr RegistryBase { get => ReadHere<IntPtr>(nameof(RegistryBase)); set => WriteHere(nameof(RegistryBase), value); }

        [Offset(176UL)]
        public IntPtr ConfigurationRoot { get => ReadHere<IntPtr>(nameof(ConfigurationRoot)); set => WriteHere(nameof(ConfigurationRoot), value); }

        [Offset(184UL)]
        public IntPtr ArcBootDeviceName { get => ReadHere<IntPtr>(nameof(ArcBootDeviceName)); set => WriteHere(nameof(ArcBootDeviceName), value); }

        [Offset(192UL)]
        public IntPtr ArcHalDeviceName { get => ReadHere<IntPtr>(nameof(ArcHalDeviceName)); set => WriteHere(nameof(ArcHalDeviceName), value); }

        [Offset(200UL)]
        public IntPtr NtBootPathName { get => ReadHere<IntPtr>(nameof(NtBootPathName)); set => WriteHere(nameof(NtBootPathName), value); }

        [Offset(208UL)]
        public IntPtr NtHalPathName { get => ReadHere<IntPtr>(nameof(NtHalPathName)); set => WriteHere(nameof(NtHalPathName), value); }

        [Offset(216UL)]
        public IntPtr LoadOptions { get => ReadHere<IntPtr>(nameof(LoadOptions)); set => WriteHere(nameof(LoadOptions), value); }

        [Offset(224UL)]
        public IntPtr NlsData { get => ReadHere<IntPtr>(nameof(NlsData)); set => WriteHere(nameof(NlsData), value); }

        [Offset(232UL)]
        public IntPtr ArcDiskInformation { get => ReadHere<IntPtr>(nameof(ArcDiskInformation)); set => WriteHere(nameof(ArcDiskInformation), value); }

        [Offset(240UL)]
        public IntPtr Extension { get => ReadHere<IntPtr>(nameof(Extension)); set => WriteHere(nameof(Extension), value); }

        [Offset(248UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        [Offset(264UL)]
        public FirmwareInformationLoaderBlock FirmwareInformation { get => ReadStructure<FirmwareInformationLoaderBlock>(nameof(FirmwareInformation)); set => WriteStructure(nameof(FirmwareInformation), value); }

        [Offset(328UL)]
        public IntPtr OsBootstatPathName { get => ReadHere<IntPtr>(nameof(OsBootstatPathName)); set => WriteHere(nameof(OsBootstatPathName), value); }

        [Offset(336UL)]
        public IntPtr ArcOSDataDeviceName { get => ReadHere<IntPtr>(nameof(ArcOSDataDeviceName)); set => WriteHere(nameof(ArcOSDataDeviceName), value); }

        [Offset(344UL)]
        public IntPtr ArcWindowsSysPartName { get => ReadHere<IntPtr>(nameof(ArcWindowsSysPartName)); set => WriteHere(nameof(ArcWindowsSysPartName), value); }

        [Offset(352UL)]
        public RtlRbTree MemoryDescriptorTree { get => ReadStructure<RtlRbTree>(nameof(MemoryDescriptorTree)); set => WriteStructure(nameof(MemoryDescriptorTree), value); }

        public LoaderParameterBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoaderParameterBlock>();
        }
    }
}