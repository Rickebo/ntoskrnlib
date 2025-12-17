using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_IO_MEMORY_RESOURCE")]
    public sealed class PepAcpiIoMemoryResource : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public byte Information { get => ReadHere<byte>(nameof(Information)); set => WriteHere(nameof(Information), value); }

        [Offset(8UL)]
        public LargeInteger MinimumAddress { get => ReadStructure<LargeInteger>(nameof(MinimumAddress)); set => WriteStructure(nameof(MinimumAddress), value); }

        [Offset(16UL)]
        public LargeInteger MaximumAddress { get => ReadStructure<LargeInteger>(nameof(MaximumAddress)); set => WriteStructure(nameof(MaximumAddress), value); }

        [Offset(24UL)]
        public uint Alignment { get => ReadHere<uint>(nameof(Alignment)); set => WriteHere(nameof(Alignment), value); }

        [Offset(28UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        public PepAcpiIoMemoryResource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepAcpiIoMemoryResource>();
        }
    }
}