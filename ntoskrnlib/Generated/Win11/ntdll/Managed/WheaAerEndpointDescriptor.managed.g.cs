using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_WHEA_AER_ENDPOINT_DESCRIPTOR")]
    public sealed class WheaAerEndpointDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Type { get => ReadHere<ushort>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public byte Enabled { get => ReadHere<byte>(nameof(Enabled)); set => WriteHere(nameof(Enabled), value); }

        [Offset(3UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(4UL)]
        public uint BusNumber { get => ReadHere<uint>(nameof(BusNumber)); set => WriteHere(nameof(BusNumber), value); }

        [Offset(8UL)]
        public WheaPciSlotNumber Slot { get => ReadStructure<WheaPciSlotNumber>(nameof(Slot)); set => WriteStructure(nameof(Slot), value); }

        [Offset(12UL)]
        public ushort DeviceControl { get => ReadHere<ushort>(nameof(DeviceControl)); set => WriteHere(nameof(DeviceControl), value); }

        [Offset(14UL)]
        public AerEndpointDescriptorFlags Flags { get => ReadStructure<AerEndpointDescriptorFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(16UL)]
        public uint UncorrectableErrorMask { get => ReadHere<uint>(nameof(UncorrectableErrorMask)); set => WriteHere(nameof(UncorrectableErrorMask), value); }

        [Offset(20UL)]
        public uint UncorrectableErrorSeverity { get => ReadHere<uint>(nameof(UncorrectableErrorSeverity)); set => WriteHere(nameof(UncorrectableErrorSeverity), value); }

        [Offset(24UL)]
        public uint CorrectableErrorMask { get => ReadHere<uint>(nameof(CorrectableErrorMask)); set => WriteHere(nameof(CorrectableErrorMask), value); }

        [Offset(28UL)]
        public uint AdvancedCapsAndControl { get => ReadHere<uint>(nameof(AdvancedCapsAndControl)); set => WriteHere(nameof(AdvancedCapsAndControl), value); }

        public WheaAerEndpointDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaAerEndpointDescriptor>();
        }
    }
}