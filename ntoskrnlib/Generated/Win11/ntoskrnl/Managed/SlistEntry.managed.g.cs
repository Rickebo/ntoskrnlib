using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SLIST_ENTRY")]
    public sealed class SlistEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        public SlistEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SlistEntry>();
        }
    }
}