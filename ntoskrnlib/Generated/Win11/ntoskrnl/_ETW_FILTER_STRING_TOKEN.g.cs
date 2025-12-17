#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _ETW_FILTER_STRING_TOKEN
    {
        [FieldOffset(0)]
        public ushort Count;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _ETW_FILTER_STRING_TOKEN_ELEMENT[] Tokens;
    }
}