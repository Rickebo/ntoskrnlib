using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TEB64")]
    public sealed class TEB64 : DynamicStructure
    {
        [Offset(0UL)]
        public NtTIB64 NtTib { get => ReadStructure<NtTIB64>(nameof(NtTib)); set => WriteStructure(nameof(NtTib), value); }

        [Offset(56UL)]
        public ulong EnvironmentPointer { get => ReadHere<ulong>(nameof(EnvironmentPointer)); set => WriteHere(nameof(EnvironmentPointer), value); }

        [Offset(64UL)]
        public ClientID64 ClientId { get => ReadStructure<ClientID64>(nameof(ClientId)); set => WriteStructure(nameof(ClientId), value); }

        [Offset(80UL)]
        public ulong ActiveRpcHandle { get => ReadHere<ulong>(nameof(ActiveRpcHandle)); set => WriteHere(nameof(ActiveRpcHandle), value); }

        [Offset(88UL)]
        public ulong ThreadLocalStoragePointer { get => ReadHere<ulong>(nameof(ThreadLocalStoragePointer)); set => WriteHere(nameof(ThreadLocalStoragePointer), value); }

        [Offset(96UL)]
        public ulong ProcessEnvironmentBlock { get => ReadHere<ulong>(nameof(ProcessEnvironmentBlock)); set => WriteHere(nameof(ProcessEnvironmentBlock), value); }

        [Offset(104UL)]
        public uint LastErrorValue { get => ReadHere<uint>(nameof(LastErrorValue)); set => WriteHere(nameof(LastErrorValue), value); }

        [Offset(108UL)]
        public uint CountOfOwnedCriticalSections { get => ReadHere<uint>(nameof(CountOfOwnedCriticalSections)); set => WriteHere(nameof(CountOfOwnedCriticalSections), value); }

        [Offset(112UL)]
        public ulong CsrClientThread { get => ReadHere<ulong>(nameof(CsrClientThread)); set => WriteHere(nameof(CsrClientThread), value); }

        [Offset(120UL)]
        public ulong Win32ThreadInfo { get => ReadHere<ulong>(nameof(Win32ThreadInfo)); set => WriteHere(nameof(Win32ThreadInfo), value); }

        [Offset(128UL)]
        [Length(26)]
        public DynamicArray User32Reserved { get => ReadStructure<DynamicArray>(nameof(User32Reserved)); set => WriteStructure(nameof(User32Reserved), value); }

        [Offset(232UL)]
        [Length(5)]
        public DynamicArray UserReserved { get => ReadStructure<DynamicArray>(nameof(UserReserved)); set => WriteStructure(nameof(UserReserved), value); }

        [Offset(256UL)]
        public ulong WOW32Reserved { get => ReadHere<ulong>(nameof(WOW32Reserved)); set => WriteHere(nameof(WOW32Reserved), value); }

        [Offset(264UL)]
        public uint CurrentLocale { get => ReadHere<uint>(nameof(CurrentLocale)); set => WriteHere(nameof(CurrentLocale), value); }

        [Offset(268UL)]
        public uint FpSoftwareStatusRegister { get => ReadHere<uint>(nameof(FpSoftwareStatusRegister)); set => WriteHere(nameof(FpSoftwareStatusRegister), value); }

        [Offset(272UL)]
        [Length(16)]
        public DynamicArray ReservedForDebuggerInstrumentation { get => ReadStructure<DynamicArray>(nameof(ReservedForDebuggerInstrumentation)); set => WriteStructure(nameof(ReservedForDebuggerInstrumentation), value); }

        [Offset(400UL)]
        [Length(25)]
        public DynamicArray SystemReserved1 { get => ReadStructure<DynamicArray>(nameof(SystemReserved1)); set => WriteStructure(nameof(SystemReserved1), value); }

        [Offset(600UL)]
        public ulong HeapFlsData { get => ReadHere<ulong>(nameof(HeapFlsData)); set => WriteHere(nameof(HeapFlsData), value); }

        [Offset(608UL)]
        [Length(4)]
        public DynamicArray RngState { get => ReadStructure<DynamicArray>(nameof(RngState)); set => WriteStructure(nameof(RngState), value); }

        [Offset(640UL)]
        public sbyte PlaceholderCompatibilityMode { get => ReadHere<sbyte>(nameof(PlaceholderCompatibilityMode)); set => WriteHere(nameof(PlaceholderCompatibilityMode), value); }

        [Offset(641UL)]
        public byte PlaceholderHydrationAlwaysExplicit { get => ReadHere<byte>(nameof(PlaceholderHydrationAlwaysExplicit)); set => WriteHere(nameof(PlaceholderHydrationAlwaysExplicit), value); }

        [Offset(642UL)]
        [Length(10)]
        public DynamicArray PlaceholderReserved { get => ReadStructure<DynamicArray>(nameof(PlaceholderReserved)); set => WriteStructure(nameof(PlaceholderReserved), value); }

        [Offset(652UL)]
        public uint ProxiedProcessId { get => ReadHere<uint>(nameof(ProxiedProcessId)); set => WriteHere(nameof(ProxiedProcessId), value); }

        [Offset(656UL)]
        public ActivationContextSTACK64 _ActivationStack { get => ReadStructure<ActivationContextSTACK64>(nameof(_ActivationStack)); set => WriteStructure(nameof(_ActivationStack), value); }

        [Offset(696UL)]
        [Length(8)]
        public DynamicArray WorkingOnBehalfTicket { get => ReadStructure<DynamicArray>(nameof(WorkingOnBehalfTicket)); set => WriteStructure(nameof(WorkingOnBehalfTicket), value); }

        [Offset(704UL)]
        public int ExceptionCode { get => ReadHere<int>(nameof(ExceptionCode)); set => WriteHere(nameof(ExceptionCode), value); }

        [Offset(708UL)]
        [Length(4)]
        public DynamicArray Padding0 { get => ReadStructure<DynamicArray>(nameof(Padding0)); set => WriteStructure(nameof(Padding0), value); }

        [Offset(712UL)]
        public ulong ActivationContextStackPointer { get => ReadHere<ulong>(nameof(ActivationContextStackPointer)); set => WriteHere(nameof(ActivationContextStackPointer), value); }

        [Offset(720UL)]
        public ulong InstrumentationCallbackSp { get => ReadHere<ulong>(nameof(InstrumentationCallbackSp)); set => WriteHere(nameof(InstrumentationCallbackSp), value); }

        [Offset(728UL)]
        public ulong InstrumentationCallbackPreviousPc { get => ReadHere<ulong>(nameof(InstrumentationCallbackPreviousPc)); set => WriteHere(nameof(InstrumentationCallbackPreviousPc), value); }

        [Offset(736UL)]
        public ulong InstrumentationCallbackPreviousSp { get => ReadHere<ulong>(nameof(InstrumentationCallbackPreviousSp)); set => WriteHere(nameof(InstrumentationCallbackPreviousSp), value); }

        [Offset(744UL)]
        public uint TxFsContext { get => ReadHere<uint>(nameof(TxFsContext)); set => WriteHere(nameof(TxFsContext), value); }

        [Offset(748UL)]
        public byte InstrumentationCallbackDisabled { get => ReadHere<byte>(nameof(InstrumentationCallbackDisabled)); set => WriteHere(nameof(InstrumentationCallbackDisabled), value); }

        [Offset(749UL)]
        public byte UnalignedLoadStoreExceptions { get => ReadHere<byte>(nameof(UnalignedLoadStoreExceptions)); set => WriteHere(nameof(UnalignedLoadStoreExceptions), value); }

        [Offset(750UL)]
        [Length(2)]
        public DynamicArray Padding1 { get => ReadStructure<DynamicArray>(nameof(Padding1)); set => WriteStructure(nameof(Padding1), value); }

        [Offset(752UL)]
        public GdiTebBATCH64 GdiTebBatch { get => ReadStructure<GdiTebBATCH64>(nameof(GdiTebBatch)); set => WriteStructure(nameof(GdiTebBatch), value); }

        [Offset(2008UL)]
        public ClientID64 RealClientId { get => ReadStructure<ClientID64>(nameof(RealClientId)); set => WriteStructure(nameof(RealClientId), value); }

        [Offset(2024UL)]
        public ulong GdiCachedProcessHandle { get => ReadHere<ulong>(nameof(GdiCachedProcessHandle)); set => WriteHere(nameof(GdiCachedProcessHandle), value); }

        [Offset(2032UL)]
        public uint GdiClientPID { get => ReadHere<uint>(nameof(GdiClientPID)); set => WriteHere(nameof(GdiClientPID), value); }

        [Offset(2036UL)]
        public uint GdiClientTID { get => ReadHere<uint>(nameof(GdiClientTID)); set => WriteHere(nameof(GdiClientTID), value); }

        [Offset(2040UL)]
        public ulong GdiThreadLocalInfo { get => ReadHere<ulong>(nameof(GdiThreadLocalInfo)); set => WriteHere(nameof(GdiThreadLocalInfo), value); }

        [Offset(2048UL)]
        [Length(62)]
        public DynamicArray Win32ClientInfo { get => ReadStructure<DynamicArray>(nameof(Win32ClientInfo)); set => WriteStructure(nameof(Win32ClientInfo), value); }

        [Offset(2544UL)]
        [Length(233)]
        public DynamicArray glDispatchTable { get => ReadStructure<DynamicArray>(nameof(glDispatchTable)); set => WriteStructure(nameof(glDispatchTable), value); }

        [Offset(4408UL)]
        [Length(29)]
        public DynamicArray glReserved1 { get => ReadStructure<DynamicArray>(nameof(glReserved1)); set => WriteStructure(nameof(glReserved1), value); }

        [Offset(4640UL)]
        public ulong glReserved2 { get => ReadHere<ulong>(nameof(glReserved2)); set => WriteHere(nameof(glReserved2), value); }

        [Offset(4648UL)]
        public ulong glSectionInfo { get => ReadHere<ulong>(nameof(glSectionInfo)); set => WriteHere(nameof(glSectionInfo), value); }

        [Offset(4656UL)]
        public ulong glSection { get => ReadHere<ulong>(nameof(glSection)); set => WriteHere(nameof(glSection), value); }

        [Offset(4664UL)]
        public ulong glTable { get => ReadHere<ulong>(nameof(glTable)); set => WriteHere(nameof(glTable), value); }

        [Offset(4672UL)]
        public ulong glCurrentRC { get => ReadHere<ulong>(nameof(glCurrentRC)); set => WriteHere(nameof(glCurrentRC), value); }

        [Offset(4680UL)]
        public ulong glContext { get => ReadHere<ulong>(nameof(glContext)); set => WriteHere(nameof(glContext), value); }

        [Offset(4688UL)]
        public uint LastStatusValue { get => ReadHere<uint>(nameof(LastStatusValue)); set => WriteHere(nameof(LastStatusValue), value); }

        [Offset(4692UL)]
        [Length(4)]
        public DynamicArray Padding2 { get => ReadStructure<DynamicArray>(nameof(Padding2)); set => WriteStructure(nameof(Padding2), value); }

        [Offset(4696UL)]
        public STRING64 StaticUnicodeString { get => ReadStructure<STRING64>(nameof(StaticUnicodeString)); set => WriteStructure(nameof(StaticUnicodeString), value); }

        [Offset(4712UL)]
        [Length(261)]
        public DynamicArray StaticUnicodeBuffer { get => ReadStructure<DynamicArray>(nameof(StaticUnicodeBuffer)); set => WriteStructure(nameof(StaticUnicodeBuffer), value); }

        [Offset(5234UL)]
        [Length(6)]
        public DynamicArray Padding3 { get => ReadStructure<DynamicArray>(nameof(Padding3)); set => WriteStructure(nameof(Padding3), value); }

        [Offset(5240UL)]
        public ulong DeallocationStack { get => ReadHere<ulong>(nameof(DeallocationStack)); set => WriteHere(nameof(DeallocationStack), value); }

        [Offset(5248UL)]
        [Length(64)]
        public DynamicArray TlsSlots { get => ReadStructure<DynamicArray>(nameof(TlsSlots)); set => WriteStructure(nameof(TlsSlots), value); }

        [Offset(5760UL)]
        public ListENTRY64 TlsLinks { get => ReadStructure<ListENTRY64>(nameof(TlsLinks)); set => WriteStructure(nameof(TlsLinks), value); }

        [Offset(5776UL)]
        public ulong Vdm { get => ReadHere<ulong>(nameof(Vdm)); set => WriteHere(nameof(Vdm), value); }

        [Offset(5784UL)]
        public ulong ReservedForNtRpc { get => ReadHere<ulong>(nameof(ReservedForNtRpc)); set => WriteHere(nameof(ReservedForNtRpc), value); }

        [Offset(5792UL)]
        [Length(2)]
        public DynamicArray DbgSsReserved { get => ReadStructure<DynamicArray>(nameof(DbgSsReserved)); set => WriteStructure(nameof(DbgSsReserved), value); }

        [Offset(5808UL)]
        public uint HardErrorMode { get => ReadHere<uint>(nameof(HardErrorMode)); set => WriteHere(nameof(HardErrorMode), value); }

        [Offset(5812UL)]
        [Length(4)]
        public DynamicArray Padding4 { get => ReadStructure<DynamicArray>(nameof(Padding4)); set => WriteStructure(nameof(Padding4), value); }

        [Offset(5816UL)]
        [Length(11)]
        public DynamicArray Instrumentation { get => ReadStructure<DynamicArray>(nameof(Instrumentation)); set => WriteStructure(nameof(Instrumentation), value); }

        [Offset(5904UL)]
        public Guid ActivityId { get => ReadStructure<Guid>(nameof(ActivityId)); set => WriteStructure(nameof(ActivityId), value); }

        [Offset(5920UL)]
        public ulong SubProcessTag { get => ReadHere<ulong>(nameof(SubProcessTag)); set => WriteHere(nameof(SubProcessTag), value); }

        [Offset(5928UL)]
        public ulong PerflibData { get => ReadHere<ulong>(nameof(PerflibData)); set => WriteHere(nameof(PerflibData), value); }

        [Offset(5936UL)]
        public ulong EtwTraceData { get => ReadHere<ulong>(nameof(EtwTraceData)); set => WriteHere(nameof(EtwTraceData), value); }

        [Offset(5944UL)]
        public ulong WinSockData { get => ReadHere<ulong>(nameof(WinSockData)); set => WriteHere(nameof(WinSockData), value); }

        [Offset(5952UL)]
        public uint GdiBatchCount { get => ReadHere<uint>(nameof(GdiBatchCount)); set => WriteHere(nameof(GdiBatchCount), value); }

        [Offset(5956UL)]
        public ProcessorNumber CurrentIdealProcessor { get => ReadStructure<ProcessorNumber>(nameof(CurrentIdealProcessor)); set => WriteStructure(nameof(CurrentIdealProcessor), value); }

        [Offset(5956UL)]
        public uint IdealProcessorValue { get => ReadHere<uint>(nameof(IdealProcessorValue)); set => WriteHere(nameof(IdealProcessorValue), value); }

        [Offset(5956UL)]
        public byte ReservedPad0 { get => ReadHere<byte>(nameof(ReservedPad0)); set => WriteHere(nameof(ReservedPad0), value); }

        [Offset(5957UL)]
        public byte ReservedPad1 { get => ReadHere<byte>(nameof(ReservedPad1)); set => WriteHere(nameof(ReservedPad1), value); }

        [Offset(5958UL)]
        public byte ReservedPad2 { get => ReadHere<byte>(nameof(ReservedPad2)); set => WriteHere(nameof(ReservedPad2), value); }

        [Offset(5959UL)]
        public byte IdealProcessor { get => ReadHere<byte>(nameof(IdealProcessor)); set => WriteHere(nameof(IdealProcessor), value); }

        [Offset(5960UL)]
        public uint GuaranteedStackBytes { get => ReadHere<uint>(nameof(GuaranteedStackBytes)); set => WriteHere(nameof(GuaranteedStackBytes), value); }

        [Offset(5964UL)]
        [Length(4)]
        public DynamicArray Padding5 { get => ReadStructure<DynamicArray>(nameof(Padding5)); set => WriteStructure(nameof(Padding5), value); }

        [Offset(5968UL)]
        public ulong ReservedForPerf { get => ReadHere<ulong>(nameof(ReservedForPerf)); set => WriteHere(nameof(ReservedForPerf), value); }

        [Offset(5976UL)]
        public ulong ReservedForOle { get => ReadHere<ulong>(nameof(ReservedForOle)); set => WriteHere(nameof(ReservedForOle), value); }

        [Offset(5984UL)]
        public uint WaitingOnLoaderLock { get => ReadHere<uint>(nameof(WaitingOnLoaderLock)); set => WriteHere(nameof(WaitingOnLoaderLock), value); }

        [Offset(5988UL)]
        [Length(4)]
        public DynamicArray Padding6 { get => ReadStructure<DynamicArray>(nameof(Padding6)); set => WriteStructure(nameof(Padding6), value); }

        [Offset(5992UL)]
        public ulong SavedPriorityState { get => ReadHere<ulong>(nameof(SavedPriorityState)); set => WriteHere(nameof(SavedPriorityState), value); }

        [Offset(6000UL)]
        public ulong ReservedForCodeCoverage { get => ReadHere<ulong>(nameof(ReservedForCodeCoverage)); set => WriteHere(nameof(ReservedForCodeCoverage), value); }

        [Offset(6008UL)]
        public ulong ThreadPoolData { get => ReadHere<ulong>(nameof(ThreadPoolData)); set => WriteHere(nameof(ThreadPoolData), value); }

        [Offset(6016UL)]
        public ulong TlsExpansionSlots { get => ReadHere<ulong>(nameof(TlsExpansionSlots)); set => WriteHere(nameof(TlsExpansionSlots), value); }

        [Offset(6024UL)]
        public ulong ChpeV2CpuAreaInfo { get => ReadHere<ulong>(nameof(ChpeV2CpuAreaInfo)); set => WriteHere(nameof(ChpeV2CpuAreaInfo), value); }

        [Offset(6032UL)]
        public ulong Unused { get => ReadHere<ulong>(nameof(Unused)); set => WriteHere(nameof(Unused), value); }

        [Offset(6040UL)]
        public uint MuiGeneration { get => ReadHere<uint>(nameof(MuiGeneration)); set => WriteHere(nameof(MuiGeneration), value); }

        [Offset(6044UL)]
        public uint IsImpersonating { get => ReadHere<uint>(nameof(IsImpersonating)); set => WriteHere(nameof(IsImpersonating), value); }

        [Offset(6048UL)]
        public ulong NlsCache { get => ReadHere<ulong>(nameof(NlsCache)); set => WriteHere(nameof(NlsCache), value); }

        [Offset(6056UL)]
        public ulong pShimData { get => ReadHere<ulong>(nameof(pShimData)); set => WriteHere(nameof(pShimData), value); }

        [Offset(6064UL)]
        public uint HeapData { get => ReadHere<uint>(nameof(HeapData)); set => WriteHere(nameof(HeapData), value); }

        [Offset(6068UL)]
        [Length(4)]
        public DynamicArray Padding7 { get => ReadStructure<DynamicArray>(nameof(Padding7)); set => WriteStructure(nameof(Padding7), value); }

        [Offset(6072UL)]
        public ulong CurrentTransactionHandle { get => ReadHere<ulong>(nameof(CurrentTransactionHandle)); set => WriteHere(nameof(CurrentTransactionHandle), value); }

        [Offset(6080UL)]
        public ulong ActiveFrame { get => ReadHere<ulong>(nameof(ActiveFrame)); set => WriteHere(nameof(ActiveFrame), value); }

        [Offset(6088UL)]
        public ulong FlsData { get => ReadHere<ulong>(nameof(FlsData)); set => WriteHere(nameof(FlsData), value); }

        [Offset(6096UL)]
        public ulong PreferredLanguages { get => ReadHere<ulong>(nameof(PreferredLanguages)); set => WriteHere(nameof(PreferredLanguages), value); }

        [Offset(6104UL)]
        public ulong UserPrefLanguages { get => ReadHere<ulong>(nameof(UserPrefLanguages)); set => WriteHere(nameof(UserPrefLanguages), value); }

        [Offset(6112UL)]
        public ulong MergedPrefLanguages { get => ReadHere<ulong>(nameof(MergedPrefLanguages)); set => WriteHere(nameof(MergedPrefLanguages), value); }

        [Offset(6120UL)]
        public uint MuiImpersonation { get => ReadHere<uint>(nameof(MuiImpersonation)); set => WriteHere(nameof(MuiImpersonation), value); }

        [Offset(6124UL)]
        public ushort CrossTebFlags { get => ReadHere<ushort>(nameof(CrossTebFlags)); set => WriteHere(nameof(CrossTebFlags), value); }

        [Offset(6124UL)]
        public ushort SpareCrossTebBits { get => ReadHere<ushort>(nameof(SpareCrossTebBits)); set => WriteHere(nameof(SpareCrossTebBits), value); }

        [Offset(6126UL)]
        public ushort SameTebFlags { get => ReadHere<ushort>(nameof(SameTebFlags)); set => WriteHere(nameof(SameTebFlags), value); }

        [Offset(6126UL)]
        public ushort SafeThunkCall { get => ReadHere<ushort>(nameof(SafeThunkCall)); set => WriteHere(nameof(SafeThunkCall), value); }

        [Offset(6126UL)]
        public ushort InDebugPrint { get => ReadHere<ushort>(nameof(InDebugPrint)); set => WriteHere(nameof(InDebugPrint), value); }

        [Offset(6126UL)]
        public ushort HasFiberData { get => ReadHere<ushort>(nameof(HasFiberData)); set => WriteHere(nameof(HasFiberData), value); }

        [Offset(6126UL)]
        public ushort SkipThreadAttach { get => ReadHere<ushort>(nameof(SkipThreadAttach)); set => WriteHere(nameof(SkipThreadAttach), value); }

        [Offset(6126UL)]
        public ushort WerInShipAssertCode { get => ReadHere<ushort>(nameof(WerInShipAssertCode)); set => WriteHere(nameof(WerInShipAssertCode), value); }

        [Offset(6126UL)]
        public ushort RanProcessInit { get => ReadHere<ushort>(nameof(RanProcessInit)); set => WriteHere(nameof(RanProcessInit), value); }

        [Offset(6126UL)]
        public ushort ClonedThread { get => ReadHere<ushort>(nameof(ClonedThread)); set => WriteHere(nameof(ClonedThread), value); }

        [Offset(6126UL)]
        public ushort SuppressDebugMsg { get => ReadHere<ushort>(nameof(SuppressDebugMsg)); set => WriteHere(nameof(SuppressDebugMsg), value); }

        [Offset(6126UL)]
        public ushort DisableUserStackWalk { get => ReadHere<ushort>(nameof(DisableUserStackWalk)); set => WriteHere(nameof(DisableUserStackWalk), value); }

        [Offset(6126UL)]
        public ushort RtlExceptionAttached { get => ReadHere<ushort>(nameof(RtlExceptionAttached)); set => WriteHere(nameof(RtlExceptionAttached), value); }

        [Offset(6126UL)]
        public ushort InitialThread { get => ReadHere<ushort>(nameof(InitialThread)); set => WriteHere(nameof(InitialThread), value); }

        [Offset(6126UL)]
        public ushort SessionAware { get => ReadHere<ushort>(nameof(SessionAware)); set => WriteHere(nameof(SessionAware), value); }

        [Offset(6126UL)]
        public ushort LoadOwner { get => ReadHere<ushort>(nameof(LoadOwner)); set => WriteHere(nameof(LoadOwner), value); }

        [Offset(6126UL)]
        public ushort LoaderWorker { get => ReadHere<ushort>(nameof(LoaderWorker)); set => WriteHere(nameof(LoaderWorker), value); }

        [Offset(6126UL)]
        public ushort SkipLoaderInit { get => ReadHere<ushort>(nameof(SkipLoaderInit)); set => WriteHere(nameof(SkipLoaderInit), value); }

        [Offset(6126UL)]
        public ushort SkipFileAPIBrokering { get => ReadHere<ushort>(nameof(SkipFileAPIBrokering)); set => WriteHere(nameof(SkipFileAPIBrokering), value); }

        [Offset(6128UL)]
        public ulong TxnScopeEnterCallback { get => ReadHere<ulong>(nameof(TxnScopeEnterCallback)); set => WriteHere(nameof(TxnScopeEnterCallback), value); }

        [Offset(6136UL)]
        public ulong TxnScopeExitCallback { get => ReadHere<ulong>(nameof(TxnScopeExitCallback)); set => WriteHere(nameof(TxnScopeExitCallback), value); }

        [Offset(6144UL)]
        public ulong TxnScopeContext { get => ReadHere<ulong>(nameof(TxnScopeContext)); set => WriteHere(nameof(TxnScopeContext), value); }

        [Offset(6152UL)]
        public uint LockCount { get => ReadHere<uint>(nameof(LockCount)); set => WriteHere(nameof(LockCount), value); }

        [Offset(6156UL)]
        public int WowTebOffset { get => ReadHere<int>(nameof(WowTebOffset)); set => WriteHere(nameof(WowTebOffset), value); }

        [Offset(6160UL)]
        public ulong ResourceRetValue { get => ReadHere<ulong>(nameof(ResourceRetValue)); set => WriteHere(nameof(ResourceRetValue), value); }

        [Offset(6168UL)]
        public ulong ReservedForWdf { get => ReadHere<ulong>(nameof(ReservedForWdf)); set => WriteHere(nameof(ReservedForWdf), value); }

        [Offset(6176UL)]
        public ulong ReservedForCrt { get => ReadHere<ulong>(nameof(ReservedForCrt)); set => WriteHere(nameof(ReservedForCrt), value); }

        [Offset(6184UL)]
        public Guid EffectiveContainerId { get => ReadStructure<Guid>(nameof(EffectiveContainerId)); set => WriteStructure(nameof(EffectiveContainerId), value); }

        [Offset(6200UL)]
        public ulong LastSleepCounter { get => ReadHere<ulong>(nameof(LastSleepCounter)); set => WriteHere(nameof(LastSleepCounter), value); }

        [Offset(6208UL)]
        public uint SpinCallCount { get => ReadHere<uint>(nameof(SpinCallCount)); set => WriteHere(nameof(SpinCallCount), value); }

        [Offset(6212UL)]
        [Length(4)]
        public DynamicArray Padding8 { get => ReadStructure<DynamicArray>(nameof(Padding8)); set => WriteStructure(nameof(Padding8), value); }

        [Offset(6216UL)]
        public ulong ExtendedFeatureDisableMask { get => ReadHere<ulong>(nameof(ExtendedFeatureDisableMask)); set => WriteHere(nameof(ExtendedFeatureDisableMask), value); }

        [Offset(6224UL)]
        public ulong SchedulerSharedDataSlot { get => ReadHere<ulong>(nameof(SchedulerSharedDataSlot)); set => WriteHere(nameof(SchedulerSharedDataSlot), value); }

        [Offset(6232UL)]
        public ulong HeapWalkContext { get => ReadHere<ulong>(nameof(HeapWalkContext)); set => WriteHere(nameof(HeapWalkContext), value); }

        [Offset(6240UL)]
        public GroupAFFINITY64 PrimaryGroupAffinity { get => ReadStructure<GroupAFFINITY64>(nameof(PrimaryGroupAffinity)); set => WriteStructure(nameof(PrimaryGroupAffinity), value); }

        [Offset(6256UL)]
        [Length(2)]
        public DynamicArray Rcu { get => ReadStructure<DynamicArray>(nameof(Rcu)); set => WriteStructure(nameof(Rcu), value); }

        public TEB64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TEB64>();
        }
    }
}