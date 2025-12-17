using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTHREAD")]
    public sealed class Kthread : DynamicStructure
    {
        [Offset(0UL)]
        public DispatcherHeader Header { get => ReadStructure<DispatcherHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(24UL)]
        public IntPtr SListFaultAddress { get => ReadHere<IntPtr>(nameof(SListFaultAddress)); set => WriteHere(nameof(SListFaultAddress), value); }

        [Offset(32UL)]
        public ulong QuantumTarget { get => ReadHere<ulong>(nameof(QuantumTarget)); set => WriteHere(nameof(QuantumTarget), value); }

        [Offset(40UL)]
        public IntPtr InitialStack { get => ReadHere<IntPtr>(nameof(InitialStack)); set => WriteHere(nameof(InitialStack), value); }

        [Offset(48UL)]
        public IntPtr StackLimit { get => ReadHere<IntPtr>(nameof(StackLimit)); set => WriteHere(nameof(StackLimit), value); }

        [Offset(56UL)]
        public IntPtr StackBase { get => ReadHere<IntPtr>(nameof(StackBase)); set => WriteHere(nameof(StackBase), value); }

        [Offset(64UL)]
        public ulong ThreadLock { get => ReadHere<ulong>(nameof(ThreadLock)); set => WriteHere(nameof(ThreadLock), value); }

        [Offset(72UL)]
        public ulong CycleTime { get => ReadHere<ulong>(nameof(CycleTime)); set => WriteHere(nameof(CycleTime), value); }

        [Offset(80UL)]
        public uint CurrentRunTime { get => ReadHere<uint>(nameof(CurrentRunTime)); set => WriteHere(nameof(CurrentRunTime), value); }

        [Offset(84UL)]
        public uint ExpectedRunTime { get => ReadHere<uint>(nameof(ExpectedRunTime)); set => WriteHere(nameof(ExpectedRunTime), value); }

        [Offset(88UL)]
        public IntPtr KernelStack { get => ReadHere<IntPtr>(nameof(KernelStack)); set => WriteHere(nameof(KernelStack), value); }

        [Offset(96UL)]
        public IntPtr StateSaveArea { get => ReadHere<IntPtr>(nameof(StateSaveArea)); set => WriteHere(nameof(StateSaveArea), value); }

        [Offset(104UL)]
        public IntPtr SchedulingGroup { get => ReadHere<IntPtr>(nameof(SchedulingGroup)); set => WriteHere(nameof(SchedulingGroup), value); }

        [Offset(112UL)]
        public KwaitStatusRegister WaitRegister { get => ReadStructure<KwaitStatusRegister>(nameof(WaitRegister)); set => WriteStructure(nameof(WaitRegister), value); }

        [Offset(113UL)]
        public byte Running { get => ReadHere<byte>(nameof(Running)); set => WriteHere(nameof(Running), value); }

        [Offset(114UL)]
        [Length(2)]
        public DynamicArray Alerted { get => ReadStructure<DynamicArray>(nameof(Alerted)); set => WriteStructure(nameof(Alerted), value); }

        [Offset(116UL)]
        public uint AutoBoostActive { get => ReadHere<uint>(nameof(AutoBoostActive)); set => WriteHere(nameof(AutoBoostActive), value); }

        [Offset(116UL)]
        public uint ReadyTransition { get => ReadHere<uint>(nameof(ReadyTransition)); set => WriteHere(nameof(ReadyTransition), value); }

        [Offset(116UL)]
        public uint WaitNext { get => ReadHere<uint>(nameof(WaitNext)); set => WriteHere(nameof(WaitNext), value); }

        [Offset(116UL)]
        public uint SystemAffinityActive { get => ReadHere<uint>(nameof(SystemAffinityActive)); set => WriteHere(nameof(SystemAffinityActive), value); }

        [Offset(116UL)]
        public uint Alertable { get => ReadHere<uint>(nameof(Alertable)); set => WriteHere(nameof(Alertable), value); }

        [Offset(116UL)]
        public uint Reserved1 { get => ReadHere<uint>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(116UL)]
        public uint ApcInterruptRequest { get => ReadHere<uint>(nameof(ApcInterruptRequest)); set => WriteHere(nameof(ApcInterruptRequest), value); }

        [Offset(116UL)]
        public uint QuantumEndMigrate { get => ReadHere<uint>(nameof(QuantumEndMigrate)); set => WriteHere(nameof(QuantumEndMigrate), value); }

        [Offset(116UL)]
        public uint SecureThread { get => ReadHere<uint>(nameof(SecureThread)); set => WriteHere(nameof(SecureThread), value); }

        [Offset(116UL)]
        public uint TimerActive { get => ReadHere<uint>(nameof(TimerActive)); set => WriteHere(nameof(TimerActive), value); }

        [Offset(116UL)]
        public uint SystemThread { get => ReadHere<uint>(nameof(SystemThread)); set => WriteHere(nameof(SystemThread), value); }

        [Offset(116UL)]
        public uint ProcessDetachActive { get => ReadHere<uint>(nameof(ProcessDetachActive)); set => WriteHere(nameof(ProcessDetachActive), value); }

        [Offset(116UL)]
        public uint Reserved2 { get => ReadHere<uint>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(116UL)]
        public uint ScbReadyQueue { get => ReadHere<uint>(nameof(ScbReadyQueue)); set => WriteHere(nameof(ScbReadyQueue), value); }

        [Offset(116UL)]
        public uint ApcQueueable { get => ReadHere<uint>(nameof(ApcQueueable)); set => WriteHere(nameof(ApcQueueable), value); }

        [Offset(116UL)]
        public uint Reserved3 { get => ReadHere<uint>(nameof(Reserved3)); set => WriteHere(nameof(Reserved3), value); }

        [Offset(116UL)]
        public uint WaitNextClearWobPriorityFloor { get => ReadHere<uint>(nameof(WaitNextClearWobPriorityFloor)); set => WriteHere(nameof(WaitNextClearWobPriorityFloor), value); }

        [Offset(116UL)]
        public uint TimerSuspended { get => ReadHere<uint>(nameof(TimerSuspended)); set => WriteHere(nameof(TimerSuspended), value); }

        [Offset(116UL)]
        public uint SuspendedWaitMode { get => ReadHere<uint>(nameof(SuspendedWaitMode)); set => WriteHere(nameof(SuspendedWaitMode), value); }

        [Offset(116UL)]
        public uint SuspendSchedulerApcWait { get => ReadHere<uint>(nameof(SuspendSchedulerApcWait)); set => WriteHere(nameof(SuspendSchedulerApcWait), value); }

        [Offset(116UL)]
        public uint CetUserShadowStack { get => ReadHere<uint>(nameof(CetUserShadowStack)); set => WriteHere(nameof(CetUserShadowStack), value); }

        [Offset(116UL)]
        public uint BypassProcessFreeze { get => ReadHere<uint>(nameof(BypassProcessFreeze)); set => WriteHere(nameof(BypassProcessFreeze), value); }

        [Offset(116UL)]
        public uint CetKernelShadowStack { get => ReadHere<uint>(nameof(CetKernelShadowStack)); set => WriteHere(nameof(CetKernelShadowStack), value); }

        [Offset(116UL)]
        public uint StateSaveAreaDecoupled { get => ReadHere<uint>(nameof(StateSaveAreaDecoupled)); set => WriteHere(nameof(StateSaveAreaDecoupled), value); }

        [Offset(116UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(116UL)]
        public int MiscFlags { get => ReadHere<int>(nameof(MiscFlags)); set => WriteHere(nameof(MiscFlags), value); }

        [Offset(120UL)]
        public uint UserIdealProcessorFixed { get => ReadHere<uint>(nameof(UserIdealProcessorFixed)); set => WriteHere(nameof(UserIdealProcessorFixed), value); }

        [Offset(120UL)]
        public uint IsolationWidth { get => ReadHere<uint>(nameof(IsolationWidth)); set => WriteHere(nameof(IsolationWidth), value); }

        [Offset(120UL)]
        public uint AutoAlignment { get => ReadHere<uint>(nameof(AutoAlignment)); set => WriteHere(nameof(AutoAlignment), value); }

        [Offset(120UL)]
        public uint DisableBoost { get => ReadHere<uint>(nameof(DisableBoost)); set => WriteHere(nameof(DisableBoost), value); }

        [Offset(120UL)]
        public uint AlertedByThreadId { get => ReadHere<uint>(nameof(AlertedByThreadId)); set => WriteHere(nameof(AlertedByThreadId), value); }

        [Offset(120UL)]
        public uint QuantumDonation { get => ReadHere<uint>(nameof(QuantumDonation)); set => WriteHere(nameof(QuantumDonation), value); }

        [Offset(120UL)]
        public uint EnableStackSwap { get => ReadHere<uint>(nameof(EnableStackSwap)); set => WriteHere(nameof(EnableStackSwap), value); }

        [Offset(120UL)]
        public uint GuiThread { get => ReadHere<uint>(nameof(GuiThread)); set => WriteHere(nameof(GuiThread), value); }

        [Offset(120UL)]
        public uint DisableQuantum { get => ReadHere<uint>(nameof(DisableQuantum)); set => WriteHere(nameof(DisableQuantum), value); }

        [Offset(120UL)]
        public uint ChargeOnlySchedulingGroup { get => ReadHere<uint>(nameof(ChargeOnlySchedulingGroup)); set => WriteHere(nameof(ChargeOnlySchedulingGroup), value); }

        [Offset(120UL)]
        public uint DeferPreemption { get => ReadHere<uint>(nameof(DeferPreemption)); set => WriteHere(nameof(DeferPreemption), value); }

        [Offset(120UL)]
        public uint QueueDeferPreemption { get => ReadHere<uint>(nameof(QueueDeferPreemption)); set => WriteHere(nameof(QueueDeferPreemption), value); }

        [Offset(120UL)]
        public uint ForceDeferSchedule { get => ReadHere<uint>(nameof(ForceDeferSchedule)); set => WriteHere(nameof(ForceDeferSchedule), value); }

        [Offset(120UL)]
        public uint SharedReadyQueueAffinity { get => ReadHere<uint>(nameof(SharedReadyQueueAffinity)); set => WriteHere(nameof(SharedReadyQueueAffinity), value); }

        [Offset(120UL)]
        public uint FreezeCount { get => ReadHere<uint>(nameof(FreezeCount)); set => WriteHere(nameof(FreezeCount), value); }

        [Offset(120UL)]
        public uint TerminationApcRequest { get => ReadHere<uint>(nameof(TerminationApcRequest)); set => WriteHere(nameof(TerminationApcRequest), value); }

        [Offset(120UL)]
        public uint AutoBoostEntriesExhausted { get => ReadHere<uint>(nameof(AutoBoostEntriesExhausted)); set => WriteHere(nameof(AutoBoostEntriesExhausted), value); }

        [Offset(120UL)]
        public uint KernelStackResident { get => ReadHere<uint>(nameof(KernelStackResident)); set => WriteHere(nameof(KernelStackResident), value); }

        [Offset(120UL)]
        public uint TerminateRequestReason { get => ReadHere<uint>(nameof(TerminateRequestReason)); set => WriteHere(nameof(TerminateRequestReason), value); }

        [Offset(120UL)]
        public uint ProcessStackCountDecremented { get => ReadHere<uint>(nameof(ProcessStackCountDecremented)); set => WriteHere(nameof(ProcessStackCountDecremented), value); }

        [Offset(120UL)]
        public uint RestrictedGuiThread { get => ReadHere<uint>(nameof(RestrictedGuiThread)); set => WriteHere(nameof(RestrictedGuiThread), value); }

        [Offset(120UL)]
        public uint VpBackingThread { get => ReadHere<uint>(nameof(VpBackingThread)); set => WriteHere(nameof(VpBackingThread), value); }

        [Offset(120UL)]
        public uint EtwStackTraceCrimsonApcDisabled { get => ReadHere<uint>(nameof(EtwStackTraceCrimsonApcDisabled)); set => WriteHere(nameof(EtwStackTraceCrimsonApcDisabled), value); }

        [Offset(120UL)]
        public uint EtwStackTraceApcInserted { get => ReadHere<uint>(nameof(EtwStackTraceApcInserted)); set => WriteHere(nameof(EtwStackTraceApcInserted), value); }

        [Offset(120UL)]
        public int ThreadFlags { get => ReadHere<int>(nameof(ThreadFlags)); set => WriteHere(nameof(ThreadFlags), value); }

        [Offset(124UL)]
        public byte Tag { get => ReadHere<byte>(nameof(Tag)); set => WriteHere(nameof(Tag), value); }

        [Offset(125UL)]
        public byte CalloutActive { get => ReadHere<byte>(nameof(CalloutActive)); set => WriteHere(nameof(CalloutActive), value); }

        [Offset(125UL)]
        public byte ReservedStackInUse { get => ReadHere<byte>(nameof(ReservedStackInUse)); set => WriteHere(nameof(ReservedStackInUse), value); }

        [Offset(125UL)]
        public byte UserStackWalkActive { get => ReadHere<byte>(nameof(UserStackWalkActive)); set => WriteHere(nameof(UserStackWalkActive), value); }

        [Offset(125UL)]
        public byte SameThreadTransientFlagsReserved { get => ReadHere<byte>(nameof(SameThreadTransientFlagsReserved)); set => WriteHere(nameof(SameThreadTransientFlagsReserved), value); }

        [Offset(125UL)]
        public sbyte SameThreadTransientFlags { get => ReadHere<sbyte>(nameof(SameThreadTransientFlags)); set => WriteHere(nameof(SameThreadTransientFlags), value); }

        [Offset(126UL)]
        public byte RunningNonRetpolineCode { get => ReadHere<byte>(nameof(RunningNonRetpolineCode)); set => WriteHere(nameof(RunningNonRetpolineCode), value); }

        [Offset(126UL)]
        public byte SpecCtrlSpare { get => ReadHere<byte>(nameof(SpecCtrlSpare)); set => WriteHere(nameof(SpecCtrlSpare), value); }

        [Offset(126UL)]
        public byte SpecCtrl { get => ReadHere<byte>(nameof(SpecCtrl)); set => WriteHere(nameof(SpecCtrl), value); }

        [Offset(128UL)]
        public uint SystemCallNumber { get => ReadHere<uint>(nameof(SystemCallNumber)); set => WriteHere(nameof(SystemCallNumber), value); }

        [Offset(132UL)]
        public uint ReadyTime { get => ReadHere<uint>(nameof(ReadyTime)); set => WriteHere(nameof(ReadyTime), value); }

        [Offset(136UL)]
        public IntPtr FirstArgument { get => ReadHere<IntPtr>(nameof(FirstArgument)); set => WriteHere(nameof(FirstArgument), value); }

        [Offset(144UL)]
        public IntPtr TrapFrame { get => ReadHere<IntPtr>(nameof(TrapFrame)); set => WriteHere(nameof(TrapFrame), value); }

        [Offset(152UL)]
        public KapcState ApcState { get => ReadStructure<KapcState>(nameof(ApcState)); set => WriteStructure(nameof(ApcState), value); }

        [Offset(152UL)]
        [Length(43)]
        public DynamicArray ApcStateFill { get => ReadStructure<DynamicArray>(nameof(ApcStateFill)); set => WriteStructure(nameof(ApcStateFill), value); }

        [Offset(195UL)]
        public sbyte Priority { get => ReadHere<sbyte>(nameof(Priority)); set => WriteHere(nameof(Priority), value); }

        [Offset(196UL)]
        public uint UserIdealProcessor { get => ReadHere<uint>(nameof(UserIdealProcessor)); set => WriteHere(nameof(UserIdealProcessor), value); }

        [Offset(200UL)]
        public long WaitStatus { get => ReadHere<long>(nameof(WaitStatus)); set => WriteHere(nameof(WaitStatus), value); }

        [Offset(208UL)]
        public IntPtr WaitBlockList { get => ReadHere<IntPtr>(nameof(WaitBlockList)); set => WriteHere(nameof(WaitBlockList), value); }

        [Offset(216UL)]
        public ListEntry WaitListEntry { get => ReadStructure<ListEntry>(nameof(WaitListEntry)); set => WriteStructure(nameof(WaitListEntry), value); }

        [Offset(216UL)]
        public SingleListEntry SwapListEntry { get => ReadStructure<SingleListEntry>(nameof(SwapListEntry)); set => WriteStructure(nameof(SwapListEntry), value); }

        [Offset(232UL)]
        public IntPtr Queue { get => ReadHere<IntPtr>(nameof(Queue)); set => WriteHere(nameof(Queue), value); }

        [Offset(240UL)]
        public IntPtr Teb { get => ReadHere<IntPtr>(nameof(Teb)); set => WriteHere(nameof(Teb), value); }

        [Offset(248UL)]
        public ulong RelativeTimerBias { get => ReadHere<ulong>(nameof(RelativeTimerBias)); set => WriteHere(nameof(RelativeTimerBias), value); }

        [Offset(256UL)]
        public Ktimer Timer { get => ReadStructure<Ktimer>(nameof(Timer)); set => WriteStructure(nameof(Timer), value); }

        [Offset(320UL)]
        [Length(4)]
        public DynamicArray WaitBlock { get => ReadStructure<DynamicArray>(nameof(WaitBlock)); set => WriteStructure(nameof(WaitBlock), value); }

        [Offset(320UL)]
        [Length(20)]
        public DynamicArray WaitBlockFill4 { get => ReadStructure<DynamicArray>(nameof(WaitBlockFill4)); set => WriteStructure(nameof(WaitBlockFill4), value); }

        [Offset(340UL)]
        public uint ContextSwitches { get => ReadHere<uint>(nameof(ContextSwitches)); set => WriteHere(nameof(ContextSwitches), value); }

        [Offset(320UL)]
        [Length(68)]
        public DynamicArray WaitBlockFill5 { get => ReadStructure<DynamicArray>(nameof(WaitBlockFill5)); set => WriteStructure(nameof(WaitBlockFill5), value); }

        [Offset(388UL)]
        public byte State { get => ReadHere<byte>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(389UL)]
        public sbyte Spare13 { get => ReadHere<sbyte>(nameof(Spare13)); set => WriteHere(nameof(Spare13), value); }

        [Offset(390UL)]
        public byte WaitIrql { get => ReadHere<byte>(nameof(WaitIrql)); set => WriteHere(nameof(WaitIrql), value); }

        [Offset(391UL)]
        public sbyte WaitMode { get => ReadHere<sbyte>(nameof(WaitMode)); set => WriteHere(nameof(WaitMode), value); }

        [Offset(320UL)]
        [Length(116)]
        public DynamicArray WaitBlockFill6 { get => ReadStructure<DynamicArray>(nameof(WaitBlockFill6)); set => WriteStructure(nameof(WaitBlockFill6), value); }

        [Offset(436UL)]
        public uint WaitTime { get => ReadHere<uint>(nameof(WaitTime)); set => WriteHere(nameof(WaitTime), value); }

        [Offset(320UL)]
        [Length(164)]
        public DynamicArray WaitBlockFill7 { get => ReadStructure<DynamicArray>(nameof(WaitBlockFill7)); set => WriteStructure(nameof(WaitBlockFill7), value); }

        [Offset(484UL)]
        public short KernelApcDisable { get => ReadHere<short>(nameof(KernelApcDisable)); set => WriteHere(nameof(KernelApcDisable), value); }

        [Offset(486UL)]
        public short SpecialApcDisable { get => ReadHere<short>(nameof(SpecialApcDisable)); set => WriteHere(nameof(SpecialApcDisable), value); }

        [Offset(484UL)]
        public uint CombinedApcDisable { get => ReadHere<uint>(nameof(CombinedApcDisable)); set => WriteHere(nameof(CombinedApcDisable), value); }

        [Offset(320UL)]
        [Length(40)]
        public DynamicArray WaitBlockFill8 { get => ReadStructure<DynamicArray>(nameof(WaitBlockFill8)); set => WriteStructure(nameof(WaitBlockFill8), value); }

        [Offset(360UL)]
        public IntPtr ThreadCounters { get => ReadHere<IntPtr>(nameof(ThreadCounters)); set => WriteHere(nameof(ThreadCounters), value); }

        [Offset(320UL)]
        [Length(88)]
        public DynamicArray WaitBlockFill9 { get => ReadStructure<DynamicArray>(nameof(WaitBlockFill9)); set => WriteStructure(nameof(WaitBlockFill9), value); }

        [Offset(408UL)]
        public IntPtr XStateSave { get => ReadHere<IntPtr>(nameof(XStateSave)); set => WriteHere(nameof(XStateSave), value); }

        [Offset(320UL)]
        [Length(136)]
        public DynamicArray WaitBlockFill10 { get => ReadStructure<DynamicArray>(nameof(WaitBlockFill10)); set => WriteStructure(nameof(WaitBlockFill10), value); }

        [Offset(456UL)]
        public IntPtr Win32Thread { get => ReadHere<IntPtr>(nameof(Win32Thread)); set => WriteHere(nameof(Win32Thread), value); }

        [Offset(320UL)]
        [Length(176)]
        public DynamicArray WaitBlockFill11 { get => ReadStructure<DynamicArray>(nameof(WaitBlockFill11)); set => WriteStructure(nameof(WaitBlockFill11), value); }

        [Offset(496UL)]
        public ulong Spare18 { get => ReadHere<ulong>(nameof(Spare18)); set => WriteHere(nameof(Spare18), value); }

        [Offset(504UL)]
        public ulong LastXStateSaveDebugInfo { get => ReadHere<ulong>(nameof(LastXStateSaveDebugInfo)); set => WriteHere(nameof(LastXStateSaveDebugInfo), value); }

        [Offset(512UL)]
        public int ThreadFlags2 { get => ReadHere<int>(nameof(ThreadFlags2)); set => WriteHere(nameof(ThreadFlags2), value); }

        [Offset(512UL)]
        public uint DisableKasan { get => ReadHere<uint>(nameof(DisableKasan)); set => WriteHere(nameof(DisableKasan), value); }

        [Offset(512UL)]
        public uint AbContextSwitchState { get => ReadHere<uint>(nameof(AbContextSwitchState)); set => WriteHere(nameof(AbContextSwitchState), value); }

        [Offset(512UL)]
        public uint ThreadFlags2Reserved { get => ReadHere<uint>(nameof(ThreadFlags2Reserved)); set => WriteHere(nameof(ThreadFlags2Reserved), value); }

        [Offset(516UL)]
        public byte BamQosLevel { get => ReadHere<byte>(nameof(BamQosLevel)); set => WriteHere(nameof(BamQosLevel), value); }

        [Offset(517UL)]
        public byte HardwareFeedbackClass { get => ReadHere<byte>(nameof(HardwareFeedbackClass)); set => WriteHere(nameof(HardwareFeedbackClass), value); }

        [Offset(518UL)]
        public short PriorityDecrement { get => ReadHere<short>(nameof(PriorityDecrement)); set => WriteHere(nameof(PriorityDecrement), value); }

        [Offset(518UL)]
        public ushort ForegroundBoost { get => ReadHere<ushort>(nameof(ForegroundBoost)); set => WriteHere(nameof(ForegroundBoost), value); }

        [Offset(518UL)]
        public ushort UnusualBoost { get => ReadHere<ushort>(nameof(UnusualBoost)); set => WriteHere(nameof(UnusualBoost), value); }

        [Offset(520UL)]
        public ListEntry QueueListEntry { get => ReadStructure<ListEntry>(nameof(QueueListEntry)); set => WriteStructure(nameof(QueueListEntry), value); }

        [Offset(536UL)]
        public uint NextProcessor { get => ReadHere<uint>(nameof(NextProcessor)); set => WriteHere(nameof(NextProcessor), value); }

        [Offset(536UL)]
        public uint NextProcessorNumber { get => ReadHere<uint>(nameof(NextProcessorNumber)); set => WriteHere(nameof(NextProcessorNumber), value); }

        [Offset(536UL)]
        public uint SharedReadyQueue { get => ReadHere<uint>(nameof(SharedReadyQueue)); set => WriteHere(nameof(SharedReadyQueue), value); }

        [Offset(540UL)]
        public int QueuePriority { get => ReadHere<int>(nameof(QueuePriority)); set => WriteHere(nameof(QueuePriority), value); }

        [Offset(544UL)]
        public IntPtr Process { get => ReadHere<IntPtr>(nameof(Process)); set => WriteHere(nameof(Process), value); }

        [Offset(552UL)]
        public IntPtr UserAffinity { get => ReadHere<IntPtr>(nameof(UserAffinity)); set => WriteHere(nameof(UserAffinity), value); }

        [Offset(560UL)]
        public ushort UserAffinityPrimaryGroup { get => ReadHere<ushort>(nameof(UserAffinityPrimaryGroup)); set => WriteHere(nameof(UserAffinityPrimaryGroup), value); }

        [Offset(562UL)]
        public sbyte PreviousMode { get => ReadHere<sbyte>(nameof(PreviousMode)); set => WriteHere(nameof(PreviousMode), value); }

        [Offset(563UL)]
        public sbyte BasePriority { get => ReadHere<sbyte>(nameof(BasePriority)); set => WriteHere(nameof(BasePriority), value); }

        [Offset(564UL)]
        public byte Spare24 { get => ReadHere<byte>(nameof(Spare24)); set => WriteHere(nameof(Spare24), value); }

        [Offset(565UL)]
        public byte Preempted { get => ReadHere<byte>(nameof(Preempted)); set => WriteHere(nameof(Preempted), value); }

        [Offset(566UL)]
        public byte AdjustReason { get => ReadHere<byte>(nameof(AdjustReason)); set => WriteHere(nameof(AdjustReason), value); }

        [Offset(567UL)]
        public sbyte AdjustIncrement { get => ReadHere<sbyte>(nameof(AdjustIncrement)); set => WriteHere(nameof(AdjustIncrement), value); }

        [Offset(568UL)]
        public ulong AffinityVersion { get => ReadHere<ulong>(nameof(AffinityVersion)); set => WriteHere(nameof(AffinityVersion), value); }

        [Offset(576UL)]
        public IntPtr Affinity { get => ReadHere<IntPtr>(nameof(Affinity)); set => WriteHere(nameof(Affinity), value); }

        [Offset(584UL)]
        public ushort AffinityPrimaryGroup { get => ReadHere<ushort>(nameof(AffinityPrimaryGroup)); set => WriteHere(nameof(AffinityPrimaryGroup), value); }

        [Offset(586UL)]
        public byte ApcStateIndex { get => ReadHere<byte>(nameof(ApcStateIndex)); set => WriteHere(nameof(ApcStateIndex), value); }

        [Offset(587UL)]
        public byte WaitBlockCount { get => ReadHere<byte>(nameof(WaitBlockCount)); set => WriteHere(nameof(WaitBlockCount), value); }

        [Offset(588UL)]
        public uint IdealProcessor { get => ReadHere<uint>(nameof(IdealProcessor)); set => WriteHere(nameof(IdealProcessor), value); }

        [Offset(592UL)]
        public ulong NpxState { get => ReadHere<ulong>(nameof(NpxState)); set => WriteHere(nameof(NpxState), value); }

        [Offset(600UL)]
        public KapcState SavedApcState { get => ReadStructure<KapcState>(nameof(SavedApcState)); set => WriteStructure(nameof(SavedApcState), value); }

        [Offset(600UL)]
        [Length(43)]
        public DynamicArray SavedApcStateFill { get => ReadStructure<DynamicArray>(nameof(SavedApcStateFill)); set => WriteStructure(nameof(SavedApcStateFill), value); }

        [Offset(643UL)]
        public byte WaitReason { get => ReadHere<byte>(nameof(WaitReason)); set => WriteHere(nameof(WaitReason), value); }

        [Offset(644UL)]
        public sbyte SuspendCount { get => ReadHere<sbyte>(nameof(SuspendCount)); set => WriteHere(nameof(SuspendCount), value); }

        [Offset(645UL)]
        public sbyte Saturation { get => ReadHere<sbyte>(nameof(Saturation)); set => WriteHere(nameof(Saturation), value); }

        [Offset(646UL)]
        public ushort SListFaultCount { get => ReadHere<ushort>(nameof(SListFaultCount)); set => WriteHere(nameof(SListFaultCount), value); }

        [Offset(648UL)]
        public Kapc SchedulerApc { get => ReadStructure<Kapc>(nameof(SchedulerApc)); set => WriteStructure(nameof(SchedulerApc), value); }

        [Offset(648UL)]
        [Length(3)]
        public DynamicArray SchedulerApcFill1 { get => ReadStructure<DynamicArray>(nameof(SchedulerApcFill1)); set => WriteStructure(nameof(SchedulerApcFill1), value); }

        [Offset(651UL)]
        public byte QuantumReset { get => ReadHere<byte>(nameof(QuantumReset)); set => WriteHere(nameof(QuantumReset), value); }

        [Offset(648UL)]
        [Length(4)]
        public DynamicArray SchedulerApcFill2 { get => ReadStructure<DynamicArray>(nameof(SchedulerApcFill2)); set => WriteStructure(nameof(SchedulerApcFill2), value); }

        [Offset(652UL)]
        public uint KernelTime { get => ReadHere<uint>(nameof(KernelTime)); set => WriteHere(nameof(KernelTime), value); }

        [Offset(648UL)]
        [Length(64)]
        public DynamicArray SchedulerApcFill3 { get => ReadStructure<DynamicArray>(nameof(SchedulerApcFill3)); set => WriteStructure(nameof(SchedulerApcFill3), value); }

        [Offset(712UL)]
        public IntPtr WaitPrcb { get => ReadHere<IntPtr>(nameof(WaitPrcb)); set => WriteHere(nameof(WaitPrcb), value); }

        [Offset(648UL)]
        [Length(72)]
        public DynamicArray SchedulerApcFill4 { get => ReadStructure<DynamicArray>(nameof(SchedulerApcFill4)); set => WriteStructure(nameof(SchedulerApcFill4), value); }

        [Offset(720UL)]
        public IntPtr LegoData { get => ReadHere<IntPtr>(nameof(LegoData)); set => WriteHere(nameof(LegoData), value); }

        [Offset(648UL)]
        [Length(83)]
        public DynamicArray SchedulerApcFill5 { get => ReadStructure<DynamicArray>(nameof(SchedulerApcFill5)); set => WriteStructure(nameof(SchedulerApcFill5), value); }

        [Offset(731UL)]
        public byte CallbackNestingLevel { get => ReadHere<byte>(nameof(CallbackNestingLevel)); set => WriteHere(nameof(CallbackNestingLevel), value); }

        [Offset(732UL)]
        public uint UserTime { get => ReadHere<uint>(nameof(UserTime)); set => WriteHere(nameof(UserTime), value); }

        [Offset(736UL)]
        public Kevent SuspendEvent { get => ReadStructure<Kevent>(nameof(SuspendEvent)); set => WriteStructure(nameof(SuspendEvent), value); }

        [Offset(760UL)]
        public ListEntry ThreadListEntry { get => ReadStructure<ListEntry>(nameof(ThreadListEntry)); set => WriteStructure(nameof(ThreadListEntry), value); }

        [Offset(776UL)]
        public ListEntry MutantListHead { get => ReadStructure<ListEntry>(nameof(MutantListHead)); set => WriteStructure(nameof(MutantListHead), value); }

        [Offset(792UL)]
        public byte AbWaitEntryCount { get => ReadHere<byte>(nameof(AbWaitEntryCount)); set => WriteHere(nameof(AbWaitEntryCount), value); }

        [Offset(793UL)]
        public byte AbOwnedEntryCount { get => ReadHere<byte>(nameof(AbOwnedEntryCount)); set => WriteHere(nameof(AbOwnedEntryCount), value); }

        [Offset(792UL)]
        public ushort AbEntryCountValue { get => ReadHere<ushort>(nameof(AbEntryCountValue)); set => WriteHere(nameof(AbEntryCountValue), value); }

        [Offset(794UL)]
        public byte FreezeFlags { get => ReadHere<byte>(nameof(FreezeFlags)); set => WriteHere(nameof(FreezeFlags), value); }

        [Offset(794UL)]
        public byte FreezeCount2 { get => ReadHere<byte>(nameof(FreezeCount2)); set => WriteHere(nameof(FreezeCount2), value); }

        [Offset(794UL)]
        public byte FreezeNormal { get => ReadHere<byte>(nameof(FreezeNormal)); set => WriteHere(nameof(FreezeNormal), value); }

        [Offset(794UL)]
        public byte FreezeDeep { get => ReadHere<byte>(nameof(FreezeDeep)); set => WriteHere(nameof(FreezeDeep), value); }

        [Offset(795UL)]
        public sbyte WobPriority { get => ReadHere<sbyte>(nameof(WobPriority)); set => WriteHere(nameof(WobPriority), value); }

        [Offset(796UL)]
        public uint SecureThreadCookie { get => ReadHere<uint>(nameof(SecureThreadCookie)); set => WriteHere(nameof(SecureThreadCookie), value); }

        [Offset(800UL)]
        public IntPtr SchedulerSharedSystemSlot { get => ReadHere<IntPtr>(nameof(SchedulerSharedSystemSlot)); set => WriteHere(nameof(SchedulerSharedSystemSlot), value); }

        [Offset(808UL)]
        public SingleListEntry PropagateBoostsEntry { get => ReadStructure<SingleListEntry>(nameof(PropagateBoostsEntry)); set => WriteStructure(nameof(PropagateBoostsEntry), value); }

        [Offset(816UL)]
        public SingleListEntry IoSelfBoostsEntry { get => ReadStructure<SingleListEntry>(nameof(IoSelfBoostsEntry)); set => WriteStructure(nameof(IoSelfBoostsEntry), value); }

        [Offset(824UL)]
        [Length(32)]
        public DynamicArray PriorityFloorCounts { get => ReadStructure<DynamicArray>(nameof(PriorityFloorCounts)); set => WriteStructure(nameof(PriorityFloorCounts), value); }

        [Offset(856UL)]
        public uint PriorityFloorSummary { get => ReadHere<uint>(nameof(PriorityFloorSummary)); set => WriteHere(nameof(PriorityFloorSummary), value); }

        [Offset(860UL)]
        public int AbCompletedIoBoostCount { get => ReadHere<int>(nameof(AbCompletedIoBoostCount)); set => WriteHere(nameof(AbCompletedIoBoostCount), value); }

        [Offset(864UL)]
        public int AbCompletedIoQoSBoostCount { get => ReadHere<int>(nameof(AbCompletedIoQoSBoostCount)); set => WriteHere(nameof(AbCompletedIoQoSBoostCount), value); }

        [Offset(868UL)]
        public short KeReferenceCount { get => ReadHere<short>(nameof(KeReferenceCount)); set => WriteHere(nameof(KeReferenceCount), value); }

        [Offset(870UL)]
        public sbyte DecayBoost { get => ReadHere<sbyte>(nameof(DecayBoost)); set => WriteHere(nameof(DecayBoost), value); }

        [Offset(871UL)]
        public byte Spare6 { get => ReadHere<byte>(nameof(Spare6)); set => WriteHere(nameof(Spare6), value); }

        [Offset(872UL)]
        public uint ForegroundLossTime { get => ReadHere<uint>(nameof(ForegroundLossTime)); set => WriteHere(nameof(ForegroundLossTime), value); }

        [Offset(880UL)]
        public ListEntry GlobalForegroundListEntry { get => ReadStructure<ListEntry>(nameof(GlobalForegroundListEntry)); set => WriteStructure(nameof(GlobalForegroundListEntry), value); }

        [Offset(880UL)]
        public SingleListEntry ForegroundDpcStackListEntry { get => ReadStructure<SingleListEntry>(nameof(ForegroundDpcStackListEntry)); set => WriteStructure(nameof(ForegroundDpcStackListEntry), value); }

        [Offset(888UL)]
        public ulong InGlobalForegroundList { get => ReadHere<ulong>(nameof(InGlobalForegroundList)); set => WriteHere(nameof(InGlobalForegroundList), value); }

        [Offset(896UL)]
        public long ReadOperationCount { get => ReadHere<long>(nameof(ReadOperationCount)); set => WriteHere(nameof(ReadOperationCount), value); }

        [Offset(904UL)]
        public long WriteOperationCount { get => ReadHere<long>(nameof(WriteOperationCount)); set => WriteHere(nameof(WriteOperationCount), value); }

        [Offset(912UL)]
        public long OtherOperationCount { get => ReadHere<long>(nameof(OtherOperationCount)); set => WriteHere(nameof(OtherOperationCount), value); }

        [Offset(920UL)]
        public long ReadTransferCount { get => ReadHere<long>(nameof(ReadTransferCount)); set => WriteHere(nameof(ReadTransferCount), value); }

        [Offset(928UL)]
        public long WriteTransferCount { get => ReadHere<long>(nameof(WriteTransferCount)); set => WriteHere(nameof(WriteTransferCount), value); }

        [Offset(936UL)]
        public long OtherTransferCount { get => ReadHere<long>(nameof(OtherTransferCount)); set => WriteHere(nameof(OtherTransferCount), value); }

        [Offset(944UL)]
        public IntPtr QueuedScb { get => ReadHere<IntPtr>(nameof(QueuedScb)); set => WriteHere(nameof(QueuedScb), value); }

        [Offset(952UL)]
        public uint ThreadTimerDelay { get => ReadHere<uint>(nameof(ThreadTimerDelay)); set => WriteHere(nameof(ThreadTimerDelay), value); }

        [Offset(956UL)]
        public ushort Spare26 { get => ReadHere<ushort>(nameof(Spare26)); set => WriteHere(nameof(Spare26), value); }

        [Offset(958UL)]
        public byte PpmPolicy { get => ReadHere<byte>(nameof(PpmPolicy)); set => WriteHere(nameof(PpmPolicy), value); }

        [Offset(959UL)]
        public byte Spare27 { get => ReadHere<byte>(nameof(Spare27)); set => WriteHere(nameof(Spare27), value); }

        [Offset(960UL)]
        [Length(1)]
        public DynamicArray TracingPrivate { get => ReadStructure<DynamicArray>(nameof(TracingPrivate)); set => WriteStructure(nameof(TracingPrivate), value); }

        [Offset(968UL)]
        public IntPtr SchedulerAssist { get => ReadHere<IntPtr>(nameof(SchedulerAssist)); set => WriteHere(nameof(SchedulerAssist), value); }

        [Offset(976UL)]
        public IntPtr AbWaitObject { get => ReadHere<IntPtr>(nameof(AbWaitObject)); set => WriteHere(nameof(AbWaitObject), value); }

        [Offset(984UL)]
        public uint ReservedPreviousReadyTimeValue { get => ReadHere<uint>(nameof(ReservedPreviousReadyTimeValue)); set => WriteHere(nameof(ReservedPreviousReadyTimeValue), value); }

        [Offset(992UL)]
        public ulong KernelWaitTime { get => ReadHere<ulong>(nameof(KernelWaitTime)); set => WriteHere(nameof(KernelWaitTime), value); }

        [Offset(1000UL)]
        public ulong UserWaitTime { get => ReadHere<ulong>(nameof(UserWaitTime)); set => WriteHere(nameof(UserWaitTime), value); }

        [Offset(1008UL)]
        public ListEntry GlobalUpdateVpThreadPriorityListEntry { get => ReadStructure<ListEntry>(nameof(GlobalUpdateVpThreadPriorityListEntry)); set => WriteStructure(nameof(GlobalUpdateVpThreadPriorityListEntry), value); }

        [Offset(1008UL)]
        public SingleListEntry UpdateVpThreadPriorityDpcStackListEntry { get => ReadStructure<SingleListEntry>(nameof(UpdateVpThreadPriorityDpcStackListEntry)); set => WriteStructure(nameof(UpdateVpThreadPriorityDpcStackListEntry), value); }

        [Offset(1016UL)]
        public ulong InGlobalUpdateVpThreadPriorityList { get => ReadHere<ulong>(nameof(InGlobalUpdateVpThreadPriorityList)); set => WriteHere(nameof(InGlobalUpdateVpThreadPriorityList), value); }

        [Offset(1024UL)]
        public int SchedulerAssistPriorityFloor { get => ReadHere<int>(nameof(SchedulerAssistPriorityFloor)); set => WriteHere(nameof(SchedulerAssistPriorityFloor), value); }

        [Offset(1028UL)]
        public int RealtimePriorityFloor { get => ReadHere<int>(nameof(RealtimePriorityFloor)); set => WriteHere(nameof(RealtimePriorityFloor), value); }

        [Offset(1032UL)]
        public IntPtr KernelShadowStack { get => ReadHere<IntPtr>(nameof(KernelShadowStack)); set => WriteHere(nameof(KernelShadowStack), value); }

        [Offset(1040UL)]
        public IntPtr KernelShadowStackInitial { get => ReadHere<IntPtr>(nameof(KernelShadowStackInitial)); set => WriteHere(nameof(KernelShadowStackInitial), value); }

        [Offset(1048UL)]
        public IntPtr KernelShadowStackBase { get => ReadHere<IntPtr>(nameof(KernelShadowStackBase)); set => WriteHere(nameof(KernelShadowStackBase), value); }

        [Offset(1056UL)]
        public KernelShadowStackLimit KernelShadowStackLimit { get => ReadStructure<KernelShadowStackLimit>(nameof(KernelShadowStackLimit)); set => WriteStructure(nameof(KernelShadowStackLimit), value); }

        [Offset(1064UL)]
        public ulong ExtendedFeatureDisableMask { get => ReadHere<ulong>(nameof(ExtendedFeatureDisableMask)); set => WriteHere(nameof(ExtendedFeatureDisableMask), value); }

        [Offset(1072UL)]
        public ulong HgsFeedbackStartTime { get => ReadHere<ulong>(nameof(HgsFeedbackStartTime)); set => WriteHere(nameof(HgsFeedbackStartTime), value); }

        [Offset(1080UL)]
        public ulong HgsFeedbackCycles { get => ReadHere<ulong>(nameof(HgsFeedbackCycles)); set => WriteHere(nameof(HgsFeedbackCycles), value); }

        [Offset(1088UL)]
        public uint HgsInvalidFeedbackCount { get => ReadHere<uint>(nameof(HgsInvalidFeedbackCount)); set => WriteHere(nameof(HgsInvalidFeedbackCount), value); }

        [Offset(1092UL)]
        public uint HgsLowerPerfClassFeedbackCount { get => ReadHere<uint>(nameof(HgsLowerPerfClassFeedbackCount)); set => WriteHere(nameof(HgsLowerPerfClassFeedbackCount), value); }

        [Offset(1096UL)]
        public uint HgsHigherPerfClassFeedbackCount { get => ReadHere<uint>(nameof(HgsHigherPerfClassFeedbackCount)); set => WriteHere(nameof(HgsHigherPerfClassFeedbackCount), value); }

        [Offset(1100UL)]
        public uint ModeHistory { get => ReadHere<uint>(nameof(ModeHistory)); set => WriteHere(nameof(ModeHistory), value); }

        [Offset(1104UL)]
        public SingleListEntry SystemAffinityTokenListHead { get => ReadStructure<SingleListEntry>(nameof(SystemAffinityTokenListHead)); set => WriteStructure(nameof(SystemAffinityTokenListHead), value); }

        [Offset(1112UL)]
        public IntPtr IptSaveArea { get => ReadHere<IntPtr>(nameof(IptSaveArea)); set => WriteHere(nameof(IptSaveArea), value); }

        [Offset(1120UL)]
        public byte ResourceIndex { get => ReadHere<byte>(nameof(ResourceIndex)); set => WriteHere(nameof(ResourceIndex), value); }

        [Offset(1121UL)]
        public byte CoreIsolationReasons { get => ReadHere<byte>(nameof(CoreIsolationReasons)); set => WriteHere(nameof(CoreIsolationReasons), value); }

        [Offset(1122UL)]
        public byte BamQosLevelFromAssistPage { get => ReadHere<byte>(nameof(BamQosLevelFromAssistPage)); set => WriteHere(nameof(BamQosLevelFromAssistPage), value); }

        [Offset(1123UL)]
        public byte SecureCallCoreIsolationCount { get => ReadHere<byte>(nameof(SecureCallCoreIsolationCount)); set => WriteHere(nameof(SecureCallCoreIsolationCount), value); }

        [Offset(1124UL)]
        public uint SchedulerSharedOffset { get => ReadHere<uint>(nameof(SchedulerSharedOffset)); set => WriteHere(nameof(SchedulerSharedOffset), value); }

        [Offset(1128UL)]
        public IntPtr SchedulerSharedSwappablePage { get => ReadHere<IntPtr>(nameof(SchedulerSharedSwappablePage)); set => WriteHere(nameof(SchedulerSharedSwappablePage), value); }

        [Offset(1136UL)]
        public IntPtr KernelAbEntries { get => ReadHere<IntPtr>(nameof(KernelAbEntries)); set => WriteHere(nameof(KernelAbEntries), value); }

        [Offset(1144UL)]
        public IntPtr UserAbEntries { get => ReadHere<IntPtr>(nameof(UserAbEntries)); set => WriteHere(nameof(UserAbEntries), value); }

        [Offset(1152UL)]
        public ulong KcsanThread { get => ReadHere<ulong>(nameof(KcsanThread)); set => WriteHere(nameof(KcsanThread), value); }

        [Offset(1160UL)]
        public uint SchedulerAssistYieldCounter { get => ReadHere<uint>(nameof(SchedulerAssistYieldCounter)); set => WriteHere(nameof(SchedulerAssistYieldCounter), value); }

        [Offset(1164UL)]
        public uint SchedulerAssistYieldBoostCount { get => ReadHere<uint>(nameof(SchedulerAssistYieldBoostCount)); set => WriteHere(nameof(SchedulerAssistYieldBoostCount), value); }

        [Offset(1168UL)]
        public long SchedulerAssistLastYieldBoostTime { get => ReadHere<long>(nameof(SchedulerAssistLastYieldBoostTime)); set => WriteHere(nameof(SchedulerAssistLastYieldBoostTime), value); }

        [Offset(1176UL)]
        [Length(5)]
        public DynamicArray Padding { get => ReadStructure<DynamicArray>(nameof(Padding)); set => WriteStructure(nameof(Padding), value); }

        public Kthread(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kthread>();
        }
    }
}