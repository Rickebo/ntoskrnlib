#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1192)]
    public partial struct _PROC_PERF_CONSTRAINT
    {
        [FieldOffset(0)]
        public IntPtr CheckContext;
        [FieldOffset(8)]
        public ulong PerfContext;
        [FieldOffset(16)]
        public uint Presence;
        [FieldOffset(20)]
        public uint ProcessorId;
        [FieldOffset(24)]
        public uint PlatformCap;
        [FieldOffset(28)]
        public uint ThermalCap;
        [FieldOffset(32)]
        public uint LimitReasons;
        [FieldOffset(40)]
        public ulong PlatformCapStartTime;
        [FieldOffset(48)]
        public uint ProcCap;
        [FieldOffset(52)]
        public uint ProcFloor;
        [FieldOffset(56)]
        public uint TargetPercent;
        [FieldOffset(60)]
        public byte EngageResponsivenessOverrides;
        [FieldOffset(61)]
        public byte ResponsivenessChangeCount;
        [FieldOffset(64)]
        public _PERF_CONTROL_STATE_SELECTION Selection;
        [FieldOffset(120)]
        public uint DomainSelectionGeneration;
        [FieldOffset(124)]
        public uint PreviousFrequency;
        [FieldOffset(128)]
        public uint PreviousPercent;
        [FieldOffset(132)]
        public uint LatestFrequencyPercent;
        [FieldOffset(136)]
        public uint LatestPerformancePercent;
        [FieldOffset(140)]
        public byte Force;
        [FieldOffset(141)]
        public byte UseQosUpdateLock;
        [FieldOffset(144)]
        public ulong QosUpdateLock;
        [FieldOffset(152)]
        public uint CurrentLogEntry;
        [FieldOffset(160)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public _PPM_PERF_SNAPSHOT[] SnapshotLog;
        [FieldOffset(1184)]
        public uint IncreasePerfCheckCount;
        [FieldOffset(1188)]
        public uint DecreasePerfCheckCount;
    }
}