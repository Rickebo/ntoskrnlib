using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_THERMAL_ZONE")]
    public sealed class PopThermalZone : DynamicStructure
    {
        [Offset(0UL)]
        public PopPolicyDevice PolicyDevice { get => ReadStructure<PopPolicyDevice>(nameof(PolicyDevice)); set => WriteStructure(nameof(PolicyDevice), value); }

        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public uint DeviceType { get => ReadHere<uint>(nameof(DeviceType)); set => WriteHere(nameof(DeviceType), value); }

        [Offset(24UL)]
        public IntPtr Notification { get => ReadHere<IntPtr>(nameof(Notification)); set => WriteHere(nameof(Notification), value); }

        [Offset(32UL)]
        public UnicodeString Name { get => ReadStructure<UnicodeString>(nameof(Name)); set => WriteStructure(nameof(Name), value); }

        [Offset(48UL)]
        public IntPtr Device { get => ReadHere<IntPtr>(nameof(Device)); set => WriteHere(nameof(Device), value); }

        [Offset(56UL)]
        public IntPtr Irp { get => ReadHere<IntPtr>(nameof(Irp)); set => WriteHere(nameof(Irp), value); }

        [Offset(64UL)]
        public byte State { get => ReadHere<byte>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(65UL)]
        public byte Flags { get => ReadHere<byte>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(66UL)]
        public byte Removing { get => ReadHere<byte>(nameof(Removing)); set => WriteHere(nameof(Removing), value); }

        [Offset(67UL)]
        public byte Mode { get => ReadHere<byte>(nameof(Mode)); set => WriteHere(nameof(Mode), value); }

        [Offset(68UL)]
        public byte PendingMode { get => ReadHere<byte>(nameof(PendingMode)); set => WriteHere(nameof(PendingMode), value); }

        [Offset(69UL)]
        public byte ActivePoint { get => ReadHere<byte>(nameof(ActivePoint)); set => WriteHere(nameof(ActivePoint), value); }

        [Offset(70UL)]
        public byte PendingActivePoint { get => ReadHere<byte>(nameof(PendingActivePoint)); set => WriteHere(nameof(PendingActivePoint), value); }

        [Offset(71UL)]
        public byte Critical { get => ReadHere<byte>(nameof(Critical)); set => WriteHere(nameof(Critical), value); }

        [Offset(72UL)]
        public byte ThermalStandby { get => ReadHere<byte>(nameof(ThermalStandby)); set => WriteHere(nameof(ThermalStandby), value); }

        [Offset(73UL)]
        public byte OverThrottled { get => ReadHere<byte>(nameof(OverThrottled)); set => WriteHere(nameof(OverThrottled), value); }

        [Offset(76UL)]
        public int HighPrecisionThrottle { get => ReadHere<int>(nameof(HighPrecisionThrottle)); set => WriteHere(nameof(HighPrecisionThrottle), value); }

        [Offset(80UL)]
        public int Throttle { get => ReadHere<int>(nameof(Throttle)); set => WriteHere(nameof(Throttle), value); }

        [Offset(84UL)]
        public int PendingThrottle { get => ReadHere<int>(nameof(PendingThrottle)); set => WriteHere(nameof(PendingThrottle), value); }

        [Offset(88UL)]
        public uint ThrottleReasons { get => ReadHere<uint>(nameof(ThrottleReasons)); set => WriteHere(nameof(ThrottleReasons), value); }

        [Offset(96UL)]
        public ulong LastPassiveTime { get => ReadHere<ulong>(nameof(LastPassiveTime)); set => WriteHere(nameof(LastPassiveTime), value); }

        [Offset(104UL)]
        public uint SampleRate { get => ReadHere<uint>(nameof(SampleRate)); set => WriteHere(nameof(SampleRate), value); }

        [Offset(108UL)]
        public uint LastTemp { get => ReadHere<uint>(nameof(LastTemp)); set => WriteHere(nameof(LastTemp), value); }

        [Offset(112UL)]
        public ThermalInformationEx Info { get => ReadStructure<ThermalInformationEx>(nameof(Info)); set => WriteStructure(nameof(Info), value); }

        [Offset(204UL)]
        public ThermalPolicy Policy { get => ReadStructure<ThermalPolicy>(nameof(Policy)); set => WriteStructure(nameof(Policy), value); }

        [Offset(228UL)]
        public byte PolicyDriver { get => ReadHere<byte>(nameof(PolicyDriver)); set => WriteHere(nameof(PolicyDriver), value); }

        [Offset(232UL)]
        public ulong PollingRate { get => ReadHere<ulong>(nameof(PollingRate)); set => WriteHere(nameof(PollingRate), value); }

        [Offset(240UL)]
        public ulong LastTemperatureTime { get => ReadHere<ulong>(nameof(LastTemperatureTime)); set => WriteHere(nameof(LastTemperatureTime), value); }

        [Offset(248UL)]
        public ulong LastActiveStartTime { get => ReadHere<ulong>(nameof(LastActiveStartTime)); set => WriteHere(nameof(LastActiveStartTime), value); }

        [Offset(256UL)]
        public ulong LastPassiveStartTime { get => ReadHere<ulong>(nameof(LastPassiveStartTime)); set => WriteHere(nameof(LastPassiveStartTime), value); }

        [Offset(264UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        [Offset(296UL)]
        public KTIMER2 ZoneUpdateTimer { get => ReadStructure<KTIMER2>(nameof(ZoneUpdateTimer)); set => WriteStructure(nameof(ZoneUpdateTimer), value); }

        [Offset(432UL)]
        public PopRwLock Lock { get => ReadStructure<PopRwLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(448UL)]
        public Kevent ZoneStopped { get => ReadStructure<Kevent>(nameof(ZoneStopped)); set => WriteStructure(nameof(ZoneStopped), value); }

        [Offset(472UL)]
        public Kevent TemperatureUpdated { get => ReadStructure<Kevent>(nameof(TemperatureUpdated)); set => WriteStructure(nameof(TemperatureUpdated), value); }

        [Offset(496UL)]
        public uint InstanceId { get => ReadHere<uint>(nameof(InstanceId)); set => WriteHere(nameof(InstanceId), value); }

        [Offset(504UL)]
        public PopThermalTelemetryTracker TelemetryTracker { get => ReadStructure<PopThermalTelemetryTracker>(nameof(TelemetryTracker)); set => WriteStructure(nameof(TelemetryTracker), value); }

        [Offset(1040UL)]
        public UnicodeString Description { get => ReadStructure<UnicodeString>(nameof(Description)); set => WriteStructure(nameof(Description), value); }

        public PopThermalZone(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopThermalZone>();
        }
    }
}