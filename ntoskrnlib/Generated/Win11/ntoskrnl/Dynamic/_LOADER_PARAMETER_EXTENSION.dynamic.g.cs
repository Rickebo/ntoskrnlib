using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOADER_PARAMETER_EXTENSION")]
    public sealed class _LOADER_PARAMETER_EXTENSION : DynamicStructure
    {
        public uint Size { get; }
        public _PROFILE_PARAMETER_BLOCK Profile { get; }
        public IntPtr EmInfFileImage { get; }
        public uint EmInfFileSize { get; }
        public IntPtr TriageDumpBlock { get; }
        public IntPtr HeadlessLoaderBlock { get; }
        public IntPtr SMBiosEPSHeader { get; }
        public IntPtr DrvDBImage { get; }
        public uint DrvDBSize { get; }
        public IntPtr DrvDBPatchImage { get; }
        public uint DrvDBPatchSize { get; }
        public IntPtr NetworkLoaderBlock { get; }
        public _LIST_ENTRY FirmwareDescriptorListHead { get; }
        public IntPtr AcpiTable { get; }
        public uint AcpiTableSize { get; }
        public uint LastBootSucceeded { get; }
        public uint LastBootShutdown { get; }
        public uint IumPersistentDatabaseEnabled { get; }
        public uint BootDebuggerActive { get; }
        public uint StrongCodeGuarantees { get; }
        public uint HardStrongCodeGuarantees { get; }
        public uint SidSharingDisabled { get; }
        public uint TpmInitialized { get; }
        public uint VsmConfigured { get; }
        public uint IumEnabled { get; }
        public uint IsSmbboot { get; }
        public uint BootLogEnabled { get; }
        public uint DriverVerifierEnabled { get; }
        public uint SuppressMonitorX { get; }
        public uint KernelCetEnabled { get; }
        public uint SuppressSmap { get; }
        public uint PointerAuthKernelIpEnabled { get; }
        public uint SplitLargeNumaNodes { get; }
        public uint KernelCetAuditModeEnabled { get; }
        public uint VerboseSELEnabled { get; }
        public uint EarlyCrashDumpEnabled { get; }
        public uint FeatureSimulations { get; }
        public uint MicrocodeSelfHosting { get; }
        public uint XhciLegacyHandoffSkip { get; }
        public uint DisableInsiderOptInHVCI { get; }
        public uint MicrocodeMinVerSupported { get; }
        public uint GpuIommuEnabled { get; }
        public _LOADER_PERFORMANCE_DATA LoaderPerformanceData { get; }
        public _LIST_ENTRY BootApplicationPersistentData { get; }
        public IntPtr WmdTestResult { get; }
        public _GUID BootIdentifier { get; }
        public uint Reserved1 { get; }
        public IntPtr DumpHeader { get; }
        public IntPtr BgContext { get; }
        public IntPtr NumaLocalityInfo { get; }
        public IntPtr NumaGroupAssignment { get; }
        public _LIST_ENTRY AttachedHives { get; }
        public uint MemoryCachingRequirementsCount { get; }
        public IntPtr MemoryCachingRequirements { get; }
        public _BOOT_ENTROPY_LDR_RESULT BootEntropyResult { get; }
        public ulong ProcessorCounterFrequency { get; }
        public _LOADER_PARAMETER_HYPERVISOR_EXTENSION HypervisorExtension { get; }
        public _GUID HardwareConfigurationId { get; }
        public _LIST_ENTRY HalExtensionModuleList { get; }
        public _LIST_ENTRY PrmUpdateModuleList { get; }
        public _LIST_ENTRY PrmFirmwareModuleList { get; }
        public _LARGE_INTEGER SystemTime { get; }
        public ulong TimeStampAtSystemTimeRead { get; }
        public ulong BootFlags { get; }
        public ulong DbgMenuOsSelection { get; }
        public ulong DbgHiberBoot { get; }
        public ulong DbgSoftRestart { get; }
        public ulong DbgMeasuredLaunch { get; }
        public ulong DbgMeasuredLaunchCapable { get; }
        public ulong DbgSystemHiveReplace { get; }
        public ulong DbgMeasuredLaunchSmmProtections { get; }
        public ulong DbgMeasuredLaunchSmmLevel { get; }
        public ulong DbgBugCheckRecovery { get; }
        public ulong DbgFASR { get; }
        public ulong DbgUseCachedBcd { get; }
        public ulong InternalBootFlags { get; }
        public ulong DbgUtcBootTime { get; }
        public ulong DbgRtcBootTime { get; }
        public ulong DbgNoLegacyServices { get; }
        public IntPtr WfsFPData { get; }
        public uint WfsFPDataSize { get; }
        public _LOADER_BUGCHECK_PARAMETERS BugcheckParameters { get; }
        public IntPtr ApiSetSchema { get; }
        public uint ApiSetSchemaSize { get; }
        public _LIST_ENTRY ApiSetSchemaExtensions { get; }
        public _UNICODE_STRING AcpiBiosVersion { get; }
        public _UNICODE_STRING SmbiosVersion { get; }
        public _UNICODE_STRING EfiVersion { get; }
        public IntPtr KdDebugDevice { get; }
        public _OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2 OfflineCrashdumpConfigurationTable { get; }
        public _UNICODE_STRING ManufacturingProfile { get; }
        public IntPtr BbtBuffer { get; }
        public ulong XsaveAllowedFeatures { get; }
        public uint XsaveFlags { get; }
        public IntPtr BootOptions { get; }
        public uint IumEnablement { get; }
        public uint IumPolicy { get; }
        public int IumStatus { get; }
        public uint BootId { get; }
        public IntPtr CodeIntegrityData { get; }
        public uint CodeIntegrityDataSize { get; }
        public _LOADER_HIVE_RECOVERY_INFO SystemHiveRecoveryInfo { get; }
        public uint SoftRestartCount { get; }
        public long SoftRestartTime { get; }
        public IntPtr HypercallCodeVa { get; }
        public IntPtr HalVirtualAddress { get; }
        public ulong HalNumberOfBytes { get; }
        public IntPtr LeapSecondData { get; }
        public uint MajorRelease { get; }
        public uint Reserved2 { get; }
        public sbyte[] NtBuildLab { get; }
        public sbyte[] NtBuildLabEx { get; }
        public _LOADER_RESET_REASON ResetReason { get; }
        public uint MaxPciBusNumber { get; }
        public uint FeatureSettings { get; }
        public uint HotPatchReserveSize { get; }
        public uint KernelScpReserveSize { get; }
        public _unnamed_tag_ MiniExecutive { get; }
        public _VSM_PERFORMANCE_DATA VsmPerformanceData { get; }
        public IntPtr NumaMemoryRanges { get; }
        public uint NumaMemoryRangeCount { get; }
        public uint IommuFaultPolicy { get; }
        public _LOADER_FEATURE_CONFIGURATION_INFORMATION FeatureConfigurationInformation { get; }
        public _ETW_BOOT_CONFIG EtwBootConfig { get; }
        public IntPtr FwRamdiskInfo { get; }
        public IntPtr IpmiHwContext { get; }
        public ulong IdleThreadShadowStack { get; }
        public ulong TransitionShadowStack { get; }
        public IntPtr IstShadowStacksTable { get; }
        public ulong[] ReservedForKernelCet { get; }
        public IntPtr MirroringData { get; }
        public _LARGE_INTEGER Luid { get; }
        public _unnamed_tag_ InstalledMemory { get; }
        public _LIST_ENTRY HotPatchList { get; }
        public IntPtr BSPMicrocodeData { get; }
        public uint BSPMicrocodeDataSize { get; }
        public _unnamed_tag_ CimfsInformation { get; }
        public _LARGE_INTEGER HalSoftRebootDatabase { get; }
        public uint KasanEnabled { get; }
        public uint InitialSystemPowerStatePresent { get; }
        public uint Unused2 { get; }
        public uint KasanFlags { get; }
        public uint Unused3 { get; }
        public uint KernelLargeStackSize { get; }
        public ulong PerformanceDataFrequency { get; }
        public uint DriverProxyReserveSize { get; }
        public IntPtr FunctionOverrideCapabilityMask { get; }
        public IntPtr FunctionOverrideOptinCapabilities { get; }
        public IntPtr PrmFwHandlerTable { get; }
        public uint PrmFwHandlerCount { get; }
        public ulong InitialSystemPowerState { get; }
        public IntPtr MicrocodeRecord { get; }
        public uint MicrocodeRecordSize { get; }
        public IntPtr OslRamdiskInfo { get; }
        public _unnamed_tag_ CompositefsInformation { get; }
        public IntPtr FeatureConfigurationInformation2 { get; }
        public uint PageTableLogCount { get; }
        public byte[] PageTableLog { get; }
        public ulong EntropyAccumulatorConfig { get; }
        public _LOADER_BOOT_APPLICATION_SVN_INFORMATION BootAppSvnInfo { get; }

        public _LOADER_PARAMETER_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOADER_PARAMETER_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.Profile),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.EmInfFileImage),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.EmInfFileSize),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.TriageDumpBlock),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.HeadlessLoaderBlock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.SMBiosEPSHeader),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DrvDBImage),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DrvDBSize),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DrvDBPatchImage),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DrvDBPatchSize),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.NetworkLoaderBlock),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.FirmwareDescriptorListHead),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.AcpiTable),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.AcpiTableSize),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.LastBootSucceeded),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.LastBootShutdown),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.IumPersistentDatabaseEnabled),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.BootDebuggerActive),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.StrongCodeGuarantees),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.HardStrongCodeGuarantees),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.SidSharingDisabled),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.TpmInitialized),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.VsmConfigured),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.IumEnabled),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.IsSmbboot),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.BootLogEnabled),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DriverVerifierEnabled),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.SuppressMonitorX),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.KernelCetEnabled),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.SuppressSmap),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.PointerAuthKernelIpEnabled),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.SplitLargeNumaNodes),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.KernelCetAuditModeEnabled),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.VerboseSELEnabled),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.EarlyCrashDumpEnabled),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.FeatureSimulations),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.MicrocodeSelfHosting),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.XhciLegacyHandoffSkip),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DisableInsiderOptInHVCI),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.MicrocodeMinVerSupported),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.GpuIommuEnabled),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.LoaderPerformanceData),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.BootApplicationPersistentData),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.WmdTestResult),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.BootIdentifier),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.Reserved1),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DumpHeader),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.BgContext),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.NumaLocalityInfo),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.NumaGroupAssignment),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.AttachedHives),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.MemoryCachingRequirementsCount),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.MemoryCachingRequirements),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.BootEntropyResult),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.ProcessorCounterFrequency),
                    new ulong[]
                    {
                        2496UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.HypervisorExtension),
                    new ulong[]
                    {
                        2504UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.HardwareConfigurationId),
                    new ulong[]
                    {
                        2568UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.HalExtensionModuleList),
                    new ulong[]
                    {
                        2584UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.PrmUpdateModuleList),
                    new ulong[]
                    {
                        2600UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.PrmFirmwareModuleList),
                    new ulong[]
                    {
                        2616UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.SystemTime),
                    new ulong[]
                    {
                        2632UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.TimeStampAtSystemTimeRead),
                    new ulong[]
                    {
                        2640UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.BootFlags),
                    new ulong[]
                    {
                        2648UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DbgMenuOsSelection),
                    new ulong[]
                    {
                        2648UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DbgHiberBoot),
                    new ulong[]
                    {
                        2648UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DbgSoftRestart),
                    new ulong[]
                    {
                        2648UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DbgMeasuredLaunch),
                    new ulong[]
                    {
                        2648UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DbgMeasuredLaunchCapable),
                    new ulong[]
                    {
                        2648UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DbgSystemHiveReplace),
                    new ulong[]
                    {
                        2648UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DbgMeasuredLaunchSmmProtections),
                    new ulong[]
                    {
                        2648UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DbgMeasuredLaunchSmmLevel),
                    new ulong[]
                    {
                        2648UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DbgBugCheckRecovery),
                    new ulong[]
                    {
                        2648UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DbgFASR),
                    new ulong[]
                    {
                        2648UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DbgUseCachedBcd),
                    new ulong[]
                    {
                        2648UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.InternalBootFlags),
                    new ulong[]
                    {
                        2656UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DbgUtcBootTime),
                    new ulong[]
                    {
                        2656UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DbgRtcBootTime),
                    new ulong[]
                    {
                        2656UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DbgNoLegacyServices),
                    new ulong[]
                    {
                        2656UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.WfsFPData),
                    new ulong[]
                    {
                        2664UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.WfsFPDataSize),
                    new ulong[]
                    {
                        2672UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.BugcheckParameters),
                    new ulong[]
                    {
                        2680UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.ApiSetSchema),
                    new ulong[]
                    {
                        2720UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.ApiSetSchemaSize),
                    new ulong[]
                    {
                        2728UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.ApiSetSchemaExtensions),
                    new ulong[]
                    {
                        2736UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.AcpiBiosVersion),
                    new ulong[]
                    {
                        2752UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.SmbiosVersion),
                    new ulong[]
                    {
                        2768UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.EfiVersion),
                    new ulong[]
                    {
                        2784UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.KdDebugDevice),
                    new ulong[]
                    {
                        2800UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.OfflineCrashdumpConfigurationTable),
                    new ulong[]
                    {
                        2808UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.ManufacturingProfile),
                    new ulong[]
                    {
                        2840UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.BbtBuffer),
                    new ulong[]
                    {
                        2856UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.XsaveAllowedFeatures),
                    new ulong[]
                    {
                        2864UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.XsaveFlags),
                    new ulong[]
                    {
                        2872UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.BootOptions),
                    new ulong[]
                    {
                        2880UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.IumEnablement),
                    new ulong[]
                    {
                        2888UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.IumPolicy),
                    new ulong[]
                    {
                        2892UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.IumStatus),
                    new ulong[]
                    {
                        2896UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.BootId),
                    new ulong[]
                    {
                        2900UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.CodeIntegrityData),
                    new ulong[]
                    {
                        2904UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.CodeIntegrityDataSize),
                    new ulong[]
                    {
                        2912UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.SystemHiveRecoveryInfo),
                    new ulong[]
                    {
                        2916UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.SoftRestartCount),
                    new ulong[]
                    {
                        2936UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.SoftRestartTime),
                    new ulong[]
                    {
                        2944UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.HypercallCodeVa),
                    new ulong[]
                    {
                        2952UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.HalVirtualAddress),
                    new ulong[]
                    {
                        2960UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.HalNumberOfBytes),
                    new ulong[]
                    {
                        2968UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.LeapSecondData),
                    new ulong[]
                    {
                        2976UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.MajorRelease),
                    new ulong[]
                    {
                        2984UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.Reserved2),
                    new ulong[]
                    {
                        2988UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.NtBuildLab),
                    new ulong[]
                    {
                        2992UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.NtBuildLabEx),
                    new ulong[]
                    {
                        3216UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.ResetReason),
                    new ulong[]
                    {
                        3440UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.MaxPciBusNumber),
                    new ulong[]
                    {
                        3488UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.FeatureSettings),
                    new ulong[]
                    {
                        3492UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.HotPatchReserveSize),
                    new ulong[]
                    {
                        3496UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.KernelScpReserveSize),
                    new ulong[]
                    {
                        3500UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.MiniExecutive),
                    new ulong[]
                    {
                        3504UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.VsmPerformanceData),
                    new ulong[]
                    {
                        3520UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.NumaMemoryRanges),
                    new ulong[]
                    {
                        3584UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.NumaMemoryRangeCount),
                    new ulong[]
                    {
                        3592UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.IommuFaultPolicy),
                    new ulong[]
                    {
                        3596UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.FeatureConfigurationInformation),
                    new ulong[]
                    {
                        3600UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.EtwBootConfig),
                    new ulong[]
                    {
                        3672UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.FwRamdiskInfo),
                    new ulong[]
                    {
                        3696UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.IpmiHwContext),
                    new ulong[]
                    {
                        3704UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.IdleThreadShadowStack),
                    new ulong[]
                    {
                        3712UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.TransitionShadowStack),
                    new ulong[]
                    {
                        3720UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.IstShadowStacksTable),
                    new ulong[]
                    {
                        3728UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.ReservedForKernelCet),
                    new ulong[]
                    {
                        3736UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.MirroringData),
                    new ulong[]
                    {
                        3752UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.Luid),
                    new ulong[]
                    {
                        3760UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.InstalledMemory),
                    new ulong[]
                    {
                        3768UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.HotPatchList),
                    new ulong[]
                    {
                        3784UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.BSPMicrocodeData),
                    new ulong[]
                    {
                        3800UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.BSPMicrocodeDataSize),
                    new ulong[]
                    {
                        3808UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.CimfsInformation),
                    new ulong[]
                    {
                        3816UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.HalSoftRebootDatabase),
                    new ulong[]
                    {
                        3848UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.KasanEnabled),
                    new ulong[]
                    {
                        3856UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.InitialSystemPowerStatePresent),
                    new ulong[]
                    {
                        3856UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.Unused2),
                    new ulong[]
                    {
                        3856UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.KasanFlags),
                    new ulong[]
                    {
                        3856UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.Unused3),
                    new ulong[]
                    {
                        3856UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.KernelLargeStackSize),
                    new ulong[]
                    {
                        3860UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.PerformanceDataFrequency),
                    new ulong[]
                    {
                        3864UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.DriverProxyReserveSize),
                    new ulong[]
                    {
                        3872UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.FunctionOverrideCapabilityMask),
                    new ulong[]
                    {
                        3880UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.FunctionOverrideOptinCapabilities),
                    new ulong[]
                    {
                        3888UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.PrmFwHandlerTable),
                    new ulong[]
                    {
                        3896UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.PrmFwHandlerCount),
                    new ulong[]
                    {
                        3904UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.InitialSystemPowerState),
                    new ulong[]
                    {
                        3912UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.MicrocodeRecord),
                    new ulong[]
                    {
                        3920UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.MicrocodeRecordSize),
                    new ulong[]
                    {
                        3928UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.OslRamdiskInfo),
                    new ulong[]
                    {
                        3936UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.CompositefsInformation),
                    new ulong[]
                    {
                        3944UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.FeatureConfigurationInformation2),
                    new ulong[]
                    {
                        3960UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.PageTableLogCount),
                    new ulong[]
                    {
                        3968UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.PageTableLog),
                    new ulong[]
                    {
                        3976UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.EntropyAccumulatorConfig),
                    new ulong[]
                    {
                        4376UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_EXTENSION.BootAppSvnInfo),
                    new ulong[]
                    {
                        4384UL
                    }
                }
            };
            Register<_LOADER_PARAMETER_EXTENSION>((mem, ptr) => new _LOADER_PARAMETER_EXTENSION(mem, ptr), offsets);
        }
    }
}