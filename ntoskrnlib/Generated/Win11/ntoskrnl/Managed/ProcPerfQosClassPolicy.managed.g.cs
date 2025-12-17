using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROC_PERF_QOS_CLASS_POLICY")]
    public sealed class ProcPerfQosClassPolicy : DynamicStructure
    {
        [Offset(0UL)]
        public uint MaxPolicyPercent { get => ReadHere<uint>(nameof(MaxPolicyPercent)); set => WriteHere(nameof(MaxPolicyPercent), value); }

        [Offset(4UL)]
        public uint MaxEquivalentFrequencyPercent { get => ReadHere<uint>(nameof(MaxEquivalentFrequencyPercent)); set => WriteHere(nameof(MaxEquivalentFrequencyPercent), value); }

        [Offset(8UL)]
        public uint MinPolicyPercent { get => ReadHere<uint>(nameof(MinPolicyPercent)); set => WriteHere(nameof(MinPolicyPercent), value); }

        [Offset(12UL)]
        public uint AutonomousActivityWindow { get => ReadHere<uint>(nameof(AutonomousActivityWindow)); set => WriteHere(nameof(AutonomousActivityWindow), value); }

        [Offset(16UL)]
        public uint EnergyPerfPreference { get => ReadHere<uint>(nameof(EnergyPerfPreference)); set => WriteHere(nameof(EnergyPerfPreference), value); }

        [Offset(20UL)]
        public byte ProvideGuidance { get => ReadHere<byte>(nameof(ProvideGuidance)); set => WriteHere(nameof(ProvideGuidance), value); }

        [Offset(21UL)]
        public byte AllowThrottling { get => ReadHere<byte>(nameof(AllowThrottling)); set => WriteHere(nameof(AllowThrottling), value); }

        [Offset(22UL)]
        public byte PerfBoostMode { get => ReadHere<byte>(nameof(PerfBoostMode)); set => WriteHere(nameof(PerfBoostMode), value); }

        [Offset(23UL)]
        public byte LatencyHintPerf { get => ReadHere<byte>(nameof(LatencyHintPerf)); set => WriteHere(nameof(LatencyHintPerf), value); }

        [Offset(24UL)]
        public byte LatencyHintEpp { get => ReadHere<byte>(nameof(LatencyHintEpp)); set => WriteHere(nameof(LatencyHintEpp), value); }

        [Offset(25UL)]
        public byte TrackDesiredCrossClass { get => ReadHere<byte>(nameof(TrackDesiredCrossClass)); set => WriteHere(nameof(TrackDesiredCrossClass), value); }

        [Offset(28UL)]
        public uint ResourcePriority { get => ReadHere<uint>(nameof(ResourcePriority)); set => WriteHere(nameof(ResourcePriority), value); }

        public ProcPerfQosClassPolicy(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcPerfQosClassPolicy>();
        }
    }
}