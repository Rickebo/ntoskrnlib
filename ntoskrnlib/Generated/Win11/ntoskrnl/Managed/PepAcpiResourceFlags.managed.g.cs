using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_RESOURCE_FLAGS")]
    public sealed class PepAcpiResourceFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint AsULong { get => ReadHere<uint>(nameof(AsULong)); set => WriteHere(nameof(AsULong), value); }

        [Offset(0UL)]
        public uint Shared { get => ReadHere<uint>(nameof(Shared)); set => WriteHere(nameof(Shared), value); }

        [Offset(0UL)]
        public uint Wake { get => ReadHere<uint>(nameof(Wake)); set => WriteHere(nameof(Wake), value); }

        [Offset(0UL)]
        public uint ResourceUsage { get => ReadHere<uint>(nameof(ResourceUsage)); set => WriteHere(nameof(ResourceUsage), value); }

        [Offset(0UL)]
        public uint SlaveMode { get => ReadHere<uint>(nameof(SlaveMode)); set => WriteHere(nameof(SlaveMode), value); }

        [Offset(0UL)]
        public uint AddressingMode { get => ReadHere<uint>(nameof(AddressingMode)); set => WriteHere(nameof(AddressingMode), value); }

        [Offset(0UL)]
        public uint SharedMode { get => ReadHere<uint>(nameof(SharedMode)); set => WriteHere(nameof(SharedMode), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public PepAcpiResourceFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepAcpiResourceFlags>();
        }
    }
}