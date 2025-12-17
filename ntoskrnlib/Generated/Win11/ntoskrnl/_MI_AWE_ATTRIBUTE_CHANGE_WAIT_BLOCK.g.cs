#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _MI_AWE_ATTRIBUTE_CHANGE_WAIT_BLOCK
    {
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(8)]
        public IntPtr BasePfn;
        [FieldOffset(16)]
        public _KGATE Gate;
    }
}