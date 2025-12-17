using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TEB")]
    public sealed class _TEB : DynamicStructure
    {
        public _NT_TIB NtTib { get; }
        public IntPtr EnvironmentPointer { get; }
        public _CLIENT_ID ClientId { get; }
        public IntPtr ActiveRpcHandle { get; }
        public IntPtr ThreadLocalStoragePointer { get; }
        public IntPtr ProcessEnvironmentBlock { get; }
        public uint LastErrorValue { get; }
        public uint CountOfOwnedCriticalSections { get; }
        public IntPtr CsrClientThread { get; }
        public IntPtr Win32ThreadInfo { get; }
        public uint[] User32Reserved { get; }
        public uint[] UserReserved { get; }
        public IntPtr WOW32Reserved { get; }
        public uint CurrentLocale { get; }
        public uint FpSoftwareStatusRegister { get; }
        public byte[] ReservedForDebuggerInstrumentation { get; }
        public byte[] SystemReserved1 { get; }
        public IntPtr HeapFlsData { get; }
        public ulong[] RngState { get; }
        public sbyte PlaceholderCompatibilityMode { get; }
        public byte PlaceholderHydrationAlwaysExplicit { get; }
        public sbyte[] PlaceholderReserved { get; }
        public uint ProxiedProcessId { get; }
        public _ACTIVATION_CONTEXT_STACK _ActivationStack { get; }
        public byte[] WorkingOnBehalfTicket { get; }
        public int ExceptionCode { get; }
        public byte[] Padding0 { get; }
        public IntPtr ActivationContextStackPointer { get; }
        public ulong InstrumentationCallbackSp { get; }
        public ulong InstrumentationCallbackPreviousPc { get; }
        public ulong InstrumentationCallbackPreviousSp { get; }
        public uint TxFsContext { get; }
        public byte InstrumentationCallbackDisabled { get; }
        public byte UnalignedLoadStoreExceptions { get; }
        public byte[] Padding1 { get; }
        public _GDI_TEB_BATCH GdiTebBatch { get; }
        public _CLIENT_ID RealClientId { get; }
        public IntPtr GdiCachedProcessHandle { get; }
        public uint GdiClientPID { get; }
        public uint GdiClientTID { get; }
        public IntPtr GdiThreadLocalInfo { get; }
        public ulong[] Win32ClientInfo { get; }
        public byte[] glDispatchTable { get; }
        public ulong[] glReserved1 { get; }
        public IntPtr glReserved2 { get; }
        public IntPtr glSectionInfo { get; }
        public IntPtr glSection { get; }
        public IntPtr glTable { get; }
        public IntPtr glCurrentRC { get; }
        public IntPtr glContext { get; }
        public uint LastStatusValue { get; }
        public byte[] Padding2 { get; }
        public _UNICODE_STRING StaticUnicodeString { get; }
        public short[] StaticUnicodeBuffer { get; }
        public byte[] Padding3 { get; }
        public IntPtr DeallocationStack { get; }
        public byte[] TlsSlots { get; }
        public _LIST_ENTRY TlsLinks { get; }
        public IntPtr Vdm { get; }
        public IntPtr ReservedForNtRpc { get; }
        public byte[] DbgSsReserved { get; }
        public uint HardErrorMode { get; }
        public byte[] Padding4 { get; }
        public byte[] Instrumentation { get; }
        public _GUID ActivityId { get; }
        public IntPtr SubProcessTag { get; }
        public IntPtr PerflibData { get; }
        public IntPtr EtwTraceData { get; }
        public IntPtr WinSockData { get; }
        public uint GdiBatchCount { get; }
        public _PROCESSOR_NUMBER CurrentIdealProcessor { get; }
        public uint IdealProcessorValue { get; }
        public byte ReservedPad0 { get; }
        public byte ReservedPad1 { get; }
        public byte ReservedPad2 { get; }
        public byte IdealProcessor { get; }
        public uint GuaranteedStackBytes { get; }
        public byte[] Padding5 { get; }
        public IntPtr ReservedForPerf { get; }
        public IntPtr ReservedForOle { get; }
        public uint WaitingOnLoaderLock { get; }
        public byte[] Padding6 { get; }
        public IntPtr SavedPriorityState { get; }
        public ulong ReservedForCodeCoverage { get; }
        public IntPtr ThreadPoolData { get; }
        public IntPtr TlsExpansionSlots { get; }
        public IntPtr ChpeV2CpuAreaInfo { get; }
        public IntPtr Unused { get; }
        public uint MuiGeneration { get; }
        public uint IsImpersonating { get; }
        public IntPtr NlsCache { get; }
        public IntPtr pShimData { get; }
        public uint HeapData { get; }
        public byte[] Padding7 { get; }
        public IntPtr CurrentTransactionHandle { get; }
        public IntPtr ActiveFrame { get; }
        public IntPtr FlsData { get; }
        public IntPtr PreferredLanguages { get; }
        public IntPtr UserPrefLanguages { get; }
        public IntPtr MergedPrefLanguages { get; }
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
        public IntPtr TxnScopeEnterCallback { get; }
        public IntPtr TxnScopeExitCallback { get; }
        public IntPtr TxnScopeContext { get; }
        public uint LockCount { get; }
        public int WowTebOffset { get; }
        public IntPtr ResourceRetValue { get; }
        public IntPtr ReservedForWdf { get; }
        public ulong ReservedForCrt { get; }
        public _GUID EffectiveContainerId { get; }
        public ulong LastSleepCounter { get; }
        public uint SpinCallCount { get; }
        public byte[] Padding8 { get; }
        public ulong ExtendedFeatureDisableMask { get; }
        public IntPtr SchedulerSharedDataSlot { get; }
        public IntPtr HeapWalkContext { get; }
        public _GROUP_AFFINITY PrimaryGroupAffinity { get; }
        public uint[] Rcu { get; }

        public _TEB(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TEB()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TEB.NtTib),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TEB.EnvironmentPointer),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_TEB.ClientId),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_TEB.ActiveRpcHandle),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_TEB.ThreadLocalStoragePointer),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TEB.ProcessEnvironmentBlock),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_TEB.LastErrorValue),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_TEB.CountOfOwnedCriticalSections),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_TEB.CsrClientThread),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_TEB.Win32ThreadInfo),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_TEB.User32Reserved),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_TEB.UserReserved),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_TEB.WOW32Reserved),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_TEB.CurrentLocale),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_TEB.FpSoftwareStatusRegister),
                    new ulong[]
                    {
                        268UL
                    }
                },
                {
                    nameof(_TEB.ReservedForDebuggerInstrumentation),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_TEB.SystemReserved1),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_TEB.HeapFlsData),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_TEB.RngState),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_TEB.PlaceholderCompatibilityMode),
                    new ulong[]
                    {
                        640UL
                    }
                },
                {
                    nameof(_TEB.PlaceholderHydrationAlwaysExplicit),
                    new ulong[]
                    {
                        641UL
                    }
                },
                {
                    nameof(_TEB.PlaceholderReserved),
                    new ulong[]
                    {
                        642UL
                    }
                },
                {
                    nameof(_TEB.ProxiedProcessId),
                    new ulong[]
                    {
                        652UL
                    }
                },
                {
                    nameof(_TEB._ActivationStack),
                    new ulong[]
                    {
                        656UL
                    }
                },
                {
                    nameof(_TEB.WorkingOnBehalfTicket),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(_TEB.ExceptionCode),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_TEB.Padding0),
                    new ulong[]
                    {
                        708UL
                    }
                },
                {
                    nameof(_TEB.ActivationContextStackPointer),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_TEB.InstrumentationCallbackSp),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_TEB.InstrumentationCallbackPreviousPc),
                    new ulong[]
                    {
                        728UL
                    }
                },
                {
                    nameof(_TEB.InstrumentationCallbackPreviousSp),
                    new ulong[]
                    {
                        736UL
                    }
                },
                {
                    nameof(_TEB.TxFsContext),
                    new ulong[]
                    {
                        744UL
                    }
                },
                {
                    nameof(_TEB.InstrumentationCallbackDisabled),
                    new ulong[]
                    {
                        748UL
                    }
                },
                {
                    nameof(_TEB.UnalignedLoadStoreExceptions),
                    new ulong[]
                    {
                        749UL
                    }
                },
                {
                    nameof(_TEB.Padding1),
                    new ulong[]
                    {
                        750UL
                    }
                },
                {
                    nameof(_TEB.GdiTebBatch),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_TEB.RealClientId),
                    new ulong[]
                    {
                        2008UL
                    }
                },
                {
                    nameof(_TEB.GdiCachedProcessHandle),
                    new ulong[]
                    {
                        2024UL
                    }
                },
                {
                    nameof(_TEB.GdiClientPID),
                    new ulong[]
                    {
                        2032UL
                    }
                },
                {
                    nameof(_TEB.GdiClientTID),
                    new ulong[]
                    {
                        2036UL
                    }
                },
                {
                    nameof(_TEB.GdiThreadLocalInfo),
                    new ulong[]
                    {
                        2040UL
                    }
                },
                {
                    nameof(_TEB.Win32ClientInfo),
                    new ulong[]
                    {
                        2048UL
                    }
                },
                {
                    nameof(_TEB.glDispatchTable),
                    new ulong[]
                    {
                        2544UL
                    }
                },
                {
                    nameof(_TEB.glReserved1),
                    new ulong[]
                    {
                        4408UL
                    }
                },
                {
                    nameof(_TEB.glReserved2),
                    new ulong[]
                    {
                        4640UL
                    }
                },
                {
                    nameof(_TEB.glSectionInfo),
                    new ulong[]
                    {
                        4648UL
                    }
                },
                {
                    nameof(_TEB.glSection),
                    new ulong[]
                    {
                        4656UL
                    }
                },
                {
                    nameof(_TEB.glTable),
                    new ulong[]
                    {
                        4664UL
                    }
                },
                {
                    nameof(_TEB.glCurrentRC),
                    new ulong[]
                    {
                        4672UL
                    }
                },
                {
                    nameof(_TEB.glContext),
                    new ulong[]
                    {
                        4680UL
                    }
                },
                {
                    nameof(_TEB.LastStatusValue),
                    new ulong[]
                    {
                        4688UL
                    }
                },
                {
                    nameof(_TEB.Padding2),
                    new ulong[]
                    {
                        4692UL
                    }
                },
                {
                    nameof(_TEB.StaticUnicodeString),
                    new ulong[]
                    {
                        4696UL
                    }
                },
                {
                    nameof(_TEB.StaticUnicodeBuffer),
                    new ulong[]
                    {
                        4712UL
                    }
                },
                {
                    nameof(_TEB.Padding3),
                    new ulong[]
                    {
                        5234UL
                    }
                },
                {
                    nameof(_TEB.DeallocationStack),
                    new ulong[]
                    {
                        5240UL
                    }
                },
                {
                    nameof(_TEB.TlsSlots),
                    new ulong[]
                    {
                        5248UL
                    }
                },
                {
                    nameof(_TEB.TlsLinks),
                    new ulong[]
                    {
                        5760UL
                    }
                },
                {
                    nameof(_TEB.Vdm),
                    new ulong[]
                    {
                        5776UL
                    }
                },
                {
                    nameof(_TEB.ReservedForNtRpc),
                    new ulong[]
                    {
                        5784UL
                    }
                },
                {
                    nameof(_TEB.DbgSsReserved),
                    new ulong[]
                    {
                        5792UL
                    }
                },
                {
                    nameof(_TEB.HardErrorMode),
                    new ulong[]
                    {
                        5808UL
                    }
                },
                {
                    nameof(_TEB.Padding4),
                    new ulong[]
                    {
                        5812UL
                    }
                },
                {
                    nameof(_TEB.Instrumentation),
                    new ulong[]
                    {
                        5816UL
                    }
                },
                {
                    nameof(_TEB.ActivityId),
                    new ulong[]
                    {
                        5904UL
                    }
                },
                {
                    nameof(_TEB.SubProcessTag),
                    new ulong[]
                    {
                        5920UL
                    }
                },
                {
                    nameof(_TEB.PerflibData),
                    new ulong[]
                    {
                        5928UL
                    }
                },
                {
                    nameof(_TEB.EtwTraceData),
                    new ulong[]
                    {
                        5936UL
                    }
                },
                {
                    nameof(_TEB.WinSockData),
                    new ulong[]
                    {
                        5944UL
                    }
                },
                {
                    nameof(_TEB.GdiBatchCount),
                    new ulong[]
                    {
                        5952UL
                    }
                },
                {
                    nameof(_TEB.CurrentIdealProcessor),
                    new ulong[]
                    {
                        5956UL
                    }
                },
                {
                    nameof(_TEB.IdealProcessorValue),
                    new ulong[]
                    {
                        5956UL
                    }
                },
                {
                    nameof(_TEB.ReservedPad0),
                    new ulong[]
                    {
                        5956UL
                    }
                },
                {
                    nameof(_TEB.ReservedPad1),
                    new ulong[]
                    {
                        5957UL
                    }
                },
                {
                    nameof(_TEB.ReservedPad2),
                    new ulong[]
                    {
                        5958UL
                    }
                },
                {
                    nameof(_TEB.IdealProcessor),
                    new ulong[]
                    {
                        5959UL
                    }
                },
                {
                    nameof(_TEB.GuaranteedStackBytes),
                    new ulong[]
                    {
                        5960UL
                    }
                },
                {
                    nameof(_TEB.Padding5),
                    new ulong[]
                    {
                        5964UL
                    }
                },
                {
                    nameof(_TEB.ReservedForPerf),
                    new ulong[]
                    {
                        5968UL
                    }
                },
                {
                    nameof(_TEB.ReservedForOle),
                    new ulong[]
                    {
                        5976UL
                    }
                },
                {
                    nameof(_TEB.WaitingOnLoaderLock),
                    new ulong[]
                    {
                        5984UL
                    }
                },
                {
                    nameof(_TEB.Padding6),
                    new ulong[]
                    {
                        5988UL
                    }
                },
                {
                    nameof(_TEB.SavedPriorityState),
                    new ulong[]
                    {
                        5992UL
                    }
                },
                {
                    nameof(_TEB.ReservedForCodeCoverage),
                    new ulong[]
                    {
                        6000UL
                    }
                },
                {
                    nameof(_TEB.ThreadPoolData),
                    new ulong[]
                    {
                        6008UL
                    }
                },
                {
                    nameof(_TEB.TlsExpansionSlots),
                    new ulong[]
                    {
                        6016UL
                    }
                },
                {
                    nameof(_TEB.ChpeV2CpuAreaInfo),
                    new ulong[]
                    {
                        6024UL
                    }
                },
                {
                    nameof(_TEB.Unused),
                    new ulong[]
                    {
                        6032UL
                    }
                },
                {
                    nameof(_TEB.MuiGeneration),
                    new ulong[]
                    {
                        6040UL
                    }
                },
                {
                    nameof(_TEB.IsImpersonating),
                    new ulong[]
                    {
                        6044UL
                    }
                },
                {
                    nameof(_TEB.NlsCache),
                    new ulong[]
                    {
                        6048UL
                    }
                },
                {
                    nameof(_TEB.pShimData),
                    new ulong[]
                    {
                        6056UL
                    }
                },
                {
                    nameof(_TEB.HeapData),
                    new ulong[]
                    {
                        6064UL
                    }
                },
                {
                    nameof(_TEB.Padding7),
                    new ulong[]
                    {
                        6068UL
                    }
                },
                {
                    nameof(_TEB.CurrentTransactionHandle),
                    new ulong[]
                    {
                        6072UL
                    }
                },
                {
                    nameof(_TEB.ActiveFrame),
                    new ulong[]
                    {
                        6080UL
                    }
                },
                {
                    nameof(_TEB.FlsData),
                    new ulong[]
                    {
                        6088UL
                    }
                },
                {
                    nameof(_TEB.PreferredLanguages),
                    new ulong[]
                    {
                        6096UL
                    }
                },
                {
                    nameof(_TEB.UserPrefLanguages),
                    new ulong[]
                    {
                        6104UL
                    }
                },
                {
                    nameof(_TEB.MergedPrefLanguages),
                    new ulong[]
                    {
                        6112UL
                    }
                },
                {
                    nameof(_TEB.MuiImpersonation),
                    new ulong[]
                    {
                        6120UL
                    }
                },
                {
                    nameof(_TEB.CrossTebFlags),
                    new ulong[]
                    {
                        6124UL
                    }
                },
                {
                    nameof(_TEB.SpareCrossTebBits),
                    new ulong[]
                    {
                        6124UL
                    }
                },
                {
                    nameof(_TEB.SameTebFlags),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.SafeThunkCall),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.InDebugPrint),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.HasFiberData),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.SkipThreadAttach),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.WerInShipAssertCode),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.RanProcessInit),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.ClonedThread),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.SuppressDebugMsg),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.DisableUserStackWalk),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.RtlExceptionAttached),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.InitialThread),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.SessionAware),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.LoadOwner),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.LoaderWorker),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.SkipLoaderInit),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.SkipFileAPIBrokering),
                    new ulong[]
                    {
                        6126UL
                    }
                },
                {
                    nameof(_TEB.TxnScopeEnterCallback),
                    new ulong[]
                    {
                        6128UL
                    }
                },
                {
                    nameof(_TEB.TxnScopeExitCallback),
                    new ulong[]
                    {
                        6136UL
                    }
                },
                {
                    nameof(_TEB.TxnScopeContext),
                    new ulong[]
                    {
                        6144UL
                    }
                },
                {
                    nameof(_TEB.LockCount),
                    new ulong[]
                    {
                        6152UL
                    }
                },
                {
                    nameof(_TEB.WowTebOffset),
                    new ulong[]
                    {
                        6156UL
                    }
                },
                {
                    nameof(_TEB.ResourceRetValue),
                    new ulong[]
                    {
                        6160UL
                    }
                },
                {
                    nameof(_TEB.ReservedForWdf),
                    new ulong[]
                    {
                        6168UL
                    }
                },
                {
                    nameof(_TEB.ReservedForCrt),
                    new ulong[]
                    {
                        6176UL
                    }
                },
                {
                    nameof(_TEB.EffectiveContainerId),
                    new ulong[]
                    {
                        6184UL
                    }
                },
                {
                    nameof(_TEB.LastSleepCounter),
                    new ulong[]
                    {
                        6200UL
                    }
                },
                {
                    nameof(_TEB.SpinCallCount),
                    new ulong[]
                    {
                        6208UL
                    }
                },
                {
                    nameof(_TEB.Padding8),
                    new ulong[]
                    {
                        6212UL
                    }
                },
                {
                    nameof(_TEB.ExtendedFeatureDisableMask),
                    new ulong[]
                    {
                        6216UL
                    }
                },
                {
                    nameof(_TEB.SchedulerSharedDataSlot),
                    new ulong[]
                    {
                        6224UL
                    }
                },
                {
                    nameof(_TEB.HeapWalkContext),
                    new ulong[]
                    {
                        6232UL
                    }
                },
                {
                    nameof(_TEB.PrimaryGroupAffinity),
                    new ulong[]
                    {
                        6240UL
                    }
                },
                {
                    nameof(_TEB.Rcu),
                    new ulong[]
                    {
                        6256UL
                    }
                }
            };
            Register<_TEB>((mem, ptr) => new _TEB(mem, ptr), offsets);
        }
    }
}