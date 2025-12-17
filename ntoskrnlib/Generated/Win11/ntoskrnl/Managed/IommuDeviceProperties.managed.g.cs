using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DEVICE_PROPERTIES")]
    public sealed class IommuDeviceProperties : DynamicStructure
    {
        [Offset(0UL)]
        public uint IsThunderbolt { get => ReadHere<uint>(nameof(IsThunderbolt)); set => WriteHere(nameof(IsThunderbolt), value); }

        [Offset(0UL)]
        public uint DmaCapableAtBoot { get => ReadHere<uint>(nameof(DmaCapableAtBoot)); set => WriteHere(nameof(DmaCapableAtBoot), value); }

        [Offset(0UL)]
        public uint ForceDisableDmaRemapping { get => ReadHere<uint>(nameof(ForceDisableDmaRemapping)); set => WriteHere(nameof(ForceDisableDmaRemapping), value); }

        [Offset(0UL)]
        public uint IsUntrustedPort { get => ReadHere<uint>(nameof(IsUntrustedPort)); set => WriteHere(nameof(IsUntrustedPort), value); }

        [Offset(0UL)]
        public uint ForceEnableDmaRemapping { get => ReadHere<uint>(nameof(ForceEnableDmaRemapping)); set => WriteHere(nameof(ForceEnableDmaRemapping), value); }

        [Offset(0UL)]
        public uint Rsvd { get => ReadHere<uint>(nameof(Rsvd)); set => WriteHere(nameof(Rsvd), value); }

        [Offset(0UL)]
        public uint AsULONG { get => ReadHere<uint>(nameof(AsULONG)); set => WriteHere(nameof(AsULONG), value); }

        public IommuDeviceProperties(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDeviceProperties>();
        }
    }
}