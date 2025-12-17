using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_IMAGE_FILE_HEADER")]
    public sealed class ImageFileHeader : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Machine { get => ReadHere<ushort>(nameof(Machine)); set => WriteHere(nameof(Machine), value); }

        [Offset(2UL)]
        public ushort NumberOfSections { get => ReadHere<ushort>(nameof(NumberOfSections)); set => WriteHere(nameof(NumberOfSections), value); }

        [Offset(4UL)]
        public uint TimeDateStamp { get => ReadHere<uint>(nameof(TimeDateStamp)); set => WriteHere(nameof(TimeDateStamp), value); }

        [Offset(8UL)]
        public uint PointerToSymbolTable { get => ReadHere<uint>(nameof(PointerToSymbolTable)); set => WriteHere(nameof(PointerToSymbolTable), value); }

        [Offset(12UL)]
        public uint NumberOfSymbols { get => ReadHere<uint>(nameof(NumberOfSymbols)); set => WriteHere(nameof(NumberOfSymbols), value); }

        [Offset(16UL)]
        public ushort SizeOfOptionalHeader { get => ReadHere<ushort>(nameof(SizeOfOptionalHeader)); set => WriteHere(nameof(SizeOfOptionalHeader), value); }

        [Offset(18UL)]
        public ushort Characteristics { get => ReadHere<ushort>(nameof(Characteristics)); set => WriteHere(nameof(Characteristics), value); }

        public ImageFileHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ImageFileHeader>();
        }
    }
}