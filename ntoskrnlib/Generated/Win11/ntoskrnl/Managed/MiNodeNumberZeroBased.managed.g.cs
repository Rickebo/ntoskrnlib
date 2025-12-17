using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_NODE_NUMBER_ZERO_BASED")]
    public sealed class MiNodeNumberZeroBased : DynamicStructure
    {
        [Offset(0UL)]
        public uint ZeroBased { get => ReadHere<uint>(nameof(ZeroBased)); set => WriteHere(nameof(ZeroBased), value); }

        public MiNodeNumberZeroBased(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiNodeNumberZeroBased>();
        }
    }
}