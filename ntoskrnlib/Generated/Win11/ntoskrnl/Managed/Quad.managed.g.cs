using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_QUAD")]
    public sealed class Quad : DynamicStructure
    {
        [Offset(0UL)]
        public long UseThisFieldToCopy { get => ReadHere<long>(nameof(UseThisFieldToCopy)); set => WriteHere(nameof(UseThisFieldToCopy), value); }

        [Offset(0UL)]
        public long DoNotUseThisField { get => ReadHere<long>(nameof(DoNotUseThisField)); set => WriteHere(nameof(DoNotUseThisField), value); }

        public Quad(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Quad>();
        }
    }
}