using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DEVICE_ID_PCI")]
    public sealed class ExtIommuDeviceIdPci : DynamicStructure
    {
        [Offset(0UL)]
        public ulong AsUINT64 { get => ReadHere<ulong>(nameof(AsUINT64)); set => WriteHere(nameof(AsUINT64), value); }

        [Offset(0UL)]
        public ushort PciSegmentNumber { get => ReadHere<ushort>(nameof(PciSegmentNumber)); set => WriteHere(nameof(PciSegmentNumber), value); }

        [Offset(2UL)]
        public ushort PhantomFunctionBits { get => ReadHere<ushort>(nameof(PhantomFunctionBits)); set => WriteHere(nameof(PhantomFunctionBits), value); }

        [Offset(2UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(2UL)]
        public ushort StartBusNumber { get => ReadHere<ushort>(nameof(StartBusNumber)); set => WriteHere(nameof(StartBusNumber), value); }

        [Offset(4UL)]
        public ushort Bdf { get => ReadHere<ushort>(nameof(Bdf)); set => WriteHere(nameof(Bdf), value); }

        [Offset(6UL)]
        public ushort DevicePathLength { get => ReadHere<ushort>(nameof(DevicePathLength)); set => WriteHere(nameof(DevicePathLength), value); }

        [Offset(8UL)]
        public IntPtr DevicePath { get => ReadHere<IntPtr>(nameof(DevicePath)); set => WriteHere(nameof(DevicePath), value); }

        public ExtIommuDeviceIdPci(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuDeviceIdPci>();
        }
    }
}