using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_IMAGE_NT_HEADERS64")]
    public sealed class ImageNtHEADERS64 : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public ImageFileHeader FileHeader { get => ReadStructure<ImageFileHeader>(nameof(FileHeader)); set => WriteStructure(nameof(FileHeader), value); }

        [Offset(24UL)]
        public ImageOptionalHEADER64 OptionalHeader { get => ReadStructure<ImageOptionalHEADER64>(nameof(OptionalHeader)); set => WriteStructure(nameof(OptionalHeader), value); }

        public ImageNtHEADERS64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ImageNtHEADERS64>();
        }
    }
}