using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOP_IRP_STACK_PROFILER")]
    public sealed class IopIrpStackProfiler : DynamicStructure
    {
        [Offset(0UL)]
        [Length(20)]
        public DynamicArray Profile { get => ReadStructure<DynamicArray>(nameof(Profile)); set => WriteStructure(nameof(Profile), value); }

        [Offset(80UL)]
        public uint TotalIrps { get => ReadHere<uint>(nameof(TotalIrps)); set => WriteHere(nameof(TotalIrps), value); }

        public IopIrpStackProfiler(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IopIrpStackProfiler>();
        }
    }
}