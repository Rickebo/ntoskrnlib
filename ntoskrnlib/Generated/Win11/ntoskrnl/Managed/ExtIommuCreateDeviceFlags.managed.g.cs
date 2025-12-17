using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_CREATE_DEVICE_FLAGS")]
    public sealed class ExtIommuCreateDeviceFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint AsUINT32 { get => ReadHere<uint>(nameof(AsUINT32)); set => WriteHere(nameof(AsUINT32), value); }

        [Offset(0UL)]
        public uint WildCard { get => ReadHere<uint>(nameof(WildCard)); set => WriteHere(nameof(WildCard), value); }

        [Offset(0UL)]
        public uint ForceCreate { get => ReadHere<uint>(nameof(ForceCreate)); set => WriteHere(nameof(ForceCreate), value); }

        [Offset(0UL)]
        public uint LiveTraffic { get => ReadHere<uint>(nameof(LiveTraffic)); set => WriteHere(nameof(LiveTraffic), value); }

        [Offset(0UL)]
        public uint DeviceIsReserved { get => ReadHere<uint>(nameof(DeviceIsReserved)); set => WriteHere(nameof(DeviceIsReserved), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public ExtIommuCreateDeviceFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuCreateDeviceFlags>();
        }
    }
}