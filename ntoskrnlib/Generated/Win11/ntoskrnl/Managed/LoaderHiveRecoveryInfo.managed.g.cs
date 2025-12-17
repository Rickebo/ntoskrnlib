using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOADER_HIVE_RECOVERY_INFO")]
    public sealed class LoaderHiveRecoveryInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint Recovered { get => ReadHere<uint>(nameof(Recovered)); set => WriteHere(nameof(Recovered), value); }

        [Offset(0UL)]
        public uint LegacyRecovery { get => ReadHere<uint>(nameof(LegacyRecovery)); set => WriteHere(nameof(LegacyRecovery), value); }

        [Offset(0UL)]
        public uint SoftRebootConflict { get => ReadHere<uint>(nameof(SoftRebootConflict)); set => WriteHere(nameof(SoftRebootConflict), value); }

        [Offset(0UL)]
        public uint MostRecentLog { get => ReadHere<uint>(nameof(MostRecentLog)); set => WriteHere(nameof(MostRecentLog), value); }

        [Offset(0UL)]
        public uint LoadedFromSnapshot { get => ReadHere<uint>(nameof(LoadedFromSnapshot)); set => WriteHere(nameof(LoadedFromSnapshot), value); }

        [Offset(4UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(8UL)]
        public uint LogNextSequence { get => ReadHere<uint>(nameof(LogNextSequence)); set => WriteHere(nameof(LogNextSequence), value); }

        [Offset(12UL)]
        public uint LogMinimumSequence { get => ReadHere<uint>(nameof(LogMinimumSequence)); set => WriteHere(nameof(LogMinimumSequence), value); }

        [Offset(16UL)]
        public uint LogCurrentOffset { get => ReadHere<uint>(nameof(LogCurrentOffset)); set => WriteHere(nameof(LogCurrentOffset), value); }

        public LoaderHiveRecoveryInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoaderHiveRecoveryInfo>();
        }
    }
}