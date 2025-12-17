using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMADDRESS_LIST")]
    public sealed class MmaddressList : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(8UL)]
        public IntPtr EndVa { get => ReadHere<IntPtr>(nameof(EndVa)); set => WriteHere(nameof(EndVa), value); }

        public MmaddressList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmaddressList>();
        }
    }
}