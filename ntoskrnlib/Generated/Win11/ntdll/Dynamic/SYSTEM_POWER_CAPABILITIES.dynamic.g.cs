using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!SYSTEM_POWER_CAPABILITIES")]
    public sealed class SYSTEM_POWER_CAPABILITIES : DynamicStructure
    {
        public byte PowerButtonPresent { get; }
        public byte SleepButtonPresent { get; }
        public byte LidPresent { get; }
        public byte SystemS1 { get; }
        public byte SystemS2 { get; }
        public byte SystemS3 { get; }
        public byte SystemS4 { get; }
        public byte SystemS5 { get; }
        public byte HiberFilePresent { get; }
        public byte FullWake { get; }
        public byte VideoDimPresent { get; }
        public byte ApmPresent { get; }
        public byte UpsPresent { get; }
        public byte ThermalControl { get; }
        public byte ProcessorThrottle { get; }
        public byte ProcessorMinThrottle { get; }
        public byte ProcessorMaxThrottle { get; }
        public byte FastSystemS4 { get; }
        public byte Hiberboot { get; }
        public byte WakeAlarmPresent { get; }
        public byte AoAc { get; }
        public byte DiskSpinDown { get; }
        public byte HiberFileType { get; }
        public byte AoAcConnectivitySupported { get; }
        public byte[] spare3 { get; }
        public byte SystemBatteriesPresent { get; }
        public byte BatteriesAreShortTerm { get; }
        public byte[] BatteryScale { get; }
        public uint AcOnLineWake { get; }
        public uint SoftLidWake { get; }
        public uint RtcWake { get; }
        public uint MinDeviceWakeState { get; }
        public uint DefaultLowLatencyWake { get; }

        public SYSTEM_POWER_CAPABILITIES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static SYSTEM_POWER_CAPABILITIES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.PowerButtonPresent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.SleepButtonPresent),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.LidPresent),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.SystemS1),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.SystemS2),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.SystemS3),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.SystemS4),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.SystemS5),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.HiberFilePresent),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.FullWake),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.VideoDimPresent),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.ApmPresent),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.UpsPresent),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.ThermalControl),
                    new ulong[]
                    {
                        13UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.ProcessorThrottle),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.ProcessorMinThrottle),
                    new ulong[]
                    {
                        15UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.ProcessorMaxThrottle),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.FastSystemS4),
                    new ulong[]
                    {
                        17UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.Hiberboot),
                    new ulong[]
                    {
                        18UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.WakeAlarmPresent),
                    new ulong[]
                    {
                        19UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.AoAc),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.DiskSpinDown),
                    new ulong[]
                    {
                        21UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.HiberFileType),
                    new ulong[]
                    {
                        22UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.AoAcConnectivitySupported),
                    new ulong[]
                    {
                        23UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.spare3),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.SystemBatteriesPresent),
                    new ulong[]
                    {
                        30UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.BatteriesAreShortTerm),
                    new ulong[]
                    {
                        31UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.BatteryScale),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.AcOnLineWake),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.SoftLidWake),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.RtcWake),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.MinDeviceWakeState),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_CAPABILITIES.DefaultLowLatencyWake),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<SYSTEM_POWER_CAPABILITIES>((mem, ptr) => new SYSTEM_POWER_CAPABILITIES(mem, ptr), offsets);
        }
    }
}