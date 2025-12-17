using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!wil_details_FeatureReportingCache")]
    public sealed class wil_details_FeatureReportingCache : DynamicStructure
    {
        public wil_details_ReportedState reported { get; }
        public wil_details_RecordedState recorded { get; }

        public wil_details_FeatureReportingCache(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static wil_details_FeatureReportingCache()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(wil_details_FeatureReportingCache.reported),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureReportingCache.recorded),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<wil_details_FeatureReportingCache>((mem, ptr) => new wil_details_FeatureReportingCache(mem, ptr), offsets);
        }
    }
}