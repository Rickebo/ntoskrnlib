using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_DEPENDENT")]
    public sealed class PopFxDependent : DynamicStructure
    {
        [Offset(0UL)]
        public uint Index { get => ReadHere<uint>(nameof(Index)); set => WriteHere(nameof(Index), value); }

        [Offset(4UL)]
        public uint ProviderIndex { get => ReadHere<uint>(nameof(ProviderIndex)); set => WriteHere(nameof(ProviderIndex), value); }

        public PopFxDependent(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxDependent>();
        }
    }
}