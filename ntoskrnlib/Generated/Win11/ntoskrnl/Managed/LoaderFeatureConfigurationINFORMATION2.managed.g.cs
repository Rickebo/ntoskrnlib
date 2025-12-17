using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOADER_FEATURE_CONFIGURATION_INFORMATION2")]
    public sealed class LoaderFeatureConfigurationINFORMATION2 : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public IntPtr DelayedFeatureUsageDataBuffer { get => ReadHere<IntPtr>(nameof(DelayedFeatureUsageDataBuffer)); set => WriteHere(nameof(DelayedFeatureUsageDataBuffer), value); }

        [Offset(16UL)]
        public ulong DelayedFeatureUsageDataBufferSize { get => ReadHere<ulong>(nameof(DelayedFeatureUsageDataBufferSize)); set => WriteHere(nameof(DelayedFeatureUsageDataBufferSize), value); }

        [Offset(24UL)]
        public byte ExperimentationClientPresent { get => ReadHere<byte>(nameof(ExperimentationClientPresent)); set => WriteHere(nameof(ExperimentationClientPresent), value); }

        [Offset(32UL)]
        public IntPtr GovernedFeatureInfoTable { get => ReadHere<IntPtr>(nameof(GovernedFeatureInfoTable)); set => WriteHere(nameof(GovernedFeatureInfoTable), value); }

        [Offset(40UL)]
        public ulong GovernedFeatureInfoTableSize { get => ReadHere<ulong>(nameof(GovernedFeatureInfoTableSize)); set => WriteHere(nameof(GovernedFeatureInfoTableSize), value); }

        public LoaderFeatureConfigurationINFORMATION2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoaderFeatureConfigurationINFORMATION2>();
        }
    }
}