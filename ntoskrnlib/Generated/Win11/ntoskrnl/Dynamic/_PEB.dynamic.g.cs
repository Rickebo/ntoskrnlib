using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEB")]
    public sealed class _PEB : DynamicStructure
    {
        public byte InheritedAddressSpace { get; }
        public byte ReadImageFileExecOptions { get; }
        public byte BeingDebugged { get; }
        public byte BitField { get; }
        public byte ImageUsesLargePages { get; }
        public byte IsProtectedProcess { get; }
        public byte IsImageDynamicallyRelocated { get; }
        public byte SkipPatchingUser32Forwarders { get; }
        public byte IsPackagedProcess { get; }
        public byte IsAppContainer { get; }
        public byte IsProtectedProcessLight { get; }
        public byte IsLongPathAwareProcess { get; }
        public byte[] Padding0 { get; }
        public IntPtr Mutant { get; }
        public IntPtr ImageBaseAddress { get; }
        public IntPtr Ldr { get; }
        public IntPtr ProcessParameters { get; }
        public IntPtr SubSystemData { get; }
        public IntPtr ProcessHeap { get; }
        public IntPtr FastPebLock { get; }
        public IntPtr AtlThunkSListPtr { get; }
        public IntPtr IFEOKey { get; }
        public uint CrossProcessFlags { get; }
        public uint ProcessInJob { get; }
        public uint ProcessInitializing { get; }
        public uint ProcessUsingVEH { get; }
        public uint ProcessUsingVCH { get; }
        public uint ProcessUsingFTH { get; }
        public uint ProcessPreviouslyThrottled { get; }
        public uint ProcessCurrentlyThrottled { get; }
        public uint ProcessImagesHotPatched { get; }
        public uint ReservedBits0 { get; }
        public byte[] Padding1 { get; }
        public IntPtr KernelCallbackTable { get; }
        public IntPtr UserSharedInfoPtr { get; }
        public uint SystemReserved { get; }
        public uint AtlThunkSListPtr32 { get; }
        public IntPtr ApiSetMap { get; }
        public uint TlsExpansionCounter { get; }
        public byte[] Padding2 { get; }
        public IntPtr TlsBitmap { get; }
        public uint[] TlsBitmapBits { get; }
        public IntPtr ReadOnlySharedMemoryBase { get; }
        public IntPtr SharedData { get; }
        public IntPtr ReadOnlyStaticServerData { get; }
        public IntPtr AnsiCodePageData { get; }
        public IntPtr OemCodePageData { get; }
        public IntPtr UnicodeCaseTableData { get; }
        public uint NumberOfProcessors { get; }
        public uint NtGlobalFlag { get; }
        public _LARGE_INTEGER CriticalSectionTimeout { get; }
        public ulong HeapSegmentReserve { get; }
        public ulong HeapSegmentCommit { get; }
        public ulong HeapDeCommitTotalFreeThreshold { get; }
        public ulong HeapDeCommitFreeBlockThreshold { get; }
        public uint NumberOfHeaps { get; }
        public uint MaximumNumberOfHeaps { get; }
        public IntPtr ProcessHeaps { get; }
        public IntPtr GdiSharedHandleTable { get; }
        public IntPtr ProcessStarterHelper { get; }
        public uint GdiDCAttributeList { get; }
        public byte[] Padding3 { get; }
        public IntPtr LoaderLock { get; }
        public uint OSMajorVersion { get; }
        public uint OSMinorVersion { get; }
        public ushort OSBuildNumber { get; }
        public ushort OSCSDVersion { get; }
        public uint OSPlatformId { get; }
        public uint ImageSubsystem { get; }
        public uint ImageSubsystemMajorVersion { get; }
        public uint ImageSubsystemMinorVersion { get; }
        public byte[] Padding4 { get; }
        public ulong ActiveProcessAffinityMask { get; }
        public uint[] GdiHandleBuffer { get; }
        public IntPtr PostProcessInitRoutine { get; }
        public IntPtr TlsExpansionBitmap { get; }
        public uint[] TlsExpansionBitmapBits { get; }
        public uint SessionId { get; }
        public byte[] Padding5 { get; }
        public _ULARGE_INTEGER AppCompatFlags { get; }
        public _ULARGE_INTEGER AppCompatFlagsUser { get; }
        public IntPtr pShimData { get; }
        public IntPtr AppCompatInfo { get; }
        public _UNICODE_STRING CSDVersion { get; }
        public IntPtr ActivationContextData { get; }
        public IntPtr ProcessAssemblyStorageMap { get; }
        public IntPtr SystemDefaultActivationContextData { get; }
        public IntPtr SystemAssemblyStorageMap { get; }
        public ulong MinimumStackCommit { get; }
        public byte[] SparePointers { get; }
        public IntPtr PatchLoaderData { get; }
        public IntPtr ChpeV2ProcessInfo { get; }
        public uint AppModelFeatureState { get; }
        public uint[] SpareUlongs { get; }
        public ushort ActiveCodePage { get; }
        public ushort OemCodePage { get; }
        public ushort UseCaseMapping { get; }
        public ushort UnusedNlsField { get; }
        public IntPtr WerRegistrationData { get; }
        public IntPtr WerShipAssertPtr { get; }
        public IntPtr EcCodeBitMap { get; }
        public IntPtr pImageHeaderHash { get; }
        public uint TracingFlags { get; }
        public uint HeapTracingEnabled { get; }
        public uint CritSecTracingEnabled { get; }
        public uint LibLoaderTracingEnabled { get; }
        public uint SpareTracingBits { get; }
        public byte[] Padding6 { get; }
        public ulong CsrServerReadOnlySharedMemoryBase { get; }
        public ulong TppWorkerpListLock { get; }
        public _LIST_ENTRY TppWorkerpList { get; }
        public byte[] WaitOnAddressHashTable { get; }
        public IntPtr TelemetryCoverageHeader { get; }
        public uint CloudFileFlags { get; }
        public uint CloudFileDiagFlags { get; }
        public sbyte PlaceholderCompatibilityMode { get; }
        public sbyte[] PlaceholderCompatibilityModeReserved { get; }
        public IntPtr LeapSecondData { get; }
        public uint LeapSecondFlags { get; }
        public uint SixtySecondEnabled { get; }
        public uint Reserved { get; }
        public uint NtGlobalFlag2 { get; }
        public ulong ExtendedFeatureDisableMask { get; }

        public _PEB(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEB()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEB.InheritedAddressSpace),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEB.ReadImageFileExecOptions),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_PEB.BeingDebugged),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PEB.BitField),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB.ImageUsesLargePages),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB.IsProtectedProcess),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB.IsImageDynamicallyRelocated),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB.SkipPatchingUser32Forwarders),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB.IsPackagedProcess),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB.IsAppContainer),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB.IsProtectedProcessLight),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB.IsLongPathAwareProcess),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB.Padding0),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PEB.Mutant),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEB.ImageBaseAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PEB.Ldr),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PEB.ProcessParameters),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PEB.SubSystemData),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEB.ProcessHeap),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PEB.FastPebLock),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PEB.AtlThunkSListPtr),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PEB.IFEOKey),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PEB.CrossProcessFlags),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB.ProcessInJob),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB.ProcessInitializing),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB.ProcessUsingVEH),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB.ProcessUsingVCH),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB.ProcessUsingFTH),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB.ProcessPreviouslyThrottled),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB.ProcessCurrentlyThrottled),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB.ProcessImagesHotPatched),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB.ReservedBits0),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB.Padding1),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_PEB.KernelCallbackTable),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PEB.UserSharedInfoPtr),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PEB.SystemReserved),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PEB.AtlThunkSListPtr32),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_PEB.ApiSetMap),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PEB.TlsExpansionCounter),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_PEB.Padding2),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_PEB.TlsBitmap),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_PEB.TlsBitmapBits),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_PEB.ReadOnlySharedMemoryBase),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_PEB.SharedData),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_PEB.ReadOnlyStaticServerData),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_PEB.AnsiCodePageData),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_PEB.OemCodePageData),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_PEB.UnicodeCaseTableData),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_PEB.NumberOfProcessors),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_PEB.NtGlobalFlag),
                    new ulong[]
                    {
                        188UL
                    }
                },
                {
                    nameof(_PEB.CriticalSectionTimeout),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_PEB.HeapSegmentReserve),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_PEB.HeapSegmentCommit),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_PEB.HeapDeCommitTotalFreeThreshold),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_PEB.HeapDeCommitFreeBlockThreshold),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_PEB.NumberOfHeaps),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_PEB.MaximumNumberOfHeaps),
                    new ulong[]
                    {
                        236UL
                    }
                },
                {
                    nameof(_PEB.ProcessHeaps),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_PEB.GdiSharedHandleTable),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_PEB.ProcessStarterHelper),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_PEB.GdiDCAttributeList),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_PEB.Padding3),
                    new ulong[]
                    {
                        268UL
                    }
                },
                {
                    nameof(_PEB.LoaderLock),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_PEB.OSMajorVersion),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_PEB.OSMinorVersion),
                    new ulong[]
                    {
                        284UL
                    }
                },
                {
                    nameof(_PEB.OSBuildNumber),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_PEB.OSCSDVersion),
                    new ulong[]
                    {
                        290UL
                    }
                },
                {
                    nameof(_PEB.OSPlatformId),
                    new ulong[]
                    {
                        292UL
                    }
                },
                {
                    nameof(_PEB.ImageSubsystem),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_PEB.ImageSubsystemMajorVersion),
                    new ulong[]
                    {
                        300UL
                    }
                },
                {
                    nameof(_PEB.ImageSubsystemMinorVersion),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_PEB.Padding4),
                    new ulong[]
                    {
                        308UL
                    }
                },
                {
                    nameof(_PEB.ActiveProcessAffinityMask),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_PEB.GdiHandleBuffer),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_PEB.PostProcessInitRoutine),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_PEB.TlsExpansionBitmap),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_PEB.TlsExpansionBitmapBits),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_PEB.SessionId),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_PEB.Padding5),
                    new ulong[]
                    {
                        708UL
                    }
                },
                {
                    nameof(_PEB.AppCompatFlags),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_PEB.AppCompatFlagsUser),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_PEB.pShimData),
                    new ulong[]
                    {
                        728UL
                    }
                },
                {
                    nameof(_PEB.AppCompatInfo),
                    new ulong[]
                    {
                        736UL
                    }
                },
                {
                    nameof(_PEB.CSDVersion),
                    new ulong[]
                    {
                        744UL
                    }
                },
                {
                    nameof(_PEB.ActivationContextData),
                    new ulong[]
                    {
                        760UL
                    }
                },
                {
                    nameof(_PEB.ProcessAssemblyStorageMap),
                    new ulong[]
                    {
                        768UL
                    }
                },
                {
                    nameof(_PEB.SystemDefaultActivationContextData),
                    new ulong[]
                    {
                        776UL
                    }
                },
                {
                    nameof(_PEB.SystemAssemblyStorageMap),
                    new ulong[]
                    {
                        784UL
                    }
                },
                {
                    nameof(_PEB.MinimumStackCommit),
                    new ulong[]
                    {
                        792UL
                    }
                },
                {
                    nameof(_PEB.SparePointers),
                    new ulong[]
                    {
                        800UL
                    }
                },
                {
                    nameof(_PEB.PatchLoaderData),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_PEB.ChpeV2ProcessInfo),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_PEB.AppModelFeatureState),
                    new ulong[]
                    {
                        832UL
                    }
                },
                {
                    nameof(_PEB.SpareUlongs),
                    new ulong[]
                    {
                        836UL
                    }
                },
                {
                    nameof(_PEB.ActiveCodePage),
                    new ulong[]
                    {
                        844UL
                    }
                },
                {
                    nameof(_PEB.OemCodePage),
                    new ulong[]
                    {
                        846UL
                    }
                },
                {
                    nameof(_PEB.UseCaseMapping),
                    new ulong[]
                    {
                        848UL
                    }
                },
                {
                    nameof(_PEB.UnusedNlsField),
                    new ulong[]
                    {
                        850UL
                    }
                },
                {
                    nameof(_PEB.WerRegistrationData),
                    new ulong[]
                    {
                        856UL
                    }
                },
                {
                    nameof(_PEB.WerShipAssertPtr),
                    new ulong[]
                    {
                        864UL
                    }
                },
                {
                    nameof(_PEB.EcCodeBitMap),
                    new ulong[]
                    {
                        872UL
                    }
                },
                {
                    nameof(_PEB.pImageHeaderHash),
                    new ulong[]
                    {
                        880UL
                    }
                },
                {
                    nameof(_PEB.TracingFlags),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_PEB.HeapTracingEnabled),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_PEB.CritSecTracingEnabled),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_PEB.LibLoaderTracingEnabled),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_PEB.SpareTracingBits),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_PEB.Padding6),
                    new ulong[]
                    {
                        892UL
                    }
                },
                {
                    nameof(_PEB.CsrServerReadOnlySharedMemoryBase),
                    new ulong[]
                    {
                        896UL
                    }
                },
                {
                    nameof(_PEB.TppWorkerpListLock),
                    new ulong[]
                    {
                        904UL
                    }
                },
                {
                    nameof(_PEB.TppWorkerpList),
                    new ulong[]
                    {
                        912UL
                    }
                },
                {
                    nameof(_PEB.WaitOnAddressHashTable),
                    new ulong[]
                    {
                        928UL
                    }
                },
                {
                    nameof(_PEB.TelemetryCoverageHeader),
                    new ulong[]
                    {
                        1952UL
                    }
                },
                {
                    nameof(_PEB.CloudFileFlags),
                    new ulong[]
                    {
                        1960UL
                    }
                },
                {
                    nameof(_PEB.CloudFileDiagFlags),
                    new ulong[]
                    {
                        1964UL
                    }
                },
                {
                    nameof(_PEB.PlaceholderCompatibilityMode),
                    new ulong[]
                    {
                        1968UL
                    }
                },
                {
                    nameof(_PEB.PlaceholderCompatibilityModeReserved),
                    new ulong[]
                    {
                        1969UL
                    }
                },
                {
                    nameof(_PEB.LeapSecondData),
                    new ulong[]
                    {
                        1976UL
                    }
                },
                {
                    nameof(_PEB.LeapSecondFlags),
                    new ulong[]
                    {
                        1984UL
                    }
                },
                {
                    nameof(_PEB.SixtySecondEnabled),
                    new ulong[]
                    {
                        1984UL
                    }
                },
                {
                    nameof(_PEB.Reserved),
                    new ulong[]
                    {
                        1984UL
                    }
                },
                {
                    nameof(_PEB.NtGlobalFlag2),
                    new ulong[]
                    {
                        1988UL
                    }
                },
                {
                    nameof(_PEB.ExtendedFeatureDisableMask),
                    new ulong[]
                    {
                        1992UL
                    }
                }
            };
            Register<_PEB>((mem, ptr) => new _PEB(mem, ptr), offsets);
        }
    }
}