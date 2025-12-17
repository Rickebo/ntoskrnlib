using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_SPLAY_LINKS")]
    public sealed class RtlSplayLinks : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Parent { get => ReadHere<IntPtr>(nameof(Parent)); set => WriteHere(nameof(Parent), value); }

        [Offset(8UL)]
        public IntPtr LeftChild { get => ReadHere<IntPtr>(nameof(LeftChild)); set => WriteHere(nameof(LeftChild), value); }

        [Offset(16UL)]
        public IntPtr RightChild { get => ReadHere<IntPtr>(nameof(RightChild)); set => WriteHere(nameof(RightChild), value); }

        public RtlSplayLinks(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlSplayLinks>();
        }
    }
}