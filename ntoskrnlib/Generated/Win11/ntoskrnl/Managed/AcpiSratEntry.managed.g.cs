using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ACPI_SRAT_ENTRY")]
    public sealed class AcpiSratEntry : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Length { get => ReadHere<byte>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public UnnamedTag ApicAffinity { get => ReadStructure<UnnamedTag>(nameof(ApicAffinity)); set => WriteStructure(nameof(ApicAffinity), value); }

        [Offset(2UL)]
        public UnnamedTag MemoryAffinity { get => ReadStructure<UnnamedTag>(nameof(MemoryAffinity)); set => WriteStructure(nameof(MemoryAffinity), value); }

        [Offset(2UL)]
        public UnnamedTag X2ApicAffinity { get => ReadStructure<UnnamedTag>(nameof(X2ApicAffinity)); set => WriteStructure(nameof(X2ApicAffinity), value); }

        [Offset(2UL)]
        public UnnamedTag GiccAffinity { get => ReadStructure<UnnamedTag>(nameof(GiccAffinity)); set => WriteStructure(nameof(GiccAffinity), value); }

        [Offset(2UL)]
        public UnnamedTag GicItsAffinity { get => ReadStructure<UnnamedTag>(nameof(GicItsAffinity)); set => WriteStructure(nameof(GicItsAffinity), value); }

        [Offset(2UL)]
        public UnnamedTag GenericInitiatorAffinity { get => ReadStructure<UnnamedTag>(nameof(GenericInitiatorAffinity)); set => WriteStructure(nameof(GenericInitiatorAffinity), value); }

        [Offset(2UL)]
        public UnnamedTag GenericPortAffinity { get => ReadStructure<UnnamedTag>(nameof(GenericPortAffinity)); set => WriteStructure(nameof(GenericPortAffinity), value); }

        public AcpiSratEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AcpiSratEntry>();
        }
    }
}