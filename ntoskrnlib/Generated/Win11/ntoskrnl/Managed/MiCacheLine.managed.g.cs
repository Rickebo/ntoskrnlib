using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_CACHE_LINE")]
    public sealed class MiCacheLine : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(0UL)]
        public UnnamedTag u2 { get => ReadStructure<UnnamedTag>(nameof(u2)); set => WriteStructure(nameof(u2), value); }

        public MiCacheLine(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiCacheLine>();
        }
    }
}