#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _CURDIR
    {
        [FieldOffset(0)]
        public _UNICODE_STRING DosPath;
        [FieldOffset(16)]
        public IntPtr Handle;
    }
}