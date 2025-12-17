using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EPROCESS")]
    public sealed class _EPROCESS : DynamicStructure
    {
        public _KPROCESS Pcb { get; }
        public _EX_PUSH_LOCK ProcessLock { get; }
        public IntPtr UniqueProcessId { get; }
        public _LIST_ENTRY ActiveProcessLinks { get; }
        public _EX_RUNDOWN_REF RundownProtect { get; }
        public uint Flags2 { get; }
        public uint JobNotReallyActive { get; }
        public uint AccountingFolded { get; }
        public uint NewProcessReported { get; }
        public uint ExitProcessReported { get; }
        public uint ReportCommitChanges { get; }
        public uint LastReportMemory { get; }
        public uint ForceWakeCharge { get; }
        public uint CrossSessionCreate { get; }
        public uint NeedsHandleRundown { get; }
        public uint RefTraceEnabled { get; }
        public uint PicoCreated { get; }
        public uint EmptyJobEvaluated { get; }
        public uint DefaultPagePriority { get; }
        public uint PrimaryTokenFrozen { get; }
        public uint ProcessVerifierTarget { get; }
        public uint RestrictSetThreadContext { get; }
        public uint AffinityPermanent { get; }
        public uint AffinityUpdateEnable { get; }
        public uint PropagateNode { get; }
        public uint ExplicitAffinity { get; }
        public uint Flags2Available1 { get; }
        public uint EnableReadVmLogging { get; }
        public uint EnableWriteVmLogging { get; }
        public uint FatalAccessTerminationRequested { get; }
        public uint DisableSystemAllowedCpuSet { get; }
        public uint Flags2Available2 { get; }
        public uint InPrivate { get; }
        public uint Flags { get; }
        public uint CreateReported { get; }
        public uint NoDebugInherit { get; }
        public uint ProcessExiting { get; }
        public uint ProcessDelete { get; }
        public uint ManageExecutableMemoryWrites { get; }
        public uint VmDeleted { get; }
        public uint OutswapEnabled { get; }
        public uint Outswapped { get; }
        public uint FailFastOnCommitFail { get; }
        public uint Wow64VaSpace4Gb { get; }
        public uint AddressSpaceInitialized { get; }
        public uint SetTimerResolution { get; }
        public uint BreakOnTermination { get; }
        public uint DeprioritizeViews { get; }
        public uint WriteWatch { get; }
        public uint ProcessInSession { get; }
        public uint OverrideAddressSpace { get; }
        public uint HasAddressSpace { get; }
        public uint LaunchPrefetched { get; }
        public uint Reserved { get; }
        public uint VmTopDown { get; }
        public uint ImageNotifyDone { get; }
        public uint PdeUpdateNeeded { get; }
        public uint VdmAllowed { get; }
        public uint ProcessRundown { get; }
        public uint ProcessInserted { get; }
        public uint DefaultIoPriority { get; }
        public uint ProcessSelfDelete { get; }
        public uint SetTimerResolutionLink { get; }
        public _LARGE_INTEGER CreateTime { get; }
        public ulong[] ProcessQuotaUsage { get; }
        public ulong[] ProcessQuotaPeak { get; }
        public ulong PeakVirtualSize { get; }
        public ulong VirtualSize { get; }
        public _LIST_ENTRY SessionProcessLinks { get; }
        public IntPtr ExceptionPortData { get; }
        public ulong ExceptionPortValue { get; }
        public ulong ExceptionPortState { get; }
        public _EX_FAST_REF Token { get; }
        public ulong MmReserved { get; }
        public _EX_PUSH_LOCK AddressCreationLock { get; }
        public _EX_PUSH_LOCK PageTableCommitmentLock { get; }
        public IntPtr RotateInProgress { get; }
        public IntPtr ForkInProgress { get; }
        public IntPtr CommitChargeJob { get; }
        public _RTL_AVL_TREE CloneRoot { get; }
        public ulong NumberOfPrivatePages { get; }
        public ulong MmReserved2 { get; }
        public IntPtr Win32Process { get; }
        public IntPtr Job { get; }
        public IntPtr SectionObject { get; }
        public IntPtr SectionBaseAddress { get; }
        public uint Cookie { get; }
        public IntPtr WorkingSetWatch { get; }
        public IntPtr Win32WindowStation { get; }
        public IntPtr InheritedFromUniqueProcessId { get; }
        public ulong OwnerProcessId { get; }
        public IntPtr Peb { get; }
        public IntPtr Session { get; }
        public IntPtr Spare1 { get; }
        public IntPtr QuotaBlock { get; }
        public IntPtr ObjectTable { get; }
        public IntPtr DebugPort { get; }
        public IntPtr WoW64Process { get; }
        public _EX_FAST_REF DeviceMap { get; }
        public IntPtr EtwDataSource { get; }
        public ulong PageDirectoryPte { get; }
        public IntPtr ImageFilePointer { get; }
        public byte[] ImageFileName { get; }
        public byte PriorityClass { get; }
        public IntPtr SecurityPort { get; }
        public _SE_AUDIT_PROCESS_CREATION_INFO SeAuditProcessCreationInfo { get; }
        public _LIST_ENTRY JobLinks { get; }
        public IntPtr HighestUserAddress { get; }
        public _LIST_ENTRY ThreadListHead { get; }
        public uint ActiveThreads { get; }
        public uint ImagePathHash { get; }
        public uint DefaultHardErrorProcessing { get; }
        public int LastThreadExitStatus { get; }
        public _EX_FAST_REF PrefetchTrace { get; }
        public IntPtr LockedPagesList { get; }
        public _LARGE_INTEGER ReadOperationCount { get; }
        public _LARGE_INTEGER WriteOperationCount { get; }
        public _LARGE_INTEGER OtherOperationCount { get; }
        public _LARGE_INTEGER ReadTransferCount { get; }
        public _LARGE_INTEGER WriteTransferCount { get; }
        public _LARGE_INTEGER OtherTransferCount { get; }
        public ulong CommitChargeLimit { get; }
        public ulong CommitCharge { get; }
        public ulong CommitChargePeak { get; }
        public _MMSUPPORT_FULL Vm { get; }
        public _LIST_ENTRY MmProcessLinks { get; }
        public uint ModifiedPageCount { get; }
        public int ExitStatus { get; }
        public _RTL_AVL_TREE VadRoot { get; }
        public IntPtr VadHint { get; }
        public ulong VadCount { get; }
        public ulong VadPhysicalPages { get; }
        public ulong VadPhysicalPagesLimit { get; }
        public _ALPC_PROCESS_CONTEXT AlpcContext { get; }
        public _LIST_ENTRY TimerResolutionLink { get; }
        public IntPtr TimerResolutionStackRecord { get; }
        public uint RequestedTimerResolution { get; }
        public uint SmallestTimerResolution { get; }
        public _LARGE_INTEGER ExitTime { get; }
        public IntPtr InvertedFunctionTable { get; }
        public _EX_PUSH_LOCK InvertedFunctionTableLock { get; }
        public uint ActiveThreadsHighWatermark { get; }
        public uint LargePrivateVadCount { get; }
        public _EX_PUSH_LOCK ThreadListLock { get; }
        public IntPtr WnfContext { get; }
        public IntPtr ServerSilo { get; }
        public byte SignatureLevel { get; }
        public byte SectionSignatureLevel { get; }
        public _PS_PROTECTION Protection { get; }
        public byte HangCount { get; }
        public byte GhostCount { get; }
        public byte PrefilterException { get; }
        public uint Flags3 { get; }
        public uint Minimal { get; }
        public uint ReplacingPageRoot { get; }
        public uint Crashed { get; }
        public uint JobVadsAreTracked { get; }
        public uint VadTrackingDisabled { get; }
        public uint AuxiliaryProcess { get; }
        public uint SubsystemProcess { get; }
        public uint IndirectCpuSets { get; }
        public uint RelinquishedCommit { get; }
        public uint HighGraphicsPriority { get; }
        public uint CommitFailLogged { get; }
        public uint ReserveFailLogged { get; }
        public uint SystemProcess { get; }
        public uint AllImagesAtBasePristineBase { get; }
        public uint AddressPolicyFrozen { get; }
        public uint ProcessFirstResume { get; }
        public uint ForegroundExternal { get; }
        public uint ForegroundSystem { get; }
        public uint HighMemoryPriority { get; }
        public uint EnableProcessSuspendResumeLogging { get; }
        public uint EnableThreadSuspendResumeLogging { get; }
        public uint SecurityDomainChanged { get; }
        public uint SecurityFreezeComplete { get; }
        public uint VmProcessorHost { get; }
        public uint VmProcessorHostTransition { get; }
        public uint AltSyscall { get; }
        public uint TimerResolutionIgnore { get; }
        public uint DisallowUserTerminate { get; }
        public uint EnableProcessRemoteExecProtectVmLogging { get; }
        public uint EnableProcessLocalExecProtectVmLogging { get; }
        public uint MemoryCompressionProcess { get; }
        public uint EnableProcessImpersonationLogging { get; }
        public int DeviceAsid { get; }
        public IntPtr SvmData { get; }
        public _EX_PUSH_LOCK SvmProcessLock { get; }
        public ulong SvmLock { get; }
        public _LIST_ENTRY SvmProcessDeviceListHead { get; }
        public ulong LastFreezeInterruptTime { get; }
        public IntPtr DiskCounters { get; }
        public IntPtr PicoContext { get; }
        public IntPtr EnclaveTable { get; }
        public ulong EnclaveNumber { get; }
        public _EX_PUSH_LOCK EnclaveLock { get; }
        public uint HighPriorityFaultsAllowed { get; }
        public IntPtr EnergyContext { get; }
        public IntPtr VmContext { get; }
        public ulong SequenceNumber { get; }
        public ulong CreateInterruptTime { get; }
        public ulong CreateUnbiasedInterruptTime { get; }
        public ulong TotalUnbiasedFrozenTime { get; }
        public ulong LastAppStateUpdateTime { get; }
        public ulong LastAppStateUptime { get; }
        public ulong LastAppState { get; }
        public ulong SharedCommitCharge { get; }
        public _EX_PUSH_LOCK SharedCommitLock { get; }
        public _LIST_ENTRY SharedCommitLinks { get; }
        public ulong AllowedCpuSets { get; }
        public ulong DefaultCpuSets { get; }
        public IntPtr AllowedCpuSetsIndirect { get; }
        public IntPtr DefaultCpuSetsIndirect { get; }
        public IntPtr DiskIoAttribution { get; }
        public IntPtr DxgProcess { get; }
        public uint Win32KFilterSet { get; }
        public ushort Machine { get; }
        public byte MmSlabIdentity { get; }
        public byte Spare0 { get; }
        public _PS_INTERLOCKED_TIMER_DELAY_VALUES ProcessTimerDelay { get; }
        public uint KTimerSets { get; }
        public uint KTimer2Sets { get; }
        public uint ThreadTimerSets { get; }
        public ulong VirtualTimerListLock { get; }
        public _LIST_ENTRY VirtualTimerListHead { get; }
        public _WNF_STATE_NAME WakeChannel { get; }
        public _PS_PROCESS_WAKE_INFORMATION WakeInfo { get; }
        public uint MitigationFlags { get; }
        public _unnamed_tag_ MitigationFlagsValues { get; }
        public uint MitigationFlags2 { get; }
        public _unnamed_tag_ MitigationFlags2Values { get; }
        public IntPtr PartitionObject { get; }
        public ulong SecurityDomain { get; }
        public ulong ParentSecurityDomain { get; }
        public IntPtr CoverageSamplerContext { get; }
        public IntPtr MmHotPatchContext { get; }
        public _RTL_AVL_TREE DynamicEHContinuationTargetsTree { get; }
        public _EX_PUSH_LOCK DynamicEHContinuationTargetsLock { get; }
        public _PS_DYNAMIC_ENFORCED_ADDRESS_RANGES DynamicEnforcedCetCompatibleRanges { get; }
        public uint DisabledComponentFlags { get; }
        public int PageCombineSequence { get; }
        public _EX_PUSH_LOCK EnableOptionalXStateFeaturesLock { get; }
        public IntPtr PathRedirectionHashes { get; }
        public IntPtr SyscallProvider { get; }
        public _LIST_ENTRY SyscallProviderProcessLinks { get; }
        public _PSP_SYSCALL_PROVIDER_DISPATCH_CONTEXT SyscallProviderDispatchContext { get; }
        public uint MitigationFlags3 { get; }
        public _unnamed_tag_ MitigationFlags3Values { get; }
        public uint Flags4 { get; }
        public uint ThreadWasActive { get; }
        public uint MinimalTerminate { get; }
        public uint ImageExpansionDisable { get; }
        public uint SessionFirstProcess { get; }
        public uint SyscallUsage { get; }
        public _unnamed_tag_ SyscallUsageValues { get; }
        public int SupervisorDeviceAsid { get; }
        public IntPtr SupervisorSvmData { get; }
        public IntPtr NetworkCounters { get; }
        public _PROCESS_EXECUTION Execution { get; }
        public IntPtr ThreadIndexTable { get; }
        public _LIST_ENTRY FreezeWorkLinks { get; }

        public _EPROCESS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EPROCESS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EPROCESS.Pcb),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EPROCESS.ProcessLock),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_EPROCESS.UniqueProcessId),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_EPROCESS.ActiveProcessLinks),
                    new ulong[]
                    {
                        472UL
                    }
                },
                {
                    nameof(_EPROCESS.RundownProtect),
                    new ulong[]
                    {
                        488UL
                    }
                },
                {
                    nameof(_EPROCESS.Flags2),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.JobNotReallyActive),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.AccountingFolded),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.NewProcessReported),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.ExitProcessReported),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.ReportCommitChanges),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.LastReportMemory),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.ForceWakeCharge),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.CrossSessionCreate),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.NeedsHandleRundown),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.RefTraceEnabled),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.PicoCreated),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.EmptyJobEvaluated),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.DefaultPagePriority),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.PrimaryTokenFrozen),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.ProcessVerifierTarget),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.RestrictSetThreadContext),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.AffinityPermanent),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.AffinityUpdateEnable),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.PropagateNode),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.ExplicitAffinity),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.Flags2Available1),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.EnableReadVmLogging),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.EnableWriteVmLogging),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.FatalAccessTerminationRequested),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.DisableSystemAllowedCpuSet),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.Flags2Available2),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.InPrivate),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_EPROCESS.Flags),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.CreateReported),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.NoDebugInherit),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.ProcessExiting),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.ProcessDelete),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.ManageExecutableMemoryWrites),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.VmDeleted),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.OutswapEnabled),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.Outswapped),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.FailFastOnCommitFail),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.Wow64VaSpace4Gb),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.AddressSpaceInitialized),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.SetTimerResolution),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.BreakOnTermination),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.DeprioritizeViews),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.WriteWatch),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.ProcessInSession),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.OverrideAddressSpace),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.HasAddressSpace),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.LaunchPrefetched),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.Reserved),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.VmTopDown),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.ImageNotifyDone),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.PdeUpdateNeeded),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.VdmAllowed),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.ProcessRundown),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.ProcessInserted),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.DefaultIoPriority),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.ProcessSelfDelete),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.SetTimerResolutionLink),
                    new ulong[]
                    {
                        500UL
                    }
                },
                {
                    nameof(_EPROCESS.CreateTime),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_EPROCESS.ProcessQuotaUsage),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_EPROCESS.ProcessQuotaPeak),
                    new ulong[]
                    {
                        528UL
                    }
                },
                {
                    nameof(_EPROCESS.PeakVirtualSize),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(_EPROCESS.VirtualSize),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(_EPROCESS.SessionProcessLinks),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_EPROCESS.ExceptionPortData),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_EPROCESS.ExceptionPortValue),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_EPROCESS.ExceptionPortState),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_EPROCESS.Token),
                    new ulong[]
                    {
                        584UL
                    }
                },
                {
                    nameof(_EPROCESS.MmReserved),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_EPROCESS.AddressCreationLock),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_EPROCESS.PageTableCommitmentLock),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_EPROCESS.RotateInProgress),
                    new ulong[]
                    {
                        616UL
                    }
                },
                {
                    nameof(_EPROCESS.ForkInProgress),
                    new ulong[]
                    {
                        624UL
                    }
                },
                {
                    nameof(_EPROCESS.CommitChargeJob),
                    new ulong[]
                    {
                        632UL
                    }
                },
                {
                    nameof(_EPROCESS.CloneRoot),
                    new ulong[]
                    {
                        640UL
                    }
                },
                {
                    nameof(_EPROCESS.NumberOfPrivatePages),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(_EPROCESS.MmReserved2),
                    new ulong[]
                    {
                        656UL
                    }
                },
                {
                    nameof(_EPROCESS.Win32Process),
                    new ulong[]
                    {
                        664UL
                    }
                },
                {
                    nameof(_EPROCESS.Job),
                    new ulong[]
                    {
                        672UL
                    }
                },
                {
                    nameof(_EPROCESS.SectionObject),
                    new ulong[]
                    {
                        680UL
                    }
                },
                {
                    nameof(_EPROCESS.SectionBaseAddress),
                    new ulong[]
                    {
                        688UL
                    }
                },
                {
                    nameof(_EPROCESS.Cookie),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(_EPROCESS.WorkingSetWatch),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_EPROCESS.Win32WindowStation),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_EPROCESS.InheritedFromUniqueProcessId),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_EPROCESS.OwnerProcessId),
                    new ulong[]
                    {
                        728UL
                    }
                },
                {
                    nameof(_EPROCESS.Peb),
                    new ulong[]
                    {
                        736UL
                    }
                },
                {
                    nameof(_EPROCESS.Session),
                    new ulong[]
                    {
                        744UL
                    }
                },
                {
                    nameof(_EPROCESS.Spare1),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_EPROCESS.QuotaBlock),
                    new ulong[]
                    {
                        760UL
                    }
                },
                {
                    nameof(_EPROCESS.ObjectTable),
                    new ulong[]
                    {
                        768UL
                    }
                },
                {
                    nameof(_EPROCESS.DebugPort),
                    new ulong[]
                    {
                        776UL
                    }
                },
                {
                    nameof(_EPROCESS.WoW64Process),
                    new ulong[]
                    {
                        784UL
                    }
                },
                {
                    nameof(_EPROCESS.DeviceMap),
                    new ulong[]
                    {
                        792UL
                    }
                },
                {
                    nameof(_EPROCESS.EtwDataSource),
                    new ulong[]
                    {
                        800UL
                    }
                },
                {
                    nameof(_EPROCESS.PageDirectoryPte),
                    new ulong[]
                    {
                        808UL
                    }
                },
                {
                    nameof(_EPROCESS.ImageFilePointer),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_EPROCESS.ImageFileName),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_EPROCESS.PriorityClass),
                    new ulong[]
                    {
                        839UL
                    }
                },
                {
                    nameof(_EPROCESS.SecurityPort),
                    new ulong[]
                    {
                        840UL
                    }
                },
                {
                    nameof(_EPROCESS.SeAuditProcessCreationInfo),
                    new ulong[]
                    {
                        848UL
                    }
                },
                {
                    nameof(_EPROCESS.JobLinks),
                    new ulong[]
                    {
                        856UL
                    }
                },
                {
                    nameof(_EPROCESS.HighestUserAddress),
                    new ulong[]
                    {
                        872UL
                    }
                },
                {
                    nameof(_EPROCESS.ThreadListHead),
                    new ulong[]
                    {
                        880UL
                    }
                },
                {
                    nameof(_EPROCESS.ActiveThreads),
                    new ulong[]
                    {
                        896UL
                    }
                },
                {
                    nameof(_EPROCESS.ImagePathHash),
                    new ulong[]
                    {
                        900UL
                    }
                },
                {
                    nameof(_EPROCESS.DefaultHardErrorProcessing),
                    new ulong[]
                    {
                        904UL
                    }
                },
                {
                    nameof(_EPROCESS.LastThreadExitStatus),
                    new ulong[]
                    {
                        908UL
                    }
                },
                {
                    nameof(_EPROCESS.PrefetchTrace),
                    new ulong[]
                    {
                        912UL
                    }
                },
                {
                    nameof(_EPROCESS.LockedPagesList),
                    new ulong[]
                    {
                        920UL
                    }
                },
                {
                    nameof(_EPROCESS.ReadOperationCount),
                    new ulong[]
                    {
                        928UL
                    }
                },
                {
                    nameof(_EPROCESS.WriteOperationCount),
                    new ulong[]
                    {
                        936UL
                    }
                },
                {
                    nameof(_EPROCESS.OtherOperationCount),
                    new ulong[]
                    {
                        944UL
                    }
                },
                {
                    nameof(_EPROCESS.ReadTransferCount),
                    new ulong[]
                    {
                        952UL
                    }
                },
                {
                    nameof(_EPROCESS.WriteTransferCount),
                    new ulong[]
                    {
                        960UL
                    }
                },
                {
                    nameof(_EPROCESS.OtherTransferCount),
                    new ulong[]
                    {
                        968UL
                    }
                },
                {
                    nameof(_EPROCESS.CommitChargeLimit),
                    new ulong[]
                    {
                        976UL
                    }
                },
                {
                    nameof(_EPROCESS.CommitCharge),
                    new ulong[]
                    {
                        984UL
                    }
                },
                {
                    nameof(_EPROCESS.CommitChargePeak),
                    new ulong[]
                    {
                        992UL
                    }
                },
                {
                    nameof(_EPROCESS.Vm),
                    new ulong[]
                    {
                        1024UL
                    }
                },
                {
                    nameof(_EPROCESS.MmProcessLinks),
                    new ulong[]
                    {
                        1344UL
                    }
                },
                {
                    nameof(_EPROCESS.ModifiedPageCount),
                    new ulong[]
                    {
                        1360UL
                    }
                },
                {
                    nameof(_EPROCESS.ExitStatus),
                    new ulong[]
                    {
                        1364UL
                    }
                },
                {
                    nameof(_EPROCESS.VadRoot),
                    new ulong[]
                    {
                        1368UL
                    }
                },
                {
                    nameof(_EPROCESS.VadHint),
                    new ulong[]
                    {
                        1376UL
                    }
                },
                {
                    nameof(_EPROCESS.VadCount),
                    new ulong[]
                    {
                        1384UL
                    }
                },
                {
                    nameof(_EPROCESS.VadPhysicalPages),
                    new ulong[]
                    {
                        1392UL
                    }
                },
                {
                    nameof(_EPROCESS.VadPhysicalPagesLimit),
                    new ulong[]
                    {
                        1400UL
                    }
                },
                {
                    nameof(_EPROCESS.AlpcContext),
                    new ulong[]
                    {
                        1408UL
                    }
                },
                {
                    nameof(_EPROCESS.TimerResolutionLink),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_EPROCESS.TimerResolutionStackRecord),
                    new ulong[]
                    {
                        1456UL
                    }
                },
                {
                    nameof(_EPROCESS.RequestedTimerResolution),
                    new ulong[]
                    {
                        1464UL
                    }
                },
                {
                    nameof(_EPROCESS.SmallestTimerResolution),
                    new ulong[]
                    {
                        1468UL
                    }
                },
                {
                    nameof(_EPROCESS.ExitTime),
                    new ulong[]
                    {
                        1472UL
                    }
                },
                {
                    nameof(_EPROCESS.InvertedFunctionTable),
                    new ulong[]
                    {
                        1480UL
                    }
                },
                {
                    nameof(_EPROCESS.InvertedFunctionTableLock),
                    new ulong[]
                    {
                        1488UL
                    }
                },
                {
                    nameof(_EPROCESS.ActiveThreadsHighWatermark),
                    new ulong[]
                    {
                        1496UL
                    }
                },
                {
                    nameof(_EPROCESS.LargePrivateVadCount),
                    new ulong[]
                    {
                        1500UL
                    }
                },
                {
                    nameof(_EPROCESS.ThreadListLock),
                    new ulong[]
                    {
                        1504UL
                    }
                },
                {
                    nameof(_EPROCESS.WnfContext),
                    new ulong[]
                    {
                        1512UL
                    }
                },
                {
                    nameof(_EPROCESS.ServerSilo),
                    new ulong[]
                    {
                        1520UL
                    }
                },
                {
                    nameof(_EPROCESS.SignatureLevel),
                    new ulong[]
                    {
                        1528UL
                    }
                },
                {
                    nameof(_EPROCESS.SectionSignatureLevel),
                    new ulong[]
                    {
                        1529UL
                    }
                },
                {
                    nameof(_EPROCESS.Protection),
                    new ulong[]
                    {
                        1530UL
                    }
                },
                {
                    nameof(_EPROCESS.HangCount),
                    new ulong[]
                    {
                        1531UL
                    }
                },
                {
                    nameof(_EPROCESS.GhostCount),
                    new ulong[]
                    {
                        1531UL
                    }
                },
                {
                    nameof(_EPROCESS.PrefilterException),
                    new ulong[]
                    {
                        1531UL
                    }
                },
                {
                    nameof(_EPROCESS.Flags3),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.Minimal),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.ReplacingPageRoot),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.Crashed),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.JobVadsAreTracked),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.VadTrackingDisabled),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.AuxiliaryProcess),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.SubsystemProcess),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.IndirectCpuSets),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.RelinquishedCommit),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.HighGraphicsPriority),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.CommitFailLogged),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.ReserveFailLogged),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.SystemProcess),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.AllImagesAtBasePristineBase),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.AddressPolicyFrozen),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.ProcessFirstResume),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.ForegroundExternal),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.ForegroundSystem),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.HighMemoryPriority),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.EnableProcessSuspendResumeLogging),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.EnableThreadSuspendResumeLogging),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.SecurityDomainChanged),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.SecurityFreezeComplete),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.VmProcessorHost),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.VmProcessorHostTransition),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.AltSyscall),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.TimerResolutionIgnore),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.DisallowUserTerminate),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.EnableProcessRemoteExecProtectVmLogging),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.EnableProcessLocalExecProtectVmLogging),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.MemoryCompressionProcess),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.EnableProcessImpersonationLogging),
                    new ulong[]
                    {
                        1532UL
                    }
                },
                {
                    nameof(_EPROCESS.DeviceAsid),
                    new ulong[]
                    {
                        1536UL
                    }
                },
                {
                    nameof(_EPROCESS.SvmData),
                    new ulong[]
                    {
                        1544UL
                    }
                },
                {
                    nameof(_EPROCESS.SvmProcessLock),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EPROCESS.SvmLock),
                    new ulong[]
                    {
                        1560UL
                    }
                },
                {
                    nameof(_EPROCESS.SvmProcessDeviceListHead),
                    new ulong[]
                    {
                        1568UL
                    }
                },
                {
                    nameof(_EPROCESS.LastFreezeInterruptTime),
                    new ulong[]
                    {
                        1584UL
                    }
                },
                {
                    nameof(_EPROCESS.DiskCounters),
                    new ulong[]
                    {
                        1592UL
                    }
                },
                {
                    nameof(_EPROCESS.PicoContext),
                    new ulong[]
                    {
                        1600UL
                    }
                },
                {
                    nameof(_EPROCESS.EnclaveTable),
                    new ulong[]
                    {
                        1608UL
                    }
                },
                {
                    nameof(_EPROCESS.EnclaveNumber),
                    new ulong[]
                    {
                        1616UL
                    }
                },
                {
                    nameof(_EPROCESS.EnclaveLock),
                    new ulong[]
                    {
                        1624UL
                    }
                },
                {
                    nameof(_EPROCESS.HighPriorityFaultsAllowed),
                    new ulong[]
                    {
                        1632UL
                    }
                },
                {
                    nameof(_EPROCESS.EnergyContext),
                    new ulong[]
                    {
                        1640UL
                    }
                },
                {
                    nameof(_EPROCESS.VmContext),
                    new ulong[]
                    {
                        1648UL
                    }
                },
                {
                    nameof(_EPROCESS.SequenceNumber),
                    new ulong[]
                    {
                        1656UL
                    }
                },
                {
                    nameof(_EPROCESS.CreateInterruptTime),
                    new ulong[]
                    {
                        1664UL
                    }
                },
                {
                    nameof(_EPROCESS.CreateUnbiasedInterruptTime),
                    new ulong[]
                    {
                        1672UL
                    }
                },
                {
                    nameof(_EPROCESS.TotalUnbiasedFrozenTime),
                    new ulong[]
                    {
                        1680UL
                    }
                },
                {
                    nameof(_EPROCESS.LastAppStateUpdateTime),
                    new ulong[]
                    {
                        1688UL
                    }
                },
                {
                    nameof(_EPROCESS.LastAppStateUptime),
                    new ulong[]
                    {
                        1696UL
                    }
                },
                {
                    nameof(_EPROCESS.LastAppState),
                    new ulong[]
                    {
                        1696UL
                    }
                },
                {
                    nameof(_EPROCESS.SharedCommitCharge),
                    new ulong[]
                    {
                        1704UL
                    }
                },
                {
                    nameof(_EPROCESS.SharedCommitLock),
                    new ulong[]
                    {
                        1712UL
                    }
                },
                {
                    nameof(_EPROCESS.SharedCommitLinks),
                    new ulong[]
                    {
                        1720UL
                    }
                },
                {
                    nameof(_EPROCESS.AllowedCpuSets),
                    new ulong[]
                    {
                        1736UL
                    }
                },
                {
                    nameof(_EPROCESS.DefaultCpuSets),
                    new ulong[]
                    {
                        1744UL
                    }
                },
                {
                    nameof(_EPROCESS.AllowedCpuSetsIndirect),
                    new ulong[]
                    {
                        1736UL
                    }
                },
                {
                    nameof(_EPROCESS.DefaultCpuSetsIndirect),
                    new ulong[]
                    {
                        1744UL
                    }
                },
                {
                    nameof(_EPROCESS.DiskIoAttribution),
                    new ulong[]
                    {
                        1752UL
                    }
                },
                {
                    nameof(_EPROCESS.DxgProcess),
                    new ulong[]
                    {
                        1760UL
                    }
                },
                {
                    nameof(_EPROCESS.Win32KFilterSet),
                    new ulong[]
                    {
                        1768UL
                    }
                },
                {
                    nameof(_EPROCESS.Machine),
                    new ulong[]
                    {
                        1772UL
                    }
                },
                {
                    nameof(_EPROCESS.MmSlabIdentity),
                    new ulong[]
                    {
                        1774UL
                    }
                },
                {
                    nameof(_EPROCESS.Spare0),
                    new ulong[]
                    {
                        1775UL
                    }
                },
                {
                    nameof(_EPROCESS.ProcessTimerDelay),
                    new ulong[]
                    {
                        1776UL
                    }
                },
                {
                    nameof(_EPROCESS.KTimerSets),
                    new ulong[]
                    {
                        1784UL
                    }
                },
                {
                    nameof(_EPROCESS.KTimer2Sets),
                    new ulong[]
                    {
                        1788UL
                    }
                },
                {
                    nameof(_EPROCESS.ThreadTimerSets),
                    new ulong[]
                    {
                        1792UL
                    }
                },
                {
                    nameof(_EPROCESS.VirtualTimerListLock),
                    new ulong[]
                    {
                        1800UL
                    }
                },
                {
                    nameof(_EPROCESS.VirtualTimerListHead),
                    new ulong[]
                    {
                        1808UL
                    }
                },
                {
                    nameof(_EPROCESS.WakeChannel),
                    new ulong[]
                    {
                        1824UL
                    }
                },
                {
                    nameof(_EPROCESS.WakeInfo),
                    new ulong[]
                    {
                        1824UL
                    }
                },
                {
                    nameof(_EPROCESS.MitigationFlags),
                    new ulong[]
                    {
                        1872UL
                    }
                },
                {
                    nameof(_EPROCESS.MitigationFlagsValues),
                    new ulong[]
                    {
                        1872UL
                    }
                },
                {
                    nameof(_EPROCESS.MitigationFlags2),
                    new ulong[]
                    {
                        1876UL
                    }
                },
                {
                    nameof(_EPROCESS.MitigationFlags2Values),
                    new ulong[]
                    {
                        1876UL
                    }
                },
                {
                    nameof(_EPROCESS.PartitionObject),
                    new ulong[]
                    {
                        1880UL
                    }
                },
                {
                    nameof(_EPROCESS.SecurityDomain),
                    new ulong[]
                    {
                        1888UL
                    }
                },
                {
                    nameof(_EPROCESS.ParentSecurityDomain),
                    new ulong[]
                    {
                        1896UL
                    }
                },
                {
                    nameof(_EPROCESS.CoverageSamplerContext),
                    new ulong[]
                    {
                        1904UL
                    }
                },
                {
                    nameof(_EPROCESS.MmHotPatchContext),
                    new ulong[]
                    {
                        1912UL
                    }
                },
                {
                    nameof(_EPROCESS.DynamicEHContinuationTargetsTree),
                    new ulong[]
                    {
                        1920UL
                    }
                },
                {
                    nameof(_EPROCESS.DynamicEHContinuationTargetsLock),
                    new ulong[]
                    {
                        1928UL
                    }
                },
                {
                    nameof(_EPROCESS.DynamicEnforcedCetCompatibleRanges),
                    new ulong[]
                    {
                        1936UL
                    }
                },
                {
                    nameof(_EPROCESS.DisabledComponentFlags),
                    new ulong[]
                    {
                        1952UL
                    }
                },
                {
                    nameof(_EPROCESS.PageCombineSequence),
                    new ulong[]
                    {
                        1956UL
                    }
                },
                {
                    nameof(_EPROCESS.EnableOptionalXStateFeaturesLock),
                    new ulong[]
                    {
                        1960UL
                    }
                },
                {
                    nameof(_EPROCESS.PathRedirectionHashes),
                    new ulong[]
                    {
                        1968UL
                    }
                },
                {
                    nameof(_EPROCESS.SyscallProvider),
                    new ulong[]
                    {
                        1976UL
                    }
                },
                {
                    nameof(_EPROCESS.SyscallProviderProcessLinks),
                    new ulong[]
                    {
                        1984UL
                    }
                },
                {
                    nameof(_EPROCESS.SyscallProviderDispatchContext),
                    new ulong[]
                    {
                        2000UL
                    }
                },
                {
                    nameof(_EPROCESS.MitigationFlags3),
                    new ulong[]
                    {
                        2008UL
                    }
                },
                {
                    nameof(_EPROCESS.MitigationFlags3Values),
                    new ulong[]
                    {
                        2008UL
                    }
                },
                {
                    nameof(_EPROCESS.Flags4),
                    new ulong[]
                    {
                        2012UL
                    }
                },
                {
                    nameof(_EPROCESS.ThreadWasActive),
                    new ulong[]
                    {
                        2012UL
                    }
                },
                {
                    nameof(_EPROCESS.MinimalTerminate),
                    new ulong[]
                    {
                        2012UL
                    }
                },
                {
                    nameof(_EPROCESS.ImageExpansionDisable),
                    new ulong[]
                    {
                        2012UL
                    }
                },
                {
                    nameof(_EPROCESS.SessionFirstProcess),
                    new ulong[]
                    {
                        2012UL
                    }
                },
                {
                    nameof(_EPROCESS.SyscallUsage),
                    new ulong[]
                    {
                        2016UL
                    }
                },
                {
                    nameof(_EPROCESS.SyscallUsageValues),
                    new ulong[]
                    {
                        2016UL
                    }
                },
                {
                    nameof(_EPROCESS.SupervisorDeviceAsid),
                    new ulong[]
                    {
                        2020UL
                    }
                },
                {
                    nameof(_EPROCESS.SupervisorSvmData),
                    new ulong[]
                    {
                        2024UL
                    }
                },
                {
                    nameof(_EPROCESS.NetworkCounters),
                    new ulong[]
                    {
                        2032UL
                    }
                },
                {
                    nameof(_EPROCESS.Execution),
                    new ulong[]
                    {
                        2040UL
                    }
                },
                {
                    nameof(_EPROCESS.ThreadIndexTable),
                    new ulong[]
                    {
                        2048UL
                    }
                },
                {
                    nameof(_EPROCESS.FreezeWorkLinks),
                    new ulong[]
                    {
                        2056UL
                    }
                }
            };
            Register<_EPROCESS>((mem, ptr) => new _EPROCESS(mem, ptr), offsets);
        }
    }
}