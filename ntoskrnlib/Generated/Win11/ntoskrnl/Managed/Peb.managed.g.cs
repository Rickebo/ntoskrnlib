using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEB")]
    public sealed class Peb : DynamicStructure
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
        [Length(4)]
        public DynamicArray Padding0 { get => ReadStructure<DynamicArray>(nameof(Padding0)); set => WriteStructure(nameof(Padding0), value); }

        [Offset(8UL)]
        public IntPtr Mutant { get => ReadHere<IntPtr>(nameof(Mutant)); set => WriteHere(nameof(Mutant), value); }

        [Offset(16UL)]
        public IntPtr ImageBaseAddress { get => ReadHere<IntPtr>(nameof(ImageBaseAddress)); set => WriteHere(nameof(ImageBaseAddress), value); }

        [Offset(24UL)]
        public IntPtr Ldr { get => ReadHere<IntPtr>(nameof(Ldr)); set => WriteHere(nameof(Ldr), value); }

        [Offset(32UL)]
        public IntPtr ProcessParameters { get => ReadHere<IntPtr>(nameof(ProcessParameters)); set => WriteHere(nameof(ProcessParameters), value); }

        [Offset(40UL)]
        public IntPtr SubSystemData { get => ReadHere<IntPtr>(nameof(SubSystemData)); set => WriteHere(nameof(SubSystemData), value); }

        [Offset(48UL)]
        public IntPtr ProcessHeap { get => ReadHere<IntPtr>(nameof(ProcessHeap)); set => WriteHere(nameof(ProcessHeap), value); }

        [Offset(56UL)]
        public IntPtr FastPebLock { get => ReadHere<IntPtr>(nameof(FastPebLock)); set => WriteHere(nameof(FastPebLock), value); }

        [Offset(64UL)]
        public IntPtr AtlThunkSListPtr { get => ReadHere<IntPtr>(nameof(AtlThunkSListPtr)); set => WriteHere(nameof(AtlThunkSListPtr), value); }

        [Offset(72UL)]
        public IntPtr IFEOKey { get => ReadHere<IntPtr>(nameof(IFEOKey)); set => WriteHere(nameof(IFEOKey), value); }

        [Offset(80UL)]
        public uint CrossProcessFlags { get => ReadHere<uint>(nameof(CrossProcessFlags)); set => WriteHere(nameof(CrossProcessFlags), value); }

        [Offset(80UL)]
        public uint ProcessInJob { get => ReadHere<uint>(nameof(ProcessInJob)); set => WriteHere(nameof(ProcessInJob), value); }

        [Offset(80UL)]
        public uint ProcessInitializing { get => ReadHere<uint>(nameof(ProcessInitializing)); set => WriteHere(nameof(ProcessInitializing), value); }

        [Offset(80UL)]
        public uint ProcessUsingVEH { get => ReadHere<uint>(nameof(ProcessUsingVEH)); set => WriteHere(nameof(ProcessUsingVEH), value); }

        [Offset(80UL)]
        public uint ProcessUsingVCH { get => ReadHere<uint>(nameof(ProcessUsingVCH)); set => WriteHere(nameof(ProcessUsingVCH), value); }

        [Offset(80UL)]
        public uint ProcessUsingFTH { get => ReadHere<uint>(nameof(ProcessUsingFTH)); set => WriteHere(nameof(ProcessUsingFTH), value); }

        [Offset(80UL)]
        public uint ProcessPreviouslyThrottled { get => ReadHere<uint>(nameof(ProcessPreviouslyThrottled)); set => WriteHere(nameof(ProcessPreviouslyThrottled), value); }

        [Offset(80UL)]
        public uint ProcessCurrentlyThrottled { get => ReadHere<uint>(nameof(ProcessCurrentlyThrottled)); set => WriteHere(nameof(ProcessCurrentlyThrottled), value); }

        [Offset(80UL)]
        public uint ProcessImagesHotPatched { get => ReadHere<uint>(nameof(ProcessImagesHotPatched)); set => WriteHere(nameof(ProcessImagesHotPatched), value); }

        [Offset(80UL)]
        public uint ReservedBits0 { get => ReadHere<uint>(nameof(ReservedBits0)); set => WriteHere(nameof(ReservedBits0), value); }

        [Offset(84UL)]
        [Length(4)]
        public DynamicArray Padding1 { get => ReadStructure<DynamicArray>(nameof(Padding1)); set => WriteStructure(nameof(Padding1), value); }

        [Offset(88UL)]
        public IntPtr KernelCallbackTable { get => ReadHere<IntPtr>(nameof(KernelCallbackTable)); set => WriteHere(nameof(KernelCallbackTable), value); }

        [Offset(88UL)]
        public IntPtr UserSharedInfoPtr { get => ReadHere<IntPtr>(nameof(UserSharedInfoPtr)); set => WriteHere(nameof(UserSharedInfoPtr), value); }

        [Offset(96UL)]
        public uint SystemReserved { get => ReadHere<uint>(nameof(SystemReserved)); set => WriteHere(nameof(SystemReserved), value); }

        [Offset(100UL)]
        public uint AtlThunkSListPtr32 { get => ReadHere<uint>(nameof(AtlThunkSListPtr32)); set => WriteHere(nameof(AtlThunkSListPtr32), value); }

        [Offset(104UL)]
        public IntPtr ApiSetMap { get => ReadHere<IntPtr>(nameof(ApiSetMap)); set => WriteHere(nameof(ApiSetMap), value); }

        [Offset(112UL)]
        public uint TlsExpansionCounter { get => ReadHere<uint>(nameof(TlsExpansionCounter)); set => WriteHere(nameof(TlsExpansionCounter), value); }

        [Offset(116UL)]
        [Length(4)]
        public DynamicArray Padding2 { get => ReadStructure<DynamicArray>(nameof(Padding2)); set => WriteStructure(nameof(Padding2), value); }

        [Offset(120UL)]
        public IntPtr TlsBitmap { get => ReadHere<IntPtr>(nameof(TlsBitmap)); set => WriteHere(nameof(TlsBitmap), value); }

        [Offset(128UL)]
        [Length(2)]
        public DynamicArray TlsBitmapBits { get => ReadStructure<DynamicArray>(nameof(TlsBitmapBits)); set => WriteStructure(nameof(TlsBitmapBits), value); }

        [Offset(136UL)]
        public IntPtr ReadOnlySharedMemoryBase { get => ReadHere<IntPtr>(nameof(ReadOnlySharedMemoryBase)); set => WriteHere(nameof(ReadOnlySharedMemoryBase), value); }

        [Offset(144UL)]
        public IntPtr SharedData { get => ReadHere<IntPtr>(nameof(SharedData)); set => WriteHere(nameof(SharedData), value); }

        [Offset(152UL)]
        public IntPtr ReadOnlyStaticServerData { get => ReadHere<IntPtr>(nameof(ReadOnlyStaticServerData)); set => WriteHere(nameof(ReadOnlyStaticServerData), value); }

        [Offset(160UL)]
        public IntPtr AnsiCodePageData { get => ReadHere<IntPtr>(nameof(AnsiCodePageData)); set => WriteHere(nameof(AnsiCodePageData), value); }

        [Offset(168UL)]
        public IntPtr OemCodePageData { get => ReadHere<IntPtr>(nameof(OemCodePageData)); set => WriteHere(nameof(OemCodePageData), value); }

        [Offset(176UL)]
        public IntPtr UnicodeCaseTableData { get => ReadHere<IntPtr>(nameof(UnicodeCaseTableData)); set => WriteHere(nameof(UnicodeCaseTableData), value); }

        [Offset(184UL)]
        public uint NumberOfProcessors { get => ReadHere<uint>(nameof(NumberOfProcessors)); set => WriteHere(nameof(NumberOfProcessors), value); }

        [Offset(188UL)]
        public uint NtGlobalFlag { get => ReadHere<uint>(nameof(NtGlobalFlag)); set => WriteHere(nameof(NtGlobalFlag), value); }

        [Offset(192UL)]
        public LargeInteger CriticalSectionTimeout { get => ReadStructure<LargeInteger>(nameof(CriticalSectionTimeout)); set => WriteStructure(nameof(CriticalSectionTimeout), value); }

        [Offset(200UL)]
        public ulong HeapSegmentReserve { get => ReadHere<ulong>(nameof(HeapSegmentReserve)); set => WriteHere(nameof(HeapSegmentReserve), value); }

        [Offset(208UL)]
        public ulong HeapSegmentCommit { get => ReadHere<ulong>(nameof(HeapSegmentCommit)); set => WriteHere(nameof(HeapSegmentCommit), value); }

        [Offset(216UL)]
        public ulong HeapDeCommitTotalFreeThreshold { get => ReadHere<ulong>(nameof(HeapDeCommitTotalFreeThreshold)); set => WriteHere(nameof(HeapDeCommitTotalFreeThreshold), value); }

        [Offset(224UL)]
        public ulong HeapDeCommitFreeBlockThreshold { get => ReadHere<ulong>(nameof(HeapDeCommitFreeBlockThreshold)); set => WriteHere(nameof(HeapDeCommitFreeBlockThreshold), value); }

        [Offset(232UL)]
        public uint NumberOfHeaps { get => ReadHere<uint>(nameof(NumberOfHeaps)); set => WriteHere(nameof(NumberOfHeaps), value); }

        [Offset(236UL)]
        public uint MaximumNumberOfHeaps { get => ReadHere<uint>(nameof(MaximumNumberOfHeaps)); set => WriteHere(nameof(MaximumNumberOfHeaps), value); }

        [Offset(240UL)]
        public IntPtr ProcessHeaps { get => ReadHere<IntPtr>(nameof(ProcessHeaps)); set => WriteHere(nameof(ProcessHeaps), value); }

        [Offset(248UL)]
        public IntPtr GdiSharedHandleTable { get => ReadHere<IntPtr>(nameof(GdiSharedHandleTable)); set => WriteHere(nameof(GdiSharedHandleTable), value); }

        [Offset(256UL)]
        public IntPtr ProcessStarterHelper { get => ReadHere<IntPtr>(nameof(ProcessStarterHelper)); set => WriteHere(nameof(ProcessStarterHelper), value); }

        [Offset(264UL)]
        public uint GdiDCAttributeList { get => ReadHere<uint>(nameof(GdiDCAttributeList)); set => WriteHere(nameof(GdiDCAttributeList), value); }

        [Offset(268UL)]
        [Length(4)]
        public DynamicArray Padding3 { get => ReadStructure<DynamicArray>(nameof(Padding3)); set => WriteStructure(nameof(Padding3), value); }

        [Offset(272UL)]
        public IntPtr LoaderLock { get => ReadHere<IntPtr>(nameof(LoaderLock)); set => WriteHere(nameof(LoaderLock), value); }

        [Offset(280UL)]
        public uint OSMajorVersion { get => ReadHere<uint>(nameof(OSMajorVersion)); set => WriteHere(nameof(OSMajorVersion), value); }

        [Offset(284UL)]
        public uint OSMinorVersion { get => ReadHere<uint>(nameof(OSMinorVersion)); set => WriteHere(nameof(OSMinorVersion), value); }

        [Offset(288UL)]
        public ushort OSBuildNumber { get => ReadHere<ushort>(nameof(OSBuildNumber)); set => WriteHere(nameof(OSBuildNumber), value); }

        [Offset(290UL)]
        public ushort OSCSDVersion { get => ReadHere<ushort>(nameof(OSCSDVersion)); set => WriteHere(nameof(OSCSDVersion), value); }

        [Offset(292UL)]
        public uint OSPlatformId { get => ReadHere<uint>(nameof(OSPlatformId)); set => WriteHere(nameof(OSPlatformId), value); }

        [Offset(296UL)]
        public uint ImageSubsystem { get => ReadHere<uint>(nameof(ImageSubsystem)); set => WriteHere(nameof(ImageSubsystem), value); }

        [Offset(300UL)]
        public uint ImageSubsystemMajorVersion { get => ReadHere<uint>(nameof(ImageSubsystemMajorVersion)); set => WriteHere(nameof(ImageSubsystemMajorVersion), value); }

        [Offset(304UL)]
        public uint ImageSubsystemMinorVersion { get => ReadHere<uint>(nameof(ImageSubsystemMinorVersion)); set => WriteHere(nameof(ImageSubsystemMinorVersion), value); }

        [Offset(308UL)]
        [Length(4)]
        public DynamicArray Padding4 { get => ReadStructure<DynamicArray>(nameof(Padding4)); set => WriteStructure(nameof(Padding4), value); }

        [Offset(312UL)]
        public ulong ActiveProcessAffinityMask { get => ReadHere<ulong>(nameof(ActiveProcessAffinityMask)); set => WriteHere(nameof(ActiveProcessAffinityMask), value); }

        [Offset(320UL)]
        [Length(60)]
        public DynamicArray GdiHandleBuffer { get => ReadStructure<DynamicArray>(nameof(GdiHandleBuffer)); set => WriteStructure(nameof(GdiHandleBuffer), value); }

        [Offset(560UL)]
        public IntPtr PostProcessInitRoutine { get => ReadHere<IntPtr>(nameof(PostProcessInitRoutine)); set => WriteHere(nameof(PostProcessInitRoutine), value); }

        [Offset(568UL)]
        public IntPtr TlsExpansionBitmap { get => ReadHere<IntPtr>(nameof(TlsExpansionBitmap)); set => WriteHere(nameof(TlsExpansionBitmap), value); }

        [Offset(576UL)]
        [Length(32)]
        public DynamicArray TlsExpansionBitmapBits { get => ReadStructure<DynamicArray>(nameof(TlsExpansionBitmapBits)); set => WriteStructure(nameof(TlsExpansionBitmapBits), value); }

        [Offset(704UL)]
        public uint SessionId { get => ReadHere<uint>(nameof(SessionId)); set => WriteHere(nameof(SessionId), value); }

        [Offset(708UL)]
        [Length(4)]
        public DynamicArray Padding5 { get => ReadStructure<DynamicArray>(nameof(Padding5)); set => WriteStructure(nameof(Padding5), value); }

        [Offset(712UL)]
        public UlargeInteger AppCompatFlags { get => ReadStructure<UlargeInteger>(nameof(AppCompatFlags)); set => WriteStructure(nameof(AppCompatFlags), value); }

        [Offset(720UL)]
        public UlargeInteger AppCompatFlagsUser { get => ReadStructure<UlargeInteger>(nameof(AppCompatFlagsUser)); set => WriteStructure(nameof(AppCompatFlagsUser), value); }

        [Offset(728UL)]
        public IntPtr pShimData { get => ReadHere<IntPtr>(nameof(pShimData)); set => WriteHere(nameof(pShimData), value); }

        [Offset(736UL)]
        public IntPtr AppCompatInfo { get => ReadHere<IntPtr>(nameof(AppCompatInfo)); set => WriteHere(nameof(AppCompatInfo), value); }

        [Offset(744UL)]
        public UnicodeString CSDVersion { get => ReadStructure<UnicodeString>(nameof(CSDVersion)); set => WriteStructure(nameof(CSDVersion), value); }

        [Offset(760UL)]
        public IntPtr ActivationContextData { get => ReadHere<IntPtr>(nameof(ActivationContextData)); set => WriteHere(nameof(ActivationContextData), value); }

        [Offset(768UL)]
        public IntPtr ProcessAssemblyStorageMap { get => ReadHere<IntPtr>(nameof(ProcessAssemblyStorageMap)); set => WriteHere(nameof(ProcessAssemblyStorageMap), value); }

        [Offset(776UL)]
        public IntPtr SystemDefaultActivationContextData { get => ReadHere<IntPtr>(nameof(SystemDefaultActivationContextData)); set => WriteHere(nameof(SystemDefaultActivationContextData), value); }

        [Offset(784UL)]
        public IntPtr SystemAssemblyStorageMap { get => ReadHere<IntPtr>(nameof(SystemAssemblyStorageMap)); set => WriteHere(nameof(SystemAssemblyStorageMap), value); }

        [Offset(792UL)]
        public ulong MinimumStackCommit { get => ReadHere<ulong>(nameof(MinimumStackCommit)); set => WriteHere(nameof(MinimumStackCommit), value); }

        [Offset(800UL)]
        [Length(2)]
        public DynamicArray SparePointers { get => ReadStructure<DynamicArray>(nameof(SparePointers)); set => WriteStructure(nameof(SparePointers), value); }

        [Offset(816UL)]
        public IntPtr PatchLoaderData { get => ReadHere<IntPtr>(nameof(PatchLoaderData)); set => WriteHere(nameof(PatchLoaderData), value); }

        [Offset(824UL)]
        public IntPtr ChpeV2ProcessInfo { get => ReadHere<IntPtr>(nameof(ChpeV2ProcessInfo)); set => WriteHere(nameof(ChpeV2ProcessInfo), value); }

        [Offset(832UL)]
        public uint AppModelFeatureState { get => ReadHere<uint>(nameof(AppModelFeatureState)); set => WriteHere(nameof(AppModelFeatureState), value); }

        [Offset(836UL)]
        [Length(2)]
        public DynamicArray SpareUlongs { get => ReadStructure<DynamicArray>(nameof(SpareUlongs)); set => WriteStructure(nameof(SpareUlongs), value); }

        [Offset(844UL)]
        public ushort ActiveCodePage { get => ReadHere<ushort>(nameof(ActiveCodePage)); set => WriteHere(nameof(ActiveCodePage), value); }

        [Offset(846UL)]
        public ushort OemCodePage { get => ReadHere<ushort>(nameof(OemCodePage)); set => WriteHere(nameof(OemCodePage), value); }

        [Offset(848UL)]
        public ushort UseCaseMapping { get => ReadHere<ushort>(nameof(UseCaseMapping)); set => WriteHere(nameof(UseCaseMapping), value); }

        [Offset(850UL)]
        public ushort UnusedNlsField { get => ReadHere<ushort>(nameof(UnusedNlsField)); set => WriteHere(nameof(UnusedNlsField), value); }

        [Offset(856UL)]
        public IntPtr WerRegistrationData { get => ReadHere<IntPtr>(nameof(WerRegistrationData)); set => WriteHere(nameof(WerRegistrationData), value); }

        [Offset(864UL)]
        public IntPtr WerShipAssertPtr { get => ReadHere<IntPtr>(nameof(WerShipAssertPtr)); set => WriteHere(nameof(WerShipAssertPtr), value); }

        [Offset(872UL)]
        public IntPtr EcCodeBitMap { get => ReadHere<IntPtr>(nameof(EcCodeBitMap)); set => WriteHere(nameof(EcCodeBitMap), value); }

        [Offset(880UL)]
        public IntPtr pImageHeaderHash { get => ReadHere<IntPtr>(nameof(pImageHeaderHash)); set => WriteHere(nameof(pImageHeaderHash), value); }

        [Offset(888UL)]
        public uint TracingFlags { get => ReadHere<uint>(nameof(TracingFlags)); set => WriteHere(nameof(TracingFlags), value); }

        [Offset(888UL)]
        public uint HeapTracingEnabled { get => ReadHere<uint>(nameof(HeapTracingEnabled)); set => WriteHere(nameof(HeapTracingEnabled), value); }

        [Offset(888UL)]
        public uint CritSecTracingEnabled { get => ReadHere<uint>(nameof(CritSecTracingEnabled)); set => WriteHere(nameof(CritSecTracingEnabled), value); }

        [Offset(888UL)]
        public uint LibLoaderTracingEnabled { get => ReadHere<uint>(nameof(LibLoaderTracingEnabled)); set => WriteHere(nameof(LibLoaderTracingEnabled), value); }

        [Offset(888UL)]
        public uint SpareTracingBits { get => ReadHere<uint>(nameof(SpareTracingBits)); set => WriteHere(nameof(SpareTracingBits), value); }

        [Offset(892UL)]
        [Length(4)]
        public DynamicArray Padding6 { get => ReadStructure<DynamicArray>(nameof(Padding6)); set => WriteStructure(nameof(Padding6), value); }

        [Offset(896UL)]
        public ulong CsrServerReadOnlySharedMemoryBase { get => ReadHere<ulong>(nameof(CsrServerReadOnlySharedMemoryBase)); set => WriteHere(nameof(CsrServerReadOnlySharedMemoryBase), value); }

        [Offset(904UL)]
        public ulong TppWorkerpListLock { get => ReadHere<ulong>(nameof(TppWorkerpListLock)); set => WriteHere(nameof(TppWorkerpListLock), value); }

        [Offset(912UL)]
        public ListEntry TppWorkerpList { get => ReadStructure<ListEntry>(nameof(TppWorkerpList)); set => WriteStructure(nameof(TppWorkerpList), value); }

        [Offset(928UL)]
        [Length(128)]
        public DynamicArray WaitOnAddressHashTable { get => ReadStructure<DynamicArray>(nameof(WaitOnAddressHashTable)); set => WriteStructure(nameof(WaitOnAddressHashTable), value); }

        [Offset(1952UL)]
        public IntPtr TelemetryCoverageHeader { get => ReadHere<IntPtr>(nameof(TelemetryCoverageHeader)); set => WriteHere(nameof(TelemetryCoverageHeader), value); }

        [Offset(1960UL)]
        public uint CloudFileFlags { get => ReadHere<uint>(nameof(CloudFileFlags)); set => WriteHere(nameof(CloudFileFlags), value); }

        [Offset(1964UL)]
        public uint CloudFileDiagFlags { get => ReadHere<uint>(nameof(CloudFileDiagFlags)); set => WriteHere(nameof(CloudFileDiagFlags), value); }

        [Offset(1968UL)]
        public sbyte PlaceholderCompatibilityMode { get => ReadHere<sbyte>(nameof(PlaceholderCompatibilityMode)); set => WriteHere(nameof(PlaceholderCompatibilityMode), value); }

        [Offset(1969UL)]
        [Length(7)]
        public DynamicArray PlaceholderCompatibilityModeReserved { get => ReadStructure<DynamicArray>(nameof(PlaceholderCompatibilityModeReserved)); set => WriteStructure(nameof(PlaceholderCompatibilityModeReserved), value); }

        [Offset(1976UL)]
        public IntPtr LeapSecondData { get => ReadHere<IntPtr>(nameof(LeapSecondData)); set => WriteHere(nameof(LeapSecondData), value); }

        [Offset(1984UL)]
        public uint LeapSecondFlags { get => ReadHere<uint>(nameof(LeapSecondFlags)); set => WriteHere(nameof(LeapSecondFlags), value); }

        [Offset(1984UL)]
        public uint SixtySecondEnabled { get => ReadHere<uint>(nameof(SixtySecondEnabled)); set => WriteHere(nameof(SixtySecondEnabled), value); }

        [Offset(1984UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(1988UL)]
        public uint NtGlobalFlag2 { get => ReadHere<uint>(nameof(NtGlobalFlag2)); set => WriteHere(nameof(NtGlobalFlag2), value); }

        [Offset(1992UL)]
        public ulong ExtendedFeatureDisableMask { get => ReadHere<ulong>(nameof(ExtendedFeatureDisableMask)); set => WriteHere(nameof(ExtendedFeatureDisableMask), value); }

        public Peb(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Peb>();
        }
    }
}