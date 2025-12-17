using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_HP_LFH_CONFIG")]
    public sealed class RtlHpLfhConfig : DynamicStructure
    {
        [Offset(0UL)]
        public ushort MaxBlockSize { get => ReadHere<ushort>(nameof(MaxBlockSize)); set => WriteHere(nameof(MaxBlockSize), value); }

        [Offset(2UL)]
        public ushort WitholdPageCrossingBlocks { get => ReadHere<ushort>(nameof(WitholdPageCrossingBlocks)); set => WriteHere(nameof(WitholdPageCrossingBlocks), value); }

        [Offset(0UL)]
        public uint AllFields { get => ReadHere<uint>(nameof(AllFields)); set => WriteHere(nameof(AllFields), value); }

        public RtlHpLfhConfig(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlHpLfhConfig>();
        }
    }
}