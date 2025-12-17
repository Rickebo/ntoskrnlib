using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!SYSTEM_POWER_CAPABILITIES")]
    public sealed class SystemPowerCapabilities : DynamicStructure
    {
        [Offset(0UL)]
        public byte PowerButtonPresent { get => ReadHere<byte>(nameof(PowerButtonPresent)); set => WriteHere(nameof(PowerButtonPresent), value); }

        [Offset(1UL)]
        public byte SleepButtonPresent { get => ReadHere<byte>(nameof(SleepButtonPresent)); set => WriteHere(nameof(SleepButtonPresent), value); }

        [Offset(2UL)]
        public byte LidPresent { get => ReadHere<byte>(nameof(LidPresent)); set => WriteHere(nameof(LidPresent), value); }

        [Offset(3UL)]
        public byte SystemS1 { get => ReadHere<byte>(nameof(SystemS1)); set => WriteHere(nameof(SystemS1), value); }

        [Offset(4UL)]
        public byte SystemS2 { get => ReadHere<byte>(nameof(SystemS2)); set => WriteHere(nameof(SystemS2), value); }

        [Offset(5UL)]
        public byte SystemS3 { get => ReadHere<byte>(nameof(SystemS3)); set => WriteHere(nameof(SystemS3), value); }

        [Offset(6UL)]
        public byte SystemS4 { get => ReadHere<byte>(nameof(SystemS4)); set => WriteHere(nameof(SystemS4), value); }

        [Offset(7UL)]
        public byte SystemS5 { get => ReadHere<byte>(nameof(SystemS5)); set => WriteHere(nameof(SystemS5), value); }

        [Offset(8UL)]
        public byte HiberFilePresent { get => ReadHere<byte>(nameof(HiberFilePresent)); set => WriteHere(nameof(HiberFilePresent), value); }

        [Offset(9UL)]
        public byte FullWake { get => ReadHere<byte>(nameof(FullWake)); set => WriteHere(nameof(FullWake), value); }

        [Offset(10UL)]
        public byte VideoDimPresent { get => ReadHere<byte>(nameof(VideoDimPresent)); set => WriteHere(nameof(VideoDimPresent), value); }

        [Offset(11UL)]
        public byte ApmPresent { get => ReadHere<byte>(nameof(ApmPresent)); set => WriteHere(nameof(ApmPresent), value); }

        [Offset(12UL)]
        public byte UpsPresent { get => ReadHere<byte>(nameof(UpsPresent)); set => WriteHere(nameof(UpsPresent), value); }

        [Offset(13UL)]
        public byte ThermalControl { get => ReadHere<byte>(nameof(ThermalControl)); set => WriteHere(nameof(ThermalControl), value); }

        [Offset(14UL)]
        public byte ProcessorThrottle { get => ReadHere<byte>(nameof(ProcessorThrottle)); set => WriteHere(nameof(ProcessorThrottle), value); }

        [Offset(15UL)]
        public byte ProcessorMinThrottle { get => ReadHere<byte>(nameof(ProcessorMinThrottle)); set => WriteHere(nameof(ProcessorMinThrottle), value); }

        [Offset(16UL)]
        public byte ProcessorMaxThrottle { get => ReadHere<byte>(nameof(ProcessorMaxThrottle)); set => WriteHere(nameof(ProcessorMaxThrottle), value); }

        [Offset(17UL)]
        public byte FastSystemS4 { get => ReadHere<byte>(nameof(FastSystemS4)); set => WriteHere(nameof(FastSystemS4), value); }

        [Offset(18UL)]
        public byte Hiberboot { get => ReadHere<byte>(nameof(Hiberboot)); set => WriteHere(nameof(Hiberboot), value); }

        [Offset(19UL)]
        public byte WakeAlarmPresent { get => ReadHere<byte>(nameof(WakeAlarmPresent)); set => WriteHere(nameof(WakeAlarmPresent), value); }

        [Offset(20UL)]
        public byte AoAc { get => ReadHere<byte>(nameof(AoAc)); set => WriteHere(nameof(AoAc), value); }

        [Offset(21UL)]
        public byte DiskSpinDown { get => ReadHere<byte>(nameof(DiskSpinDown)); set => WriteHere(nameof(DiskSpinDown), value); }

        [Offset(22UL)]
        public byte HiberFileType { get => ReadHere<byte>(nameof(HiberFileType)); set => WriteHere(nameof(HiberFileType), value); }

        [Offset(23UL)]
        public byte AoAcConnectivitySupported { get => ReadHere<byte>(nameof(AoAcConnectivitySupported)); set => WriteHere(nameof(AoAcConnectivitySupported), value); }

        [Offset(24UL)]
        [Length(6)]
        public DynamicArray spare3 { get => ReadStructure<DynamicArray>(nameof(spare3)); set => WriteStructure(nameof(spare3), value); }

        [Offset(30UL)]
        public byte SystemBatteriesPresent { get => ReadHere<byte>(nameof(SystemBatteriesPresent)); set => WriteHere(nameof(SystemBatteriesPresent), value); }

        [Offset(31UL)]
        public byte BatteriesAreShortTerm { get => ReadHere<byte>(nameof(BatteriesAreShortTerm)); set => WriteHere(nameof(BatteriesAreShortTerm), value); }

        [Offset(32UL)]
        [Length(3)]
        public DynamicArray BatteryScale { get => ReadStructure<DynamicArray>(nameof(BatteryScale)); set => WriteStructure(nameof(BatteryScale), value); }

        [Offset(56UL)]
        public uint AcOnLineWake { get => ReadHere<uint>(nameof(AcOnLineWake)); set => WriteHere(nameof(AcOnLineWake), value); }

        [Offset(60UL)]
        public uint SoftLidWake { get => ReadHere<uint>(nameof(SoftLidWake)); set => WriteHere(nameof(SoftLidWake), value); }

        [Offset(64UL)]
        public uint RtcWake { get => ReadHere<uint>(nameof(RtcWake)); set => WriteHere(nameof(RtcWake), value); }

        [Offset(68UL)]
        public uint MinDeviceWakeState { get => ReadHere<uint>(nameof(MinDeviceWakeState)); set => WriteHere(nameof(MinDeviceWakeState), value); }

        [Offset(72UL)]
        public uint DefaultLowLatencyWake { get => ReadHere<uint>(nameof(DefaultLowLatencyWake)); set => WriteHere(nameof(DefaultLowLatencyWake), value); }

        public SystemPowerCapabilities(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SystemPowerCapabilities>();
        }
    }
}