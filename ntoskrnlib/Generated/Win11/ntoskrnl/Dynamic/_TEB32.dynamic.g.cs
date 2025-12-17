using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TEB32")]
    public sealed class _TEB32 : DynamicStructure
    {
        public _NT_TIB32 NtTib { get; }
        public uint EnvironmentPointer { get; }
        public _CLIENT_ID32 ClientId { get; }
        public uint ActiveRpcHandle { get; }
        public uint ThreadLocalStoragePointer { get; }
        public uint ProcessEnvironmentBlock { get; }
        public uint LastErrorValue { get; }
        public uint CountOfOwnedCriticalSections { get; }
        public uint CsrClientThread { get; }
        public uint Win32ThreadInfo { get; }
        public uint[] User32Reserved { get; }
        public uint[] UserReserved { get; }
        public uint WOW32Reserved { get; }
        public uint CurrentLocale { get; }
        public uint FpSoftwareStatusRegister { get; }
        public uint[] ReservedForDebuggerInstrumentation { get; }
        public uint[] SystemReserved1 { get; }
        public uint HeapFlsData { get; }
        public uint[] RngState { get; }
        public sbyte PlaceholderCompatibilityMode { get; }
        public byte PlaceholderHydrationAlwaysExplicit { get; }
        public sbyte[] PlaceholderReserved { get; }
        public uint ProxiedProcessId { get; }
        public _ACTIVATION_CONTEXT_STACK32 _ActivationStack { get; }
        public byte[] WorkingOnBehalfTicket { get; }
        public int ExceptionCode { get; }
        public uint ActivationContextStackPointer { get; }
        public uint InstrumentationCallbackSp { get; }
        public uint InstrumentationCallbackPreviousPc { get; }
        public uint InstrumentationCallbackPreviousSp { get; }
        public byte InstrumentationCallbackDisabled { get; }
        public byte[] SpareBytes { get; }
        public uint TxFsContext { get; }
        public _GDI_TEB_BATCH32 GdiTebBatch { get; }
        public _CLIENT_ID32 RealClientId { get; }
        public uint GdiCachedProcessHandle { get; }
        public uint GdiClientPID { get; }
        public uint GdiClientTID { get; }
        public uint GdiThreadLocalInfo { get; }
        public uint[] Win32ClientInfo { get; }
        public uint[] glDispatchTable { get; }
        public uint[] glReserved1 { get; }
        public uint glReserved2 { get; }
        public uint glSectionInfo { get; }
        public uint glSection { get; }
        public uint glTable { get; }
        public uint glCurrentRC { get; }
        public uint glContext { get; }
        public uint LastStatusValue { get; }
        public _STRING32 StaticUnicodeString { get; }
        public short[] StaticUnicodeBuffer { get; }
        public uint DeallocationStack { get; }
        public uint[] TlsSlots { get; }
        public LIST_ENTRY32 TlsLinks { get; }
        public uint Vdm { get; }
        public uint ReservedForNtRpc { get; }
        public uint[] DbgSsReserved { get; }
        public uint HardErrorMode { get; }
        public uint[] Instrumentation { get; }
        public _GUID ActivityId { get; }
        public uint SubProcessTag { get; }
        public uint PerflibData { get; }
        public uint EtwTraceData { get; }
        public uint WinSockData { get; }
        public uint GdiBatchCount { get; }
        public _PROCESSOR_NUMBER CurrentIdealProcessor { get; }
        public uint IdealProcessorValue { get; }
        public byte ReservedPad0 { get; }
        public byte ReservedPad1 { get; }
        public byte ReservedPad2 { get; }
        public byte IdealProcessor { get; }
        public uint GuaranteedStackBytes { get; }
        public uint ReservedForPerf { get; }
        public uint ReservedForOle { get; }
        public uint WaitingOnLoaderLock { get; }
        public uint SavedPriorityState { get; }
        public uint ReservedForCodeCoverage { get; }
        public uint ThreadPoolData { get; }
        public uint TlsExpansionSlots { get; }
        public uint MuiGeneration { get; }
        public uint IsImpersonating { get; }
        public uint NlsCache { get; }
        public uint pShimData { get; }
        public uint HeapData { get; }
        public uint CurrentTransactionHandle { get; }
        public uint ActiveFrame { get; }
        public uint FlsData { get; }
        public uint PreferredLanguages { get; }
        public uint UserPrefLanguages { get; }
        public uint MergedPrefLanguages { get; }
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
        public uint TxnScopeEnterCallback { get; }
        public uint TxnScopeExitCallback { get; }
        public uint TxnScopeContext { get; }
        public uint LockCount { get; }
        public int WowTebOffset { get; }
        public uint ResourceRetValue { get; }
        public uint ReservedForWdf { get; }
        public ulong ReservedForCrt { get; }
        public _GUID EffectiveContainerId { get; }
        public ulong LastSleepCounter { get; }
        public uint SpinCallCount { get; }
        public ulong ExtendedFeatureDisableMask { get; }
        public uint SchedulerSharedDataSlot { get; }
        public uint HeapWalkContext { get; }
        public _GROUP_AFFINITY32 PrimaryGroupAffinity { get; }
        public uint[] Rcu { get; }

        public _TEB32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TEB32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TEB32.NtTib),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TEB32.EnvironmentPointer),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_TEB32.ClientId),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_TEB32.ActiveRpcHandle),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_TEB32.ThreadLocalStoragePointer),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_TEB32.ProcessEnvironmentBlock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_TEB32.LastErrorValue),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_TEB32.CountOfOwnedCriticalSections),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_TEB32.CsrClientThread),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_TEB32.Win32ThreadInfo),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_TEB32.User32Reserved),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_TEB32.UserReserved),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_TEB32.WOW32Reserved),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_TEB32.CurrentLocale),
                    new ulong[]
                    {
                        196UL
                    }
                },
                {
                    nameof(_TEB32.FpSoftwareStatusRegister),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_TEB32.ReservedForDebuggerInstrumentation),
                    new ulong[]
                    {
                        204UL
                    }
                },
                {
                    nameof(_TEB32.SystemReserved1),
                    new ulong[]
                    {
                        268UL
                    }
                },
                {
                    nameof(_TEB32.HeapFlsData),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_TEB32.RngState),
                    new ulong[]
                    {
                        356UL
                    }
                },
                {
                    nameof(_TEB32.PlaceholderCompatibilityMode),
                    new ulong[]
                    {
                        372UL
                    }
                },
                {
                    nameof(_TEB32.PlaceholderHydrationAlwaysExplicit),
                    new ulong[]
                    {
                        373UL
                    }
                },
                {
                    nameof(_TEB32.PlaceholderReserved),
                    new ulong[]
                    {
                        374UL
                    }
                },
                {
                    nameof(_TEB32.ProxiedProcessId),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_TEB32._ActivationStack),
                    new ulong[]
                    {
                        388UL
                    }
                },
                {
                    nameof(_TEB32.WorkingOnBehalfTicket),
                    new ulong[]
                    {
                        412UL
                    }
                },
                {
                    nameof(_TEB32.ExceptionCode),
                    new ulong[]
                    {
                        420UL
                    }
                },
                {
                    nameof(_TEB32.ActivationContextStackPointer),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_TEB32.InstrumentationCallbackSp),
                    new ulong[]
                    {
                        428UL
                    }
                },
                {
                    nameof(_TEB32.InstrumentationCallbackPreviousPc),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_TEB32.InstrumentationCallbackPreviousSp),
                    new ulong[]
                    {
                        436UL
                    }
                },
                {
                    nameof(_TEB32.InstrumentationCallbackDisabled),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_TEB32.SpareBytes),
                    new ulong[]
                    {
                        441UL
                    }
                },
                {
                    nameof(_TEB32.TxFsContext),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_TEB32.GdiTebBatch),
                    new ulong[]
                    {
                        468UL
                    }
                },
                {
                    nameof(_TEB32.RealClientId),
                    new ulong[]
                    {
                        1716UL
                    }
                },
                {
                    nameof(_TEB32.GdiCachedProcessHandle),
                    new ulong[]
                    {
                        1724UL
                    }
                },
                {
                    nameof(_TEB32.GdiClientPID),
                    new ulong[]
                    {
                        1728UL
                    }
                },
                {
                    nameof(_TEB32.GdiClientTID),
                    new ulong[]
                    {
                        1732UL
                    }
                },
                {
                    nameof(_TEB32.GdiThreadLocalInfo),
                    new ulong[]
                    {
                        1736UL
                    }
                },
                {
                    nameof(_TEB32.Win32ClientInfo),
                    new ulong[]
                    {
                        1740UL
                    }
                },
                {
                    nameof(_TEB32.glDispatchTable),
                    new ulong[]
                    {
                        1988UL
                    }
                },
                {
                    nameof(_TEB32.glReserved1),
                    new ulong[]
                    {
                        2920UL
                    }
                },
                {
                    nameof(_TEB32.glReserved2),
                    new ulong[]
                    {
                        3036UL
                    }
                },
                {
                    nameof(_TEB32.glSectionInfo),
                    new ulong[]
                    {
                        3040UL
                    }
                },
                {
                    nameof(_TEB32.glSection),
                    new ulong[]
                    {
                        3044UL
                    }
                },
                {
                    nameof(_TEB32.glTable),
                    new ulong[]
                    {
                        3048UL
                    }
                },
                {
                    nameof(_TEB32.glCurrentRC),
                    new ulong[]
                    {
                        3052UL
                    }
                },
                {
                    nameof(_TEB32.glContext),
                    new ulong[]
                    {
                        3056UL
                    }
                },
                {
                    nameof(_TEB32.LastStatusValue),
                    new ulong[]
                    {
                        3060UL
                    }
                },
                {
                    nameof(_TEB32.StaticUnicodeString),
                    new ulong[]
                    {
                        3064UL
                    }
                },
                {
                    nameof(_TEB32.StaticUnicodeBuffer),
                    new ulong[]
                    {
                        3072UL
                    }
                },
                {
                    nameof(_TEB32.DeallocationStack),
                    new ulong[]
                    {
                        3596UL
                    }
                },
                {
                    nameof(_TEB32.TlsSlots),
                    new ulong[]
                    {
                        3600UL
                    }
                },
                {
                    nameof(_TEB32.TlsLinks),
                    new ulong[]
                    {
                        3856UL
                    }
                },
                {
                    nameof(_TEB32.Vdm),
                    new ulong[]
                    {
                        3864UL
                    }
                },
                {
                    nameof(_TEB32.ReservedForNtRpc),
                    new ulong[]
                    {
                        3868UL
                    }
                },
                {
                    nameof(_TEB32.DbgSsReserved),
                    new ulong[]
                    {
                        3872UL
                    }
                },
                {
                    nameof(_TEB32.HardErrorMode),
                    new ulong[]
                    {
                        3880UL
                    }
                },
                {
                    nameof(_TEB32.Instrumentation),
                    new ulong[]
                    {
                        3884UL
                    }
                },
                {
                    nameof(_TEB32.ActivityId),
                    new ulong[]
                    {
                        3920UL
                    }
                },
                {
                    nameof(_TEB32.SubProcessTag),
                    new ulong[]
                    {
                        3936UL
                    }
                },
                {
                    nameof(_TEB32.PerflibData),
                    new ulong[]
                    {
                        3940UL
                    }
                },
                {
                    nameof(_TEB32.EtwTraceData),
                    new ulong[]
                    {
                        3944UL
                    }
                },
                {
                    nameof(_TEB32.WinSockData),
                    new ulong[]
                    {
                        3948UL
                    }
                },
                {
                    nameof(_TEB32.GdiBatchCount),
                    new ulong[]
                    {
                        3952UL
                    }
                },
                {
                    nameof(_TEB32.CurrentIdealProcessor),
                    new ulong[]
                    {
                        3956UL
                    }
                },
                {
                    nameof(_TEB32.IdealProcessorValue),
                    new ulong[]
                    {
                        3956UL
                    }
                },
                {
                    nameof(_TEB32.ReservedPad0),
                    new ulong[]
                    {
                        3956UL
                    }
                },
                {
                    nameof(_TEB32.ReservedPad1),
                    new ulong[]
                    {
                        3957UL
                    }
                },
                {
                    nameof(_TEB32.ReservedPad2),
                    new ulong[]
                    {
                        3958UL
                    }
                },
                {
                    nameof(_TEB32.IdealProcessor),
                    new ulong[]
                    {
                        3959UL
                    }
                },
                {
                    nameof(_TEB32.GuaranteedStackBytes),
                    new ulong[]
                    {
                        3960UL
                    }
                },
                {
                    nameof(_TEB32.ReservedForPerf),
                    new ulong[]
                    {
                        3964UL
                    }
                },
                {
                    nameof(_TEB32.ReservedForOle),
                    new ulong[]
                    {
                        3968UL
                    }
                },
                {
                    nameof(_TEB32.WaitingOnLoaderLock),
                    new ulong[]
                    {
                        3972UL
                    }
                },
                {
                    nameof(_TEB32.SavedPriorityState),
                    new ulong[]
                    {
                        3976UL
                    }
                },
                {
                    nameof(_TEB32.ReservedForCodeCoverage),
                    new ulong[]
                    {
                        3980UL
                    }
                },
                {
                    nameof(_TEB32.ThreadPoolData),
                    new ulong[]
                    {
                        3984UL
                    }
                },
                {
                    nameof(_TEB32.TlsExpansionSlots),
                    new ulong[]
                    {
                        3988UL
                    }
                },
                {
                    nameof(_TEB32.MuiGeneration),
                    new ulong[]
                    {
                        3992UL
                    }
                },
                {
                    nameof(_TEB32.IsImpersonating),
                    new ulong[]
                    {
                        3996UL
                    }
                },
                {
                    nameof(_TEB32.NlsCache),
                    new ulong[]
                    {
                        4000UL
                    }
                },
                {
                    nameof(_TEB32.pShimData),
                    new ulong[]
                    {
                        4004UL
                    }
                },
                {
                    nameof(_TEB32.HeapData),
                    new ulong[]
                    {
                        4008UL
                    }
                },
                {
                    nameof(_TEB32.CurrentTransactionHandle),
                    new ulong[]
                    {
                        4012UL
                    }
                },
                {
                    nameof(_TEB32.ActiveFrame),
                    new ulong[]
                    {
                        4016UL
                    }
                },
                {
                    nameof(_TEB32.FlsData),
                    new ulong[]
                    {
                        4020UL
                    }
                },
                {
                    nameof(_TEB32.PreferredLanguages),
                    new ulong[]
                    {
                        4024UL
                    }
                },
                {
                    nameof(_TEB32.UserPrefLanguages),
                    new ulong[]
                    {
                        4028UL
                    }
                },
                {
                    nameof(_TEB32.MergedPrefLanguages),
                    new ulong[]
                    {
                        4032UL
                    }
                },
                {
                    nameof(_TEB32.MuiImpersonation),
                    new ulong[]
                    {
                        4036UL
                    }
                },
                {
                    nameof(_TEB32.CrossTebFlags),
                    new ulong[]
                    {
                        4040UL
                    }
                },
                {
                    nameof(_TEB32.SpareCrossTebBits),
                    new ulong[]
                    {
                        4040UL
                    }
                },
                {
                    nameof(_TEB32.SameTebFlags),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.SafeThunkCall),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.InDebugPrint),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.HasFiberData),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.SkipThreadAttach),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.WerInShipAssertCode),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.RanProcessInit),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.ClonedThread),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.SuppressDebugMsg),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.DisableUserStackWalk),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.RtlExceptionAttached),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.InitialThread),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.SessionAware),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.LoadOwner),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.LoaderWorker),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.SkipLoaderInit),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.SkipFileAPIBrokering),
                    new ulong[]
                    {
                        4042UL
                    }
                },
                {
                    nameof(_TEB32.TxnScopeEnterCallback),
                    new ulong[]
                    {
                        4044UL
                    }
                },
                {
                    nameof(_TEB32.TxnScopeExitCallback),
                    new ulong[]
                    {
                        4048UL
                    }
                },
                {
                    nameof(_TEB32.TxnScopeContext),
                    new ulong[]
                    {
                        4052UL
                    }
                },
                {
                    nameof(_TEB32.LockCount),
                    new ulong[]
                    {
                        4056UL
                    }
                },
                {
                    nameof(_TEB32.WowTebOffset),
                    new ulong[]
                    {
                        4060UL
                    }
                },
                {
                    nameof(_TEB32.ResourceRetValue),
                    new ulong[]
                    {
                        4064UL
                    }
                },
                {
                    nameof(_TEB32.ReservedForWdf),
                    new ulong[]
                    {
                        4068UL
                    }
                },
                {
                    nameof(_TEB32.ReservedForCrt),
                    new ulong[]
                    {
                        4072UL
                    }
                },
                {
                    nameof(_TEB32.EffectiveContainerId),
                    new ulong[]
                    {
                        4080UL
                    }
                },
                {
                    nameof(_TEB32.LastSleepCounter),
                    new ulong[]
                    {
                        4096UL
                    }
                },
                {
                    nameof(_TEB32.SpinCallCount),
                    new ulong[]
                    {
                        4104UL
                    }
                },
                {
                    nameof(_TEB32.ExtendedFeatureDisableMask),
                    new ulong[]
                    {
                        4112UL
                    }
                },
                {
                    nameof(_TEB32.SchedulerSharedDataSlot),
                    new ulong[]
                    {
                        4120UL
                    }
                },
                {
                    nameof(_TEB32.HeapWalkContext),
                    new ulong[]
                    {
                        4124UL
                    }
                },
                {
                    nameof(_TEB32.PrimaryGroupAffinity),
                    new ulong[]
                    {
                        4128UL
                    }
                },
                {
                    nameof(_TEB32.Rcu),
                    new ulong[]
                    {
                        4140UL
                    }
                }
            };
            Register<_TEB32>((mem, ptr) => new _TEB32(mem, ptr), offsets);
        }
    }
}