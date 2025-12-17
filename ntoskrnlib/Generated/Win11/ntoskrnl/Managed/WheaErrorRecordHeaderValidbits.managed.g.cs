using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_ERROR_RECORD_HEADER_VALIDBITS")]
    public sealed class WheaErrorRecordHeaderValidbits : DynamicStructure
    {
        [Offset(0UL)]
        public uint PlatformId { get => ReadHere<uint>(nameof(PlatformId)); set => WriteHere(nameof(PlatformId), value); }

        [Offset(0UL)]
        public uint Timestamp { get => ReadHere<uint>(nameof(Timestamp)); set => WriteHere(nameof(Timestamp), value); }

        [Offset(0UL)]
        public uint PartitionId { get => ReadHere<uint>(nameof(PartitionId)); set => WriteHere(nameof(PartitionId), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public uint AsULONG { get => ReadHere<uint>(nameof(AsULONG)); set => WriteHere(nameof(AsULONG), value); }

        public WheaErrorRecordHeaderValidbits(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaErrorRecordHeaderValidbits>();
        }
    }
}