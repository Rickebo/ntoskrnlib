using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_EVENT_LOG_ENTRY_HEADER")]
    public sealed class WheaEventLogEntryHeader : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(12UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(16UL)]
        public uint OwnerTag { get => ReadHere<uint>(nameof(OwnerTag)); set => WriteHere(nameof(OwnerTag), value); }

        [Offset(20UL)]
        public uint Id { get => ReadHere<uint>(nameof(Id)); set => WriteHere(nameof(Id), value); }

        [Offset(24UL)]
        public WheaEventLogEntryFlags Flags { get => ReadStructure<WheaEventLogEntryFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(28UL)]
        public uint PayloadLength { get => ReadHere<uint>(nameof(PayloadLength)); set => WriteHere(nameof(PayloadLength), value); }

        public WheaEventLogEntryHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaEventLogEntryHeader>();
        }
    }
}