using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_GPIO_RESOURCE")]
    public sealed class PepAcpiGpioResource : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public PepAcpiResourceFlags Flags { get => ReadStructure<PepAcpiResourceFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(8UL)]
        public uint InterruptType { get => ReadHere<uint>(nameof(InterruptType)); set => WriteHere(nameof(InterruptType), value); }

        [Offset(12UL)]
        public uint InterruptPolarity { get => ReadHere<uint>(nameof(InterruptPolarity)); set => WriteHere(nameof(InterruptPolarity), value); }

        [Offset(16UL)]
        public uint PinConfig { get => ReadHere<uint>(nameof(PinConfig)); set => WriteHere(nameof(PinConfig), value); }

        [Offset(20UL)]
        public uint IoRestrictionType { get => ReadHere<uint>(nameof(IoRestrictionType)); set => WriteHere(nameof(IoRestrictionType), value); }

        [Offset(24UL)]
        public ushort DriveStrength { get => ReadHere<ushort>(nameof(DriveStrength)); set => WriteHere(nameof(DriveStrength), value); }

        [Offset(26UL)]
        public ushort DebounceTimeout { get => ReadHere<ushort>(nameof(DebounceTimeout)); set => WriteHere(nameof(DebounceTimeout), value); }

        [Offset(32UL)]
        public IntPtr PinTable { get => ReadHere<IntPtr>(nameof(PinTable)); set => WriteHere(nameof(PinTable), value); }

        [Offset(40UL)]
        public ushort PinCount { get => ReadHere<ushort>(nameof(PinCount)); set => WriteHere(nameof(PinCount), value); }

        [Offset(42UL)]
        public byte ResourceSourceIndex { get => ReadHere<byte>(nameof(ResourceSourceIndex)); set => WriteHere(nameof(ResourceSourceIndex), value); }

        [Offset(48UL)]
        public IntPtr ResourceSourceName { get => ReadHere<IntPtr>(nameof(ResourceSourceName)); set => WriteHere(nameof(ResourceSourceName), value); }

        [Offset(56UL)]
        public IntPtr VendorData { get => ReadHere<IntPtr>(nameof(VendorData)); set => WriteHere(nameof(VendorData), value); }

        [Offset(64UL)]
        public ushort VendorDataLength { get => ReadHere<ushort>(nameof(VendorDataLength)); set => WriteHere(nameof(VendorDataLength), value); }

        public PepAcpiGpioResource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepAcpiGpioResource>();
        }
    }
}