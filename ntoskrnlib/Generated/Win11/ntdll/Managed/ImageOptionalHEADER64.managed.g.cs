using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_IMAGE_OPTIONAL_HEADER64")]
    public sealed class ImageOptionalHEADER64 : DynamicStructure
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
        public ulong ImageBase { get => ReadHere<ulong>(nameof(ImageBase)); set => WriteHere(nameof(ImageBase), value); }

        [Offset(32UL)]
        public uint SectionAlignment { get => ReadHere<uint>(nameof(SectionAlignment)); set => WriteHere(nameof(SectionAlignment), value); }

        [Offset(36UL)]
        public uint FileAlignment { get => ReadHere<uint>(nameof(FileAlignment)); set => WriteHere(nameof(FileAlignment), value); }

        [Offset(40UL)]
        public ushort MajorOperatingSystemVersion { get => ReadHere<ushort>(nameof(MajorOperatingSystemVersion)); set => WriteHere(nameof(MajorOperatingSystemVersion), value); }

        [Offset(42UL)]
        public ushort MinorOperatingSystemVersion { get => ReadHere<ushort>(nameof(MinorOperatingSystemVersion)); set => WriteHere(nameof(MinorOperatingSystemVersion), value); }

        [Offset(44UL)]
        public ushort MajorImageVersion { get => ReadHere<ushort>(nameof(MajorImageVersion)); set => WriteHere(nameof(MajorImageVersion), value); }

        [Offset(46UL)]
        public ushort MinorImageVersion { get => ReadHere<ushort>(nameof(MinorImageVersion)); set => WriteHere(nameof(MinorImageVersion), value); }

        [Offset(48UL)]
        public ushort MajorSubsystemVersion { get => ReadHere<ushort>(nameof(MajorSubsystemVersion)); set => WriteHere(nameof(MajorSubsystemVersion), value); }

        [Offset(50UL)]
        public ushort MinorSubsystemVersion { get => ReadHere<ushort>(nameof(MinorSubsystemVersion)); set => WriteHere(nameof(MinorSubsystemVersion), value); }

        [Offset(52UL)]
        public uint Win32VersionValue { get => ReadHere<uint>(nameof(Win32VersionValue)); set => WriteHere(nameof(Win32VersionValue), value); }

        [Offset(56UL)]
        public uint SizeOfImage { get => ReadHere<uint>(nameof(SizeOfImage)); set => WriteHere(nameof(SizeOfImage), value); }

        [Offset(60UL)]
        public uint SizeOfHeaders { get => ReadHere<uint>(nameof(SizeOfHeaders)); set => WriteHere(nameof(SizeOfHeaders), value); }

        [Offset(64UL)]
        public uint CheckSum { get => ReadHere<uint>(nameof(CheckSum)); set => WriteHere(nameof(CheckSum), value); }

        [Offset(68UL)]
        public ushort Subsystem { get => ReadHere<ushort>(nameof(Subsystem)); set => WriteHere(nameof(Subsystem), value); }

        [Offset(70UL)]
        public ushort DllCharacteristics { get => ReadHere<ushort>(nameof(DllCharacteristics)); set => WriteHere(nameof(DllCharacteristics), value); }

        [Offset(72UL)]
        public ulong SizeOfStackReserve { get => ReadHere<ulong>(nameof(SizeOfStackReserve)); set => WriteHere(nameof(SizeOfStackReserve), value); }

        [Offset(80UL)]
        public ulong SizeOfStackCommit { get => ReadHere<ulong>(nameof(SizeOfStackCommit)); set => WriteHere(nameof(SizeOfStackCommit), value); }

        [Offset(88UL)]
        public ulong SizeOfHeapReserve { get => ReadHere<ulong>(nameof(SizeOfHeapReserve)); set => WriteHere(nameof(SizeOfHeapReserve), value); }

        [Offset(96UL)]
        public ulong SizeOfHeapCommit { get => ReadHere<ulong>(nameof(SizeOfHeapCommit)); set => WriteHere(nameof(SizeOfHeapCommit), value); }

        [Offset(104UL)]
        public uint LoaderFlags { get => ReadHere<uint>(nameof(LoaderFlags)); set => WriteHere(nameof(LoaderFlags), value); }

        [Offset(108UL)]
        public uint NumberOfRvaAndSizes { get => ReadHere<uint>(nameof(NumberOfRvaAndSizes)); set => WriteHere(nameof(NumberOfRvaAndSizes), value); }

        [Offset(112UL)]
        [Length(16)]
        public DynamicArray DataDirectory { get => ReadStructure<DynamicArray>(nameof(DataDirectory)); set => WriteStructure(nameof(DataDirectory), value); }

        public ImageOptionalHEADER64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ImageOptionalHEADER64>();
        }
    }
}