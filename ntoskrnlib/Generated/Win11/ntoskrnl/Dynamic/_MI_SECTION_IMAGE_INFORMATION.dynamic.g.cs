using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SECTION_IMAGE_INFORMATION")]
    public sealed class _MI_SECTION_IMAGE_INFORMATION : DynamicStructure
    {
        public _SECTION_IMAGE_INFORMATION ExportedImageInformation { get; }
        public _MI_EXTRA_IMAGE_INFORMATION InternalImageInformation { get; }

        public _MI_SECTION_IMAGE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SECTION_IMAGE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SECTION_IMAGE_INFORMATION.ExportedImageInformation),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SECTION_IMAGE_INFORMATION.InternalImageInformation),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_MI_SECTION_IMAGE_INFORMATION>((mem, ptr) => new _MI_SECTION_IMAGE_INFORMATION(mem, ptr), offsets);
        }
    }
}