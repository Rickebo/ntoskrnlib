using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_VALIDBITS")]
    public sealed class WheaErrorRecordSectionDescriptorValidbits : DynamicStructure
    {
        [Offset(0UL)]
        public byte FRUId { get => ReadHere<byte>(nameof(FRUId)); set => WriteHere(nameof(FRUId), value); }

        [Offset(0UL)]
        public byte FRUText { get => ReadHere<byte>(nameof(FRUText)); set => WriteHere(nameof(FRUText), value); }

        [Offset(0UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public byte AsUCHAR { get => ReadHere<byte>(nameof(AsUCHAR)); set => WriteHere(nameof(AsUCHAR), value); }

        public WheaErrorRecordSectionDescriptorValidbits(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaErrorRecordSectionDescriptorValidbits>();
        }
    }
}