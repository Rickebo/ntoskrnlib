using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_AVL_TREE")]
    public sealed class RtlAvlTree : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Root { get => ReadHere<IntPtr>(nameof(Root)); set => WriteHere(nameof(Root), value); }

        public RtlAvlTree(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlAvlTree>();
        }
    }
}