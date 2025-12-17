using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_PROVIDER")]
    public sealed class PopFxProvider : DynamicStructure
    {
        [Offset(0UL)]
        public uint Index { get => ReadHere<uint>(nameof(Index)); set => WriteHere(nameof(Index), value); }

        [Offset(4UL)]
        public byte Activating { get => ReadHere<byte>(nameof(Activating)); set => WriteHere(nameof(Activating), value); }

        public PopFxProvider(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxProvider>();
        }
    }
}