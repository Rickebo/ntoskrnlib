using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SYSTEM_POWER_POLICY")]
    public sealed class SystemPowerPolicy : DynamicStructure
    {
        [Offset(0UL)]
        public uint Revision { get => ReadHere<uint>(nameof(Revision)); set => WriteHere(nameof(Revision), value); }

        [Offset(4UL)]
        public PowerActionPolicy PowerButton { get => ReadStructure<PowerActionPolicy>(nameof(PowerButton)); set => WriteStructure(nameof(PowerButton), value); }

        [Offset(16UL)]
        public PowerActionPolicy SleepButton { get => ReadStructure<PowerActionPolicy>(nameof(SleepButton)); set => WriteStructure(nameof(SleepButton), value); }

        [Offset(28UL)]
        public PowerActionPolicy LidClose { get => ReadStructure<PowerActionPolicy>(nameof(LidClose)); set => WriteStructure(nameof(LidClose), value); }

        [Offset(40UL)]
        public uint LidOpenWake { get => ReadHere<uint>(nameof(LidOpenWake)); set => WriteHere(nameof(LidOpenWake), value); }

        [Offset(44UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(48UL)]
        public PowerActionPolicy Idle { get => ReadStructure<PowerActionPolicy>(nameof(Idle)); set => WriteStructure(nameof(Idle), value); }

        [Offset(60UL)]
        public uint IdleTimeout { get => ReadHere<uint>(nameof(IdleTimeout)); set => WriteHere(nameof(IdleTimeout), value); }

        [Offset(64UL)]
        public byte IdleSensitivity { get => ReadHere<byte>(nameof(IdleSensitivity)); set => WriteHere(nameof(IdleSensitivity), value); }

        [Offset(65UL)]
        public byte DynamicThrottle { get => ReadHere<byte>(nameof(DynamicThrottle)); set => WriteHere(nameof(DynamicThrottle), value); }

        [Offset(66UL)]
        [Length(2)]
        public DynamicArray Spare2 { get => ReadStructure<DynamicArray>(nameof(Spare2)); set => WriteStructure(nameof(Spare2), value); }

        [Offset(68UL)]
        public uint MinSleep { get => ReadHere<uint>(nameof(MinSleep)); set => WriteHere(nameof(MinSleep), value); }

        [Offset(72UL)]
        public uint MaxSleep { get => ReadHere<uint>(nameof(MaxSleep)); set => WriteHere(nameof(MaxSleep), value); }

        [Offset(76UL)]
        public uint ReducedLatencySleep { get => ReadHere<uint>(nameof(ReducedLatencySleep)); set => WriteHere(nameof(ReducedLatencySleep), value); }

        [Offset(80UL)]
        public uint WinLogonFlags { get => ReadHere<uint>(nameof(WinLogonFlags)); set => WriteHere(nameof(WinLogonFlags), value); }

        [Offset(84UL)]
        public uint Spare3 { get => ReadHere<uint>(nameof(Spare3)); set => WriteHere(nameof(Spare3), value); }

        [Offset(88UL)]
        public uint DozeS4Timeout { get => ReadHere<uint>(nameof(DozeS4Timeout)); set => WriteHere(nameof(DozeS4Timeout), value); }

        [Offset(92UL)]
        public uint BroadcastCapacityResolution { get => ReadHere<uint>(nameof(BroadcastCapacityResolution)); set => WriteHere(nameof(BroadcastCapacityResolution), value); }

        [Offset(96UL)]
        [Length(4)]
        public DynamicArray DischargePolicy { get => ReadStructure<DynamicArray>(nameof(DischargePolicy)); set => WriteStructure(nameof(DischargePolicy), value); }

        [Offset(192UL)]
        public uint VideoTimeout { get => ReadHere<uint>(nameof(VideoTimeout)); set => WriteHere(nameof(VideoTimeout), value); }

        [Offset(196UL)]
        public byte VideoDimDisplay { get => ReadHere<byte>(nameof(VideoDimDisplay)); set => WriteHere(nameof(VideoDimDisplay), value); }

        [Offset(200UL)]
        [Length(3)]
        public DynamicArray VideoReserved { get => ReadStructure<DynamicArray>(nameof(VideoReserved)); set => WriteStructure(nameof(VideoReserved), value); }

        [Offset(212UL)]
        public uint SpindownTimeout { get => ReadHere<uint>(nameof(SpindownTimeout)); set => WriteHere(nameof(SpindownTimeout), value); }

        [Offset(216UL)]
        public byte OptimizeForPower { get => ReadHere<byte>(nameof(OptimizeForPower)); set => WriteHere(nameof(OptimizeForPower), value); }

        [Offset(217UL)]
        public byte FanThrottleTolerance { get => ReadHere<byte>(nameof(FanThrottleTolerance)); set => WriteHere(nameof(FanThrottleTolerance), value); }

        [Offset(218UL)]
        public byte ForcedThrottle { get => ReadHere<byte>(nameof(ForcedThrottle)); set => WriteHere(nameof(ForcedThrottle), value); }

        [Offset(219UL)]
        public byte MinThrottle { get => ReadHere<byte>(nameof(MinThrottle)); set => WriteHere(nameof(MinThrottle), value); }

        [Offset(220UL)]
        public PowerActionPolicy OverThrottled { get => ReadStructure<PowerActionPolicy>(nameof(OverThrottled)); set => WriteStructure(nameof(OverThrottled), value); }

        public SystemPowerPolicy(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SystemPowerPolicy>();
        }
    }
}