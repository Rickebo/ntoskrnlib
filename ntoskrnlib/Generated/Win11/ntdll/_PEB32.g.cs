#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1160)]
    public partial struct _PEB32
    {
        [FieldOffset(0)]
        public byte InheritedAddressSpace;
        [FieldOffset(1)]
        public byte ReadImageFileExecOptions;
        [FieldOffset(2)]
        public byte BeingDebugged;
        [FieldOffset(3)]
        public byte BitField;
        [FieldOffset(3)]
        public byte ImageUsesLargePages;
        [FieldOffset(3)]
        public byte IsProtectedProcess;
        [FieldOffset(3)]
        public byte IsImageDynamicallyRelocated;
        [FieldOffset(3)]
        public byte SkipPatchingUser32Forwarders;
        [FieldOffset(3)]
        public byte IsPackagedProcess;
        [FieldOffset(3)]
        public byte IsAppContainer;
        [FieldOffset(3)]
        public byte IsProtectedProcessLight;
        [FieldOffset(3)]
        public byte IsLongPathAwareProcess;
        [FieldOffset(4)]
        public uint Mutant;
        [FieldOffset(8)]
        public uint ImageBaseAddress;
        [FieldOffset(12)]
        public uint Ldr;
        [FieldOffset(16)]
        public uint ProcessParameters;
        [FieldOffset(20)]
        public uint SubSystemData;
        [FieldOffset(24)]
        public uint ProcessHeap;
        [FieldOffset(28)]
        public uint FastPebLock;
        [FieldOffset(32)]
        public uint AtlThunkSListPtr;
        [FieldOffset(36)]
        public uint IFEOKey;
        [FieldOffset(40)]
        public uint CrossProcessFlags;
        [FieldOffset(40)]
        public uint ProcessInJob;
        [FieldOffset(40)]
        public uint ProcessInitializing;
        [FieldOffset(40)]
        public uint ProcessUsingVEH;
        [FieldOffset(40)]
        public uint ProcessUsingVCH;
        [FieldOffset(40)]
        public uint ProcessUsingFTH;
        [FieldOffset(40)]
        public uint ProcessPreviouslyThrottled;
        [FieldOffset(40)]
        public uint ProcessCurrentlyThrottled;
        [FieldOffset(40)]
        public uint ProcessImagesHotPatched;
        [FieldOffset(40)]
        public uint ReservedBits0;
        [FieldOffset(44)]
        public uint KernelCallbackTable;
        [FieldOffset(44)]
        public uint UserSharedInfoPtr;
        [FieldOffset(48)]
        public uint SystemReserved;
        [FieldOffset(52)]
        public uint AtlThunkSListPtr32;
        [FieldOffset(56)]
        public uint ApiSetMap;
        [FieldOffset(60)]
        public uint TlsExpansionCounter;
        [FieldOffset(64)]
        public uint TlsBitmap;
        [FieldOffset(68)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] TlsBitmapBits;
        [FieldOffset(76)]
        public uint ReadOnlySharedMemoryBase;
        [FieldOffset(80)]
        public uint SharedData;
        [FieldOffset(84)]
        public uint ReadOnlyStaticServerData;
        [FieldOffset(88)]
        public uint AnsiCodePageData;
        [FieldOffset(92)]
        public uint OemCodePageData;
        [FieldOffset(96)]
        public uint UnicodeCaseTableData;
        [FieldOffset(100)]
        public uint NumberOfProcessors;
        [FieldOffset(104)]
        public uint NtGlobalFlag;
        [FieldOffset(112)]
        public _LARGE_INTEGER CriticalSectionTimeout;
        [FieldOffset(120)]
        public uint HeapSegmentReserve;
        [FieldOffset(124)]
        public uint HeapSegmentCommit;
        [FieldOffset(128)]
        public uint HeapDeCommitTotalFreeThreshold;
        [FieldOffset(132)]
        public uint HeapDeCommitFreeBlockThreshold;
        [FieldOffset(136)]
        public uint NumberOfHeaps;
        [FieldOffset(140)]
        public uint MaximumNumberOfHeaps;
        [FieldOffset(144)]
        public uint ProcessHeaps;
        [FieldOffset(148)]
        public uint GdiSharedHandleTable;
        [FieldOffset(152)]
        public uint ProcessStarterHelper;
        [FieldOffset(156)]
        public uint GdiDCAttributeList;
        [FieldOffset(160)]
        public uint LoaderLock;
        [FieldOffset(164)]
        public uint OSMajorVersion;
        [FieldOffset(168)]
        public uint OSMinorVersion;
        [FieldOffset(172)]
        public ushort OSBuildNumber;
        [FieldOffset(174)]
        public ushort OSCSDVersion;
        [FieldOffset(176)]
        public uint OSPlatformId;
        [FieldOffset(180)]
        public uint ImageSubsystem;
        [FieldOffset(184)]
        public uint ImageSubsystemMajorVersion;
        [FieldOffset(188)]
        public uint ImageSubsystemMinorVersion;
        [FieldOffset(192)]
        public uint ActiveProcessAffinityMask;
        [FieldOffset(196)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 34)]
        public uint[] GdiHandleBuffer;
        [FieldOffset(332)]
        public uint PostProcessInitRoutine;
        [FieldOffset(336)]
        public uint TlsExpansionBitmap;
        [FieldOffset(340)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public uint[] TlsExpansionBitmapBits;
        [FieldOffset(468)]
        public uint SessionId;
        [FieldOffset(472)]
        public _ULARGE_INTEGER AppCompatFlags;
        [FieldOffset(480)]
        public _ULARGE_INTEGER AppCompatFlagsUser;
        [FieldOffset(488)]
        public uint pShimData;
        [FieldOffset(492)]
        public uint AppCompatInfo;
        [FieldOffset(496)]
        public _STRING32 CSDVersion;
        [FieldOffset(504)]
        public uint ActivationContextData;
        [FieldOffset(508)]
        public uint ProcessAssemblyStorageMap;
        [FieldOffset(512)]
        public uint SystemDefaultActivationContextData;
        [FieldOffset(516)]
        public uint SystemAssemblyStorageMap;
        [FieldOffset(520)]
        public uint MinimumStackCommit;
        [FieldOffset(524)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] SparePointers;
        [FieldOffset(532)]
        public uint PatchLoaderData;
        [FieldOffset(536)]
        public uint ChpeV2ProcessInfo;
        [FieldOffset(540)]
        public uint AppModelFeatureState;
        [FieldOffset(544)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] SpareUlongs;
        [FieldOffset(552)]
        public ushort ActiveCodePage;
        [FieldOffset(554)]
        public ushort OemCodePage;
        [FieldOffset(556)]
        public ushort UseCaseMapping;
        [FieldOffset(558)]
        public ushort UnusedNlsField;
        [FieldOffset(560)]
        public uint WerRegistrationData;
        [FieldOffset(564)]
        public uint WerShipAssertPtr;
        [FieldOffset(568)]
        public uint Spare;
        [FieldOffset(572)]
        public uint pImageHeaderHash;
        [FieldOffset(576)]
        public uint TracingFlags;
        [FieldOffset(576)]
        public uint HeapTracingEnabled;
        [FieldOffset(576)]
        public uint CritSecTracingEnabled;
        [FieldOffset(576)]
        public uint LibLoaderTracingEnabled;
        [FieldOffset(576)]
        public uint SpareTracingBits;
        [FieldOffset(584)]
        public ulong CsrServerReadOnlySharedMemoryBase;
        [FieldOffset(592)]
        public uint TppWorkerpListLock;
        [FieldOffset(596)]
        public LIST_ENTRY32 TppWorkerpList;
        [FieldOffset(604)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public uint[] WaitOnAddressHashTable;
        [FieldOffset(1116)]
        public uint TelemetryCoverageHeader;
        [FieldOffset(1120)]
        public uint CloudFileFlags;
        [FieldOffset(1124)]
        public uint CloudFileDiagFlags;
        [FieldOffset(1128)]
        public sbyte PlaceholderCompatibilityMode;
        [FieldOffset(1129)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public sbyte[] PlaceholderCompatibilityModeReserved;
        [FieldOffset(1136)]
        public uint LeapSecondData;
        [FieldOffset(1140)]
        public uint LeapSecondFlags;
        [FieldOffset(1140)]
        public uint SixtySecondEnabled;
        [FieldOffset(1140)]
        public uint Reserved;
        [FieldOffset(1144)]
        public uint NtGlobalFlag2;
        [FieldOffset(1152)]
        public ulong ExtendedFeatureDisableMask;
    }
}