#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1216)]
    public partial struct _KTHREAD
    {
        [FieldOffset(0)]
        public _DISPATCHER_HEADER Header;
        [FieldOffset(24)]
        public IntPtr SListFaultAddress;
        [FieldOffset(32)]
        public ulong QuantumTarget;
        [FieldOffset(40)]
        public IntPtr InitialStack;
        [FieldOffset(48)]
        public IntPtr StackLimit;
        [FieldOffset(56)]
        public IntPtr StackBase;
        [FieldOffset(64)]
        public ulong ThreadLock;
        [FieldOffset(72)]
        public ulong CycleTime;
        [FieldOffset(80)]
        public uint CurrentRunTime;
        [FieldOffset(84)]
        public uint ExpectedRunTime;
        [FieldOffset(88)]
        public IntPtr KernelStack;
        [FieldOffset(96)]
        public IntPtr StateSaveArea;
        [FieldOffset(104)]
        public IntPtr SchedulingGroup;
        [FieldOffset(112)]
        public _KWAIT_STATUS_REGISTER WaitRegister;
        [FieldOffset(113)]
        public byte Running;
        [FieldOffset(114)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Alerted;
        [FieldOffset(116)]
        public uint AutoBoostActive;
        [FieldOffset(116)]
        public uint ReadyTransition;
        [FieldOffset(116)]
        public uint WaitNext;
        [FieldOffset(116)]
        public uint SystemAffinityActive;
        [FieldOffset(116)]
        public uint Alertable;
        [FieldOffset(116)]
        public uint Reserved1;
        [FieldOffset(116)]
        public uint ApcInterruptRequest;
        [FieldOffset(116)]
        public uint QuantumEndMigrate;
        [FieldOffset(116)]
        public uint SecureThread;
        [FieldOffset(116)]
        public uint TimerActive;
        [FieldOffset(116)]
        public uint SystemThread;
        [FieldOffset(116)]
        public uint ProcessDetachActive;
        [FieldOffset(116)]
        public uint Reserved2;
        [FieldOffset(116)]
        public uint ScbReadyQueue;
        [FieldOffset(116)]
        public uint ApcQueueable;
        [FieldOffset(116)]
        public uint Reserved3;
        [FieldOffset(116)]
        public uint WaitNextClearWobPriorityFloor;
        [FieldOffset(116)]
        public uint TimerSuspended;
        [FieldOffset(116)]
        public uint SuspendedWaitMode;
        [FieldOffset(116)]
        public uint SuspendSchedulerApcWait;
        [FieldOffset(116)]
        public uint CetUserShadowStack;
        [FieldOffset(116)]
        public uint BypassProcessFreeze;
        [FieldOffset(116)]
        public uint CetKernelShadowStack;
        [FieldOffset(116)]
        public uint StateSaveAreaDecoupled;
        [FieldOffset(116)]
        public uint Reserved;
        [FieldOffset(116)]
        public int MiscFlags;
        [FieldOffset(120)]
        public uint UserIdealProcessorFixed;
        [FieldOffset(120)]
        public uint IsolationWidth;
        [FieldOffset(120)]
        public uint AutoAlignment;
        [FieldOffset(120)]
        public uint DisableBoost;
        [FieldOffset(120)]
        public uint AlertedByThreadId;
        [FieldOffset(120)]
        public uint QuantumDonation;
        [FieldOffset(120)]
        public uint EnableStackSwap;
        [FieldOffset(120)]
        public uint GuiThread;
        [FieldOffset(120)]
        public uint DisableQuantum;
        [FieldOffset(120)]
        public uint ChargeOnlySchedulingGroup;
        [FieldOffset(120)]
        public uint DeferPreemption;
        [FieldOffset(120)]
        public uint QueueDeferPreemption;
        [FieldOffset(120)]
        public uint ForceDeferSchedule;
        [FieldOffset(120)]
        public uint SharedReadyQueueAffinity;
        [FieldOffset(120)]
        public uint FreezeCount;
        [FieldOffset(120)]
        public uint TerminationApcRequest;
        [FieldOffset(120)]
        public uint AutoBoostEntriesExhausted;
        [FieldOffset(120)]
        public uint KernelStackResident;
        [FieldOffset(120)]
        public uint TerminateRequestReason;
        [FieldOffset(120)]
        public uint ProcessStackCountDecremented;
        [FieldOffset(120)]
        public uint RestrictedGuiThread;
        [FieldOffset(120)]
        public uint VpBackingThread;
        [FieldOffset(120)]
        public uint EtwStackTraceCrimsonApcDisabled;
        [FieldOffset(120)]
        public uint EtwStackTraceApcInserted;
        [FieldOffset(120)]
        public int ThreadFlags;
        [FieldOffset(124)]
        public byte Tag;
        [FieldOffset(125)]
        public byte CalloutActive;
        [FieldOffset(125)]
        public byte ReservedStackInUse;
        [FieldOffset(125)]
        public byte UserStackWalkActive;
        [FieldOffset(125)]
        public byte SameThreadTransientFlagsReserved;
        [FieldOffset(125)]
        public sbyte SameThreadTransientFlags;
        [FieldOffset(126)]
        public byte RunningNonRetpolineCode;
        [FieldOffset(126)]
        public byte SpecCtrlSpare;
        [FieldOffset(126)]
        public byte SpecCtrl;
        [FieldOffset(128)]
        public uint SystemCallNumber;
        [FieldOffset(132)]
        public uint ReadyTime;
        [FieldOffset(136)]
        public IntPtr FirstArgument;
        [FieldOffset(144)]
        public IntPtr TrapFrame;
        [FieldOffset(152)]
        public _KAPC_STATE ApcState;
        [FieldOffset(152)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 43)]
        public byte[] ApcStateFill;
        [FieldOffset(195)]
        public sbyte Priority;
        [FieldOffset(196)]
        public uint UserIdealProcessor;
        [FieldOffset(200)]
        public long WaitStatus;
        [FieldOffset(208)]
        public IntPtr WaitBlockList;
        [FieldOffset(216)]
        public _LIST_ENTRY WaitListEntry;
        [FieldOffset(216)]
        public _SINGLE_LIST_ENTRY SwapListEntry;
        [FieldOffset(232)]
        public IntPtr Queue;
        [FieldOffset(240)]
        public IntPtr Teb;
        [FieldOffset(248)]
        public ulong RelativeTimerBias;
        [FieldOffset(256)]
        public _KTIMER Timer;
        [FieldOffset(320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _KWAIT_BLOCK[] WaitBlock;
        [FieldOffset(320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] WaitBlockFill4;
        [FieldOffset(340)]
        public uint ContextSwitches;
        [FieldOffset(320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 68)]
        public byte[] WaitBlockFill5;
        [FieldOffset(388)]
        public byte State;
        [FieldOffset(389)]
        public sbyte Spare13;
        [FieldOffset(390)]
        public byte WaitIrql;
        [FieldOffset(391)]
        public sbyte WaitMode;
        [FieldOffset(320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 116)]
        public byte[] WaitBlockFill6;
        [FieldOffset(436)]
        public uint WaitTime;
        [FieldOffset(320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 164)]
        public byte[] WaitBlockFill7;
        [FieldOffset(484)]
        public short KernelApcDisable;
        [FieldOffset(486)]
        public short SpecialApcDisable;
        [FieldOffset(484)]
        public uint CombinedApcDisable;
        [FieldOffset(320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public byte[] WaitBlockFill8;
        [FieldOffset(360)]
        public IntPtr ThreadCounters;
        [FieldOffset(320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
        public byte[] WaitBlockFill9;
        [FieldOffset(408)]
        public IntPtr XStateSave;
        [FieldOffset(320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 136)]
        public byte[] WaitBlockFill10;
        [FieldOffset(456)]
        public IntPtr Win32Thread;
        [FieldOffset(320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 176)]
        public byte[] WaitBlockFill11;
        [FieldOffset(496)]
        public ulong Spare18;
        [FieldOffset(504)]
        public ulong LastXStateSaveDebugInfo;
        [FieldOffset(512)]
        public int ThreadFlags2;
        [FieldOffset(512)]
        public uint DisableKasan;
        [FieldOffset(512)]
        public uint AbContextSwitchState;
        [FieldOffset(512)]
        public uint ThreadFlags2Reserved;
        [FieldOffset(516)]
        public byte BamQosLevel;
        [FieldOffset(517)]
        public byte HardwareFeedbackClass;
        [FieldOffset(518)]
        public short PriorityDecrement;
        [FieldOffset(518)]
        public ushort ForegroundBoost;
        [FieldOffset(518)]
        public ushort UnusualBoost;
        [FieldOffset(520)]
        public _LIST_ENTRY QueueListEntry;
        [FieldOffset(536)]
        public uint NextProcessor;
        [FieldOffset(536)]
        public uint NextProcessorNumber;
        [FieldOffset(536)]
        public uint SharedReadyQueue;
        [FieldOffset(540)]
        public int QueuePriority;
        [FieldOffset(544)]
        public IntPtr Process;
        [FieldOffset(552)]
        public IntPtr UserAffinity;
        [FieldOffset(560)]
        public ushort UserAffinityPrimaryGroup;
        [FieldOffset(562)]
        public sbyte PreviousMode;
        [FieldOffset(563)]
        public sbyte BasePriority;
        [FieldOffset(564)]
        public byte Spare24;
        [FieldOffset(565)]
        public byte Preempted;
        [FieldOffset(566)]
        public byte AdjustReason;
        [FieldOffset(567)]
        public sbyte AdjustIncrement;
        [FieldOffset(568)]
        public ulong AffinityVersion;
        [FieldOffset(576)]
        public IntPtr Affinity;
        [FieldOffset(584)]
        public ushort AffinityPrimaryGroup;
        [FieldOffset(586)]
        public byte ApcStateIndex;
        [FieldOffset(587)]
        public byte WaitBlockCount;
        [FieldOffset(588)]
        public uint IdealProcessor;
        [FieldOffset(592)]
        public ulong NpxState;
        [FieldOffset(600)]
        public _KAPC_STATE SavedApcState;
        [FieldOffset(600)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 43)]
        public byte[] SavedApcStateFill;
        [FieldOffset(643)]
        public byte WaitReason;
        [FieldOffset(644)]
        public sbyte SuspendCount;
        [FieldOffset(645)]
        public sbyte Saturation;
        [FieldOffset(646)]
        public ushort SListFaultCount;
        [FieldOffset(648)]
        public _KAPC SchedulerApc;
        [FieldOffset(648)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] SchedulerApcFill1;
        [FieldOffset(651)]
        public byte QuantumReset;
        [FieldOffset(648)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] SchedulerApcFill2;
        [FieldOffset(652)]
        public uint KernelTime;
        [FieldOffset(648)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] SchedulerApcFill3;
        [FieldOffset(712)]
        public IntPtr WaitPrcb;
        [FieldOffset(648)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
        public byte[] SchedulerApcFill4;
        [FieldOffset(720)]
        public IntPtr LegoData;
        [FieldOffset(648)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 83)]
        public byte[] SchedulerApcFill5;
        [FieldOffset(731)]
        public byte CallbackNestingLevel;
        [FieldOffset(732)]
        public uint UserTime;
        [FieldOffset(736)]
        public _KEVENT SuspendEvent;
        [FieldOffset(760)]
        public _LIST_ENTRY ThreadListEntry;
        [FieldOffset(776)]
        public _LIST_ENTRY MutantListHead;
        [FieldOffset(792)]
        public byte AbWaitEntryCount;
        [FieldOffset(793)]
        public byte AbOwnedEntryCount;
        [FieldOffset(792)]
        public ushort AbEntryCountValue;
        [FieldOffset(794)]
        public byte FreezeFlags;
        [FieldOffset(794)]
        public byte FreezeCount2;
        [FieldOffset(794)]
        public byte FreezeNormal;
        [FieldOffset(794)]
        public byte FreezeDeep;
        [FieldOffset(795)]
        public sbyte WobPriority;
        [FieldOffset(796)]
        public uint SecureThreadCookie;
        [FieldOffset(800)]
        public IntPtr SchedulerSharedSystemSlot;
        [FieldOffset(808)]
        public _SINGLE_LIST_ENTRY PropagateBoostsEntry;
        [FieldOffset(816)]
        public _SINGLE_LIST_ENTRY IoSelfBoostsEntry;
        [FieldOffset(824)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] PriorityFloorCounts;
        [FieldOffset(856)]
        public uint PriorityFloorSummary;
        [FieldOffset(860)]
        public int AbCompletedIoBoostCount;
        [FieldOffset(864)]
        public int AbCompletedIoQoSBoostCount;
        [FieldOffset(868)]
        public short KeReferenceCount;
        [FieldOffset(870)]
        public sbyte DecayBoost;
        [FieldOffset(871)]
        public byte Spare6;
        [FieldOffset(872)]
        public uint ForegroundLossTime;
        [FieldOffset(880)]
        public _LIST_ENTRY GlobalForegroundListEntry;
        [FieldOffset(880)]
        public _SINGLE_LIST_ENTRY ForegroundDpcStackListEntry;
        [FieldOffset(888)]
        public ulong InGlobalForegroundList;
        [FieldOffset(896)]
        public long ReadOperationCount;
        [FieldOffset(904)]
        public long WriteOperationCount;
        [FieldOffset(912)]
        public long OtherOperationCount;
        [FieldOffset(920)]
        public long ReadTransferCount;
        [FieldOffset(928)]
        public long WriteTransferCount;
        [FieldOffset(936)]
        public long OtherTransferCount;
        [FieldOffset(944)]
        public IntPtr QueuedScb;
        [FieldOffset(952)]
        public uint ThreadTimerDelay;
        [FieldOffset(956)]
        public ushort Spare26;
        [FieldOffset(958)]
        public byte PpmPolicy;
        [FieldOffset(959)]
        public byte Spare27;
        [FieldOffset(960)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ulong[] TracingPrivate;
        [FieldOffset(968)]
        public IntPtr SchedulerAssist;
        [FieldOffset(976)]
        public IntPtr AbWaitObject;
        [FieldOffset(984)]
        public uint ReservedPreviousReadyTimeValue;
        [FieldOffset(992)]
        public ulong KernelWaitTime;
        [FieldOffset(1000)]
        public ulong UserWaitTime;
        [FieldOffset(1008)]
        public _LIST_ENTRY GlobalUpdateVpThreadPriorityListEntry;
        [FieldOffset(1008)]
        public _SINGLE_LIST_ENTRY UpdateVpThreadPriorityDpcStackListEntry;
        [FieldOffset(1016)]
        public ulong InGlobalUpdateVpThreadPriorityList;
        [FieldOffset(1024)]
        public int SchedulerAssistPriorityFloor;
        [FieldOffset(1028)]
        public int RealtimePriorityFloor;
        [FieldOffset(1032)]
        public IntPtr KernelShadowStack;
        [FieldOffset(1040)]
        public IntPtr KernelShadowStackInitial;
        [FieldOffset(1048)]
        public IntPtr KernelShadowStackBase;
        [FieldOffset(1056)]
        public _KERNEL_SHADOW_STACK_LIMIT KernelShadowStackLimit;
        [FieldOffset(1064)]
        public ulong ExtendedFeatureDisableMask;
        [FieldOffset(1072)]
        public ulong HgsFeedbackStartTime;
        [FieldOffset(1080)]
        public ulong HgsFeedbackCycles;
        [FieldOffset(1088)]
        public uint HgsInvalidFeedbackCount;
        [FieldOffset(1092)]
        public uint HgsLowerPerfClassFeedbackCount;
        [FieldOffset(1096)]
        public uint HgsHigherPerfClassFeedbackCount;
        [FieldOffset(1100)]
        public uint ModeHistory;
        [FieldOffset(1104)]
        public _SINGLE_LIST_ENTRY SystemAffinityTokenListHead;
        [FieldOffset(1112)]
        public IntPtr IptSaveArea;
        [FieldOffset(1120)]
        public byte ResourceIndex;
        [FieldOffset(1121)]
        public byte CoreIsolationReasons;
        [FieldOffset(1122)]
        public byte BamQosLevelFromAssistPage;
        [FieldOffset(1123)]
        public byte SecureCallCoreIsolationCount;
        [FieldOffset(1124)]
        public uint SchedulerSharedOffset;
        [FieldOffset(1128)]
        public IntPtr SchedulerSharedSwappablePage;
        [FieldOffset(1136)]
        public IntPtr KernelAbEntries;
        [FieldOffset(1144)]
        public IntPtr UserAbEntries;
        [FieldOffset(1152)]
        public ulong KcsanThread;
        [FieldOffset(1160)]
        public uint SchedulerAssistYieldCounter;
        [FieldOffset(1164)]
        public uint SchedulerAssistYieldBoostCount;
        [FieldOffset(1168)]
        public long SchedulerAssistLastYieldBoostTime;
        [FieldOffset(1176)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public ulong[] Padding;
    }
}