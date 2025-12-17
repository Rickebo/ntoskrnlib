using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VF_AVL_TABLE")]
    public sealed class VfAvlTable : DynamicStructure
    {
        [Offset(0UL)]
        public RtlAvlTable RtlTable { get => ReadStructure<RtlAvlTable>(nameof(RtlTable)); set => WriteStructure(nameof(RtlTable), value); }

        [Offset(104UL)]
        public IntPtr ReservedNode { get => ReadHere<IntPtr>(nameof(ReservedNode)); set => WriteHere(nameof(ReservedNode), value); }

        [Offset(112UL)]
        public IntPtr NodeToFree { get => ReadHere<IntPtr>(nameof(NodeToFree)); set => WriteHere(nameof(NodeToFree), value); }

        [Offset(128UL)]
        public int Lock { get => ReadHere<int>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(136UL)]
        public IntPtr ExclusiveOwnerThread { get => ReadHere<IntPtr>(nameof(ExclusiveOwnerThread)); set => WriteHere(nameof(ExclusiveOwnerThread), value); }

        public VfAvlTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VfAvlTable>();
        }
    }
}