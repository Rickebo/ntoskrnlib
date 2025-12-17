using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_DESCRIPTION")]
    public sealed class DeviceDescription : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public byte Master { get => ReadHere<byte>(nameof(Master)); set => WriteHere(nameof(Master), value); }

        [Offset(5UL)]
        public byte ScatterGather { get => ReadHere<byte>(nameof(ScatterGather)); set => WriteHere(nameof(ScatterGather), value); }

        [Offset(6UL)]
        public byte DemandMode { get => ReadHere<byte>(nameof(DemandMode)); set => WriteHere(nameof(DemandMode), value); }

        [Offset(7UL)]
        public byte AutoInitialize { get => ReadHere<byte>(nameof(AutoInitialize)); set => WriteHere(nameof(AutoInitialize), value); }

        [Offset(8UL)]
        public byte Dma32BitAddresses { get => ReadHere<byte>(nameof(Dma32BitAddresses)); set => WriteHere(nameof(Dma32BitAddresses), value); }

        [Offset(9UL)]
        public byte IgnoreCount { get => ReadHere<byte>(nameof(IgnoreCount)); set => WriteHere(nameof(IgnoreCount), value); }

        [Offset(10UL)]
        public byte Reserved1 { get => ReadHere<byte>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(11UL)]
        public byte Dma64BitAddresses { get => ReadHere<byte>(nameof(Dma64BitAddresses)); set => WriteHere(nameof(Dma64BitAddresses), value); }

        [Offset(12UL)]
        public uint BusNumber { get => ReadHere<uint>(nameof(BusNumber)); set => WriteHere(nameof(BusNumber), value); }

        [Offset(16UL)]
        public uint DmaChannel { get => ReadHere<uint>(nameof(DmaChannel)); set => WriteHere(nameof(DmaChannel), value); }

        [Offset(20UL)]
        public uint InterfaceType { get => ReadHere<uint>(nameof(InterfaceType)); set => WriteHere(nameof(InterfaceType), value); }

        [Offset(24UL)]
        public uint DmaWidth { get => ReadHere<uint>(nameof(DmaWidth)); set => WriteHere(nameof(DmaWidth), value); }

        [Offset(28UL)]
        public uint DmaSpeed { get => ReadHere<uint>(nameof(DmaSpeed)); set => WriteHere(nameof(DmaSpeed), value); }

        [Offset(32UL)]
        public uint MaximumLength { get => ReadHere<uint>(nameof(MaximumLength)); set => WriteHere(nameof(MaximumLength), value); }

        [Offset(36UL)]
        public uint DmaPort { get => ReadHere<uint>(nameof(DmaPort)); set => WriteHere(nameof(DmaPort), value); }

        [Offset(40UL)]
        public uint DmaAddressWidth { get => ReadHere<uint>(nameof(DmaAddressWidth)); set => WriteHere(nameof(DmaAddressWidth), value); }

        [Offset(44UL)]
        public uint DmaControllerInstance { get => ReadHere<uint>(nameof(DmaControllerInstance)); set => WriteHere(nameof(DmaControllerInstance), value); }

        [Offset(48UL)]
        public uint DmaRequestLine { get => ReadHere<uint>(nameof(DmaRequestLine)); set => WriteHere(nameof(DmaRequestLine), value); }

        [Offset(56UL)]
        public LargeInteger DeviceAddress { get => ReadStructure<LargeInteger>(nameof(DeviceAddress)); set => WriteStructure(nameof(DeviceAddress), value); }

        public DeviceDescription(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceDescription>();
        }
    }
}