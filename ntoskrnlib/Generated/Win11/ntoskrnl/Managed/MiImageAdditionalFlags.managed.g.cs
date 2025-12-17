using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_IMAGE_ADDITIONAL_FLAGS")]
    public sealed class MiImageAdditionalFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint SizeOfHeader { get => ReadHere<uint>(nameof(SizeOfHeader)); set => WriteHere(nameof(SizeOfHeader), value); }

        [Offset(0UL)]
        public uint FilesystemWantsRva { get => ReadHere<uint>(nameof(FilesystemWantsRva)); set => WriteHere(nameof(FilesystemWantsRva), value); }

        public MiImageAdditionalFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiImageAdditionalFlags>();
        }
    }
}