#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _VF_ADDRESS_RANGE
    {
        [FieldOffset(0)]
        public IntPtr Start;
        [FieldOffset(8)]
        public IntPtr End;
    }
}