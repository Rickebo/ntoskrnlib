using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_FORCED_COMMITS")]
    public sealed class MiForcedCommits : DynamicStructure
    {
        [Offset(0UL)]
        public uint Regular { get => ReadHere<uint>(nameof(Regular)); set => WriteHere(nameof(Regular), value); }

        [Offset(4UL)]
        public uint Wrap { get => ReadHere<uint>(nameof(Wrap)); set => WriteHere(nameof(Wrap), value); }

        public MiForcedCommits(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiForcedCommits>();
        }
    }
}