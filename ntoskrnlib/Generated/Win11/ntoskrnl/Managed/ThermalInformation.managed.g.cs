using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_THERMAL_INFORMATION")]
    public sealed class ThermalInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint ThermalStamp { get => ReadHere<uint>(nameof(ThermalStamp)); set => WriteHere(nameof(ThermalStamp), value); }

        [Offset(4UL)]
        public uint ThermalConstant1 { get => ReadHere<uint>(nameof(ThermalConstant1)); set => WriteHere(nameof(ThermalConstant1), value); }

        [Offset(8UL)]
        public uint ThermalConstant2 { get => ReadHere<uint>(nameof(ThermalConstant2)); set => WriteHere(nameof(ThermalConstant2), value); }

        [Offset(16UL)]
        public ulong Processors { get => ReadHere<ulong>(nameof(Processors)); set => WriteHere(nameof(Processors), value); }

        [Offset(24UL)]
        public uint SamplingPeriod { get => ReadHere<uint>(nameof(SamplingPeriod)); set => WriteHere(nameof(SamplingPeriod), value); }

        [Offset(28UL)]
        public uint CurrentTemperature { get => ReadHere<uint>(nameof(CurrentTemperature)); set => WriteHere(nameof(CurrentTemperature), value); }

        [Offset(32UL)]
        public uint PassiveTripPoint { get => ReadHere<uint>(nameof(PassiveTripPoint)); set => WriteHere(nameof(PassiveTripPoint), value); }

        [Offset(36UL)]
        public uint CriticalTripPoint { get => ReadHere<uint>(nameof(CriticalTripPoint)); set => WriteHere(nameof(CriticalTripPoint), value); }

        [Offset(40UL)]
        public byte ActiveTripPointCount { get => ReadHere<byte>(nameof(ActiveTripPointCount)); set => WriteHere(nameof(ActiveTripPointCount), value); }

        [Offset(44UL)]
        [Length(10)]
        public DynamicArray ActiveTripPoint { get => ReadStructure<DynamicArray>(nameof(ActiveTripPoint)); set => WriteStructure(nameof(ActiveTripPoint), value); }

        public ThermalInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ThermalInformation>();
        }
    }
}