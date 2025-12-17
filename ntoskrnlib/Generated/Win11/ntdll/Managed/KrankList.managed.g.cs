using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KRANK_LIST")]
    public sealed class KrankList : DynamicStructure
    {
        [Offset(0UL)]
        [Length(64)]
        public DynamicArray Ranks { get => ReadStructure<DynamicArray>(nameof(Ranks)); set => WriteStructure(nameof(Ranks), value); }

        [Offset(0UL)]
        [Length(8)]
        public DynamicArray AsUlong64s { get => ReadStructure<DynamicArray>(nameof(AsUlong64s)); set => WriteStructure(nameof(AsUlong64s), value); }

        public KrankList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KrankList>();
        }
    }
}