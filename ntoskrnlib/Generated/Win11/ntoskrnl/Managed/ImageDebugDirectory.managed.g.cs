using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IMAGE_DEBUG_DIRECTORY")]
    public sealed class ImageDebugDirectory : DynamicStructure
    {
        [Offset(0UL)]
        public uint Characteristics { get => ReadHere<uint>(nameof(Characteristics)); set => WriteHere(nameof(Characteristics), value); }

        [Offset(4UL)]
        public uint TimeDateStamp { get => ReadHere<uint>(nameof(TimeDateStamp)); set => WriteHere(nameof(TimeDateStamp), value); }

        [Offset(8UL)]
        public ushort MajorVersion { get => ReadHere<ushort>(nameof(MajorVersion)); set => WriteHere(nameof(MajorVersion), value); }

        [Offset(10UL)]
        public ushort MinorVersion { get => ReadHere<ushort>(nameof(MinorVersion)); set => WriteHere(nameof(MinorVersion), value); }

        [Offset(12UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(16UL)]
        public uint SizeOfData { get => ReadHere<uint>(nameof(SizeOfData)); set => WriteHere(nameof(SizeOfData), value); }

        [Offset(20UL)]
        public uint AddressOfRawData { get => ReadHere<uint>(nameof(AddressOfRawData)); set => WriteHere(nameof(AddressOfRawData), value); }

        [Offset(24UL)]
        public uint PointerToRawData { get => ReadHere<uint>(nameof(PointerToRawData)); set => WriteHere(nameof(PointerToRawData), value); }

        public ImageDebugDirectory(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ImageDebugDirectory>();
        }
    }
}