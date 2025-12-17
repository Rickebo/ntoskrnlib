#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _CC_FILE_SIZES
    {
        [FieldOffset(0)]
        public _LARGE_INTEGER AllocationSize;
        [FieldOffset(8)]
        public _LARGE_INTEGER FileSize;
        [FieldOffset(16)]
        public _LARGE_INTEGER ValidDataLength;
    }
}