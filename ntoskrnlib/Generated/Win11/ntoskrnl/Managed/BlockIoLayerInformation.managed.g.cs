using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_BLOCK_IO_LAYER_INFORMATION")]
    public sealed class BlockIoLayerInformation : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ArcName { get => ReadHere<IntPtr>(nameof(ArcName)); set => WriteHere(nameof(ArcName), value); }

        public BlockIoLayerInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<BlockIoLayerInformation>();
        }
    }
}