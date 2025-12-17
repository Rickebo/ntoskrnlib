using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR")]
    public sealed class WheaErrorRecordSectionDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public uint SectionOffset { get => ReadHere<uint>(nameof(SectionOffset)); set => WriteHere(nameof(SectionOffset), value); }

        [Offset(4UL)]
        public uint SectionLength { get => ReadHere<uint>(nameof(SectionLength)); set => WriteHere(nameof(SectionLength), value); }

        [Offset(8UL)]
        public WheaRevision Revision { get => ReadStructure<WheaRevision>(nameof(Revision)); set => WriteStructure(nameof(Revision), value); }

        [Offset(10UL)]
        public WheaErrorRecordSectionDescriptorValidbits ValidBits { get => ReadStructure<WheaErrorRecordSectionDescriptorValidbits>(nameof(ValidBits)); set => WriteStructure(nameof(ValidBits), value); }

        [Offset(11UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(12UL)]
        public WheaErrorRecordSectionDescriptorFlags Flags { get => ReadStructure<WheaErrorRecordSectionDescriptorFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(16UL)]
        public Guid SectionType { get => ReadStructure<Guid>(nameof(SectionType)); set => WriteStructure(nameof(SectionType), value); }

        [Offset(32UL)]
        public Guid FRUId { get => ReadStructure<Guid>(nameof(FRUId)); set => WriteStructure(nameof(FRUId), value); }

        [Offset(48UL)]
        public uint SectionSeverity { get => ReadHere<uint>(nameof(SectionSeverity)); set => WriteHere(nameof(SectionSeverity), value); }

        [Offset(52UL)]
        [Length(20)]
        public DynamicArray FRUText { get => ReadStructure<DynamicArray>(nameof(FRUText)); set => WriteStructure(nameof(FRUText), value); }

        public WheaErrorRecordSectionDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaErrorRecordSectionDescriptor>();
        }
    }
}