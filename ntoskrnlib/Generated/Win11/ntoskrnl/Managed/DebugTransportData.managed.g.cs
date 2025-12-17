using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEBUG_TRANSPORT_DATA")]
    public sealed class DebugTransportData : DynamicStructure
    {
        [Offset(0UL)]
        public uint HwContextSize { get => ReadHere<uint>(nameof(HwContextSize)); set => WriteHere(nameof(HwContextSize), value); }

        [Offset(4UL)]
        public uint SharedVisibleDataSize { get => ReadHere<uint>(nameof(SharedVisibleDataSize)); set => WriteHere(nameof(SharedVisibleDataSize), value); }

        [Offset(8UL)]
        public byte UseSerialFraming { get => ReadHere<byte>(nameof(UseSerialFraming)); set => WriteHere(nameof(UseSerialFraming), value); }

        [Offset(9UL)]
        public byte ValidUSBCoreId { get => ReadHere<byte>(nameof(ValidUSBCoreId)); set => WriteHere(nameof(ValidUSBCoreId), value); }

        [Offset(10UL)]
        public byte USBCoreId { get => ReadHere<byte>(nameof(USBCoreId)); set => WriteHere(nameof(USBCoreId), value); }

        public DebugTransportData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DebugTransportData>();
        }
    }
}