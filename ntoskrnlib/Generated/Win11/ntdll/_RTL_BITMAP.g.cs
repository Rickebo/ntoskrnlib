#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _RTL_BITMAP
    {
        [FieldOffset(0)]
        public uint SizeOfBitMap;
        [FieldOffset(8)]
        public IntPtr Buffer;
    }
}