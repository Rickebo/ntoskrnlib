#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _OBJECT_HEADER_HANDLE_INFO
    {
        [FieldOffset(0)]
        public IntPtr HandleCountDataBase;
        [FieldOffset(0)]
        public _OBJECT_HANDLE_COUNT_ENTRY SingleEntry;
    }
}