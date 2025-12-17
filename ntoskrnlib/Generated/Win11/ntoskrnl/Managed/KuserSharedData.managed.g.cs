using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KUSER_SHARED_DATA")]
    public sealed class KuserSharedData : DynamicStructure
    {
        [Offset(0UL)]
        public uint TickCountLowDeprecated { get => ReadHere<uint>(nameof(TickCountLowDeprecated)); set => WriteHere(nameof(TickCountLowDeprecated), value); }

        [Offset(4UL)]
        public uint TickCountMultiplier { get => ReadHere<uint>(nameof(TickCountMultiplier)); set => WriteHere(nameof(TickCountMultiplier), value); }

        [Offset(8UL)]
        public KsystemTime InterruptTime { get => ReadStructure<KsystemTime>(nameof(InterruptTime)); set => WriteStructure(nameof(InterruptTime), value); }

        [Offset(20UL)]
        public KsystemTime SystemTime { get => ReadStructure<KsystemTime>(nameof(SystemTime)); set => WriteStructure(nameof(SystemTime), value); }

        [Offset(32UL)]
        public KsystemTime TimeZoneBias { get => ReadStructure<KsystemTime>(nameof(TimeZoneBias)); set => WriteStructure(nameof(TimeZoneBias), value); }

        [Offset(44UL)]
        public ushort ImageNumberLow { get => ReadHere<ushort>(nameof(ImageNumberLow)); set => WriteHere(nameof(ImageNumberLow), value); }

        [Offset(46UL)]
        public ushort ImageNumberHigh { get => ReadHere<ushort>(nameof(ImageNumberHigh)); set => WriteHere(nameof(ImageNumberHigh), value); }

        [Offset(48UL)]
        [Length(260)]
        public DynamicArray NtSystemRoot { get => ReadStructure<DynamicArray>(nameof(NtSystemRoot)); set => WriteStructure(nameof(NtSystemRoot), value); }

        [Offset(568UL)]
        public uint MaxStackTraceDepth { get => ReadHere<uint>(nameof(MaxStackTraceDepth)); set => WriteHere(nameof(MaxStackTraceDepth), value); }

        [Offset(572UL)]
        public uint CryptoExponent { get => ReadHere<uint>(nameof(CryptoExponent)); set => WriteHere(nameof(CryptoExponent), value); }

        [Offset(576UL)]
        public uint TimeZoneId { get => ReadHere<uint>(nameof(TimeZoneId)); set => WriteHere(nameof(TimeZoneId), value); }

        [Offset(580UL)]
        public uint LargePageMinimum { get => ReadHere<uint>(nameof(LargePageMinimum)); set => WriteHere(nameof(LargePageMinimum), value); }

        [Offset(584UL)]
        public uint AitSamplingValue { get => ReadHere<uint>(nameof(AitSamplingValue)); set => WriteHere(nameof(AitSamplingValue), value); }

        [Offset(588UL)]
        public uint AppCompatFlag { get => ReadHere<uint>(nameof(AppCompatFlag)); set => WriteHere(nameof(AppCompatFlag), value); }

        [Offset(592UL)]
        public ulong RNGSeedVersion { get => ReadHere<ulong>(nameof(RNGSeedVersion)); set => WriteHere(nameof(RNGSeedVersion), value); }

        [Offset(600UL)]
        public uint GlobalValidationRunlevel { get => ReadHere<uint>(nameof(GlobalValidationRunlevel)); set => WriteHere(nameof(GlobalValidationRunlevel), value); }

        [Offset(604UL)]
        public int TimeZoneBiasStamp { get => ReadHere<int>(nameof(TimeZoneBiasStamp)); set => WriteHere(nameof(TimeZoneBiasStamp), value); }

        [Offset(608UL)]
        public uint NtBuildNumber { get => ReadHere<uint>(nameof(NtBuildNumber)); set => WriteHere(nameof(NtBuildNumber), value); }

        [Offset(612UL)]
        public uint NtProductType { get => ReadHere<uint>(nameof(NtProductType)); set => WriteHere(nameof(NtProductType), value); }

        [Offset(616UL)]
        public byte ProductTypeIsValid { get => ReadHere<byte>(nameof(ProductTypeIsValid)); set => WriteHere(nameof(ProductTypeIsValid), value); }

        [Offset(617UL)]
        [Length(1)]
        public DynamicArray Reserved0 { get => ReadStructure<DynamicArray>(nameof(Reserved0)); set => WriteStructure(nameof(Reserved0), value); }

        [Offset(618UL)]
        public ushort NativeProcessorArchitecture { get => ReadHere<ushort>(nameof(NativeProcessorArchitecture)); set => WriteHere(nameof(NativeProcessorArchitecture), value); }

        [Offset(620UL)]
        public uint NtMajorVersion { get => ReadHere<uint>(nameof(NtMajorVersion)); set => WriteHere(nameof(NtMajorVersion), value); }

        [Offset(624UL)]
        public uint NtMinorVersion { get => ReadHere<uint>(nameof(NtMinorVersion)); set => WriteHere(nameof(NtMinorVersion), value); }

        [Offset(628UL)]
        [Length(64)]
        public DynamicArray ProcessorFeatures { get => ReadStructure<DynamicArray>(nameof(ProcessorFeatures)); set => WriteStructure(nameof(ProcessorFeatures), value); }

        [Offset(692UL)]
        public uint Reserved1 { get => ReadHere<uint>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(696UL)]
        public uint Reserved3 { get => ReadHere<uint>(nameof(Reserved3)); set => WriteHere(nameof(Reserved3), value); }

        [Offset(700UL)]
        public uint TimeSlip { get => ReadHere<uint>(nameof(TimeSlip)); set => WriteHere(nameof(TimeSlip), value); }

        [Offset(704UL)]
        public uint AlternativeArchitecture { get => ReadHere<uint>(nameof(AlternativeArchitecture)); set => WriteHere(nameof(AlternativeArchitecture), value); }

        [Offset(708UL)]
        public uint BootId { get => ReadHere<uint>(nameof(BootId)); set => WriteHere(nameof(BootId), value); }

        [Offset(712UL)]
        public LargeInteger SystemExpirationDate { get => ReadStructure<LargeInteger>(nameof(SystemExpirationDate)); set => WriteStructure(nameof(SystemExpirationDate), value); }

        [Offset(720UL)]
        public uint SuiteMask { get => ReadHere<uint>(nameof(SuiteMask)); set => WriteHere(nameof(SuiteMask), value); }

        [Offset(724UL)]
        public byte KdDebuggerEnabled { get => ReadHere<byte>(nameof(KdDebuggerEnabled)); set => WriteHere(nameof(KdDebuggerEnabled), value); }

        [Offset(725UL)]
        public byte MitigationPolicies { get => ReadHere<byte>(nameof(MitigationPolicies)); set => WriteHere(nameof(MitigationPolicies), value); }

        [Offset(725UL)]
        public byte NXSupportPolicy { get => ReadHere<byte>(nameof(NXSupportPolicy)); set => WriteHere(nameof(NXSupportPolicy), value); }

        [Offset(725UL)]
        public byte SEHValidationPolicy { get => ReadHere<byte>(nameof(SEHValidationPolicy)); set => WriteHere(nameof(SEHValidationPolicy), value); }

        [Offset(725UL)]
        public byte CurDirDevicesSkippedForDlls { get => ReadHere<byte>(nameof(CurDirDevicesSkippedForDlls)); set => WriteHere(nameof(CurDirDevicesSkippedForDlls), value); }

        [Offset(725UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(726UL)]
        public ushort CyclesPerYield { get => ReadHere<ushort>(nameof(CyclesPerYield)); set => WriteHere(nameof(CyclesPerYield), value); }

        [Offset(728UL)]
        public uint ActiveConsoleId { get => ReadHere<uint>(nameof(ActiveConsoleId)); set => WriteHere(nameof(ActiveConsoleId), value); }

        [Offset(732UL)]
        public uint DismountCount { get => ReadHere<uint>(nameof(DismountCount)); set => WriteHere(nameof(DismountCount), value); }

        [Offset(736UL)]
        public uint ComPlusPackage { get => ReadHere<uint>(nameof(ComPlusPackage)); set => WriteHere(nameof(ComPlusPackage), value); }

        [Offset(740UL)]
        public uint LastSystemRITEventTickCount { get => ReadHere<uint>(nameof(LastSystemRITEventTickCount)); set => WriteHere(nameof(LastSystemRITEventTickCount), value); }

        [Offset(744UL)]
        public uint NumberOfPhysicalPages { get => ReadHere<uint>(nameof(NumberOfPhysicalPages)); set => WriteHere(nameof(NumberOfPhysicalPages), value); }

        [Offset(748UL)]
        public byte SafeBootMode { get => ReadHere<byte>(nameof(SafeBootMode)); set => WriteHere(nameof(SafeBootMode), value); }

        [Offset(749UL)]
        public byte VirtualizationFlags { get => ReadHere<byte>(nameof(VirtualizationFlags)); set => WriteHere(nameof(VirtualizationFlags), value); }

        [Offset(750UL)]
        [Length(2)]
        public DynamicArray Reserved12 { get => ReadStructure<DynamicArray>(nameof(Reserved12)); set => WriteStructure(nameof(Reserved12), value); }

        [Offset(752UL)]
        public uint SharedDataFlags { get => ReadHere<uint>(nameof(SharedDataFlags)); set => WriteHere(nameof(SharedDataFlags), value); }

        [Offset(752UL)]
        public uint DbgErrorPortPresent { get => ReadHere<uint>(nameof(DbgErrorPortPresent)); set => WriteHere(nameof(DbgErrorPortPresent), value); }

        [Offset(752UL)]
        public uint DbgElevationEnabled { get => ReadHere<uint>(nameof(DbgElevationEnabled)); set => WriteHere(nameof(DbgElevationEnabled), value); }

        [Offset(752UL)]
        public uint DbgVirtEnabled { get => ReadHere<uint>(nameof(DbgVirtEnabled)); set => WriteHere(nameof(DbgVirtEnabled), value); }

        [Offset(752UL)]
        public uint DbgInstallerDetectEnabled { get => ReadHere<uint>(nameof(DbgInstallerDetectEnabled)); set => WriteHere(nameof(DbgInstallerDetectEnabled), value); }

        [Offset(752UL)]
        public uint DbgLkgEnabled { get => ReadHere<uint>(nameof(DbgLkgEnabled)); set => WriteHere(nameof(DbgLkgEnabled), value); }

        [Offset(752UL)]
        public uint DbgDynProcessorEnabled { get => ReadHere<uint>(nameof(DbgDynProcessorEnabled)); set => WriteHere(nameof(DbgDynProcessorEnabled), value); }

        [Offset(752UL)]
        public uint DbgConsoleBrokerEnabled { get => ReadHere<uint>(nameof(DbgConsoleBrokerEnabled)); set => WriteHere(nameof(DbgConsoleBrokerEnabled), value); }

        [Offset(752UL)]
        public uint DbgSecureBootEnabled { get => ReadHere<uint>(nameof(DbgSecureBootEnabled)); set => WriteHere(nameof(DbgSecureBootEnabled), value); }

        [Offset(752UL)]
        public uint DbgMultiSessionSku { get => ReadHere<uint>(nameof(DbgMultiSessionSku)); set => WriteHere(nameof(DbgMultiSessionSku), value); }

        [Offset(752UL)]
        public uint DbgMultiUsersInSessionSku { get => ReadHere<uint>(nameof(DbgMultiUsersInSessionSku)); set => WriteHere(nameof(DbgMultiUsersInSessionSku), value); }

        [Offset(752UL)]
        public uint DbgStateSeparationEnabled { get => ReadHere<uint>(nameof(DbgStateSeparationEnabled)); set => WriteHere(nameof(DbgStateSeparationEnabled), value); }

        [Offset(752UL)]
        public uint SpareBits { get => ReadHere<uint>(nameof(SpareBits)); set => WriteHere(nameof(SpareBits), value); }

        [Offset(756UL)]
        [Length(1)]
        public DynamicArray DataFlagsPad { get => ReadStructure<DynamicArray>(nameof(DataFlagsPad)); set => WriteStructure(nameof(DataFlagsPad), value); }

        [Offset(760UL)]
        public ulong TestRetInstruction { get => ReadHere<ulong>(nameof(TestRetInstruction)); set => WriteHere(nameof(TestRetInstruction), value); }

        [Offset(768UL)]
        public long QpcFrequency { get => ReadHere<long>(nameof(QpcFrequency)); set => WriteHere(nameof(QpcFrequency), value); }

        [Offset(776UL)]
        public uint SystemCall { get => ReadHere<uint>(nameof(SystemCall)); set => WriteHere(nameof(SystemCall), value); }

        [Offset(780UL)]
        public uint Reserved2 { get => ReadHere<uint>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(784UL)]
        public ulong FullNumberOfPhysicalPages { get => ReadHere<ulong>(nameof(FullNumberOfPhysicalPages)); set => WriteHere(nameof(FullNumberOfPhysicalPages), value); }

        [Offset(792UL)]
        [Length(1)]
        public DynamicArray SystemCallPad { get => ReadStructure<DynamicArray>(nameof(SystemCallPad)); set => WriteStructure(nameof(SystemCallPad), value); }

        [Offset(800UL)]
        public KsystemTime TickCount { get => ReadStructure<KsystemTime>(nameof(TickCount)); set => WriteStructure(nameof(TickCount), value); }

        [Offset(800UL)]
        public ulong TickCountQuad { get => ReadHere<ulong>(nameof(TickCountQuad)); set => WriteHere(nameof(TickCountQuad), value); }

        [Offset(800UL)]
        [Length(3)]
        public DynamicArray ReservedTickCountOverlay { get => ReadStructure<DynamicArray>(nameof(ReservedTickCountOverlay)); set => WriteStructure(nameof(ReservedTickCountOverlay), value); }

        [Offset(812UL)]
        [Length(1)]
        public DynamicArray TickCountPad { get => ReadStructure<DynamicArray>(nameof(TickCountPad)); set => WriteStructure(nameof(TickCountPad), value); }

        [Offset(816UL)]
        public uint Cookie { get => ReadHere<uint>(nameof(Cookie)); set => WriteHere(nameof(Cookie), value); }

        [Offset(820UL)]
        [Length(1)]
        public DynamicArray CookiePad { get => ReadStructure<DynamicArray>(nameof(CookiePad)); set => WriteStructure(nameof(CookiePad), value); }

        [Offset(824UL)]
        public long ConsoleSessionForegroundProcessId { get => ReadHere<long>(nameof(ConsoleSessionForegroundProcessId)); set => WriteHere(nameof(ConsoleSessionForegroundProcessId), value); }

        [Offset(832UL)]
        public ulong TimeUpdateLock { get => ReadHere<ulong>(nameof(TimeUpdateLock)); set => WriteHere(nameof(TimeUpdateLock), value); }

        [Offset(840UL)]
        public ulong BaselineSystemTimeQpc { get => ReadHere<ulong>(nameof(BaselineSystemTimeQpc)); set => WriteHere(nameof(BaselineSystemTimeQpc), value); }

        [Offset(848UL)]
        public ulong BaselineInterruptTimeQpc { get => ReadHere<ulong>(nameof(BaselineInterruptTimeQpc)); set => WriteHere(nameof(BaselineInterruptTimeQpc), value); }

        [Offset(856UL)]
        public ulong QpcSystemTimeIncrement { get => ReadHere<ulong>(nameof(QpcSystemTimeIncrement)); set => WriteHere(nameof(QpcSystemTimeIncrement), value); }

        [Offset(864UL)]
        public ulong QpcInterruptTimeIncrement { get => ReadHere<ulong>(nameof(QpcInterruptTimeIncrement)); set => WriteHere(nameof(QpcInterruptTimeIncrement), value); }

        [Offset(872UL)]
        public byte QpcSystemTimeIncrementShift { get => ReadHere<byte>(nameof(QpcSystemTimeIncrementShift)); set => WriteHere(nameof(QpcSystemTimeIncrementShift), value); }

        [Offset(873UL)]
        public byte QpcInterruptTimeIncrementShift { get => ReadHere<byte>(nameof(QpcInterruptTimeIncrementShift)); set => WriteHere(nameof(QpcInterruptTimeIncrementShift), value); }

        [Offset(874UL)]
        public ushort UnparkedProcessorCount { get => ReadHere<ushort>(nameof(UnparkedProcessorCount)); set => WriteHere(nameof(UnparkedProcessorCount), value); }

        [Offset(876UL)]
        [Length(4)]
        public DynamicArray EnclaveFeatureMask { get => ReadStructure<DynamicArray>(nameof(EnclaveFeatureMask)); set => WriteStructure(nameof(EnclaveFeatureMask), value); }

        [Offset(892UL)]
        public uint TelemetryCoverageRound { get => ReadHere<uint>(nameof(TelemetryCoverageRound)); set => WriteHere(nameof(TelemetryCoverageRound), value); }

        [Offset(896UL)]
        [Length(16)]
        public DynamicArray UserModeGlobalLogger { get => ReadStructure<DynamicArray>(nameof(UserModeGlobalLogger)); set => WriteStructure(nameof(UserModeGlobalLogger), value); }

        [Offset(928UL)]
        public uint ImageFileExecutionOptions { get => ReadHere<uint>(nameof(ImageFileExecutionOptions)); set => WriteHere(nameof(ImageFileExecutionOptions), value); }

        [Offset(932UL)]
        public uint LangGenerationCount { get => ReadHere<uint>(nameof(LangGenerationCount)); set => WriteHere(nameof(LangGenerationCount), value); }

        [Offset(936UL)]
        public ulong Reserved4 { get => ReadHere<ulong>(nameof(Reserved4)); set => WriteHere(nameof(Reserved4), value); }

        [Offset(944UL)]
        public ulong InterruptTimeBias { get => ReadHere<ulong>(nameof(InterruptTimeBias)); set => WriteHere(nameof(InterruptTimeBias), value); }

        [Offset(952UL)]
        public ulong QpcBias { get => ReadHere<ulong>(nameof(QpcBias)); set => WriteHere(nameof(QpcBias), value); }

        [Offset(960UL)]
        public uint ActiveProcessorCount { get => ReadHere<uint>(nameof(ActiveProcessorCount)); set => WriteHere(nameof(ActiveProcessorCount), value); }

        [Offset(964UL)]
        public byte ActiveGroupCount { get => ReadHere<byte>(nameof(ActiveGroupCount)); set => WriteHere(nameof(ActiveGroupCount), value); }

        [Offset(965UL)]
        public byte Reserved9 { get => ReadHere<byte>(nameof(Reserved9)); set => WriteHere(nameof(Reserved9), value); }

        [Offset(966UL)]
        public ushort QpcData { get => ReadHere<ushort>(nameof(QpcData)); set => WriteHere(nameof(QpcData), value); }

        [Offset(966UL)]
        public byte QpcBypassEnabled { get => ReadHere<byte>(nameof(QpcBypassEnabled)); set => WriteHere(nameof(QpcBypassEnabled), value); }

        [Offset(967UL)]
        public byte QpcReserved { get => ReadHere<byte>(nameof(QpcReserved)); set => WriteHere(nameof(QpcReserved), value); }

        [Offset(968UL)]
        public LargeInteger TimeZoneBiasEffectiveStart { get => ReadStructure<LargeInteger>(nameof(TimeZoneBiasEffectiveStart)); set => WriteStructure(nameof(TimeZoneBiasEffectiveStart), value); }

        [Offset(976UL)]
        public LargeInteger TimeZoneBiasEffectiveEnd { get => ReadStructure<LargeInteger>(nameof(TimeZoneBiasEffectiveEnd)); set => WriteStructure(nameof(TimeZoneBiasEffectiveEnd), value); }

        [Offset(984UL)]
        public XstateConfiguration XState { get => ReadStructure<XstateConfiguration>(nameof(XState)); set => WriteStructure(nameof(XState), value); }

        [Offset(1824UL)]
        public KsystemTime FeatureConfigurationChangeStamp { get => ReadStructure<KsystemTime>(nameof(FeatureConfigurationChangeStamp)); set => WriteStructure(nameof(FeatureConfigurationChangeStamp), value); }

        [Offset(1836UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(1840UL)]
        public ulong UserPointerAuthMask { get => ReadHere<ulong>(nameof(UserPointerAuthMask)); set => WriteHere(nameof(UserPointerAuthMask), value); }

        [Offset(1848UL)]
        [Length(210)]
        public DynamicArray Reserved10 { get => ReadStructure<DynamicArray>(nameof(Reserved10)); set => WriteStructure(nameof(Reserved10), value); }

        public KuserSharedData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KuserSharedData>();
        }
    }
}