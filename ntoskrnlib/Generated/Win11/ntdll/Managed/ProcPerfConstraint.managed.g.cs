using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PROC_PERF_CONSTRAINT")]
    public sealed class ProcPerfConstraint : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr CheckContext { get => ReadHere<IntPtr>(nameof(CheckContext)); set => WriteHere(nameof(CheckContext), value); }

        [Offset(8UL)]
        public ulong PerfContext { get => ReadHere<ulong>(nameof(PerfContext)); set => WriteHere(nameof(PerfContext), value); }

        [Offset(16UL)]
        public uint Presence { get => ReadHere<uint>(nameof(Presence)); set => WriteHere(nameof(Presence), value); }

        [Offset(20UL)]
        public uint ProcessorId { get => ReadHere<uint>(nameof(ProcessorId)); set => WriteHere(nameof(ProcessorId), value); }

        [Offset(24UL)]
        public uint PlatformCap { get => ReadHere<uint>(nameof(PlatformCap)); set => WriteHere(nameof(PlatformCap), value); }

        [Offset(28UL)]
        public uint ThermalCap { get => ReadHere<uint>(nameof(ThermalCap)); set => WriteHere(nameof(ThermalCap), value); }

        [Offset(32UL)]
        public uint LimitReasons { get => ReadHere<uint>(nameof(LimitReasons)); set => WriteHere(nameof(LimitReasons), value); }

        [Offset(40UL)]
        public ulong PlatformCapStartTime { get => ReadHere<ulong>(nameof(PlatformCapStartTime)); set => WriteHere(nameof(PlatformCapStartTime), value); }

        [Offset(48UL)]
        public uint ProcCap { get => ReadHere<uint>(nameof(ProcCap)); set => WriteHere(nameof(ProcCap), value); }

        [Offset(52UL)]
        public uint ProcFloor { get => ReadHere<uint>(nameof(ProcFloor)); set => WriteHere(nameof(ProcFloor), value); }

        [Offset(56UL)]
        public uint TargetPercent { get => ReadHere<uint>(nameof(TargetPercent)); set => WriteHere(nameof(TargetPercent), value); }

        [Offset(60UL)]
        public byte EngageResponsivenessOverrides { get => ReadHere<byte>(nameof(EngageResponsivenessOverrides)); set => WriteHere(nameof(EngageResponsivenessOverrides), value); }

        [Offset(61UL)]
        public byte ResponsivenessChangeCount { get => ReadHere<byte>(nameof(ResponsivenessChangeCount)); set => WriteHere(nameof(ResponsivenessChangeCount), value); }

        [Offset(64UL)]
        public PerfControlStateSelection Selection { get => ReadStructure<PerfControlStateSelection>(nameof(Selection)); set => WriteStructure(nameof(Selection), value); }

        [Offset(120UL)]
        public uint DomainSelectionGeneration { get => ReadHere<uint>(nameof(DomainSelectionGeneration)); set => WriteHere(nameof(DomainSelectionGeneration), value); }

        [Offset(124UL)]
        public uint PreviousFrequency { get => ReadHere<uint>(nameof(PreviousFrequency)); set => WriteHere(nameof(PreviousFrequency), value); }

        [Offset(128UL)]
        public uint PreviousPercent { get => ReadHere<uint>(nameof(PreviousPercent)); set => WriteHere(nameof(PreviousPercent), value); }

        [Offset(132UL)]
        public uint LatestFrequencyPercent { get => ReadHere<uint>(nameof(LatestFrequencyPercent)); set => WriteHere(nameof(LatestFrequencyPercent), value); }

        [Offset(136UL)]
        public uint LatestPerformancePercent { get => ReadHere<uint>(nameof(LatestPerformancePercent)); set => WriteHere(nameof(LatestPerformancePercent), value); }

        [Offset(140UL)]
        public byte Force { get => ReadHere<byte>(nameof(Force)); set => WriteHere(nameof(Force), value); }

        [Offset(141UL)]
        public byte UseQosUpdateLock { get => ReadHere<byte>(nameof(UseQosUpdateLock)); set => WriteHere(nameof(UseQosUpdateLock), value); }

        [Offset(144UL)]
        public ulong QosUpdateLock { get => ReadHere<ulong>(nameof(QosUpdateLock)); set => WriteHere(nameof(QosUpdateLock), value); }

        [Offset(152UL)]
        public uint CurrentLogEntry { get => ReadHere<uint>(nameof(CurrentLogEntry)); set => WriteHere(nameof(CurrentLogEntry), value); }

        [Offset(160UL)]
        [Length(8)]
        public DynamicArray SnapshotLog { get => ReadStructure<DynamicArray>(nameof(SnapshotLog)); set => WriteStructure(nameof(SnapshotLog), value); }

        [Offset(1184UL)]
        public uint IncreasePerfCheckCount { get => ReadHere<uint>(nameof(IncreasePerfCheckCount)); set => WriteHere(nameof(IncreasePerfCheckCount), value); }

        [Offset(1188UL)]
        public uint DecreasePerfCheckCount { get => ReadHere<uint>(nameof(DecreasePerfCheckCount)); set => WriteHere(nameof(DecreasePerfCheckCount), value); }

        public ProcPerfConstraint(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcPerfConstraint>();
        }
    }
}