using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARM_LOADER_BLOCK")]
    public sealed class ArmLoaderBlock : DynamicStructure
    {
        [Offset(0UL)]
        public uint PlaceHolder { get => ReadHere<uint>(nameof(PlaceHolder)); set => WriteHere(nameof(PlaceHolder), value); }

        public ArmLoaderBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArmLoaderBlock>();
        }
    }
}