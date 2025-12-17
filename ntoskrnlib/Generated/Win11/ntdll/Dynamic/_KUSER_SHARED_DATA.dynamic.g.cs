using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KUSER_SHARED_DATA")]
    public sealed class _KUSER_SHARED_DATA : DynamicStructure
    {
        public uint TickCountLowDeprecated { get; }
        public uint TickCountMultiplier { get; }
        public _KSYSTEM_TIME InterruptTime { get; }
        public _KSYSTEM_TIME SystemTime { get; }
        public _KSYSTEM_TIME TimeZoneBias { get; }
        public ushort ImageNumberLow { get; }
        public ushort ImageNumberHigh { get; }
        public short[] NtSystemRoot { get; }
        public uint MaxStackTraceDepth { get; }
        public uint CryptoExponent { get; }
        public uint TimeZoneId { get; }
        public uint LargePageMinimum { get; }
        public uint AitSamplingValue { get; }
        public uint AppCompatFlag { get; }
        public ulong RNGSeedVersion { get; }
        public uint GlobalValidationRunlevel { get; }
        public int TimeZoneBiasStamp { get; }
        public uint NtBuildNumber { get; }
        public uint NtProductType { get; }
        public byte ProductTypeIsValid { get; }
        public byte[] Reserved0 { get; }
        public ushort NativeProcessorArchitecture { get; }
        public uint NtMajorVersion { get; }
        public uint NtMinorVersion { get; }
        public byte[] ProcessorFeatures { get; }
        public uint Reserved1 { get; }
        public uint Reserved3 { get; }
        public uint TimeSlip { get; }
        public uint AlternativeArchitecture { get; }
        public uint BootId { get; }
        public _LARGE_INTEGER SystemExpirationDate { get; }
        public uint SuiteMask { get; }
        public byte KdDebuggerEnabled { get; }
        public byte MitigationPolicies { get; }
        public byte NXSupportPolicy { get; }
        public byte SEHValidationPolicy { get; }
        public byte CurDirDevicesSkippedForDlls { get; }
        public byte Reserved { get; }
        public ushort CyclesPerYield { get; }
        public uint ActiveConsoleId { get; }
        public uint DismountCount { get; }
        public uint ComPlusPackage { get; }
        public uint LastSystemRITEventTickCount { get; }
        public uint NumberOfPhysicalPages { get; }
        public byte SafeBootMode { get; }
        public byte VirtualizationFlags { get; }
        public byte[] Reserved12 { get; }
        public uint SharedDataFlags { get; }
        public uint DbgErrorPortPresent { get; }
        public uint DbgElevationEnabled { get; }
        public uint DbgVirtEnabled { get; }
        public uint DbgInstallerDetectEnabled { get; }
        public uint DbgLkgEnabled { get; }
        public uint DbgDynProcessorEnabled { get; }
        public uint DbgConsoleBrokerEnabled { get; }
        public uint DbgSecureBootEnabled { get; }
        public uint DbgMultiSessionSku { get; }
        public uint DbgMultiUsersInSessionSku { get; }
        public uint DbgStateSeparationEnabled { get; }
        public uint SpareBits { get; }
        public uint[] DataFlagsPad { get; }
        public ulong TestRetInstruction { get; }
        public long QpcFrequency { get; }
        public uint SystemCall { get; }
        public uint Reserved2 { get; }
        public ulong FullNumberOfPhysicalPages { get; }
        public ulong[] SystemCallPad { get; }
        public _KSYSTEM_TIME TickCount { get; }
        public ulong TickCountQuad { get; }
        public uint[] ReservedTickCountOverlay { get; }
        public uint[] TickCountPad { get; }
        public uint Cookie { get; }
        public uint[] CookiePad { get; }
        public long ConsoleSessionForegroundProcessId { get; }
        public ulong TimeUpdateLock { get; }
        public ulong BaselineSystemTimeQpc { get; }
        public ulong BaselineInterruptTimeQpc { get; }
        public ulong QpcSystemTimeIncrement { get; }
        public ulong QpcInterruptTimeIncrement { get; }
        public byte QpcSystemTimeIncrementShift { get; }
        public byte QpcInterruptTimeIncrementShift { get; }
        public ushort UnparkedProcessorCount { get; }
        public uint[] EnclaveFeatureMask { get; }
        public uint TelemetryCoverageRound { get; }
        public ushort[] UserModeGlobalLogger { get; }
        public uint ImageFileExecutionOptions { get; }
        public uint LangGenerationCount { get; }
        public ulong Reserved4 { get; }
        public ulong InterruptTimeBias { get; }
        public ulong QpcBias { get; }
        public uint ActiveProcessorCount { get; }
        public byte ActiveGroupCount { get; }
        public byte Reserved9 { get; }
        public ushort QpcData { get; }
        public byte QpcBypassEnabled { get; }
        public byte QpcReserved { get; }
        public _LARGE_INTEGER TimeZoneBiasEffectiveStart { get; }
        public _LARGE_INTEGER TimeZoneBiasEffectiveEnd { get; }
        public _XSTATE_CONFIGURATION XState { get; }
        public _KSYSTEM_TIME FeatureConfigurationChangeStamp { get; }
        public uint Spare { get; }
        public ulong UserPointerAuthMask { get; }
        public uint[] Reserved10 { get; }

        public _KUSER_SHARED_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KUSER_SHARED_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KUSER_SHARED_DATA.TickCountLowDeprecated),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.TickCountMultiplier),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.InterruptTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.SystemTime),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.TimeZoneBias),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.ImageNumberLow),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.ImageNumberHigh),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.NtSystemRoot),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.MaxStackTraceDepth),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.CryptoExponent),
                    new ulong[]
                    {
                        572UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.TimeZoneId),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.LargePageMinimum),
                    new ulong[]
                    {
                        580UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.AitSamplingValue),
                    new ulong[]
                    {
                        584UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.AppCompatFlag),
                    new ulong[]
                    {
                        588UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.RNGSeedVersion),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.GlobalValidationRunlevel),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.TimeZoneBiasStamp),
                    new ulong[]
                    {
                        604UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.NtBuildNumber),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.NtProductType),
                    new ulong[]
                    {
                        612UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.ProductTypeIsValid),
                    new ulong[]
                    {
                        616UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.Reserved0),
                    new ulong[]
                    {
                        617UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.NativeProcessorArchitecture),
                    new ulong[]
                    {
                        618UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.NtMajorVersion),
                    new ulong[]
                    {
                        620UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.NtMinorVersion),
                    new ulong[]
                    {
                        624UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.ProcessorFeatures),
                    new ulong[]
                    {
                        628UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.Reserved1),
                    new ulong[]
                    {
                        692UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.Reserved3),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.TimeSlip),
                    new ulong[]
                    {
                        700UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.AlternativeArchitecture),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.BootId),
                    new ulong[]
                    {
                        708UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.SystemExpirationDate),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.SuiteMask),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.KdDebuggerEnabled),
                    new ulong[]
                    {
                        724UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.MitigationPolicies),
                    new ulong[]
                    {
                        725UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.NXSupportPolicy),
                    new ulong[]
                    {
                        725UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.SEHValidationPolicy),
                    new ulong[]
                    {
                        725UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.CurDirDevicesSkippedForDlls),
                    new ulong[]
                    {
                        725UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.Reserved),
                    new ulong[]
                    {
                        725UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.CyclesPerYield),
                    new ulong[]
                    {
                        726UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.ActiveConsoleId),
                    new ulong[]
                    {
                        728UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.DismountCount),
                    new ulong[]
                    {
                        732UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.ComPlusPackage),
                    new ulong[]
                    {
                        736UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.LastSystemRITEventTickCount),
                    new ulong[]
                    {
                        740UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.NumberOfPhysicalPages),
                    new ulong[]
                    {
                        744UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.SafeBootMode),
                    new ulong[]
                    {
                        748UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.VirtualizationFlags),
                    new ulong[]
                    {
                        749UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.Reserved12),
                    new ulong[]
                    {
                        750UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.SharedDataFlags),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.DbgErrorPortPresent),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.DbgElevationEnabled),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.DbgVirtEnabled),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.DbgInstallerDetectEnabled),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.DbgLkgEnabled),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.DbgDynProcessorEnabled),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.DbgConsoleBrokerEnabled),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.DbgSecureBootEnabled),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.DbgMultiSessionSku),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.DbgMultiUsersInSessionSku),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.DbgStateSeparationEnabled),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.SpareBits),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.DataFlagsPad),
                    new ulong[]
                    {
                        756UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.TestRetInstruction),
                    new ulong[]
                    {
                        760UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.QpcFrequency),
                    new ulong[]
                    {
                        768UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.SystemCall),
                    new ulong[]
                    {
                        776UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.Reserved2),
                    new ulong[]
                    {
                        780UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.FullNumberOfPhysicalPages),
                    new ulong[]
                    {
                        784UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.SystemCallPad),
                    new ulong[]
                    {
                        792UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.TickCount),
                    new ulong[]
                    {
                        800UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.TickCountQuad),
                    new ulong[]
                    {
                        800UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.ReservedTickCountOverlay),
                    new ulong[]
                    {
                        800UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.TickCountPad),
                    new ulong[]
                    {
                        812UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.Cookie),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.CookiePad),
                    new ulong[]
                    {
                        820UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.ConsoleSessionForegroundProcessId),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.TimeUpdateLock),
                    new ulong[]
                    {
                        832UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.BaselineSystemTimeQpc),
                    new ulong[]
                    {
                        840UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.BaselineInterruptTimeQpc),
                    new ulong[]
                    {
                        848UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.QpcSystemTimeIncrement),
                    new ulong[]
                    {
                        856UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.QpcInterruptTimeIncrement),
                    new ulong[]
                    {
                        864UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.QpcSystemTimeIncrementShift),
                    new ulong[]
                    {
                        872UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.QpcInterruptTimeIncrementShift),
                    new ulong[]
                    {
                        873UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.UnparkedProcessorCount),
                    new ulong[]
                    {
                        874UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.EnclaveFeatureMask),
                    new ulong[]
                    {
                        876UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.TelemetryCoverageRound),
                    new ulong[]
                    {
                        892UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.UserModeGlobalLogger),
                    new ulong[]
                    {
                        896UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.ImageFileExecutionOptions),
                    new ulong[]
                    {
                        928UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.LangGenerationCount),
                    new ulong[]
                    {
                        932UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.Reserved4),
                    new ulong[]
                    {
                        936UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.InterruptTimeBias),
                    new ulong[]
                    {
                        944UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.QpcBias),
                    new ulong[]
                    {
                        952UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.ActiveProcessorCount),
                    new ulong[]
                    {
                        960UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.ActiveGroupCount),
                    new ulong[]
                    {
                        964UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.Reserved9),
                    new ulong[]
                    {
                        965UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.QpcData),
                    new ulong[]
                    {
                        966UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.QpcBypassEnabled),
                    new ulong[]
                    {
                        966UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.QpcReserved),
                    new ulong[]
                    {
                        967UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.TimeZoneBiasEffectiveStart),
                    new ulong[]
                    {
                        968UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.TimeZoneBiasEffectiveEnd),
                    new ulong[]
                    {
                        976UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.XState),
                    new ulong[]
                    {
                        984UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.FeatureConfigurationChangeStamp),
                    new ulong[]
                    {
                        1824UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.Spare),
                    new ulong[]
                    {
                        1836UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.UserPointerAuthMask),
                    new ulong[]
                    {
                        1840UL
                    }
                },
                {
                    nameof(_KUSER_SHARED_DATA.Reserved10),
                    new ulong[]
                    {
                        1848UL
                    }
                }
            };
            Register<_KUSER_SHARED_DATA>((mem, ptr) => new _KUSER_SHARED_DATA(mem, ptr), offsets);
        }
    }
}