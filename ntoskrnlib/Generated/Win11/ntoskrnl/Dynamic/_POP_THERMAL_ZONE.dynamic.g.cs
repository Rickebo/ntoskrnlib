using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_THERMAL_ZONE")]
    public sealed class _POP_THERMAL_ZONE : DynamicStructure
    {
        public _POP_POLICY_DEVICE PolicyDevice { get; }
        public _LIST_ENTRY Link { get; }
        public uint DeviceType { get; }
        public IntPtr Notification { get; }
        public _UNICODE_STRING Name { get; }
        public IntPtr Device { get; }
        public IntPtr Irp { get; }
        public byte State { get; }
        public byte Flags { get; }
        public byte Removing { get; }
        public byte Mode { get; }
        public byte PendingMode { get; }
        public byte ActivePoint { get; }
        public byte PendingActivePoint { get; }
        public byte Critical { get; }
        public byte ThermalStandby { get; }
        public byte OverThrottled { get; }
        public int HighPrecisionThrottle { get; }
        public int Throttle { get; }
        public int PendingThrottle { get; }
        public uint ThrottleReasons { get; }
        public ulong LastPassiveTime { get; }
        public uint SampleRate { get; }
        public uint LastTemp { get; }
        public _THERMAL_INFORMATION_EX Info { get; }
        public _THERMAL_POLICY Policy { get; }
        public byte PolicyDriver { get; }
        public ulong PollingRate { get; }
        public ulong LastTemperatureTime { get; }
        public ulong LastActiveStartTime { get; }
        public ulong LastPassiveStartTime { get; }
        public _WORK_QUEUE_ITEM WorkItem { get; }
        public _KTIMER2 ZoneUpdateTimer { get; }
        public _POP_RW_LOCK Lock { get; }
        public _KEVENT ZoneStopped { get; }
        public _KEVENT TemperatureUpdated { get; }
        public uint InstanceId { get; }
        public _POP_THERMAL_TELEMETRY_TRACKER TelemetryTracker { get; }
        public _UNICODE_STRING Description { get; }

        public _POP_THERMAL_ZONE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_THERMAL_ZONE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_THERMAL_ZONE.PolicyDevice),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.DeviceType),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.Notification),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.Name),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.Device),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.Irp),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.State),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.Flags),
                    new ulong[]
                    {
                        65UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.Removing),
                    new ulong[]
                    {
                        66UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.Mode),
                    new ulong[]
                    {
                        67UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.PendingMode),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.ActivePoint),
                    new ulong[]
                    {
                        69UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.PendingActivePoint),
                    new ulong[]
                    {
                        70UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.Critical),
                    new ulong[]
                    {
                        71UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.ThermalStandby),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.OverThrottled),
                    new ulong[]
                    {
                        73UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.HighPrecisionThrottle),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.Throttle),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.PendingThrottle),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.ThrottleReasons),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.LastPassiveTime),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.SampleRate),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.LastTemp),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.Info),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.Policy),
                    new ulong[]
                    {
                        204UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.PolicyDriver),
                    new ulong[]
                    {
                        228UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.PollingRate),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.LastTemperatureTime),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.LastActiveStartTime),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.LastPassiveStartTime),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.WorkItem),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.ZoneUpdateTimer),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.Lock),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.ZoneStopped),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.TemperatureUpdated),
                    new ulong[]
                    {
                        472UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.InstanceId),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.TelemetryTracker),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_POP_THERMAL_ZONE.Description),
                    new ulong[]
                    {
                        1040UL
                    }
                }
            };
            Register<_POP_THERMAL_ZONE>((mem, ptr) => new _POP_THERMAL_ZONE(mem, ptr), offsets);
        }
    }
}