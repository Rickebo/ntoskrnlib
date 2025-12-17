#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _ETW_FILTER_STRING_TOKEN_ELEMENT
    {
        [FieldOffset(0)]
        public ushort Length;
        [FieldOffset(8)]
        public IntPtr String;
    }
}