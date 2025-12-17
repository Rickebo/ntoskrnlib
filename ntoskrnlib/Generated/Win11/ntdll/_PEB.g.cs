#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 2000)]
    public partial struct _PEB
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
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding0;
        [FieldOffset(8)]
        public IntPtr Mutant;
        [FieldOffset(16)]
        public IntPtr ImageBaseAddress;
        [FieldOffset(24)]
        public IntPtr Ldr;
        [FieldOffset(32)]
        public IntPtr ProcessParameters;
        [FieldOffset(40)]
        public IntPtr SubSystemData;
        [FieldOffset(48)]
        public IntPtr ProcessHeap;
        [FieldOffset(56)]
        public IntPtr FastPebLock;
        [FieldOffset(64)]
        public IntPtr AtlThunkSListPtr;
        [FieldOffset(72)]
        public IntPtr IFEOKey;
        [FieldOffset(80)]
        public uint CrossProcessFlags;
        [FieldOffset(80)]
        public uint ProcessInJob;
        [FieldOffset(80)]
        public uint ProcessInitializing;
        [FieldOffset(80)]
        public uint ProcessUsingVEH;
        [FieldOffset(80)]
        public uint ProcessUsingVCH;
        [FieldOffset(80)]
        public uint ProcessUsingFTH;
        [FieldOffset(80)]
        public uint ProcessPreviouslyThrottled;
        [FieldOffset(80)]
        public uint ProcessCurrentlyThrottled;
        [FieldOffset(80)]
        public uint ProcessImagesHotPatched;
        [FieldOffset(80)]
        public uint ReservedBits0;
        [FieldOffset(84)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding1;
        [FieldOffset(88)]
        public IntPtr KernelCallbackTable;
        [FieldOffset(88)]
        public IntPtr UserSharedInfoPtr;
        [FieldOffset(96)]
        public uint SystemReserved;
        [FieldOffset(100)]
        public uint AtlThunkSListPtr32;
        [FieldOffset(104)]
        public IntPtr ApiSetMap;
        [FieldOffset(112)]
        public uint TlsExpansionCounter;
        [FieldOffset(116)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding2;
        [FieldOffset(120)]
        public IntPtr TlsBitmap;
        [FieldOffset(128)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] TlsBitmapBits;
        [FieldOffset(136)]
        public IntPtr ReadOnlySharedMemoryBase;
        [FieldOffset(144)]
        public IntPtr SharedData;
        [FieldOffset(152)]
        public IntPtr ReadOnlyStaticServerData;
        [FieldOffset(160)]
        public IntPtr AnsiCodePageData;
        [FieldOffset(168)]
        public IntPtr OemCodePageData;
        [FieldOffset(176)]
        public IntPtr UnicodeCaseTableData;
        [FieldOffset(184)]
        public uint NumberOfProcessors;
        [FieldOffset(188)]
        public uint NtGlobalFlag;
        [FieldOffset(192)]
        public _LARGE_INTEGER CriticalSectionTimeout;
        [FieldOffset(200)]
        public ulong HeapSegmentReserve;
        [FieldOffset(208)]
        public ulong HeapSegmentCommit;
        [FieldOffset(216)]
        public ulong HeapDeCommitTotalFreeThreshold;
        [FieldOffset(224)]
        public ulong HeapDeCommitFreeBlockThreshold;
        [FieldOffset(232)]
        public uint NumberOfHeaps;
        [FieldOffset(236)]
        public uint MaximumNumberOfHeaps;
        [FieldOffset(240)]
        public IntPtr ProcessHeaps;
        [FieldOffset(248)]
        public IntPtr GdiSharedHandleTable;
        [FieldOffset(256)]
        public IntPtr ProcessStarterHelper;
        [FieldOffset(264)]
        public uint GdiDCAttributeList;
        [FieldOffset(268)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding3;
        [FieldOffset(272)]
        public IntPtr LoaderLock;
        [FieldOffset(280)]
        public uint OSMajorVersion;
        [FieldOffset(284)]
        public uint OSMinorVersion;
        [FieldOffset(288)]
        public ushort OSBuildNumber;
        [FieldOffset(290)]
        public ushort OSCSDVersion;
        [FieldOffset(292)]
        public uint OSPlatformId;
        [FieldOffset(296)]
        public uint ImageSubsystem;
        [FieldOffset(300)]
        public uint ImageSubsystemMajorVersion;
        [FieldOffset(304)]
        public uint ImageSubsystemMinorVersion;
        [FieldOffset(308)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding4;
        [FieldOffset(312)]
        public ulong ActiveProcessAffinityMask;
        [FieldOffset(320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public uint[] GdiHandleBuffer;
        [FieldOffset(560)]
        public IntPtr PostProcessInitRoutine;
        [FieldOffset(568)]
        public IntPtr TlsExpansionBitmap;
        [FieldOffset(576)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public uint[] TlsExpansionBitmapBits;
        [FieldOffset(704)]
        public uint SessionId;
        [FieldOffset(708)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding5;
        [FieldOffset(712)]
        public _ULARGE_INTEGER AppCompatFlags;
        [FieldOffset(720)]
        public _ULARGE_INTEGER AppCompatFlagsUser;
        [FieldOffset(728)]
        public IntPtr pShimData;
        [FieldOffset(736)]
        public IntPtr AppCompatInfo;
        [FieldOffset(744)]
        public _UNICODE_STRING CSDVersion;
        [FieldOffset(760)]
        public IntPtr ActivationContextData;
        [FieldOffset(768)]
        public IntPtr ProcessAssemblyStorageMap;
        [FieldOffset(776)]
        public IntPtr SystemDefaultActivationContextData;
        [FieldOffset(784)]
        public IntPtr SystemAssemblyStorageMap;
        [FieldOffset(792)]
        public ulong MinimumStackCommit;
        [FieldOffset(800)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] SparePointers;
        [FieldOffset(816)]
        public IntPtr PatchLoaderData;
        [FieldOffset(824)]
        public IntPtr ChpeV2ProcessInfo;
        [FieldOffset(832)]
        public uint AppModelFeatureState;
        [FieldOffset(836)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] SpareUlongs;
        [FieldOffset(844)]
        public ushort ActiveCodePage;
        [FieldOffset(846)]
        public ushort OemCodePage;
        [FieldOffset(848)]
        public ushort UseCaseMapping;
        [FieldOffset(850)]
        public ushort UnusedNlsField;
        [FieldOffset(856)]
        public IntPtr WerRegistrationData;
        [FieldOffset(864)]
        public IntPtr WerShipAssertPtr;
        [FieldOffset(872)]
        public IntPtr EcCodeBitMap;
        [FieldOffset(880)]
        public IntPtr pImageHeaderHash;
        [FieldOffset(888)]
        public uint TracingFlags;
        [FieldOffset(888)]
        public uint HeapTracingEnabled;
        [FieldOffset(888)]
        public uint CritSecTracingEnabled;
        [FieldOffset(888)]
        public uint LibLoaderTracingEnabled;
        [FieldOffset(888)]
        public uint SpareTracingBits;
        [FieldOffset(892)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding6;
        [FieldOffset(896)]
        public ulong CsrServerReadOnlySharedMemoryBase;
        [FieldOffset(904)]
        public ulong TppWorkerpListLock;
        [FieldOffset(912)]
        public _LIST_ENTRY TppWorkerpList;
        [FieldOffset(928)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public IntPtr[] WaitOnAddressHashTable;
        [FieldOffset(1952)]
        public IntPtr TelemetryCoverageHeader;
        [FieldOffset(1960)]
        public uint CloudFileFlags;
        [FieldOffset(1964)]
        public uint CloudFileDiagFlags;
        [FieldOffset(1968)]
        public sbyte PlaceholderCompatibilityMode;
        [FieldOffset(1969)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public sbyte[] PlaceholderCompatibilityModeReserved;
        [FieldOffset(1976)]
        public IntPtr LeapSecondData;
        [FieldOffset(1984)]
        public uint LeapSecondFlags;
        [FieldOffset(1984)]
        public uint SixtySecondEnabled;
        [FieldOffset(1984)]
        public uint Reserved;
        [FieldOffset(1988)]
        public uint NtGlobalFlag2;
        [FieldOffset(1992)]
        public ulong ExtendedFeatureDisableMask;
    }
}