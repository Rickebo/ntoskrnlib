using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IMAGE_SECTION_HEADER")]
    public sealed class ImageSectionHeader : DynamicStructure
    {
        [Offset(0UL)]
        [Length(8)]
        public DynamicArray Name { get => ReadStructure<DynamicArray>(nameof(Name)); set => WriteStructure(nameof(Name), value); }

        [Offset(8UL)]
        public UnnamedTag Misc { get => ReadStructure<UnnamedTag>(nameof(Misc)); set => WriteStructure(nameof(Misc), value); }

        [Offset(12UL)]
        public uint VirtualAddress { get => ReadHere<uint>(nameof(VirtualAddress)); set => WriteHere(nameof(VirtualAddress), value); }

        [Offset(16UL)]
        public uint SizeOfRawData { get => ReadHere<uint>(nameof(SizeOfRawData)); set => WriteHere(nameof(SizeOfRawData), value); }

        [Offset(20UL)]
        public uint PointerToRawData { get => ReadHere<uint>(nameof(PointerToRawData)); set => WriteHere(nameof(PointerToRawData), value); }

        [Offset(24UL)]
        public uint PointerToRelocations { get => ReadHere<uint>(nameof(PointerToRelocations)); set => WriteHere(nameof(PointerToRelocations), value); }

        [Offset(28UL)]
        public uint PointerToLinenumbers { get => ReadHere<uint>(nameof(PointerToLinenumbers)); set => WriteHere(nameof(PointerToLinenumbers), value); }

        [Offset(32UL)]
        public ushort NumberOfRelocations { get => ReadHere<ushort>(nameof(NumberOfRelocations)); set => WriteHere(nameof(NumberOfRelocations), value); }

        [Offset(34UL)]
        public ushort NumberOfLinenumbers { get => ReadHere<ushort>(nameof(NumberOfLinenumbers)); set => WriteHere(nameof(NumberOfLinenumbers), value); }

        [Offset(36UL)]
        public uint Characteristics { get => ReadHere<uint>(nameof(Characteristics)); set => WriteHere(nameof(Characteristics), value); }

        public ImageSectionHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ImageSectionHeader>();
        }
    }
}