using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_ADAPTER")]
    public sealed class DmaAdapter : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Version { get => ReadHere<ushort>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(2UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public IntPtr DmaOperations { get => ReadHere<IntPtr>(nameof(DmaOperations)); set => WriteHere(nameof(DmaOperations), value); }

        public DmaAdapter(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaAdapter>();
        }
    }
}