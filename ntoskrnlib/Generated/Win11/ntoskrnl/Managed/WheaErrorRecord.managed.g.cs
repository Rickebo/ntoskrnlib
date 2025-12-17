using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_ERROR_RECORD")]
    public sealed class WheaErrorRecord : DynamicStructure
    {
        [Offset(0UL)]
        public WheaErrorRecordHeader Header { get => ReadStructure<WheaErrorRecordHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(128UL)]
        [Length(1)]
        public DynamicArray SectionDescriptor { get => ReadStructure<DynamicArray>(nameof(SectionDescriptor)); set => WriteStructure(nameof(SectionDescriptor), value); }

        public WheaErrorRecord(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaErrorRecord>();
        }
    }
}