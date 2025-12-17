using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CMP_DISCARD_AND_REPLACE_KCB_CONTEXT")]
    public sealed class CmpDiscardAndReplaceKcbContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr BaseKcb { get => ReadHere<IntPtr>(nameof(BaseKcb)); set => WriteHere(nameof(BaseKcb), value); }

        [Offset(8UL)]
        public int PrepareStatus { get => ReadHere<int>(nameof(PrepareStatus)); set => WriteHere(nameof(PrepareStatus), value); }

        [Offset(16UL)]
        public ListEntry ClonedKcbListHead { get => ReadStructure<ListEntry>(nameof(ClonedKcbListHead)); set => WriteStructure(nameof(ClonedKcbListHead), value); }

        public CmpDiscardAndReplaceKcbContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmpDiscardAndReplaceKcbContext>();
        }
    }
}