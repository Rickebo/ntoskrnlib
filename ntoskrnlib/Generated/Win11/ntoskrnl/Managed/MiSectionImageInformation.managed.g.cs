using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SECTION_IMAGE_INFORMATION")]
    public sealed class MiSectionImageInformation : DynamicStructure
    {
        [Offset(0UL)]
        public SectionImageInformation ExportedImageInformation { get => ReadStructure<SectionImageInformation>(nameof(ExportedImageInformation)); set => WriteStructure(nameof(ExportedImageInformation), value); }

        [Offset(64UL)]
        public MiExtraImageInformation InternalImageInformation { get => ReadStructure<MiExtraImageInformation>(nameof(InternalImageInformation)); set => WriteStructure(nameof(InternalImageInformation), value); }

        public MiSectionImageInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSectionImageInformation>();
        }
    }
}