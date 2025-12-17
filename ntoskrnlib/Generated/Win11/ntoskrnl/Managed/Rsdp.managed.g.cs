using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RSDP")]
    public sealed class Rsdp : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Signature { get => ReadHere<ulong>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(8UL)]
        public byte Checksum { get => ReadHere<byte>(nameof(Checksum)); set => WriteHere(nameof(Checksum), value); }

        [Offset(9UL)]
        [Length(6)]
        public DynamicArray OEMID { get => ReadStructure<DynamicArray>(nameof(OEMID)); set => WriteStructure(nameof(OEMID), value); }

        [Offset(15UL)]
        public byte Revision { get => ReadHere<byte>(nameof(Revision)); set => WriteHere(nameof(Revision), value); }

        [Offset(16UL)]
        public uint RsdtAddress { get => ReadHere<uint>(nameof(RsdtAddress)); set => WriteHere(nameof(RsdtAddress), value); }

        [Offset(20UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(24UL)]
        public LargeInteger XsdtAddress { get => ReadStructure<LargeInteger>(nameof(XsdtAddress)); set => WriteStructure(nameof(XsdtAddress), value); }

        [Offset(32UL)]
        public byte XChecksum { get => ReadHere<byte>(nameof(XChecksum)); set => WriteHere(nameof(XChecksum), value); }

        [Offset(33UL)]
        [Length(3)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        public Rsdp(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Rsdp>();
        }
    }
}