using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_BALANCED_LINKS")]
    public sealed class RtlBalancedLinks : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Parent { get => ReadHere<IntPtr>(nameof(Parent)); set => WriteHere(nameof(Parent), value); }

        [Offset(8UL)]
        public IntPtr LeftChild { get => ReadHere<IntPtr>(nameof(LeftChild)); set => WriteHere(nameof(LeftChild), value); }

        [Offset(16UL)]
        public IntPtr RightChild { get => ReadHere<IntPtr>(nameof(RightChild)); set => WriteHere(nameof(RightChild), value); }

        [Offset(24UL)]
        public sbyte Balance { get => ReadHere<sbyte>(nameof(Balance)); set => WriteHere(nameof(Balance), value); }

        [Offset(25UL)]
        [Length(3)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        public RtlBalancedLinks(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlBalancedLinks>();
        }
    }
}