using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_INTERRUPT_RESOURCE")]
    public sealed class PepAcpiInterruptResource : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public uint InterruptType { get => ReadHere<uint>(nameof(InterruptType)); set => WriteHere(nameof(InterruptType), value); }

        [Offset(8UL)]
        public uint InterruptPolarity { get => ReadHere<uint>(nameof(InterruptPolarity)); set => WriteHere(nameof(InterruptPolarity), value); }

        [Offset(12UL)]
        public PepAcpiResourceFlags Flags { get => ReadStructure<PepAcpiResourceFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(16UL)]
        public byte Count { get => ReadHere<byte>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(24UL)]
        public IntPtr Pins { get => ReadHere<IntPtr>(nameof(Pins)); set => WriteHere(nameof(Pins), value); }

        public PepAcpiInterruptResource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepAcpiInterruptResource>();
        }
    }
}