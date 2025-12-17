using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SMBIOS3_TABLE_HEADER")]
    public sealed class SMBIOS3TableHeader : DynamicStructure
    {
        [Offset(0UL)]
        [Length(5)]
        public DynamicArray Signature { get => ReadStructure<DynamicArray>(nameof(Signature)); set => WriteStructure(nameof(Signature), value); }

        [Offset(5UL)]
        public byte Checksum { get => ReadHere<byte>(nameof(Checksum)); set => WriteHere(nameof(Checksum), value); }

        [Offset(6UL)]
        public byte Length { get => ReadHere<byte>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(7UL)]
        public byte MajorVersion { get => ReadHere<byte>(nameof(MajorVersion)); set => WriteHere(nameof(MajorVersion), value); }

        [Offset(8UL)]
        public byte MinorVersion { get => ReadHere<byte>(nameof(MinorVersion)); set => WriteHere(nameof(MinorVersion), value); }

        [Offset(9UL)]
        public byte Docrev { get => ReadHere<byte>(nameof(Docrev)); set => WriteHere(nameof(Docrev), value); }

        [Offset(10UL)]
        public byte EntryPointRevision { get => ReadHere<byte>(nameof(EntryPointRevision)); set => WriteHere(nameof(EntryPointRevision), value); }

        [Offset(11UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(12UL)]
        public uint StructureTableMaximumSize { get => ReadHere<uint>(nameof(StructureTableMaximumSize)); set => WriteHere(nameof(StructureTableMaximumSize), value); }

        [Offset(16UL)]
        public ulong StructureTableAddress { get => ReadHere<ulong>(nameof(StructureTableAddress)); set => WriteHere(nameof(StructureTableAddress), value); }

        public SMBIOS3TableHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SMBIOS3TableHeader>();
        }
    }
}