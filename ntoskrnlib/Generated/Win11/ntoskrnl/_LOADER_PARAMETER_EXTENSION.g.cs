#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4400)]
    public partial struct _LOADER_PARAMETER_EXTENSION
    {
        [FieldOffset(0)]
        public uint Size;
        [FieldOffset(4)]
        public _PROFILE_PARAMETER_BLOCK Profile;
        [FieldOffset(24)]
        public IntPtr EmInfFileImage;
        [FieldOffset(32)]
        public uint EmInfFileSize;
        [FieldOffset(40)]
        public IntPtr TriageDumpBlock;
        [FieldOffset(48)]
        public IntPtr HeadlessLoaderBlock;
        [FieldOffset(56)]
        public IntPtr SMBiosEPSHeader;
        [FieldOffset(64)]
        public IntPtr DrvDBImage;
        [FieldOffset(72)]
        public uint DrvDBSize;
        [FieldOffset(80)]
        public IntPtr DrvDBPatchImage;
        [FieldOffset(88)]
        public uint DrvDBPatchSize;
        [FieldOffset(96)]
        public IntPtr NetworkLoaderBlock;
        [FieldOffset(104)]
        public _LIST_ENTRY FirmwareDescriptorListHead;
        [FieldOffset(120)]
        public IntPtr AcpiTable;
        [FieldOffset(128)]
        public uint AcpiTableSize;
        [FieldOffset(132)]
        public uint LastBootSucceeded;
        [FieldOffset(132)]
        public uint LastBootShutdown;
        [FieldOffset(132)]
        public uint IumPersistentDatabaseEnabled;
        [FieldOffset(132)]
        public uint BootDebuggerActive;
        [FieldOffset(132)]
        public uint StrongCodeGuarantees;
        [FieldOffset(132)]
        public uint HardStrongCodeGuarantees;
        [FieldOffset(132)]
        public uint SidSharingDisabled;
        [FieldOffset(132)]
        public uint TpmInitialized;
        [FieldOffset(132)]
        public uint VsmConfigured;
        [FieldOffset(132)]
        public uint IumEnabled;
        [FieldOffset(132)]
        public uint IsSmbboot;
        [FieldOffset(132)]
        public uint BootLogEnabled;
        [FieldOffset(132)]
        public uint DriverVerifierEnabled;
        [FieldOffset(132)]
        public uint SuppressMonitorX;
        [FieldOffset(132)]
        public uint KernelCetEnabled;
        [FieldOffset(132)]
        public uint SuppressSmap;
        [FieldOffset(132)]
        public uint PointerAuthKernelIpEnabled;
        [FieldOffset(132)]
        public uint SplitLargeNumaNodes;
        [FieldOffset(132)]
        public uint KernelCetAuditModeEnabled;
        [FieldOffset(132)]
        public uint VerboseSELEnabled;
        [FieldOffset(132)]
        public uint EarlyCrashDumpEnabled;
        [FieldOffset(132)]
        public uint FeatureSimulations;
        [FieldOffset(132)]
        public uint MicrocodeSelfHosting;
        [FieldOffset(132)]
        public uint XhciLegacyHandoffSkip;
        [FieldOffset(132)]
        public uint DisableInsiderOptInHVCI;
        [FieldOffset(132)]
        public uint MicrocodeMinVerSupported;
        [FieldOffset(132)]
        public uint GpuIommuEnabled;
        [FieldOffset(136)]
        public _LOADER_PERFORMANCE_DATA LoaderPerformanceData;
        [FieldOffset(232)]
        public _LIST_ENTRY BootApplicationPersistentData;
        [FieldOffset(248)]
        public IntPtr WmdTestResult;
        [FieldOffset(256)]
        public _GUID BootIdentifier;
        [FieldOffset(272)]
        public uint Reserved1;
        [FieldOffset(280)]
        public IntPtr DumpHeader;
        [FieldOffset(288)]
        public IntPtr BgContext;
        [FieldOffset(296)]
        public IntPtr NumaLocalityInfo;
        [FieldOffset(304)]
        public IntPtr NumaGroupAssignment;
        [FieldOffset(312)]
        public _LIST_ENTRY AttachedHives;
        [FieldOffset(328)]
        public uint MemoryCachingRequirementsCount;
        [FieldOffset(336)]
        public IntPtr MemoryCachingRequirements;
        [FieldOffset(344)]
        public _BOOT_ENTROPY_LDR_RESULT BootEntropyResult;
        [FieldOffset(2496)]
        public ulong ProcessorCounterFrequency;
        [FieldOffset(2504)]
        public _LOADER_PARAMETER_HYPERVISOR_EXTENSION HypervisorExtension;
        [FieldOffset(2568)]
        public _GUID HardwareConfigurationId;
        [FieldOffset(2584)]
        public _LIST_ENTRY HalExtensionModuleList;
        [FieldOffset(2600)]
        public _LIST_ENTRY PrmUpdateModuleList;
        [FieldOffset(2616)]
        public _LIST_ENTRY PrmFirmwareModuleList;
        [FieldOffset(2632)]
        public _LARGE_INTEGER SystemTime;
        [FieldOffset(2640)]
        public ulong TimeStampAtSystemTimeRead;
        [FieldOffset(2648)]
        public ulong BootFlags;
        [FieldOffset(2648)]
        public ulong DbgMenuOsSelection;
        [FieldOffset(2648)]
        public ulong DbgHiberBoot;
        [FieldOffset(2648)]
        public ulong DbgSoftRestart;
        [FieldOffset(2648)]
        public ulong DbgMeasuredLaunch;
        [FieldOffset(2648)]
        public ulong DbgMeasuredLaunchCapable;
        [FieldOffset(2648)]
        public ulong DbgSystemHiveReplace;
        [FieldOffset(2648)]
        public ulong DbgMeasuredLaunchSmmProtections;
        [FieldOffset(2648)]
        public ulong DbgMeasuredLaunchSmmLevel;
        [FieldOffset(2648)]
        public ulong DbgBugCheckRecovery;
        [FieldOffset(2648)]
        public ulong DbgFASR;
        [FieldOffset(2648)]
        public ulong DbgUseCachedBcd;
        [FieldOffset(2656)]
        public ulong InternalBootFlags;
        [FieldOffset(2656)]
        public ulong DbgUtcBootTime;
        [FieldOffset(2656)]
        public ulong DbgRtcBootTime;
        [FieldOffset(2656)]
        public ulong DbgNoLegacyServices;
        [FieldOffset(2664)]
        public IntPtr WfsFPData;
        [FieldOffset(2672)]
        public uint WfsFPDataSize;
        [FieldOffset(2680)]
        public _LOADER_BUGCHECK_PARAMETERS BugcheckParameters;
        [FieldOffset(2720)]
        public IntPtr ApiSetSchema;
        [FieldOffset(2728)]
        public uint ApiSetSchemaSize;
        [FieldOffset(2736)]
        public _LIST_ENTRY ApiSetSchemaExtensions;
        [FieldOffset(2752)]
        public _UNICODE_STRING AcpiBiosVersion;
        [FieldOffset(2768)]
        public _UNICODE_STRING SmbiosVersion;
        [FieldOffset(2784)]
        public _UNICODE_STRING EfiVersion;
        [FieldOffset(2800)]
        public IntPtr KdDebugDevice;
        [FieldOffset(2808)]
        public _OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2 OfflineCrashdumpConfigurationTable;
        [FieldOffset(2840)]
        public _UNICODE_STRING ManufacturingProfile;
        [FieldOffset(2856)]
        public IntPtr BbtBuffer;
        [FieldOffset(2864)]
        public ulong XsaveAllowedFeatures;
        [FieldOffset(2872)]
        public uint XsaveFlags;
        [FieldOffset(2880)]
        public IntPtr BootOptions;
        [FieldOffset(2888)]
        public uint IumEnablement;
        [FieldOffset(2892)]
        public uint IumPolicy;
        [FieldOffset(2896)]
        public int IumStatus;
        [FieldOffset(2900)]
        public uint BootId;
        [FieldOffset(2904)]
        public IntPtr CodeIntegrityData;
        [FieldOffset(2912)]
        public uint CodeIntegrityDataSize;
        [FieldOffset(2916)]
        public _LOADER_HIVE_RECOVERY_INFO SystemHiveRecoveryInfo;
        [FieldOffset(2936)]
        public uint SoftRestartCount;
        [FieldOffset(2944)]
        public long SoftRestartTime;
        [FieldOffset(2952)]
        public IntPtr HypercallCodeVa;
        [FieldOffset(2960)]
        public IntPtr HalVirtualAddress;
        [FieldOffset(2968)]
        public ulong HalNumberOfBytes;
        [FieldOffset(2976)]
        public IntPtr LeapSecondData;
        [FieldOffset(2984)]
        public uint MajorRelease;
        [FieldOffset(2988)]
        public uint Reserved2;
        [FieldOffset(2992)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 224)]
        public sbyte[] NtBuildLab;
        [FieldOffset(3216)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 224)]
        public sbyte[] NtBuildLabEx;
        [FieldOffset(3440)]
        public _LOADER_RESET_REASON ResetReason;
        [FieldOffset(3488)]
        public uint MaxPciBusNumber;
        [FieldOffset(3492)]
        public uint FeatureSettings;
        [FieldOffset(3496)]
        public uint HotPatchReserveSize;
        [FieldOffset(3500)]
        public uint KernelScpReserveSize;
        [FieldOffset(3504)]
        public _unnamed_tag_ MiniExecutive;
        [FieldOffset(3520)]
        public _VSM_PERFORMANCE_DATA VsmPerformanceData;
        [FieldOffset(3584)]
        public IntPtr NumaMemoryRanges;
        [FieldOffset(3592)]
        public uint NumaMemoryRangeCount;
        [FieldOffset(3596)]
        public uint IommuFaultPolicy;
        [FieldOffset(3600)]
        public _LOADER_FEATURE_CONFIGURATION_INFORMATION FeatureConfigurationInformation;
        [FieldOffset(3672)]
        public _ETW_BOOT_CONFIG EtwBootConfig;
        [FieldOffset(3696)]
        public IntPtr FwRamdiskInfo;
        [FieldOffset(3704)]
        public IntPtr IpmiHwContext;
        [FieldOffset(3712)]
        public ulong IdleThreadShadowStack;
        [FieldOffset(3720)]
        public ulong TransitionShadowStack;
        [FieldOffset(3728)]
        public IntPtr IstShadowStacksTable;
        [FieldOffset(3736)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] ReservedForKernelCet;
        [FieldOffset(3752)]
        public IntPtr MirroringData;
        [FieldOffset(3760)]
        public _LARGE_INTEGER Luid;
        [FieldOffset(3768)]
        public _unnamed_tag_ InstalledMemory;
        [FieldOffset(3784)]
        public _LIST_ENTRY HotPatchList;
        [FieldOffset(3800)]
        public IntPtr BSPMicrocodeData;
        [FieldOffset(3808)]
        public uint BSPMicrocodeDataSize;
        [FieldOffset(3816)]
        public _unnamed_tag_ CimfsInformation;
        [FieldOffset(3848)]
        public _LARGE_INTEGER HalSoftRebootDatabase;
        [FieldOffset(3856)]
        public uint KasanEnabled;
        [FieldOffset(3856)]
        public uint InitialSystemPowerStatePresent;
        [FieldOffset(3856)]
        public uint Unused2;
        [FieldOffset(3856)]
        public uint KasanFlags;
        [FieldOffset(3856)]
        public uint Unused3;
        [FieldOffset(3860)]
        public uint KernelLargeStackSize;
        [FieldOffset(3864)]
        public ulong PerformanceDataFrequency;
        [FieldOffset(3872)]
        public uint DriverProxyReserveSize;
        [FieldOffset(3880)]
        public IntPtr FunctionOverrideCapabilityMask;
        [FieldOffset(3888)]
        public IntPtr FunctionOverrideOptinCapabilities;
        [FieldOffset(3896)]
        public IntPtr PrmFwHandlerTable;
        [FieldOffset(3904)]
        public uint PrmFwHandlerCount;
        [FieldOffset(3912)]
        public ulong InitialSystemPowerState;
        [FieldOffset(3920)]
        public IntPtr MicrocodeRecord;
        [FieldOffset(3928)]
        public uint MicrocodeRecordSize;
        [FieldOffset(3936)]
        public IntPtr OslRamdiskInfo;
        [FieldOffset(3944)]
        public _unnamed_tag_ CompositefsInformation;
        [FieldOffset(3960)]
        public IntPtr FeatureConfigurationInformation2;
        [FieldOffset(3968)]
        public uint PageTableLogCount;
        [FieldOffset(3976)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public _OSLOADER_PAGE_TABLE_LOG[] PageTableLog;
        [FieldOffset(4376)]
        public ulong EntropyAccumulatorConfig;
        [FieldOffset(4384)]
        public _LOADER_BOOT_APPLICATION_SVN_INFORMATION BootAppSvnInfo;
    }
}