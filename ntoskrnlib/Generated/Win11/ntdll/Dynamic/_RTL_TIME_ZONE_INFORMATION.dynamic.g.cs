using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_TIME_ZONE_INFORMATION")]
    public sealed class _RTL_TIME_ZONE_INFORMATION : DynamicStructure
    {
        public int Bias { get; }
        public short[] StandardName { get; }
        public _TIME_FIELDS StandardStart { get; }
        public int StandardBias { get; }
        public short[] DaylightName { get; }
        public _TIME_FIELDS DaylightStart { get; }
        public int DaylightBias { get; }

        public _RTL_TIME_ZONE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_TIME_ZONE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_TIME_ZONE_INFORMATION.Bias),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_TIME_ZONE_INFORMATION.StandardName),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_TIME_ZONE_INFORMATION.StandardStart),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_RTL_TIME_ZONE_INFORMATION.StandardBias),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_RTL_TIME_ZONE_INFORMATION.DaylightName),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_RTL_TIME_ZONE_INFORMATION.DaylightStart),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_RTL_TIME_ZONE_INFORMATION.DaylightBias),
                    new ulong[]
                    {
                        168UL
                    }
                }
            };
            Register<_RTL_TIME_ZONE_INFORMATION>((mem, ptr) => new _RTL_TIME_ZONE_INFORMATION(mem, ptr), offsets);
        }
    }
}