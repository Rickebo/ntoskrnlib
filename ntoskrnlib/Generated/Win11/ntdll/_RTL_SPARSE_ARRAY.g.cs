#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _RTL_SPARSE_ARRAY
    {
        [FieldOffset(0)]
        public ulong ElementCount;
        [FieldOffset(8)]
        public uint ElementSizeShift;
        [FieldOffset(16)]
        public _RTL_CSPARSE_BITMAP Bitmap;
    }
}