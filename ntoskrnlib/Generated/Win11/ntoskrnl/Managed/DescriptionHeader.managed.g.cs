using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DESCRIPTION_HEADER")]
    public sealed class DescriptionHeader : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(8UL)]
        public byte Revision { get => ReadHere<byte>(nameof(Revision)); set => WriteHere(nameof(Revision), value); }

        [Offset(9UL)]
        public byte Checksum { get => ReadHere<byte>(nameof(Checksum)); set => WriteHere(nameof(Checksum), value); }

        [Offset(10UL)]
        [Length(6)]
        public DynamicArray OEMID { get => ReadStructure<DynamicArray>(nameof(OEMID)); set => WriteStructure(nameof(OEMID), value); }

        [Offset(16UL)]
        [Length(8)]
        public DynamicArray OEMTableID { get => ReadStructure<DynamicArray>(nameof(OEMTableID)); set => WriteStructure(nameof(OEMTableID), value); }

        [Offset(24UL)]
        public uint OEMRevision { get => ReadHere<uint>(nameof(OEMRevision)); set => WriteHere(nameof(OEMRevision), value); }

        [Offset(28UL)]
        [Length(4)]
        public DynamicArray CreatorID { get => ReadStructure<DynamicArray>(nameof(CreatorID)); set => WriteStructure(nameof(CreatorID), value); }

        [Offset(32UL)]
        public uint CreatorRev { get => ReadHere<uint>(nameof(CreatorRev)); set => WriteHere(nameof(CreatorRev), value); }

        public DescriptionHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DescriptionHeader>();
        }
    }
}