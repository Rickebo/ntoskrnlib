using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EPROCESS")]
    public sealed class Eprocess : DynamicStructure
    {
        [Offset(0UL)]
        public Kprocess Pcb { get => ReadStructure<Kprocess>(nameof(Pcb)); set => WriteStructure(nameof(Pcb), value); }

        [Offset(456UL)]
        public ExPushLock ProcessLock { get => ReadStructure<ExPushLock>(nameof(ProcessLock)); set => WriteStructure(nameof(ProcessLock), value); }

        [Offset(464UL)]
        public IntPtr UniqueProcessId { get => ReadHere<IntPtr>(nameof(UniqueProcessId)); set => WriteHere(nameof(UniqueProcessId), value); }

        [Offset(472UL)]
        public ListEntry ActiveProcessLinks { get => ReadStructure<ListEntry>(nameof(ActiveProcessLinks)); set => WriteStructure(nameof(ActiveProcessLinks), value); }

        [Offset(488UL)]
        public ExRundownRef RundownProtect { get => ReadStructure<ExRundownRef>(nameof(RundownProtect)); set => WriteStructure(nameof(RundownProtect), value); }

        [Offset(496UL)]
        public uint Flags2 { get => ReadHere<uint>(nameof(Flags2)); set => WriteHere(nameof(Flags2), value); }

        [Offset(496UL)]
        public uint JobNotReallyActive { get => ReadHere<uint>(nameof(JobNotReallyActive)); set => WriteHere(nameof(JobNotReallyActive), value); }

        [Offset(496UL)]
        public uint AccountingFolded { get => ReadHere<uint>(nameof(AccountingFolded)); set => WriteHere(nameof(AccountingFolded), value); }

        [Offset(496UL)]
        public uint NewProcessReported { get => ReadHere<uint>(nameof(NewProcessReported)); set => WriteHere(nameof(NewProcessReported), value); }

        [Offset(496UL)]
        public uint ExitProcessReported { get => ReadHere<uint>(nameof(ExitProcessReported)); set => WriteHere(nameof(ExitProcessReported), value); }

        [Offset(496UL)]
        public uint ReportCommitChanges { get => ReadHere<uint>(nameof(ReportCommitChanges)); set => WriteHere(nameof(ReportCommitChanges), value); }

        [Offset(496UL)]
        public uint LastReportMemory { get => ReadHere<uint>(nameof(LastReportMemory)); set => WriteHere(nameof(LastReportMemory), value); }

        [Offset(496UL)]
        public uint ForceWakeCharge { get => ReadHere<uint>(nameof(ForceWakeCharge)); set => WriteHere(nameof(ForceWakeCharge), value); }

        [Offset(496UL)]
        public uint CrossSessionCreate { get => ReadHere<uint>(nameof(CrossSessionCreate)); set => WriteHere(nameof(CrossSessionCreate), value); }

        [Offset(496UL)]
        public uint NeedsHandleRundown { get => ReadHere<uint>(nameof(NeedsHandleRundown)); set => WriteHere(nameof(NeedsHandleRundown), value); }

        [Offset(496UL)]
        public uint RefTraceEnabled { get => ReadHere<uint>(nameof(RefTraceEnabled)); set => WriteHere(nameof(RefTraceEnabled), value); }

        [Offset(496UL)]
        public uint PicoCreated { get => ReadHere<uint>(nameof(PicoCreated)); set => WriteHere(nameof(PicoCreated), value); }

        [Offset(496UL)]
        public uint EmptyJobEvaluated { get => ReadHere<uint>(nameof(EmptyJobEvaluated)); set => WriteHere(nameof(EmptyJobEvaluated), value); }

        [Offset(496UL)]
        public uint DefaultPagePriority { get => ReadHere<uint>(nameof(DefaultPagePriority)); set => WriteHere(nameof(DefaultPagePriority), value); }

        [Offset(496UL)]
        public uint PrimaryTokenFrozen { get => ReadHere<uint>(nameof(PrimaryTokenFrozen)); set => WriteHere(nameof(PrimaryTokenFrozen), value); }

        [Offset(496UL)]
        public uint ProcessVerifierTarget { get => ReadHere<uint>(nameof(ProcessVerifierTarget)); set => WriteHere(nameof(ProcessVerifierTarget), value); }

        [Offset(496UL)]
        public uint RestrictSetThreadContext { get => ReadHere<uint>(nameof(RestrictSetThreadContext)); set => WriteHere(nameof(RestrictSetThreadContext), value); }

        [Offset(496UL)]
        public uint AffinityPermanent { get => ReadHere<uint>(nameof(AffinityPermanent)); set => WriteHere(nameof(AffinityPermanent), value); }

        [Offset(496UL)]
        public uint AffinityUpdateEnable { get => ReadHere<uint>(nameof(AffinityUpdateEnable)); set => WriteHere(nameof(AffinityUpdateEnable), value); }

        [Offset(496UL)]
        public uint PropagateNode { get => ReadHere<uint>(nameof(PropagateNode)); set => WriteHere(nameof(PropagateNode), value); }

        [Offset(496UL)]
        public uint ExplicitAffinity { get => ReadHere<uint>(nameof(ExplicitAffinity)); set => WriteHere(nameof(ExplicitAffinity), value); }

        [Offset(496UL)]
        public uint Flags2Available1 { get => ReadHere<uint>(nameof(Flags2Available1)); set => WriteHere(nameof(Flags2Available1), value); }

        [Offset(496UL)]
        public uint EnableReadVmLogging { get => ReadHere<uint>(nameof(EnableReadVmLogging)); set => WriteHere(nameof(EnableReadVmLogging), value); }

        [Offset(496UL)]
        public uint EnableWriteVmLogging { get => ReadHere<uint>(nameof(EnableWriteVmLogging)); set => WriteHere(nameof(EnableWriteVmLogging), value); }

        [Offset(496UL)]
        public uint FatalAccessTerminationRequested { get => ReadHere<uint>(nameof(FatalAccessTerminationRequested)); set => WriteHere(nameof(FatalAccessTerminationRequested), value); }

        [Offset(496UL)]
        public uint DisableSystemAllowedCpuSet { get => ReadHere<uint>(nameof(DisableSystemAllowedCpuSet)); set => WriteHere(nameof(DisableSystemAllowedCpuSet), value); }

        [Offset(496UL)]
        public uint Flags2Available2 { get => ReadHere<uint>(nameof(Flags2Available2)); set => WriteHere(nameof(Flags2Available2), value); }

        [Offset(496UL)]
        public uint InPrivate { get => ReadHere<uint>(nameof(InPrivate)); set => WriteHere(nameof(InPrivate), value); }

        [Offset(500UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(500UL)]
        public uint CreateReported { get => ReadHere<uint>(nameof(CreateReported)); set => WriteHere(nameof(CreateReported), value); }

        [Offset(500UL)]
        public uint NoDebugInherit { get => ReadHere<uint>(nameof(NoDebugInherit)); set => WriteHere(nameof(NoDebugInherit), value); }

        [Offset(500UL)]
        public uint ProcessExiting { get => ReadHere<uint>(nameof(ProcessExiting)); set => WriteHere(nameof(ProcessExiting), value); }

        [Offset(500UL)]
        public uint ProcessDelete { get => ReadHere<uint>(nameof(ProcessDelete)); set => WriteHere(nameof(ProcessDelete), value); }

        [Offset(500UL)]
        public uint ManageExecutableMemoryWrites { get => ReadHere<uint>(nameof(ManageExecutableMemoryWrites)); set => WriteHere(nameof(ManageExecutableMemoryWrites), value); }

        [Offset(500UL)]
        public uint VmDeleted { get => ReadHere<uint>(nameof(VmDeleted)); set => WriteHere(nameof(VmDeleted), value); }

        [Offset(500UL)]
        public uint OutswapEnabled { get => ReadHere<uint>(nameof(OutswapEnabled)); set => WriteHere(nameof(OutswapEnabled), value); }

        [Offset(500UL)]
        public uint Outswapped { get => ReadHere<uint>(nameof(Outswapped)); set => WriteHere(nameof(Outswapped), value); }

        [Offset(500UL)]
        public uint FailFastOnCommitFail { get => ReadHere<uint>(nameof(FailFastOnCommitFail)); set => WriteHere(nameof(FailFastOnCommitFail), value); }

        [Offset(500UL)]
        public uint Wow64VaSpace4Gb { get => ReadHere<uint>(nameof(Wow64VaSpace4Gb)); set => WriteHere(nameof(Wow64VaSpace4Gb), value); }

        [Offset(500UL)]
        public uint AddressSpaceInitialized { get => ReadHere<uint>(nameof(AddressSpaceInitialized)); set => WriteHere(nameof(AddressSpaceInitialized), value); }

        [Offset(500UL)]
        public uint SetTimerResolution { get => ReadHere<uint>(nameof(SetTimerResolution)); set => WriteHere(nameof(SetTimerResolution), value); }

        [Offset(500UL)]
        public uint BreakOnTermination { get => ReadHere<uint>(nameof(BreakOnTermination)); set => WriteHere(nameof(BreakOnTermination), value); }

        [Offset(500UL)]
        public uint DeprioritizeViews { get => ReadHere<uint>(nameof(DeprioritizeViews)); set => WriteHere(nameof(DeprioritizeViews), value); }

        [Offset(500UL)]
        public uint WriteWatch { get => ReadHere<uint>(nameof(WriteWatch)); set => WriteHere(nameof(WriteWatch), value); }

        [Offset(500UL)]
        public uint ProcessInSession { get => ReadHere<uint>(nameof(ProcessInSession)); set => WriteHere(nameof(ProcessInSession), value); }

        [Offset(500UL)]
        public uint OverrideAddressSpace { get => ReadHere<uint>(nameof(OverrideAddressSpace)); set => WriteHere(nameof(OverrideAddressSpace), value); }

        [Offset(500UL)]
        public uint HasAddressSpace { get => ReadHere<uint>(nameof(HasAddressSpace)); set => WriteHere(nameof(HasAddressSpace), value); }

        [Offset(500UL)]
        public uint LaunchPrefetched { get => ReadHere<uint>(nameof(LaunchPrefetched)); set => WriteHere(nameof(LaunchPrefetched), value); }

        [Offset(500UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(500UL)]
        public uint VmTopDown { get => ReadHere<uint>(nameof(VmTopDown)); set => WriteHere(nameof(VmTopDown), value); }

        [Offset(500UL)]
        public uint ImageNotifyDone { get => ReadHere<uint>(nameof(ImageNotifyDone)); set => WriteHere(nameof(ImageNotifyDone), value); }

        [Offset(500UL)]
        public uint PdeUpdateNeeded { get => ReadHere<uint>(nameof(PdeUpdateNeeded)); set => WriteHere(nameof(PdeUpdateNeeded), value); }

        [Offset(500UL)]
        public uint VdmAllowed { get => ReadHere<uint>(nameof(VdmAllowed)); set => WriteHere(nameof(VdmAllowed), value); }

        [Offset(500UL)]
        public uint ProcessRundown { get => ReadHere<uint>(nameof(ProcessRundown)); set => WriteHere(nameof(ProcessRundown), value); }

        [Offset(500UL)]
        public uint ProcessInserted { get => ReadHere<uint>(nameof(ProcessInserted)); set => WriteHere(nameof(ProcessInserted), value); }

        [Offset(500UL)]
        public uint DefaultIoPriority { get => ReadHere<uint>(nameof(DefaultIoPriority)); set => WriteHere(nameof(DefaultIoPriority), value); }

        [Offset(500UL)]
        public uint ProcessSelfDelete { get => ReadHere<uint>(nameof(ProcessSelfDelete)); set => WriteHere(nameof(ProcessSelfDelete), value); }

        [Offset(500UL)]
        public uint SetTimerResolutionLink { get => ReadHere<uint>(nameof(SetTimerResolutionLink)); set => WriteHere(nameof(SetTimerResolutionLink), value); }

        [Offset(504UL)]
        public LargeInteger CreateTime { get => ReadStructure<LargeInteger>(nameof(CreateTime)); set => WriteStructure(nameof(CreateTime), value); }

        [Offset(512UL)]
        [Length(2)]
        public DynamicArray ProcessQuotaUsage { get => ReadStructure<DynamicArray>(nameof(ProcessQuotaUsage)); set => WriteStructure(nameof(ProcessQuotaUsage), value); }

        [Offset(528UL)]
        [Length(2)]
        public DynamicArray ProcessQuotaPeak { get => ReadStructure<DynamicArray>(nameof(ProcessQuotaPeak)); set => WriteStructure(nameof(ProcessQuotaPeak), value); }

        [Offset(544UL)]
        public ulong PeakVirtualSize { get => ReadHere<ulong>(nameof(PeakVirtualSize)); set => WriteHere(nameof(PeakVirtualSize), value); }

        [Offset(552UL)]
        public ulong VirtualSize { get => ReadHere<ulong>(nameof(VirtualSize)); set => WriteHere(nameof(VirtualSize), value); }

        [Offset(560UL)]
        public ListEntry SessionProcessLinks { get => ReadStructure<ListEntry>(nameof(SessionProcessLinks)); set => WriteStructure(nameof(SessionProcessLinks), value); }

        [Offset(576UL)]
        public IntPtr ExceptionPortData { get => ReadHere<IntPtr>(nameof(ExceptionPortData)); set => WriteHere(nameof(ExceptionPortData), value); }

        [Offset(576UL)]
        public ulong ExceptionPortValue { get => ReadHere<ulong>(nameof(ExceptionPortValue)); set => WriteHere(nameof(ExceptionPortValue), value); }

        [Offset(576UL)]
        public ulong ExceptionPortState { get => ReadHere<ulong>(nameof(ExceptionPortState)); set => WriteHere(nameof(ExceptionPortState), value); }

        [Offset(584UL)]
        public ExFastRef Token { get => ReadStructure<ExFastRef>(nameof(Token)); set => WriteStructure(nameof(Token), value); }

        [Offset(592UL)]
        public ulong MmReserved { get => ReadHere<ulong>(nameof(MmReserved)); set => WriteHere(nameof(MmReserved), value); }

        [Offset(600UL)]
        public ExPushLock AddressCreationLock { get => ReadStructure<ExPushLock>(nameof(AddressCreationLock)); set => WriteStructure(nameof(AddressCreationLock), value); }

        [Offset(608UL)]
        public ExPushLock PageTableCommitmentLock { get => ReadStructure<ExPushLock>(nameof(PageTableCommitmentLock)); set => WriteStructure(nameof(PageTableCommitmentLock), value); }

        [Offset(616UL)]
        public IntPtr RotateInProgress { get => ReadHere<IntPtr>(nameof(RotateInProgress)); set => WriteHere(nameof(RotateInProgress), value); }

        [Offset(624UL)]
        public IntPtr ForkInProgress { get => ReadHere<IntPtr>(nameof(ForkInProgress)); set => WriteHere(nameof(ForkInProgress), value); }

        [Offset(632UL)]
        public IntPtr CommitChargeJob { get => ReadHere<IntPtr>(nameof(CommitChargeJob)); set => WriteHere(nameof(CommitChargeJob), value); }

        [Offset(640UL)]
        public RtlAvlTree CloneRoot { get => ReadStructure<RtlAvlTree>(nameof(CloneRoot)); set => WriteStructure(nameof(CloneRoot), value); }

        [Offset(648UL)]
        public ulong NumberOfPrivatePages { get => ReadHere<ulong>(nameof(NumberOfPrivatePages)); set => WriteHere(nameof(NumberOfPrivatePages), value); }

        [Offset(656UL)]
        public ulong MmReserved2 { get => ReadHere<ulong>(nameof(MmReserved2)); set => WriteHere(nameof(MmReserved2), value); }

        [Offset(664UL)]
        public IntPtr Win32Process { get => ReadHere<IntPtr>(nameof(Win32Process)); set => WriteHere(nameof(Win32Process), value); }

        [Offset(672UL)]
        public IntPtr Job { get => ReadHere<IntPtr>(nameof(Job)); set => WriteHere(nameof(Job), value); }

        [Offset(680UL)]
        public IntPtr SectionObject { get => ReadHere<IntPtr>(nameof(SectionObject)); set => WriteHere(nameof(SectionObject), value); }

        [Offset(688UL)]
        public IntPtr SectionBaseAddress { get => ReadHere<IntPtr>(nameof(SectionBaseAddress)); set => WriteHere(nameof(SectionBaseAddress), value); }

        [Offset(696UL)]
        public uint Cookie { get => ReadHere<uint>(nameof(Cookie)); set => WriteHere(nameof(Cookie), value); }

        [Offset(704UL)]
        public IntPtr WorkingSetWatch { get => ReadHere<IntPtr>(nameof(WorkingSetWatch)); set => WriteHere(nameof(WorkingSetWatch), value); }

        [Offset(712UL)]
        public IntPtr Win32WindowStation { get => ReadHere<IntPtr>(nameof(Win32WindowStation)); set => WriteHere(nameof(Win32WindowStation), value); }

        [Offset(720UL)]
        public IntPtr InheritedFromUniqueProcessId { get => ReadHere<IntPtr>(nameof(InheritedFromUniqueProcessId)); set => WriteHere(nameof(InheritedFromUniqueProcessId), value); }

        [Offset(728UL)]
        public ulong OwnerProcessId { get => ReadHere<ulong>(nameof(OwnerProcessId)); set => WriteHere(nameof(OwnerProcessId), value); }

        [Offset(736UL)]
        public IntPtr Peb { get => ReadHere<IntPtr>(nameof(Peb)); set => WriteHere(nameof(Peb), value); }

        [Offset(744UL)]
        public IntPtr Session { get => ReadHere<IntPtr>(nameof(Session)); set => WriteHere(nameof(Session), value); }

        [Offset(752UL)]
        public IntPtr Spare1 { get => ReadHere<IntPtr>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(760UL)]
        public IntPtr QuotaBlock { get => ReadHere<IntPtr>(nameof(QuotaBlock)); set => WriteHere(nameof(QuotaBlock), value); }

        [Offset(768UL)]
        public IntPtr ObjectTable { get => ReadHere<IntPtr>(nameof(ObjectTable)); set => WriteHere(nameof(ObjectTable), value); }

        [Offset(776UL)]
        public IntPtr DebugPort { get => ReadHere<IntPtr>(nameof(DebugPort)); set => WriteHere(nameof(DebugPort), value); }

        [Offset(784UL)]
        public IntPtr WoW64Process { get => ReadHere<IntPtr>(nameof(WoW64Process)); set => WriteHere(nameof(WoW64Process), value); }

        [Offset(792UL)]
        public ExFastRef DeviceMap { get => ReadStructure<ExFastRef>(nameof(DeviceMap)); set => WriteStructure(nameof(DeviceMap), value); }

        [Offset(800UL)]
        public IntPtr EtwDataSource { get => ReadHere<IntPtr>(nameof(EtwDataSource)); set => WriteHere(nameof(EtwDataSource), value); }

        [Offset(808UL)]
        public ulong PageDirectoryPte { get => ReadHere<ulong>(nameof(PageDirectoryPte)); set => WriteHere(nameof(PageDirectoryPte), value); }

        [Offset(816UL)]
        public IntPtr ImageFilePointer { get => ReadHere<IntPtr>(nameof(ImageFilePointer)); set => WriteHere(nameof(ImageFilePointer), value); }

        [Offset(824UL)]
        [Length(15)]
        public DynamicArray ImageFileName { get => ReadStructure<DynamicArray>(nameof(ImageFileName)); set => WriteStructure(nameof(ImageFileName), value); }

        [Offset(839UL)]
        public byte PriorityClass { get => ReadHere<byte>(nameof(PriorityClass)); set => WriteHere(nameof(PriorityClass), value); }

        [Offset(840UL)]
        public IntPtr SecurityPort { get => ReadHere<IntPtr>(nameof(SecurityPort)); set => WriteHere(nameof(SecurityPort), value); }

        [Offset(848UL)]
        public SeAuditProcessCreationInfo SeAuditProcessCreationInfo { get => ReadStructure<SeAuditProcessCreationInfo>(nameof(SeAuditProcessCreationInfo)); set => WriteStructure(nameof(SeAuditProcessCreationInfo), value); }

        [Offset(856UL)]
        public ListEntry JobLinks { get => ReadStructure<ListEntry>(nameof(JobLinks)); set => WriteStructure(nameof(JobLinks), value); }

        [Offset(872UL)]
        public IntPtr HighestUserAddress { get => ReadHere<IntPtr>(nameof(HighestUserAddress)); set => WriteHere(nameof(HighestUserAddress), value); }

        [Offset(880UL)]
        public ListEntry ThreadListHead { get => ReadStructure<ListEntry>(nameof(ThreadListHead)); set => WriteStructure(nameof(ThreadListHead), value); }

        [Offset(896UL)]
        public uint ActiveThreads { get => ReadHere<uint>(nameof(ActiveThreads)); set => WriteHere(nameof(ActiveThreads), value); }

        [Offset(900UL)]
        public uint ImagePathHash { get => ReadHere<uint>(nameof(ImagePathHash)); set => WriteHere(nameof(ImagePathHash), value); }

        [Offset(904UL)]
        public uint DefaultHardErrorProcessing { get => ReadHere<uint>(nameof(DefaultHardErrorProcessing)); set => WriteHere(nameof(DefaultHardErrorProcessing), value); }

        [Offset(908UL)]
        public int LastThreadExitStatus { get => ReadHere<int>(nameof(LastThreadExitStatus)); set => WriteHere(nameof(LastThreadExitStatus), value); }

        [Offset(912UL)]
        public ExFastRef PrefetchTrace { get => ReadStructure<ExFastRef>(nameof(PrefetchTrace)); set => WriteStructure(nameof(PrefetchTrace), value); }

        [Offset(920UL)]
        public IntPtr LockedPagesList { get => ReadHere<IntPtr>(nameof(LockedPagesList)); set => WriteHere(nameof(LockedPagesList), value); }

        [Offset(928UL)]
        public LargeInteger ReadOperationCount { get => ReadStructure<LargeInteger>(nameof(ReadOperationCount)); set => WriteStructure(nameof(ReadOperationCount), value); }

        [Offset(936UL)]
        public LargeInteger WriteOperationCount { get => ReadStructure<LargeInteger>(nameof(WriteOperationCount)); set => WriteStructure(nameof(WriteOperationCount), value); }

        [Offset(944UL)]
        public LargeInteger OtherOperationCount { get => ReadStructure<LargeInteger>(nameof(OtherOperationCount)); set => WriteStructure(nameof(OtherOperationCount), value); }

        [Offset(952UL)]
        public LargeInteger ReadTransferCount { get => ReadStructure<LargeInteger>(nameof(ReadTransferCount)); set => WriteStructure(nameof(ReadTransferCount), value); }

        [Offset(960UL)]
        public LargeInteger WriteTransferCount { get => ReadStructure<LargeInteger>(nameof(WriteTransferCount)); set => WriteStructure(nameof(WriteTransferCount), value); }

        [Offset(968UL)]
        public LargeInteger OtherTransferCount { get => ReadStructure<LargeInteger>(nameof(OtherTransferCount)); set => WriteStructure(nameof(OtherTransferCount), value); }

        [Offset(976UL)]
        public ulong CommitChargeLimit { get => ReadHere<ulong>(nameof(CommitChargeLimit)); set => WriteHere(nameof(CommitChargeLimit), value); }

        [Offset(984UL)]
        public ulong CommitCharge { get => ReadHere<ulong>(nameof(CommitCharge)); set => WriteHere(nameof(CommitCharge), value); }

        [Offset(992UL)]
        public ulong CommitChargePeak { get => ReadHere<ulong>(nameof(CommitChargePeak)); set => WriteHere(nameof(CommitChargePeak), value); }

        [Offset(1024UL)]
        public MmsupportFull Vm { get => ReadStructure<MmsupportFull>(nameof(Vm)); set => WriteStructure(nameof(Vm), value); }

        [Offset(1344UL)]
        public ListEntry MmProcessLinks { get => ReadStructure<ListEntry>(nameof(MmProcessLinks)); set => WriteStructure(nameof(MmProcessLinks), value); }

        [Offset(1360UL)]
        public uint ModifiedPageCount { get => ReadHere<uint>(nameof(ModifiedPageCount)); set => WriteHere(nameof(ModifiedPageCount), value); }

        [Offset(1364UL)]
        public int ExitStatus { get => ReadHere<int>(nameof(ExitStatus)); set => WriteHere(nameof(ExitStatus), value); }

        [Offset(1368UL)]
        public RtlAvlTree VadRoot { get => ReadStructure<RtlAvlTree>(nameof(VadRoot)); set => WriteStructure(nameof(VadRoot), value); }

        [Offset(1376UL)]
        public IntPtr VadHint { get => ReadHere<IntPtr>(nameof(VadHint)); set => WriteHere(nameof(VadHint), value); }

        [Offset(1384UL)]
        public ulong VadCount { get => ReadHere<ulong>(nameof(VadCount)); set => WriteHere(nameof(VadCount), value); }

        [Offset(1392UL)]
        public ulong VadPhysicalPages { get => ReadHere<ulong>(nameof(VadPhysicalPages)); set => WriteHere(nameof(VadPhysicalPages), value); }

        [Offset(1400UL)]
        public ulong VadPhysicalPagesLimit { get => ReadHere<ulong>(nameof(VadPhysicalPagesLimit)); set => WriteHere(nameof(VadPhysicalPagesLimit), value); }

        [Offset(1408UL)]
        public AlpcProcessContext AlpcContext { get => ReadStructure<AlpcProcessContext>(nameof(AlpcContext)); set => WriteStructure(nameof(AlpcContext), value); }

        [Offset(1440UL)]
        public ListEntry TimerResolutionLink { get => ReadStructure<ListEntry>(nameof(TimerResolutionLink)); set => WriteStructure(nameof(TimerResolutionLink), value); }

        [Offset(1456UL)]
        public IntPtr TimerResolutionStackRecord { get => ReadHere<IntPtr>(nameof(TimerResolutionStackRecord)); set => WriteHere(nameof(TimerResolutionStackRecord), value); }

        [Offset(1464UL)]
        public uint RequestedTimerResolution { get => ReadHere<uint>(nameof(RequestedTimerResolution)); set => WriteHere(nameof(RequestedTimerResolution), value); }

        [Offset(1468UL)]
        public uint SmallestTimerResolution { get => ReadHere<uint>(nameof(SmallestTimerResolution)); set => WriteHere(nameof(SmallestTimerResolution), value); }

        [Offset(1472UL)]
        public LargeInteger ExitTime { get => ReadStructure<LargeInteger>(nameof(ExitTime)); set => WriteStructure(nameof(ExitTime), value); }

        [Offset(1480UL)]
        public IntPtr InvertedFunctionTable { get => ReadHere<IntPtr>(nameof(InvertedFunctionTable)); set => WriteHere(nameof(InvertedFunctionTable), value); }

        [Offset(1488UL)]
        public ExPushLock InvertedFunctionTableLock { get => ReadStructure<ExPushLock>(nameof(InvertedFunctionTableLock)); set => WriteStructure(nameof(InvertedFunctionTableLock), value); }

        [Offset(1496UL)]
        public uint ActiveThreadsHighWatermark { get => ReadHere<uint>(nameof(ActiveThreadsHighWatermark)); set => WriteHere(nameof(ActiveThreadsHighWatermark), value); }

        [Offset(1500UL)]
        public uint LargePrivateVadCount { get => ReadHere<uint>(nameof(LargePrivateVadCount)); set => WriteHere(nameof(LargePrivateVadCount), value); }

        [Offset(1504UL)]
        public ExPushLock ThreadListLock { get => ReadStructure<ExPushLock>(nameof(ThreadListLock)); set => WriteStructure(nameof(ThreadListLock), value); }

        [Offset(1512UL)]
        public IntPtr WnfContext { get => ReadHere<IntPtr>(nameof(WnfContext)); set => WriteHere(nameof(WnfContext), value); }

        [Offset(1520UL)]
        public IntPtr ServerSilo { get => ReadHere<IntPtr>(nameof(ServerSilo)); set => WriteHere(nameof(ServerSilo), value); }

        [Offset(1528UL)]
        public byte SignatureLevel { get => ReadHere<byte>(nameof(SignatureLevel)); set => WriteHere(nameof(SignatureLevel), value); }

        [Offset(1529UL)]
        public byte SectionSignatureLevel { get => ReadHere<byte>(nameof(SectionSignatureLevel)); set => WriteHere(nameof(SectionSignatureLevel), value); }

        [Offset(1530UL)]
        public PsProtection Protection { get => ReadStructure<PsProtection>(nameof(Protection)); set => WriteStructure(nameof(Protection), value); }

        [Offset(1531UL)]
        public byte HangCount { get => ReadHere<byte>(nameof(HangCount)); set => WriteHere(nameof(HangCount), value); }

        [Offset(1531UL)]
        public byte GhostCount { get => ReadHere<byte>(nameof(GhostCount)); set => WriteHere(nameof(GhostCount), value); }

        [Offset(1531UL)]
        public byte PrefilterException { get => ReadHere<byte>(nameof(PrefilterException)); set => WriteHere(nameof(PrefilterException), value); }

        [Offset(1532UL)]
        public uint Flags3 { get => ReadHere<uint>(nameof(Flags3)); set => WriteHere(nameof(Flags3), value); }

        [Offset(1532UL)]
        public uint Minimal { get => ReadHere<uint>(nameof(Minimal)); set => WriteHere(nameof(Minimal), value); }

        [Offset(1532UL)]
        public uint ReplacingPageRoot { get => ReadHere<uint>(nameof(ReplacingPageRoot)); set => WriteHere(nameof(ReplacingPageRoot), value); }

        [Offset(1532UL)]
        public uint Crashed { get => ReadHere<uint>(nameof(Crashed)); set => WriteHere(nameof(Crashed), value); }

        [Offset(1532UL)]
        public uint JobVadsAreTracked { get => ReadHere<uint>(nameof(JobVadsAreTracked)); set => WriteHere(nameof(JobVadsAreTracked), value); }

        [Offset(1532UL)]
        public uint VadTrackingDisabled { get => ReadHere<uint>(nameof(VadTrackingDisabled)); set => WriteHere(nameof(VadTrackingDisabled), value); }

        [Offset(1532UL)]
        public uint AuxiliaryProcess { get => ReadHere<uint>(nameof(AuxiliaryProcess)); set => WriteHere(nameof(AuxiliaryProcess), value); }

        [Offset(1532UL)]
        public uint SubsystemProcess { get => ReadHere<uint>(nameof(SubsystemProcess)); set => WriteHere(nameof(SubsystemProcess), value); }

        [Offset(1532UL)]
        public uint IndirectCpuSets { get => ReadHere<uint>(nameof(IndirectCpuSets)); set => WriteHere(nameof(IndirectCpuSets), value); }

        [Offset(1532UL)]
        public uint RelinquishedCommit { get => ReadHere<uint>(nameof(RelinquishedCommit)); set => WriteHere(nameof(RelinquishedCommit), value); }

        [Offset(1532UL)]
        public uint HighGraphicsPriority { get => ReadHere<uint>(nameof(HighGraphicsPriority)); set => WriteHere(nameof(HighGraphicsPriority), value); }

        [Offset(1532UL)]
        public uint CommitFailLogged { get => ReadHere<uint>(nameof(CommitFailLogged)); set => WriteHere(nameof(CommitFailLogged), value); }

        [Offset(1532UL)]
        public uint ReserveFailLogged { get => ReadHere<uint>(nameof(ReserveFailLogged)); set => WriteHere(nameof(ReserveFailLogged), value); }

        [Offset(1532UL)]
        public uint SystemProcess { get => ReadHere<uint>(nameof(SystemProcess)); set => WriteHere(nameof(SystemProcess), value); }

        [Offset(1532UL)]
        public uint AllImagesAtBasePristineBase { get => ReadHere<uint>(nameof(AllImagesAtBasePristineBase)); set => WriteHere(nameof(AllImagesAtBasePristineBase), value); }

        [Offset(1532UL)]
        public uint AddressPolicyFrozen { get => ReadHere<uint>(nameof(AddressPolicyFrozen)); set => WriteHere(nameof(AddressPolicyFrozen), value); }

        [Offset(1532UL)]
        public uint ProcessFirstResume { get => ReadHere<uint>(nameof(ProcessFirstResume)); set => WriteHere(nameof(ProcessFirstResume), value); }

        [Offset(1532UL)]
        public uint ForegroundExternal { get => ReadHere<uint>(nameof(ForegroundExternal)); set => WriteHere(nameof(ForegroundExternal), value); }

        [Offset(1532UL)]
        public uint ForegroundSystem { get => ReadHere<uint>(nameof(ForegroundSystem)); set => WriteHere(nameof(ForegroundSystem), value); }

        [Offset(1532UL)]
        public uint HighMemoryPriority { get => ReadHere<uint>(nameof(HighMemoryPriority)); set => WriteHere(nameof(HighMemoryPriority), value); }

        [Offset(1532UL)]
        public uint EnableProcessSuspendResumeLogging { get => ReadHere<uint>(nameof(EnableProcessSuspendResumeLogging)); set => WriteHere(nameof(EnableProcessSuspendResumeLogging), value); }

        [Offset(1532UL)]
        public uint EnableThreadSuspendResumeLogging { get => ReadHere<uint>(nameof(EnableThreadSuspendResumeLogging)); set => WriteHere(nameof(EnableThreadSuspendResumeLogging), value); }

        [Offset(1532UL)]
        public uint SecurityDomainChanged { get => ReadHere<uint>(nameof(SecurityDomainChanged)); set => WriteHere(nameof(SecurityDomainChanged), value); }

        [Offset(1532UL)]
        public uint SecurityFreezeComplete { get => ReadHere<uint>(nameof(SecurityFreezeComplete)); set => WriteHere(nameof(SecurityFreezeComplete), value); }

        [Offset(1532UL)]
        public uint VmProcessorHost { get => ReadHere<uint>(nameof(VmProcessorHost)); set => WriteHere(nameof(VmProcessorHost), value); }

        [Offset(1532UL)]
        public uint VmProcessorHostTransition { get => ReadHere<uint>(nameof(VmProcessorHostTransition)); set => WriteHere(nameof(VmProcessorHostTransition), value); }

        [Offset(1532UL)]
        public uint AltSyscall { get => ReadHere<uint>(nameof(AltSyscall)); set => WriteHere(nameof(AltSyscall), value); }

        [Offset(1532UL)]
        public uint TimerResolutionIgnore { get => ReadHere<uint>(nameof(TimerResolutionIgnore)); set => WriteHere(nameof(TimerResolutionIgnore), value); }

        [Offset(1532UL)]
        public uint DisallowUserTerminate { get => ReadHere<uint>(nameof(DisallowUserTerminate)); set => WriteHere(nameof(DisallowUserTerminate), value); }

        [Offset(1532UL)]
        public uint EnableProcessRemoteExecProtectVmLogging { get => ReadHere<uint>(nameof(EnableProcessRemoteExecProtectVmLogging)); set => WriteHere(nameof(EnableProcessRemoteExecProtectVmLogging), value); }

        [Offset(1532UL)]
        public uint EnableProcessLocalExecProtectVmLogging { get => ReadHere<uint>(nameof(EnableProcessLocalExecProtectVmLogging)); set => WriteHere(nameof(EnableProcessLocalExecProtectVmLogging), value); }

        [Offset(1532UL)]
        public uint MemoryCompressionProcess { get => ReadHere<uint>(nameof(MemoryCompressionProcess)); set => WriteHere(nameof(MemoryCompressionProcess), value); }

        [Offset(1532UL)]
        public uint EnableProcessImpersonationLogging { get => ReadHere<uint>(nameof(EnableProcessImpersonationLogging)); set => WriteHere(nameof(EnableProcessImpersonationLogging), value); }

        [Offset(1536UL)]
        public int DeviceAsid { get => ReadHere<int>(nameof(DeviceAsid)); set => WriteHere(nameof(DeviceAsid), value); }

        [Offset(1544UL)]
        public IntPtr SvmData { get => ReadHere<IntPtr>(nameof(SvmData)); set => WriteHere(nameof(SvmData), value); }

        [Offset(1552UL)]
        public ExPushLock SvmProcessLock { get => ReadStructure<ExPushLock>(nameof(SvmProcessLock)); set => WriteStructure(nameof(SvmProcessLock), value); }

        [Offset(1560UL)]
        public ulong SvmLock { get => ReadHere<ulong>(nameof(SvmLock)); set => WriteHere(nameof(SvmLock), value); }

        [Offset(1568UL)]
        public ListEntry SvmProcessDeviceListHead { get => ReadStructure<ListEntry>(nameof(SvmProcessDeviceListHead)); set => WriteStructure(nameof(SvmProcessDeviceListHead), value); }

        [Offset(1584UL)]
        public ulong LastFreezeInterruptTime { get => ReadHere<ulong>(nameof(LastFreezeInterruptTime)); set => WriteHere(nameof(LastFreezeInterruptTime), value); }

        [Offset(1592UL)]
        public IntPtr DiskCounters { get => ReadHere<IntPtr>(nameof(DiskCounters)); set => WriteHere(nameof(DiskCounters), value); }

        [Offset(1600UL)]
        public IntPtr PicoContext { get => ReadHere<IntPtr>(nameof(PicoContext)); set => WriteHere(nameof(PicoContext), value); }

        [Offset(1608UL)]
        public IntPtr EnclaveTable { get => ReadHere<IntPtr>(nameof(EnclaveTable)); set => WriteHere(nameof(EnclaveTable), value); }

        [Offset(1616UL)]
        public ulong EnclaveNumber { get => ReadHere<ulong>(nameof(EnclaveNumber)); set => WriteHere(nameof(EnclaveNumber), value); }

        [Offset(1624UL)]
        public ExPushLock EnclaveLock { get => ReadStructure<ExPushLock>(nameof(EnclaveLock)); set => WriteStructure(nameof(EnclaveLock), value); }

        [Offset(1632UL)]
        public uint HighPriorityFaultsAllowed { get => ReadHere<uint>(nameof(HighPriorityFaultsAllowed)); set => WriteHere(nameof(HighPriorityFaultsAllowed), value); }

        [Offset(1640UL)]
        public IntPtr EnergyContext { get => ReadHere<IntPtr>(nameof(EnergyContext)); set => WriteHere(nameof(EnergyContext), value); }

        [Offset(1648UL)]
        public IntPtr VmContext { get => ReadHere<IntPtr>(nameof(VmContext)); set => WriteHere(nameof(VmContext), value); }

        [Offset(1656UL)]
        public ulong SequenceNumber { get => ReadHere<ulong>(nameof(SequenceNumber)); set => WriteHere(nameof(SequenceNumber), value); }

        [Offset(1664UL)]
        public ulong CreateInterruptTime { get => ReadHere<ulong>(nameof(CreateInterruptTime)); set => WriteHere(nameof(CreateInterruptTime), value); }

        [Offset(1672UL)]
        public ulong CreateUnbiasedInterruptTime { get => ReadHere<ulong>(nameof(CreateUnbiasedInterruptTime)); set => WriteHere(nameof(CreateUnbiasedInterruptTime), value); }

        [Offset(1680UL)]
        public ulong TotalUnbiasedFrozenTime { get => ReadHere<ulong>(nameof(TotalUnbiasedFrozenTime)); set => WriteHere(nameof(TotalUnbiasedFrozenTime), value); }

        [Offset(1688UL)]
        public ulong LastAppStateUpdateTime { get => ReadHere<ulong>(nameof(LastAppStateUpdateTime)); set => WriteHere(nameof(LastAppStateUpdateTime), value); }

        [Offset(1696UL)]
        public ulong LastAppStateUptime { get => ReadHere<ulong>(nameof(LastAppStateUptime)); set => WriteHere(nameof(LastAppStateUptime), value); }

        [Offset(1696UL)]
        public ulong LastAppState { get => ReadHere<ulong>(nameof(LastAppState)); set => WriteHere(nameof(LastAppState), value); }

        [Offset(1704UL)]
        public ulong SharedCommitCharge { get => ReadHere<ulong>(nameof(SharedCommitCharge)); set => WriteHere(nameof(SharedCommitCharge), value); }

        [Offset(1712UL)]
        public ExPushLock SharedCommitLock { get => ReadStructure<ExPushLock>(nameof(SharedCommitLock)); set => WriteStructure(nameof(SharedCommitLock), value); }

        [Offset(1720UL)]
        public ListEntry SharedCommitLinks { get => ReadStructure<ListEntry>(nameof(SharedCommitLinks)); set => WriteStructure(nameof(SharedCommitLinks), value); }

        [Offset(1736UL)]
        public ulong AllowedCpuSets { get => ReadHere<ulong>(nameof(AllowedCpuSets)); set => WriteHere(nameof(AllowedCpuSets), value); }

        [Offset(1744UL)]
        public ulong DefaultCpuSets { get => ReadHere<ulong>(nameof(DefaultCpuSets)); set => WriteHere(nameof(DefaultCpuSets), value); }

        [Offset(1736UL)]
        public IntPtr AllowedCpuSetsIndirect { get => ReadHere<IntPtr>(nameof(AllowedCpuSetsIndirect)); set => WriteHere(nameof(AllowedCpuSetsIndirect), value); }

        [Offset(1744UL)]
        public IntPtr DefaultCpuSetsIndirect { get => ReadHere<IntPtr>(nameof(DefaultCpuSetsIndirect)); set => WriteHere(nameof(DefaultCpuSetsIndirect), value); }

        [Offset(1752UL)]
        public IntPtr DiskIoAttribution { get => ReadHere<IntPtr>(nameof(DiskIoAttribution)); set => WriteHere(nameof(DiskIoAttribution), value); }

        [Offset(1760UL)]
        public IntPtr DxgProcess { get => ReadHere<IntPtr>(nameof(DxgProcess)); set => WriteHere(nameof(DxgProcess), value); }

        [Offset(1768UL)]
        public uint Win32KFilterSet { get => ReadHere<uint>(nameof(Win32KFilterSet)); set => WriteHere(nameof(Win32KFilterSet), value); }

        [Offset(1772UL)]
        public ushort Machine { get => ReadHere<ushort>(nameof(Machine)); set => WriteHere(nameof(Machine), value); }

        [Offset(1774UL)]
        public byte MmSlabIdentity { get => ReadHere<byte>(nameof(MmSlabIdentity)); set => WriteHere(nameof(MmSlabIdentity), value); }

        [Offset(1775UL)]
        public byte Spare0 { get => ReadHere<byte>(nameof(Spare0)); set => WriteHere(nameof(Spare0), value); }

        [Offset(1776UL)]
        public PsInterlockedTimerDelayValues ProcessTimerDelay { get => ReadStructure<PsInterlockedTimerDelayValues>(nameof(ProcessTimerDelay)); set => WriteStructure(nameof(ProcessTimerDelay), value); }

        [Offset(1784UL)]
        public uint KTimerSets { get => ReadHere<uint>(nameof(KTimerSets)); set => WriteHere(nameof(KTimerSets), value); }

        [Offset(1788UL)]
        public uint KTimer2Sets { get => ReadHere<uint>(nameof(KTimer2Sets)); set => WriteHere(nameof(KTimer2Sets), value); }

        [Offset(1792UL)]
        public uint ThreadTimerSets { get => ReadHere<uint>(nameof(ThreadTimerSets)); set => WriteHere(nameof(ThreadTimerSets), value); }

        [Offset(1800UL)]
        public ulong VirtualTimerListLock { get => ReadHere<ulong>(nameof(VirtualTimerListLock)); set => WriteHere(nameof(VirtualTimerListLock), value); }

        [Offset(1808UL)]
        public ListEntry VirtualTimerListHead { get => ReadStructure<ListEntry>(nameof(VirtualTimerListHead)); set => WriteStructure(nameof(VirtualTimerListHead), value); }

        [Offset(1824UL)]
        public WnfStateName WakeChannel { get => ReadStructure<WnfStateName>(nameof(WakeChannel)); set => WriteStructure(nameof(WakeChannel), value); }

        [Offset(1824UL)]
        public PsProcessWakeInformation WakeInfo { get => ReadStructure<PsProcessWakeInformation>(nameof(WakeInfo)); set => WriteStructure(nameof(WakeInfo), value); }

        [Offset(1872UL)]
        public uint MitigationFlags { get => ReadHere<uint>(nameof(MitigationFlags)); set => WriteHere(nameof(MitigationFlags), value); }

        [Offset(1872UL)]
        public UnnamedTag MitigationFlagsValues { get => ReadStructure<UnnamedTag>(nameof(MitigationFlagsValues)); set => WriteStructure(nameof(MitigationFlagsValues), value); }

        [Offset(1876UL)]
        public uint MitigationFlags2 { get => ReadHere<uint>(nameof(MitigationFlags2)); set => WriteHere(nameof(MitigationFlags2), value); }

        [Offset(1876UL)]
        public UnnamedTag MitigationFlags2Values { get => ReadStructure<UnnamedTag>(nameof(MitigationFlags2Values)); set => WriteStructure(nameof(MitigationFlags2Values), value); }

        [Offset(1880UL)]
        public IntPtr PartitionObject { get => ReadHere<IntPtr>(nameof(PartitionObject)); set => WriteHere(nameof(PartitionObject), value); }

        [Offset(1888UL)]
        public ulong SecurityDomain { get => ReadHere<ulong>(nameof(SecurityDomain)); set => WriteHere(nameof(SecurityDomain), value); }

        [Offset(1896UL)]
        public ulong ParentSecurityDomain { get => ReadHere<ulong>(nameof(ParentSecurityDomain)); set => WriteHere(nameof(ParentSecurityDomain), value); }

        [Offset(1904UL)]
        public IntPtr CoverageSamplerContext { get => ReadHere<IntPtr>(nameof(CoverageSamplerContext)); set => WriteHere(nameof(CoverageSamplerContext), value); }

        [Offset(1912UL)]
        public IntPtr MmHotPatchContext { get => ReadHere<IntPtr>(nameof(MmHotPatchContext)); set => WriteHere(nameof(MmHotPatchContext), value); }

        [Offset(1920UL)]
        public RtlAvlTree DynamicEHContinuationTargetsTree { get => ReadStructure<RtlAvlTree>(nameof(DynamicEHContinuationTargetsTree)); set => WriteStructure(nameof(DynamicEHContinuationTargetsTree), value); }

        [Offset(1928UL)]
        public ExPushLock DynamicEHContinuationTargetsLock { get => ReadStructure<ExPushLock>(nameof(DynamicEHContinuationTargetsLock)); set => WriteStructure(nameof(DynamicEHContinuationTargetsLock), value); }

        [Offset(1936UL)]
        public PsDynamicEnforcedAddressRanges DynamicEnforcedCetCompatibleRanges { get => ReadStructure<PsDynamicEnforcedAddressRanges>(nameof(DynamicEnforcedCetCompatibleRanges)); set => WriteStructure(nameof(DynamicEnforcedCetCompatibleRanges), value); }

        [Offset(1952UL)]
        public uint DisabledComponentFlags { get => ReadHere<uint>(nameof(DisabledComponentFlags)); set => WriteHere(nameof(DisabledComponentFlags), value); }

        [Offset(1956UL)]
        public int PageCombineSequence { get => ReadHere<int>(nameof(PageCombineSequence)); set => WriteHere(nameof(PageCombineSequence), value); }

        [Offset(1960UL)]
        public ExPushLock EnableOptionalXStateFeaturesLock { get => ReadStructure<ExPushLock>(nameof(EnableOptionalXStateFeaturesLock)); set => WriteStructure(nameof(EnableOptionalXStateFeaturesLock), value); }

        [Offset(1968UL)]
        public IntPtr PathRedirectionHashes { get => ReadHere<IntPtr>(nameof(PathRedirectionHashes)); set => WriteHere(nameof(PathRedirectionHashes), value); }

        [Offset(1976UL)]
        public IntPtr SyscallProvider { get => ReadHere<IntPtr>(nameof(SyscallProvider)); set => WriteHere(nameof(SyscallProvider), value); }

        [Offset(1984UL)]
        public ListEntry SyscallProviderProcessLinks { get => ReadStructure<ListEntry>(nameof(SyscallProviderProcessLinks)); set => WriteStructure(nameof(SyscallProviderProcessLinks), value); }

        [Offset(2000UL)]
        public PspSyscallProviderDispatchContext SyscallProviderDispatchContext { get => ReadStructure<PspSyscallProviderDispatchContext>(nameof(SyscallProviderDispatchContext)); set => WriteStructure(nameof(SyscallProviderDispatchContext), value); }

        [Offset(2008UL)]
        public uint MitigationFlags3 { get => ReadHere<uint>(nameof(MitigationFlags3)); set => WriteHere(nameof(MitigationFlags3), value); }

        [Offset(2008UL)]
        public UnnamedTag MitigationFlags3Values { get => ReadStructure<UnnamedTag>(nameof(MitigationFlags3Values)); set => WriteStructure(nameof(MitigationFlags3Values), value); }

        [Offset(2012UL)]
        public uint Flags4 { get => ReadHere<uint>(nameof(Flags4)); set => WriteHere(nameof(Flags4), value); }

        [Offset(2012UL)]
        public uint ThreadWasActive { get => ReadHere<uint>(nameof(ThreadWasActive)); set => WriteHere(nameof(ThreadWasActive), value); }

        [Offset(2012UL)]
        public uint MinimalTerminate { get => ReadHere<uint>(nameof(MinimalTerminate)); set => WriteHere(nameof(MinimalTerminate), value); }

        [Offset(2012UL)]
        public uint ImageExpansionDisable { get => ReadHere<uint>(nameof(ImageExpansionDisable)); set => WriteHere(nameof(ImageExpansionDisable), value); }

        [Offset(2012UL)]
        public uint SessionFirstProcess { get => ReadHere<uint>(nameof(SessionFirstProcess)); set => WriteHere(nameof(SessionFirstProcess), value); }

        [Offset(2016UL)]
        public uint SyscallUsage { get => ReadHere<uint>(nameof(SyscallUsage)); set => WriteHere(nameof(SyscallUsage), value); }

        [Offset(2016UL)]
        public UnnamedTag SyscallUsageValues { get => ReadStructure<UnnamedTag>(nameof(SyscallUsageValues)); set => WriteStructure(nameof(SyscallUsageValues), value); }

        [Offset(2020UL)]
        public int SupervisorDeviceAsid { get => ReadHere<int>(nameof(SupervisorDeviceAsid)); set => WriteHere(nameof(SupervisorDeviceAsid), value); }

        [Offset(2024UL)]
        public IntPtr SupervisorSvmData { get => ReadHere<IntPtr>(nameof(SupervisorSvmData)); set => WriteHere(nameof(SupervisorSvmData), value); }

        [Offset(2032UL)]
        public IntPtr NetworkCounters { get => ReadHere<IntPtr>(nameof(NetworkCounters)); set => WriteHere(nameof(NetworkCounters), value); }

        [Offset(2040UL)]
        public ProcessExecution Execution { get => ReadStructure<ProcessExecution>(nameof(Execution)); set => WriteStructure(nameof(Execution), value); }

        [Offset(2048UL)]
        public IntPtr ThreadIndexTable { get => ReadHere<IntPtr>(nameof(ThreadIndexTable)); set => WriteHere(nameof(ThreadIndexTable), value); }

        [Offset(2056UL)]
        public ListEntry FreezeWorkLinks { get => ReadStructure<ListEntry>(nameof(FreezeWorkLinks)); set => WriteStructure(nameof(FreezeWorkLinks), value); }

        public Eprocess(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Eprocess>();
        }
    }
}