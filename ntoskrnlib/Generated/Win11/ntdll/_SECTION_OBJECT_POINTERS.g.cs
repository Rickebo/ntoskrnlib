#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _SECTION_OBJECT_POINTERS
    {
        [FieldOffset(0)]
        public IntPtr DataSectionObject;
        [FieldOffset(8)]
        public IntPtr SharedCacheMap;
        [FieldOffset(16)]
        public IntPtr ImageSectionObject;
    }
}