using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_NODE_RANGE")]
    public sealed class HalNodeRange : DynamicStructure
    {
        [Offset(0UL)]
        public ulong PageFrameIndex { get => ReadHere<ulong>(nameof(PageFrameIndex)); set => WriteHere(nameof(PageFrameIndex), value); }

        [Offset(8UL)]
        public uint Node { get => ReadHere<uint>(nameof(Node)); set => WriteHere(nameof(Node), value); }

        public HalNodeRange(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalNodeRange>();
        }
    }
}