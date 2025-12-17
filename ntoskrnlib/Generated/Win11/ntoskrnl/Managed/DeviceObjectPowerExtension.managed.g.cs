using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_OBJECT_POWER_EXTENSION")]
    public sealed class DeviceObjectPowerExtension : DynamicStructure
    {
        [Offset(0UL)]
        public uint IdleCount { get => ReadHere<uint>(nameof(IdleCount)); set => WriteHere(nameof(IdleCount), value); }

        [Offset(4UL)]
        public uint BusyCount { get => ReadHere<uint>(nameof(BusyCount)); set => WriteHere(nameof(BusyCount), value); }

        [Offset(8UL)]
        public uint BusyReference { get => ReadHere<uint>(nameof(BusyReference)); set => WriteHere(nameof(BusyReference), value); }

        [Offset(12UL)]
        public uint TotalBusyCount { get => ReadHere<uint>(nameof(TotalBusyCount)); set => WriteHere(nameof(TotalBusyCount), value); }

        [Offset(16UL)]
        public uint ConservationIdleTime { get => ReadHere<uint>(nameof(ConservationIdleTime)); set => WriteHere(nameof(ConservationIdleTime), value); }

        [Offset(20UL)]
        public uint PerformanceIdleTime { get => ReadHere<uint>(nameof(PerformanceIdleTime)); set => WriteHere(nameof(PerformanceIdleTime), value); }

        [Offset(24UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(32UL)]
        public ListEntry IdleList { get => ReadStructure<ListEntry>(nameof(IdleList)); set => WriteStructure(nameof(IdleList), value); }

        [Offset(48UL)]
        public uint IdleType { get => ReadHere<uint>(nameof(IdleType)); set => WriteHere(nameof(IdleType), value); }

        [Offset(52UL)]
        public uint IdleState { get => ReadHere<uint>(nameof(IdleState)); set => WriteHere(nameof(IdleState), value); }

        [Offset(56UL)]
        public uint CurrentState { get => ReadHere<uint>(nameof(CurrentState)); set => WriteHere(nameof(CurrentState), value); }

        [Offset(64UL)]
        public IntPtr CoolingExtension { get => ReadHere<IntPtr>(nameof(CoolingExtension)); set => WriteHere(nameof(CoolingExtension), value); }

        [Offset(72UL)]
        public IntPtr PowerLimitExtension { get => ReadHere<IntPtr>(nameof(PowerLimitExtension)); set => WriteHere(nameof(PowerLimitExtension), value); }

        [Offset(80UL)]
        public ListEntry Volume { get => ReadStructure<ListEntry>(nameof(Volume)); set => WriteStructure(nameof(Volume), value); }

        [Offset(96UL)]
        public UnnamedTag Specific { get => ReadStructure<UnnamedTag>(nameof(Specific)); set => WriteStructure(nameof(Specific), value); }

        public DeviceObjectPowerExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceObjectPowerExtension>();
        }
    }
}