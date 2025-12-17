#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PS_TRUSTLET_ATTRIBUTE_DATA
    {
        [FieldOffset(0)]
        public _PS_TRUSTLET_ATTRIBUTE_HEADER Header;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ulong[] Data;
    }
}