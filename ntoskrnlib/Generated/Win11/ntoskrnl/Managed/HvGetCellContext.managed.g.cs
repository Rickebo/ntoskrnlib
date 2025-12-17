using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HV_GET_CELL_CONTEXT")]
    public sealed class HvGetCellContext : DynamicStructure
    {
        [Offset(0UL)]
        public uint Cell { get => ReadHere<uint>(nameof(Cell)); set => WriteHere(nameof(Cell), value); }

        [Offset(4UL)]
        public HvGetBinContext BinContext { get => ReadStructure<HvGetBinContext>(nameof(BinContext)); set => WriteStructure(nameof(BinContext), value); }

        public HvGetCellContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HvGetCellContext>();
        }
    }
}