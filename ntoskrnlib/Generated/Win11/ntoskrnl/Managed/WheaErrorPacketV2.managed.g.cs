using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_ERROR_PACKET_V2")]
    public sealed class WheaErrorPacketV2 : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(12UL)]
        public WheaErrorPacketFlags Flags { get => ReadStructure<WheaErrorPacketFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(16UL)]
        public uint ErrorType { get => ReadHere<uint>(nameof(ErrorType)); set => WriteHere(nameof(ErrorType), value); }

        [Offset(20UL)]
        public uint ErrorSeverity { get => ReadHere<uint>(nameof(ErrorSeverity)); set => WriteHere(nameof(ErrorSeverity), value); }

        [Offset(24UL)]
        public uint ErrorSourceId { get => ReadHere<uint>(nameof(ErrorSourceId)); set => WriteHere(nameof(ErrorSourceId), value); }

        [Offset(28UL)]
        public uint ErrorSourceType { get => ReadHere<uint>(nameof(ErrorSourceType)); set => WriteHere(nameof(ErrorSourceType), value); }

        [Offset(32UL)]
        public Guid NotifyType { get => ReadStructure<Guid>(nameof(NotifyType)); set => WriteStructure(nameof(NotifyType), value); }

        [Offset(48UL)]
        public ulong Context { get => ReadHere<ulong>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(56UL)]
        public uint DataFormat { get => ReadHere<uint>(nameof(DataFormat)); set => WriteHere(nameof(DataFormat), value); }

        [Offset(60UL)]
        public uint Reserved1 { get => ReadHere<uint>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(64UL)]
        public uint DataOffset { get => ReadHere<uint>(nameof(DataOffset)); set => WriteHere(nameof(DataOffset), value); }

        [Offset(68UL)]
        public uint DataLength { get => ReadHere<uint>(nameof(DataLength)); set => WriteHere(nameof(DataLength), value); }

        [Offset(72UL)]
        public uint PshedDataOffset { get => ReadHere<uint>(nameof(PshedDataOffset)); set => WriteHere(nameof(PshedDataOffset), value); }

        [Offset(76UL)]
        public uint PshedDataLength { get => ReadHere<uint>(nameof(PshedDataLength)); set => WriteHere(nameof(PshedDataLength), value); }

        public WheaErrorPacketV2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaErrorPacketV2>();
        }
    }
}