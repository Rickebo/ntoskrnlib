using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_FEATURE_USAGE_DATA")]
    public sealed class _RTL_FEATURE_USAGE_DATA : DynamicStructure
    {
        public uint FeatureId { get; }
        public ushort ReportingKind { get; }
        public ushort UsageCount { get; }

        public _RTL_FEATURE_USAGE_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_FEATURE_USAGE_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_FEATURE_USAGE_DATA.FeatureId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_FEATURE_USAGE_DATA.ReportingKind),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_FEATURE_USAGE_DATA.UsageCount),
                    new ulong[]
                    {
                        6UL
                    }
                }
            };
            Register<_RTL_FEATURE_USAGE_DATA>((mem, ptr) => new _RTL_FEATURE_USAGE_DATA(mem, ptr), offsets);
        }
    }
}