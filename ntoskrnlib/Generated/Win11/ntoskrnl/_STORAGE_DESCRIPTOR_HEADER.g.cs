#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _STORAGE_DESCRIPTOR_HEADER
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public uint Size;
    }
}