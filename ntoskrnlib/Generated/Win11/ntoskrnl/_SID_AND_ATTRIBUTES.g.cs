#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _SID_AND_ATTRIBUTES
    {
        [FieldOffset(0)]
        public IntPtr Sid;
        [FieldOffset(8)]
        public uint Attributes;
    }
}