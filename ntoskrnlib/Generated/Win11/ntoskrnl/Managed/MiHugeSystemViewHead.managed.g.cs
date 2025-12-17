using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_HUGE_SYSTEM_VIEW_HEAD")]
    public sealed class MiHugeSystemViewHead : DynamicStructure
    {
        [Offset(0UL)]
        public RtlAvlTree ViewRoot { get => ReadStructure<RtlAvlTree>(nameof(ViewRoot)); set => WriteStructure(nameof(ViewRoot), value); }

        [Offset(8UL)]
        public uint ViewCount { get => ReadHere<uint>(nameof(ViewCount)); set => WriteHere(nameof(ViewCount), value); }

        [Offset(12UL)]
        public int Lock { get => ReadHere<int>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        public MiHugeSystemViewHead(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiHugeSystemViewHead>();
        }
    }
}