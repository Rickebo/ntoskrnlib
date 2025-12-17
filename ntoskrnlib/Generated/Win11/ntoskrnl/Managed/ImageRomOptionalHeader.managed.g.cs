using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IMAGE_ROM_OPTIONAL_HEADER")]
    public sealed class ImageRomOptionalHeader : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Magic { get => ReadHere<ushort>(nameof(Magic)); set => WriteHere(nameof(Magic), value); }

        [Offset(2UL)]
        public byte MajorLinkerVersion { get => ReadHere<byte>(nameof(MajorLinkerVersion)); set => WriteHere(nameof(MajorLinkerVersion), value); }

        [Offset(3UL)]
        public byte MinorLinkerVersion { get => ReadHere<byte>(nameof(MinorLinkerVersion)); set => WriteHere(nameof(MinorLinkerVersion), value); }

        [Offset(4UL)]
        public uint SizeOfCode { get => ReadHere<uint>(nameof(SizeOfCode)); set => WriteHere(nameof(SizeOfCode), value); }

        [Offset(8UL)]
        public uint SizeOfInitializedData { get => ReadHere<uint>(nameof(SizeOfInitializedData)); set => WriteHere(nameof(SizeOfInitializedData), value); }

        [Offset(12UL)]
        public uint SizeOfUninitializedData { get => ReadHere<uint>(nameof(SizeOfUninitializedData)); set => WriteHere(nameof(SizeOfUninitializedData), value); }

        [Offset(16UL)]
        public uint AddressOfEntryPoint { get => ReadHere<uint>(nameof(AddressOfEntryPoint)); set => WriteHere(nameof(AddressOfEntryPoint), value); }

        [Offset(20UL)]
        public uint BaseOfCode { get => ReadHere<uint>(nameof(BaseOfCode)); set => WriteHere(nameof(BaseOfCode), value); }

        [Offset(24UL)]
        public uint BaseOfData { get => ReadHere<uint>(nameof(BaseOfData)); set => WriteHere(nameof(BaseOfData), value); }

        [Offset(28UL)]
        public uint BaseOfBss { get => ReadHere<uint>(nameof(BaseOfBss)); set => WriteHere(nameof(BaseOfBss), value); }

        [Offset(32UL)]
        public uint GprMask { get => ReadHere<uint>(nameof(GprMask)); set => WriteHere(nameof(GprMask), value); }

        [Offset(36UL)]
        [Length(4)]
        public DynamicArray CprMask { get => ReadStructure<DynamicArray>(nameof(CprMask)); set => WriteStructure(nameof(CprMask), value); }

        [Offset(52UL)]
        public uint GpValue { get => ReadHere<uint>(nameof(GpValue)); set => WriteHere(nameof(GpValue), value); }

        public ImageRomOptionalHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ImageRomOptionalHeader>();
        }
    }
}