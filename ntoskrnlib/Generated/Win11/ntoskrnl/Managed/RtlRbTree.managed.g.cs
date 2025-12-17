using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_RB_TREE")]
    public sealed class RtlRbTree : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Root { get => ReadHere<IntPtr>(nameof(Root)); set => WriteHere(nameof(Root), value); }

        [Offset(8UL)]
        public byte Encoded { get => ReadHere<byte>(nameof(Encoded)); set => WriteHere(nameof(Encoded), value); }

        [Offset(8UL)]
        public IntPtr Min { get => ReadHere<IntPtr>(nameof(Min)); set => WriteHere(nameof(Min), value); }

        public RtlRbTree(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlRbTree>();
        }
    }
}