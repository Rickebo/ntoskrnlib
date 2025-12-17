using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_POWER_ACTION")]
    public sealed class _POP_POWER_ACTION : DynamicStructure
    {
        public byte Updates { get; }
        public byte State { get; }
        public byte Shutdown { get; }
        public uint Action { get; }
        public uint LightestState { get; }
        public uint Flags { get; }
        public int Status { get; }
        public uint DeviceType { get; }
        public uint DeviceTypeFlags { get; }
        public IntPtr RequestorInformation { get; }
        public byte IrpMinor { get; }
        public byte Waking { get; }
        public uint SystemState { get; }
        public uint NextSystemState { get; }
        public uint EffectiveSystemState { get; }
        public uint CurrentSystemState { get; }
        public IntPtr ShutdownBugCode { get; }
        public IntPtr DevState { get; }
        public IntPtr HiberContext { get; }
        public ulong WakeTime { get; }
        public ulong SleepTime { get; }
        public ulong WakeFirstUnattendedTime { get; }
        public uint WakeAlarmSignaled { get; }
        public byte[] WakeAlarm { get; }
        public byte WakeAlarmPaused { get; }
        public ulong WakeAlarmLastTime { get; }
        public ulong DozeDeferralStartTime { get; }
        public SYSTEM_POWER_CAPABILITIES FilteredCapabilities { get; }
        public ulong WatchdogLock { get; }
        public _KDPC WatchdogDpc { get; }
        public _KTIMER WatchdogTimer { get; }
        public byte WatchdogInitialized { get; }
        public uint WatchdogState { get; }
        public ulong WatchdogStartTime { get; }
        public uint WatchdogTimeout { get; }
        public IntPtr ActionWorkerThread { get; }
        public IntPtr PromoteActionWorkerThread { get; }
        public IntPtr UnlockAfterSleepWorkerThread { get; }

        public _POP_POWER_ACTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_POWER_ACTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_POWER_ACTION.Updates),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.State),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.Shutdown),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.Action),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.LightestState),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.Status),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.DeviceType),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.DeviceTypeFlags),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.RequestorInformation),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.IrpMinor),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.Waking),
                    new ulong[]
                    {
                        41UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.SystemState),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.NextSystemState),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.EffectiveSystemState),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.CurrentSystemState),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.ShutdownBugCode),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.DevState),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.HiberContext),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.WakeTime),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.SleepTime),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.WakeFirstUnattendedTime),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.WakeAlarmSignaled),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.WakeAlarm),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.WakeAlarmPaused),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.WakeAlarmLastTime),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.DozeDeferralStartTime),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.FilteredCapabilities),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.WatchdogLock),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.WatchdogDpc),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.WatchdogTimer),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.WatchdogInitialized),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.WatchdogState),
                    new ulong[]
                    {
                        436UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.WatchdogStartTime),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.WatchdogTimeout),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.ActionWorkerThread),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.PromoteActionWorkerThread),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_POP_POWER_ACTION.UnlockAfterSleepWorkerThread),
                    new ulong[]
                    {
                        472UL
                    }
                }
            };
            Register<_POP_POWER_ACTION>((mem, ptr) => new _POP_POWER_ACTION(mem, ptr), offsets);
        }
    }
}