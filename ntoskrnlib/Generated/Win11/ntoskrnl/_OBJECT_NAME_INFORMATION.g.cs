#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _OBJECT_NAME_INFORMATION
    {
        [FieldOffset(0)]
        public _UNICODE_STRING Name;
    }
}