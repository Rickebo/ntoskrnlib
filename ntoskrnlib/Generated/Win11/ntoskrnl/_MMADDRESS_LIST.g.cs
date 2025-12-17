#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _MMADDRESS_LIST
    {
        [FieldOffset(0)]
        public _unnamed_tag_ u1;
        [FieldOffset(8)]
        public IntPtr EndVa;
    }
}