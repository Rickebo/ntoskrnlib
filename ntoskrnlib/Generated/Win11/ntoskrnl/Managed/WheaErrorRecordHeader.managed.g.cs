using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_ERROR_RECORD_HEADER")]
    public sealed class WheaErrorRecordHeader : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public WheaRevision Revision { get => ReadStructure<WheaRevision>(nameof(Revision)); set => WriteStructure(nameof(Revision), value); }

        [Offset(6UL)]
        public uint SignatureEnd { get => ReadHere<uint>(nameof(SignatureEnd)); set => WriteHere(nameof(SignatureEnd), value); }

        [Offset(10UL)]
        public ushort SectionCount { get => ReadHere<ushort>(nameof(SectionCount)); set => WriteHere(nameof(SectionCount), value); }

        [Offset(12UL)]
        public uint Severity { get => ReadHere<uint>(nameof(Severity)); set => WriteHere(nameof(Severity), value); }

        [Offset(16UL)]
        public WheaErrorRecordHeaderValidbits ValidBits { get => ReadStructure<WheaErrorRecordHeaderValidbits>(nameof(ValidBits)); set => WriteStructure(nameof(ValidBits), value); }

        [Offset(20UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(24UL)]
        public WheaTimestamp Timestamp { get => ReadStructure<WheaTimestamp>(nameof(Timestamp)); set => WriteStructure(nameof(Timestamp), value); }

        [Offset(32UL)]
        public Guid PlatformId { get => ReadStructure<Guid>(nameof(PlatformId)); set => WriteStructure(nameof(PlatformId), value); }

        [Offset(48UL)]
        public Guid PartitionId { get => ReadStructure<Guid>(nameof(PartitionId)); set => WriteStructure(nameof(PartitionId), value); }

        [Offset(64UL)]
        public Guid CreatorId { get => ReadStructure<Guid>(nameof(CreatorId)); set => WriteStructure(nameof(CreatorId), value); }

        [Offset(80UL)]
        public Guid NotifyType { get => ReadStructure<Guid>(nameof(NotifyType)); set => WriteStructure(nameof(NotifyType), value); }

        [Offset(96UL)]
        public ulong RecordId { get => ReadHere<ulong>(nameof(RecordId)); set => WriteHere(nameof(RecordId), value); }

        [Offset(104UL)]
        public WheaErrorRecordHeaderFlags Flags { get => ReadStructure<WheaErrorRecordHeaderFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(108UL)]
        public WheaPersistenceInfo PersistenceInfo { get => ReadStructure<WheaPersistenceInfo>(nameof(PersistenceInfo)); set => WriteStructure(nameof(PersistenceInfo), value); }

        [Offset(116UL)]
        public uint OsBuildNumber { get => ReadHere<uint>(nameof(OsBuildNumber)); set => WriteHere(nameof(OsBuildNumber), value); }

        [Offset(120UL)]
        [Length(8)]
        public DynamicArray Reserved2 { get => ReadStructure<DynamicArray>(nameof(Reserved2)); set => WriteStructure(nameof(Reserved2), value); }

        [Offset(116UL)]
        [Length(12)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        public WheaErrorRecordHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaErrorRecordHeader>();
        }
    }
}