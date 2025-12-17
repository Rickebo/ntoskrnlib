#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MI_IMAGE_ADDITIONAL_FLAGS
    {
        [FieldOffset(0)]
        public uint SizeOfHeader;
        [FieldOffset(0)]
        public uint FilesystemWantsRva;
    }
}