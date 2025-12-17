using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VF_AVL_TREE")]
    public sealed class VfAvlTree : DynamicStructure
    {
        [Offset(0UL)]
        public ulong NodeRangeSize { get => ReadHere<ulong>(nameof(NodeRangeSize)); set => WriteHere(nameof(NodeRangeSize), value); }

        [Offset(8UL)]
        public ulong NodeCount { get => ReadHere<ulong>(nameof(NodeCount)); set => WriteHere(nameof(NodeCount), value); }

        [Offset(16UL)]
        public IntPtr Tables { get => ReadHere<IntPtr>(nameof(Tables)); set => WriteHere(nameof(Tables), value); }

        [Offset(24UL)]
        public uint TablesNo { get => ReadHere<uint>(nameof(TablesNo)); set => WriteHere(nameof(TablesNo), value); }

        [Offset(28UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        public VfAvlTree(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VfAvlTree>();
        }
    }
}