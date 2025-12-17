using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_RESERVED_REGION")]
    public sealed class IommuDmaReservedRegion : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr RegionNext { get => ReadHere<IntPtr>(nameof(RegionNext)); set => WriteHere(nameof(RegionNext), value); }

        [Offset(8UL)]
        public ulong Base { get => ReadHere<ulong>(nameof(Base)); set => WriteHere(nameof(Base), value); }

        [Offset(16UL)]
        public ulong NumberOfPages { get => ReadHere<ulong>(nameof(NumberOfPages)); set => WriteHere(nameof(NumberOfPages), value); }

        [Offset(24UL)]
        public byte ShouldMap { get => ReadHere<byte>(nameof(ShouldMap)); set => WriteHere(nameof(ShouldMap), value); }

        public IommuDmaReservedRegion(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDmaReservedRegion>();
        }
    }
}