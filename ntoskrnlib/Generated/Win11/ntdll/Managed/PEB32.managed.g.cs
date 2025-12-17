using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PEB32")]
    public sealed class PEB32 : DynamicStructure
    {
        [Offset(0UL)]
        public byte InheritedAddressSpace { get => ReadHere<byte>(nameof(InheritedAddressSpace)); set => WriteHere(nameof(InheritedAddressSpace), value); }

        [Offset(1UL)]
        public byte ReadImageFileExecOptions { get => ReadHere<byte>(nameof(ReadImageFileExecOptions)); set => WriteHere(nameof(ReadImageFileExecOptions), value); }

        [Offset(2UL)]
        public byte BeingDebugged { get => ReadHere<byte>(nameof(BeingDebugged)); set => WriteHere(nameof(BeingDebugged), value); }

        [Offset(3UL)]
        public byte BitField { get => ReadHere<byte>(nameof(BitField)); set => WriteHere(nameof(BitField), value); }

        [Offset(3UL)]
        public byte ImageUsesLargePages { get => ReadHere<byte>(nameof(ImageUsesLargePages)); set => WriteHere(nameof(ImageUsesLargePages), value); }

        [Offset(3UL)]
        public byte IsProtectedProcess { get => ReadHere<byte>(nameof(IsProtectedProcess)); set => WriteHere(nameof(IsProtectedProcess), value); }

        [Offset(3UL)]
        public byte IsImageDynamicallyRelocated { get => ReadHere<byte>(nameof(IsImageDynamicallyRelocated)); set => WriteHere(nameof(IsImageDynamicallyRelocated), value); }

        [Offset(3UL)]
        public byte SkipPatchingUser32Forwarders { get => ReadHere<byte>(nameof(SkipPatchingUser32Forwarders)); set => WriteHere(nameof(SkipPatchingUser32Forwarders), value); }

        [Offset(3UL)]
        public byte IsPackagedProcess { get => ReadHere<byte>(nameof(IsPackagedProcess)); set => WriteHere(nameof(IsPackagedProcess), value); }

        [Offset(3UL)]
        public byte IsAppContainer { get => ReadHere<byte>(nameof(IsAppContainer)); set => WriteHere(nameof(IsAppContainer), value); }

        [Offset(3UL)]
        public byte IsProtectedProcessLight { get => ReadHere<byte>(nameof(IsProtectedProcessLight)); set => WriteHere(nameof(IsProtectedProcessLight), value); }

        [Offset(3UL)]
        public byte IsLongPathAwareProcess { get => ReadHere<byte>(nameof(IsLongPathAwareProcess)); set => WriteHere(nameof(IsLongPathAwareProcess), value); }

        [Offset(4UL)]
        public uint Mutant { get => ReadHere<uint>(nameof(Mutant)); set => WriteHere(nameof(Mutant), value); }

        [Offset(8UL)]
        public uint ImageBaseAddress { get => ReadHere<uint>(nameof(ImageBaseAddress)); set => WriteHere(nameof(ImageBaseAddress), value); }

        [Offset(12UL)]
        public uint Ldr { get => ReadHere<uint>(nameof(Ldr)); set => WriteHere(nameof(Ldr), value); }

        [Offset(16UL)]
        public uint ProcessParameters { get => ReadHere<uint>(nameof(ProcessParameters)); set => WriteHere(nameof(ProcessParameters), value); }

        [Offset(20UL)]
        public uint SubSystemData { get => ReadHere<uint>(nameof(SubSystemData)); set => WriteHere(nameof(SubSystemData), value); }

        [Offset(24UL)]
        public uint ProcessHeap { get => ReadHere<uint>(nameof(ProcessHeap)); set => WriteHere(nameof(ProcessHeap), value); }

        [Offset(28UL)]
        public uint FastPebLock { get => ReadHere<uint>(nameof(FastPebLock)); set => WriteHere(nameof(FastPebLock), value); }

        [Offset(32UL)]
        public uint AtlThunkSListPtr { get => ReadHere<uint>(nameof(AtlThunkSListPtr)); set => WriteHere(nameof(AtlThunkSListPtr), value); }

        [Offset(36UL)]
        public uint IFEOKey { get => ReadHere<uint>(nameof(IFEOKey)); set => WriteHere(nameof(IFEOKey), value); }

        [Offset(40UL)]
        public uint CrossProcessFlags { get => ReadHere<uint>(nameof(CrossProcessFlags)); set => WriteHere(nameof(CrossProcessFlags), value); }

        [Offset(40UL)]
        public uint ProcessInJob { get => ReadHere<uint>(nameof(ProcessInJob)); set => WriteHere(nameof(ProcessInJob), value); }

        [Offset(40UL)]
        public uint ProcessInitializing { get => ReadHere<uint>(nameof(ProcessInitializing)); set => WriteHere(nameof(ProcessInitializing), value); }

        [Offset(40UL)]
        public uint ProcessUsingVEH { get => ReadHere<uint>(nameof(ProcessUsingVEH)); set => WriteHere(nameof(ProcessUsingVEH), value); }

        [Offset(40UL)]
        public uint ProcessUsingVCH { get => ReadHere<uint>(nameof(ProcessUsingVCH)); set => WriteHere(nameof(ProcessUsingVCH), value); }

        [Offset(40UL)]
        public uint ProcessUsingFTH { get => ReadHere<uint>(nameof(ProcessUsingFTH)); set => WriteHere(nameof(ProcessUsingFTH), value); }

        [Offset(40UL)]
        public uint ProcessPreviouslyThrottled { get => ReadHere<uint>(nameof(ProcessPreviouslyThrottled)); set => WriteHere(nameof(ProcessPreviouslyThrottled), value); }

        [Offset(40UL)]
        public uint ProcessCurrentlyThrottled { get => ReadHere<uint>(nameof(ProcessCurrentlyThrottled)); set => WriteHere(nameof(ProcessCurrentlyThrottled), value); }

        [Offset(40UL)]
        public uint ProcessImagesHotPatched { get => ReadHere<uint>(nameof(ProcessImagesHotPatched)); set => WriteHere(nameof(ProcessImagesHotPatched), value); }

        [Offset(40UL)]
        public uint ReservedBits0 { get => ReadHere<uint>(nameof(ReservedBits0)); set => WriteHere(nameof(ReservedBits0), value); }

        [Offset(44UL)]
        public uint KernelCallbackTable { get => ReadHere<uint>(nameof(KernelCallbackTable)); set => WriteHere(nameof(KernelCallbackTable), value); }

        [Offset(44UL)]
        public uint UserSharedInfoPtr { get => ReadHere<uint>(nameof(UserSharedInfoPtr)); set => WriteHere(nameof(UserSharedInfoPtr), value); }

        [Offset(48UL)]
        public uint SystemReserved { get => ReadHere<uint>(nameof(SystemReserved)); set => WriteHere(nameof(SystemReserved), value); }

        [Offset(52UL)]
        public uint AtlThunkSListPtr32 { get => ReadHere<uint>(nameof(AtlThunkSListPtr32)); set => WriteHere(nameof(AtlThunkSListPtr32), value); }

        [Offset(56UL)]
        public uint ApiSetMap { get => ReadHere<uint>(nameof(ApiSetMap)); set => WriteHere(nameof(ApiSetMap), value); }

        [Offset(60UL)]
        public uint TlsExpansionCounter { get => ReadHere<uint>(nameof(TlsExpansionCounter)); set => WriteHere(nameof(TlsExpansionCounter), value); }

        [Offset(64UL)]
        public uint TlsBitmap { get => ReadHere<uint>(nameof(TlsBitmap)); set => WriteHere(nameof(TlsBitmap), value); }

        [Offset(68UL)]
        [Length(2)]
        public DynamicArray TlsBitmapBits { get => ReadStructure<DynamicArray>(nameof(TlsBitmapBits)); set => WriteStructure(nameof(TlsBitmapBits), value); }

        [Offset(76UL)]
        public uint ReadOnlySharedMemoryBase { get => ReadHere<uint>(nameof(ReadOnlySharedMemoryBase)); set => WriteHere(nameof(ReadOnlySharedMemoryBase), value); }

        [Offset(80UL)]
        public uint SharedData { get => ReadHere<uint>(nameof(SharedData)); set => WriteHere(nameof(SharedData), value); }

        [Offset(84UL)]
        public uint ReadOnlyStaticServerData { get => ReadHere<uint>(nameof(ReadOnlyStaticServerData)); set => WriteHere(nameof(ReadOnlyStaticServerData), value); }

        [Offset(88UL)]
        public uint AnsiCodePageData { get => ReadHere<uint>(nameof(AnsiCodePageData)); set => WriteHere(nameof(AnsiCodePageData), value); }

        [Offset(92UL)]
        public uint OemCodePageData { get => ReadHere<uint>(nameof(OemCodePageData)); set => WriteHere(nameof(OemCodePageData), value); }

        [Offset(96UL)]
        public uint UnicodeCaseTableData { get => ReadHere<uint>(nameof(UnicodeCaseTableData)); set => WriteHere(nameof(UnicodeCaseTableData), value); }

        [Offset(100UL)]
        public uint NumberOfProcessors { get => ReadHere<uint>(nameof(NumberOfProcessors)); set => WriteHere(nameof(NumberOfProcessors), value); }

        [Offset(104UL)]
        public uint NtGlobalFlag { get => ReadHere<uint>(nameof(NtGlobalFlag)); set => WriteHere(nameof(NtGlobalFlag), value); }

        [Offset(112UL)]
        public LargeInteger CriticalSectionTimeout { get => ReadStructure<LargeInteger>(nameof(CriticalSectionTimeout)); set => WriteStructure(nameof(CriticalSectionTimeout), value); }

        [Offset(120UL)]
        public uint HeapSegmentReserve { get => ReadHere<uint>(nameof(HeapSegmentReserve)); set => WriteHere(nameof(HeapSegmentReserve), value); }

        [Offset(124UL)]
        public uint HeapSegmentCommit { get => ReadHere<uint>(nameof(HeapSegmentCommit)); set => WriteHere(nameof(HeapSegmentCommit), value); }

        [Offset(128UL)]
        public uint HeapDeCommitTotalFreeThreshold { get => ReadHere<uint>(nameof(HeapDeCommitTotalFreeThreshold)); set => WriteHere(nameof(HeapDeCommitTotalFreeThreshold), value); }

        [Offset(132UL)]
        public uint HeapDeCommitFreeBlockThreshold { get => ReadHere<uint>(nameof(HeapDeCommitFreeBlockThreshold)); set => WriteHere(nameof(HeapDeCommitFreeBlockThreshold), value); }

        [Offset(136UL)]
        public uint NumberOfHeaps { get => ReadHere<uint>(nameof(NumberOfHeaps)); set => WriteHere(nameof(NumberOfHeaps), value); }

        [Offset(140UL)]
        public uint MaximumNumberOfHeaps { get => ReadHere<uint>(nameof(MaximumNumberOfHeaps)); set => WriteHere(nameof(MaximumNumberOfHeaps), value); }

        [Offset(144UL)]
        public uint ProcessHeaps { get => ReadHere<uint>(nameof(ProcessHeaps)); set => WriteHere(nameof(ProcessHeaps), value); }

        [Offset(148UL)]
        public uint GdiSharedHandleTable { get => ReadHere<uint>(nameof(GdiSharedHandleTable)); set => WriteHere(nameof(GdiSharedHandleTable), value); }

        [Offset(152UL)]
        public uint ProcessStarterHelper { get => ReadHere<uint>(nameof(ProcessStarterHelper)); set => WriteHere(nameof(ProcessStarterHelper), value); }

        [Offset(156UL)]
        public uint GdiDCAttributeList { get => ReadHere<uint>(nameof(GdiDCAttributeList)); set => WriteHere(nameof(GdiDCAttributeList), value); }

        [Offset(160UL)]
        public uint LoaderLock { get => ReadHere<uint>(nameof(LoaderLock)); set => WriteHere(nameof(LoaderLock), value); }

        [Offset(164UL)]
        public uint OSMajorVersion { get => ReadHere<uint>(nameof(OSMajorVersion)); set => WriteHere(nameof(OSMajorVersion), value); }

        [Offset(168UL)]
        public uint OSMinorVersion { get => ReadHere<uint>(nameof(OSMinorVersion)); set => WriteHere(nameof(OSMinorVersion), value); }

        [Offset(172UL)]
        public ushort OSBuildNumber { get => ReadHere<ushort>(nameof(OSBuildNumber)); set => WriteHere(nameof(OSBuildNumber), value); }

        [Offset(174UL)]
        public ushort OSCSDVersion { get => ReadHere<ushort>(nameof(OSCSDVersion)); set => WriteHere(nameof(OSCSDVersion), value); }

        [Offset(176UL)]
        public uint OSPlatformId { get => ReadHere<uint>(nameof(OSPlatformId)); set => WriteHere(nameof(OSPlatformId), value); }

        [Offset(180UL)]
        public uint ImageSubsystem { get => ReadHere<uint>(nameof(ImageSubsystem)); set => WriteHere(nameof(ImageSubsystem), value); }

        [Offset(184UL)]
        public uint ImageSubsystemMajorVersion { get => ReadHere<uint>(nameof(ImageSubsystemMajorVersion)); set => WriteHere(nameof(ImageSubsystemMajorVersion), value); }

        [Offset(188UL)]
        public uint ImageSubsystemMinorVersion { get => ReadHere<uint>(nameof(ImageSubsystemMinorVersion)); set => WriteHere(nameof(ImageSubsystemMinorVersion), value); }

        [Offset(192UL)]
        public uint ActiveProcessAffinityMask { get => ReadHere<uint>(nameof(ActiveProcessAffinityMask)); set => WriteHere(nameof(ActiveProcessAffinityMask), value); }

        [Offset(196UL)]
        [Length(34)]
        public DynamicArray GdiHandleBuffer { get => ReadStructure<DynamicArray>(nameof(GdiHandleBuffer)); set => WriteStructure(nameof(GdiHandleBuffer), value); }

        [Offset(332UL)]
        public uint PostProcessInitRoutine { get => ReadHere<uint>(nameof(PostProcessInitRoutine)); set => WriteHere(nameof(PostProcessInitRoutine), value); }

        [Offset(336UL)]
        public uint TlsExpansionBitmap { get => ReadHere<uint>(nameof(TlsExpansionBitmap)); set => WriteHere(nameof(TlsExpansionBitmap), value); }

        [Offset(340UL)]
        [Length(32)]
        public DynamicArray TlsExpansionBitmapBits { get => ReadStructure<DynamicArray>(nameof(TlsExpansionBitmapBits)); set => WriteStructure(nameof(TlsExpansionBitmapBits), value); }

        [Offset(468UL)]
        public uint SessionId { get => ReadHere<uint>(nameof(SessionId)); set => WriteHere(nameof(SessionId), value); }

        [Offset(472UL)]
        public UlargeInteger AppCompatFlags { get => ReadStructure<UlargeInteger>(nameof(AppCompatFlags)); set => WriteStructure(nameof(AppCompatFlags), value); }

        [Offset(480UL)]
        public UlargeInteger AppCompatFlagsUser { get => ReadStructure<UlargeInteger>(nameof(AppCompatFlagsUser)); set => WriteStructure(nameof(AppCompatFlagsUser), value); }

        [Offset(488UL)]
        public uint pShimData { get => ReadHere<uint>(nameof(pShimData)); set => WriteHere(nameof(pShimData), value); }

        [Offset(492UL)]
        public uint AppCompatInfo { get => ReadHere<uint>(nameof(AppCompatInfo)); set => WriteHere(nameof(AppCompatInfo), value); }

        [Offset(496UL)]
        public STRING32 CSDVersion { get => ReadStructure<STRING32>(nameof(CSDVersion)); set => WriteStructure(nameof(CSDVersion), value); }

        [Offset(504UL)]
        public uint ActivationContextData { get => ReadHere<uint>(nameof(ActivationContextData)); set => WriteHere(nameof(ActivationContextData), value); }

        [Offset(508UL)]
        public uint ProcessAssemblyStorageMap { get => ReadHere<uint>(nameof(ProcessAssemblyStorageMap)); set => WriteHere(nameof(ProcessAssemblyStorageMap), value); }

        [Offset(512UL)]
        public uint SystemDefaultActivationContextData { get => ReadHere<uint>(nameof(SystemDefaultActivationContextData)); set => WriteHere(nameof(SystemDefaultActivationContextData), value); }

        [Offset(516UL)]
        public uint SystemAssemblyStorageMap { get => ReadHere<uint>(nameof(SystemAssemblyStorageMap)); set => WriteHere(nameof(SystemAssemblyStorageMap), value); }

        [Offset(520UL)]
        public uint MinimumStackCommit { get => ReadHere<uint>(nameof(MinimumStackCommit)); set => WriteHere(nameof(MinimumStackCommit), value); }

        [Offset(524UL)]
        [Length(2)]
        public DynamicArray SparePointers { get => ReadStructure<DynamicArray>(nameof(SparePointers)); set => WriteStructure(nameof(SparePointers), value); }

        [Offset(532UL)]
        public uint PatchLoaderData { get => ReadHere<uint>(nameof(PatchLoaderData)); set => WriteHere(nameof(PatchLoaderData), value); }

        [Offset(536UL)]
        public uint ChpeV2ProcessInfo { get => ReadHere<uint>(nameof(ChpeV2ProcessInfo)); set => WriteHere(nameof(ChpeV2ProcessInfo), value); }

        [Offset(540UL)]
        public uint AppModelFeatureState { get => ReadHere<uint>(nameof(AppModelFeatureState)); set => WriteHere(nameof(AppModelFeatureState), value); }

        [Offset(544UL)]
        [Length(2)]
        public DynamicArray SpareUlongs { get => ReadStructure<DynamicArray>(nameof(SpareUlongs)); set => WriteStructure(nameof(SpareUlongs), value); }

        [Offset(552UL)]
        public ushort ActiveCodePage { get => ReadHere<ushort>(nameof(ActiveCodePage)); set => WriteHere(nameof(ActiveCodePage), value); }

        [Offset(554UL)]
        public ushort OemCodePage { get => ReadHere<ushort>(nameof(OemCodePage)); set => WriteHere(nameof(OemCodePage), value); }

        [Offset(556UL)]
        public ushort UseCaseMapping { get => ReadHere<ushort>(nameof(UseCaseMapping)); set => WriteHere(nameof(UseCaseMapping), value); }

        [Offset(558UL)]
        public ushort UnusedNlsField { get => ReadHere<ushort>(nameof(UnusedNlsField)); set => WriteHere(nameof(UnusedNlsField), value); }

        [Offset(560UL)]
        public uint WerRegistrationData { get => ReadHere<uint>(nameof(WerRegistrationData)); set => WriteHere(nameof(WerRegistrationData), value); }

        [Offset(564UL)]
        public uint WerShipAssertPtr { get => ReadHere<uint>(nameof(WerShipAssertPtr)); set => WriteHere(nameof(WerShipAssertPtr), value); }

        [Offset(568UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(572UL)]
        public uint pImageHeaderHash { get => ReadHere<uint>(nameof(pImageHeaderHash)); set => WriteHere(nameof(pImageHeaderHash), value); }

        [Offset(576UL)]
        public uint TracingFlags { get => ReadHere<uint>(nameof(TracingFlags)); set => WriteHere(nameof(TracingFlags), value); }

        [Offset(576UL)]
        public uint HeapTracingEnabled { get => ReadHere<uint>(nameof(HeapTracingEnabled)); set => WriteHere(nameof(HeapTracingEnabled), value); }

        [Offset(576UL)]
        public uint CritSecTracingEnabled { get => ReadHere<uint>(nameof(CritSecTracingEnabled)); set => WriteHere(nameof(CritSecTracingEnabled), value); }

        [Offset(576UL)]
        public uint LibLoaderTracingEnabled { get => ReadHere<uint>(nameof(LibLoaderTracingEnabled)); set => WriteHere(nameof(LibLoaderTracingEnabled), value); }

        [Offset(576UL)]
        public uint SpareTracingBits { get => ReadHere<uint>(nameof(SpareTracingBits)); set => WriteHere(nameof(SpareTracingBits), value); }

        [Offset(584UL)]
        public ulong CsrServerReadOnlySharedMemoryBase { get => ReadHere<ulong>(nameof(CsrServerReadOnlySharedMemoryBase)); set => WriteHere(nameof(CsrServerReadOnlySharedMemoryBase), value); }

        [Offset(592UL)]
        public uint TppWorkerpListLock { get => ReadHere<uint>(nameof(TppWorkerpListLock)); set => WriteHere(nameof(TppWorkerpListLock), value); }

        [Offset(596UL)]
        public ListENTRY32 TppWorkerpList { get => ReadStructure<ListENTRY32>(nameof(TppWorkerpList)); set => WriteStructure(nameof(TppWorkerpList), value); }

        [Offset(604UL)]
        [Length(128)]
        public DynamicArray WaitOnAddressHashTable { get => ReadStructure<DynamicArray>(nameof(WaitOnAddressHashTable)); set => WriteStructure(nameof(WaitOnAddressHashTable), value); }

        [Offset(1116UL)]
        public uint TelemetryCoverageHeader { get => ReadHere<uint>(nameof(TelemetryCoverageHeader)); set => WriteHere(nameof(TelemetryCoverageHeader), value); }

        [Offset(1120UL)]
        public uint CloudFileFlags { get => ReadHere<uint>(nameof(CloudFileFlags)); set => WriteHere(nameof(CloudFileFlags), value); }

        [Offset(1124UL)]
        public uint CloudFileDiagFlags { get => ReadHere<uint>(nameof(CloudFileDiagFlags)); set => WriteHere(nameof(CloudFileDiagFlags), value); }

        [Offset(1128UL)]
        public sbyte PlaceholderCompatibilityMode { get => ReadHere<sbyte>(nameof(PlaceholderCompatibilityMode)); set => WriteHere(nameof(PlaceholderCompatibilityMode), value); }

        [Offset(1129UL)]
        [Length(7)]
        public DynamicArray PlaceholderCompatibilityModeReserved { get => ReadStructure<DynamicArray>(nameof(PlaceholderCompatibilityModeReserved)); set => WriteStructure(nameof(PlaceholderCompatibilityModeReserved), value); }

        [Offset(1136UL)]
        public uint LeapSecondData { get => ReadHere<uint>(nameof(LeapSecondData)); set => WriteHere(nameof(LeapSecondData), value); }

        [Offset(1140UL)]
        public uint LeapSecondFlags { get => ReadHere<uint>(nameof(LeapSecondFlags)); set => WriteHere(nameof(LeapSecondFlags), value); }

        [Offset(1140UL)]
        public uint SixtySecondEnabled { get => ReadHere<uint>(nameof(SixtySecondEnabled)); set => WriteHere(nameof(SixtySecondEnabled), value); }

        [Offset(1140UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(1144UL)]
        public uint NtGlobalFlag2 { get => ReadHere<uint>(nameof(NtGlobalFlag2)); set => WriteHere(nameof(NtGlobalFlag2), value); }

        [Offset(1152UL)]
        public ulong ExtendedFeatureDisableMask { get => ReadHere<ulong>(nameof(ExtendedFeatureDisableMask)); set => WriteHere(nameof(ExtendedFeatureDisableMask), value); }

        public PEB32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PEB32>();
        }
    }
}