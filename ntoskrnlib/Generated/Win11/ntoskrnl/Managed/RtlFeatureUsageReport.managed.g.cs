using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_FEATURE_USAGE_REPORT")]
    public sealed class RtlFeatureUsageReport : DynamicStructure
    {
        [Offset(0UL)]
        public uint FeatureId { get => ReadHere<uint>(nameof(FeatureId)); set => WriteHere(nameof(FeatureId), value); }

        [Offset(4UL)]
        public ushort ReportingKind { get => ReadHere<ushort>(nameof(ReportingKind)); set => WriteHere(nameof(ReportingKind), value); }

        [Offset(6UL)]
        public ushort ReportingOptions { get => ReadHere<ushort>(nameof(ReportingOptions)); set => WriteHere(nameof(ReportingOptions), value); }

        public RtlFeatureUsageReport(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlFeatureUsageReport>();
        }
    }
}