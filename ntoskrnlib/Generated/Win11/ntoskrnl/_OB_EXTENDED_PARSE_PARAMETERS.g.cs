#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _OB_EXTENDED_PARSE_PARAMETERS
    {
        [FieldOffset(0)]
        public ushort Length;
        [FieldOffset(4)]
        public uint RestrictedAccessMask;
        [FieldOffset(8)]
        public IntPtr Silo;
    }
}