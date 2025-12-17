using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!wil_details_RecordUsageResult")]
    public sealed class WilDetailsRecordUsageResult : DynamicStructure
    {
        [Offset(0UL)]
        public int queueBackground { get => ReadHere<int>(nameof(queueBackground)); set => WriteHere(nameof(queueBackground), value); }

        [Offset(4UL)]
        public uint countImmediate { get => ReadHere<uint>(nameof(countImmediate)); set => WriteHere(nameof(countImmediate), value); }

        [Offset(8UL)]
        public uint kindImmediate { get => ReadHere<uint>(nameof(kindImmediate)); set => WriteHere(nameof(kindImmediate), value); }

        [Offset(12UL)]
        public uint payloadId { get => ReadHere<uint>(nameof(payloadId)); set => WriteHere(nameof(payloadId), value); }

        [Offset(16UL)]
        public int ignoredUse { get => ReadHere<int>(nameof(ignoredUse)); set => WriteHere(nameof(ignoredUse), value); }

        [Offset(20UL)]
        public int isWexpConfiguration { get => ReadHere<int>(nameof(isWexpConfiguration)); set => WriteHere(nameof(isWexpConfiguration), value); }

        public WilDetailsRecordUsageResult(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WilDetailsRecordUsageResult>();
        }
    }
}