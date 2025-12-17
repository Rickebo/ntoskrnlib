#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HEAP_SPAN
    {
        [FieldOffset(0)]
        public IntPtr Address;
        [FieldOffset(8)]
        public ulong Size;
    }
}