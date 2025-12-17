using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEB64")]
    public sealed class _PEB64 : DynamicStructure
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
        public ulong Mutant { get; }
        public ulong ImageBaseAddress { get; }
        public ulong Ldr { get; }
        public ulong ProcessParameters { get; }
        public ulong SubSystemData { get; }
        public ulong ProcessHeap { get; }
        public ulong FastPebLock { get; }
        public ulong AtlThunkSListPtr { get; }
        public ulong IFEOKey { get; }
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
        public ulong KernelCallbackTable { get; }
        public ulong UserSharedInfoPtr { get; }
        public uint SystemReserved { get; }
        public uint AtlThunkSListPtr32 { get; }
        public ulong ApiSetMap { get; }
        public uint TlsExpansionCounter { get; }
        public byte[] Padding2 { get; }
        public ulong TlsBitmap { get; }
        public uint[] TlsBitmapBits { get; }
        public ulong ReadOnlySharedMemoryBase { get; }
        public ulong SharedData { get; }
        public ulong ReadOnlyStaticServerData { get; }
        public ulong AnsiCodePageData { get; }
        public ulong OemCodePageData { get; }
        public ulong UnicodeCaseTableData { get; }
        public uint NumberOfProcessors { get; }
        public uint NtGlobalFlag { get; }
        public _LARGE_INTEGER CriticalSectionTimeout { get; }
        public ulong HeapSegmentReserve { get; }
        public ulong HeapSegmentCommit { get; }
        public ulong HeapDeCommitTotalFreeThreshold { get; }
        public ulong HeapDeCommitFreeBlockThreshold { get; }
        public uint NumberOfHeaps { get; }
        public uint MaximumNumberOfHeaps { get; }
        public ulong ProcessHeaps { get; }
        public ulong GdiSharedHandleTable { get; }
        public ulong ProcessStarterHelper { get; }
        public uint GdiDCAttributeList { get; }
        public byte[] Padding3 { get; }
        public ulong LoaderLock { get; }
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
        public ulong PostProcessInitRoutine { get; }
        public ulong TlsExpansionBitmap { get; }
        public uint[] TlsExpansionBitmapBits { get; }
        public uint SessionId { get; }
        public byte[] Padding5 { get; }
        public _ULARGE_INTEGER AppCompatFlags { get; }
        public _ULARGE_INTEGER AppCompatFlagsUser { get; }
        public ulong pShimData { get; }
        public ulong AppCompatInfo { get; }
        public _STRING64 CSDVersion { get; }
        public ulong ActivationContextData { get; }
        public ulong ProcessAssemblyStorageMap { get; }
        public ulong SystemDefaultActivationContextData { get; }
        public ulong SystemAssemblyStorageMap { get; }
        public ulong MinimumStackCommit { get; }
        public ulong[] SparePointers { get; }
        public ulong PatchLoaderData { get; }
        public ulong ChpeV2ProcessInfo { get; }
        public uint AppModelFeatureState { get; }
        public uint[] SpareUlongs { get; }
        public ushort ActiveCodePage { get; }
        public ushort OemCodePage { get; }
        public ushort UseCaseMapping { get; }
        public ushort UnusedNlsField { get; }
        public ulong WerRegistrationData { get; }
        public ulong WerShipAssertPtr { get; }
        public ulong EcCodeBitMap { get; }
        public ulong pImageHeaderHash { get; }
        public uint TracingFlags { get; }
        public uint HeapTracingEnabled { get; }
        public uint CritSecTracingEnabled { get; }
        public uint LibLoaderTracingEnabled { get; }
        public uint SpareTracingBits { get; }
        public byte[] Padding6 { get; }
        public ulong CsrServerReadOnlySharedMemoryBase { get; }
        public ulong TppWorkerpListLock { get; }
        public LIST_ENTRY64 TppWorkerpList { get; }
        public ulong[] WaitOnAddressHashTable { get; }
        public ulong TelemetryCoverageHeader { get; }
        public uint CloudFileFlags { get; }
        public uint CloudFileDiagFlags { get; }
        public sbyte PlaceholderCompatibilityMode { get; }
        public sbyte[] PlaceholderCompatibilityModeReserved { get; }
        public ulong LeapSecondData { get; }
        public uint LeapSecondFlags { get; }
        public uint SixtySecondEnabled { get; }
        public uint Reserved { get; }
        public uint NtGlobalFlag2 { get; }
        public ulong ExtendedFeatureDisableMask { get; }

        public _PEB64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEB64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEB64.InheritedAddressSpace),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEB64.ReadImageFileExecOptions),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_PEB64.BeingDebugged),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PEB64.BitField),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB64.ImageUsesLargePages),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB64.IsProtectedProcess),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB64.IsImageDynamicallyRelocated),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB64.SkipPatchingUser32Forwarders),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB64.IsPackagedProcess),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB64.IsAppContainer),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB64.IsProtectedProcessLight),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB64.IsLongPathAwareProcess),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB64.Padding0),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PEB64.Mutant),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEB64.ImageBaseAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PEB64.Ldr),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PEB64.ProcessParameters),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PEB64.SubSystemData),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEB64.ProcessHeap),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PEB64.FastPebLock),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PEB64.AtlThunkSListPtr),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PEB64.IFEOKey),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PEB64.CrossProcessFlags),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB64.ProcessInJob),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB64.ProcessInitializing),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB64.ProcessUsingVEH),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB64.ProcessUsingVCH),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB64.ProcessUsingFTH),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB64.ProcessPreviouslyThrottled),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB64.ProcessCurrentlyThrottled),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB64.ProcessImagesHotPatched),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB64.ReservedBits0),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB64.Padding1),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_PEB64.KernelCallbackTable),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PEB64.UserSharedInfoPtr),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PEB64.SystemReserved),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PEB64.AtlThunkSListPtr32),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_PEB64.ApiSetMap),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PEB64.TlsExpansionCounter),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_PEB64.Padding2),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_PEB64.TlsBitmap),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_PEB64.TlsBitmapBits),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_PEB64.ReadOnlySharedMemoryBase),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_PEB64.SharedData),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_PEB64.ReadOnlyStaticServerData),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_PEB64.AnsiCodePageData),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_PEB64.OemCodePageData),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_PEB64.UnicodeCaseTableData),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_PEB64.NumberOfProcessors),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_PEB64.NtGlobalFlag),
                    new ulong[]
                    {
                        188UL
                    }
                },
                {
                    nameof(_PEB64.CriticalSectionTimeout),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_PEB64.HeapSegmentReserve),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_PEB64.HeapSegmentCommit),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_PEB64.HeapDeCommitTotalFreeThreshold),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_PEB64.HeapDeCommitFreeBlockThreshold),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_PEB64.NumberOfHeaps),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_PEB64.MaximumNumberOfHeaps),
                    new ulong[]
                    {
                        236UL
                    }
                },
                {
                    nameof(_PEB64.ProcessHeaps),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_PEB64.GdiSharedHandleTable),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_PEB64.ProcessStarterHelper),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_PEB64.GdiDCAttributeList),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_PEB64.Padding3),
                    new ulong[]
                    {
                        268UL
                    }
                },
                {
                    nameof(_PEB64.LoaderLock),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_PEB64.OSMajorVersion),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_PEB64.OSMinorVersion),
                    new ulong[]
                    {
                        284UL
                    }
                },
                {
                    nameof(_PEB64.OSBuildNumber),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_PEB64.OSCSDVersion),
                    new ulong[]
                    {
                        290UL
                    }
                },
                {
                    nameof(_PEB64.OSPlatformId),
                    new ulong[]
                    {
                        292UL
                    }
                },
                {
                    nameof(_PEB64.ImageSubsystem),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_PEB64.ImageSubsystemMajorVersion),
                    new ulong[]
                    {
                        300UL
                    }
                },
                {
                    nameof(_PEB64.ImageSubsystemMinorVersion),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_PEB64.Padding4),
                    new ulong[]
                    {
                        308UL
                    }
                },
                {
                    nameof(_PEB64.ActiveProcessAffinityMask),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_PEB64.GdiHandleBuffer),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_PEB64.PostProcessInitRoutine),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_PEB64.TlsExpansionBitmap),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_PEB64.TlsExpansionBitmapBits),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_PEB64.SessionId),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_PEB64.Padding5),
                    new ulong[]
                    {
                        708UL
                    }
                },
                {
                    nameof(_PEB64.AppCompatFlags),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_PEB64.AppCompatFlagsUser),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_PEB64.pShimData),
                    new ulong[]
                    {
                        728UL
                    }
                },
                {
                    nameof(_PEB64.AppCompatInfo),
                    new ulong[]
                    {
                        736UL
                    }
                },
                {
                    nameof(_PEB64.CSDVersion),
                    new ulong[]
                    {
                        744UL
                    }
                },
                {
                    nameof(_PEB64.ActivationContextData),
                    new ulong[]
                    {
                        760UL
                    }
                },
                {
                    nameof(_PEB64.ProcessAssemblyStorageMap),
                    new ulong[]
                    {
                        768UL
                    }
                },
                {
                    nameof(_PEB64.SystemDefaultActivationContextData),
                    new ulong[]
                    {
                        776UL
                    }
                },
                {
                    nameof(_PEB64.SystemAssemblyStorageMap),
                    new ulong[]
                    {
                        784UL
                    }
                },
                {
                    nameof(_PEB64.MinimumStackCommit),
                    new ulong[]
                    {
                        792UL
                    }
                },
                {
                    nameof(_PEB64.SparePointers),
                    new ulong[]
                    {
                        800UL
                    }
                },
                {
                    nameof(_PEB64.PatchLoaderData),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_PEB64.ChpeV2ProcessInfo),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_PEB64.AppModelFeatureState),
                    new ulong[]
                    {
                        832UL
                    }
                },
                {
                    nameof(_PEB64.SpareUlongs),
                    new ulong[]
                    {
                        836UL
                    }
                },
                {
                    nameof(_PEB64.ActiveCodePage),
                    new ulong[]
                    {
                        844UL
                    }
                },
                {
                    nameof(_PEB64.OemCodePage),
                    new ulong[]
                    {
                        846UL
                    }
                },
                {
                    nameof(_PEB64.UseCaseMapping),
                    new ulong[]
                    {
                        848UL
                    }
                },
                {
                    nameof(_PEB64.UnusedNlsField),
                    new ulong[]
                    {
                        850UL
                    }
                },
                {
                    nameof(_PEB64.WerRegistrationData),
                    new ulong[]
                    {
                        856UL
                    }
                },
                {
                    nameof(_PEB64.WerShipAssertPtr),
                    new ulong[]
                    {
                        864UL
                    }
                },
                {
                    nameof(_PEB64.EcCodeBitMap),
                    new ulong[]
                    {
                        872UL
                    }
                },
                {
                    nameof(_PEB64.pImageHeaderHash),
                    new ulong[]
                    {
                        880UL
                    }
                },
                {
                    nameof(_PEB64.TracingFlags),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_PEB64.HeapTracingEnabled),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_PEB64.CritSecTracingEnabled),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_PEB64.LibLoaderTracingEnabled),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_PEB64.SpareTracingBits),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_PEB64.Padding6),
                    new ulong[]
                    {
                        892UL
                    }
                },
                {
                    nameof(_PEB64.CsrServerReadOnlySharedMemoryBase),
                    new ulong[]
                    {
                        896UL
                    }
                },
                {
                    nameof(_PEB64.TppWorkerpListLock),
                    new ulong[]
                    {
                        904UL
                    }
                },
                {
                    nameof(_PEB64.TppWorkerpList),
                    new ulong[]
                    {
                        912UL
                    }
                },
                {
                    nameof(_PEB64.WaitOnAddressHashTable),
                    new ulong[]
                    {
                        928UL
                    }
                },
                {
                    nameof(_PEB64.TelemetryCoverageHeader),
                    new ulong[]
                    {
                        1952UL
                    }
                },
                {
                    nameof(_PEB64.CloudFileFlags),
                    new ulong[]
                    {
                        1960UL
                    }
                },
                {
                    nameof(_PEB64.CloudFileDiagFlags),
                    new ulong[]
                    {
                        1964UL
                    }
                },
                {
                    nameof(_PEB64.PlaceholderCompatibilityMode),
                    new ulong[]
                    {
                        1968UL
                    }
                },
                {
                    nameof(_PEB64.PlaceholderCompatibilityModeReserved),
                    new ulong[]
                    {
                        1969UL
                    }
                },
                {
                    nameof(_PEB64.LeapSecondData),
                    new ulong[]
                    {
                        1976UL
                    }
                },
                {
                    nameof(_PEB64.LeapSecondFlags),
                    new ulong[]
                    {
                        1984UL
                    }
                },
                {
                    nameof(_PEB64.SixtySecondEnabled),
                    new ulong[]
                    {
                        1984UL
                    }
                },
                {
                    nameof(_PEB64.Reserved),
                    new ulong[]
                    {
                        1984UL
                    }
                },
                {
                    nameof(_PEB64.NtGlobalFlag2),
                    new ulong[]
                    {
                        1988UL
                    }
                },
                {
                    nameof(_PEB64.ExtendedFeatureDisableMask),
                    new ulong[]
                    {
                        1992UL
                    }
                }
            };
            Register<_PEB64>((mem, ptr) => new _PEB64(mem, ptr), offsets);
        }
    }
}