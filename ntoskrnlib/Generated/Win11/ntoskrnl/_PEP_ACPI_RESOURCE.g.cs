#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _PEP_ACPI_RESOURCE
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(0)]
        public _PEP_ACPI_IO_MEMORY_RESOURCE IoMemory;
        [FieldOffset(0)]
        public _PEP_ACPI_INTERRUPT_RESOURCE Interrupt;
        [FieldOffset(0)]
        public _PEP_ACPI_GPIO_RESOURCE Gpio;
        [FieldOffset(0)]
        public _PEP_ACPI_SPB_I2C_RESOURCE SpbI2c;
        [FieldOffset(0)]
        public _PEP_ACPI_SPB_SPI_RESOURCE SpbSpi;
        [FieldOffset(0)]
        public _PEP_ACPI_SPB_UART_RESOURCE SpbUart;
        [FieldOffset(0)]
        public _PEP_ACPI_EXTENDED_ADDRESS ExtendedAddress;
    }
}