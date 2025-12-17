using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_AWE_ATTRIBUTE_CHANGE_WAIT_BLOCK")]
    public sealed class MiAweAttributeChangeWaitBlock : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public IntPtr BasePfn { get => ReadHere<IntPtr>(nameof(BasePfn)); set => WriteHere(nameof(BasePfn), value); }

        [Offset(16UL)]
        public Kgate Gate { get => ReadStructure<Kgate>(nameof(Gate)); set => WriteStructure(nameof(Gate), value); }

        public MiAweAttributeChangeWaitBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiAweAttributeChangeWaitBlock>();
        }
    }
}