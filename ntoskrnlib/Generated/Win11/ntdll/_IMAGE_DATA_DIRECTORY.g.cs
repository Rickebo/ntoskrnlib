#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _IMAGE_DATA_DIRECTORY
    {
        [FieldOffset(0)]
        public uint VirtualAddress;
        [FieldOffset(4)]
        public uint Size;
    }
}