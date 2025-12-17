using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TEB32")]
    public sealed class TEB32 : DynamicStructure
    {
        [Offset(0UL)]
        public NtTIB32 NtTib { get => ReadStructure<NtTIB32>(nameof(NtTib)); set => WriteStructure(nameof(NtTib), value); }

        [Offset(28UL)]
        public uint EnvironmentPointer { get => ReadHere<uint>(nameof(EnvironmentPointer)); set => WriteHere(nameof(EnvironmentPointer), value); }

        [Offset(32UL)]
        public ClientID32 ClientId { get => ReadStructure<ClientID32>(nameof(ClientId)); set => WriteStructure(nameof(ClientId), value); }

        [Offset(40UL)]
        public uint ActiveRpcHandle { get => ReadHere<uint>(nameof(ActiveRpcHandle)); set => WriteHere(nameof(ActiveRpcHandle), value); }

        [Offset(44UL)]
        public uint ThreadLocalStoragePointer { get => ReadHere<uint>(nameof(ThreadLocalStoragePointer)); set => WriteHere(nameof(ThreadLocalStoragePointer), value); }

        [Offset(48UL)]
        public uint ProcessEnvironmentBlock { get => ReadHere<uint>(nameof(ProcessEnvironmentBlock)); set => WriteHere(nameof(ProcessEnvironmentBlock), value); }

        [Offset(52UL)]
        public uint LastErrorValue { get => ReadHere<uint>(nameof(LastErrorValue)); set => WriteHere(nameof(LastErrorValue), value); }

        [Offset(56UL)]
        public uint CountOfOwnedCriticalSections { get => ReadHere<uint>(nameof(CountOfOwnedCriticalSections)); set => WriteHere(nameof(CountOfOwnedCriticalSections), value); }

        [Offset(60UL)]
        public uint CsrClientThread { get => ReadHere<uint>(nameof(CsrClientThread)); set => WriteHere(nameof(CsrClientThread), value); }

        [Offset(64UL)]
        public uint Win32ThreadInfo { get => ReadHere<uint>(nameof(Win32ThreadInfo)); set => WriteHere(nameof(Win32ThreadInfo), value); }

        [Offset(68UL)]
        [Length(26)]
        public DynamicArray User32Reserved { get => ReadStructure<DynamicArray>(nameof(User32Reserved)); set => WriteStructure(nameof(User32Reserved), value); }

        [Offset(172UL)]
        [Length(5)]
        public DynamicArray UserReserved { get => ReadStructure<DynamicArray>(nameof(UserReserved)); set => WriteStructure(nameof(UserReserved), value); }

        [Offset(192UL)]
        public uint WOW32Reserved { get => ReadHere<uint>(nameof(WOW32Reserved)); set => WriteHere(nameof(WOW32Reserved), value); }

        [Offset(196UL)]
        public uint CurrentLocale { get => ReadHere<uint>(nameof(CurrentLocale)); set => WriteHere(nameof(CurrentLocale), value); }

        [Offset(200UL)]
        public uint FpSoftwareStatusRegister { get => ReadHere<uint>(nameof(FpSoftwareStatusRegister)); set => WriteHere(nameof(FpSoftwareStatusRegister), value); }

        [Offset(204UL)]
        [Length(16)]
        public DynamicArray ReservedForDebuggerInstrumentation { get => ReadStructure<DynamicArray>(nameof(ReservedForDebuggerInstrumentation)); set => WriteStructure(nameof(ReservedForDebuggerInstrumentation), value); }

        [Offset(268UL)]
        [Length(21)]
        public DynamicArray SystemReserved1 { get => ReadStructure<DynamicArray>(nameof(SystemReserved1)); set => WriteStructure(nameof(SystemReserved1), value); }

        [Offset(352UL)]
        public uint HeapFlsData { get => ReadHere<uint>(nameof(HeapFlsData)); set => WriteHere(nameof(HeapFlsData), value); }

        [Offset(356UL)]
        [Length(4)]
        public DynamicArray RngState { get => ReadStructure<DynamicArray>(nameof(RngState)); set => WriteStructure(nameof(RngState), value); }

        [Offset(372UL)]
        public sbyte PlaceholderCompatibilityMode { get => ReadHere<sbyte>(nameof(PlaceholderCompatibilityMode)); set => WriteHere(nameof(PlaceholderCompatibilityMode), value); }

        [Offset(373UL)]
        public byte PlaceholderHydrationAlwaysExplicit { get => ReadHere<byte>(nameof(PlaceholderHydrationAlwaysExplicit)); set => WriteHere(nameof(PlaceholderHydrationAlwaysExplicit), value); }

        [Offset(374UL)]
        [Length(10)]
        public DynamicArray PlaceholderReserved { get => ReadStructure<DynamicArray>(nameof(PlaceholderReserved)); set => WriteStructure(nameof(PlaceholderReserved), value); }

        [Offset(384UL)]
        public uint ProxiedProcessId { get => ReadHere<uint>(nameof(ProxiedProcessId)); set => WriteHere(nameof(ProxiedProcessId), value); }

        [Offset(388UL)]
        public ActivationContextSTACK32 _ActivationStack { get => ReadStructure<ActivationContextSTACK32>(nameof(_ActivationStack)); set => WriteStructure(nameof(_ActivationStack), value); }

        [Offset(412UL)]
        [Length(8)]
        public DynamicArray WorkingOnBehalfTicket { get => ReadStructure<DynamicArray>(nameof(WorkingOnBehalfTicket)); set => WriteStructure(nameof(WorkingOnBehalfTicket), value); }

        [Offset(420UL)]
        public int ExceptionCode { get => ReadHere<int>(nameof(ExceptionCode)); set => WriteHere(nameof(ExceptionCode), value); }

        [Offset(424UL)]
        public uint ActivationContextStackPointer { get => ReadHere<uint>(nameof(ActivationContextStackPointer)); set => WriteHere(nameof(ActivationContextStackPointer), value); }

        [Offset(428UL)]
        public uint InstrumentationCallbackSp { get => ReadHere<uint>(nameof(InstrumentationCallbackSp)); set => WriteHere(nameof(InstrumentationCallbackSp), value); }

        [Offset(432UL)]
        public uint InstrumentationCallbackPreviousPc { get => ReadHere<uint>(nameof(InstrumentationCallbackPreviousPc)); set => WriteHere(nameof(InstrumentationCallbackPreviousPc), value); }

        [Offset(436UL)]
        public uint InstrumentationCallbackPreviousSp { get => ReadHere<uint>(nameof(InstrumentationCallbackPreviousSp)); set => WriteHere(nameof(InstrumentationCallbackPreviousSp), value); }

        [Offset(440UL)]
        public byte InstrumentationCallbackDisabled { get => ReadHere<byte>(nameof(InstrumentationCallbackDisabled)); set => WriteHere(nameof(InstrumentationCallbackDisabled), value); }

        [Offset(441UL)]
        [Length(23)]
        public DynamicArray SpareBytes { get => ReadStructure<DynamicArray>(nameof(SpareBytes)); set => WriteStructure(nameof(SpareBytes), value); }

        [Offset(464UL)]
        public uint TxFsContext { get => ReadHere<uint>(nameof(TxFsContext)); set => WriteHere(nameof(TxFsContext), value); }

        [Offset(468UL)]
        public GdiTebBATCH32 GdiTebBatch { get => ReadStructure<GdiTebBATCH32>(nameof(GdiTebBatch)); set => WriteStructure(nameof(GdiTebBatch), value); }

        [Offset(1716UL)]
        public ClientID32 RealClientId { get => ReadStructure<ClientID32>(nameof(RealClientId)); set => WriteStructure(nameof(RealClientId), value); }

        [Offset(1724UL)]
        public uint GdiCachedProcessHandle { get => ReadHere<uint>(nameof(GdiCachedProcessHandle)); set => WriteHere(nameof(GdiCachedProcessHandle), value); }

        [Offset(1728UL)]
        public uint GdiClientPID { get => ReadHere<uint>(nameof(GdiClientPID)); set => WriteHere(nameof(GdiClientPID), value); }

        [Offset(1732UL)]
        public uint GdiClientTID { get => ReadHere<uint>(nameof(GdiClientTID)); set => WriteHere(nameof(GdiClientTID), value); }

        [Offset(1736UL)]
        public uint GdiThreadLocalInfo { get => ReadHere<uint>(nameof(GdiThreadLocalInfo)); set => WriteHere(nameof(GdiThreadLocalInfo), value); }

        [Offset(1740UL)]
        [Length(62)]
        public DynamicArray Win32ClientInfo { get => ReadStructure<DynamicArray>(nameof(Win32ClientInfo)); set => WriteStructure(nameof(Win32ClientInfo), value); }

        [Offset(1988UL)]
        [Length(233)]
        public DynamicArray glDispatchTable { get => ReadStructure<DynamicArray>(nameof(glDispatchTable)); set => WriteStructure(nameof(glDispatchTable), value); }

        [Offset(2920UL)]
        [Length(29)]
        public DynamicArray glReserved1 { get => ReadStructure<DynamicArray>(nameof(glReserved1)); set => WriteStructure(nameof(glReserved1), value); }

        [Offset(3036UL)]
        public uint glReserved2 { get => ReadHere<uint>(nameof(glReserved2)); set => WriteHere(nameof(glReserved2), value); }

        [Offset(3040UL)]
        public uint glSectionInfo { get => ReadHere<uint>(nameof(glSectionInfo)); set => WriteHere(nameof(glSectionInfo), value); }

        [Offset(3044UL)]
        public uint glSection { get => ReadHere<uint>(nameof(glSection)); set => WriteHere(nameof(glSection), value); }

        [Offset(3048UL)]
        public uint glTable { get => ReadHere<uint>(nameof(glTable)); set => WriteHere(nameof(glTable), value); }

        [Offset(3052UL)]
        public uint glCurrentRC { get => ReadHere<uint>(nameof(glCurrentRC)); set => WriteHere(nameof(glCurrentRC), value); }

        [Offset(3056UL)]
        public uint glContext { get => ReadHere<uint>(nameof(glContext)); set => WriteHere(nameof(glContext), value); }

        [Offset(3060UL)]
        public uint LastStatusValue { get => ReadHere<uint>(nameof(LastStatusValue)); set => WriteHere(nameof(LastStatusValue), value); }

        [Offset(3064UL)]
        public STRING32 StaticUnicodeString { get => ReadStructure<STRING32>(nameof(StaticUnicodeString)); set => WriteStructure(nameof(StaticUnicodeString), value); }

        [Offset(3072UL)]
        [Length(261)]
        public DynamicArray StaticUnicodeBuffer { get => ReadStructure<DynamicArray>(nameof(StaticUnicodeBuffer)); set => WriteStructure(nameof(StaticUnicodeBuffer), value); }

        [Offset(3596UL)]
        public uint DeallocationStack { get => ReadHere<uint>(nameof(DeallocationStack)); set => WriteHere(nameof(DeallocationStack), value); }

        [Offset(3600UL)]
        [Length(64)]
        public DynamicArray TlsSlots { get => ReadStructure<DynamicArray>(nameof(TlsSlots)); set => WriteStructure(nameof(TlsSlots), value); }

        [Offset(3856UL)]
        public ListENTRY32 TlsLinks { get => ReadStructure<ListENTRY32>(nameof(TlsLinks)); set => WriteStructure(nameof(TlsLinks), value); }

        [Offset(3864UL)]
        public uint Vdm { get => ReadHere<uint>(nameof(Vdm)); set => WriteHere(nameof(Vdm), value); }

        [Offset(3868UL)]
        public uint ReservedForNtRpc { get => ReadHere<uint>(nameof(ReservedForNtRpc)); set => WriteHere(nameof(ReservedForNtRpc), value); }

        [Offset(3872UL)]
        [Length(2)]
        public DynamicArray DbgSsReserved { get => ReadStructure<DynamicArray>(nameof(DbgSsReserved)); set => WriteStructure(nameof(DbgSsReserved), value); }

        [Offset(3880UL)]
        public uint HardErrorMode { get => ReadHere<uint>(nameof(HardErrorMode)); set => WriteHere(nameof(HardErrorMode), value); }

        [Offset(3884UL)]
        [Length(9)]
        public DynamicArray Instrumentation { get => ReadStructure<DynamicArray>(nameof(Instrumentation)); set => WriteStructure(nameof(Instrumentation), value); }

        [Offset(3920UL)]
        public Guid ActivityId { get => ReadStructure<Guid>(nameof(ActivityId)); set => WriteStructure(nameof(ActivityId), value); }

        [Offset(3936UL)]
        public uint SubProcessTag { get => ReadHere<uint>(nameof(SubProcessTag)); set => WriteHere(nameof(SubProcessTag), value); }

        [Offset(3940UL)]
        public uint PerflibData { get => ReadHere<uint>(nameof(PerflibData)); set => WriteHere(nameof(PerflibData), value); }

        [Offset(3944UL)]
        public uint EtwTraceData { get => ReadHere<uint>(nameof(EtwTraceData)); set => WriteHere(nameof(EtwTraceData), value); }

        [Offset(3948UL)]
        public uint WinSockData { get => ReadHere<uint>(nameof(WinSockData)); set => WriteHere(nameof(WinSockData), value); }

        [Offset(3952UL)]
        public uint GdiBatchCount { get => ReadHere<uint>(nameof(GdiBatchCount)); set => WriteHere(nameof(GdiBatchCount), value); }

        [Offset(3956UL)]
        public ProcessorNumber CurrentIdealProcessor { get => ReadStructure<ProcessorNumber>(nameof(CurrentIdealProcessor)); set => WriteStructure(nameof(CurrentIdealProcessor), value); }

        [Offset(3956UL)]
        public uint IdealProcessorValue { get => ReadHere<uint>(nameof(IdealProcessorValue)); set => WriteHere(nameof(IdealProcessorValue), value); }

        [Offset(3956UL)]
        public byte ReservedPad0 { get => ReadHere<byte>(nameof(ReservedPad0)); set => WriteHere(nameof(ReservedPad0), value); }

        [Offset(3957UL)]
        public byte ReservedPad1 { get => ReadHere<byte>(nameof(ReservedPad1)); set => WriteHere(nameof(ReservedPad1), value); }

        [Offset(3958UL)]
        public byte ReservedPad2 { get => ReadHere<byte>(nameof(ReservedPad2)); set => WriteHere(nameof(ReservedPad2), value); }

        [Offset(3959UL)]
        public byte IdealProcessor { get => ReadHere<byte>(nameof(IdealProcessor)); set => WriteHere(nameof(IdealProcessor), value); }

        [Offset(3960UL)]
        public uint GuaranteedStackBytes { get => ReadHere<uint>(nameof(GuaranteedStackBytes)); set => WriteHere(nameof(GuaranteedStackBytes), value); }

        [Offset(3964UL)]
        public uint ReservedForPerf { get => ReadHere<uint>(nameof(ReservedForPerf)); set => WriteHere(nameof(ReservedForPerf), value); }

        [Offset(3968UL)]
        public uint ReservedForOle { get => ReadHere<uint>(nameof(ReservedForOle)); set => WriteHere(nameof(ReservedForOle), value); }

        [Offset(3972UL)]
        public uint WaitingOnLoaderLock { get => ReadHere<uint>(nameof(WaitingOnLoaderLock)); set => WriteHere(nameof(WaitingOnLoaderLock), value); }

        [Offset(3976UL)]
        public uint SavedPriorityState { get => ReadHere<uint>(nameof(SavedPriorityState)); set => WriteHere(nameof(SavedPriorityState), value); }

        [Offset(3980UL)]
        public uint ReservedForCodeCoverage { get => ReadHere<uint>(nameof(ReservedForCodeCoverage)); set => WriteHere(nameof(ReservedForCodeCoverage), value); }

        [Offset(3984UL)]
        public uint ThreadPoolData { get => ReadHere<uint>(nameof(ThreadPoolData)); set => WriteHere(nameof(ThreadPoolData), value); }

        [Offset(3988UL)]
        public uint TlsExpansionSlots { get => ReadHere<uint>(nameof(TlsExpansionSlots)); set => WriteHere(nameof(TlsExpansionSlots), value); }

        [Offset(3992UL)]
        public uint MuiGeneration { get => ReadHere<uint>(nameof(MuiGeneration)); set => WriteHere(nameof(MuiGeneration), value); }

        [Offset(3996UL)]
        public uint IsImpersonating { get => ReadHere<uint>(nameof(IsImpersonating)); set => WriteHere(nameof(IsImpersonating), value); }

        [Offset(4000UL)]
        public uint NlsCache { get => ReadHere<uint>(nameof(NlsCache)); set => WriteHere(nameof(NlsCache), value); }

        [Offset(4004UL)]
        public uint pShimData { get => ReadHere<uint>(nameof(pShimData)); set => WriteHere(nameof(pShimData), value); }

        [Offset(4008UL)]
        public uint HeapData { get => ReadHere<uint>(nameof(HeapData)); set => WriteHere(nameof(HeapData), value); }

        [Offset(4012UL)]
        public uint CurrentTransactionHandle { get => ReadHere<uint>(nameof(CurrentTransactionHandle)); set => WriteHere(nameof(CurrentTransactionHandle), value); }

        [Offset(4016UL)]
        public uint ActiveFrame { get => ReadHere<uint>(nameof(ActiveFrame)); set => WriteHere(nameof(ActiveFrame), value); }

        [Offset(4020UL)]
        public uint FlsData { get => ReadHere<uint>(nameof(FlsData)); set => WriteHere(nameof(FlsData), value); }

        [Offset(4024UL)]
        public uint PreferredLanguages { get => ReadHere<uint>(nameof(PreferredLanguages)); set => WriteHere(nameof(PreferredLanguages), value); }

        [Offset(4028UL)]
        public uint UserPrefLanguages { get => ReadHere<uint>(nameof(UserPrefLanguages)); set => WriteHere(nameof(UserPrefLanguages), value); }

        [Offset(4032UL)]
        public uint MergedPrefLanguages { get => ReadHere<uint>(nameof(MergedPrefLanguages)); set => WriteHere(nameof(MergedPrefLanguages), value); }

        [Offset(4036UL)]
        public uint MuiImpersonation { get => ReadHere<uint>(nameof(MuiImpersonation)); set => WriteHere(nameof(MuiImpersonation), value); }

        [Offset(4040UL)]
        public ushort CrossTebFlags { get => ReadHere<ushort>(nameof(CrossTebFlags)); set => WriteHere(nameof(CrossTebFlags), value); }

        [Offset(4040UL)]
        public ushort SpareCrossTebBits { get => ReadHere<ushort>(nameof(SpareCrossTebBits)); set => WriteHere(nameof(SpareCrossTebBits), value); }

        [Offset(4042UL)]
        public ushort SameTebFlags { get => ReadHere<ushort>(nameof(SameTebFlags)); set => WriteHere(nameof(SameTebFlags), value); }

        [Offset(4042UL)]
        public ushort SafeThunkCall { get => ReadHere<ushort>(nameof(SafeThunkCall)); set => WriteHere(nameof(SafeThunkCall), value); }

        [Offset(4042UL)]
        public ushort InDebugPrint { get => ReadHere<ushort>(nameof(InDebugPrint)); set => WriteHere(nameof(InDebugPrint), value); }

        [Offset(4042UL)]
        public ushort HasFiberData { get => ReadHere<ushort>(nameof(HasFiberData)); set => WriteHere(nameof(HasFiberData), value); }

        [Offset(4042UL)]
        public ushort SkipThreadAttach { get => ReadHere<ushort>(nameof(SkipThreadAttach)); set => WriteHere(nameof(SkipThreadAttach), value); }

        [Offset(4042UL)]
        public ushort WerInShipAssertCode { get => ReadHere<ushort>(nameof(WerInShipAssertCode)); set => WriteHere(nameof(WerInShipAssertCode), value); }

        [Offset(4042UL)]
        public ushort RanProcessInit { get => ReadHere<ushort>(nameof(RanProcessInit)); set => WriteHere(nameof(RanProcessInit), value); }

        [Offset(4042UL)]
        public ushort ClonedThread { get => ReadHere<ushort>(nameof(ClonedThread)); set => WriteHere(nameof(ClonedThread), value); }

        [Offset(4042UL)]
        public ushort SuppressDebugMsg { get => ReadHere<ushort>(nameof(SuppressDebugMsg)); set => WriteHere(nameof(SuppressDebugMsg), value); }

        [Offset(4042UL)]
        public ushort DisableUserStackWalk { get => ReadHere<ushort>(nameof(DisableUserStackWalk)); set => WriteHere(nameof(DisableUserStackWalk), value); }

        [Offset(4042UL)]
        public ushort RtlExceptionAttached { get => ReadHere<ushort>(nameof(RtlExceptionAttached)); set => WriteHere(nameof(RtlExceptionAttached), value); }

        [Offset(4042UL)]
        public ushort InitialThread { get => ReadHere<ushort>(nameof(InitialThread)); set => WriteHere(nameof(InitialThread), value); }

        [Offset(4042UL)]
        public ushort SessionAware { get => ReadHere<ushort>(nameof(SessionAware)); set => WriteHere(nameof(SessionAware), value); }

        [Offset(4042UL)]
        public ushort LoadOwner { get => ReadHere<ushort>(nameof(LoadOwner)); set => WriteHere(nameof(LoadOwner), value); }

        [Offset(4042UL)]
        public ushort LoaderWorker { get => ReadHere<ushort>(nameof(LoaderWorker)); set => WriteHere(nameof(LoaderWorker), value); }

        [Offset(4042UL)]
        public ushort SkipLoaderInit { get => ReadHere<ushort>(nameof(SkipLoaderInit)); set => WriteHere(nameof(SkipLoaderInit), value); }

        [Offset(4042UL)]
        public ushort SkipFileAPIBrokering { get => ReadHere<ushort>(nameof(SkipFileAPIBrokering)); set => WriteHere(nameof(SkipFileAPIBrokering), value); }

        [Offset(4044UL)]
        public uint TxnScopeEnterCallback { get => ReadHere<uint>(nameof(TxnScopeEnterCallback)); set => WriteHere(nameof(TxnScopeEnterCallback), value); }

        [Offset(4048UL)]
        public uint TxnScopeExitCallback { get => ReadHere<uint>(nameof(TxnScopeExitCallback)); set => WriteHere(nameof(TxnScopeExitCallback), value); }

        [Offset(4052UL)]
        public uint TxnScopeContext { get => ReadHere<uint>(nameof(TxnScopeContext)); set => WriteHere(nameof(TxnScopeContext), value); }

        [Offset(4056UL)]
        public uint LockCount { get => ReadHere<uint>(nameof(LockCount)); set => WriteHere(nameof(LockCount), value); }

        [Offset(4060UL)]
        public int WowTebOffset { get => ReadHere<int>(nameof(WowTebOffset)); set => WriteHere(nameof(WowTebOffset), value); }

        [Offset(4064UL)]
        public uint ResourceRetValue { get => ReadHere<uint>(nameof(ResourceRetValue)); set => WriteHere(nameof(ResourceRetValue), value); }

        [Offset(4068UL)]
        public uint ReservedForWdf { get => ReadHere<uint>(nameof(ReservedForWdf)); set => WriteHere(nameof(ReservedForWdf), value); }

        [Offset(4072UL)]
        public ulong ReservedForCrt { get => ReadHere<ulong>(nameof(ReservedForCrt)); set => WriteHere(nameof(ReservedForCrt), value); }

        [Offset(4080UL)]
        public Guid EffectiveContainerId { get => ReadStructure<Guid>(nameof(EffectiveContainerId)); set => WriteStructure(nameof(EffectiveContainerId), value); }

        [Offset(4096UL)]
        public ulong LastSleepCounter { get => ReadHere<ulong>(nameof(LastSleepCounter)); set => WriteHere(nameof(LastSleepCounter), value); }

        [Offset(4104UL)]
        public uint SpinCallCount { get => ReadHere<uint>(nameof(SpinCallCount)); set => WriteHere(nameof(SpinCallCount), value); }

        [Offset(4112UL)]
        public ulong ExtendedFeatureDisableMask { get => ReadHere<ulong>(nameof(ExtendedFeatureDisableMask)); set => WriteHere(nameof(ExtendedFeatureDisableMask), value); }

        [Offset(4120UL)]
        public uint SchedulerSharedDataSlot { get => ReadHere<uint>(nameof(SchedulerSharedDataSlot)); set => WriteHere(nameof(SchedulerSharedDataSlot), value); }

        [Offset(4124UL)]
        public uint HeapWalkContext { get => ReadHere<uint>(nameof(HeapWalkContext)); set => WriteHere(nameof(HeapWalkContext), value); }

        [Offset(4128UL)]
        public GroupAFFINITY32 PrimaryGroupAffinity { get => ReadStructure<GroupAFFINITY32>(nameof(PrimaryGroupAffinity)); set => WriteStructure(nameof(PrimaryGroupAffinity), value); }

        [Offset(4140UL)]
        [Length(2)]
        public DynamicArray Rcu { get => ReadStructure<DynamicArray>(nameof(Rcu)); set => WriteStructure(nameof(Rcu), value); }

        public TEB32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TEB32>();
        }
    }
}