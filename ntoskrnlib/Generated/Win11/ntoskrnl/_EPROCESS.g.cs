#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2112)]
    public partial struct _EPROCESS
    {
        [FieldOffset(0)]
        public _KPROCESS Pcb;
        [FieldOffset(456)]
        public _EX_PUSH_LOCK ProcessLock;
        [FieldOffset(464)]
        public IntPtr UniqueProcessId;
        [FieldOffset(472)]
        public _LIST_ENTRY ActiveProcessLinks;
        [FieldOffset(488)]
        public _EX_RUNDOWN_REF RundownProtect;
        [FieldOffset(496)]
        public uint Flags2;
        [FieldOffset(496)]
        public uint JobNotReallyActive;
        [FieldOffset(496)]
        public uint AccountingFolded;
        [FieldOffset(496)]
        public uint NewProcessReported;
        [FieldOffset(496)]
        public uint ExitProcessReported;
        [FieldOffset(496)]
        public uint ReportCommitChanges;
        [FieldOffset(496)]
        public uint LastReportMemory;
        [FieldOffset(496)]
        public uint ForceWakeCharge;
        [FieldOffset(496)]
        public uint CrossSessionCreate;
        [FieldOffset(496)]
        public uint NeedsHandleRundown;
        [FieldOffset(496)]
        public uint RefTraceEnabled;
        [FieldOffset(496)]
        public uint PicoCreated;
        [FieldOffset(496)]
        public uint EmptyJobEvaluated;
        [FieldOffset(496)]
        public uint DefaultPagePriority;
        [FieldOffset(496)]
        public uint PrimaryTokenFrozen;
        [FieldOffset(496)]
        public uint ProcessVerifierTarget;
        [FieldOffset(496)]
        public uint RestrictSetThreadContext;
        [FieldOffset(496)]
        public uint AffinityPermanent;
        [FieldOffset(496)]
        public uint AffinityUpdateEnable;
        [FieldOffset(496)]
        public uint PropagateNode;
        [FieldOffset(496)]
        public uint ExplicitAffinity;
        [FieldOffset(496)]
        public uint Flags2Available1;
        [FieldOffset(496)]
        public uint EnableReadVmLogging;
        [FieldOffset(496)]
        public uint EnableWriteVmLogging;
        [FieldOffset(496)]
        public uint FatalAccessTerminationRequested;
        [FieldOffset(496)]
        public uint DisableSystemAllowedCpuSet;
        [FieldOffset(496)]
        public uint Flags2Available2;
        [FieldOffset(496)]
        public uint InPrivate;
        [FieldOffset(500)]
        public uint Flags;
        [FieldOffset(500)]
        public uint CreateReported;
        [FieldOffset(500)]
        public uint NoDebugInherit;
        [FieldOffset(500)]
        public uint ProcessExiting;
        [FieldOffset(500)]
        public uint ProcessDelete;
        [FieldOffset(500)]
        public uint ManageExecutableMemoryWrites;
        [FieldOffset(500)]
        public uint VmDeleted;
        [FieldOffset(500)]
        public uint OutswapEnabled;
        [FieldOffset(500)]
        public uint Outswapped;
        [FieldOffset(500)]
        public uint FailFastOnCommitFail;
        [FieldOffset(500)]
        public uint Wow64VaSpace4Gb;
        [FieldOffset(500)]
        public uint AddressSpaceInitialized;
        [FieldOffset(500)]
        public uint SetTimerResolution;
        [FieldOffset(500)]
        public uint BreakOnTermination;
        [FieldOffset(500)]
        public uint DeprioritizeViews;
        [FieldOffset(500)]
        public uint WriteWatch;
        [FieldOffset(500)]
        public uint ProcessInSession;
        [FieldOffset(500)]
        public uint OverrideAddressSpace;
        [FieldOffset(500)]
        public uint HasAddressSpace;
        [FieldOffset(500)]
        public uint LaunchPrefetched;
        [FieldOffset(500)]
        public uint Reserved;
        [FieldOffset(500)]
        public uint VmTopDown;
        [FieldOffset(500)]
        public uint ImageNotifyDone;
        [FieldOffset(500)]
        public uint PdeUpdateNeeded;
        [FieldOffset(500)]
        public uint VdmAllowed;
        [FieldOffset(500)]
        public uint ProcessRundown;
        [FieldOffset(500)]
        public uint ProcessInserted;
        [FieldOffset(500)]
        public uint DefaultIoPriority;
        [FieldOffset(500)]
        public uint ProcessSelfDelete;
        [FieldOffset(500)]
        public uint SetTimerResolutionLink;
        [FieldOffset(504)]
        public _LARGE_INTEGER CreateTime;
        [FieldOffset(512)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] ProcessQuotaUsage;
        [FieldOffset(528)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] ProcessQuotaPeak;
        [FieldOffset(544)]
        public ulong PeakVirtualSize;
        [FieldOffset(552)]
        public ulong VirtualSize;
        [FieldOffset(560)]
        public _LIST_ENTRY SessionProcessLinks;
        [FieldOffset(576)]
        public IntPtr ExceptionPortData;
        [FieldOffset(576)]
        public ulong ExceptionPortValue;
        [FieldOffset(576)]
        public ulong ExceptionPortState;
        [FieldOffset(584)]
        public _EX_FAST_REF Token;
        [FieldOffset(592)]
        public ulong MmReserved;
        [FieldOffset(600)]
        public _EX_PUSH_LOCK AddressCreationLock;
        [FieldOffset(608)]
        public _EX_PUSH_LOCK PageTableCommitmentLock;
        [FieldOffset(616)]
        public IntPtr RotateInProgress;
        [FieldOffset(624)]
        public IntPtr ForkInProgress;
        [FieldOffset(632)]
        public IntPtr CommitChargeJob;
        [FieldOffset(640)]
        public _RTL_AVL_TREE CloneRoot;
        [FieldOffset(648)]
        public ulong NumberOfPrivatePages;
        [FieldOffset(656)]
        public ulong MmReserved2;
        [FieldOffset(664)]
        public IntPtr Win32Process;
        [FieldOffset(672)]
        public IntPtr Job;
        [FieldOffset(680)]
        public IntPtr SectionObject;
        [FieldOffset(688)]
        public IntPtr SectionBaseAddress;
        [FieldOffset(696)]
        public uint Cookie;
        [FieldOffset(704)]
        public IntPtr WorkingSetWatch;
        [FieldOffset(712)]
        public IntPtr Win32WindowStation;
        [FieldOffset(720)]
        public IntPtr InheritedFromUniqueProcessId;
        [FieldOffset(728)]
        public ulong OwnerProcessId;
        [FieldOffset(736)]
        public IntPtr Peb;
        [FieldOffset(744)]
        public IntPtr Session;
        [FieldOffset(752)]
        public IntPtr Spare1;
        [FieldOffset(760)]
        public IntPtr QuotaBlock;
        [FieldOffset(768)]
        public IntPtr ObjectTable;
        [FieldOffset(776)]
        public IntPtr DebugPort;
        [FieldOffset(784)]
        public IntPtr WoW64Process;
        [FieldOffset(792)]
        public _EX_FAST_REF DeviceMap;
        [FieldOffset(800)]
        public IntPtr EtwDataSource;
        [FieldOffset(808)]
        public ulong PageDirectoryPte;
        [FieldOffset(816)]
        public IntPtr ImageFilePointer;
        [FieldOffset(824)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public byte[] ImageFileName;
        [FieldOffset(839)]
        public byte PriorityClass;
        [FieldOffset(840)]
        public IntPtr SecurityPort;
        [FieldOffset(848)]
        public _SE_AUDIT_PROCESS_CREATION_INFO SeAuditProcessCreationInfo;
        [FieldOffset(856)]
        public _LIST_ENTRY JobLinks;
        [FieldOffset(872)]
        public IntPtr HighestUserAddress;
        [FieldOffset(880)]
        public _LIST_ENTRY ThreadListHead;
        [FieldOffset(896)]
        public uint ActiveThreads;
        [FieldOffset(900)]
        public uint ImagePathHash;
        [FieldOffset(904)]
        public uint DefaultHardErrorProcessing;
        [FieldOffset(908)]
        public int LastThreadExitStatus;
        [FieldOffset(912)]
        public _EX_FAST_REF PrefetchTrace;
        [FieldOffset(920)]
        public IntPtr LockedPagesList;
        [FieldOffset(928)]
        public _LARGE_INTEGER ReadOperationCount;
        [FieldOffset(936)]
        public _LARGE_INTEGER WriteOperationCount;
        [FieldOffset(944)]
        public _LARGE_INTEGER OtherOperationCount;
        [FieldOffset(952)]
        public _LARGE_INTEGER ReadTransferCount;
        [FieldOffset(960)]
        public _LARGE_INTEGER WriteTransferCount;
        [FieldOffset(968)]
        public _LARGE_INTEGER OtherTransferCount;
        [FieldOffset(976)]
        public ulong CommitChargeLimit;
        [FieldOffset(984)]
        public ulong CommitCharge;
        [FieldOffset(992)]
        public ulong CommitChargePeak;
        [FieldOffset(1024)]
        public _MMSUPPORT_FULL Vm;
        [FieldOffset(1344)]
        public _LIST_ENTRY MmProcessLinks;
        [FieldOffset(1360)]
        public uint ModifiedPageCount;
        [FieldOffset(1364)]
        public int ExitStatus;
        [FieldOffset(1368)]
        public _RTL_AVL_TREE VadRoot;
        [FieldOffset(1376)]
        public IntPtr VadHint;
        [FieldOffset(1384)]
        public ulong VadCount;
        [FieldOffset(1392)]
        public ulong VadPhysicalPages;
        [FieldOffset(1400)]
        public ulong VadPhysicalPagesLimit;
        [FieldOffset(1408)]
        public _ALPC_PROCESS_CONTEXT AlpcContext;
        [FieldOffset(1440)]
        public _LIST_ENTRY TimerResolutionLink;
        [FieldOffset(1456)]
        public IntPtr TimerResolutionStackRecord;
        [FieldOffset(1464)]
        public uint RequestedTimerResolution;
        [FieldOffset(1468)]
        public uint SmallestTimerResolution;
        [FieldOffset(1472)]
        public _LARGE_INTEGER ExitTime;
        [FieldOffset(1480)]
        public IntPtr InvertedFunctionTable;
        [FieldOffset(1488)]
        public _EX_PUSH_LOCK InvertedFunctionTableLock;
        [FieldOffset(1496)]
        public uint ActiveThreadsHighWatermark;
        [FieldOffset(1500)]
        public uint LargePrivateVadCount;
        [FieldOffset(1504)]
        public _EX_PUSH_LOCK ThreadListLock;
        [FieldOffset(1512)]
        public IntPtr WnfContext;
        [FieldOffset(1520)]
        public IntPtr ServerSilo;
        [FieldOffset(1528)]
        public byte SignatureLevel;
        [FieldOffset(1529)]
        public byte SectionSignatureLevel;
        [FieldOffset(1530)]
        public _PS_PROTECTION Protection;
        [FieldOffset(1531)]
        public byte HangCount;
        [FieldOffset(1531)]
        public byte GhostCount;
        [FieldOffset(1531)]
        public byte PrefilterException;
        [FieldOffset(1532)]
        public uint Flags3;
        [FieldOffset(1532)]
        public uint Minimal;
        [FieldOffset(1532)]
        public uint ReplacingPageRoot;
        [FieldOffset(1532)]
        public uint Crashed;
        [FieldOffset(1532)]
        public uint JobVadsAreTracked;
        [FieldOffset(1532)]
        public uint VadTrackingDisabled;
        [FieldOffset(1532)]
        public uint AuxiliaryProcess;
        [FieldOffset(1532)]
        public uint SubsystemProcess;
        [FieldOffset(1532)]
        public uint IndirectCpuSets;
        [FieldOffset(1532)]
        public uint RelinquishedCommit;
        [FieldOffset(1532)]
        public uint HighGraphicsPriority;
        [FieldOffset(1532)]
        public uint CommitFailLogged;
        [FieldOffset(1532)]
        public uint ReserveFailLogged;
        [FieldOffset(1532)]
        public uint SystemProcess;
        [FieldOffset(1532)]
        public uint AllImagesAtBasePristineBase;
        [FieldOffset(1532)]
        public uint AddressPolicyFrozen;
        [FieldOffset(1532)]
        public uint ProcessFirstResume;
        [FieldOffset(1532)]
        public uint ForegroundExternal;
        [FieldOffset(1532)]
        public uint ForegroundSystem;
        [FieldOffset(1532)]
        public uint HighMemoryPriority;
        [FieldOffset(1532)]
        public uint EnableProcessSuspendResumeLogging;
        [FieldOffset(1532)]
        public uint EnableThreadSuspendResumeLogging;
        [FieldOffset(1532)]
        public uint SecurityDomainChanged;
        [FieldOffset(1532)]
        public uint SecurityFreezeComplete;
        [FieldOffset(1532)]
        public uint VmProcessorHost;
        [FieldOffset(1532)]
        public uint VmProcessorHostTransition;
        [FieldOffset(1532)]
        public uint AltSyscall;
        [FieldOffset(1532)]
        public uint TimerResolutionIgnore;
        [FieldOffset(1532)]
        public uint DisallowUserTerminate;
        [FieldOffset(1532)]
        public uint EnableProcessRemoteExecProtectVmLogging;
        [FieldOffset(1532)]
        public uint EnableProcessLocalExecProtectVmLogging;
        [FieldOffset(1532)]
        public uint MemoryCompressionProcess;
        [FieldOffset(1532)]
        public uint EnableProcessImpersonationLogging;
        [FieldOffset(1536)]
        public int DeviceAsid;
        [FieldOffset(1544)]
        public IntPtr SvmData;
        [FieldOffset(1552)]
        public _EX_PUSH_LOCK SvmProcessLock;
        [FieldOffset(1560)]
        public ulong SvmLock;
        [FieldOffset(1568)]
        public _LIST_ENTRY SvmProcessDeviceListHead;
        [FieldOffset(1584)]
        public ulong LastFreezeInterruptTime;
        [FieldOffset(1592)]
        public IntPtr DiskCounters;
        [FieldOffset(1600)]
        public IntPtr PicoContext;
        [FieldOffset(1608)]
        public IntPtr EnclaveTable;
        [FieldOffset(1616)]
        public ulong EnclaveNumber;
        [FieldOffset(1624)]
        public _EX_PUSH_LOCK EnclaveLock;
        [FieldOffset(1632)]
        public uint HighPriorityFaultsAllowed;
        [FieldOffset(1640)]
        public IntPtr EnergyContext;
        [FieldOffset(1648)]
        public IntPtr VmContext;
        [FieldOffset(1656)]
        public ulong SequenceNumber;
        [FieldOffset(1664)]
        public ulong CreateInterruptTime;
        [FieldOffset(1672)]
        public ulong CreateUnbiasedInterruptTime;
        [FieldOffset(1680)]
        public ulong TotalUnbiasedFrozenTime;
        [FieldOffset(1688)]
        public ulong LastAppStateUpdateTime;
        [FieldOffset(1696)]
        public ulong LastAppStateUptime;
        [FieldOffset(1696)]
        public ulong LastAppState;
        [FieldOffset(1704)]
        public ulong SharedCommitCharge;
        [FieldOffset(1712)]
        public _EX_PUSH_LOCK SharedCommitLock;
        [FieldOffset(1720)]
        public _LIST_ENTRY SharedCommitLinks;
        [FieldOffset(1736)]
        public ulong AllowedCpuSets;
        [FieldOffset(1744)]
        public ulong DefaultCpuSets;
        [FieldOffset(1736)]
        public IntPtr AllowedCpuSetsIndirect;
        [FieldOffset(1744)]
        public IntPtr DefaultCpuSetsIndirect;
        [FieldOffset(1752)]
        public IntPtr DiskIoAttribution;
        [FieldOffset(1760)]
        public IntPtr DxgProcess;
        [FieldOffset(1768)]
        public uint Win32KFilterSet;
        [FieldOffset(1772)]
        public ushort Machine;
        [FieldOffset(1774)]
        public byte MmSlabIdentity;
        [FieldOffset(1775)]
        public byte Spare0;
        [FieldOffset(1776)]
        public _PS_INTERLOCKED_TIMER_DELAY_VALUES ProcessTimerDelay;
        [FieldOffset(1784)]
        public uint KTimerSets;
        [FieldOffset(1788)]
        public uint KTimer2Sets;
        [FieldOffset(1792)]
        public uint ThreadTimerSets;
        [FieldOffset(1800)]
        public ulong VirtualTimerListLock;
        [FieldOffset(1808)]
        public _LIST_ENTRY VirtualTimerListHead;
        [FieldOffset(1824)]
        public _WNF_STATE_NAME WakeChannel;
        [FieldOffset(1824)]
        public _PS_PROCESS_WAKE_INFORMATION WakeInfo;
        [FieldOffset(1872)]
        public uint MitigationFlags;
        [FieldOffset(1872)]
        public _unnamed_tag_ MitigationFlagsValues;
        [FieldOffset(1876)]
        public uint MitigationFlags2;
        [FieldOffset(1876)]
        public _unnamed_tag_ MitigationFlags2Values;
        [FieldOffset(1880)]
        public IntPtr PartitionObject;
        [FieldOffset(1888)]
        public ulong SecurityDomain;
        [FieldOffset(1896)]
        public ulong ParentSecurityDomain;
        [FieldOffset(1904)]
        public IntPtr CoverageSamplerContext;
        [FieldOffset(1912)]
        public IntPtr MmHotPatchContext;
        [FieldOffset(1920)]
        public _RTL_AVL_TREE DynamicEHContinuationTargetsTree;
        [FieldOffset(1928)]
        public _EX_PUSH_LOCK DynamicEHContinuationTargetsLock;
        [FieldOffset(1936)]
        public _PS_DYNAMIC_ENFORCED_ADDRESS_RANGES DynamicEnforcedCetCompatibleRanges;
        [FieldOffset(1952)]
        public uint DisabledComponentFlags;
        [FieldOffset(1956)]
        public int PageCombineSequence;
        [FieldOffset(1960)]
        public _EX_PUSH_LOCK EnableOptionalXStateFeaturesLock;
        [FieldOffset(1968)]
        public IntPtr PathRedirectionHashes;
        [FieldOffset(1976)]
        public IntPtr SyscallProvider;
        [FieldOffset(1984)]
        public _LIST_ENTRY SyscallProviderProcessLinks;
        [FieldOffset(2000)]
        public _PSP_SYSCALL_PROVIDER_DISPATCH_CONTEXT SyscallProviderDispatchContext;
        [FieldOffset(2008)]
        public uint MitigationFlags3;
        [FieldOffset(2008)]
        public _unnamed_tag_ MitigationFlags3Values;
        [FieldOffset(2012)]
        public uint Flags4;
        [FieldOffset(2012)]
        public uint ThreadWasActive;
        [FieldOffset(2012)]
        public uint MinimalTerminate;
        [FieldOffset(2012)]
        public uint ImageExpansionDisable;
        [FieldOffset(2012)]
        public uint SessionFirstProcess;
        [FieldOffset(2016)]
        public uint SyscallUsage;
        [FieldOffset(2016)]
        public _unnamed_tag_ SyscallUsageValues;
        [FieldOffset(2020)]
        public int SupervisorDeviceAsid;
        [FieldOffset(2024)]
        public IntPtr SupervisorSvmData;
        [FieldOffset(2032)]
        public IntPtr NetworkCounters;
        [FieldOffset(2040)]
        public _PROCESS_EXECUTION Execution;
        [FieldOffset(2048)]
        public IntPtr ThreadIndexTable;
        [FieldOffset(2056)]
        public _LIST_ENTRY FreezeWorkLinks;
    }
}