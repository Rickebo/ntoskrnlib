#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 568)]
    public partial struct _PROCESSOR_POWER_STATE
    {
        [FieldOffset(0)]
        public IntPtr IdleStates;
        [FieldOffset(8)]
        public IntPtr IdleAccounting;
        [FieldOffset(16)]
        public ulong IdleTimeLast;
        [FieldOffset(24)]
        public ulong IdleTimeTotal;
        [FieldOffset(32)]
        public ulong IdleSequenceNumber;
        [FieldOffset(40)]
        public ulong IdleTimeEntry;
        [FieldOffset(48)]
        public ulong IdleTimeExpiration;
        [FieldOffset(48)]
        public long IdleWakeTime;
        [FieldOffset(56)]
        public uint IdleWakeLatencyLimit;
        [FieldOffset(60)]
        public byte NonInterruptibleTransition;
        [FieldOffset(61)]
        public byte PepWokenTransition;
        [FieldOffset(62)]
        public byte HvTargetState;
        [FieldOffset(64)]
        public uint TargetIdleState;
        [FieldOffset(68)]
        public _PROC_IDLE_POLICY IdlePolicy;
        [FieldOffset(76)]
        public _PPM_IDLE_SYNCHRONIZATION_STATE Synchronization;
        [FieldOffset(80)]
        public _PROC_FEEDBACK PerfFeedback;
        [FieldOffset(224)]
        public uint Hypervisor;
        [FieldOffset(228)]
        public uint LastSysTime;
        [FieldOffset(232)]
        public ulong WmiDispatchPtr;
        [FieldOffset(240)]
        public int WmiInterfaceEnabled;
        [FieldOffset(248)]
        public _PPM_FFH_THROTTLE_STATE_INFO FFHThrottleStateInfo;
        [FieldOffset(280)]
        public _KDPC PerfActionDpc;
        [FieldOffset(344)]
        public int PerfActionMask;
        [FieldOffset(352)]
        public _PROC_IDLE_SNAP HvIdleCheck;
        [FieldOffset(368)]
        public _PROC_PERF_CHECK_CONTEXT CheckContext;
        [FieldOffset(440)]
        public IntPtr Concurrency;
        [FieldOffset(448)]
        public IntPtr ClassConcurrency;
        [FieldOffset(456)]
        public byte ArchitecturalEfficiencyClass;
        [FieldOffset(457)]
        public byte PerformanceSchedulingClass;
        [FieldOffset(458)]
        public byte EfficiencySchedulingClass;
        [FieldOffset(459)]
        public byte Reserved;
        [FieldOffset(460)]
        public byte Parked;
        [FieldOffset(461)]
        public byte SoftParked;
        [FieldOffset(462)]
        public byte LongPriorQosPeriod;
        [FieldOffset(464)]
        public ulong SnapTimeLast;
        [FieldOffset(464)]
        public ulong EnergyConsumed;
        [FieldOffset(472)]
        public ulong ActiveTime;
        [FieldOffset(480)]
        public ulong TotalTime;
        [FieldOffset(488)]
        public IntPtr FxDevice;
        [FieldOffset(496)]
        public ulong LastQosTransitionTime;
        [FieldOffset(504)]
        public ulong QosTransitionHysteresis;
        [FieldOffset(512)]
        public uint RequestedQosClass;
        [FieldOffset(516)]
        public uint ResolvedQosClass;
        [FieldOffset(520)]
        public ushort QosEquivalencyMask;
        [FieldOffset(522)]
        public ushort HwFeedbackTableOffset;
        [FieldOffset(524)]
        public byte HwFeedbackParkHint;
        [FieldOffset(525)]
        public byte HeteroCoreType;
        [FieldOffset(526)]
        public ushort HwFeedbackTableIndex;
        [FieldOffset(528)]
        public IntPtr HwFeedbackClassList;
        [FieldOffset(536)]
        public IntPtr EeCyclesWorkloadClassList;
        [FieldOffset(544)]
        public IntPtr PerfCyclesWorkloadClassList;
        [FieldOffset(552)]
        public byte ContainmentGroupType;
        [FieldOffset(554)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] FrequencyBucketThresholds;
    }
}