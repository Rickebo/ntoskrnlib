using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SYSTEM_POWER_POLICY")]
    public sealed class _SYSTEM_POWER_POLICY : DynamicStructure
    {
        public uint Revision { get; }
        public POWER_ACTION_POLICY PowerButton { get; }
        public POWER_ACTION_POLICY SleepButton { get; }
        public POWER_ACTION_POLICY LidClose { get; }
        public uint LidOpenWake { get; }
        public uint Reserved { get; }
        public POWER_ACTION_POLICY Idle { get; }
        public uint IdleTimeout { get; }
        public byte IdleSensitivity { get; }
        public byte DynamicThrottle { get; }
        public byte[] Spare2 { get; }
        public uint MinSleep { get; }
        public uint MaxSleep { get; }
        public uint ReducedLatencySleep { get; }
        public uint WinLogonFlags { get; }
        public uint Spare3 { get; }
        public uint DozeS4Timeout { get; }
        public uint BroadcastCapacityResolution { get; }
        public byte[] DischargePolicy { get; }
        public uint VideoTimeout { get; }
        public byte VideoDimDisplay { get; }
        public uint[] VideoReserved { get; }
        public uint SpindownTimeout { get; }
        public byte OptimizeForPower { get; }
        public byte FanThrottleTolerance { get; }
        public byte ForcedThrottle { get; }
        public byte MinThrottle { get; }
        public POWER_ACTION_POLICY OverThrottled { get; }

        public _SYSTEM_POWER_POLICY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SYSTEM_POWER_POLICY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SYSTEM_POWER_POLICY.Revision),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.PowerButton),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.SleepButton),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.LidClose),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.LidOpenWake),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.Reserved),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.Idle),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.IdleTimeout),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.IdleSensitivity),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.DynamicThrottle),
                    new ulong[]
                    {
                        65UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.Spare2),
                    new ulong[]
                    {
                        66UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.MinSleep),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.MaxSleep),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.ReducedLatencySleep),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.WinLogonFlags),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.Spare3),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.DozeS4Timeout),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.BroadcastCapacityResolution),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.DischargePolicy),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.VideoTimeout),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.VideoDimDisplay),
                    new ulong[]
                    {
                        196UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.VideoReserved),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.SpindownTimeout),
                    new ulong[]
                    {
                        212UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.OptimizeForPower),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.FanThrottleTolerance),
                    new ulong[]
                    {
                        217UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.ForcedThrottle),
                    new ulong[]
                    {
                        218UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.MinThrottle),
                    new ulong[]
                    {
                        219UL
                    }
                },
                {
                    nameof(_SYSTEM_POWER_POLICY.OverThrottled),
                    new ulong[]
                    {
                        220UL
                    }
                }
            };
            Register<_SYSTEM_POWER_POLICY>((mem, ptr) => new _SYSTEM_POWER_POLICY(mem, ptr), offsets);
        }
    }
}