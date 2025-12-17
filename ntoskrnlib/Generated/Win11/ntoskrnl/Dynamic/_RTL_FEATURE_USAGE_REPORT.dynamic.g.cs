using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_FEATURE_USAGE_REPORT")]
    public sealed class _RTL_FEATURE_USAGE_REPORT : DynamicStructure
    {
        public uint FeatureId { get; }
        public ushort ReportingKind { get; }
        public ushort ReportingOptions { get; }

        public _RTL_FEATURE_USAGE_REPORT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_FEATURE_USAGE_REPORT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_FEATURE_USAGE_REPORT.FeatureId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_FEATURE_USAGE_REPORT.ReportingKind),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_FEATURE_USAGE_REPORT.ReportingOptions),
                    new ulong[]
                    {
                        6UL
                    }
                }
            };
            Register<_RTL_FEATURE_USAGE_REPORT>((mem, ptr) => new _RTL_FEATURE_USAGE_REPORT(mem, ptr), offsets);
        }
    }
}