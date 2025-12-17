using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXP_POOL_CONTEXT_HEADER")]
    public sealed class ExpPoolContextHeader : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public uint ContextType { get => ReadHere<uint>(nameof(ContextType)); set => WriteHere(nameof(ContextType), value); }

        public ExpPoolContextHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExpPoolContextHeader>();
        }
    }
}