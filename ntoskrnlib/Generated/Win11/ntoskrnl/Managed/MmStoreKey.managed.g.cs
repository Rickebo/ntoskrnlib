using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MM_STORE_KEY")]
    public sealed class MmStoreKey : DynamicStructure
    {
        [Offset(0UL)]
        public uint EntireKey { get => ReadHere<uint>(nameof(EntireKey)); set => WriteHere(nameof(EntireKey), value); }

        public MmStoreKey(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmStoreKey>();
        }
    }
}