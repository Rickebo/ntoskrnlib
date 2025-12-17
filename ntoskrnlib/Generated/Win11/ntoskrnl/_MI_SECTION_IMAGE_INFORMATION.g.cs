#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _MI_SECTION_IMAGE_INFORMATION
    {
        [FieldOffset(0)]
        public _SECTION_IMAGE_INFORMATION ExportedImageInformation;
        [FieldOffset(64)]
        public _MI_EXTRA_IMAGE_INFORMATION InternalImageInformation;
    }
}