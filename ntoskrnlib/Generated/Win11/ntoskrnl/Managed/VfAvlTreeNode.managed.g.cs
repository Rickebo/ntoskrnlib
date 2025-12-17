using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VF_AVL_TREE_NODE")]
    public sealed class VfAvlTreeNode : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr p { get => ReadHere<IntPtr>(nameof(p)); set => WriteHere(nameof(p), value); }

        [Offset(8UL)]
        public ulong RangeSize { get => ReadHere<ulong>(nameof(RangeSize)); set => WriteHere(nameof(RangeSize), value); }

        public VfAvlTreeNode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VfAvlTreeNode>();
        }
    }
}