using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_EXTENT_DELETION_WAIT_BLOCK")]
    public sealed class MiExtentDeletionWaitBlock : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public Kgate Gate { get => ReadStructure<Kgate>(nameof(Gate)); set => WriteStructure(nameof(Gate), value); }

        public MiExtentDeletionWaitBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiExtentDeletionWaitBlock>();
        }
    }
}