#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 2688)]
    public partial struct _KUSER_SHARED_DATA
    {
        [FieldOffset(0)]
        public uint TickCountLowDeprecated;
        [FieldOffset(4)]
        public uint TickCountMultiplier;
        [FieldOffset(8)]
        public _KSYSTEM_TIME InterruptTime;
        [FieldOffset(20)]
        public _KSYSTEM_TIME SystemTime;
        [FieldOffset(32)]
        public _KSYSTEM_TIME TimeZoneBias;
        [FieldOffset(44)]
        public ushort ImageNumberLow;
        [FieldOffset(46)]
        public ushort ImageNumberHigh;
        [FieldOffset(48)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        public short[] NtSystemRoot;
        [FieldOffset(568)]
        public uint MaxStackTraceDepth;
        [FieldOffset(572)]
        public uint CryptoExponent;
        [FieldOffset(576)]
        public uint TimeZoneId;
        [FieldOffset(580)]
        public uint LargePageMinimum;
        [FieldOffset(584)]
        public uint AitSamplingValue;
        [FieldOffset(588)]
        public uint AppCompatFlag;
        [FieldOffset(592)]
        public ulong RNGSeedVersion;
        [FieldOffset(600)]
        public uint GlobalValidationRunlevel;
        [FieldOffset(604)]
        public int TimeZoneBiasStamp;
        [FieldOffset(608)]
        public uint NtBuildNumber;
        [FieldOffset(612)]
        public uint NtProductType;
        [FieldOffset(616)]
        public byte ProductTypeIsValid;
        [FieldOffset(617)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] Reserved0;
        [FieldOffset(618)]
        public ushort NativeProcessorArchitecture;
        [FieldOffset(620)]
        public uint NtMajorVersion;
        [FieldOffset(624)]
        public uint NtMinorVersion;
        [FieldOffset(628)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] ProcessorFeatures;
        [FieldOffset(692)]
        public uint Reserved1;
        [FieldOffset(696)]
        public uint Reserved3;
        [FieldOffset(700)]
        public uint TimeSlip;
        [FieldOffset(704)]
        public uint AlternativeArchitecture;
        [FieldOffset(708)]
        public uint BootId;
        [FieldOffset(712)]
        public _LARGE_INTEGER SystemExpirationDate;
        [FieldOffset(720)]
        public uint SuiteMask;
        [FieldOffset(724)]
        public byte KdDebuggerEnabled;
        [FieldOffset(725)]
        public byte MitigationPolicies;
        [FieldOffset(725)]
        public byte NXSupportPolicy;
        [FieldOffset(725)]
        public byte SEHValidationPolicy;
        [FieldOffset(725)]
        public byte CurDirDevicesSkippedForDlls;
        [FieldOffset(725)]
        public byte Reserved;
        [FieldOffset(726)]
        public ushort CyclesPerYield;
        [FieldOffset(728)]
        public uint ActiveConsoleId;
        [FieldOffset(732)]
        public uint DismountCount;
        [FieldOffset(736)]
        public uint ComPlusPackage;
        [FieldOffset(740)]
        public uint LastSystemRITEventTickCount;
        [FieldOffset(744)]
        public uint NumberOfPhysicalPages;
        [FieldOffset(748)]
        public byte SafeBootMode;
        [FieldOffset(749)]
        public byte VirtualizationFlags;
        [FieldOffset(750)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Reserved12;
        [FieldOffset(752)]
        public uint SharedDataFlags;
        [FieldOffset(752)]
        public uint DbgErrorPortPresent;
        [FieldOffset(752)]
        public uint DbgElevationEnabled;
        [FieldOffset(752)]
        public uint DbgVirtEnabled;
        [FieldOffset(752)]
        public uint DbgInstallerDetectEnabled;
        [FieldOffset(752)]
        public uint DbgLkgEnabled;
        [FieldOffset(752)]
        public uint DbgDynProcessorEnabled;
        [FieldOffset(752)]
        public uint DbgConsoleBrokerEnabled;
        [FieldOffset(752)]
        public uint DbgSecureBootEnabled;
        [FieldOffset(752)]
        public uint DbgMultiSessionSku;
        [FieldOffset(752)]
        public uint DbgMultiUsersInSessionSku;
        [FieldOffset(752)]
        public uint DbgStateSeparationEnabled;
        [FieldOffset(752)]
        public uint SpareBits;
        [FieldOffset(756)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] DataFlagsPad;
        [FieldOffset(760)]
        public ulong TestRetInstruction;
        [FieldOffset(768)]
        public long QpcFrequency;
        [FieldOffset(776)]
        public uint SystemCall;
        [FieldOffset(780)]
        public uint Reserved2;
        [FieldOffset(784)]
        public ulong FullNumberOfPhysicalPages;
        [FieldOffset(792)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ulong[] SystemCallPad;
        [FieldOffset(800)]
        public _KSYSTEM_TIME TickCount;
        [FieldOffset(800)]
        public ulong TickCountQuad;
        [FieldOffset(800)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public uint[] ReservedTickCountOverlay;
        [FieldOffset(812)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] TickCountPad;
        [FieldOffset(816)]
        public uint Cookie;
        [FieldOffset(820)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] CookiePad;
        [FieldOffset(824)]
        public long ConsoleSessionForegroundProcessId;
        [FieldOffset(832)]
        public ulong TimeUpdateLock;
        [FieldOffset(840)]
        public ulong BaselineSystemTimeQpc;
        [FieldOffset(848)]
        public ulong BaselineInterruptTimeQpc;
        [FieldOffset(856)]
        public ulong QpcSystemTimeIncrement;
        [FieldOffset(864)]
        public ulong QpcInterruptTimeIncrement;
        [FieldOffset(872)]
        public byte QpcSystemTimeIncrementShift;
        [FieldOffset(873)]
        public byte QpcInterruptTimeIncrementShift;
        [FieldOffset(874)]
        public ushort UnparkedProcessorCount;
        [FieldOffset(876)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] EnclaveFeatureMask;
        [FieldOffset(892)]
        public uint TelemetryCoverageRound;
        [FieldOffset(896)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] UserModeGlobalLogger;
        [FieldOffset(928)]
        public uint ImageFileExecutionOptions;
        [FieldOffset(932)]
        public uint LangGenerationCount;
        [FieldOffset(936)]
        public ulong Reserved4;
        [FieldOffset(944)]
        public ulong InterruptTimeBias;
        [FieldOffset(952)]
        public ulong QpcBias;
        [FieldOffset(960)]
        public uint ActiveProcessorCount;
        [FieldOffset(964)]
        public byte ActiveGroupCount;
        [FieldOffset(965)]
        public byte Reserved9;
        [FieldOffset(966)]
        public ushort QpcData;
        [FieldOffset(966)]
        public byte QpcBypassEnabled;
        [FieldOffset(967)]
        public byte QpcReserved;
        [FieldOffset(968)]
        public _LARGE_INTEGER TimeZoneBiasEffectiveStart;
        [FieldOffset(976)]
        public _LARGE_INTEGER TimeZoneBiasEffectiveEnd;
        [FieldOffset(984)]
        public _XSTATE_CONFIGURATION XState;
        [FieldOffset(1824)]
        public _KSYSTEM_TIME FeatureConfigurationChangeStamp;
        [FieldOffset(1836)]
        public uint Spare;
        [FieldOffset(1840)]
        public ulong UserPointerAuthMask;
        [FieldOffset(1848)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 210)]
        public uint[] Reserved10;
    }
}