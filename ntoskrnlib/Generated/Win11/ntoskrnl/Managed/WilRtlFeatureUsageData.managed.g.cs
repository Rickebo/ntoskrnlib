using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!__WIL_RTL_FEATURE_USAGE_DATA")]
    public sealed class WilRtlFeatureUsageData : DynamicStructure
    {
        [Offset(0UL)]
        public uint FeatureId { get => ReadHere<uint>(nameof(FeatureId)); set => WriteHere(nameof(FeatureId), value); }

        [Offset(4UL)]
        public ushort ReportingKind { get => ReadHere<ushort>(nameof(ReportingKind)); set => WriteHere(nameof(ReportingKind), value); }

        [Offset(6UL)]
        public ushort UsageCount { get => ReadHere<ushort>(nameof(UsageCount)); set => WriteHere(nameof(UsageCount), value); }

        public WilRtlFeatureUsageData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WilRtlFeatureUsageData>();
        }
    }
}