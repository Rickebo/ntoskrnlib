#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 328)]
    public partial struct _POP_POWER_SETTING_VALUES
    {
        [FieldOffset(0)]
        public uint StructureSize;
        [FieldOffset(4)]
        public _SYSTEM_POWER_POLICY PopPolicy;
        [FieldOffset(236)]
        public uint CurrentAcDcPowerState;
        [FieldOffset(240)]
        public byte AwayModeEnabled;
        [FieldOffset(241)]
        public byte AwayModeEngaged;
        [FieldOffset(242)]
        public byte AwayModePolicyAllowed;
        [FieldOffset(244)]
        public int AwayModeIgnoreUserPresent;
        [FieldOffset(248)]
        public int AwayModeIgnoreAction;
        [FieldOffset(252)]
        public byte DisableFastS4;
        [FieldOffset(253)]
        public byte DisableStandbyStates;
        [FieldOffset(256)]
        public uint UnattendSleepTimeout;
        [FieldOffset(260)]
        public uint DiskIgnoreTime;
        [FieldOffset(264)]
        public uint DeviceIdlePolicy;
        [FieldOffset(268)]
        public uint VideoDimTimeout;
        [FieldOffset(272)]
        public uint VideoNormalBrightness;
        [FieldOffset(276)]
        public uint VideoDimBrightness;
        [FieldOffset(280)]
        public uint AlsOffset;
        [FieldOffset(284)]
        public uint AlsEnabled;
        [FieldOffset(288)]
        public uint EsBrightness;
        [FieldOffset(292)]
        public byte SwitchShutdownForced;
        [FieldOffset(296)]
        public uint SystemCoolingPolicy;
        [FieldOffset(300)]
        public byte MediaBufferingEngaged;
        [FieldOffset(301)]
        public byte AudioActivity;
        [FieldOffset(302)]
        public byte FullscreenVideoPlayback;
        [FieldOffset(304)]
        public uint EsBatteryThreshold;
        [FieldOffset(308)]
        public byte EsAggressive;
        [FieldOffset(309)]
        public byte EsUserAwaySetting;
        [FieldOffset(312)]
        public uint ConnectivityInStandby;
        [FieldOffset(316)]
        public uint DisconnectedStandbyMode;
        [FieldOffset(320)]
        public uint UserPresencePredictionEnabled;
        [FieldOffset(324)]
        public byte AirplaneModeEnabled;
        [FieldOffset(325)]
        public byte BluetoothDeviceCharging;
    }
}