using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_DYNAMIC_TIME_ZONE_INFORMATION")]
    public sealed class _RTL_DYNAMIC_TIME_ZONE_INFORMATION : DynamicStructure
    {
        public _RTL_TIME_ZONE_INFORMATION tzi { get; }
        public short[] TimeZoneKeyName { get; }
        public byte DynamicDaylightTimeDisabled { get; }

        public _RTL_DYNAMIC_TIME_ZONE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_DYNAMIC_TIME_ZONE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_DYNAMIC_TIME_ZONE_INFORMATION.tzi),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_TIME_ZONE_INFORMATION.TimeZoneKeyName),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_TIME_ZONE_INFORMATION.DynamicDaylightTimeDisabled),
                    new ulong[]
                    {
                        428UL
                    }
                }
            };
            Register<_RTL_DYNAMIC_TIME_ZONE_INFORMATION>((mem, ptr) => new _RTL_DYNAMIC_TIME_ZONE_INFORMATION(mem, ptr), offsets);
        }
    }
}