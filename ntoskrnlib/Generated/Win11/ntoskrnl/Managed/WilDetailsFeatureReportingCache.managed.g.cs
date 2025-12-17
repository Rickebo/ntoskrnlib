using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!wil_details_FeatureReportingCache")]
    public sealed class WilDetailsFeatureReportingCache : DynamicStructure
    {
        [Offset(0UL)]
        public WilDetailsReportedState reported { get => ReadStructure<WilDetailsReportedState>(nameof(reported)); set => WriteStructure(nameof(reported), value); }

        [Offset(4UL)]
        public WilDetailsRecordedState recorded { get => ReadStructure<WilDetailsRecordedState>(nameof(recorded)); set => WriteStructure(nameof(recorded), value); }

        public WilDetailsFeatureReportingCache(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WilDetailsFeatureReportingCache>();
        }
    }
}