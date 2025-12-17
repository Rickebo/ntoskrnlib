#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _DISALLOWED_GUIDS
    {
        [FieldOffset(0)]
        public ushort Count;
        [FieldOffset(8)]
        public IntPtr Guids;
    }
}