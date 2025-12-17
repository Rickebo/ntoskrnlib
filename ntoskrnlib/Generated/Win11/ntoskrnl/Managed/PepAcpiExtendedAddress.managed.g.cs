using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_EXTENDED_ADDRESS")]
    public sealed class PepAcpiExtendedAddress : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public PepAcpiResourceFlags Flags { get => ReadStructure<PepAcpiResourceFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(8UL)]
        public byte ResourceFlags { get => ReadHere<byte>(nameof(ResourceFlags)); set => WriteHere(nameof(ResourceFlags), value); }

        [Offset(9UL)]
        public byte GeneralFlags { get => ReadHere<byte>(nameof(GeneralFlags)); set => WriteHere(nameof(GeneralFlags), value); }

        [Offset(10UL)]
        public byte TypeSpecificFlags { get => ReadHere<byte>(nameof(TypeSpecificFlags)); set => WriteHere(nameof(TypeSpecificFlags), value); }

        [Offset(11UL)]
        public byte RevisionId { get => ReadHere<byte>(nameof(RevisionId)); set => WriteHere(nameof(RevisionId), value); }

        [Offset(12UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(16UL)]
        public ulong Granularity { get => ReadHere<ulong>(nameof(Granularity)); set => WriteHere(nameof(Granularity), value); }

        [Offset(24UL)]
        public ulong MinimumAddress { get => ReadHere<ulong>(nameof(MinimumAddress)); set => WriteHere(nameof(MinimumAddress), value); }

        [Offset(32UL)]
        public ulong MaximumAddress { get => ReadHere<ulong>(nameof(MaximumAddress)); set => WriteHere(nameof(MaximumAddress), value); }

        [Offset(40UL)]
        public ulong TranslationAddress { get => ReadHere<ulong>(nameof(TranslationAddress)); set => WriteHere(nameof(TranslationAddress), value); }

        [Offset(48UL)]
        public ulong AddressLength { get => ReadHere<ulong>(nameof(AddressLength)); set => WriteHere(nameof(AddressLength), value); }

        [Offset(56UL)]
        public ulong TypeAttribute { get => ReadHere<ulong>(nameof(TypeAttribute)); set => WriteHere(nameof(TypeAttribute), value); }

        [Offset(64UL)]
        public IntPtr DescriptorName { get => ReadHere<IntPtr>(nameof(DescriptorName)); set => WriteHere(nameof(DescriptorName), value); }

        public PepAcpiExtendedAddress(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepAcpiExtendedAddress>();
        }
    }
}