using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTIMER2_COLLECTION")]
    public sealed class KTIMER2Collection : DynamicStructure
    {
        [Offset(0UL)]
        public RtlRbTree Tree { get => ReadStructure<RtlRbTree>(nameof(Tree)); set => WriteStructure(nameof(Tree), value); }

        [Offset(16UL)]
        public ulong NextDueTime { get => ReadHere<ulong>(nameof(NextDueTime)); set => WriteHere(nameof(NextDueTime), value); }

        public KTIMER2Collection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KTIMER2Collection>();
        }
    }
}