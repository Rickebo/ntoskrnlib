using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOADER_FEATURE_CONFIGURATION_INFORMATION")]
    public sealed class LoaderFeatureConfigurationInformation : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr FeatureConfigurationBuffer { get => ReadHere<IntPtr>(nameof(FeatureConfigurationBuffer)); set => WriteHere(nameof(FeatureConfigurationBuffer), value); }

        [Offset(8UL)]
        public ulong FeatureConfigurationBufferSize { get => ReadHere<ulong>(nameof(FeatureConfigurationBufferSize)); set => WriteHere(nameof(FeatureConfigurationBufferSize), value); }

        [Offset(16UL)]
        public IntPtr UsageSubscriptionBuffer { get => ReadHere<IntPtr>(nameof(UsageSubscriptionBuffer)); set => WriteHere(nameof(UsageSubscriptionBuffer), value); }

        [Offset(24UL)]
        public ulong UsageSubscriptionBufferSize { get => ReadHere<ulong>(nameof(UsageSubscriptionBufferSize)); set => WriteHere(nameof(UsageSubscriptionBufferSize), value); }

        [Offset(32UL)]
        public IntPtr DelayedUsageReportBuffer { get => ReadHere<IntPtr>(nameof(DelayedUsageReportBuffer)); set => WriteHere(nameof(DelayedUsageReportBuffer), value); }

        [Offset(40UL)]
        public ulong DelayedUsageReportBufferSize { get => ReadHere<ulong>(nameof(DelayedUsageReportBufferSize)); set => WriteHere(nameof(DelayedUsageReportBufferSize), value); }

        [Offset(48UL)]
        public LoaderFeatureConfigurationDiagnosticInformation DiagnosticInformation { get => ReadStructure<LoaderFeatureConfigurationDiagnosticInformation>(nameof(DiagnosticInformation)); set => WriteStructure(nameof(DiagnosticInformation), value); }

        public LoaderFeatureConfigurationInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoaderFeatureConfigurationInformation>();
        }
    }
}