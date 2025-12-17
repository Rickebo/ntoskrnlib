#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _OB_EXTENDED_USER_INFO
    {
        [FieldOffset(0)]
        public IntPtr Context1;
        [FieldOffset(8)]
        public IntPtr Context2;
    }
}