using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_POWER_SETTING_VALUES")]
    public sealed class PopPowerSettingValues : DynamicStructure
    {
        [Offset(0UL)]
        public uint StructureSize { get => ReadHere<uint>(nameof(StructureSize)); set => WriteHere(nameof(StructureSize), value); }

        [Offset(4UL)]
        public SystemPowerPolicy PopPolicy { get => ReadStructure<SystemPowerPolicy>(nameof(PopPolicy)); set => WriteStructure(nameof(PopPolicy), value); }

        [Offset(236UL)]
        public uint CurrentAcDcPowerState { get => ReadHere<uint>(nameof(CurrentAcDcPowerState)); set => WriteHere(nameof(CurrentAcDcPowerState), value); }

        [Offset(240UL)]
        public byte AwayModeEnabled { get => ReadHere<byte>(nameof(AwayModeEnabled)); set => WriteHere(nameof(AwayModeEnabled), value); }

        [Offset(241UL)]
        public byte AwayModeEngaged { get => ReadHere<byte>(nameof(AwayModeEngaged)); set => WriteHere(nameof(AwayModeEngaged), value); }

        [Offset(242UL)]
        public byte AwayModePolicyAllowed { get => ReadHere<byte>(nameof(AwayModePolicyAllowed)); set => WriteHere(nameof(AwayModePolicyAllowed), value); }

        [Offset(244UL)]
        public int AwayModeIgnoreUserPresent { get => ReadHere<int>(nameof(AwayModeIgnoreUserPresent)); set => WriteHere(nameof(AwayModeIgnoreUserPresent), value); }

        [Offset(248UL)]
        public int AwayModeIgnoreAction { get => ReadHere<int>(nameof(AwayModeIgnoreAction)); set => WriteHere(nameof(AwayModeIgnoreAction), value); }

        [Offset(252UL)]
        public byte DisableFastS4 { get => ReadHere<byte>(nameof(DisableFastS4)); set => WriteHere(nameof(DisableFastS4), value); }

        [Offset(253UL)]
        public byte DisableStandbyStates { get => ReadHere<byte>(nameof(DisableStandbyStates)); set => WriteHere(nameof(DisableStandbyStates), value); }

        [Offset(256UL)]
        public uint UnattendSleepTimeout { get => ReadHere<uint>(nameof(UnattendSleepTimeout)); set => WriteHere(nameof(UnattendSleepTimeout), value); }

        [Offset(260UL)]
        public uint DiskIgnoreTime { get => ReadHere<uint>(nameof(DiskIgnoreTime)); set => WriteHere(nameof(DiskIgnoreTime), value); }

        [Offset(264UL)]
        public uint DeviceIdlePolicy { get => ReadHere<uint>(nameof(DeviceIdlePolicy)); set => WriteHere(nameof(DeviceIdlePolicy), value); }

        [Offset(268UL)]
        public uint VideoDimTimeout { get => ReadHere<uint>(nameof(VideoDimTimeout)); set => WriteHere(nameof(VideoDimTimeout), value); }

        [Offset(272UL)]
        public uint VideoNormalBrightness { get => ReadHere<uint>(nameof(VideoNormalBrightness)); set => WriteHere(nameof(VideoNormalBrightness), value); }

        [Offset(276UL)]
        public uint VideoDimBrightness { get => ReadHere<uint>(nameof(VideoDimBrightness)); set => WriteHere(nameof(VideoDimBrightness), value); }

        [Offset(280UL)]
        public uint AlsOffset { get => ReadHere<uint>(nameof(AlsOffset)); set => WriteHere(nameof(AlsOffset), value); }

        [Offset(284UL)]
        public uint AlsEnabled { get => ReadHere<uint>(nameof(AlsEnabled)); set => WriteHere(nameof(AlsEnabled), value); }

        [Offset(288UL)]
        public uint EsBrightness { get => ReadHere<uint>(nameof(EsBrightness)); set => WriteHere(nameof(EsBrightness), value); }

        [Offset(292UL)]
        public byte SwitchShutdownForced { get => ReadHere<byte>(nameof(SwitchShutdownForced)); set => WriteHere(nameof(SwitchShutdownForced), value); }

        [Offset(296UL)]
        public uint SystemCoolingPolicy { get => ReadHere<uint>(nameof(SystemCoolingPolicy)); set => WriteHere(nameof(SystemCoolingPolicy), value); }

        [Offset(300UL)]
        public byte MediaBufferingEngaged { get => ReadHere<byte>(nameof(MediaBufferingEngaged)); set => WriteHere(nameof(MediaBufferingEngaged), value); }

        [Offset(301UL)]
        public byte AudioActivity { get => ReadHere<byte>(nameof(AudioActivity)); set => WriteHere(nameof(AudioActivity), value); }

        [Offset(302UL)]
        public byte FullscreenVideoPlayback { get => ReadHere<byte>(nameof(FullscreenVideoPlayback)); set => WriteHere(nameof(FullscreenVideoPlayback), value); }

        [Offset(304UL)]
        public uint EsBatteryThreshold { get => ReadHere<uint>(nameof(EsBatteryThreshold)); set => WriteHere(nameof(EsBatteryThreshold), value); }

        [Offset(308UL)]
        public byte EsAggressive { get => ReadHere<byte>(nameof(EsAggressive)); set => WriteHere(nameof(EsAggressive), value); }

        [Offset(309UL)]
        public byte EsUserAwaySetting { get => ReadHere<byte>(nameof(EsUserAwaySetting)); set => WriteHere(nameof(EsUserAwaySetting), value); }

        [Offset(312UL)]
        public uint ConnectivityInStandby { get => ReadHere<uint>(nameof(ConnectivityInStandby)); set => WriteHere(nameof(ConnectivityInStandby), value); }

        [Offset(316UL)]
        public uint DisconnectedStandbyMode { get => ReadHere<uint>(nameof(DisconnectedStandbyMode)); set => WriteHere(nameof(DisconnectedStandbyMode), value); }

        [Offset(320UL)]
        public uint UserPresencePredictionEnabled { get => ReadHere<uint>(nameof(UserPresencePredictionEnabled)); set => WriteHere(nameof(UserPresencePredictionEnabled), value); }

        [Offset(324UL)]
        public byte AirplaneModeEnabled { get => ReadHere<byte>(nameof(AirplaneModeEnabled)); set => WriteHere(nameof(AirplaneModeEnabled), value); }

        [Offset(325UL)]
        public byte BluetoothDeviceCharging { get => ReadHere<byte>(nameof(BluetoothDeviceCharging)); set => WriteHere(nameof(BluetoothDeviceCharging), value); }

        public PopPowerSettingValues(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopPowerSettingValues>();
        }
    }
}