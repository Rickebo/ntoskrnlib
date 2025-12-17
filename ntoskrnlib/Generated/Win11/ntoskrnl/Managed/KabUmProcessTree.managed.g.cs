using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KAB_UM_PROCESS_TREE")]
    public sealed class KabUmProcessTree : DynamicStructure
    {
        [Offset(0UL)]
        public RtlRbTree Tree { get => ReadStructure<RtlRbTree>(nameof(Tree)); set => WriteStructure(nameof(Tree), value); }

        [Offset(16UL)]
        public ulong TreeLock { get => ReadHere<ulong>(nameof(TreeLock)); set => WriteHere(nameof(TreeLock), value); }

        public KabUmProcessTree(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KabUmProcessTree>();
        }
    }
}