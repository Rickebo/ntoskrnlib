using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION")]
    public sealed class LoaderFeatureConfigurationDiagnosticInformation : DynamicStructure
    {
        [Offset(0UL)]
        public byte OriginalBootStatus { get => ReadHere<byte>(nameof(OriginalBootStatus)); set => WriteHere(nameof(OriginalBootStatus), value); }

        [Offset(1UL)]
        public byte NewBootStatus { get => ReadHere<byte>(nameof(NewBootStatus)); set => WriteHere(nameof(NewBootStatus), value); }

        [Offset(2UL)]
        public byte ConfigurationLoaded { get => ReadHere<byte>(nameof(ConfigurationLoaded)); set => WriteHere(nameof(ConfigurationLoaded), value); }

        [Offset(3UL)]
        public byte Spare { get => ReadHere<byte>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(4UL)]
        public UnnamedTag Flags { get => ReadStructure<UnnamedTag>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(8UL)]
        public int ConfigurationComparisonStatus { get => ReadHere<int>(nameof(ConfigurationComparisonStatus)); set => WriteHere(nameof(ConfigurationComparisonStatus), value); }

        [Offset(12UL)]
        public int CurrentConfigurationLoadStatus { get => ReadHere<int>(nameof(CurrentConfigurationLoadStatus)); set => WriteHere(nameof(CurrentConfigurationLoadStatus), value); }

        [Offset(16UL)]
        public int LkgConfigurationLoadStatus { get => ReadHere<int>(nameof(LkgConfigurationLoadStatus)); set => WriteHere(nameof(LkgConfigurationLoadStatus), value); }

        [Offset(20UL)]
        public int UsageSubscriptionLoadStatus { get => ReadHere<int>(nameof(UsageSubscriptionLoadStatus)); set => WriteHere(nameof(UsageSubscriptionLoadStatus), value); }

        public LoaderFeatureConfigurationDiagnosticInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoaderFeatureConfigurationDiagnosticInformation>();
        }
    }
}