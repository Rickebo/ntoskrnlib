using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KTHREAD")]
    public sealed class _KTHREAD : DynamicStructure
    {
        public _DISPATCHER_HEADER Header { get; }
        public IntPtr SListFaultAddress { get; }
        public ulong QuantumTarget { get; }
        public IntPtr InitialStack { get; }
        public IntPtr StackLimit { get; }
        public IntPtr StackBase { get; }
        public ulong ThreadLock { get; }
        public ulong CycleTime { get; }
        public uint CurrentRunTime { get; }
        public uint ExpectedRunTime { get; }
        public IntPtr KernelStack { get; }
        public IntPtr StateSaveArea { get; }
        public IntPtr SchedulingGroup { get; }
        public _KWAIT_STATUS_REGISTER WaitRegister { get; }
        public byte Running { get; }
        public byte[] Alerted { get; }
        public uint AutoBoostActive { get; }
        public uint ReadyTransition { get; }
        public uint WaitNext { get; }
        public uint SystemAffinityActive { get; }
        public uint Alertable { get; }
        public uint Reserved1 { get; }
        public uint ApcInterruptRequest { get; }
        public uint QuantumEndMigrate { get; }
        public uint SecureThread { get; }
        public uint TimerActive { get; }
        public uint SystemThread { get; }
        public uint ProcessDetachActive { get; }
        public uint Reserved2 { get; }
        public uint ScbReadyQueue { get; }
        public uint ApcQueueable { get; }
        public uint Reserved3 { get; }
        public uint WaitNextClearWobPriorityFloor { get; }
        public uint TimerSuspended { get; }
        public uint SuspendedWaitMode { get; }
        public uint SuspendSchedulerApcWait { get; }
        public uint CetUserShadowStack { get; }
        public uint BypassProcessFreeze { get; }
        public uint CetKernelShadowStack { get; }
        public uint StateSaveAreaDecoupled { get; }
        public uint Reserved { get; }
        public int MiscFlags { get; }
        public uint UserIdealProcessorFixed { get; }
        public uint IsolationWidth { get; }
        public uint AutoAlignment { get; }
        public uint DisableBoost { get; }
        public uint AlertedByThreadId { get; }
        public uint QuantumDonation { get; }
        public uint EnableStackSwap { get; }
        public uint GuiThread { get; }
        public uint DisableQuantum { get; }
        public uint ChargeOnlySchedulingGroup { get; }
        public uint DeferPreemption { get; }
        public uint QueueDeferPreemption { get; }
        public uint ForceDeferSchedule { get; }
        public uint SharedReadyQueueAffinity { get; }
        public uint FreezeCount { get; }
        public uint TerminationApcRequest { get; }
        public uint AutoBoostEntriesExhausted { get; }
        public uint KernelStackResident { get; }
        public uint TerminateRequestReason { get; }
        public uint ProcessStackCountDecremented { get; }
        public uint RestrictedGuiThread { get; }
        public uint VpBackingThread { get; }
        public uint EtwStackTraceCrimsonApcDisabled { get; }
        public uint EtwStackTraceApcInserted { get; }
        public int ThreadFlags { get; }
        public byte Tag { get; }
        public byte CalloutActive { get; }
        public byte ReservedStackInUse { get; }
        public byte UserStackWalkActive { get; }
        public byte SameThreadTransientFlagsReserved { get; }
        public sbyte SameThreadTransientFlags { get; }
        public byte Spare0 { get; }
        public uint SystemCallNumber { get; }
        public uint ReadyTime { get; }
        public IntPtr FirstArgument { get; }
        public IntPtr TrapFrame { get; }
        public _KAPC_STATE ApcState { get; }
        public byte[] ApcStateFill { get; }
        public sbyte Priority { get; }
        public uint UserIdealProcessor { get; }
        public long WaitStatus { get; }
        public IntPtr WaitBlockList { get; }
        public _LIST_ENTRY WaitListEntry { get; }
        public _SINGLE_LIST_ENTRY SwapListEntry { get; }
        public IntPtr Queue { get; }
        public IntPtr Teb { get; }
        public ulong RelativeTimerBias { get; }
        public _KTIMER Timer { get; }
        public byte[] WaitBlock { get; }
        public byte[] WaitBlockFill4 { get; }
        public uint ContextSwitches { get; }
        public byte[] WaitBlockFill5 { get; }
        public byte State { get; }
        public sbyte Spare13 { get; }
        public byte WaitIrql { get; }
        public sbyte WaitMode { get; }
        public byte[] WaitBlockFill6 { get; }
        public uint WaitTime { get; }
        public byte[] WaitBlockFill7 { get; }
        public short KernelApcDisable { get; }
        public short SpecialApcDisable { get; }
        public uint CombinedApcDisable { get; }
        public byte[] WaitBlockFill8 { get; }
        public IntPtr ThreadCounters { get; }
        public byte[] WaitBlockFill9 { get; }
        public IntPtr XStateSave { get; }
        public byte[] WaitBlockFill10 { get; }
        public IntPtr Win32Thread { get; }
        public byte[] WaitBlockFill11 { get; }
        public ulong Spare18 { get; }
        public ulong LastXStateSaveDebugInfo { get; }
        public int ThreadFlags2 { get; }
        public uint DisableKasan { get; }
        public uint AbContextSwitchState { get; }
        public uint ThreadFlags2Reserved { get; }
        public byte BamQosLevel { get; }
        public byte HardwareFeedbackClass { get; }
        public short PriorityDecrement { get; }
        public ushort ForegroundBoost { get; }
        public ushort UnusualBoost { get; }
        public _LIST_ENTRY QueueListEntry { get; }
        public uint NextProcessor { get; }
        public uint NextProcessorNumber { get; }
        public uint SharedReadyQueue { get; }
        public int QueuePriority { get; }
        public IntPtr Process { get; }
        public IntPtr UserAffinity { get; }
        public ushort UserAffinityPrimaryGroup { get; }
        public sbyte PreviousMode { get; }
        public sbyte BasePriority { get; }
        public byte Spare24 { get; }
        public byte Preempted { get; }
        public byte AdjustReason { get; }
        public sbyte AdjustIncrement { get; }
        public ulong AffinityVersion { get; }
        public IntPtr Affinity { get; }
        public ushort AffinityPrimaryGroup { get; }
        public byte ApcStateIndex { get; }
        public byte WaitBlockCount { get; }
        public uint IdealProcessor { get; }
        public ulong NpxState { get; }
        public _KAPC_STATE SavedApcState { get; }
        public byte[] SavedApcStateFill { get; }
        public byte WaitReason { get; }
        public sbyte SuspendCount { get; }
        public sbyte Saturation { get; }
        public ushort SListFaultCount { get; }
        public _KAPC SchedulerApc { get; }
        public byte[] SchedulerApcFill1 { get; }
        public byte QuantumReset { get; }
        public byte[] SchedulerApcFill2 { get; }
        public uint KernelTime { get; }
        public byte[] SchedulerApcFill3 { get; }
        public IntPtr WaitPrcb { get; }
        public byte[] SchedulerApcFill4 { get; }
        public IntPtr LegoData { get; }
        public byte[] SchedulerApcFill5 { get; }
        public byte CallbackNestingLevel { get; }
        public uint UserTime { get; }
        public _KEVENT SuspendEvent { get; }
        public _LIST_ENTRY ThreadListEntry { get; }
        public _LIST_ENTRY MutantListHead { get; }
        public byte AbWaitEntryCount { get; }
        public byte AbOwnedEntryCount { get; }
        public ushort AbEntryCountValue { get; }
        public byte FreezeFlags { get; }
        public byte FreezeCount2 { get; }
        public byte FreezeNormal { get; }
        public byte FreezeDeep { get; }
        public sbyte WobPriority { get; }
        public uint SecureThreadCookie { get; }
        public IntPtr SchedulerSharedSystemSlot { get; }
        public _SINGLE_LIST_ENTRY PropagateBoostsEntry { get; }
        public _SINGLE_LIST_ENTRY IoSelfBoostsEntry { get; }
        public byte[] PriorityFloorCounts { get; }
        public uint PriorityFloorSummary { get; }
        public int AbCompletedIoBoostCount { get; }
        public int AbCompletedIoQoSBoostCount { get; }
        public short KeReferenceCount { get; }
        public sbyte DecayBoost { get; }
        public byte Spare6 { get; }
        public uint ForegroundLossTime { get; }
        public _LIST_ENTRY GlobalForegroundListEntry { get; }
        public _SINGLE_LIST_ENTRY ForegroundDpcStackListEntry { get; }
        public ulong InGlobalForegroundList { get; }
        public long ReadOperationCount { get; }
        public long WriteOperationCount { get; }
        public long OtherOperationCount { get; }
        public long ReadTransferCount { get; }
        public long WriteTransferCount { get; }
        public long OtherTransferCount { get; }
        public IntPtr QueuedScb { get; }
        public uint ThreadTimerDelay { get; }
        public ushort Spare26 { get; }
        public byte PpmPolicy { get; }
        public byte Spare27 { get; }
        public ulong[] TracingPrivate { get; }
        public IntPtr SchedulerAssist { get; }
        public IntPtr AbWaitObject { get; }
        public uint ReservedPreviousReadyTimeValue { get; }
        public ulong KernelWaitTime { get; }
        public ulong UserWaitTime { get; }
        public _LIST_ENTRY GlobalUpdateVpThreadPriorityListEntry { get; }
        public _SINGLE_LIST_ENTRY UpdateVpThreadPriorityDpcStackListEntry { get; }
        public ulong InGlobalUpdateVpThreadPriorityList { get; }
        public int SchedulerAssistPriorityFloor { get; }
        public int RealtimePriorityFloor { get; }
        public IntPtr KernelShadowStack { get; }
        public IntPtr KernelShadowStackInitial { get; }
        public IntPtr KernelShadowStackBase { get; }
        public _KERNEL_SHADOW_STACK_LIMIT KernelShadowStackLimit { get; }
        public ulong ExtendedFeatureDisableMask { get; }
        public ulong HgsFeedbackStartTime { get; }
        public ulong HgsFeedbackCycles { get; }
        public uint HgsInvalidFeedbackCount { get; }
        public uint HgsLowerPerfClassFeedbackCount { get; }
        public uint HgsHigherPerfClassFeedbackCount { get; }
        public uint ModeHistory { get; }
        public _SINGLE_LIST_ENTRY SystemAffinityTokenListHead { get; }
        public IntPtr IptSaveArea { get; }
        public byte ResourceIndex { get; }
        public byte CoreIsolationReasons { get; }
        public byte BamQosLevelFromAssistPage { get; }
        public byte SecureCallCoreIsolationCount { get; }
        public uint SchedulerSharedOffset { get; }
        public IntPtr SchedulerSharedSwappablePage { get; }
        public IntPtr KernelAbEntries { get; }
        public IntPtr UserAbEntries { get; }
        public ulong KcsanThread { get; }
        public uint SchedulerAssistYieldCounter { get; }
        public uint SchedulerAssistYieldBoostCount { get; }
        public long SchedulerAssistLastYieldBoostTime { get; }
        public ulong[] Padding { get; }

        public _KTHREAD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTHREAD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTHREAD.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTHREAD.SListFaultAddress),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KTHREAD.QuantumTarget),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KTHREAD.InitialStack),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KTHREAD.StackLimit),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KTHREAD.StackBase),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KTHREAD.ThreadLock),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KTHREAD.CycleTime),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KTHREAD.CurrentRunTime),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_KTHREAD.ExpectedRunTime),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_KTHREAD.KernelStack),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_KTHREAD.StateSaveArea),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulingGroup),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitRegister),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KTHREAD.Running),
                    new ulong[]
                    {
                        113UL
                    }
                },
                {
                    nameof(_KTHREAD.Alerted),
                    new ulong[]
                    {
                        114UL
                    }
                },
                {
                    nameof(_KTHREAD.AutoBoostActive),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.ReadyTransition),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitNext),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.SystemAffinityActive),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.Alertable),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.Reserved1),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.ApcInterruptRequest),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.QuantumEndMigrate),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.SecureThread),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.TimerActive),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.SystemThread),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.ProcessDetachActive),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.Reserved2),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.ScbReadyQueue),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.ApcQueueable),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.Reserved3),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitNextClearWobPriorityFloor),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.TimerSuspended),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.SuspendedWaitMode),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.SuspendSchedulerApcWait),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.CetUserShadowStack),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.BypassProcessFreeze),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.CetKernelShadowStack),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.StateSaveAreaDecoupled),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.Reserved),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.MiscFlags),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KTHREAD.UserIdealProcessorFixed),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.IsolationWidth),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.AutoAlignment),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.DisableBoost),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.AlertedByThreadId),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.QuantumDonation),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.EnableStackSwap),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.GuiThread),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.DisableQuantum),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.ChargeOnlySchedulingGroup),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.DeferPreemption),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.QueueDeferPreemption),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.ForceDeferSchedule),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.SharedReadyQueueAffinity),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.FreezeCount),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.TerminationApcRequest),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.AutoBoostEntriesExhausted),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.KernelStackResident),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.TerminateRequestReason),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.ProcessStackCountDecremented),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.RestrictedGuiThread),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.VpBackingThread),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.EtwStackTraceCrimsonApcDisabled),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.EtwStackTraceApcInserted),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.ThreadFlags),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTHREAD.Tag),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_KTHREAD.CalloutActive),
                    new ulong[]
                    {
                        125UL
                    }
                },
                {
                    nameof(_KTHREAD.ReservedStackInUse),
                    new ulong[]
                    {
                        125UL
                    }
                },
                {
                    nameof(_KTHREAD.UserStackWalkActive),
                    new ulong[]
                    {
                        125UL
                    }
                },
                {
                    nameof(_KTHREAD.SameThreadTransientFlagsReserved),
                    new ulong[]
                    {
                        125UL
                    }
                },
                {
                    nameof(_KTHREAD.SameThreadTransientFlags),
                    new ulong[]
                    {
                        125UL
                    }
                },
                {
                    nameof(_KTHREAD.Spare0),
                    new ulong[]
                    {
                        126UL
                    }
                },
                {
                    nameof(_KTHREAD.SystemCallNumber),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_KTHREAD.ReadyTime),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_KTHREAD.FirstArgument),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KTHREAD.TrapFrame),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KTHREAD.ApcState),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_KTHREAD.ApcStateFill),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_KTHREAD.Priority),
                    new ulong[]
                    {
                        195UL
                    }
                },
                {
                    nameof(_KTHREAD.UserIdealProcessor),
                    new ulong[]
                    {
                        196UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitStatus),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitBlockList),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitListEntry),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_KTHREAD.SwapListEntry),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_KTHREAD.Queue),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_KTHREAD.Teb),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_KTHREAD.RelativeTimerBias),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_KTHREAD.Timer),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitBlock),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitBlockFill4),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KTHREAD.ContextSwitches),
                    new ulong[]
                    {
                        340UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitBlockFill5),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KTHREAD.State),
                    new ulong[]
                    {
                        388UL
                    }
                },
                {
                    nameof(_KTHREAD.Spare13),
                    new ulong[]
                    {
                        389UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitIrql),
                    new ulong[]
                    {
                        390UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitMode),
                    new ulong[]
                    {
                        391UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitBlockFill6),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitTime),
                    new ulong[]
                    {
                        436UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitBlockFill7),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KTHREAD.KernelApcDisable),
                    new ulong[]
                    {
                        484UL
                    }
                },
                {
                    nameof(_KTHREAD.SpecialApcDisable),
                    new ulong[]
                    {
                        486UL
                    }
                },
                {
                    nameof(_KTHREAD.CombinedApcDisable),
                    new ulong[]
                    {
                        484UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitBlockFill8),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KTHREAD.ThreadCounters),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitBlockFill9),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KTHREAD.XStateSave),
                    new ulong[]
                    {
                        408UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitBlockFill10),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KTHREAD.Win32Thread),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitBlockFill11),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KTHREAD.Spare18),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_KTHREAD.LastXStateSaveDebugInfo),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_KTHREAD.ThreadFlags2),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_KTHREAD.DisableKasan),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_KTHREAD.AbContextSwitchState),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_KTHREAD.ThreadFlags2Reserved),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_KTHREAD.BamQosLevel),
                    new ulong[]
                    {
                        516UL
                    }
                },
                {
                    nameof(_KTHREAD.HardwareFeedbackClass),
                    new ulong[]
                    {
                        517UL
                    }
                },
                {
                    nameof(_KTHREAD.PriorityDecrement),
                    new ulong[]
                    {
                        518UL
                    }
                },
                {
                    nameof(_KTHREAD.ForegroundBoost),
                    new ulong[]
                    {
                        518UL
                    }
                },
                {
                    nameof(_KTHREAD.UnusualBoost),
                    new ulong[]
                    {
                        518UL
                    }
                },
                {
                    nameof(_KTHREAD.QueueListEntry),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_KTHREAD.NextProcessor),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_KTHREAD.NextProcessorNumber),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_KTHREAD.SharedReadyQueue),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_KTHREAD.QueuePriority),
                    new ulong[]
                    {
                        540UL
                    }
                },
                {
                    nameof(_KTHREAD.Process),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(_KTHREAD.UserAffinity),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(_KTHREAD.UserAffinityPrimaryGroup),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_KTHREAD.PreviousMode),
                    new ulong[]
                    {
                        562UL
                    }
                },
                {
                    nameof(_KTHREAD.BasePriority),
                    new ulong[]
                    {
                        563UL
                    }
                },
                {
                    nameof(_KTHREAD.Spare24),
                    new ulong[]
                    {
                        564UL
                    }
                },
                {
                    nameof(_KTHREAD.Preempted),
                    new ulong[]
                    {
                        565UL
                    }
                },
                {
                    nameof(_KTHREAD.AdjustReason),
                    new ulong[]
                    {
                        566UL
                    }
                },
                {
                    nameof(_KTHREAD.AdjustIncrement),
                    new ulong[]
                    {
                        567UL
                    }
                },
                {
                    nameof(_KTHREAD.AffinityVersion),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_KTHREAD.Affinity),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_KTHREAD.AffinityPrimaryGroup),
                    new ulong[]
                    {
                        584UL
                    }
                },
                {
                    nameof(_KTHREAD.ApcStateIndex),
                    new ulong[]
                    {
                        586UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitBlockCount),
                    new ulong[]
                    {
                        587UL
                    }
                },
                {
                    nameof(_KTHREAD.IdealProcessor),
                    new ulong[]
                    {
                        588UL
                    }
                },
                {
                    nameof(_KTHREAD.NpxState),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_KTHREAD.SavedApcState),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_KTHREAD.SavedApcStateFill),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitReason),
                    new ulong[]
                    {
                        643UL
                    }
                },
                {
                    nameof(_KTHREAD.SuspendCount),
                    new ulong[]
                    {
                        644UL
                    }
                },
                {
                    nameof(_KTHREAD.Saturation),
                    new ulong[]
                    {
                        645UL
                    }
                },
                {
                    nameof(_KTHREAD.SListFaultCount),
                    new ulong[]
                    {
                        646UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulerApc),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulerApcFill1),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(_KTHREAD.QuantumReset),
                    new ulong[]
                    {
                        651UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulerApcFill2),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(_KTHREAD.KernelTime),
                    new ulong[]
                    {
                        652UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulerApcFill3),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(_KTHREAD.WaitPrcb),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulerApcFill4),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(_KTHREAD.LegoData),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulerApcFill5),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(_KTHREAD.CallbackNestingLevel),
                    new ulong[]
                    {
                        731UL
                    }
                },
                {
                    nameof(_KTHREAD.UserTime),
                    new ulong[]
                    {
                        732UL
                    }
                },
                {
                    nameof(_KTHREAD.SuspendEvent),
                    new ulong[]
                    {
                        736UL
                    }
                },
                {
                    nameof(_KTHREAD.ThreadListEntry),
                    new ulong[]
                    {
                        760UL
                    }
                },
                {
                    nameof(_KTHREAD.MutantListHead),
                    new ulong[]
                    {
                        776UL
                    }
                },
                {
                    nameof(_KTHREAD.AbWaitEntryCount),
                    new ulong[]
                    {
                        792UL
                    }
                },
                {
                    nameof(_KTHREAD.AbOwnedEntryCount),
                    new ulong[]
                    {
                        793UL
                    }
                },
                {
                    nameof(_KTHREAD.AbEntryCountValue),
                    new ulong[]
                    {
                        792UL
                    }
                },
                {
                    nameof(_KTHREAD.FreezeFlags),
                    new ulong[]
                    {
                        794UL
                    }
                },
                {
                    nameof(_KTHREAD.FreezeCount2),
                    new ulong[]
                    {
                        794UL
                    }
                },
                {
                    nameof(_KTHREAD.FreezeNormal),
                    new ulong[]
                    {
                        794UL
                    }
                },
                {
                    nameof(_KTHREAD.FreezeDeep),
                    new ulong[]
                    {
                        794UL
                    }
                },
                {
                    nameof(_KTHREAD.WobPriority),
                    new ulong[]
                    {
                        795UL
                    }
                },
                {
                    nameof(_KTHREAD.SecureThreadCookie),
                    new ulong[]
                    {
                        796UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulerSharedSystemSlot),
                    new ulong[]
                    {
                        800UL
                    }
                },
                {
                    nameof(_KTHREAD.PropagateBoostsEntry),
                    new ulong[]
                    {
                        808UL
                    }
                },
                {
                    nameof(_KTHREAD.IoSelfBoostsEntry),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_KTHREAD.PriorityFloorCounts),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_KTHREAD.PriorityFloorSummary),
                    new ulong[]
                    {
                        856UL
                    }
                },
                {
                    nameof(_KTHREAD.AbCompletedIoBoostCount),
                    new ulong[]
                    {
                        860UL
                    }
                },
                {
                    nameof(_KTHREAD.AbCompletedIoQoSBoostCount),
                    new ulong[]
                    {
                        864UL
                    }
                },
                {
                    nameof(_KTHREAD.KeReferenceCount),
                    new ulong[]
                    {
                        868UL
                    }
                },
                {
                    nameof(_KTHREAD.DecayBoost),
                    new ulong[]
                    {
                        870UL
                    }
                },
                {
                    nameof(_KTHREAD.Spare6),
                    new ulong[]
                    {
                        871UL
                    }
                },
                {
                    nameof(_KTHREAD.ForegroundLossTime),
                    new ulong[]
                    {
                        872UL
                    }
                },
                {
                    nameof(_KTHREAD.GlobalForegroundListEntry),
                    new ulong[]
                    {
                        880UL
                    }
                },
                {
                    nameof(_KTHREAD.ForegroundDpcStackListEntry),
                    new ulong[]
                    {
                        880UL
                    }
                },
                {
                    nameof(_KTHREAD.InGlobalForegroundList),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_KTHREAD.ReadOperationCount),
                    new ulong[]
                    {
                        896UL
                    }
                },
                {
                    nameof(_KTHREAD.WriteOperationCount),
                    new ulong[]
                    {
                        904UL
                    }
                },
                {
                    nameof(_KTHREAD.OtherOperationCount),
                    new ulong[]
                    {
                        912UL
                    }
                },
                {
                    nameof(_KTHREAD.ReadTransferCount),
                    new ulong[]
                    {
                        920UL
                    }
                },
                {
                    nameof(_KTHREAD.WriteTransferCount),
                    new ulong[]
                    {
                        928UL
                    }
                },
                {
                    nameof(_KTHREAD.OtherTransferCount),
                    new ulong[]
                    {
                        936UL
                    }
                },
                {
                    nameof(_KTHREAD.QueuedScb),
                    new ulong[]
                    {
                        944UL
                    }
                },
                {
                    nameof(_KTHREAD.ThreadTimerDelay),
                    new ulong[]
                    {
                        952UL
                    }
                },
                {
                    nameof(_KTHREAD.Spare26),
                    new ulong[]
                    {
                        956UL
                    }
                },
                {
                    nameof(_KTHREAD.PpmPolicy),
                    new ulong[]
                    {
                        958UL
                    }
                },
                {
                    nameof(_KTHREAD.Spare27),
                    new ulong[]
                    {
                        959UL
                    }
                },
                {
                    nameof(_KTHREAD.TracingPrivate),
                    new ulong[]
                    {
                        960UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulerAssist),
                    new ulong[]
                    {
                        968UL
                    }
                },
                {
                    nameof(_KTHREAD.AbWaitObject),
                    new ulong[]
                    {
                        976UL
                    }
                },
                {
                    nameof(_KTHREAD.ReservedPreviousReadyTimeValue),
                    new ulong[]
                    {
                        984UL
                    }
                },
                {
                    nameof(_KTHREAD.KernelWaitTime),
                    new ulong[]
                    {
                        992UL
                    }
                },
                {
                    nameof(_KTHREAD.UserWaitTime),
                    new ulong[]
                    {
                        1000UL
                    }
                },
                {
                    nameof(_KTHREAD.GlobalUpdateVpThreadPriorityListEntry),
                    new ulong[]
                    {
                        1008UL
                    }
                },
                {
                    nameof(_KTHREAD.UpdateVpThreadPriorityDpcStackListEntry),
                    new ulong[]
                    {
                        1008UL
                    }
                },
                {
                    nameof(_KTHREAD.InGlobalUpdateVpThreadPriorityList),
                    new ulong[]
                    {
                        1016UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulerAssistPriorityFloor),
                    new ulong[]
                    {
                        1024UL
                    }
                },
                {
                    nameof(_KTHREAD.RealtimePriorityFloor),
                    new ulong[]
                    {
                        1028UL
                    }
                },
                {
                    nameof(_KTHREAD.KernelShadowStack),
                    new ulong[]
                    {
                        1032UL
                    }
                },
                {
                    nameof(_KTHREAD.KernelShadowStackInitial),
                    new ulong[]
                    {
                        1040UL
                    }
                },
                {
                    nameof(_KTHREAD.KernelShadowStackBase),
                    new ulong[]
                    {
                        1048UL
                    }
                },
                {
                    nameof(_KTHREAD.KernelShadowStackLimit),
                    new ulong[]
                    {
                        1056UL
                    }
                },
                {
                    nameof(_KTHREAD.ExtendedFeatureDisableMask),
                    new ulong[]
                    {
                        1064UL
                    }
                },
                {
                    nameof(_KTHREAD.HgsFeedbackStartTime),
                    new ulong[]
                    {
                        1072UL
                    }
                },
                {
                    nameof(_KTHREAD.HgsFeedbackCycles),
                    new ulong[]
                    {
                        1080UL
                    }
                },
                {
                    nameof(_KTHREAD.HgsInvalidFeedbackCount),
                    new ulong[]
                    {
                        1088UL
                    }
                },
                {
                    nameof(_KTHREAD.HgsLowerPerfClassFeedbackCount),
                    new ulong[]
                    {
                        1092UL
                    }
                },
                {
                    nameof(_KTHREAD.HgsHigherPerfClassFeedbackCount),
                    new ulong[]
                    {
                        1096UL
                    }
                },
                {
                    nameof(_KTHREAD.ModeHistory),
                    new ulong[]
                    {
                        1100UL
                    }
                },
                {
                    nameof(_KTHREAD.SystemAffinityTokenListHead),
                    new ulong[]
                    {
                        1104UL
                    }
                },
                {
                    nameof(_KTHREAD.IptSaveArea),
                    new ulong[]
                    {
                        1112UL
                    }
                },
                {
                    nameof(_KTHREAD.ResourceIndex),
                    new ulong[]
                    {
                        1120UL
                    }
                },
                {
                    nameof(_KTHREAD.CoreIsolationReasons),
                    new ulong[]
                    {
                        1121UL
                    }
                },
                {
                    nameof(_KTHREAD.BamQosLevelFromAssistPage),
                    new ulong[]
                    {
                        1122UL
                    }
                },
                {
                    nameof(_KTHREAD.SecureCallCoreIsolationCount),
                    new ulong[]
                    {
                        1123UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulerSharedOffset),
                    new ulong[]
                    {
                        1124UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulerSharedSwappablePage),
                    new ulong[]
                    {
                        1128UL
                    }
                },
                {
                    nameof(_KTHREAD.KernelAbEntries),
                    new ulong[]
                    {
                        1136UL
                    }
                },
                {
                    nameof(_KTHREAD.UserAbEntries),
                    new ulong[]
                    {
                        1144UL
                    }
                },
                {
                    nameof(_KTHREAD.KcsanThread),
                    new ulong[]
                    {
                        1152UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulerAssistYieldCounter),
                    new ulong[]
                    {
                        1160UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulerAssistYieldBoostCount),
                    new ulong[]
                    {
                        1164UL
                    }
                },
                {
                    nameof(_KTHREAD.SchedulerAssistLastYieldBoostTime),
                    new ulong[]
                    {
                        1168UL
                    }
                },
                {
                    nameof(_KTHREAD.Padding),
                    new ulong[]
                    {
                        1176UL
                    }
                }
            };
            Register<_KTHREAD>((mem, ptr) => new _KTHREAD(mem, ptr), offsets);
        }
    }
}