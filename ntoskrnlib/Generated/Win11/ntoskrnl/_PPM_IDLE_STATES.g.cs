#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1400)]
    public partial struct _PPM_IDLE_STATES
    {
        [FieldOffset(0)]
        public byte EnforceStateConstraints;
        [FieldOffset(1)]
        public byte IdleOverride;
        [FieldOffset(2)]
        public byte EstimateIdleDuration;
        [FieldOffset(3)]
        public byte ExitLatencyTraceEnabled;
        [FieldOffset(4)]
        public byte NonInterruptibleTransition;
        [FieldOffset(5)]
        public byte UnaccountedTransition;
        [FieldOffset(6)]
        public byte IdleDurationLimited;
        [FieldOffset(7)]
        public byte IdleCheckLimited;
        [FieldOffset(8)]
        public ulong IdleReevaluationDuration;
        [FieldOffset(16)]
        public byte StrictVetoBias;
        [FieldOffset(20)]
        public uint ExitLatencyCountdown;
        [FieldOffset(24)]
        public uint TargetState;
        [FieldOffset(28)]
        public uint ActualState;
        [FieldOffset(32)]
        public uint OldState;
        [FieldOffset(36)]
        public uint OverrideIndex;
        [FieldOffset(40)]
        public uint ProcessorIdleCount;
        [FieldOffset(44)]
        public uint Type;
        [FieldOffset(48)]
        public ulong LevelId;
        [FieldOffset(56)]
        public ushort ReasonFlags;
        [FieldOffset(60)]
        public int PreviousStatus;
        [FieldOffset(64)]
        public byte PreviouslyCancelled;
        [FieldOffset(65)]
        public byte PreviouslyDeniedCount;
        [FieldOffset(72)]
        public _KAFFINITY_EX PrimaryProcessorMask;
        [FieldOffset(336)]
        public _KAFFINITY_EX SecondaryProcessorMask;
        [FieldOffset(600)]
        public IntPtr IdlePreExecute;
        [FieldOffset(608)]
        public IntPtr IdleExecute;
        [FieldOffset(616)]
        public IntPtr IdlePreselect;
        [FieldOffset(624)]
        public IntPtr IdleTest;
        [FieldOffset(632)]
        public IntPtr IdleAvailabilityCheck;
        [FieldOffset(640)]
        public IntPtr IdleComplete;
        [FieldOffset(648)]
        public IntPtr IdleIsHalted;
        [FieldOffset(656)]
        public IntPtr IdleInitiateWake;
        [FieldOffset(664)]
        public IntPtr Context;
        [FieldOffset(672)]
        public _PROCESSOR_IDLE_CONSTRAINTS Constraints;
        [FieldOffset(720)]
        public _KAFFINITY_EX DeepIdleSnapshot;
        [FieldOffset(984)]
        public IntPtr Tracing;
        [FieldOffset(992)]
        public IntPtr CoordinatedTracing;
        [FieldOffset(1000)]
        public _PPM_SELECTION_MENU ProcessorMenu;
        [FieldOffset(1016)]
        public _PPM_SELECTION_MENU CoordinatedMenu;
        [FieldOffset(1032)]
        public _PPM_COORDINATED_SELECTION CoordinatedSelection;
        [FieldOffset(1056)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _PPM_IDLE_STATE[] State;
    }
}