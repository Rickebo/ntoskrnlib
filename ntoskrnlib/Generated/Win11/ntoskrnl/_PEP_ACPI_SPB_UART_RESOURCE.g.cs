#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _PEP_ACPI_SPB_UART_RESOURCE
    {
        [FieldOffset(0)]
        public _PEP_ACPI_SPB_RESOURCE SpbCommon;
        [FieldOffset(40)]
        public uint BaudRate;
        [FieldOffset(44)]
        public ushort RxBufferSize;
        [FieldOffset(46)]
        public ushort TxBufferSize;
        [FieldOffset(48)]
        public byte Parity;
        [FieldOffset(49)]
        public byte LinesInUse;
    }
}