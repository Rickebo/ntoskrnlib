using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_RESERVED_DEVICE")]
    public sealed class IommuReservedDevice : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DeviceId { get => ReadHere<IntPtr>(nameof(DeviceId)); set => WriteHere(nameof(DeviceId), value); }

        [Offset(8UL)]
        public IntPtr PageTable { get => ReadHere<IntPtr>(nameof(PageTable)); set => WriteHere(nameof(PageTable), value); }

        [Offset(16UL)]
        public LargeInteger PageTablePhysical { get => ReadStructure<LargeInteger>(nameof(PageTablePhysical)); set => WriteStructure(nameof(PageTablePhysical), value); }

        [Offset(24UL)]
        public IntPtr ExtDevice { get => ReadHere<IntPtr>(nameof(ExtDevice)); set => WriteHere(nameof(ExtDevice), value); }

        [Offset(32UL)]
        public uint RegionCount { get => ReadHere<uint>(nameof(RegionCount)); set => WriteHere(nameof(RegionCount), value); }

        [Offset(40UL)]
        [Length(1)]
        public DynamicArray Regions { get => ReadStructure<DynamicArray>(nameof(Regions)); set => WriteStructure(nameof(Regions), value); }

        public IommuReservedDevice(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuReservedDevice>();
        }
    }
}