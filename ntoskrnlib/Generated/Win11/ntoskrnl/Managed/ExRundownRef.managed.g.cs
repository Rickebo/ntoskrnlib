using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EX_RUNDOWN_REF")]
    public sealed class ExRundownRef : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Count { get => ReadHere<ulong>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(0UL)]
        public IntPtr Ptr { get => ReadHere<IntPtr>(nameof(Ptr)); set => WriteHere(nameof(Ptr), value); }

        public ExRundownRef(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExRundownRef>();
        }
    }
}