using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KQOS_GROUPING_SETS")]
    public sealed class KqosGroupingSets : DynamicStructure
    {
        [Offset(0UL)]
        public ulong SingleCoreSet { get => ReadHere<ulong>(nameof(SingleCoreSet)); set => WriteHere(nameof(SingleCoreSet), value); }

        [Offset(8UL)]
        public ulong SmtSet { get => ReadHere<ulong>(nameof(SmtSet)); set => WriteHere(nameof(SmtSet), value); }

        public KqosGroupingSets(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KqosGroupingSets>();
        }
    }
}