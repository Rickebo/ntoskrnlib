using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_FEATURE_USAGE_DATA")]
    public sealed class RtlFeatureUsageData : DynamicStructure
    {
        [Offset(0UL)]
        public uint FeatureId { get => ReadHere<uint>(nameof(FeatureId)); set => WriteHere(nameof(FeatureId), value); }

        [Offset(4UL)]
        public ushort ReportingKind { get => ReadHere<ushort>(nameof(ReportingKind)); set => WriteHere(nameof(ReportingKind), value); }

        [Offset(6UL)]
        public ushort UsageCount { get => ReadHere<ushort>(nameof(UsageCount)); set => WriteHere(nameof(UsageCount), value); }

        public RtlFeatureUsageData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlFeatureUsageData>();
        }
    }
}