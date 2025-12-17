using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LDRP_CSLIST")]
    public sealed class LdrpCslist : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Tail { get => ReadHere<IntPtr>(nameof(Tail)); set => WriteHere(nameof(Tail), value); }

        public LdrpCslist(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LdrpCslist>();
        }
    }
}