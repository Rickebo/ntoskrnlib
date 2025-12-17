using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_SPB_UART_RESOURCE")]
    public sealed class PepAcpiSpbUartResource : DynamicStructure
    {
        [Offset(0UL)]
        public PepAcpiSpbResource SpbCommon { get => ReadStructure<PepAcpiSpbResource>(nameof(SpbCommon)); set => WriteStructure(nameof(SpbCommon), value); }

        [Offset(40UL)]
        public uint BaudRate { get => ReadHere<uint>(nameof(BaudRate)); set => WriteHere(nameof(BaudRate), value); }

        [Offset(44UL)]
        public ushort RxBufferSize { get => ReadHere<ushort>(nameof(RxBufferSize)); set => WriteHere(nameof(RxBufferSize), value); }

        [Offset(46UL)]
        public ushort TxBufferSize { get => ReadHere<ushort>(nameof(TxBufferSize)); set => WriteHere(nameof(TxBufferSize), value); }

        [Offset(48UL)]
        public byte Parity { get => ReadHere<byte>(nameof(Parity)); set => WriteHere(nameof(Parity), value); }

        [Offset(49UL)]
        public byte LinesInUse { get => ReadHere<byte>(nameof(LinesInUse)); set => WriteHere(nameof(LinesInUse), value); }

        public PepAcpiSpbUartResource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepAcpiSpbUartResource>();
        }
    }
}