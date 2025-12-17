using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PCW_PROCESSOR_INFO")]
    public sealed class _PCW_PROCESSOR_INFO : DynamicStructure
    {
        public ulong IdleTime { get; }
        public ulong AvailableTime { get; }
        public ulong UserTime { get; }
        public ulong KernelTime { get; }
        public uint Interrupts { get; }
        public ulong DpcTime { get; }
        public ulong InterruptTime { get; }
        public uint ClockInterrupts { get; }
        public uint DpcCount { get; }
        public uint DpcRate { get; }
        public ulong C1Time { get; }
        public ulong C2Time { get; }
        public ulong C3Time { get; }
        public ulong C1Transitions { get; }
        public ulong C2Transitions { get; }
        public ulong C3Transitions { get; }
        public ulong StallTime { get; }
        public uint ParkingStatus { get; }
        public uint CurrentFrequency { get; }
        public uint PercentMaxFrequency { get; }
        public uint StateFlags { get; }
        public uint NominalThroughput { get; }
        public uint ActiveThroughput { get; }
        public ulong ScaledThroughput { get; }
        public ulong ScaledKernelThroughput { get; }
        public ulong AverageIdleTime { get; }
        public ulong IdleBreakEvents { get; }
        public uint PerformanceLimit { get; }
        public uint PerformanceLimitFlags { get; }
        public ulong ScaledFrequency { get; }

        public _PCW_PROCESSOR_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PCW_PROCESSOR_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PCW_PROCESSOR_INFO.IdleTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.AvailableTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.UserTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.KernelTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.Interrupts),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.DpcTime),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.InterruptTime),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.ClockInterrupts),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.DpcCount),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.DpcRate),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.C1Time),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.C2Time),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.C3Time),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.C1Transitions),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.C2Transitions),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.C3Transitions),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.StallTime),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.ParkingStatus),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.CurrentFrequency),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.PercentMaxFrequency),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.StateFlags),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.NominalThroughput),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.ActiveThroughput),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.ScaledThroughput),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.ScaledKernelThroughput),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.AverageIdleTime),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.IdleBreakEvents),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.PerformanceLimit),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.PerformanceLimitFlags),
                    new ulong[]
                    {
                        188UL
                    }
                },
                {
                    nameof(_PCW_PROCESSOR_INFO.ScaledFrequency),
                    new ulong[]
                    {
                        192UL
                    }
                }
            };
            Register<_PCW_PROCESSOR_INFO>((mem, ptr) => new _PCW_PROCESSOR_INFO(mem, ptr), offsets);
        }
    }
}