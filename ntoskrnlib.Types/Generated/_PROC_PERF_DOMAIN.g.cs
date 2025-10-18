using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=1216)]
public struct _PROC_PERF_DOMAIN
{
    [FieldOffset(0)]
    public _LIST_ENTRY Link;
    [FieldOffset(16)]
    public IntPtr Master;
    [FieldOffset(24)]
    public _KAFFINITY_EX Members;
    [FieldOffset(288)]
    public ulong DomainContext;
    [FieldOffset(296)]
    public uint ProcessorCount;
    [FieldOffset(300)]
    public byte EfficiencyClass;
    [FieldOffset(301)]
    public byte NominalPerformanceClass;
    [FieldOffset(302)]
    public byte PerformanceClass;
    [FieldOffset(304)]
    public IntPtr Presence;
    [FieldOffset(312)]
    public IntPtr Processors;
    [FieldOffset(320)]
    public IntPtr GetFFHThrottleState;
    [FieldOffset(328)]
    public IntPtr TimeWindowHandler;
    [FieldOffset(336)]
    public IntPtr BoostPolicyHandler;
    [FieldOffset(344)]
    public IntPtr BoostModeHandler;
    [FieldOffset(352)]
    public IntPtr AutonomousActivityWindowHandler;
    [FieldOffset(360)]
    public IntPtr AutonomousModeHandler;
    [FieldOffset(368)]
    public IntPtr ReinitializeHandler;
    [FieldOffset(376)]
    public IntPtr PerfSelectionHandler;
    [FieldOffset(384)]
    public IntPtr PerfPriorityHandler;
    [FieldOffset(392)]
    public IntPtr PerfControlHandler;
    [FieldOffset(400)]
    public IntPtr PerfControlHandlerHidden;
    [FieldOffset(408)]
    public IntPtr DomainPerfControlHandler;
    [FieldOffset(416)]
    public IntPtr PerfUpdateHwDebugData;
    [FieldOffset(424)]
    public IntPtr PerfQueryProcMeasurementCapabilities;
    [FieldOffset(432)]
    public IntPtr PerfQueryProcMeasurementValues;
    [FieldOffset(440)]
    public uint Id;
    [FieldOffset(444)]
    public uint MaxFrequency;
    [FieldOffset(448)]
    public uint NominalFrequency;
    [FieldOffset(452)]
    public uint MaxPercent;
    [FieldOffset(456)]
    public uint MinPerfPercent;
    [FieldOffset(460)]
    public uint MinThrottlePercent;
    [FieldOffset(464)]
    public uint AdvertizedMaximumFrequency;
    [FieldOffset(472)]
    public ulong MinimumRelativePerformance;
    [FieldOffset(480)]
    public ulong NominalRelativePerformance;
    [FieldOffset(488)]
    public byte NominalRelativePerformancePercent;
    [FieldOffset(489)]
    public byte Coordination;
    [FieldOffset(490)]
    public byte HardPlatformCap;
    [FieldOffset(491)]
    public byte AffinitizeControl;
    [FieldOffset(492)]
    public byte EfficientThrottle;
    [FieldOffset(493)]
    public byte AllowSchedulerDirectedPerfStates;
    [FieldOffset(494)]
    public byte InitiateAllProcessors;
    [FieldOffset(495)]
    public byte AllowVmPerfSelection;
    [FieldOffset(496)]
    public byte TurboRangeKnown;
    [FieldOffset(500)]
    public uint VmFrequencyStepMhz;
    [FieldOffset(504)]
    public uint VmHighestFrequencyMhz;
    [FieldOffset(508)]
    public uint VmNominalFrequencyMhz;
    [FieldOffset(512)]
    public uint VmLowestFrequencyMhz;
    [FieldOffset(516)]
    public uint VmThrottlePriorityCount;
    [FieldOffset(520)]
    public byte AutonomousMode;
    [FieldOffset(521)]
    public byte AutonomousCapability;
    [FieldOffset(522)]
    public byte ProvideGuidance;
    [FieldOffset(523)]
    public byte EppSupported;
    [FieldOffset(524)]
    public uint DesiredPercent;
    [FieldOffset(528)]
    public uint GuaranteedPercent;
    [FieldOffset(532)]
    public byte EngageResponsivenessOverrides;
    [FieldOffset(536)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=7)]
    public byte[] QosPolicies;
    [FieldOffset(760)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=7)]
    public uint[] QosDisableReasons;
    [FieldOffset(788)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=7)]
    public ushort[] QosEquivalencyMasks;
    [FieldOffset(802)]
    public byte QosSupported;
    [FieldOffset(804)]
    public uint SelectionGeneration;
    [FieldOffset(808)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=7)]
    public byte[] QosSelection;
    [FieldOffset(1200)]
    public ulong PerfChangeTime;
    [FieldOffset(1208)]
    public uint PerfChangeIntervalCount;
    [FieldOffset(1212)]
    public byte Force;
    [FieldOffset(1213)]
    public byte Update;
    [FieldOffset(1214)]
    public byte Apply;
}
