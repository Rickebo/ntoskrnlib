using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_HV_DMA_HYBRID_PASSTHROUGH_RESERVED_REGIONS")]
    public sealed class HalHvDmaHybridPassthroughReservedRegions : DynamicStructure
    {
        [Offset(0UL)]
        public ulong UnitSizePages { get => ReadHere<ulong>(nameof(UnitSizePages)); set => WriteHere(nameof(UnitSizePages), value); }

        [Offset(8UL)]
        public RtlBitmap ReservedUnitMap { get => ReadStructure<RtlBitmap>(nameof(ReservedUnitMap)); set => WriteStructure(nameof(ReservedUnitMap), value); }

        [Offset(24UL)]
        [Length(16)]
        public DynamicArray ReservedUnitMapBuffer { get => ReadStructure<DynamicArray>(nameof(ReservedUnitMapBuffer)); set => WriteStructure(nameof(ReservedUnitMapBuffer), value); }

        public HalHvDmaHybridPassthroughReservedRegions(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalHvDmaHybridPassthroughReservedRegions>();
        }
    }
}