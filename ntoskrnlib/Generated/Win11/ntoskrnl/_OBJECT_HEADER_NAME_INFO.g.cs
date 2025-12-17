#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _OBJECT_HEADER_NAME_INFO
    {
        [FieldOffset(0)]
        public IntPtr Directory;
        [FieldOffset(8)]
        public _UNICODE_STRING Name;
        [FieldOffset(24)]
        public int ReferenceCount;
        [FieldOffset(28)]
        public uint Reserved;
    }
}