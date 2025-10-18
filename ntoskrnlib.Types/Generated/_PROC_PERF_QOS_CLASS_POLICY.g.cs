using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _PROC_PERF_QOS_CLASS_POLICY
{
    [FieldOffset(0)]
    public uint MaxPolicyPercent;
    [FieldOffset(4)]
    public uint MaxEquivalentFrequencyPercent;
    [FieldOffset(8)]
    public uint MinPolicyPercent;
    [FieldOffset(12)]
    public uint AutonomousActivityWindow;
    [FieldOffset(16)]
    public uint EnergyPerfPreference;
    [FieldOffset(20)]
    public byte ProvideGuidance;
    [FieldOffset(21)]
    public byte AllowThrottling;
    [FieldOffset(22)]
    public byte PerfBoostMode;
    [FieldOffset(23)]
    public byte LatencyHintPerf;
    [FieldOffset(24)]
    public byte LatencyHintEpp;
    [FieldOffset(25)]
    public byte TrackDesiredCrossClass;
    [FieldOffset(28)]
    public uint ResourcePriority;
}
