using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_THERMAL_INFORMATION_EX")]
    public sealed class ThermalInformationEx : DynamicStructure
    {
        [Offset(0UL)]
        public uint ThermalStamp { get => ReadHere<uint>(nameof(ThermalStamp)); set => WriteHere(nameof(ThermalStamp), value); }

        [Offset(4UL)]
        public uint ThermalConstant1 { get => ReadHere<uint>(nameof(ThermalConstant1)); set => WriteHere(nameof(ThermalConstant1), value); }

        [Offset(8UL)]
        public uint ThermalConstant2 { get => ReadHere<uint>(nameof(ThermalConstant2)); set => WriteHere(nameof(ThermalConstant2), value); }

        [Offset(12UL)]
        public uint SamplingPeriod { get => ReadHere<uint>(nameof(SamplingPeriod)); set => WriteHere(nameof(SamplingPeriod), value); }

        [Offset(16UL)]
        public uint CurrentTemperature { get => ReadHere<uint>(nameof(CurrentTemperature)); set => WriteHere(nameof(CurrentTemperature), value); }

        [Offset(20UL)]
        public uint PassiveTripPoint { get => ReadHere<uint>(nameof(PassiveTripPoint)); set => WriteHere(nameof(PassiveTripPoint), value); }

        [Offset(24UL)]
        public uint ThermalStandbyTripPoint { get => ReadHere<uint>(nameof(ThermalStandbyTripPoint)); set => WriteHere(nameof(ThermalStandbyTripPoint), value); }

        [Offset(28UL)]
        public uint CriticalTripPoint { get => ReadHere<uint>(nameof(CriticalTripPoint)); set => WriteHere(nameof(CriticalTripPoint), value); }

        [Offset(32UL)]
        public byte ActiveTripPointCount { get => ReadHere<byte>(nameof(ActiveTripPointCount)); set => WriteHere(nameof(ActiveTripPointCount), value); }

        [Offset(33UL)]
        public byte PassiveCoolingDevicesPresent { get => ReadHere<byte>(nameof(PassiveCoolingDevicesPresent)); set => WriteHere(nameof(PassiveCoolingDevicesPresent), value); }

        [Offset(36UL)]
        [Length(10)]
        public DynamicArray ActiveTripPoint { get => ReadStructure<DynamicArray>(nameof(ActiveTripPoint)); set => WriteStructure(nameof(ActiveTripPoint), value); }

        [Offset(76UL)]
        public uint S4TransitionTripPoint { get => ReadHere<uint>(nameof(S4TransitionTripPoint)); set => WriteHere(nameof(S4TransitionTripPoint), value); }

        [Offset(80UL)]
        public uint MinimumThrottle { get => ReadHere<uint>(nameof(MinimumThrottle)); set => WriteHere(nameof(MinimumThrottle), value); }

        [Offset(84UL)]
        public uint OverThrottleThreshold { get => ReadHere<uint>(nameof(OverThrottleThreshold)); set => WriteHere(nameof(OverThrottleThreshold), value); }

        [Offset(88UL)]
        public uint PollingPeriod { get => ReadHere<uint>(nameof(PollingPeriod)); set => WriteHere(nameof(PollingPeriod), value); }

        public ThermalInformationEx(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ThermalInformationEx>();
        }
    }
}