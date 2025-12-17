using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PPM_PERF_SNAPSHOT")]
    public sealed class PpmPerfSnapshot : DynamicStructure
    {
        [Offset(0UL)]
        public uint Initiator { get => ReadHere<uint>(nameof(Initiator)); set => WriteHere(nameof(Initiator), value); }

        [Offset(4UL)]
        public byte LogType { get => ReadHere<byte>(nameof(LogType)); set => WriteHere(nameof(LogType), value); }

        [Offset(5UL)]
        public byte Reset { get => ReadHere<byte>(nameof(Reset)); set => WriteHere(nameof(Reset), value); }

        [Offset(6UL)]
        public byte Remote { get => ReadHere<byte>(nameof(Remote)); set => WriteHere(nameof(Remote), value); }

        [Offset(8UL)]
        public ulong InterruptTime { get => ReadHere<ulong>(nameof(InterruptTime)); set => WriteHere(nameof(InterruptTime), value); }

        [Offset(16UL)]
        public ulong RawUnscaledTime { get => ReadHere<ulong>(nameof(RawUnscaledTime)); set => WriteHere(nameof(RawUnscaledTime), value); }

        [Offset(24UL)]
        public ulong TotalUnscaleTime { get => ReadHere<ulong>(nameof(TotalUnscaleTime)); set => WriteHere(nameof(TotalUnscaleTime), value); }

        [Offset(32UL)]
        [Length(2)]
        public DynamicArray CachedScalingFactor { get => ReadStructure<DynamicArray>(nameof(CachedScalingFactor)); set => WriteStructure(nameof(CachedScalingFactor), value); }

        [Offset(40UL)]
        [Length(2)]
        public DynamicArray RawReferenceCount { get => ReadStructure<DynamicArray>(nameof(RawReferenceCount)); set => WriteStructure(nameof(RawReferenceCount), value); }

        [Offset(56UL)]
        [Length(2)]
        public DynamicArray RawActualCount { get => ReadStructure<DynamicArray>(nameof(RawActualCount)); set => WriteStructure(nameof(RawActualCount), value); }

        [Offset(72UL)]
        [Length(2)]
        public DynamicArray RawScaledTime { get => ReadStructure<DynamicArray>(nameof(RawScaledTime)); set => WriteStructure(nameof(RawScaledTime), value); }

        [Offset(88UL)]
        [Length(2)]
        public DynamicArray TotalScaleTime { get => ReadStructure<DynamicArray>(nameof(TotalScaleTime)); set => WriteStructure(nameof(TotalScaleTime), value); }

        [Offset(104UL)]
        public ulong HvCurrentTime { get => ReadHere<ulong>(nameof(HvCurrentTime)); set => WriteHere(nameof(HvCurrentTime), value); }

        [Offset(112UL)]
        public ulong IdleAccumulation { get => ReadHere<ulong>(nameof(IdleAccumulation)); set => WriteHere(nameof(IdleAccumulation), value); }

        [Offset(120UL)]
        [Length(2)]
        public DynamicArray Value { get => ReadStructure<DynamicArray>(nameof(Value)); set => WriteStructure(nameof(Value), value); }

        public PpmPerfSnapshot(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmPerfSnapshot>();
        }
    }
}