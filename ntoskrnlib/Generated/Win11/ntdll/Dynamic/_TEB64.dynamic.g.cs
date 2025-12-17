using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TEB64")]
    public sealed class _TEB64 : DynamicStructure
    {
        public _NT_TIB64 NtTib { get; }
        public ulong EnvironmentPointer { get; }
        public _CLIENT_ID64 ClientId { get; }
        public ulong ActiveRpcHandle { get; }
        public ulong ThreadLocalStoragePointer { get; }
        public ulong ProcessEnvironmentBlock { get; }
        public uint LastErrorValue { get; }
        public uint CountOfOwnedCriticalSections { get; }
        public ulong CsrClientThread { get; }
        public ulong Win32ThreadInfo { get; }
        public uint[] User32Reserved { get; }
        public uint[] UserReserved { get; }
        public ulong WOW32Reserved { get; }
        public uint CurrentLocale { get; }
        public uint FpSoftwareStatusRegister { get; }
        public ulong[] ReservedForDebuggerInstrumentation { get; }
        public ulong[] SystemReserved1 { get; }
        public ulong HeapFlsData { get; }
        public ulong[] RngState { get; }
        public sbyte PlaceholderCompatibilityMode { get; }
        public byte PlaceholderHydrationAlwaysExplicit { get; }
        public sbyte[] PlaceholderReserved { get; }
        public uint ProxiedProcessId { get; }
        public _ACTIVATION_CONTEXT_STACK64 _ActivationStack { get; }
        public byte[] WorkingOnBehalfTicket { get; }
        public int ExceptionCode { get; }
        public byte[] Padding0 { get; }
        public ulong ActivationContextStackPointer { get; }
        public ulong InstrumentationCallbackSp { get; }
        public ulong InstrumentationCallbackPreviousPc { get; }
        public ulong InstrumentationCallbackPreviousSp { get; }
        public uint TxFsContext { get; }
        public byte InstrumentationCallbackDisabled { get; }
        public byte UnalignedLoadStoreExceptions { get; }
        public byte[] Padding1 { get; }
        public _GDI_TEB_BATCH64 GdiTebBatch { get; }
        public _CLIENT_ID64 RealClientId { get; }
        public ulong GdiCachedProcessHandle { get; }
        public uint GdiClientPID { get; }
        public uint GdiClientTID { get; }
        public ulong GdiThreadLocalInfo { get; }
        public ulong[] Win32ClientInfo { get; }
        public ulong[] glDispatchTable { get; }
        public ulong[] glReserved1 { get; }
        public ulong glReserved2 { get; }
        public ulong glSectionInfo { get; }
        public ulong glSection { get; }
        public ulong glTable { get; }
        public ulong glCurrentRC { get; }
        public ulong glContext { get; }
        public uint LastStatusValue { get; }
        public byte[] Padding2 { get; }
        public _STRING64 StaticUnicodeString { get; }
        public short[] StaticUnicodeBuffer { get; }
        public byte[] Padding3 { get; }
        public ulong DeallocationStack { get; }
        public ulong[] TlsSlots { get; }
        public LIST_ENTRY64 TlsLinks { get; }
        public ulong Vdm { get; }
        public ulong ReservedForNtRpc { get; }
        public ulong[] DbgSsReserved { get; }
        public uint HardErrorMode { get; }
        public byte[] Padding4 { get; }
        public ulong[] Instrumentation { get; }
        public _GUID ActivityId { get; }
        public ulong SubProcessTag { get; }
        public ulong PerflibData { get; }
        public ulong EtwTraceData { get; }
        public ulong WinSockData { get; }
        public uint GdiBatchCount { get; }
        public _PROCESSOR_NUMBER CurrentIdealProcessor { get; }
        public uint IdealProcessorValue { get; }
        public byte ReservedPad0 { get; }
        public byte ReservedPad1 { get; }
        public byte ReservedPad2 { get; }
        public byte IdealProcessor { get; }
        public uint GuaranteedStackBytes { get; }
        public byte[] Padding5 { get; }
        public ulong ReservedForPerf { get; }
        public ulong ReservedForOle { get; }
        public uint WaitingOnLoaderLock { get; }
        public byte[] Padding6 { get; }
        public ulong SavedPriorityState { get; }
        public ulong ReservedForCodeCoverage { get; }
        public ulong ThreadPoolData { get; }
        public ulong TlsExpansionSlots { get; }
        public ulong ChpeV2CpuAreaInfo { get; }
        public ulong Unused { get; }
        public uint MuiGeneration { get; }
        public uint IsImpersonating { get; }
        public ulong NlsCache { get; }
        public ulong pShimData { get; }
        public uint HeapData { get; }
        public byte[] Padding7 { get; }
        public ulong CurrentTransactionHandle { get; }
        public ulong ActiveFrame { get; }
        public ulong FlsData { get; }
        public ulong PreferredLanguages { get; }
        public ulong UserPrefLanguages { get; }
        public ulong MergedPrefLanguages { get; }
        public uint MuiImpersonation { get; }
        public ushort CrossTebFlags { get; }
        public ushort SpareCrossTebBits { get; }
        public ushort SameTebFlags { get; }
        public ushort SafeThunkCall { get; }
        public ushort InDebugPrint { get; }
        public ushort HasFiberData { get; }
        public ushort SkipThreadAttach { get; }
        public ushort WerInShipAssertCode { get; }
        public ushort RanProcessInit { get; }
        public ushort ClonedThread { get; }
        public ushort SuppressDebugMsg { get; }
        public ushort DisableUserStackWalk { get; }
        public ushort RtlExceptionAttached { get; }
        public ushort InitialThread { get; }
        public ushort SessionAware { get; }
        public ushort LoadOwner { get; }
        public ushort LoaderWorker { get; }
        public ushort SkipLoaderInit { get; }
        public ushort SkipFileAPIBrokering { get; }
        public ulong TxnScopeEnterCallback { get; }
        public ulong TxnScopeExitCallback { get; }
        public ulong TxnScopeContext { get; }
        public uint LockCount { get; }
        public int WowTebOffset { get; }
        public ulong ResourceRetValue { get; }
        public ulong ReservedForWdf { get; }
        public ulong ReservedForCrt { get; }
        public _GUID EffectiveContainerId { get; }
        public ulong LastSleepCounter { get; }
        public uint SpinCallCount { get; }
        public byte[] Padding8 { get; }
        public ulong ExtendedFeatureDisableMask { get; }
        public ulong SchedulerSharedDataSlot { get; }
        public ulong HeapWalkContext { get; }
        public _GROUP_AFFINITY64 PrimaryGroupAffinity { get; }
        public uint[] Rcu { get; }

        public _TEB64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TEB64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TEB64.NtTib),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TEB64.EnvironmentPointer),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_TEB64.ClientId),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_TEB64.ActiveRpcHandle),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_TEB64.ThreadLocalStoragePointer),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TEB64.ProcessEnvironmentBlock),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_TEB64.LastErrorValue),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_TEB64.CountOfOwnedCriticalSections),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_TEB64.CsrClientThread),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_TEB64.Win32ThreadInfo),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_TEB64.User32Reserved),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_TEB64.UserReserved),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_TEB64.WOW32Reserved),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_TEB64.CurrentLocale),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_TEB64.FpSoftwareStatusRegister),
                    new ulong[]
                    {
                        268UL
                    }
                },
                {
                    nameof(_TEB64.ReservedForDebuggerInstrumentation),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_TEB64.SystemReserved1),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_TEB64.HeapFlsData),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_TEB64.RngState),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_TEB64.PlaceholderCompatibilityMode),
                    new ulong[]
                    {
                        640UL
                    }
                },
                {
                    nameof(_TEB64.PlaceholderHydrationAlwaysExplicit),
                    new ulong[]
                    {
                        641UL
                    }
                },
                {
                    nameof(_TEB64.PlaceholderReserved),
                    new ulong[]
                    {
                        642UL
                    }
                },
                {
                    nameof(_TEB64.ProxiedProcessId),
                    new ulong[]
                    {
                        652UL
                    }
                },
                {
                    nameof(_TEB64._ActivationStack),
                    new ulong[]
                    {
                        656UL
                    }
                },
                {
                    nameof(_TEB64.WorkingOnBehalfTicket),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(_TEB64.ExceptionCode),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_TEB64.Padding0),
                    new ulong[]
                    {
                        708UL
                    }
                },
                {
                    nameof(_TEB64.ActivationContextStackPointer),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_TEB64.InstrumentationCallbackSp),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_TEB64.InstrumentationCallbackPreviousPc),
                    new ulong[]
                    {
                        728UL
                    }
                },
                {
                    nameof(_TEB64.InstrumentationCallbackPreviousSp),
                    new ulong[]
                    {
                        736UL
                    }
                },
                {
                    nameof(_TEB64.TxFsContext),
                    new ulong[]
                    {
                        744UL
                    }
                },
                {
                    nameof(_TEB64.InstrumentationCallbackDisabled),
                    new ulong[]
                    {
                        748UL
                    }
                },
                {
                    nameof(_TEB64.UnalignedLoadStoreExceptions),
                    new ulong[]
                    {
                        749UL
                    }
                },
                {
                    nameof(_TEB64.Padding1),
                    new ulong[]
                    {
                        750UL
                    }
                },
                {
                    nameof(_TEB64.GdiTebBatch),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_TEB64.RealClientId),
                    new ulong[]
                    {
                        2008UL
                    }
                },
                {
                    nameof(_TEB64.GdiCachedProcessHandle),
                    new ulong[]
                    {
                        2024UL
                    }
                },
                {
                    nameof(_TEB64.GdiClientPID),
                    new ulong[]
                    {
                        2032UL
                    }
                },
                {
                    nameof(_TEB64.GdiClientTID),
                    new ulong[]
                    {
                        2036UL
                    }
                },
                {
                    nameof(_TEB64.GdiThreadLocalInfo),
                    new ulong[]
                    {
                        2040UL
                    }
                },
                {
                    nameof(_TEB64.Win32ClientInfo),
                    new ulong[]
                    {
                        2048UL
                    }
                },
                {
                    nameof(_TEB64.glDispatchTable),
                    new ulong[]
                    {
                        2544UL
                    }
                },
                {
                    nameof(_TEB64.glReserved1),
                    new ulong[]
                    {
                        4408UL
                    }
                },
                {
                    nameof(_TEB64.glReserved2),
                    new ulong[]
                    {
                        4640UL
                    }
                },
                {
                    nameof(_TEB64.glSectionInfo),
                    new ulong[]
                    {
                        4648UL
                    }
                },
                {
                    nameof(_TEB64.glSection),
                    new ulong[]
                    {
                        4656UL
                    }
                },
                {
                    nameof(_TEB64.glTable),
                    new ulong[]
                    {
                        4664UL
                    }
                },
                {
                    nameof(_TEB64.glCurrentRC),
                    new ulong[]
                    {
                        4672UL
                    }
                },
                {
                    nameof(_TEB64.glContext),
                    new ulong[]
                    {
                        4680UL
                    }
                },
                {
                    nameof(_TEB64.LastStatusValue),
                    new ulong[]
                    {
                        4688UL
                    }
                },
                {
                    nameof(_TEB64.Padding2),
                    new ulong[]
                    {
                        4692UL
                    }
                },
                {
                    nameof(_TEB64.StaticUnicodeString),
                    new ulong[]
                    {
                        4696UL
                    }
                },
                {
                    nameof(_TEB64.StaticUnicodeBuffer),
                    new ulong[]
                    {
                        4712UL
                    }
                },
                {
                    nameof(_TEB64.Padding3),
                    new ulong[]
                    {
                        5234UL
                    }
                },
                {
                    nameof(_TEB64.DeallocationStack),
                    new ulong[]
                    {
                        5240UL
                    }
                },
                {
                    nameof(_TEB64.TlsSlots),
                    new ulong[]
                    {
                        5248UL
                    }
                },
                {
                    nameof(_TEB64.TlsLinks),
                    new ulong[]
                    {
                        5760UL
                    }
                },
                {
                    nameof(_TEB64.Vdm),
                    new ulong[]
                    {
                        5776UL
                    }
                },
                {
                    nameof(_TEB64.ReservedForNtRpc),
                    new ulong[]
                    {
                        5784UL
                    }
                },
                {
                    nameof(_TEB64.DbgSsReserved),
                    new ulong[]
                    {
                        5792UL
                    }
                },
                {
                    nameof(_TEB64.HardErrorMode),
                    new ulong[]
                    {
                        5808UL
                    }
                },
                {
                    nameof(_TEB64.Padding4),
                    new ulong[]
                    {
                        5812UL
                    }
                },
                {
                    nameof(_TEB64.Instrumentation),
                    new ulong[]
                    {
                        5816UL
                    }
                },
                {
                    nameof(_TEB64.ActivityId),
                    new ulong[]
                    {
                        5904UL
                    }
                },
                {
                    nameof(_TEB64.SubProcessTag),
                    new ulong[]
                    {
                        5920UL
                    }
                },
                {
                    nameof(_TEB64.PerflibData),
                    new ulong[]
                    {
                        5928UL
                    }
                },
                {
                    nameof(_TEB64.EtwTraceData),
                    new ulong[]
                    {
                        5936UL
                    }
                },
                {
                    nameof(_TEB64.WinSockData),
                    new ulong[]
                    {
                        5944UL
                    }
                },
                {
                    nameof(_TEB64.GdiBatchCount),
                    new ulong[]
                    {
                        5952UL
                    }
                },
                {
                    nameof(_TEB64.CurrentIdealProcessor),
                    new ulong[]
                    {
                        5956UL
                    }
                },
                {
                    nameof(_TEB64.IdealProcessorValue),
                    new ulong[]
                    {
                        5956UL
                    }
                },
                {
                    nameof(_TEB64.ReservedPad0),
                    new ulong[]
                    {
                        5956UL
                    }
                },
                {
                    nameof(_TEB64.ReservedPad1),
                    new ulong[]
                    {
                        5957UL
                    }
                },
                {
                    nameof(_TEB64.ReservedPad2),
                    new ulong[]
                    {
                        5958UL
                    }
                },
                {
                    nameof(_TEB64.IdealProcessor),
                    new ulong[]
                    {
                        5959UL
                    }
                },
                {
                    nameof(_TEB64.GuaranteedStackBytes),
                    new ulong[]
                    {
                        5960UL
                    }
                },
                {
                    nameof(_TEB64.Padding5),
                    new ulong[]
                    {
                        5964UL
                    }
                },
                {
                    nameof(_TEB64.ReservedForPerf),
                    new ulong[]
                    {
                        5968UL
                    }
                },
                {
                    nameof(_TEB64.ReservedForOle),
                    new ulong[]
                    {
                        5976UL
                    }
                },
                {
                    nameof(_TEB64.WaitingOnLoaderLock),
                    new ulong[]
                    {
                        5984UL
                    }
                },
                {
                    nameof(_TEB64.Padding6),
                    new ulong[]
                    {
                        5988UL
                    }
                },
                {
                    nameof(_TEB64.SavedPriorityState),
                    new ulong[]
                    {
                        5992UL
                    }
                },
                {
                    nameof(_TEB64.ReservedForCodeCoverage),
                    new ulong[]
                    {
                        6000UL
                    }
                },
                {
                    nameof(_TEB64.ThreadPoolData),
                    new ulong[]
                    {
                        6008UL
                    }
                },
                {
                    nameof(_TEB64.TlsExpansionSlots),
                    new ulong[]
                    {
                        6016UL
                    }
                },
                {
                    nameof(_TEB64.ChpeV2CpuAreaInfo),
                    new ulong[]
                    {
                        6024UL
                    }
                },
                {
                    nameof(_TEB64.Unused),
                    new ulong[]
                    {
                        6032UL
                    }
                },
                {
                    nameof(_TEB64.MuiGeneration),
                    new ulong[]
                    {
                        6040UL
                    }
                },
                {
                    nameof(_TEB64.IsImpersonating),
                    new ulong[]
                    {
                        6044UL
                    }
                },
                {
                    nameof(_TEB64.NlsCache),
                    new ulong[]
                    {
                        6048UL
                    }
                },
                {
                    nameof(_TEB64.pShimData),
                    new ulong[]
                    {
                        6056UL
                    }
                },
                {
                    nameof(_TEB64.HeapData),
                    new ulong[]
                    {
                        6064UL
                    }
                },
                {
                    nameof(_TEB64.Padding7),
                    new ulong[]
                    {
                        6068UL
                    }
                },
                {
                    nameof(_TEB64.CurrentTransactionHandle),
                    new ulong[]
                    {
                        6072UL
                    }
                },
                {
                    nameof(_TEB64.ActiveFrame),
                    new ulong[]
                    {
                        6080UL
                    }
                },
                {
                    nameof(_TEB64.FlsData),
                    new ulong[]
                    {
                        6088UL
                    }
                },
                {
                    nameof(_TEB64.PreferredLanguages),
                    new ulong[]
                    {
                        6096UL
                    }
                },
                {
                    nameof(_TEB64.UserPrefLanguages),
                    new ulong[]
                    {
                        6104UL
                    }
                },
                {
                    nameof(_TEB64.MergedPrefLanguages),
                    new ulong[]
                    {
                        6112UL
                    }
                },
                {
                    nameof(_TEB64.MuiImpersonation),
                    new ulong[]
                    {
                        6120UL
                    }
                },
                {
                    nameof(_TEB64.CrossTebFlags),
                    new ulong[]
                    {
                        6124UL
                    }
                },
                {
                    nameof(_TEB64.SpareCrossTebBits),
                    new ulong[]
                    {
                        6124UL
                    }
                },
                {
                    nameof(_TEB64.SameTebFlags),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.SafeThunkCall),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.InDebugPrint),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.HasFiberData),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.SkipThreadAttach),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.WerInShipAssertCode),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.RanProcessInit),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.ClonedThread),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.SuppressDebugMsg),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.DisableUserStackWalk),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.RtlExceptionAttached),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.InitialThread),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.SessionAware),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.LoadOwner),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.LoaderWorker),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.SkipLoaderInit),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.SkipFileAPIBrokering),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB64.TxnScopeEnterCallback),
                    new ulong[]
                    {
                        6128UL
                    }
                },
                {
                    nameof(_TEB64.TxnScopeExitCallback),
                    new ulong[]
                    {
                        6136UL
                    }
                },
                {
                    nameof(_TEB64.TxnScopeContext),
                    new ulong[]
                    {
                        6144UL
                    }
                },
                {
                    nameof(_TEB64.LockCount),
                    new ulong[]
                    {
                        6152UL
                    }
                },
                {
                    nameof(_TEB64.WowTebOffset),
                    new ulong[]
                    {
                        6156UL
                    }
                },
                {
                    nameof(_TEB64.ResourceRetValue),
                    new ulong[]
                    {
                        6160UL
                    }
                },
                {
                    nameof(_TEB64.ReservedForWdf),
                    new ulong[]
                    {
                        6168UL
                    }
                },
                {
                    nameof(_TEB64.ReservedForCrt),
                    new ulong[]
                    {
                        6176UL
                    }
                },
                {
                    nameof(_TEB64.EffectiveContainerId),
                    new ulong[]
                    {
                        6184UL
                    }
                },
                {
                    nameof(_TEB64.LastSleepCounter),
                    new ulong[]
                    {
                        6200UL
                    }
                },
                {
                    nameof(_TEB64.SpinCallCount),
                    new ulong[]
                    {
                        6208UL
                    }
                },
                {
                    nameof(_TEB64.Padding8),
                    new ulong[]
                    {
                        6212UL
                    }
                },
                {
                    nameof(_TEB64.ExtendedFeatureDisableMask),
                    new ulong[]
                    {
                        6216UL
                    }
                },
                {
                    nameof(_TEB64.SchedulerSharedDataSlot),
                    new ulong[]
                    {
                        6224UL
                    }
                },
                {
                    nameof(_TEB64.HeapWalkContext),
                    new ulong[]
                    {
                        6232UL
                    }
                },
                {
                    nameof(_TEB64.PrimaryGroupAffinity),
                    new ulong[]
                    {
                        6240UL
                    }
                },
                {
                    nameof(_TEB64.Rcu),
                    new ulong[]
                    {
                        6256UL
                    }
                }
            };
            Register<_TEB64>((mem, ptr) => new _TEB64(mem, ptr), offsets);
        }
    }
}