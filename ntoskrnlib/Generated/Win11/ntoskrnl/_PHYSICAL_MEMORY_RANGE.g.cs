#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PHYSICAL_MEMORY_RANGE
    {
        [FieldOffset(0)]
        public _LARGE_INTEGER BaseAddress;
        [FieldOffset(8)]
        public _LARGE_INTEGER NumberOfBytes;
    }
}