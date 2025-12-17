using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!POHANDLE__")]
    public sealed class Pohandle : DynamicStructure
    {
        [Offset(0UL)]
        public int unused { get => ReadHere<int>(nameof(unused)); set => WriteHere(nameof(unused), value); }

        public Pohandle(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Pohandle>();
        }
    }
}