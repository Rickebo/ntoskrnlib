using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ACPI_SRAT")]
    public sealed class AcpiSrat : DynamicStructure
    {
        [Offset(0UL)]
        public DescriptionHeader Header { get => ReadStructure<DescriptionHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(36UL)]
        public uint TableRevision { get => ReadHere<uint>(nameof(TableRevision)); set => WriteHere(nameof(TableRevision), value); }

        [Offset(40UL)]
        [Length(2)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        public AcpiSrat(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AcpiSrat>();
        }
    }
}