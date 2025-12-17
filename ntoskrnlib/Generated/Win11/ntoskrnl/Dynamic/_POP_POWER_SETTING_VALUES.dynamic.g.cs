using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_POWER_SETTING_VALUES")]
    public sealed class _POP_POWER_SETTING_VALUES : DynamicStructure
    {
        public uint StructureSize { get; }
        public _SYSTEM_POWER_POLICY PopPolicy { get; }
        public uint CurrentAcDcPowerState { get; }
        public byte AwayModeEnabled { get; }
        public byte AwayModeEngaged { get; }
        public byte AwayModePolicyAllowed { get; }
        public int AwayModeIgnoreUserPresent { get; }
        public int AwayModeIgnoreAction { get; }
        public byte DisableFastS4 { get; }
        public byte DisableStandbyStates { get; }
        public uint UnattendSleepTimeout { get; }
        public uint DiskIgnoreTime { get; }
        public uint DeviceIdlePolicy { get; }
        public uint VideoDimTimeout { get; }
        public uint VideoNormalBrightness { get; }
        public uint VideoDimBrightness { get; }
        public uint AlsOffset { get; }
        public uint AlsEnabled { get; }
        public uint EsBrightness { get; }
        public byte SwitchShutdownForced { get; }
        public uint SystemCoolingPolicy { get; }
        public byte MediaBufferingEngaged { get; }
        public byte AudioActivity { get; }
        public byte FullscreenVideoPlayback { get; }
        public uint EsBatteryThreshold { get; }
        public byte EsAggressive { get; }
        public byte EsUserAwaySetting { get; }
        public uint ConnectivityInStandby { get; }
        public uint DisconnectedStandbyMode { get; }
        public uint UserPresencePredictionEnabled { get; }
        public byte AirplaneModeEnabled { get; }
        public byte BluetoothDeviceCharging { get; }

        public _POP_POWER_SETTING_VALUES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_POWER_SETTING_VALUES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_POWER_SETTING_VALUES.StructureSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.PopPolicy),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.CurrentAcDcPowerState),
                    new ulong[]
                    {
                        236UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.AwayModeEnabled),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.AwayModeEngaged),
                    new ulong[]
                    {
                        241UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.AwayModePolicyAllowed),
                    new ulong[]
                    {
                        242UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.AwayModeIgnoreUserPresent),
                    new ulong[]
                    {
                        244UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.AwayModeIgnoreAction),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.DisableFastS4),
                    new ulong[]
                    {
                        252UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.DisableStandbyStates),
                    new ulong[]
                    {
                        253UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.UnattendSleepTimeout),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.DiskIgnoreTime),
                    new ulong[]
                    {
                        260UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.DeviceIdlePolicy),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.VideoDimTimeout),
                    new ulong[]
                    {
                        268UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.VideoNormalBrightness),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.VideoDimBrightness),
                    new ulong[]
                    {
                        276UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.AlsOffset),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.AlsEnabled),
                    new ulong[]
                    {
                        284UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.EsBrightness),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.SwitchShutdownForced),
                    new ulong[]
                    {
                        292UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.SystemCoolingPolicy),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.MediaBufferingEngaged),
                    new ulong[]
                    {
                        300UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.AudioActivity),
                    new ulong[]
                    {
                        301UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.FullscreenVideoPlayback),
                    new ulong[]
                    {
                        302UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.EsBatteryThreshold),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.EsAggressive),
                    new ulong[]
                    {
                        308UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.EsUserAwaySetting),
                    new ulong[]
                    {
                        309UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.ConnectivityInStandby),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.DisconnectedStandbyMode),
                    new ulong[]
                    {
                        316UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.UserPresencePredictionEnabled),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.AirplaneModeEnabled),
                    new ulong[]
                    {
                        324UL
                    }
                },
                {
                    nameof(_POP_POWER_SETTING_VALUES.BluetoothDeviceCharging),
                    new ulong[]
                    {
                        325UL
                    }
                }
            };
            Register<_POP_POWER_SETTING_VALUES>((mem, ptr) => new _POP_POWER_SETTING_VALUES(mem, ptr), offsets);
        }
    }
}