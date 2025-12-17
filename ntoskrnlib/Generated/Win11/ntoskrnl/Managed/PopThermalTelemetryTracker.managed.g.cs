using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_THERMAL_TELEMETRY_TRACKER")]
    public sealed class PopThermalTelemetryTracker : DynamicStructure
    {
        [Offset(0UL)]
        public byte AccountingDisabled { get => ReadHere<byte>(nameof(AccountingDisabled)); set => WriteHere(nameof(AccountingDisabled), value); }

        [Offset(1UL)]
        public byte ActiveLevels { get => ReadHere<byte>(nameof(ActiveLevels)); set => WriteHere(nameof(ActiveLevels), value); }

        [Offset(8UL)]
        public ulong LastPassiveUpdateTime { get => ReadHere<ulong>(nameof(LastPassiveUpdateTime)); set => WriteHere(nameof(LastPassiveUpdateTime), value); }

        [Offset(16UL)]
        public ulong LastActiveUpdateTime { get => ReadHere<ulong>(nameof(LastActiveUpdateTime)); set => WriteHere(nameof(LastActiveUpdateTime), value); }

        [Offset(24UL)]
        [Length(21)]
        public DynamicArray TotalPassiveTime { get => ReadStructure<DynamicArray>(nameof(TotalPassiveTime)); set => WriteStructure(nameof(TotalPassiveTime), value); }

        [Offset(192UL)]
        [Length(21)]
        public DynamicArray PassiveTimeSnap { get => ReadStructure<DynamicArray>(nameof(PassiveTimeSnap)); set => WriteStructure(nameof(PassiveTimeSnap), value); }

        [Offset(360UL)]
        [Length(10)]
        public DynamicArray TotalActiveTime { get => ReadStructure<DynamicArray>(nameof(TotalActiveTime)); set => WriteStructure(nameof(TotalActiveTime), value); }

        [Offset(440UL)]
        [Length(10)]
        public DynamicArray ActiveTimeSnap { get => ReadStructure<DynamicArray>(nameof(ActiveTimeSnap)); set => WriteStructure(nameof(ActiveTimeSnap), value); }

        [Offset(520UL)]
        public ulong TotalTime { get => ReadHere<ulong>(nameof(TotalTime)); set => WriteHere(nameof(TotalTime), value); }

        [Offset(528UL)]
        public ulong TotalTimeSnap { get => ReadHere<ulong>(nameof(TotalTimeSnap)); set => WriteHere(nameof(TotalTimeSnap), value); }

        public PopThermalTelemetryTracker(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopThermalTelemetryTracker>();
        }
    }
}