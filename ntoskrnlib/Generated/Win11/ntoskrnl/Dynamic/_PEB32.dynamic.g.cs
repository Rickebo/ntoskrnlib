using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEB32")]
    public sealed class _PEB32 : DynamicStructure
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
        public uint Mutant { get; }
        public uint ImageBaseAddress { get; }
        public uint Ldr { get; }
        public uint ProcessParameters { get; }
        public uint SubSystemData { get; }
        public uint ProcessHeap { get; }
        public uint FastPebLock { get; }
        public uint AtlThunkSListPtr { get; }
        public uint IFEOKey { get; }
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
        public uint KernelCallbackTable { get; }
        public uint UserSharedInfoPtr { get; }
        public uint SystemReserved { get; }
        public uint AtlThunkSListPtr32 { get; }
        public uint ApiSetMap { get; }
        public uint TlsExpansionCounter { get; }
        public uint TlsBitmap { get; }
        public uint[] TlsBitmapBits { get; }
        public uint ReadOnlySharedMemoryBase { get; }
        public uint SharedData { get; }
        public uint ReadOnlyStaticServerData { get; }
        public uint AnsiCodePageData { get; }
        public uint OemCodePageData { get; }
        public uint UnicodeCaseTableData { get; }
        public uint NumberOfProcessors { get; }
        public uint NtGlobalFlag { get; }
        public _LARGE_INTEGER CriticalSectionTimeout { get; }
        public uint HeapSegmentReserve { get; }
        public uint HeapSegmentCommit { get; }
        public uint HeapDeCommitTotalFreeThreshold { get; }
        public uint HeapDeCommitFreeBlockThreshold { get; }
        public uint NumberOfHeaps { get; }
        public uint MaximumNumberOfHeaps { get; }
        public uint ProcessHeaps { get; }
        public uint GdiSharedHandleTable { get; }
        public uint ProcessStarterHelper { get; }
        public uint GdiDCAttributeList { get; }
        public uint LoaderLock { get; }
        public uint OSMajorVersion { get; }
        public uint OSMinorVersion { get; }
        public ushort OSBuildNumber { get; }
        public ushort OSCSDVersion { get; }
        public uint OSPlatformId { get; }
        public uint ImageSubsystem { get; }
        public uint ImageSubsystemMajorVersion { get; }
        public uint ImageSubsystemMinorVersion { get; }
        public uint ActiveProcessAffinityMask { get; }
        public uint[] GdiHandleBuffer { get; }
        public uint PostProcessInitRoutine { get; }
        public uint TlsExpansionBitmap { get; }
        public uint[] TlsExpansionBitmapBits { get; }
        public uint SessionId { get; }
        public _ULARGE_INTEGER AppCompatFlags { get; }
        public _ULARGE_INTEGER AppCompatFlagsUser { get; }
        public uint pShimData { get; }
        public uint AppCompatInfo { get; }
        public _STRING32 CSDVersion { get; }
        public uint ActivationContextData { get; }
        public uint ProcessAssemblyStorageMap { get; }
        public uint SystemDefaultActivationContextData { get; }
        public uint SystemAssemblyStorageMap { get; }
        public uint MinimumStackCommit { get; }
        public uint[] SparePointers { get; }
        public uint PatchLoaderData { get; }
        public uint ChpeV2ProcessInfo { get; }
        public uint AppModelFeatureState { get; }
        public uint[] SpareUlongs { get; }
        public ushort ActiveCodePage { get; }
        public ushort OemCodePage { get; }
        public ushort UseCaseMapping { get; }
        public ushort UnusedNlsField { get; }
        public uint WerRegistrationData { get; }
        public uint WerShipAssertPtr { get; }
        public uint Spare { get; }
        public uint pImageHeaderHash { get; }
        public uint TracingFlags { get; }
        public uint HeapTracingEnabled { get; }
        public uint CritSecTracingEnabled { get; }
        public uint LibLoaderTracingEnabled { get; }
        public uint SpareTracingBits { get; }
        public ulong CsrServerReadOnlySharedMemoryBase { get; }
        public uint TppWorkerpListLock { get; }
        public LIST_ENTRY32 TppWorkerpList { get; }
        public uint[] WaitOnAddressHashTable { get; }
        public uint TelemetryCoverageHeader { get; }
        public uint CloudFileFlags { get; }
        public uint CloudFileDiagFlags { get; }
        public sbyte PlaceholderCompatibilityMode { get; }
        public sbyte[] PlaceholderCompatibilityModeReserved { get; }
        public uint LeapSecondData { get; }
        public uint LeapSecondFlags { get; }
        public uint SixtySecondEnabled { get; }
        public uint Reserved { get; }
        public uint NtGlobalFlag2 { get; }
        public ulong ExtendedFeatureDisableMask { get; }

        public _PEB32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEB32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEB32.InheritedAddressSpace),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEB32.ReadImageFileExecOptions),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_PEB32.BeingDebugged),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PEB32.BitField),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB32.ImageUsesLargePages),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB32.IsProtectedProcess),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB32.IsImageDynamicallyRelocated),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB32.SkipPatchingUser32Forwarders),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB32.IsPackagedProcess),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB32.IsAppContainer),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB32.IsProtectedProcessLight),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB32.IsLongPathAwareProcess),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PEB32.Mutant),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PEB32.ImageBaseAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEB32.Ldr),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PEB32.ProcessParameters),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PEB32.SubSystemData),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PEB32.ProcessHeap),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PEB32.FastPebLock),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_PEB32.AtlThunkSListPtr),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PEB32.IFEOKey),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_PEB32.CrossProcessFlags),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEB32.ProcessInJob),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEB32.ProcessInitializing),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEB32.ProcessUsingVEH),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEB32.ProcessUsingVCH),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEB32.ProcessUsingFTH),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEB32.ProcessPreviouslyThrottled),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEB32.ProcessCurrentlyThrottled),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEB32.ProcessImagesHotPatched),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEB32.ReservedBits0),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEB32.KernelCallbackTable),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_PEB32.UserSharedInfoPtr),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_PEB32.SystemReserved),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PEB32.AtlThunkSListPtr32),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_PEB32.ApiSetMap),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PEB32.TlsExpansionCounter),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_PEB32.TlsBitmap),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PEB32.TlsBitmapBits),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_PEB32.ReadOnlySharedMemoryBase),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_PEB32.SharedData),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PEB32.ReadOnlyStaticServerData),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_PEB32.AnsiCodePageData),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PEB32.OemCodePageData),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_PEB32.UnicodeCaseTableData),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PEB32.NumberOfProcessors),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_PEB32.NtGlobalFlag),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PEB32.CriticalSectionTimeout),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_PEB32.HeapSegmentReserve),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_PEB32.HeapSegmentCommit),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_PEB32.HeapDeCommitTotalFreeThreshold),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_PEB32.HeapDeCommitFreeBlockThreshold),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_PEB32.NumberOfHeaps),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_PEB32.MaximumNumberOfHeaps),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_PEB32.ProcessHeaps),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_PEB32.GdiSharedHandleTable),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_PEB32.ProcessStarterHelper),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_PEB32.GdiDCAttributeList),
                    new ulong[]
                    {
                        156UL
                    }
                },
                {
                    nameof(_PEB32.LoaderLock),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_PEB32.OSMajorVersion),
                    new ulong[]
                    {
                        164UL
                    }
                },
                {
                    nameof(_PEB32.OSMinorVersion),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_PEB32.OSBuildNumber),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_PEB32.OSCSDVersion),
                    new ulong[]
                    {
                        174UL
                    }
                },
                {
                    nameof(_PEB32.OSPlatformId),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_PEB32.ImageSubsystem),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_PEB32.ImageSubsystemMajorVersion),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_PEB32.ImageSubsystemMinorVersion),
                    new ulong[]
                    {
                        188UL
                    }
                },
                {
                    nameof(_PEB32.ActiveProcessAffinityMask),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_PEB32.GdiHandleBuffer),
                    new ulong[]
                    {
                        196UL
                    }
                },
                {
                    nameof(_PEB32.PostProcessInitRoutine),
                    new ulong[]
                    {
                        332UL
                    }
                },
                {
                    nameof(_PEB32.TlsExpansionBitmap),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_PEB32.TlsExpansionBitmapBits),
                    new ulong[]
                    {
                        340UL
                    }
                },
                {
                    nameof(_PEB32.SessionId),
                    new ulong[]
                    {
                        468UL
                    }
                },
                {
                    nameof(_PEB32.AppCompatFlags),
                    new ulong[]
                    {
                        472UL
                    }
                },
                {
                    nameof(_PEB32.AppCompatFlagsUser),
                    new ulong[]
                    {
                        480UL
                    }
                },
                {
                    nameof(_PEB32.pShimData),
                    new ulong[]
                    {
                        488UL
                    }
                },
                {
                    nameof(_PEB32.AppCompatInfo),
                    new ulong[]
                    {
                        492UL
                    }
                },
                {
                    nameof(_PEB32.CSDVersion),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_PEB32.ActivationContextData),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_PEB32.ProcessAssemblyStorageMap),
                    new ulong[]
                    {
                        508UL
                    }
                },
                {
                    nameof(_PEB32.SystemDefaultActivationContextData),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_PEB32.SystemAssemblyStorageMap),
                    new ulong[]
                    {
                        516UL
                    }
                },
                {
                    nameof(_PEB32.MinimumStackCommit),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_PEB32.SparePointers),
                    new ulong[]
                    {
                        524UL
                    }
                },
                {
                    nameof(_PEB32.PatchLoaderData),
                    new ulong[]
                    {
                        532UL
                    }
                },
                {
                    nameof(_PEB32.ChpeV2ProcessInfo),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_PEB32.AppModelFeatureState),
                    new ulong[]
                    {
                        540UL
                    }
                },
                {
                    nameof(_PEB32.SpareUlongs),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(_PEB32.ActiveCodePage),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(_PEB32.OemCodePage),
                    new ulong[]
                    {
                        554UL
                    }
                },
                {
                    nameof(_PEB32.UseCaseMapping),
                    new ulong[]
                    {
                        556UL
                    }
                },
                {
                    nameof(_PEB32.UnusedNlsField),
                    new ulong[]
                    {
                        558UL
                    }
                },
                {
                    nameof(_PEB32.WerRegistrationData),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_PEB32.WerShipAssertPtr),
                    new ulong[]
                    {
                        564UL
                    }
                },
                {
                    nameof(_PEB32.Spare),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_PEB32.pImageHeaderHash),
                    new ulong[]
                    {
                        572UL
                    }
                },
                {
                    nameof(_PEB32.TracingFlags),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_PEB32.HeapTracingEnabled),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_PEB32.CritSecTracingEnabled),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_PEB32.LibLoaderTracingEnabled),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_PEB32.SpareTracingBits),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_PEB32.CsrServerReadOnlySharedMemoryBase),
                    new ulong[]
                    {
                        584UL
                    }
                },
                {
                    nameof(_PEB32.TppWorkerpListLock),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_PEB32.TppWorkerpList),
                    new ulong[]
                    {
                        596UL
                    }
                },
                {
                    nameof(_PEB32.WaitOnAddressHashTable),
                    new ulong[]
                    {
                        604UL
                    }
                },
                {
                    nameof(_PEB32.TelemetryCoverageHeader),
                    new ulong[]
                    {
                        1116UL
                    }
                },
                {
                    nameof(_PEB32.CloudFileFlags),
                    new ulong[]
                    {
                        1120UL
                    }
                },
                {
                    nameof(_PEB32.CloudFileDiagFlags),
                    new ulong[]
                    {
                        1124UL
                    }
                },
                {
                    nameof(_PEB32.PlaceholderCompatibilityMode),
                    new ulong[]
                    {
                        1128UL
                    }
                },
                {
                    nameof(_PEB32.PlaceholderCompatibilityModeReserved),
                    new ulong[]
                    {
                        1129UL
                    }
                },
                {
                    nameof(_PEB32.LeapSecondData),
                    new ulong[]
                    {
                        1136UL
                    }
                },
                {
                    nameof(_PEB32.LeapSecondFlags),
                    new ulong[]
                    {
                        1140UL
                    }
                },
                {
                    nameof(_PEB32.SixtySecondEnabled),
                    new ulong[]
                    {
                        1140UL
                    }
                },
                {
                    nameof(_PEB32.Reserved),
                    new ulong[]
                    {
                        1140UL
                    }
                },
                {
                    nameof(_PEB32.NtGlobalFlag2),
                    new ulong[]
                    {
                        1144UL
                    }
                },
                {
                    nameof(_PEB32.ExtendedFeatureDisableMask),
                    new ulong[]
                    {
                        1152UL
                    }
                }
            };
            Register<_PEB32>((mem, ptr) => new _PEB32(mem, ptr), offsets);
        }
    }
}