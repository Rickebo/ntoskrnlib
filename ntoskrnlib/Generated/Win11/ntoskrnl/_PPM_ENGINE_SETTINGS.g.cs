#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 488)]
    public partial struct _PPM_ENGINE_SETTINGS
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _PPM_POLICY_SETTINGS_MASK[] ExplicitSetting;
        [FieldOffset(32)]
        public byte ThrottlingPolicy;
        [FieldOffset(36)]
        public uint PerfTimeCheck;
        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] PerfHistoryCount;
        [FieldOffset(42)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] PerfMinPolicy;
        [FieldOffset(44)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] PerfMaxPolicy;
        [FieldOffset(46)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] PerfDecreaseTime;
        [FieldOffset(48)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] PerfIncreaseTime;
        [FieldOffset(50)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] PerfDecreasePolicy;
        [FieldOffset(52)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] PerfIncreasePolicy;
        [FieldOffset(54)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] PerfDecreaseThreshold;
        [FieldOffset(56)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] PerfIncreaseThreshold;
        [FieldOffset(60)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] PerfFrequencyCap;
        [FieldOffset(68)]
        public uint PerfBoostPolicy;
        [FieldOffset(72)]
        public uint PerfBoostMode;
        [FieldOffset(76)]
        public uint PerfReductionTolerance;
        [FieldOffset(80)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] EnergyPerfPreference;
        [FieldOffset(88)]
        public uint AutonomousActivityWindow;
        [FieldOffset(92)]
        public byte AutonomousPreference;
        [FieldOffset(93)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] LatencyHintPerf;
        [FieldOffset(95)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] LatencyHintEpp;
        [FieldOffset(97)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] LatencyHintUnpark;
        [FieldOffset(100)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] ResponsivenessDisableThreshold;
        [FieldOffset(108)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] ResponsivenessEnableThreshold;
        [FieldOffset(116)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] ResponsivenessDisableTime;
        [FieldOffset(118)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] ResponsivenessEnableTime;
        [FieldOffset(120)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] ResponsivenessEppCeiling;
        [FieldOffset(128)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] ResponsivenessPerfFloor;
        [FieldOffset(136)]
        public byte DutyCycling;
        [FieldOffset(137)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] ParkingPerfState;
        [FieldOffset(139)]
        public byte DistributeUtility;
        [FieldOffset(140)]
        public byte CoreParkingOverUtilizationThreshold;
        [FieldOffset(141)]
        public byte CoreParkingConcurrencyThreshold;
        [FieldOffset(142)]
        public byte CoreParkingHeadroomThreshold;
        [FieldOffset(143)]
        public byte CoreParkingDistributionThreshold;
        [FieldOffset(144)]
        public byte CoreParkingDecreasePolicy;
        [FieldOffset(145)]
        public byte CoreParkingIncreasePolicy;
        [FieldOffset(148)]
        public uint CoreParkingDecreaseTime;
        [FieldOffset(152)]
        public uint CoreParkingIncreaseTime;
        [FieldOffset(156)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] CoreParkingMinCores;
        [FieldOffset(158)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] CoreParkingMaxCores;
        [FieldOffset(160)]
        public uint SoftParkLatency;
        [FieldOffset(164)]
        public byte AllowScaling;
        [FieldOffset(165)]
        public byte IdleDisabled;
        [FieldOffset(168)]
        public uint IdleTimeCheck;
        [FieldOffset(172)]
        public byte IdleDemotePercent;
        [FieldOffset(173)]
        public byte IdlePromotePercent;
        [FieldOffset(174)]
        public byte IdleStateMax;
        [FieldOffset(175)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] ResourcePriority;
        [FieldOffset(177)]
        public byte HeteroDecreaseTime;
        [FieldOffset(178)]
        public byte HeteroIncreaseTime;
        [FieldOffset(179)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] HeteroDecreaseThreshold;
        [FieldOffset(307)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] HeteroIncreaseThreshold;
        [FieldOffset(435)]
        public byte Class0FloorPerformance;
        [FieldOffset(436)]
        public byte Class1InitialPerformance;
        [FieldOffset(440)]
        public uint ShortThreadRuntimeThreshold;
        [FieldOffset(444)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] ThreadPolicies;
        [FieldOffset(452)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] ArchClassLowerThreshold;
        [FieldOffset(454)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] ArchClassUpperThreshold;
        [FieldOffset(456)]
        public byte ModuleUnparkPolicy;
        [FieldOffset(457)]
        public byte ComplexUnparkPolicy;
        [FieldOffset(458)]
        public byte SmtUnparkPolicy;
        [FieldOffset(460)]
        public uint HeteroPolicy;
        [FieldOffset(464)]
        public uint HeteroContainmentDecreaseTime;
        [FieldOffset(468)]
        public uint HeteroContainmentIncreaseTime;
        [FieldOffset(472)]
        public uint HeteroEfficiencyContainmentThreshold;
        [FieldOffset(476)]
        public uint HeteroHybridContainmentThreshold;
        [FieldOffset(480)]
        public uint HeteroContainmentPolicy;
        [FieldOffset(484)]
        public byte RestrictionCount;
    }
}