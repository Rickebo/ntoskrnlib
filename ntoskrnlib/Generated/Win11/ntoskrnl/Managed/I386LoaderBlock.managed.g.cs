using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_I386_LOADER_BLOCK")]
    public sealed class I386LoaderBlock : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr CommonDataArea { get => ReadHere<IntPtr>(nameof(CommonDataArea)); set => WriteHere(nameof(CommonDataArea), value); }

        [Offset(8UL)]
        public uint MachineType { get => ReadHere<uint>(nameof(MachineType)); set => WriteHere(nameof(MachineType), value); }

        [Offset(12UL)]
        public uint VirtualBias { get => ReadHere<uint>(nameof(VirtualBias)); set => WriteHere(nameof(VirtualBias), value); }

        public I386LoaderBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<I386LoaderBlock>();
        }
    }
}