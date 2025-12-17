using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_RESOURCE")]
    public sealed class PepAcpiResource : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(0UL)]
        public PepAcpiIoMemoryResource IoMemory { get => ReadStructure<PepAcpiIoMemoryResource>(nameof(IoMemory)); set => WriteStructure(nameof(IoMemory), value); }

        [Offset(0UL)]
        public PepAcpiInterruptResource Interrupt { get => ReadStructure<PepAcpiInterruptResource>(nameof(Interrupt)); set => WriteStructure(nameof(Interrupt), value); }

        [Offset(0UL)]
        public PepAcpiGpioResource Gpio { get => ReadStructure<PepAcpiGpioResource>(nameof(Gpio)); set => WriteStructure(nameof(Gpio), value); }

        [Offset(0UL)]
        public PepAcpiSpbI2CResource SpbI2c { get => ReadStructure<PepAcpiSpbI2CResource>(nameof(SpbI2c)); set => WriteStructure(nameof(SpbI2c), value); }

        [Offset(0UL)]
        public PepAcpiSpbSpiResource SpbSpi { get => ReadStructure<PepAcpiSpbSpiResource>(nameof(SpbSpi)); set => WriteStructure(nameof(SpbSpi), value); }

        [Offset(0UL)]
        public PepAcpiSpbUartResource SpbUart { get => ReadStructure<PepAcpiSpbUartResource>(nameof(SpbUart)); set => WriteStructure(nameof(SpbUart), value); }

        [Offset(0UL)]
        public PepAcpiExtendedAddress ExtendedAddress { get => ReadStructure<PepAcpiExtendedAddress>(nameof(ExtendedAddress)); set => WriteStructure(nameof(ExtendedAddress), value); }

        public PepAcpiResource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepAcpiResource>();
        }
    }
}