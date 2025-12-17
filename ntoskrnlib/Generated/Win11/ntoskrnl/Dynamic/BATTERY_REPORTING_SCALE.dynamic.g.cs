using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!BATTERY_REPORTING_SCALE")]
    public sealed class BATTERY_REPORTING_SCALE : DynamicStructure
    {
        public uint Granularity { get; }
        public uint Capacity { get; }

        public BATTERY_REPORTING_SCALE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static BATTERY_REPORTING_SCALE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(BATTERY_REPORTING_SCALE.Granularity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(BATTERY_REPORTING_SCALE.Capacity),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<BATTERY_REPORTING_SCALE>((mem, ptr) => new BATTERY_REPORTING_SCALE(mem, ptr), offsets);
        }
    }
}