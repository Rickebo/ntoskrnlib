using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOADER_PARAMETER_EXTENSION")]
    public sealed class LoaderParameterExtension : DynamicStructure
    {
        [Offset(0UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(4UL)]
        public ProfileParameterBlock Profile { get => ReadStructure<ProfileParameterBlock>(nameof(Profile)); set => WriteStructure(nameof(Profile), value); }

        [Offset(24UL)]
        public IntPtr EmInfFileImage { get => ReadHere<IntPtr>(nameof(EmInfFileImage)); set => WriteHere(nameof(EmInfFileImage), value); }

        [Offset(32UL)]
        public uint EmInfFileSize { get => ReadHere<uint>(nameof(EmInfFileSize)); set => WriteHere(nameof(EmInfFileSize), value); }

        [Offset(40UL)]
        public IntPtr TriageDumpBlock { get => ReadHere<IntPtr>(nameof(TriageDumpBlock)); set => WriteHere(nameof(TriageDumpBlock), value); }

        [Offset(48UL)]
        public IntPtr HeadlessLoaderBlock { get => ReadHere<IntPtr>(nameof(HeadlessLoaderBlock)); set => WriteHere(nameof(HeadlessLoaderBlock), value); }

        [Offset(56UL)]
        public IntPtr SMBiosEPSHeader { get => ReadHere<IntPtr>(nameof(SMBiosEPSHeader)); set => WriteHere(nameof(SMBiosEPSHeader), value); }

        [Offset(64UL)]
        public IntPtr DrvDBImage { get => ReadHere<IntPtr>(nameof(DrvDBImage)); set => WriteHere(nameof(DrvDBImage), value); }

        [Offset(72UL)]
        public uint DrvDBSize { get => ReadHere<uint>(nameof(DrvDBSize)); set => WriteHere(nameof(DrvDBSize), value); }

        [Offset(80UL)]
        public IntPtr DrvDBPatchImage { get => ReadHere<IntPtr>(nameof(DrvDBPatchImage)); set => WriteHere(nameof(DrvDBPatchImage), value); }

        [Offset(88UL)]
        public uint DrvDBPatchSize { get => ReadHere<uint>(nameof(DrvDBPatchSize)); set => WriteHere(nameof(DrvDBPatchSize), value); }

        [Offset(96UL)]
        public IntPtr NetworkLoaderBlock { get => ReadHere<IntPtr>(nameof(NetworkLoaderBlock)); set => WriteHere(nameof(NetworkLoaderBlock), value); }

        [Offset(104UL)]
        public ListEntry FirmwareDescriptorListHead { get => ReadStructure<ListEntry>(nameof(FirmwareDescriptorListHead)); set => WriteStructure(nameof(FirmwareDescriptorListHead), value); }

        [Offset(120UL)]
        public IntPtr AcpiTable { get => ReadHere<IntPtr>(nameof(AcpiTable)); set => WriteHere(nameof(AcpiTable), value); }

        [Offset(128UL)]
        public uint AcpiTableSize { get => ReadHere<uint>(nameof(AcpiTableSize)); set => WriteHere(nameof(AcpiTableSize), value); }

        [Offset(132UL)]
        public uint LastBootSucceeded { get => ReadHere<uint>(nameof(LastBootSucceeded)); set => WriteHere(nameof(LastBootSucceeded), value); }

        [Offset(132UL)]
        public uint LastBootShutdown { get => ReadHere<uint>(nameof(LastBootShutdown)); set => WriteHere(nameof(LastBootShutdown), value); }

        [Offset(132UL)]
        public uint IumPersistentDatabaseEnabled { get => ReadHere<uint>(nameof(IumPersistentDatabaseEnabled)); set => WriteHere(nameof(IumPersistentDatabaseEnabled), value); }

        [Offset(132UL)]
        public uint BootDebuggerActive { get => ReadHere<uint>(nameof(BootDebuggerActive)); set => WriteHere(nameof(BootDebuggerActive), value); }

        [Offset(132UL)]
        public uint StrongCodeGuarantees { get => ReadHere<uint>(nameof(StrongCodeGuarantees)); set => WriteHere(nameof(StrongCodeGuarantees), value); }

        [Offset(132UL)]
        public uint HardStrongCodeGuarantees { get => ReadHere<uint>(nameof(HardStrongCodeGuarantees)); set => WriteHere(nameof(HardStrongCodeGuarantees), value); }

        [Offset(132UL)]
        public uint SidSharingDisabled { get => ReadHere<uint>(nameof(SidSharingDisabled)); set => WriteHere(nameof(SidSharingDisabled), value); }

        [Offset(132UL)]
        public uint TpmInitialized { get => ReadHere<uint>(nameof(TpmInitialized)); set => WriteHere(nameof(TpmInitialized), value); }

        [Offset(132UL)]
        public uint VsmConfigured { get => ReadHere<uint>(nameof(VsmConfigured)); set => WriteHere(nameof(VsmConfigured), value); }

        [Offset(132UL)]
        public uint IumEnabled { get => ReadHere<uint>(nameof(IumEnabled)); set => WriteHere(nameof(IumEnabled), value); }

        [Offset(132UL)]
        public uint IsSmbboot { get => ReadHere<uint>(nameof(IsSmbboot)); set => WriteHere(nameof(IsSmbboot), value); }

        [Offset(132UL)]
        public uint BootLogEnabled { get => ReadHere<uint>(nameof(BootLogEnabled)); set => WriteHere(nameof(BootLogEnabled), value); }

        [Offset(132UL)]
        public uint DriverVerifierEnabled { get => ReadHere<uint>(nameof(DriverVerifierEnabled)); set => WriteHere(nameof(DriverVerifierEnabled), value); }

        [Offset(132UL)]
        public uint SuppressMonitorX { get => ReadHere<uint>(nameof(SuppressMonitorX)); set => WriteHere(nameof(SuppressMonitorX), value); }

        [Offset(132UL)]
        public uint KernelCetEnabled { get => ReadHere<uint>(nameof(KernelCetEnabled)); set => WriteHere(nameof(KernelCetEnabled), value); }

        [Offset(132UL)]
        public uint SuppressSmap { get => ReadHere<uint>(nameof(SuppressSmap)); set => WriteHere(nameof(SuppressSmap), value); }

        [Offset(132UL)]
        public uint PointerAuthKernelIpEnabled { get => ReadHere<uint>(nameof(PointerAuthKernelIpEnabled)); set => WriteHere(nameof(PointerAuthKernelIpEnabled), value); }

        [Offset(132UL)]
        public uint SplitLargeNumaNodes { get => ReadHere<uint>(nameof(SplitLargeNumaNodes)); set => WriteHere(nameof(SplitLargeNumaNodes), value); }

        [Offset(132UL)]
        public uint KernelCetAuditModeEnabled { get => ReadHere<uint>(nameof(KernelCetAuditModeEnabled)); set => WriteHere(nameof(KernelCetAuditModeEnabled), value); }

        [Offset(132UL)]
        public uint VerboseSELEnabled { get => ReadHere<uint>(nameof(VerboseSELEnabled)); set => WriteHere(nameof(VerboseSELEnabled), value); }

        [Offset(132UL)]
        public uint EarlyCrashDumpEnabled { get => ReadHere<uint>(nameof(EarlyCrashDumpEnabled)); set => WriteHere(nameof(EarlyCrashDumpEnabled), value); }

        [Offset(132UL)]
        public uint FeatureSimulations { get => ReadHere<uint>(nameof(FeatureSimulations)); set => WriteHere(nameof(FeatureSimulations), value); }

        [Offset(132UL)]
        public uint MicrocodeSelfHosting { get => ReadHere<uint>(nameof(MicrocodeSelfHosting)); set => WriteHere(nameof(MicrocodeSelfHosting), value); }

        [Offset(132UL)]
        public uint XhciLegacyHandoffSkip { get => ReadHere<uint>(nameof(XhciLegacyHandoffSkip)); set => WriteHere(nameof(XhciLegacyHandoffSkip), value); }

        [Offset(132UL)]
        public uint DisableInsiderOptInHVCI { get => ReadHere<uint>(nameof(DisableInsiderOptInHVCI)); set => WriteHere(nameof(DisableInsiderOptInHVCI), value); }

        [Offset(132UL)]
        public uint MicrocodeMinVerSupported { get => ReadHere<uint>(nameof(MicrocodeMinVerSupported)); set => WriteHere(nameof(MicrocodeMinVerSupported), value); }

        [Offset(132UL)]
        public uint GpuIommuEnabled { get => ReadHere<uint>(nameof(GpuIommuEnabled)); set => WriteHere(nameof(GpuIommuEnabled), value); }

        [Offset(136UL)]
        public LoaderPerformanceData LoaderPerformanceData { get => ReadStructure<LoaderPerformanceData>(nameof(LoaderPerformanceData)); set => WriteStructure(nameof(LoaderPerformanceData), value); }

        [Offset(232UL)]
        public ListEntry BootApplicationPersistentData { get => ReadStructure<ListEntry>(nameof(BootApplicationPersistentData)); set => WriteStructure(nameof(BootApplicationPersistentData), value); }

        [Offset(248UL)]
        public IntPtr WmdTestResult { get => ReadHere<IntPtr>(nameof(WmdTestResult)); set => WriteHere(nameof(WmdTestResult), value); }

        [Offset(256UL)]
        public Guid BootIdentifier { get => ReadStructure<Guid>(nameof(BootIdentifier)); set => WriteStructure(nameof(BootIdentifier), value); }

        [Offset(272UL)]
        public uint Reserved1 { get => ReadHere<uint>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(280UL)]
        public IntPtr DumpHeader { get => ReadHere<IntPtr>(nameof(DumpHeader)); set => WriteHere(nameof(DumpHeader), value); }

        [Offset(288UL)]
        public IntPtr BgContext { get => ReadHere<IntPtr>(nameof(BgContext)); set => WriteHere(nameof(BgContext), value); }

        [Offset(296UL)]
        public IntPtr NumaLocalityInfo { get => ReadHere<IntPtr>(nameof(NumaLocalityInfo)); set => WriteHere(nameof(NumaLocalityInfo), value); }

        [Offset(304UL)]
        public IntPtr NumaGroupAssignment { get => ReadHere<IntPtr>(nameof(NumaGroupAssignment)); set => WriteHere(nameof(NumaGroupAssignment), value); }

        [Offset(312UL)]
        public ListEntry AttachedHives { get => ReadStructure<ListEntry>(nameof(AttachedHives)); set => WriteStructure(nameof(AttachedHives), value); }

        [Offset(328UL)]
        public uint MemoryCachingRequirementsCount { get => ReadHere<uint>(nameof(MemoryCachingRequirementsCount)); set => WriteHere(nameof(MemoryCachingRequirementsCount), value); }

        [Offset(336UL)]
        public IntPtr MemoryCachingRequirements { get => ReadHere<IntPtr>(nameof(MemoryCachingRequirements)); set => WriteHere(nameof(MemoryCachingRequirements), value); }

        [Offset(344UL)]
        public BootEntropyLdrResult BootEntropyResult { get => ReadStructure<BootEntropyLdrResult>(nameof(BootEntropyResult)); set => WriteStructure(nameof(BootEntropyResult), value); }

        [Offset(2496UL)]
        public ulong ProcessorCounterFrequency { get => ReadHere<ulong>(nameof(ProcessorCounterFrequency)); set => WriteHere(nameof(ProcessorCounterFrequency), value); }

        [Offset(2504UL)]
        public LoaderParameterHypervisorExtension HypervisorExtension { get => ReadStructure<LoaderParameterHypervisorExtension>(nameof(HypervisorExtension)); set => WriteStructure(nameof(HypervisorExtension), value); }

        [Offset(2568UL)]
        public Guid HardwareConfigurationId { get => ReadStructure<Guid>(nameof(HardwareConfigurationId)); set => WriteStructure(nameof(HardwareConfigurationId), value); }

        [Offset(2584UL)]
        public ListEntry HalExtensionModuleList { get => ReadStructure<ListEntry>(nameof(HalExtensionModuleList)); set => WriteStructure(nameof(HalExtensionModuleList), value); }

        [Offset(2600UL)]
        public ListEntry PrmUpdateModuleList { get => ReadStructure<ListEntry>(nameof(PrmUpdateModuleList)); set => WriteStructure(nameof(PrmUpdateModuleList), value); }

        [Offset(2616UL)]
        public ListEntry PrmFirmwareModuleList { get => ReadStructure<ListEntry>(nameof(PrmFirmwareModuleList)); set => WriteStructure(nameof(PrmFirmwareModuleList), value); }

        [Offset(2632UL)]
        public LargeInteger SystemTime { get => ReadStructure<LargeInteger>(nameof(SystemTime)); set => WriteStructure(nameof(SystemTime), value); }

        [Offset(2640UL)]
        public ulong TimeStampAtSystemTimeRead { get => ReadHere<ulong>(nameof(TimeStampAtSystemTimeRead)); set => WriteHere(nameof(TimeStampAtSystemTimeRead), value); }

        [Offset(2648UL)]
        public ulong BootFlags { get => ReadHere<ulong>(nameof(BootFlags)); set => WriteHere(nameof(BootFlags), value); }

        [Offset(2648UL)]
        public ulong DbgMenuOsSelection { get => ReadHere<ulong>(nameof(DbgMenuOsSelection)); set => WriteHere(nameof(DbgMenuOsSelection), value); }

        [Offset(2648UL)]
        public ulong DbgHiberBoot { get => ReadHere<ulong>(nameof(DbgHiberBoot)); set => WriteHere(nameof(DbgHiberBoot), value); }

        [Offset(2648UL)]
        public ulong DbgSoftRestart { get => ReadHere<ulong>(nameof(DbgSoftRestart)); set => WriteHere(nameof(DbgSoftRestart), value); }

        [Offset(2648UL)]
        public ulong DbgMeasuredLaunch { get => ReadHere<ulong>(nameof(DbgMeasuredLaunch)); set => WriteHere(nameof(DbgMeasuredLaunch), value); }

        [Offset(2648UL)]
        public ulong DbgMeasuredLaunchCapable { get => ReadHere<ulong>(nameof(DbgMeasuredLaunchCapable)); set => WriteHere(nameof(DbgMeasuredLaunchCapable), value); }

        [Offset(2648UL)]
        public ulong DbgSystemHiveReplace { get => ReadHere<ulong>(nameof(DbgSystemHiveReplace)); set => WriteHere(nameof(DbgSystemHiveReplace), value); }

        [Offset(2648UL)]
        public ulong DbgMeasuredLaunchSmmProtections { get => ReadHere<ulong>(nameof(DbgMeasuredLaunchSmmProtections)); set => WriteHere(nameof(DbgMeasuredLaunchSmmProtections), value); }

        [Offset(2648UL)]
        public ulong DbgMeasuredLaunchSmmLevel { get => ReadHere<ulong>(nameof(DbgMeasuredLaunchSmmLevel)); set => WriteHere(nameof(DbgMeasuredLaunchSmmLevel), value); }

        [Offset(2648UL)]
        public ulong DbgBugCheckRecovery { get => ReadHere<ulong>(nameof(DbgBugCheckRecovery)); set => WriteHere(nameof(DbgBugCheckRecovery), value); }

        [Offset(2648UL)]
        public ulong DbgFASR { get => ReadHere<ulong>(nameof(DbgFASR)); set => WriteHere(nameof(DbgFASR), value); }

        [Offset(2648UL)]
        public ulong DbgUseCachedBcd { get => ReadHere<ulong>(nameof(DbgUseCachedBcd)); set => WriteHere(nameof(DbgUseCachedBcd), value); }

        [Offset(2656UL)]
        public ulong InternalBootFlags { get => ReadHere<ulong>(nameof(InternalBootFlags)); set => WriteHere(nameof(InternalBootFlags), value); }

        [Offset(2656UL)]
        public ulong DbgUtcBootTime { get => ReadHere<ulong>(nameof(DbgUtcBootTime)); set => WriteHere(nameof(DbgUtcBootTime), value); }

        [Offset(2656UL)]
        public ulong DbgRtcBootTime { get => ReadHere<ulong>(nameof(DbgRtcBootTime)); set => WriteHere(nameof(DbgRtcBootTime), value); }

        [Offset(2656UL)]
        public ulong DbgNoLegacyServices { get => ReadHere<ulong>(nameof(DbgNoLegacyServices)); set => WriteHere(nameof(DbgNoLegacyServices), value); }

        [Offset(2664UL)]
        public IntPtr WfsFPData { get => ReadHere<IntPtr>(nameof(WfsFPData)); set => WriteHere(nameof(WfsFPData), value); }

        [Offset(2672UL)]
        public uint WfsFPDataSize { get => ReadHere<uint>(nameof(WfsFPDataSize)); set => WriteHere(nameof(WfsFPDataSize), value); }

        [Offset(2680UL)]
        public LoaderBugcheckParameters BugcheckParameters { get => ReadStructure<LoaderBugcheckParameters>(nameof(BugcheckParameters)); set => WriteStructure(nameof(BugcheckParameters), value); }

        [Offset(2720UL)]
        public IntPtr ApiSetSchema { get => ReadHere<IntPtr>(nameof(ApiSetSchema)); set => WriteHere(nameof(ApiSetSchema), value); }

        [Offset(2728UL)]
        public uint ApiSetSchemaSize { get => ReadHere<uint>(nameof(ApiSetSchemaSize)); set => WriteHere(nameof(ApiSetSchemaSize), value); }

        [Offset(2736UL)]
        public ListEntry ApiSetSchemaExtensions { get => ReadStructure<ListEntry>(nameof(ApiSetSchemaExtensions)); set => WriteStructure(nameof(ApiSetSchemaExtensions), value); }

        [Offset(2752UL)]
        public UnicodeString AcpiBiosVersion { get => ReadStructure<UnicodeString>(nameof(AcpiBiosVersion)); set => WriteStructure(nameof(AcpiBiosVersion), value); }

        [Offset(2768UL)]
        public UnicodeString SmbiosVersion { get => ReadStructure<UnicodeString>(nameof(SmbiosVersion)); set => WriteStructure(nameof(SmbiosVersion), value); }

        [Offset(2784UL)]
        public UnicodeString EfiVersion { get => ReadStructure<UnicodeString>(nameof(EfiVersion)); set => WriteStructure(nameof(EfiVersion), value); }

        [Offset(2800UL)]
        public IntPtr KdDebugDevice { get => ReadHere<IntPtr>(nameof(KdDebugDevice)); set => WriteHere(nameof(KdDebugDevice), value); }

        [Offset(2808UL)]
        public OfflineCrashdumpConfigurationTableV2 OfflineCrashdumpConfigurationTable { get => ReadStructure<OfflineCrashdumpConfigurationTableV2>(nameof(OfflineCrashdumpConfigurationTable)); set => WriteStructure(nameof(OfflineCrashdumpConfigurationTable), value); }

        [Offset(2840UL)]
        public UnicodeString ManufacturingProfile { get => ReadStructure<UnicodeString>(nameof(ManufacturingProfile)); set => WriteStructure(nameof(ManufacturingProfile), value); }

        [Offset(2856UL)]
        public IntPtr BbtBuffer { get => ReadHere<IntPtr>(nameof(BbtBuffer)); set => WriteHere(nameof(BbtBuffer), value); }

        [Offset(2864UL)]
        public ulong XsaveAllowedFeatures { get => ReadHere<ulong>(nameof(XsaveAllowedFeatures)); set => WriteHere(nameof(XsaveAllowedFeatures), value); }

        [Offset(2872UL)]
        public uint XsaveFlags { get => ReadHere<uint>(nameof(XsaveFlags)); set => WriteHere(nameof(XsaveFlags), value); }

        [Offset(2880UL)]
        public IntPtr BootOptions { get => ReadHere<IntPtr>(nameof(BootOptions)); set => WriteHere(nameof(BootOptions), value); }

        [Offset(2888UL)]
        public uint IumEnablement { get => ReadHere<uint>(nameof(IumEnablement)); set => WriteHere(nameof(IumEnablement), value); }

        [Offset(2892UL)]
        public uint IumPolicy { get => ReadHere<uint>(nameof(IumPolicy)); set => WriteHere(nameof(IumPolicy), value); }

        [Offset(2896UL)]
        public int IumStatus { get => ReadHere<int>(nameof(IumStatus)); set => WriteHere(nameof(IumStatus), value); }

        [Offset(2900UL)]
        public uint BootId { get => ReadHere<uint>(nameof(BootId)); set => WriteHere(nameof(BootId), value); }

        [Offset(2904UL)]
        public IntPtr CodeIntegrityData { get => ReadHere<IntPtr>(nameof(CodeIntegrityData)); set => WriteHere(nameof(CodeIntegrityData), value); }

        [Offset(2912UL)]
        public uint CodeIntegrityDataSize { get => ReadHere<uint>(nameof(CodeIntegrityDataSize)); set => WriteHere(nameof(CodeIntegrityDataSize), value); }

        [Offset(2916UL)]
        public LoaderHiveRecoveryInfo SystemHiveRecoveryInfo { get => ReadStructure<LoaderHiveRecoveryInfo>(nameof(SystemHiveRecoveryInfo)); set => WriteStructure(nameof(SystemHiveRecoveryInfo), value); }

        [Offset(2936UL)]
        public uint SoftRestartCount { get => ReadHere<uint>(nameof(SoftRestartCount)); set => WriteHere(nameof(SoftRestartCount), value); }

        [Offset(2944UL)]
        public long SoftRestartTime { get => ReadHere<long>(nameof(SoftRestartTime)); set => WriteHere(nameof(SoftRestartTime), value); }

        [Offset(2952UL)]
        public IntPtr HypercallCodeVa { get => ReadHere<IntPtr>(nameof(HypercallCodeVa)); set => WriteHere(nameof(HypercallCodeVa), value); }

        [Offset(2960UL)]
        public IntPtr HalVirtualAddress { get => ReadHere<IntPtr>(nameof(HalVirtualAddress)); set => WriteHere(nameof(HalVirtualAddress), value); }

        [Offset(2968UL)]
        public ulong HalNumberOfBytes { get => ReadHere<ulong>(nameof(HalNumberOfBytes)); set => WriteHere(nameof(HalNumberOfBytes), value); }

        [Offset(2976UL)]
        public IntPtr LeapSecondData { get => ReadHere<IntPtr>(nameof(LeapSecondData)); set => WriteHere(nameof(LeapSecondData), value); }

        [Offset(2984UL)]
        public uint MajorRelease { get => ReadHere<uint>(nameof(MajorRelease)); set => WriteHere(nameof(MajorRelease), value); }

        [Offset(2988UL)]
        public uint Reserved2 { get => ReadHere<uint>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(2992UL)]
        [Length(224)]
        public DynamicArray NtBuildLab { get => ReadStructure<DynamicArray>(nameof(NtBuildLab)); set => WriteStructure(nameof(NtBuildLab), value); }

        [Offset(3216UL)]
        [Length(224)]
        public DynamicArray NtBuildLabEx { get => ReadStructure<DynamicArray>(nameof(NtBuildLabEx)); set => WriteStructure(nameof(NtBuildLabEx), value); }

        [Offset(3440UL)]
        public LoaderResetReason ResetReason { get => ReadStructure<LoaderResetReason>(nameof(ResetReason)); set => WriteStructure(nameof(ResetReason), value); }

        [Offset(3488UL)]
        public uint MaxPciBusNumber { get => ReadHere<uint>(nameof(MaxPciBusNumber)); set => WriteHere(nameof(MaxPciBusNumber), value); }

        [Offset(3492UL)]
        public uint FeatureSettings { get => ReadHere<uint>(nameof(FeatureSettings)); set => WriteHere(nameof(FeatureSettings), value); }

        [Offset(3496UL)]
        public uint HotPatchReserveSize { get => ReadHere<uint>(nameof(HotPatchReserveSize)); set => WriteHere(nameof(HotPatchReserveSize), value); }

        [Offset(3500UL)]
        public uint KernelScpReserveSize { get => ReadHere<uint>(nameof(KernelScpReserveSize)); set => WriteHere(nameof(KernelScpReserveSize), value); }

        [Offset(3504UL)]
        public UnnamedTag MiniExecutive { get => ReadStructure<UnnamedTag>(nameof(MiniExecutive)); set => WriteStructure(nameof(MiniExecutive), value); }

        [Offset(3520UL)]
        public VsmPerformanceData VsmPerformanceData { get => ReadStructure<VsmPerformanceData>(nameof(VsmPerformanceData)); set => WriteStructure(nameof(VsmPerformanceData), value); }

        [Offset(3584UL)]
        public IntPtr NumaMemoryRanges { get => ReadHere<IntPtr>(nameof(NumaMemoryRanges)); set => WriteHere(nameof(NumaMemoryRanges), value); }

        [Offset(3592UL)]
        public uint NumaMemoryRangeCount { get => ReadHere<uint>(nameof(NumaMemoryRangeCount)); set => WriteHere(nameof(NumaMemoryRangeCount), value); }

        [Offset(3596UL)]
        public uint IommuFaultPolicy { get => ReadHere<uint>(nameof(IommuFaultPolicy)); set => WriteHere(nameof(IommuFaultPolicy), value); }

        [Offset(3600UL)]
        public LoaderFeatureConfigurationInformation FeatureConfigurationInformation { get => ReadStructure<LoaderFeatureConfigurationInformation>(nameof(FeatureConfigurationInformation)); set => WriteStructure(nameof(FeatureConfigurationInformation), value); }

        [Offset(3672UL)]
        public EtwBootConfig EtwBootConfig { get => ReadStructure<EtwBootConfig>(nameof(EtwBootConfig)); set => WriteStructure(nameof(EtwBootConfig), value); }

        [Offset(3696UL)]
        public IntPtr FwRamdiskInfo { get => ReadHere<IntPtr>(nameof(FwRamdiskInfo)); set => WriteHere(nameof(FwRamdiskInfo), value); }

        [Offset(3704UL)]
        public IntPtr IpmiHwContext { get => ReadHere<IntPtr>(nameof(IpmiHwContext)); set => WriteHere(nameof(IpmiHwContext), value); }

        [Offset(3712UL)]
        public ulong IdleThreadShadowStack { get => ReadHere<ulong>(nameof(IdleThreadShadowStack)); set => WriteHere(nameof(IdleThreadShadowStack), value); }

        [Offset(3720UL)]
        public ulong TransitionShadowStack { get => ReadHere<ulong>(nameof(TransitionShadowStack)); set => WriteHere(nameof(TransitionShadowStack), value); }

        [Offset(3728UL)]
        public IntPtr IstShadowStacksTable { get => ReadHere<IntPtr>(nameof(IstShadowStacksTable)); set => WriteHere(nameof(IstShadowStacksTable), value); }

        [Offset(3736UL)]
        [Length(2)]
        public DynamicArray ReservedForKernelCet { get => ReadStructure<DynamicArray>(nameof(ReservedForKernelCet)); set => WriteStructure(nameof(ReservedForKernelCet), value); }

        [Offset(3752UL)]
        public IntPtr MirroringData { get => ReadHere<IntPtr>(nameof(MirroringData)); set => WriteHere(nameof(MirroringData), value); }

        [Offset(3760UL)]
        public LargeInteger Luid { get => ReadStructure<LargeInteger>(nameof(Luid)); set => WriteStructure(nameof(Luid), value); }

        [Offset(3768UL)]
        public UnnamedTag InstalledMemory { get => ReadStructure<UnnamedTag>(nameof(InstalledMemory)); set => WriteStructure(nameof(InstalledMemory), value); }

        [Offset(3784UL)]
        public ListEntry HotPatchList { get => ReadStructure<ListEntry>(nameof(HotPatchList)); set => WriteStructure(nameof(HotPatchList), value); }

        [Offset(3800UL)]
        public IntPtr BSPMicrocodeData { get => ReadHere<IntPtr>(nameof(BSPMicrocodeData)); set => WriteHere(nameof(BSPMicrocodeData), value); }

        [Offset(3808UL)]
        public uint BSPMicrocodeDataSize { get => ReadHere<uint>(nameof(BSPMicrocodeDataSize)); set => WriteHere(nameof(BSPMicrocodeDataSize), value); }

        [Offset(3816UL)]
        public UnnamedTag CimfsInformation { get => ReadStructure<UnnamedTag>(nameof(CimfsInformation)); set => WriteStructure(nameof(CimfsInformation), value); }

        [Offset(3848UL)]
        public LargeInteger HalSoftRebootDatabase { get => ReadStructure<LargeInteger>(nameof(HalSoftRebootDatabase)); set => WriteStructure(nameof(HalSoftRebootDatabase), value); }

        [Offset(3856UL)]
        public uint KasanEnabled { get => ReadHere<uint>(nameof(KasanEnabled)); set => WriteHere(nameof(KasanEnabled), value); }

        [Offset(3856UL)]
        public uint InitialSystemPowerStatePresent { get => ReadHere<uint>(nameof(InitialSystemPowerStatePresent)); set => WriteHere(nameof(InitialSystemPowerStatePresent), value); }

        [Offset(3856UL)]
        public uint Unused2 { get => ReadHere<uint>(nameof(Unused2)); set => WriteHere(nameof(Unused2), value); }

        [Offset(3856UL)]
        public uint KasanFlags { get => ReadHere<uint>(nameof(KasanFlags)); set => WriteHere(nameof(KasanFlags), value); }

        [Offset(3856UL)]
        public uint Unused3 { get => ReadHere<uint>(nameof(Unused3)); set => WriteHere(nameof(Unused3), value); }

        [Offset(3860UL)]
        public uint KernelLargeStackSize { get => ReadHere<uint>(nameof(KernelLargeStackSize)); set => WriteHere(nameof(KernelLargeStackSize), value); }

        [Offset(3864UL)]
        public ulong PerformanceDataFrequency { get => ReadHere<ulong>(nameof(PerformanceDataFrequency)); set => WriteHere(nameof(PerformanceDataFrequency), value); }

        [Offset(3872UL)]
        public uint DriverProxyReserveSize { get => ReadHere<uint>(nameof(DriverProxyReserveSize)); set => WriteHere(nameof(DriverProxyReserveSize), value); }

        [Offset(3880UL)]
        public IntPtr FunctionOverrideCapabilityMask { get => ReadHere<IntPtr>(nameof(FunctionOverrideCapabilityMask)); set => WriteHere(nameof(FunctionOverrideCapabilityMask), value); }

        [Offset(3888UL)]
        public IntPtr FunctionOverrideOptinCapabilities { get => ReadHere<IntPtr>(nameof(FunctionOverrideOptinCapabilities)); set => WriteHere(nameof(FunctionOverrideOptinCapabilities), value); }

        [Offset(3896UL)]
        public IntPtr PrmFwHandlerTable { get => ReadHere<IntPtr>(nameof(PrmFwHandlerTable)); set => WriteHere(nameof(PrmFwHandlerTable), value); }

        [Offset(3904UL)]
        public uint PrmFwHandlerCount { get => ReadHere<uint>(nameof(PrmFwHandlerCount)); set => WriteHere(nameof(PrmFwHandlerCount), value); }

        [Offset(3912UL)]
        public ulong InitialSystemPowerState { get => ReadHere<ulong>(nameof(InitialSystemPowerState)); set => WriteHere(nameof(InitialSystemPowerState), value); }

        [Offset(3920UL)]
        public IntPtr MicrocodeRecord { get => ReadHere<IntPtr>(nameof(MicrocodeRecord)); set => WriteHere(nameof(MicrocodeRecord), value); }

        [Offset(3928UL)]
        public uint MicrocodeRecordSize { get => ReadHere<uint>(nameof(MicrocodeRecordSize)); set => WriteHere(nameof(MicrocodeRecordSize), value); }

        [Offset(3936UL)]
        public IntPtr OslRamdiskInfo { get => ReadHere<IntPtr>(nameof(OslRamdiskInfo)); set => WriteHere(nameof(OslRamdiskInfo), value); }

        [Offset(3944UL)]
        public UnnamedTag CompositefsInformation { get => ReadStructure<UnnamedTag>(nameof(CompositefsInformation)); set => WriteStructure(nameof(CompositefsInformation), value); }

        [Offset(3960UL)]
        public IntPtr FeatureConfigurationInformation2 { get => ReadHere<IntPtr>(nameof(FeatureConfigurationInformation2)); set => WriteHere(nameof(FeatureConfigurationInformation2), value); }

        [Offset(3968UL)]
        public uint PageTableLogCount { get => ReadHere<uint>(nameof(PageTableLogCount)); set => WriteHere(nameof(PageTableLogCount), value); }

        [Offset(3976UL)]
        [Length(10)]
        public DynamicArray PageTableLog { get => ReadStructure<DynamicArray>(nameof(PageTableLog)); set => WriteStructure(nameof(PageTableLog), value); }

        [Offset(4376UL)]
        public ulong EntropyAccumulatorConfig { get => ReadHere<ulong>(nameof(EntropyAccumulatorConfig)); set => WriteHere(nameof(EntropyAccumulatorConfig), value); }

        [Offset(4384UL)]
        public LoaderBootApplicationSvnInformation BootAppSvnInfo { get => ReadStructure<LoaderBootApplicationSvnInformation>(nameof(BootAppSvnInfo)); set => WriteStructure(nameof(BootAppSvnInfo), value); }

        public LoaderParameterExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoaderParameterExtension>();
        }
    }
}