using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_WHEA_AER_BRIDGE_DESCRIPTOR")]
    public sealed class WheaAerBridgeDescriptor : DynamicStructure
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
        public AerBridgeDescriptorFlags Flags { get => ReadStructure<AerBridgeDescriptorFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(16UL)]
        public uint UncorrectableErrorMask { get => ReadHere<uint>(nameof(UncorrectableErrorMask)); set => WriteHere(nameof(UncorrectableErrorMask), value); }

        [Offset(20UL)]
        public uint UncorrectableErrorSeverity { get => ReadHere<uint>(nameof(UncorrectableErrorSeverity)); set => WriteHere(nameof(UncorrectableErrorSeverity), value); }

        [Offset(24UL)]
        public uint CorrectableErrorMask { get => ReadHere<uint>(nameof(CorrectableErrorMask)); set => WriteHere(nameof(CorrectableErrorMask), value); }

        [Offset(28UL)]
        public uint AdvancedCapsAndControl { get => ReadHere<uint>(nameof(AdvancedCapsAndControl)); set => WriteHere(nameof(AdvancedCapsAndControl), value); }

        [Offset(32UL)]
        public uint SecondaryUncorrectableErrorMask { get => ReadHere<uint>(nameof(SecondaryUncorrectableErrorMask)); set => WriteHere(nameof(SecondaryUncorrectableErrorMask), value); }

        [Offset(36UL)]
        public uint SecondaryUncorrectableErrorSev { get => ReadHere<uint>(nameof(SecondaryUncorrectableErrorSev)); set => WriteHere(nameof(SecondaryUncorrectableErrorSev), value); }

        [Offset(40UL)]
        public uint SecondaryCapsAndControl { get => ReadHere<uint>(nameof(SecondaryCapsAndControl)); set => WriteHere(nameof(SecondaryCapsAndControl), value); }

        public WheaAerBridgeDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaAerBridgeDescriptor>();
        }
    }
}