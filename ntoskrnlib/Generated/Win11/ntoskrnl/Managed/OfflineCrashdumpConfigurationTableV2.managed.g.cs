using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2")]
    public sealed class OfflineCrashdumpConfigurationTableV2 : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public uint AbnormalResetOccurred { get => ReadHere<uint>(nameof(AbnormalResetOccurred)); set => WriteHere(nameof(AbnormalResetOccurred), value); }

        [Offset(8UL)]
        public uint OfflineMemoryDumpCapable { get => ReadHere<uint>(nameof(OfflineMemoryDumpCapable)); set => WriteHere(nameof(OfflineMemoryDumpCapable), value); }

        [Offset(16UL)]
        public LargeInteger ResetDataAddress { get => ReadStructure<LargeInteger>(nameof(ResetDataAddress)); set => WriteStructure(nameof(ResetDataAddress), value); }

        [Offset(24UL)]
        public uint ResetDataSize { get => ReadHere<uint>(nameof(ResetDataSize)); set => WriteHere(nameof(ResetDataSize), value); }

        public OfflineCrashdumpConfigurationTableV2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<OfflineCrashdumpConfigurationTableV2>();
        }
    }
}