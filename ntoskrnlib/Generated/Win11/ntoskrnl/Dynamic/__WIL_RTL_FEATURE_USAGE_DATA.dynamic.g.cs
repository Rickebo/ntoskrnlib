using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!__WIL_RTL_FEATURE_USAGE_DATA")]
    public sealed class __WIL_RTL_FEATURE_USAGE_DATA : DynamicStructure
    {
        public uint FeatureId { get; }
        public ushort ReportingKind { get; }
        public ushort UsageCount { get; }

        public __WIL_RTL_FEATURE_USAGE_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static __WIL_RTL_FEATURE_USAGE_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(__WIL_RTL_FEATURE_USAGE_DATA.FeatureId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__WIL_RTL_FEATURE_USAGE_DATA.ReportingKind),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(__WIL_RTL_FEATURE_USAGE_DATA.UsageCount),
                    new ulong[]
                    {
                        6UL
                    }
                }
            };
            Register<__WIL_RTL_FEATURE_USAGE_DATA>((mem, ptr) => new __WIL_RTL_FEATURE_USAGE_DATA(mem, ptr), offsets);
        }
    }
}